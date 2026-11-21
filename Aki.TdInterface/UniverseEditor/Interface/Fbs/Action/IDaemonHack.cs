using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B93 RID: 27539
	public struct IDaemonHack : IFlatbufferObject
	{
		// Token: 0x1700CA1D RID: 51741
		// (get) Token: 0x0602F65F RID: 194143 RVA: 0x00677A26 File Offset: 0x00675C26
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F660 RID: 194144 RVA: 0x00677A33 File Offset: 0x00675C33
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F661 RID: 194145 RVA: 0x00677A3C File Offset: 0x00675C3C
		public static IDaemonHack GetRootAsIDaemonHack(ByteBuffer _bb)
		{
			return IDaemonHack.GetRootAsIDaemonHack(_bb, default(IDaemonHack));
		}

		// Token: 0x0602F662 RID: 194146 RVA: 0x00677A58 File Offset: 0x00675C58
		public static IDaemonHack GetRootAsIDaemonHack(ByteBuffer _bb, IDaemonHack obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F663 RID: 194147 RVA: 0x00677A75 File Offset: 0x00675C75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F664 RID: 194148 RVA: 0x00677A84 File Offset: 0x00675C84
		public IDaemonHack __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA1E RID: 51742
		// (get) Token: 0x0602F665 RID: 194149 RVA: 0x00677A94 File Offset: 0x00675C94
		public ESimpleGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESimpleGameplayType.Cipher;
				}
				return (ESimpleGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F666 RID: 194150 RVA: 0x00677AD0 File Offset: 0x00675CD0
		public int Ids(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700CA1F RID: 51743
		// (get) Token: 0x0602F667 RID: 194151 RVA: 0x00677B10 File Offset: 0x00675D10
		public int IdsLength
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

		// Token: 0x0602F668 RID: 194152 RVA: 0x00677B3B File Offset: 0x00675D3B
		public Span<int> GetIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0602F669 RID: 194153 RVA: 0x00677B4A File Offset: 0x00675D4A
		public int[] GetIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700CA20 RID: 51744
		// (get) Token: 0x0602F66A RID: 194154 RVA: 0x00677B58 File Offset: 0x00675D58
		public bool FinishOnClose
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CA21 RID: 51745
		// (get) Token: 0x0602F66B RID: 194155 RVA: 0x00677B98 File Offset: 0x00675D98
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

		// Token: 0x0602F66C RID: 194156 RVA: 0x00677BD5 File Offset: 0x00675DD5
		public static Offset<IDaemonHack> CreateIDaemonHack(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, VectorOffset IdsOffset = default(VectorOffset), bool FinishOnClose = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IDaemonHack.AddIds(builder, IdsOffset);
			IDaemonHack.AddNullMask(builder, NullMask);
			IDaemonHack.AddFinishOnClose(builder, FinishOnClose);
			IDaemonHack.AddType(builder, Type);
			return IDaemonHack.EndIDaemonHack(builder);
		}

		// Token: 0x0602F66D RID: 194157 RVA: 0x00677C01 File Offset: 0x00675E01
		public static void StartIDaemonHack(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602F66E RID: 194158 RVA: 0x00677C0A File Offset: 0x00675E0A
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F66F RID: 194159 RVA: 0x00677C15 File Offset: 0x00675E15
		public static void AddIds(FlatBufferBuilder builder, VectorOffset idsOffset)
		{
			builder.AddOffset(1, idsOffset.Value, 0);
		}

		// Token: 0x0602F670 RID: 194160 RVA: 0x00677C28 File Offset: 0x00675E28
		public static VectorOffset CreateIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602F671 RID: 194161 RVA: 0x00677C5F File Offset: 0x00675E5F
		public static VectorOffset CreateIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F672 RID: 194162 RVA: 0x00677C79 File Offset: 0x00675E79
		public static VectorOffset CreateIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F673 RID: 194163 RVA: 0x00677C97 File Offset: 0x00675E97
		public static VectorOffset CreateIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602F674 RID: 194164 RVA: 0x00677CB0 File Offset: 0x00675EB0
		public static void StartIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602F675 RID: 194165 RVA: 0x00677CBB File Offset: 0x00675EBB
		public static void AddFinishOnClose(FlatBufferBuilder builder, bool finishOnClose)
		{
			builder.AddBool(2, finishOnClose, false);
		}

		// Token: 0x0602F676 RID: 194166 RVA: 0x00677CC6 File Offset: 0x00675EC6
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602F677 RID: 194167 RVA: 0x00677CD1 File Offset: 0x00675ED1
		public static Offset<IDaemonHack> EndIDaemonHack(FlatBufferBuilder builder)
		{
			return new Offset<IDaemonHack>(builder.EndTable());
		}

		// Token: 0x0602F678 RID: 194168 RVA: 0x00677CE0 File Offset: 0x00675EE0
		public IDaemonHackT UnPack()
		{
			IDaemonHackT daemonHackT = new IDaemonHackT();
			this.UnPackTo(daemonHackT);
			return daemonHackT;
		}

		// Token: 0x0602F679 RID: 194169 RVA: 0x00677CFC File Offset: 0x00675EFC
		public void UnPackTo(IDaemonHackT _o)
		{
			_o.Type = this.Type;
			_o.Ids = new List<int>();
			for (int i = 0; i < this.IdsLength; i++)
			{
				_o.Ids.Add(this.Ids(i));
			}
			_o.FinishOnClose = this.FinishOnClose;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602F67A RID: 194170 RVA: 0x00677D5C File Offset: 0x00675F5C
		public static Offset<IDaemonHack> Pack(FlatBufferBuilder builder, IDaemonHackT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDaemonHack>);
			}
			VectorOffset idsOffset = default(VectorOffset);
			if (_o.Ids != null)
			{
				int[] data = _o.Ids.ToArray();
				idsOffset = IDaemonHack.CreateIdsVector(builder, data);
			}
			return IDaemonHack.CreateIDaemonHack(builder, _o.Type, idsOffset, _o.FinishOnClose, _o.NullMask);
		}

		// Token: 0x0401198C RID: 72076
		private Table __p;
	}
}
