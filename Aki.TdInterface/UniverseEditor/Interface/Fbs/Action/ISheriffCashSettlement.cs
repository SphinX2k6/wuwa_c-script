using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070B8 RID: 28856
	public struct ISheriffCashSettlement : IFlatbufferObject
	{
		// Token: 0x1700D65B RID: 54875
		// (get) Token: 0x060331A9 RID: 209321 RVA: 0x006E44D9 File Offset: 0x006E26D9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060331AA RID: 209322 RVA: 0x006E44E6 File Offset: 0x006E26E6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060331AB RID: 209323 RVA: 0x006E44F0 File Offset: 0x006E26F0
		public static ISheriffCashSettlement GetRootAsISheriffCashSettlement(ByteBuffer _bb)
		{
			return ISheriffCashSettlement.GetRootAsISheriffCashSettlement(_bb, default(ISheriffCashSettlement));
		}

		// Token: 0x060331AC RID: 209324 RVA: 0x006E450C File Offset: 0x006E270C
		public static ISheriffCashSettlement GetRootAsISheriffCashSettlement(ByteBuffer _bb, ISheriffCashSettlement obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060331AD RID: 209325 RVA: 0x006E4529 File Offset: 0x006E2729
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060331AE RID: 209326 RVA: 0x006E4538 File Offset: 0x006E2738
		public ISheriffCashSettlement __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D65C RID: 54876
		// (get) Token: 0x060331AF RID: 209327 RVA: 0x006E4548 File Offset: 0x006E2748
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

		// Token: 0x1700D65D RID: 54877
		// (get) Token: 0x060331B0 RID: 209328 RVA: 0x006E4584 File Offset: 0x006E2784
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

		// Token: 0x060331B1 RID: 209329 RVA: 0x006E45BB File Offset: 0x006E27BB
		public Span<byte> GetTidMainTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060331B2 RID: 209330 RVA: 0x006E45CA File Offset: 0x006E27CA
		public byte[] GetTidMainTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700D65E RID: 54878
		// (get) Token: 0x060331B3 RID: 209331 RVA: 0x006E45D8 File Offset: 0x006E27D8
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

		// Token: 0x060331B4 RID: 209332 RVA: 0x006E460F File Offset: 0x006E280F
		public Span<byte> GetTidSubTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060331B5 RID: 209333 RVA: 0x006E461E File Offset: 0x006E281E
		public byte[] GetTidSubTextArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700D65F RID: 54879
		// (get) Token: 0x060331B6 RID: 209334 RVA: 0x006E462C File Offset: 0x006E282C
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

		// Token: 0x060331B7 RID: 209335 RVA: 0x006E466C File Offset: 0x006E286C
		public TTable? VarRef<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060331B8 RID: 209336 RVA: 0x006E46B4 File Offset: 0x006E28B4
		public IConstVarRef VarRefAsIConstVarRef()
		{
			return this.VarRef<IConstVarRef>().Value;
		}

		// Token: 0x060331B9 RID: 209337 RVA: 0x006E46D0 File Offset: 0x006E28D0
		public IGlobalVarRef VarRefAsIGlobalVarRef()
		{
			return this.VarRef<IGlobalVarRef>().Value;
		}

		// Token: 0x060331BA RID: 209338 RVA: 0x006E46EC File Offset: 0x006E28EC
		public IOtherVarRef VarRefAsIOtherVarRef()
		{
			return this.VarRef<IOtherVarRef>().Value;
		}

		// Token: 0x060331BB RID: 209339 RVA: 0x006E4708 File Offset: 0x006E2908
		public ISelfVarRef VarRefAsISelfVarRef()
		{
			return this.VarRef<ISelfVarRef>().Value;
		}

		// Token: 0x060331BC RID: 209340 RVA: 0x006E4724 File Offset: 0x006E2924
		public ISystemVarRef VarRefAsISystemVarRef()
		{
			return this.VarRef<ISystemVarRef>().Value;
		}

		// Token: 0x060331BD RID: 209341 RVA: 0x006E473F File Offset: 0x006E293F
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

		// Token: 0x060331BE RID: 209342 RVA: 0x006E4773 File Offset: 0x006E2973
		public static void StartISheriffCashSettlement(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060331BF RID: 209343 RVA: 0x006E477C File Offset: 0x006E297C
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060331C0 RID: 209344 RVA: 0x006E4787 File Offset: 0x006E2987
		public static void AddTidMainText(FlatBufferBuilder builder, StringOffset tidMainTextOffset)
		{
			builder.AddOffset(1, tidMainTextOffset.Value, 0);
		}

		// Token: 0x060331C1 RID: 209345 RVA: 0x006E4797 File Offset: 0x006E2997
		public static void AddTidSubText(FlatBufferBuilder builder, StringOffset tidSubTextOffset)
		{
			builder.AddOffset(2, tidSubTextOffset.Value, 0);
		}

		// Token: 0x060331C2 RID: 209346 RVA: 0x006E47A7 File Offset: 0x006E29A7
		public static void AddVarRefType(FlatBufferBuilder builder, TVarRef varRefType)
		{
			builder.AddByte(3, (byte)varRefType, 0);
		}

		// Token: 0x060331C3 RID: 209347 RVA: 0x006E47B2 File Offset: 0x006E29B2
		public static void AddVarRef(FlatBufferBuilder builder, int varRefOffset)
		{
			builder.AddOffset(4, varRefOffset, 0);
		}

		// Token: 0x060331C4 RID: 209348 RVA: 0x006E47BD File Offset: 0x006E29BD
		public static Offset<ISheriffCashSettlement> EndISheriffCashSettlement(FlatBufferBuilder builder)
		{
			return new Offset<ISheriffCashSettlement>(builder.EndTable());
		}

		// Token: 0x060331C5 RID: 209349 RVA: 0x006E47CC File Offset: 0x006E29CC
		public ISheriffCashSettlementT UnPack()
		{
			ISheriffCashSettlementT sheriffCashSettlementT = new ISheriffCashSettlementT();
			this.UnPackTo(sheriffCashSettlementT);
			return sheriffCashSettlementT;
		}

		// Token: 0x060331C6 RID: 209350 RVA: 0x006E47E8 File Offset: 0x006E29E8
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

		// Token: 0x060331C7 RID: 209351 RVA: 0x006E496C File Offset: 0x006E2B6C
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

		// Token: 0x04011B25 RID: 72485
		private Table __p;
	}
}
