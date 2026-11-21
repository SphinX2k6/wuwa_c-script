using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004253 RID: 16979
	public struct IFailedTeleport : IFlatbufferObject
	{
		// Token: 0x170073C0 RID: 29632
		// (get) Token: 0x06017A1F RID: 96799 RVA: 0x0035EBE4 File Offset: 0x0035CDE4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017A20 RID: 96800 RVA: 0x0035EBF1 File Offset: 0x0035CDF1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017A21 RID: 96801 RVA: 0x0035EBF8 File Offset: 0x0035CDF8
		public static IFailedTeleport GetRootAsIFailedTeleport(ByteBuffer _bb)
		{
			return IFailedTeleport.GetRootAsIFailedTeleport(_bb, default(IFailedTeleport));
		}

		// Token: 0x06017A22 RID: 96802 RVA: 0x0035EC14 File Offset: 0x0035CE14
		public static IFailedTeleport GetRootAsIFailedTeleport(ByteBuffer _bb, IFailedTeleport obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017A23 RID: 96803 RVA: 0x0035EC31 File Offset: 0x0035CE31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017A24 RID: 96804 RVA: 0x0035EC40 File Offset: 0x0035CE40
		public IFailedTeleport __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170073C1 RID: 29633
		// (get) Token: 0x06017A25 RID: 96805 RVA: 0x0035EC50 File Offset: 0x0035CE50
		public IPosA? Position
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IPosA?(default(IPosA).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170073C2 RID: 29634
		// (get) Token: 0x06017A26 RID: 96806 RVA: 0x0035ECB0 File Offset: 0x0035CEB0
		public int PositionEntityId
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

		// Token: 0x170073C3 RID: 29635
		// (get) Token: 0x06017A27 RID: 96807 RVA: 0x0035ECEC File Offset: 0x0035CEEC
		public bool IsConfirm
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170073C4 RID: 29636
		// (get) Token: 0x06017A28 RID: 96808 RVA: 0x0035ED2C File Offset: 0x0035CF2C
		public int ConfirmId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170073C5 RID: 29637
		// (get) Token: 0x06017A29 RID: 96809 RVA: 0x0035ED6C File Offset: 0x0035CF6C
		public TTeleportTransitionOption TransitionOptionType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return TTeleportTransitionOption.NONE;
				}
				return (TTeleportTransitionOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017A2A RID: 96810 RVA: 0x0035EDAC File Offset: 0x0035CFAC
		public TTable? TransitionOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017A2B RID: 96811 RVA: 0x0035EDF4 File Offset: 0x0035CFF4
		public ITeleportTransitionInDigitalScreen TransitionOptionAsITeleportTransitionInDigitalScreen()
		{
			return this.TransitionOption<ITeleportTransitionInDigitalScreen>().Value;
		}

		// Token: 0x06017A2C RID: 96812 RVA: 0x0035EE10 File Offset: 0x0035D010
		public ITeleportTransitionInSeamlessType TransitionOptionAsITeleportTransitionInSeamlessType()
		{
			return this.TransitionOption<ITeleportTransitionInSeamlessType>().Value;
		}

		// Token: 0x06017A2D RID: 96813 RVA: 0x0035EE2C File Offset: 0x0035D02C
		public ITeleportTransitionWithCenterText TransitionOptionAsITeleportTransitionWithCenterText()
		{
			return this.TransitionOption<ITeleportTransitionWithCenterText>().Value;
		}

		// Token: 0x06017A2E RID: 96814 RVA: 0x0035EE48 File Offset: 0x0035D048
		public ITeleportTransitionWithCharacterDisplay TransitionOptionAsITeleportTransitionWithCharacterDisplay()
		{
			return this.TransitionOption<ITeleportTransitionWithCharacterDisplay>().Value;
		}

		// Token: 0x06017A2F RID: 96815 RVA: 0x0035EE64 File Offset: 0x0035D064
		public ITeleportTransitionWithCustomLoading TransitionOptionAsITeleportTransitionWithCustomLoading()
		{
			return this.TransitionOption<ITeleportTransitionWithCustomLoading>().Value;
		}

		// Token: 0x06017A30 RID: 96816 RVA: 0x0035EE80 File Offset: 0x0035D080
		public ITeleportTransitionWithCustomScreen TransitionOptionAsITeleportTransitionWithCustomScreen()
		{
			return this.TransitionOption<ITeleportTransitionWithCustomScreen>().Value;
		}

		// Token: 0x06017A31 RID: 96817 RVA: 0x0035EE9C File Offset: 0x0035D09C
		public ITeleportTransitionWithEffect TransitionOptionAsITeleportTransitionWithEffect()
		{
			return this.TransitionOption<ITeleportTransitionWithEffect>().Value;
		}

		// Token: 0x06017A32 RID: 96818 RVA: 0x0035EEB8 File Offset: 0x0035D0B8
		public ITeleportTransitionWithFadeInScreen TransitionOptionAsITeleportTransitionWithFadeInScreen()
		{
			return this.TransitionOption<ITeleportTransitionWithFadeInScreen>().Value;
		}

		// Token: 0x06017A33 RID: 96819 RVA: 0x0035EED4 File Offset: 0x0035D0D4
		public ITeleportTransitionWithMp4 TransitionOptionAsITeleportTransitionWithMp4()
		{
			return this.TransitionOption<ITeleportTransitionWithMp4>().Value;
		}

		// Token: 0x06017A34 RID: 96820 RVA: 0x0035EEF0 File Offset: 0x0035D0F0
		public ITeleportTransitionWithPlayFlow TransitionOptionAsITeleportTransitionWithPlayFlow()
		{
			return this.TransitionOption<ITeleportTransitionWithPlayFlow>().Value;
		}

		// Token: 0x06017A35 RID: 96821 RVA: 0x0035EF0C File Offset: 0x0035D10C
		public ITeleportTransitionWithSpecialCustomLoading TransitionOptionAsITeleportTransitionWithSpecialCustomLoading()
		{
			return this.TransitionOption<ITeleportTransitionWithSpecialCustomLoading>().Value;
		}

		// Token: 0x170073C6 RID: 29638
		// (get) Token: 0x06017A36 RID: 96822 RVA: 0x0035EF28 File Offset: 0x0035D128
		public bool GravityFlip
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170073C7 RID: 29639
		// (get) Token: 0x06017A37 RID: 96823 RVA: 0x0035EF68 File Offset: 0x0035D168
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017A38 RID: 96824 RVA: 0x0035EFA8 File Offset: 0x0035D1A8
		public static Offset<IFailedTeleport> CreateIFailedTeleport(FlatBufferBuilder builder, Offset<IPosA> PositionOffset = default(Offset<IPosA>), int PositionEntityId = 0, bool IsConfirm = false, int ConfirmId = 0, TTeleportTransitionOption TransitionOption_type = TTeleportTransitionOption.NONE, int TransitionOptionOffset = 0, bool GravityFlip = false, byte NullMask = 0)
		{
			builder.StartTable(8);
			IFailedTeleport.AddTransitionOption(builder, TransitionOptionOffset);
			IFailedTeleport.AddConfirmId(builder, ConfirmId);
			IFailedTeleport.AddPositionEntityId(builder, PositionEntityId);
			IFailedTeleport.AddPosition(builder, PositionOffset);
			IFailedTeleport.AddNullMask(builder, NullMask);
			IFailedTeleport.AddGravityFlip(builder, GravityFlip);
			IFailedTeleport.AddTransitionOptionType(builder, TransitionOption_type);
			IFailedTeleport.AddIsConfirm(builder, IsConfirm);
			return IFailedTeleport.EndIFailedTeleport(builder);
		}

		// Token: 0x06017A39 RID: 96825 RVA: 0x0035EFFF File Offset: 0x0035D1FF
		public static void StartIFailedTeleport(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06017A3A RID: 96826 RVA: 0x0035F008 File Offset: 0x0035D208
		public static void AddPosition(FlatBufferBuilder builder, Offset<IPosA> positionOffset)
		{
			builder.AddOffset(0, positionOffset.Value, 0);
		}

		// Token: 0x06017A3B RID: 96827 RVA: 0x0035F018 File Offset: 0x0035D218
		public static void AddPositionEntityId(FlatBufferBuilder builder, int positionEntityId)
		{
			builder.AddInt(1, positionEntityId, 0);
		}

		// Token: 0x06017A3C RID: 96828 RVA: 0x0035F023 File Offset: 0x0035D223
		public static void AddIsConfirm(FlatBufferBuilder builder, bool isConfirm)
		{
			builder.AddBool(2, isConfirm, false);
		}

		// Token: 0x06017A3D RID: 96829 RVA: 0x0035F02E File Offset: 0x0035D22E
		public static void AddConfirmId(FlatBufferBuilder builder, int confirmId)
		{
			builder.AddInt(3, confirmId, 0);
		}

		// Token: 0x06017A3E RID: 96830 RVA: 0x0035F039 File Offset: 0x0035D239
		public static void AddTransitionOptionType(FlatBufferBuilder builder, TTeleportTransitionOption transitionOptionType)
		{
			builder.AddByte(4, (byte)transitionOptionType, 0);
		}

		// Token: 0x06017A3F RID: 96831 RVA: 0x0035F044 File Offset: 0x0035D244
		public static void AddTransitionOption(FlatBufferBuilder builder, int transitionOptionOffset)
		{
			builder.AddOffset(5, transitionOptionOffset, 0);
		}

		// Token: 0x06017A40 RID: 96832 RVA: 0x0035F04F File Offset: 0x0035D24F
		public static void AddGravityFlip(FlatBufferBuilder builder, bool gravityFlip)
		{
			builder.AddBool(6, gravityFlip, false);
		}

		// Token: 0x06017A41 RID: 96833 RVA: 0x0035F05A File Offset: 0x0035D25A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06017A42 RID: 96834 RVA: 0x0035F065 File Offset: 0x0035D265
		public static Offset<IFailedTeleport> EndIFailedTeleport(FlatBufferBuilder builder)
		{
			return new Offset<IFailedTeleport>(builder.EndTable());
		}

		// Token: 0x06017A43 RID: 96835 RVA: 0x0035F074 File Offset: 0x0035D274
		public IFailedTeleportT UnPack()
		{
			IFailedTeleportT failedTeleportT = new IFailedTeleportT();
			this.UnPackTo(failedTeleportT);
			return failedTeleportT;
		}

		// Token: 0x06017A44 RID: 96836 RVA: 0x0035F090 File Offset: 0x0035D290
		public void UnPackTo(IFailedTeleportT _o)
		{
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
			_o.PositionEntityId = this.PositionEntityId;
			_o.IsConfirm = this.IsConfirm;
			_o.ConfirmId = this.ConfirmId;
			_o.TransitionOption = new TTeleportTransitionOptionUnion();
			_o.TransitionOption.Type = this.TransitionOptionType;
			switch (this.TransitionOptionType)
			{
			case TTeleportTransitionOption.ITeleportTransitionInDigitalScreen:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionInDigitalScreen>() != null) ? this.TransitionOption<ITeleportTransitionInDigitalScreen>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionInSeamlessType:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionInSeamlessType>() != null) ? this.TransitionOption<ITeleportTransitionInSeamlessType>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithCenterText:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithCenterText>() != null) ? this.TransitionOption<ITeleportTransitionWithCenterText>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithCharacterDisplay:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithCharacterDisplay>() != null) ? this.TransitionOption<ITeleportTransitionWithCharacterDisplay>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithCustomLoading:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithCustomLoading>() != null) ? this.TransitionOption<ITeleportTransitionWithCustomLoading>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithCustomScreen:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithCustomScreen>() != null) ? this.TransitionOption<ITeleportTransitionWithCustomScreen>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithEffect:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithEffect>() != null) ? this.TransitionOption<ITeleportTransitionWithEffect>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithFadeInScreen:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithFadeInScreen>() != null) ? this.TransitionOption<ITeleportTransitionWithFadeInScreen>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithMp4:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithMp4>() != null) ? this.TransitionOption<ITeleportTransitionWithMp4>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithPlayFlow:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithPlayFlow>() != null) ? this.TransitionOption<ITeleportTransitionWithPlayFlow>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithSpecialCustomLoading:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithSpecialCustomLoading>() != null) ? this.TransitionOption<ITeleportTransitionWithSpecialCustomLoading>().Value.UnPack() : null);
				break;
			}
			_o.GravityFlip = this.GravityFlip;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06017A45 RID: 96837 RVA: 0x0035F3EC File Offset: 0x0035D5EC
		public static Offset<IFailedTeleport> Pack(FlatBufferBuilder builder, IFailedTeleportT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFailedTeleport>);
			}
			Offset<IPosA> positionOffset = (_o.Position == null) ? default(Offset<IPosA>) : IPosA.Pack(builder, _o.Position);
			TTeleportTransitionOption transitionOption_type = (_o.TransitionOption == null) ? TTeleportTransitionOption.NONE : _o.TransitionOption.Type;
			int transitionOptionOffset = (_o.TransitionOption == null) ? 0 : TTeleportTransitionOptionUnion.Pack(builder, _o.TransitionOption);
			return IFailedTeleport.CreateIFailedTeleport(builder, positionOffset, _o.PositionEntityId, _o.IsConfirm, _o.ConfirmId, transitionOption_type, transitionOptionOffset, _o.GravityFlip, _o.NullMask);
		}

		// Token: 0x0400C167 RID: 49511
		private Table __p;
	}
}
