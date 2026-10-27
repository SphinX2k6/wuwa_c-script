using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A30 RID: 18992
	public struct ICheckFormationRoleInfoCondition : IFlatbufferObject
	{
		// Token: 0x1700897B RID: 35195
		// (get) Token: 0x0601DB8D RID: 121741 RVA: 0x0042E15C File Offset: 0x0042C35C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DB8E RID: 121742 RVA: 0x0042E169 File Offset: 0x0042C369
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DB8F RID: 121743 RVA: 0x0042E170 File Offset: 0x0042C370
		public static ICheckFormationRoleInfoCondition GetRootAsICheckFormationRoleInfoCondition(ByteBuffer _bb)
		{
			return ICheckFormationRoleInfoCondition.GetRootAsICheckFormationRoleInfoCondition(_bb, default(ICheckFormationRoleInfoCondition));
		}

		// Token: 0x0601DB90 RID: 121744 RVA: 0x0042E18C File Offset: 0x0042C38C
		public static ICheckFormationRoleInfoCondition GetRootAsICheckFormationRoleInfoCondition(ByteBuffer _bb, ICheckFormationRoleInfoCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DB91 RID: 121745 RVA: 0x0042E1A9 File Offset: 0x0042C3A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DB92 RID: 121746 RVA: 0x0042E1B8 File Offset: 0x0042C3B8
		public ICheckFormationRoleInfoCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700897C RID: 35196
		// (get) Token: 0x0601DB93 RID: 121747 RVA: 0x0042E1C8 File Offset: 0x0042C3C8
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700897D RID: 35197
		// (get) Token: 0x0601DB94 RID: 121748 RVA: 0x0042E204 File Offset: 0x0042C404
		public TCheckFormationRoleInfo OptionType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TCheckFormationRoleInfo.NONE;
				}
				return (TCheckFormationRoleInfo)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601DB95 RID: 121749 RVA: 0x0042E240 File Offset: 0x0042C440
		public TTable? Option<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601DB96 RID: 121750 RVA: 0x0042E284 File Offset: 0x0042C484
		public IFeatureCollectionLevel OptionAsIFeatureCollectionLevel()
		{
			return this.Option<IFeatureCollectionLevel>().Value;
		}

		// Token: 0x0601DB97 RID: 121751 RVA: 0x0042E2A0 File Offset: 0x0042C4A0
		public IHasEquippedVision OptionAsIHasEquippedVision()
		{
			return this.Option<IHasEquippedVision>().Value;
		}

		// Token: 0x0601DB98 RID: 121752 RVA: 0x0042E2BC File Offset: 0x0042C4BC
		public IHasUpgradableVision OptionAsIHasUpgradableVision()
		{
			return this.Option<IHasUpgradableVision>().Value;
		}

		// Token: 0x0601DB99 RID: 121753 RVA: 0x0042E2D8 File Offset: 0x0042C4D8
		public IRoleLevel OptionAsIRoleLevel()
		{
			return this.Option<IRoleLevel>().Value;
		}

		// Token: 0x0601DB9A RID: 121754 RVA: 0x0042E2F4 File Offset: 0x0042C4F4
		public IWeaponLevel OptionAsIWeaponLevel()
		{
			return this.Option<IWeaponLevel>().Value;
		}

		// Token: 0x0601DB9B RID: 121755 RVA: 0x0042E30F File Offset: 0x0042C50F
		public static Offset<ICheckFormationRoleInfoCondition> CreateICheckFormationRoleInfoCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, TCheckFormationRoleInfo Option_type = TCheckFormationRoleInfo.NONE, int OptionOffset = 0)
		{
			builder.StartTable(3);
			ICheckFormationRoleInfoCondition.AddOption(builder, OptionOffset);
			ICheckFormationRoleInfoCondition.AddOptionType(builder, Option_type);
			ICheckFormationRoleInfoCondition.AddType(builder, Type);
			return ICheckFormationRoleInfoCondition.EndICheckFormationRoleInfoCondition(builder);
		}

		// Token: 0x0601DB9C RID: 121756 RVA: 0x0042E333 File Offset: 0x0042C533
		public static void StartICheckFormationRoleInfoCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601DB9D RID: 121757 RVA: 0x0042E33C File Offset: 0x0042C53C
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DB9E RID: 121758 RVA: 0x0042E347 File Offset: 0x0042C547
		public static void AddOptionType(FlatBufferBuilder builder, TCheckFormationRoleInfo optionType)
		{
			builder.AddByte(1, (byte)optionType, 0);
		}

		// Token: 0x0601DB9F RID: 121759 RVA: 0x0042E352 File Offset: 0x0042C552
		public static void AddOption(FlatBufferBuilder builder, int optionOffset)
		{
			builder.AddOffset(2, optionOffset, 0);
		}

		// Token: 0x0601DBA0 RID: 121760 RVA: 0x0042E35D File Offset: 0x0042C55D
		public static Offset<ICheckFormationRoleInfoCondition> EndICheckFormationRoleInfoCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckFormationRoleInfoCondition>(builder.EndTable());
		}

		// Token: 0x0601DBA1 RID: 121761 RVA: 0x0042E36C File Offset: 0x0042C56C
		public ICheckFormationRoleInfoConditionT UnPack()
		{
			ICheckFormationRoleInfoConditionT checkFormationRoleInfoConditionT = new ICheckFormationRoleInfoConditionT();
			this.UnPackTo(checkFormationRoleInfoConditionT);
			return checkFormationRoleInfoConditionT;
		}

		// Token: 0x0601DBA2 RID: 121762 RVA: 0x0042E388 File Offset: 0x0042C588
		public void UnPackTo(ICheckFormationRoleInfoConditionT _o)
		{
			_o.Type = this.Type;
			_o.Option = new TCheckFormationRoleInfoUnion();
			_o.Option.Type = this.OptionType;
			switch (this.OptionType)
			{
			case TCheckFormationRoleInfo.IFeatureCollectionLevel:
				_o.Option.Value = ((this.Option<IFeatureCollectionLevel>() != null) ? this.Option<IFeatureCollectionLevel>().Value.UnPack() : null);
				return;
			case TCheckFormationRoleInfo.IHasEquippedVision:
				_o.Option.Value = ((this.Option<IHasEquippedVision>() != null) ? this.Option<IHasEquippedVision>().Value.UnPack() : null);
				return;
			case TCheckFormationRoleInfo.IHasUpgradableVision:
				_o.Option.Value = ((this.Option<IHasUpgradableVision>() != null) ? this.Option<IHasUpgradableVision>().Value.UnPack() : null);
				return;
			case TCheckFormationRoleInfo.IRoleLevel:
				_o.Option.Value = ((this.Option<IRoleLevel>() != null) ? this.Option<IRoleLevel>().Value.UnPack() : null);
				return;
			case TCheckFormationRoleInfo.IWeaponLevel:
				_o.Option.Value = ((this.Option<IWeaponLevel>() != null) ? this.Option<IWeaponLevel>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0601DBA3 RID: 121763 RVA: 0x0042E4F4 File Offset: 0x0042C6F4
		public static Offset<ICheckFormationRoleInfoCondition> Pack(FlatBufferBuilder builder, ICheckFormationRoleInfoConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckFormationRoleInfoCondition>);
			}
			TCheckFormationRoleInfo option_type = (_o.Option == null) ? TCheckFormationRoleInfo.NONE : _o.Option.Type;
			int optionOffset = (_o.Option == null) ? 0 : TCheckFormationRoleInfoUnion.Pack(builder, _o.Option);
			return ICheckFormationRoleInfoCondition.CreateICheckFormationRoleInfoCondition(builder, _o.Type, option_type, optionOffset);
		}

		// Token: 0x0400D283 RID: 53891
		private Table __p;
	}
}
