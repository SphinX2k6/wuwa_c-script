using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006525 RID: 25893
	public struct IDaemonHack : IFlatbufferObject
	{
		// Token: 0x1700C08B RID: 49291
		// (get) Token: 0x0602CEC1 RID: 184001 RVA: 0x0062B57A File Offset: 0x0062977A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CEC2 RID: 184002 RVA: 0x0062B587 File Offset: 0x00629787
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CEC3 RID: 184003 RVA: 0x0062B590 File Offset: 0x00629790
		public static IDaemonHack GetRootAsIDaemonHack(ByteBuffer _bb)
		{
			return IDaemonHack.GetRootAsIDaemonHack(_bb, default(IDaemonHack));
		}

		// Token: 0x0602CEC4 RID: 184004 RVA: 0x0062B5AC File Offset: 0x006297AC
		public static IDaemonHack GetRootAsIDaemonHack(ByteBuffer _bb, IDaemonHack obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CEC5 RID: 184005 RVA: 0x0062B5C9 File Offset: 0x006297C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CEC6 RID: 184006 RVA: 0x0062B5D8 File Offset: 0x006297D8
		public IDaemonHack __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C08C RID: 49292
		// (get) Token: 0x0602CEC7 RID: 184007 RVA: 0x0062B5E8 File Offset: 0x006297E8
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

		// Token: 0x0602CEC8 RID: 184008 RVA: 0x0062B624 File Offset: 0x00629824
		public int Ids(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C08D RID: 49293
		// (get) Token: 0x0602CEC9 RID: 184009 RVA: 0x0062B664 File Offset: 0x00629864
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

		// Token: 0x0602CECA RID: 184010 RVA: 0x0062B68F File Offset: 0x0062988F
		public Span<int> GetIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0602CECB RID: 184011 RVA: 0x0062B69E File Offset: 0x0062989E
		public int[] GetIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700C08E RID: 49294
		// (get) Token: 0x0602CECC RID: 184012 RVA: 0x0062B6AC File Offset: 0x006298AC
		public bool FinishOnClose
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C08F RID: 49295
		// (get) Token: 0x0602CECD RID: 184013 RVA: 0x0062B6EC File Offset: 0x006298EC
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

		// Token: 0x0602CECE RID: 184014 RVA: 0x0062B729 File Offset: 0x00629929
		public static Offset<IDaemonHack> CreateIDaemonHack(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, VectorOffset IdsOffset = default(VectorOffset), bool FinishOnClose = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IDaemonHack.AddIds(builder, IdsOffset);
			IDaemonHack.AddNullMask(builder, NullMask);
			IDaemonHack.AddFinishOnClose(builder, FinishOnClose);
			IDaemonHack.AddType(builder, Type);
			return IDaemonHack.EndIDaemonHack(builder);
		}

		// Token: 0x0602CECF RID: 184015 RVA: 0x0062B755 File Offset: 0x00629955
		public static void StartIDaemonHack(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602CED0 RID: 184016 RVA: 0x0062B75E File Offset: 0x0062995E
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CED1 RID: 184017 RVA: 0x0062B769 File Offset: 0x00629969
		public static void AddIds(FlatBufferBuilder builder, VectorOffset idsOffset)
		{
			builder.AddOffset(1, idsOffset.Value, 0);
		}

		// Token: 0x0602CED2 RID: 184018 RVA: 0x0062B77C File Offset: 0x0062997C
		public static VectorOffset CreateIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602CED3 RID: 184019 RVA: 0x0062B7B3 File Offset: 0x006299B3
		public static VectorOffset CreateIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602CED4 RID: 184020 RVA: 0x0062B7CD File Offset: 0x006299CD
		public static VectorOffset CreateIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602CED5 RID: 184021 RVA: 0x0062B7EB File Offset: 0x006299EB
		public static VectorOffset CreateIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602CED6 RID: 184022 RVA: 0x0062B804 File Offset: 0x00629A04
		public static void StartIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602CED7 RID: 184023 RVA: 0x0062B80F File Offset: 0x00629A0F
		public static void AddFinishOnClose(FlatBufferBuilder builder, bool finishOnClose)
		{
			builder.AddBool(2, finishOnClose, false);
		}

		// Token: 0x0602CED8 RID: 184024 RVA: 0x0062B81A File Offset: 0x00629A1A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602CED9 RID: 184025 RVA: 0x0062B825 File Offset: 0x00629A25
		public static Offset<IDaemonHack> EndIDaemonHack(FlatBufferBuilder builder)
		{
			return new Offset<IDaemonHack>(builder.EndTable());
		}

		// Token: 0x0602CEDA RID: 184026 RVA: 0x0062B834 File Offset: 0x00629A34
		public IDaemonHackT UnPack()
		{
			IDaemonHackT daemonHackT = new IDaemonHackT();
			this.UnPackTo(daemonHackT);
			return daemonHackT;
		}

		// Token: 0x0602CEDB RID: 184027 RVA: 0x0062B850 File Offset: 0x00629A50
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

		// Token: 0x0602CEDC RID: 184028 RVA: 0x0062B8B0 File Offset: 0x00629AB0
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

		// Token: 0x04010B73 RID: 68467
		private Table __p;
	}
}
