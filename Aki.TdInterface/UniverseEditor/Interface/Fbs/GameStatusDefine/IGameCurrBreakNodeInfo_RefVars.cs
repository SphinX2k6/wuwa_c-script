using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x020046F4 RID: 18164
	public struct IGameCurrBreakNodeInfo_RefVars : IFlatbufferObject
	{
		// Token: 0x170081DA RID: 33242
		// (get) Token: 0x0601BCD1 RID: 113873 RVA: 0x003F0DDB File Offset: 0x003EEFDB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BCD2 RID: 113874 RVA: 0x003F0DE8 File Offset: 0x003EEFE8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BCD3 RID: 113875 RVA: 0x003F0DF0 File Offset: 0x003EEFF0
		public static IGameCurrBreakNodeInfo_RefVars GetRootAsIGameCurrBreakNodeInfo_RefVars(ByteBuffer _bb)
		{
			return IGameCurrBreakNodeInfo_RefVars.GetRootAsIGameCurrBreakNodeInfo_RefVars(_bb, default(IGameCurrBreakNodeInfo_RefVars));
		}

		// Token: 0x0601BCD4 RID: 113876 RVA: 0x003F0E0C File Offset: 0x003EF00C
		public static IGameCurrBreakNodeInfo_RefVars GetRootAsIGameCurrBreakNodeInfo_RefVars(ByteBuffer _bb, IGameCurrBreakNodeInfo_RefVars obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BCD5 RID: 113877 RVA: 0x003F0E29 File Offset: 0x003EF029
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BCD6 RID: 113878 RVA: 0x003F0E38 File Offset: 0x003EF038
		public IGameCurrBreakNodeInfo_RefVars __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170081DB RID: 33243
		// (get) Token: 0x0601BCD7 RID: 113879 RVA: 0x003F0E48 File Offset: 0x003EF048
		public string Item1
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BCD8 RID: 113880 RVA: 0x003F0E7F File Offset: 0x003EF07F
		public Span<byte> GetItem1Bytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601BCD9 RID: 113881 RVA: 0x003F0E8E File Offset: 0x003EF08E
		public byte[] GetItem1Array()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x170081DC RID: 33244
		// (get) Token: 0x0601BCDA RID: 113882 RVA: 0x003F0E9C File Offset: 0x003EF09C
		public string Item2
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BCDB RID: 113883 RVA: 0x003F0ED3 File Offset: 0x003EF0D3
		public Span<byte> GetItem2Bytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601BCDC RID: 113884 RVA: 0x003F0EE2 File Offset: 0x003EF0E2
		public byte[] GetItem2Array()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601BCDD RID: 113885 RVA: 0x003F0EF0 File Offset: 0x003EF0F0
		public static Offset<IGameCurrBreakNodeInfo_RefVars> CreateIGameCurrBreakNodeInfo_RefVars(FlatBufferBuilder builder, StringOffset Item1Offset = default(StringOffset), StringOffset Item2Offset = default(StringOffset))
		{
			builder.StartTable(2);
			IGameCurrBreakNodeInfo_RefVars.AddItem2(builder, Item2Offset);
			IGameCurrBreakNodeInfo_RefVars.AddItem1(builder, Item1Offset);
			return IGameCurrBreakNodeInfo_RefVars.EndIGameCurrBreakNodeInfo_RefVars(builder);
		}

		// Token: 0x0601BCDE RID: 113886 RVA: 0x003F0F0D File Offset: 0x003EF10D
		public static void StartIGameCurrBreakNodeInfo_RefVars(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601BCDF RID: 113887 RVA: 0x003F0F16 File Offset: 0x003EF116
		public static void AddItem1(FlatBufferBuilder builder, StringOffset item1Offset)
		{
			builder.AddOffset(0, item1Offset.Value, 0);
		}

		// Token: 0x0601BCE0 RID: 113888 RVA: 0x003F0F26 File Offset: 0x003EF126
		public static void AddItem2(FlatBufferBuilder builder, StringOffset item2Offset)
		{
			builder.AddOffset(1, item2Offset.Value, 0);
		}

		// Token: 0x0601BCE1 RID: 113889 RVA: 0x003F0F36 File Offset: 0x003EF136
		public static Offset<IGameCurrBreakNodeInfo_RefVars> EndIGameCurrBreakNodeInfo_RefVars(FlatBufferBuilder builder)
		{
			return new Offset<IGameCurrBreakNodeInfo_RefVars>(builder.EndTable());
		}

		// Token: 0x0601BCE2 RID: 113890 RVA: 0x003F0F44 File Offset: 0x003EF144
		public IGameCurrBreakNodeInfo_RefVarsT UnPack()
		{
			IGameCurrBreakNodeInfo_RefVarsT gameCurrBreakNodeInfo_RefVarsT = new IGameCurrBreakNodeInfo_RefVarsT();
			this.UnPackTo(gameCurrBreakNodeInfo_RefVarsT);
			return gameCurrBreakNodeInfo_RefVarsT;
		}

		// Token: 0x0601BCE3 RID: 113891 RVA: 0x003F0F5F File Offset: 0x003EF15F
		public void UnPackTo(IGameCurrBreakNodeInfo_RefVarsT _o)
		{
			_o.Item1 = this.Item1;
			_o.Item2 = this.Item2;
		}

		// Token: 0x0601BCE4 RID: 113892 RVA: 0x003F0F7C File Offset: 0x003EF17C
		public static Offset<IGameCurrBreakNodeInfo_RefVars> Pack(FlatBufferBuilder builder, IGameCurrBreakNodeInfo_RefVarsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGameCurrBreakNodeInfo_RefVars>);
			}
			StringOffset item1Offset = (_o.Item1 == null) ? default(StringOffset) : builder.CreateString(_o.Item1);
			StringOffset item2Offset = (_o.Item2 == null) ? default(StringOffset) : builder.CreateString(_o.Item2);
			return IGameCurrBreakNodeInfo_RefVars.CreateIGameCurrBreakNodeInfo_RefVars(builder, item1Offset, item2Offset);
		}

		// Token: 0x0400C99E RID: 51614
		private Table __p;
	}
}
