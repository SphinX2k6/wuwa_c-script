using System;
using System.Runtime.InteropServices;

namespace System.Diagnostics.Tracing
{
	// Token: 0x0200091D RID: 2333
	internal struct DataCollector
	{
		// Token: 0x06008D6E RID: 36206 RVA: 0x0015CDB4 File Offset: 0x0015AFB4
		internal unsafe void Enable(byte* scratch, int scratchSize, EventSource.EventData* datas, int dataCount, GCHandle* pins, int pinCount)
		{
			this.datasStart = datas;
			this.scratchEnd = scratch + scratchSize;
			this.datasEnd = datas + dataCount;
			this.pinsEnd = pins + pinCount;
			this.scratch = scratch;
			this.datas = datas;
			this.pins = pins;
			this.writingScalars = false;
		}

		// Token: 0x06008D6F RID: 36207 RVA: 0x0015CE13 File Offset: 0x0015B013
		internal void Disable()
		{
			this = default(DataCollector);
		}

		// Token: 0x06008D70 RID: 36208 RVA: 0x0015CE1C File Offset: 0x0015B01C
		internal unsafe EventSource.EventData* Finish()
		{
			this.ScalarsEnd();
			return this.datas;
		}

		// Token: 0x06008D71 RID: 36209 RVA: 0x0015CE2C File Offset: 0x0015B02C
		internal unsafe void AddScalar(void* value, int size)
		{
			if (this.bufferNesting != 0)
			{
				int num = this.bufferPos;
				int num2;
				checked
				{
					this.bufferPos += size;
					this.EnsureBuffer();
					num2 = 0;
				}
				while (num2 != size)
				{
					this.buffer[num] = ((byte*)value)[num2];
					num2++;
					num++;
				}
				return;
			}
			byte* ptr = this.scratch;
			byte* ptr2 = ptr + size;
			if (this.scratchEnd < ptr2)
			{
				throw new IndexOutOfRangeException(SR.EventSource_AddScalarOutOfRange);
			}
			this.ScalarsBegin();
			this.scratch = ptr2;
			for (int num3 = 0; num3 != size; num3++)
			{
				ptr[num3] = ((byte*)value)[num3];
			}
		}

		// Token: 0x06008D72 RID: 36210 RVA: 0x0015CEC4 File Offset: 0x0015B0C4
		internal unsafe void AddNullTerminatedString(string value)
		{
			if (value == null)
			{
				value = string.Empty;
			}
			int num = value.IndexOf('\0');
			if (num < 0)
			{
				num = value.Length;
			}
			int num2 = (num + 1) * 2;
			if (this.bufferNesting != 0)
			{
				this.EnsureBuffer(num2);
			}
			if (this.bufferNesting == 0)
			{
				this.ScalarsEnd();
				this.PinArray(value, num2);
				return;
			}
			int startIndex = this.bufferPos;
			checked
			{
				this.bufferPos += num2;
				this.EnsureBuffer();
			}
			IntPtr source;
			if (value == null)
			{
				source = (IntPtr)((UIntPtr)0);
			}
			else
			{
				fixed (char* ptr = value.GetPinnableReference())
				{
					source = ptr;
				}
			}
			Marshal.Copy(source, this.buffer, startIndex, num2);
			char* ptr = null;
		}

		// Token: 0x06008D73 RID: 36211 RVA: 0x0015CF58 File Offset: 0x0015B158
		internal unsafe void AddArray(Array value, int length, int itemSize)
		{
			if (length > 65535)
			{
				length = 65535;
			}
			int num = length * itemSize;
			if (this.bufferNesting != 0)
			{
				this.EnsureBuffer(num + 2);
			}
			this.AddScalar((void*)(&length), 2);
			checked
			{
				if (length != 0)
				{
					if (this.bufferNesting == 0)
					{
						this.ScalarsEnd();
						this.PinArray(value, num);
						return;
					}
					int dstOffset = this.bufferPos;
					this.bufferPos += num;
					this.EnsureBuffer();
					Buffer.BlockCopy(value, 0, this.buffer, dstOffset, num);
				}
			}
		}

		// Token: 0x06008D74 RID: 36212 RVA: 0x0015CFD7 File Offset: 0x0015B1D7
		internal int BeginBufferedArray()
		{
			this.BeginBuffered();
			this.bufferPos += 2;
			return this.bufferPos;
		}

		// Token: 0x06008D75 RID: 36213 RVA: 0x0015CFF3 File Offset: 0x0015B1F3
		internal void EndBufferedArray(int bookmark, int count)
		{
			this.EnsureBuffer();
			this.buffer[bookmark - 2] = (byte)count;
			this.buffer[bookmark - 1] = (byte)(count >> 8);
			this.EndBuffered();
		}

		// Token: 0x06008D76 RID: 36214 RVA: 0x0015D01B File Offset: 0x0015B21B
		internal void BeginBuffered()
		{
			this.ScalarsEnd();
			this.bufferNesting++;
		}

		// Token: 0x06008D77 RID: 36215 RVA: 0x0015D031 File Offset: 0x0015B231
		internal void EndBuffered()
		{
			this.bufferNesting--;
			if (this.bufferNesting == 0)
			{
				this.EnsureBuffer();
				this.PinArray(this.buffer, this.bufferPos);
				this.buffer = null;
				this.bufferPos = 0;
			}
		}

		// Token: 0x06008D78 RID: 36216 RVA: 0x0015D070 File Offset: 0x0015B270
		private void EnsureBuffer()
		{
			int num = this.bufferPos;
			if (this.buffer == null || this.buffer.Length < num)
			{
				this.GrowBuffer(num);
			}
		}

		// Token: 0x06008D79 RID: 36217 RVA: 0x0015D0A0 File Offset: 0x0015B2A0
		private void EnsureBuffer(int additionalSize)
		{
			int num = this.bufferPos + additionalSize;
			if (this.buffer == null || this.buffer.Length < num)
			{
				this.GrowBuffer(num);
			}
		}

		// Token: 0x06008D7A RID: 36218 RVA: 0x0015D0D0 File Offset: 0x0015B2D0
		private void GrowBuffer(int required)
		{
			int num = (this.buffer == null) ? 64 : this.buffer.Length;
			do
			{
				num *= 2;
			}
			while (num < required);
			Array.Resize<byte>(ref this.buffer, num);
		}

		// Token: 0x06008D7B RID: 36219 RVA: 0x0015D108 File Offset: 0x0015B308
		private unsafe void PinArray(object value, int size)
		{
			GCHandle* ptr = this.pins;
			if (this.pinsEnd == ptr)
			{
				throw new IndexOutOfRangeException(SR.EventSource_PinArrayOutOfRange);
			}
			EventSource.EventData* ptr2 = this.datas;
			if (this.datasEnd == ptr2)
			{
				throw new IndexOutOfRangeException(SR.EventSource_DataDescriptorsOutOfRange);
			}
			this.pins = ptr + 1;
			this.datas = ptr2 + 1;
			*ptr = GCHandle.Alloc(value, GCHandleType.Pinned);
			ptr2->DataPointer = ptr->AddrOfPinnedObject();
			ptr2->m_Size = size;
		}

		// Token: 0x06008D7C RID: 36220 RVA: 0x0015D188 File Offset: 0x0015B388
		private unsafe void ScalarsBegin()
		{
			if (!this.writingScalars)
			{
				EventSource.EventData* ptr = this.datas;
				if (this.datasEnd == ptr)
				{
					throw new IndexOutOfRangeException(SR.EventSource_DataDescriptorsOutOfRange);
				}
				ptr->DataPointer = this.scratch;
				this.writingScalars = true;
			}
		}

		// Token: 0x06008D7D RID: 36221 RVA: 0x0015D1CC File Offset: 0x0015B3CC
		private unsafe void ScalarsEnd()
		{
			if (this.writingScalars)
			{
				EventSource.EventData* ptr = this.datas;
				ptr->m_Size = (this.scratch - checked((UIntPtr)ptr->m_Ptr)) / 1;
				this.datas = ptr + 1;
				this.writingScalars = false;
			}
		}

		// Token: 0x040020D1 RID: 8401
		[ThreadStatic]
		internal static DataCollector ThreadInstance;

		// Token: 0x040020D2 RID: 8402
		private unsafe byte* scratchEnd;

		// Token: 0x040020D3 RID: 8403
		private unsafe EventSource.EventData* datasEnd;

		// Token: 0x040020D4 RID: 8404
		private unsafe GCHandle* pinsEnd;

		// Token: 0x040020D5 RID: 8405
		private unsafe EventSource.EventData* datasStart;

		// Token: 0x040020D6 RID: 8406
		private unsafe byte* scratch;

		// Token: 0x040020D7 RID: 8407
		private unsafe EventSource.EventData* datas;

		// Token: 0x040020D8 RID: 8408
		private unsafe GCHandle* pins;

		// Token: 0x040020D9 RID: 8409
		private byte[] buffer;

		// Token: 0x040020DA RID: 8410
		private int bufferPos;

		// Token: 0x040020DB RID: 8411
		private int bufferNesting;

		// Token: 0x040020DC RID: 8412
		private bool writingScalars;
	}
}
