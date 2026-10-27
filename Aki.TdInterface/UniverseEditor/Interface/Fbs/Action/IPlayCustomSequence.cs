using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CDB RID: 27867
	public struct IPlayCustomSequence : IFlatbufferObject
	{
		// Token: 0x1700CF86 RID: 53126
		// (get) Token: 0x06031200 RID: 201216 RVA: 0x006AA7A3 File Offset: 0x006A89A3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031201 RID: 201217 RVA: 0x006AA7B0 File Offset: 0x006A89B0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031202 RID: 201218 RVA: 0x006AA7B8 File Offset: 0x006A89B8
		public static IPlayCustomSequence GetRootAsIPlayCustomSequence(ByteBuffer _bb)
		{
			return IPlayCustomSequence.GetRootAsIPlayCustomSequence(_bb, default(IPlayCustomSequence));
		}

		// Token: 0x06031203 RID: 201219 RVA: 0x006AA7D4 File Offset: 0x006A89D4
		public static IPlayCustomSequence GetRootAsIPlayCustomSequence(ByteBuffer _bb, IPlayCustomSequence obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031204 RID: 201220 RVA: 0x006AA7F1 File Offset: 0x006A89F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031205 RID: 201221 RVA: 0x006AA800 File Offset: 0x006A8A00
		public IPlayCustomSequence __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CF87 RID: 53127
		// (get) Token: 0x06031206 RID: 201222 RVA: 0x006AA810 File Offset: 0x006A8A10
		public int CustomSeqId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031207 RID: 201223 RVA: 0x006AA84C File Offset: 0x006A8A4C
		public int WhoIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700CF88 RID: 53128
		// (get) Token: 0x06031208 RID: 201224 RVA: 0x006AA88C File Offset: 0x006A8A8C
		public int WhoIdsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06031209 RID: 201225 RVA: 0x006AA8B7 File Offset: 0x006A8AB7
		public Span<int> GetWhoIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0603120A RID: 201226 RVA: 0x006AA8C6 File Offset: 0x006A8AC6
		public int[] GetWhoIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700CF89 RID: 53129
		// (get) Token: 0x0603120B RID: 201227 RVA: 0x006AA8D4 File Offset: 0x006A8AD4
		public bool ResetCamera
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CF8A RID: 53130
		// (get) Token: 0x0603120C RID: 201228 RVA: 0x006AA914 File Offset: 0x006A8B14
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603120D RID: 201229 RVA: 0x006AA951 File Offset: 0x006A8B51
		public static Offset<IPlayCustomSequence> CreateIPlayCustomSequence(FlatBufferBuilder builder, int CustomSeqId = 0, VectorOffset WhoIdsOffset = default(VectorOffset), bool ResetCamera = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IPlayCustomSequence.AddWhoIds(builder, WhoIdsOffset);
			IPlayCustomSequence.AddCustomSeqId(builder, CustomSeqId);
			IPlayCustomSequence.AddNullMask(builder, NullMask);
			IPlayCustomSequence.AddResetCamera(builder, ResetCamera);
			return IPlayCustomSequence.EndIPlayCustomSequence(builder);
		}

		// Token: 0x0603120E RID: 201230 RVA: 0x006AA97D File Offset: 0x006A8B7D
		public static void StartIPlayCustomSequence(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0603120F RID: 201231 RVA: 0x006AA986 File Offset: 0x006A8B86
		public static void AddCustomSeqId(FlatBufferBuilder builder, int customSeqId)
		{
			builder.AddInt(0, customSeqId, 0);
		}

		// Token: 0x06031210 RID: 201232 RVA: 0x006AA991 File Offset: 0x006A8B91
		public static void AddWhoIds(FlatBufferBuilder builder, VectorOffset whoIdsOffset)
		{
			builder.AddOffset(1, whoIdsOffset.Value, 0);
		}

		// Token: 0x06031211 RID: 201233 RVA: 0x006AA9A4 File Offset: 0x006A8BA4
		public static VectorOffset CreateWhoIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06031212 RID: 201234 RVA: 0x006AA9DB File Offset: 0x006A8BDB
		public static VectorOffset CreateWhoIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06031213 RID: 201235 RVA: 0x006AA9F5 File Offset: 0x006A8BF5
		public static VectorOffset CreateWhoIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06031214 RID: 201236 RVA: 0x006AAA13 File Offset: 0x006A8C13
		public static VectorOffset CreateWhoIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06031215 RID: 201237 RVA: 0x006AAA2C File Offset: 0x006A8C2C
		public static void StartWhoIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06031216 RID: 201238 RVA: 0x006AAA37 File Offset: 0x006A8C37
		public static void AddResetCamera(FlatBufferBuilder builder, bool resetCamera)
		{
			builder.AddBool(2, resetCamera, false);
		}

		// Token: 0x06031217 RID: 201239 RVA: 0x006AAA42 File Offset: 0x006A8C42
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06031218 RID: 201240 RVA: 0x006AAA4D File Offset: 0x006A8C4D
		public static Offset<IPlayCustomSequence> EndIPlayCustomSequence(FlatBufferBuilder builder)
		{
			return new Offset<IPlayCustomSequence>(builder.EndTable());
		}

		// Token: 0x06031219 RID: 201241 RVA: 0x006AAA5C File Offset: 0x006A8C5C
		public IPlayCustomSequenceT UnPack()
		{
			IPlayCustomSequenceT playCustomSequenceT = new IPlayCustomSequenceT();
			this.UnPackTo(playCustomSequenceT);
			return playCustomSequenceT;
		}

		// Token: 0x0603121A RID: 201242 RVA: 0x006AAA78 File Offset: 0x006A8C78
		public void UnPackTo(IPlayCustomSequenceT _o)
		{
			_o.CustomSeqId = this.CustomSeqId;
			_o.WhoIds = new List<int>();
			for (int i = 0; i < this.WhoIdsLength; i++)
			{
				_o.WhoIds.Add(this.WhoIds(i));
			}
			_o.ResetCamera = this.ResetCamera;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603121B RID: 201243 RVA: 0x006AAAD8 File Offset: 0x006A8CD8
		public static Offset<IPlayCustomSequence> Pack(FlatBufferBuilder builder, IPlayCustomSequenceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayCustomSequence>);
			}
			VectorOffset whoIdsOffset = default(VectorOffset);
			if (_o.WhoIds != null)
			{
				int[] data = _o.WhoIds.ToArray();
				whoIdsOffset = IPlayCustomSequence.CreateWhoIdsVector(builder, data);
			}
			return IPlayCustomSequence.CreateIPlayCustomSequence(builder, _o.CustomSeqId, whoIdsOffset, _o.ResetCamera, _o.NullMask);
		}

		// Token: 0x0401164A RID: 71242
		private Table __p;
	}
}
