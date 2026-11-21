using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004B5C RID: 19292
	public struct IGameCurrBreakNodeInfo_RefVars : IFlatbufferObject
	{
		// Token: 0x1700881B RID: 34843
		// (get) Token: 0x0601D4A6 RID: 119974 RVA: 0x0041D077 File Offset: 0x0041B277
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D4A7 RID: 119975 RVA: 0x0041D084 File Offset: 0x0041B284
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D4A8 RID: 119976 RVA: 0x0041D08C File Offset: 0x0041B28C
		public static IGameCurrBreakNodeInfo_RefVars GetRootAsIGameCurrBreakNodeInfo_RefVars(ByteBuffer _bb)
		{
			return IGameCurrBreakNodeInfo_RefVars.GetRootAsIGameCurrBreakNodeInfo_RefVars(_bb, default(IGameCurrBreakNodeInfo_RefVars));
		}

		// Token: 0x0601D4A9 RID: 119977 RVA: 0x0041D0A8 File Offset: 0x0041B2A8
		public static IGameCurrBreakNodeInfo_RefVars GetRootAsIGameCurrBreakNodeInfo_RefVars(ByteBuffer _bb, IGameCurrBreakNodeInfo_RefVars obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D4AA RID: 119978 RVA: 0x0041D0C5 File Offset: 0x0041B2C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D4AB RID: 119979 RVA: 0x0041D0D4 File Offset: 0x0041B2D4
		public IGameCurrBreakNodeInfo_RefVars __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700881C RID: 34844
		// (get) Token: 0x0601D4AC RID: 119980 RVA: 0x0041D0E4 File Offset: 0x0041B2E4
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

		// Token: 0x0601D4AD RID: 119981 RVA: 0x0041D11B File Offset: 0x0041B31B
		public Span<byte> GetItem1Bytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601D4AE RID: 119982 RVA: 0x0041D12A File Offset: 0x0041B32A
		public byte[] GetItem1Array()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700881D RID: 34845
		// (get) Token: 0x0601D4AF RID: 119983 RVA: 0x0041D138 File Offset: 0x0041B338
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

		// Token: 0x0601D4B0 RID: 119984 RVA: 0x0041D16F File Offset: 0x0041B36F
		public Span<byte> GetItem2Bytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601D4B1 RID: 119985 RVA: 0x0041D17E File Offset: 0x0041B37E
		public byte[] GetItem2Array()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601D4B2 RID: 119986 RVA: 0x0041D18C File Offset: 0x0041B38C
		public static Offset<IGameCurrBreakNodeInfo_RefVars> CreateIGameCurrBreakNodeInfo_RefVars(FlatBufferBuilder builder, StringOffset Item1Offset = default(StringOffset), StringOffset Item2Offset = default(StringOffset))
		{
			builder.StartTable(2);
			IGameCurrBreakNodeInfo_RefVars.AddItem2(builder, Item2Offset);
			IGameCurrBreakNodeInfo_RefVars.AddItem1(builder, Item1Offset);
			return IGameCurrBreakNodeInfo_RefVars.EndIGameCurrBreakNodeInfo_RefVars(builder);
		}

		// Token: 0x0601D4B3 RID: 119987 RVA: 0x0041D1A9 File Offset: 0x0041B3A9
		public static void StartIGameCurrBreakNodeInfo_RefVars(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D4B4 RID: 119988 RVA: 0x0041D1B2 File Offset: 0x0041B3B2
		public static void AddItem1(FlatBufferBuilder builder, StringOffset item1Offset)
		{
			builder.AddOffset(0, item1Offset.Value, 0);
		}

		// Token: 0x0601D4B5 RID: 119989 RVA: 0x0041D1C2 File Offset: 0x0041B3C2
		public static void AddItem2(FlatBufferBuilder builder, StringOffset item2Offset)
		{
			builder.AddOffset(1, item2Offset.Value, 0);
		}

		// Token: 0x0601D4B6 RID: 119990 RVA: 0x0041D1D2 File Offset: 0x0041B3D2
		public static Offset<IGameCurrBreakNodeInfo_RefVars> EndIGameCurrBreakNodeInfo_RefVars(FlatBufferBuilder builder)
		{
			return new Offset<IGameCurrBreakNodeInfo_RefVars>(builder.EndTable());
		}

		// Token: 0x0601D4B7 RID: 119991 RVA: 0x0041D1E0 File Offset: 0x0041B3E0
		public IGameCurrBreakNodeInfo_RefVarsT UnPack()
		{
			IGameCurrBreakNodeInfo_RefVarsT gameCurrBreakNodeInfo_RefVarsT = new IGameCurrBreakNodeInfo_RefVarsT();
			this.UnPackTo(gameCurrBreakNodeInfo_RefVarsT);
			return gameCurrBreakNodeInfo_RefVarsT;
		}

		// Token: 0x0601D4B8 RID: 119992 RVA: 0x0041D1FB File Offset: 0x0041B3FB
		public void UnPackTo(IGameCurrBreakNodeInfo_RefVarsT _o)
		{
			_o.Item1 = this.Item1;
			_o.Item2 = this.Item2;
		}

		// Token: 0x0601D4B9 RID: 119993 RVA: 0x0041D218 File Offset: 0x0041B418
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

		// Token: 0x0400D3CD RID: 54221
		private Table __p;
	}
}
