using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004256 RID: 16982
	public struct IFastReturnEntityPos : IFlatbufferObject
	{
		// Token: 0x170073CF RID: 29647
		// (get) Token: 0x06017A56 RID: 96854 RVA: 0x0035F605 File Offset: 0x0035D805
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017A57 RID: 96855 RVA: 0x0035F612 File Offset: 0x0035D812
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017A58 RID: 96856 RVA: 0x0035F61C File Offset: 0x0035D81C
		public static IFastReturnEntityPos GetRootAsIFastReturnEntityPos(ByteBuffer _bb)
		{
			return IFastReturnEntityPos.GetRootAsIFastReturnEntityPos(_bb, default(IFastReturnEntityPos));
		}

		// Token: 0x06017A59 RID: 96857 RVA: 0x0035F638 File Offset: 0x0035D838
		public static IFastReturnEntityPos GetRootAsIFastReturnEntityPos(ByteBuffer _bb, IFastReturnEntityPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017A5A RID: 96858 RVA: 0x0035F655 File Offset: 0x0035D855
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017A5B RID: 96859 RVA: 0x0035F664 File Offset: 0x0035D864
		public IFastReturnEntityPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170073D0 RID: 29648
		// (get) Token: 0x06017A5C RID: 96860 RVA: 0x0035F674 File Offset: 0x0035D874
		public EFastReturnPosType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFastReturnPosType.EntityPos;
				}
				return (EFastReturnPosType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170073D1 RID: 29649
		// (get) Token: 0x06017A5D RID: 96861 RVA: 0x0035F6B0 File Offset: 0x0035D8B0
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170073D2 RID: 29650
		// (get) Token: 0x06017A5E RID: 96862 RVA: 0x0035F6EC File Offset: 0x0035D8EC
		public TTeleportTransitionOption TransitionOptionType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TTeleportTransitionOption.NONE;
				}
				return (TTeleportTransitionOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017A5F RID: 96863 RVA: 0x0035F728 File Offset: 0x0035D928
		public TTable? TransitionOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017A60 RID: 96864 RVA: 0x0035F770 File Offset: 0x0035D970
		public ITeleportTransitionInDigitalScreen TransitionOptionAsITeleportTransitionInDigitalScreen()
		{
			return this.TransitionOption<ITeleportTransitionInDigitalScreen>().Value;
		}

		// Token: 0x06017A61 RID: 96865 RVA: 0x0035F78C File Offset: 0x0035D98C
		public ITeleportTransitionInSeamlessType TransitionOptionAsITeleportTransitionInSeamlessType()
		{
			return this.TransitionOption<ITeleportTransitionInSeamlessType>().Value;
		}

		// Token: 0x06017A62 RID: 96866 RVA: 0x0035F7A8 File Offset: 0x0035D9A8
		public ITeleportTransitionWithCenterText TransitionOptionAsITeleportTransitionWithCenterText()
		{
			return this.TransitionOption<ITeleportTransitionWithCenterText>().Value;
		}

		// Token: 0x06017A63 RID: 96867 RVA: 0x0035F7C4 File Offset: 0x0035D9C4
		public ITeleportTransitionWithCharacterDisplay TransitionOptionAsITeleportTransitionWithCharacterDisplay()
		{
			return this.TransitionOption<ITeleportTransitionWithCharacterDisplay>().Value;
		}

		// Token: 0x06017A64 RID: 96868 RVA: 0x0035F7E0 File Offset: 0x0035D9E0
		public ITeleportTransitionWithCustomLoading TransitionOptionAsITeleportTransitionWithCustomLoading()
		{
			return this.TransitionOption<ITeleportTransitionWithCustomLoading>().Value;
		}

		// Token: 0x06017A65 RID: 96869 RVA: 0x0035F7FC File Offset: 0x0035D9FC
		public ITeleportTransitionWithCustomScreen TransitionOptionAsITeleportTransitionWithCustomScreen()
		{
			return this.TransitionOption<ITeleportTransitionWithCustomScreen>().Value;
		}

		// Token: 0x06017A66 RID: 96870 RVA: 0x0035F818 File Offset: 0x0035DA18
		public ITeleportTransitionWithEffect TransitionOptionAsITeleportTransitionWithEffect()
		{
			return this.TransitionOption<ITeleportTransitionWithEffect>().Value;
		}

		// Token: 0x06017A67 RID: 96871 RVA: 0x0035F834 File Offset: 0x0035DA34
		public ITeleportTransitionWithFadeInScreen TransitionOptionAsITeleportTransitionWithFadeInScreen()
		{
			return this.TransitionOption<ITeleportTransitionWithFadeInScreen>().Value;
		}

		// Token: 0x06017A68 RID: 96872 RVA: 0x0035F850 File Offset: 0x0035DA50
		public ITeleportTransitionWithMp4 TransitionOptionAsITeleportTransitionWithMp4()
		{
			return this.TransitionOption<ITeleportTransitionWithMp4>().Value;
		}

		// Token: 0x06017A69 RID: 96873 RVA: 0x0035F86C File Offset: 0x0035DA6C
		public ITeleportTransitionWithPlayFlow TransitionOptionAsITeleportTransitionWithPlayFlow()
		{
			return this.TransitionOption<ITeleportTransitionWithPlayFlow>().Value;
		}

		// Token: 0x06017A6A RID: 96874 RVA: 0x0035F888 File Offset: 0x0035DA88
		public ITeleportTransitionWithSpecialCustomLoading TransitionOptionAsITeleportTransitionWithSpecialCustomLoading()
		{
			return this.TransitionOption<ITeleportTransitionWithSpecialCustomLoading>().Value;
		}

		// Token: 0x06017A6B RID: 96875 RVA: 0x0035F8A3 File Offset: 0x0035DAA3
		public static Offset<IFastReturnEntityPos> CreateIFastReturnEntityPos(FlatBufferBuilder builder, EFastReturnPosType Type = EFastReturnPosType.EntityPos, int EntityId = 0, TTeleportTransitionOption TransitionOption_type = TTeleportTransitionOption.NONE, int TransitionOptionOffset = 0)
		{
			builder.StartTable(4);
			IFastReturnEntityPos.AddTransitionOption(builder, TransitionOptionOffset);
			IFastReturnEntityPos.AddEntityId(builder, EntityId);
			IFastReturnEntityPos.AddTransitionOptionType(builder, TransitionOption_type);
			IFastReturnEntityPos.AddType(builder, Type);
			return IFastReturnEntityPos.EndIFastReturnEntityPos(builder);
		}

		// Token: 0x06017A6C RID: 96876 RVA: 0x0035F8CF File Offset: 0x0035DACF
		public static void StartIFastReturnEntityPos(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06017A6D RID: 96877 RVA: 0x0035F8D8 File Offset: 0x0035DAD8
		public static void AddType(FlatBufferBuilder builder, EFastReturnPosType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017A6E RID: 96878 RVA: 0x0035F8E3 File Offset: 0x0035DAE3
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x06017A6F RID: 96879 RVA: 0x0035F8EE File Offset: 0x0035DAEE
		public static void AddTransitionOptionType(FlatBufferBuilder builder, TTeleportTransitionOption transitionOptionType)
		{
			builder.AddByte(2, (byte)transitionOptionType, 0);
		}

		// Token: 0x06017A70 RID: 96880 RVA: 0x0035F8F9 File Offset: 0x0035DAF9
		public static void AddTransitionOption(FlatBufferBuilder builder, int transitionOptionOffset)
		{
			builder.AddOffset(3, transitionOptionOffset, 0);
		}

		// Token: 0x06017A71 RID: 96881 RVA: 0x0035F904 File Offset: 0x0035DB04
		public static Offset<IFastReturnEntityPos> EndIFastReturnEntityPos(FlatBufferBuilder builder)
		{
			return new Offset<IFastReturnEntityPos>(builder.EndTable());
		}

		// Token: 0x06017A72 RID: 96882 RVA: 0x0035F914 File Offset: 0x0035DB14
		public IFastReturnEntityPosT UnPack()
		{
			IFastReturnEntityPosT fastReturnEntityPosT = new IFastReturnEntityPosT();
			this.UnPackTo(fastReturnEntityPosT);
			return fastReturnEntityPosT;
		}

		// Token: 0x06017A73 RID: 96883 RVA: 0x0035F930 File Offset: 0x0035DB30
		public void UnPackTo(IFastReturnEntityPosT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.TransitionOption = new TTeleportTransitionOptionUnion();
			_o.TransitionOption.Type = this.TransitionOptionType;
			switch (this.TransitionOptionType)
			{
			case TTeleportTransitionOption.ITeleportTransitionInDigitalScreen:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionInDigitalScreen>() != null) ? this.TransitionOption<ITeleportTransitionInDigitalScreen>().Value.UnPack() : null);
				return;
			case TTeleportTransitionOption.ITeleportTransitionInSeamlessType:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionInSeamlessType>() != null) ? this.TransitionOption<ITeleportTransitionInSeamlessType>().Value.UnPack() : null);
				return;
			case TTeleportTransitionOption.ITeleportTransitionWithCenterText:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithCenterText>() != null) ? this.TransitionOption<ITeleportTransitionWithCenterText>().Value.UnPack() : null);
				return;
			case TTeleportTransitionOption.ITeleportTransitionWithCharacterDisplay:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithCharacterDisplay>() != null) ? this.TransitionOption<ITeleportTransitionWithCharacterDisplay>().Value.UnPack() : null);
				return;
			case TTeleportTransitionOption.ITeleportTransitionWithCustomLoading:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithCustomLoading>() != null) ? this.TransitionOption<ITeleportTransitionWithCustomLoading>().Value.UnPack() : null);
				return;
			case TTeleportTransitionOption.ITeleportTransitionWithCustomScreen:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithCustomScreen>() != null) ? this.TransitionOption<ITeleportTransitionWithCustomScreen>().Value.UnPack() : null);
				return;
			case TTeleportTransitionOption.ITeleportTransitionWithEffect:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithEffect>() != null) ? this.TransitionOption<ITeleportTransitionWithEffect>().Value.UnPack() : null);
				return;
			case TTeleportTransitionOption.ITeleportTransitionWithFadeInScreen:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithFadeInScreen>() != null) ? this.TransitionOption<ITeleportTransitionWithFadeInScreen>().Value.UnPack() : null);
				return;
			case TTeleportTransitionOption.ITeleportTransitionWithMp4:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithMp4>() != null) ? this.TransitionOption<ITeleportTransitionWithMp4>().Value.UnPack() : null);
				return;
			case TTeleportTransitionOption.ITeleportTransitionWithPlayFlow:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithPlayFlow>() != null) ? this.TransitionOption<ITeleportTransitionWithPlayFlow>().Value.UnPack() : null);
				return;
			case TTeleportTransitionOption.ITeleportTransitionWithSpecialCustomLoading:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithSpecialCustomLoading>() != null) ? this.TransitionOption<ITeleportTransitionWithSpecialCustomLoading>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06017A74 RID: 96884 RVA: 0x0035FC10 File Offset: 0x0035DE10
		public static Offset<IFastReturnEntityPos> Pack(FlatBufferBuilder builder, IFastReturnEntityPosT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFastReturnEntityPos>);
			}
			TTeleportTransitionOption transitionOption_type = (_o.TransitionOption == null) ? TTeleportTransitionOption.NONE : _o.TransitionOption.Type;
			int transitionOptionOffset = (_o.TransitionOption == null) ? 0 : TTeleportTransitionOptionUnion.Pack(builder, _o.TransitionOption);
			return IFastReturnEntityPos.CreateIFastReturnEntityPos(builder, _o.Type, _o.EntityId, transitionOption_type, transitionOptionOffset);
		}

		// Token: 0x0400C16F RID: 49519
		private Table __p;
	}
}
