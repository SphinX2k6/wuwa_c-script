using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007884 RID: 30852
	public struct ISheriffCashSettlement : IFlatbufferObject
	{
		// Token: 0x1700E23E RID: 57918
		// (get) Token: 0x0603644B RID: 222283 RVA: 0x00744AE5 File Offset: 0x00742CE5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603644C RID: 222284 RVA: 0x00744AF2 File Offset: 0x00742CF2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603644D RID: 222285 RVA: 0x00744AFC File Offset: 0x00742CFC
		public static ISheriffCashSettlement GetRootAsISheriffCashSettlement(ByteBuffer _bb)
		{
			return ISheriffCashSettlement.GetRootAsISheriffCashSettlement(_bb, default(ISheriffCashSettlement));
		}

		// Token: 0x0603644E RID: 222286 RVA: 0x00744B18 File Offset: 0x00742D18
		public static ISheriffCashSettlement GetRootAsISheriffCashSettlement(ByteBuffer _bb, ISheriffCashSettlement obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603644F RID: 222287 RVA: 0x00744B35 File Offset: 0x00742D35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036450 RID: 222288 RVA: 0x00744B44 File Offset: 0x00742D44
		public ISheriffCashSettlement __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E23F RID: 57919
		// (get) Token: 0x06036451 RID: 222289 RVA: 0x00744B54 File Offset: 0x00742D54
		public ECommonTipType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return (ECommonTipType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E240 RID: 57920
		// (get) Token: 0x06036452 RID: 222290 RVA: 0x00744B90 File Offset: 0x00742D90
		public string TidMainText
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

		// Token: 0x06036453 RID: 222291 RVA: 0x00744BC7 File Offset: 0x00742DC7
		public Span<byte> GetTidMainTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06036454 RID: 222292 RVA: 0x00744BD6 File Offset: 0x00742DD6
		public byte[] GetTidMainTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700E241 RID: 57921
		// (get) Token: 0x06036455 RID: 222293 RVA: 0x00744BE4 File Offset: 0x00742DE4
		public string TidSubText
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036456 RID: 222294 RVA: 0x00744C1B File Offset: 0x00742E1B
		public Span<byte> GetTidSubTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06036457 RID: 222295 RVA: 0x00744C2A File Offset: 0x00742E2A
		public byte[] GetTidSubTextArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700E242 RID: 57922
		// (get) Token: 0x06036458 RID: 222296 RVA: 0x00744C38 File Offset: 0x00742E38
		public TVarRef VarRefType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036459 RID: 222297 RVA: 0x00744C78 File Offset: 0x00742E78
		public TTable? VarRef<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603645A RID: 222298 RVA: 0x00744CC0 File Offset: 0x00742EC0
		public IConstVarRef VarRefAsIConstVarRef()
		{
			return this.VarRef<IConstVarRef>().Value;
		}

		// Token: 0x0603645B RID: 222299 RVA: 0x00744CDC File Offset: 0x00742EDC
		public IGlobalVarRef VarRefAsIGlobalVarRef()
		{
			return this.VarRef<IGlobalVarRef>().Value;
		}

		// Token: 0x0603645C RID: 222300 RVA: 0x00744CF8 File Offset: 0x00742EF8
		public IOtherVarRef VarRefAsIOtherVarRef()
		{
			return this.VarRef<IOtherVarRef>().Value;
		}

		// Token: 0x0603645D RID: 222301 RVA: 0x00744D14 File Offset: 0x00742F14
		public ISelfVarRef VarRefAsISelfVarRef()
		{
			return this.VarRef<ISelfVarRef>().Value;
		}

		// Token: 0x0603645E RID: 222302 RVA: 0x00744D30 File Offset: 0x00742F30
		public ISystemVarRef VarRefAsISystemVarRef()
		{
			return this.VarRef<ISystemVarRef>().Value;
		}

		// Token: 0x0603645F RID: 222303 RVA: 0x00744D4B File Offset: 0x00742F4B
		public static Offset<ISheriffCashSettlement> CreateISheriffCashSettlement(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset TidMainTextOffset = default(StringOffset), StringOffset TidSubTextOffset = default(StringOffset), TVarRef VarRef_type = TVarRef.NONE, int VarRefOffset = 0)
		{
			builder.StartTable(5);
			ISheriffCashSettlement.AddVarRef(builder, VarRefOffset);
			ISheriffCashSettlement.AddTidSubText(builder, TidSubTextOffset);
			ISheriffCashSettlement.AddTidMainText(builder, TidMainTextOffset);
			ISheriffCashSettlement.AddVarRefType(builder, VarRef_type);
			ISheriffCashSettlement.AddType(builder, Type);
			return ISheriffCashSettlement.EndISheriffCashSettlement(builder);
		}

		// Token: 0x06036460 RID: 222304 RVA: 0x00744D7F File Offset: 0x00742F7F
		public static void StartISheriffCashSettlement(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06036461 RID: 222305 RVA: 0x00744D88 File Offset: 0x00742F88
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036462 RID: 222306 RVA: 0x00744D93 File Offset: 0x00742F93
		public static void AddTidMainText(FlatBufferBuilder builder, StringOffset tidMainTextOffset)
		{
			builder.AddOffset(1, tidMainTextOffset.Value, 0);
		}

		// Token: 0x06036463 RID: 222307 RVA: 0x00744DA3 File Offset: 0x00742FA3
		public static void AddTidSubText(FlatBufferBuilder builder, StringOffset tidSubTextOffset)
		{
			builder.AddOffset(2, tidSubTextOffset.Value, 0);
		}

		// Token: 0x06036464 RID: 222308 RVA: 0x00744DB3 File Offset: 0x00742FB3
		public static void AddVarRefType(FlatBufferBuilder builder, TVarRef varRefType)
		{
			builder.AddByte(3, (byte)varRefType, 0);
		}

		// Token: 0x06036465 RID: 222309 RVA: 0x00744DBE File Offset: 0x00742FBE
		public static void AddVarRef(FlatBufferBuilder builder, int varRefOffset)
		{
			builder.AddOffset(4, varRefOffset, 0);
		}

		// Token: 0x06036466 RID: 222310 RVA: 0x00744DC9 File Offset: 0x00742FC9
		public static Offset<ISheriffCashSettlement> EndISheriffCashSettlement(FlatBufferBuilder builder)
		{
			return new Offset<ISheriffCashSettlement>(builder.EndTable());
		}

		// Token: 0x06036467 RID: 222311 RVA: 0x00744DD8 File Offset: 0x00742FD8
		public ISheriffCashSettlementT UnPack()
		{
			ISheriffCashSettlementT sheriffCashSettlementT = new ISheriffCashSettlementT();
			this.UnPackTo(sheriffCashSettlementT);
			return sheriffCashSettlementT;
		}

		// Token: 0x06036468 RID: 222312 RVA: 0x00744DF4 File Offset: 0x00742FF4
		public void UnPackTo(ISheriffCashSettlementT _o)
		{
			_o.Type = this.Type;
			_o.TidMainText = this.TidMainText;
			_o.TidSubText = this.TidSubText;
			_o.VarRef = new TVarRefUnion();
			_o.VarRef.Type = this.VarRefType;
			switch (this.VarRefType)
			{
			case TVarRef.IConstVarRef:
				_o.VarRef.Value = ((this.VarRef<IConstVarRef>() != null) ? this.VarRef<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.VarRef.Value = ((this.VarRef<IGlobalVarRef>() != null) ? this.VarRef<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.VarRef.Value = ((this.VarRef<IOtherVarRef>() != null) ? this.VarRef<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.VarRef.Value = ((this.VarRef<ISelfVarRef>() != null) ? this.VarRef<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.VarRef.Value = ((this.VarRef<ISystemVarRef>() != null) ? this.VarRef<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06036469 RID: 222313 RVA: 0x00744F78 File Offset: 0x00743178
		public static Offset<ISheriffCashSettlement> Pack(FlatBufferBuilder builder, ISheriffCashSettlementT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISheriffCashSettlement>);
			}
			StringOffset tidMainTextOffset = (_o.TidMainText == null) ? default(StringOffset) : builder.CreateString(_o.TidMainText);
			StringOffset tidSubTextOffset = (_o.TidSubText == null) ? default(StringOffset) : builder.CreateString(_o.TidSubText);
			TVarRef varRef_type = (_o.VarRef == null) ? TVarRef.NONE : _o.VarRef.Type;
			int varRefOffset = (_o.VarRef == null) ? 0 : TVarRefUnion.Pack(builder, _o.VarRef);
			return ISheriffCashSettlement.CreateISheriffCashSettlement(builder, _o.Type, tidMainTextOffset, tidSubTextOffset, varRef_type, varRefOffset);
		}

		// Token: 0x04012B13 RID: 76563
		private Table __p;
	}
}
