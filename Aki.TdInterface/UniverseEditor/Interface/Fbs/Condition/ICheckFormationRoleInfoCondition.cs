using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EF3 RID: 20211
	public struct ICheckFormationRoleInfoCondition : IFlatbufferObject
	{
		// Token: 0x17009050 RID: 36944
		// (get) Token: 0x0601F616 RID: 128534 RVA: 0x0045F054 File Offset: 0x0045D254
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F617 RID: 128535 RVA: 0x0045F061 File Offset: 0x0045D261
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F618 RID: 128536 RVA: 0x0045F068 File Offset: 0x0045D268
		public static ICheckFormationRoleInfoCondition GetRootAsICheckFormationRoleInfoCondition(ByteBuffer _bb)
		{
			return ICheckFormationRoleInfoCondition.GetRootAsICheckFormationRoleInfoCondition(_bb, default(ICheckFormationRoleInfoCondition));
		}

		// Token: 0x0601F619 RID: 128537 RVA: 0x0045F084 File Offset: 0x0045D284
		public static ICheckFormationRoleInfoCondition GetRootAsICheckFormationRoleInfoCondition(ByteBuffer _bb, ICheckFormationRoleInfoCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F61A RID: 128538 RVA: 0x0045F0A1 File Offset: 0x0045D2A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F61B RID: 128539 RVA: 0x0045F0B0 File Offset: 0x0045D2B0
		public ICheckFormationRoleInfoCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009051 RID: 36945
		// (get) Token: 0x0601F61C RID: 128540 RVA: 0x0045F0C0 File Offset: 0x0045D2C0
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

		// Token: 0x17009052 RID: 36946
		// (get) Token: 0x0601F61D RID: 128541 RVA: 0x0045F0FC File Offset: 0x0045D2FC
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

		// Token: 0x0601F61E RID: 128542 RVA: 0x0045F138 File Offset: 0x0045D338
		public TTable? Option<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601F61F RID: 128543 RVA: 0x0045F17C File Offset: 0x0045D37C
		public IFeatureCollectionLevel OptionAsIFeatureCollectionLevel()
		{
			return this.Option<IFeatureCollectionLevel>().Value;
		}

		// Token: 0x0601F620 RID: 128544 RVA: 0x0045F198 File Offset: 0x0045D398
		public IHasEquippedVision OptionAsIHasEquippedVision()
		{
			return this.Option<IHasEquippedVision>().Value;
		}

		// Token: 0x0601F621 RID: 128545 RVA: 0x0045F1B4 File Offset: 0x0045D3B4
		public IHasUpgradableVision OptionAsIHasUpgradableVision()
		{
			return this.Option<IHasUpgradableVision>().Value;
		}

		// Token: 0x0601F622 RID: 128546 RVA: 0x0045F1D0 File Offset: 0x0045D3D0
		public IRoleLevel OptionAsIRoleLevel()
		{
			return this.Option<IRoleLevel>().Value;
		}

		// Token: 0x0601F623 RID: 128547 RVA: 0x0045F1EC File Offset: 0x0045D3EC
		public IWeaponLevel OptionAsIWeaponLevel()
		{
			return this.Option<IWeaponLevel>().Value;
		}

		// Token: 0x0601F624 RID: 128548 RVA: 0x0045F207 File Offset: 0x0045D407
		public static Offset<ICheckFormationRoleInfoCondition> CreateICheckFormationRoleInfoCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, TCheckFormationRoleInfo Option_type = TCheckFormationRoleInfo.NONE, int OptionOffset = 0)
		{
			builder.StartTable(3);
			ICheckFormationRoleInfoCondition.AddOption(builder, OptionOffset);
			ICheckFormationRoleInfoCondition.AddOptionType(builder, Option_type);
			ICheckFormationRoleInfoCondition.AddType(builder, Type);
			return ICheckFormationRoleInfoCondition.EndICheckFormationRoleInfoCondition(builder);
		}

		// Token: 0x0601F625 RID: 128549 RVA: 0x0045F22B File Offset: 0x0045D42B
		public static void StartICheckFormationRoleInfoCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601F626 RID: 128550 RVA: 0x0045F234 File Offset: 0x0045D434
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F627 RID: 128551 RVA: 0x0045F23F File Offset: 0x0045D43F
		public static void AddOptionType(FlatBufferBuilder builder, TCheckFormationRoleInfo optionType)
		{
			builder.AddByte(1, (byte)optionType, 0);
		}

		// Token: 0x0601F628 RID: 128552 RVA: 0x0045F24A File Offset: 0x0045D44A
		public static void AddOption(FlatBufferBuilder builder, int optionOffset)
		{
			builder.AddOffset(2, optionOffset, 0);
		}

		// Token: 0x0601F629 RID: 128553 RVA: 0x0045F255 File Offset: 0x0045D455
		public static Offset<ICheckFormationRoleInfoCondition> EndICheckFormationRoleInfoCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckFormationRoleInfoCondition>(builder.EndTable());
		}

		// Token: 0x0601F62A RID: 128554 RVA: 0x0045F264 File Offset: 0x0045D464
		public ICheckFormationRoleInfoConditionT UnPack()
		{
			ICheckFormationRoleInfoConditionT checkFormationRoleInfoConditionT = new ICheckFormationRoleInfoConditionT();
			this.UnPackTo(checkFormationRoleInfoConditionT);
			return checkFormationRoleInfoConditionT;
		}

		// Token: 0x0601F62B RID: 128555 RVA: 0x0045F280 File Offset: 0x0045D480
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

		// Token: 0x0601F62C RID: 128556 RVA: 0x0045F3EC File Offset: 0x0045D5EC
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

		// Token: 0x0400DD5A RID: 56666
		private Table __p;
	}
}
