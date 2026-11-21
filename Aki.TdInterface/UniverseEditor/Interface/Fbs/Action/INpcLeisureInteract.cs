using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007322 RID: 29474
	public struct INpcLeisureInteract : IFlatbufferObject
	{
		// Token: 0x1700D808 RID: 55304
		// (get) Token: 0x06033653 RID: 210515 RVA: 0x006EDE9F File Offset: 0x006EC09F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033654 RID: 210516 RVA: 0x006EDEAC File Offset: 0x006EC0AC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033655 RID: 210517 RVA: 0x006EDEB4 File Offset: 0x006EC0B4
		public static INpcLeisureInteract GetRootAsINpcLeisureInteract(ByteBuffer _bb)
		{
			return INpcLeisureInteract.GetRootAsINpcLeisureInteract(_bb, default(INpcLeisureInteract));
		}

		// Token: 0x06033656 RID: 210518 RVA: 0x006EDED0 File Offset: 0x006EC0D0
		public static INpcLeisureInteract GetRootAsINpcLeisureInteract(ByteBuffer _bb, INpcLeisureInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033657 RID: 210519 RVA: 0x006EDEED File Offset: 0x006EC0ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033658 RID: 210520 RVA: 0x006EDEFC File Offset: 0x006EC0FC
		public INpcLeisureInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D809 RID: 55305
		// (get) Token: 0x06033659 RID: 210521 RVA: 0x006EDF0C File Offset: 0x006EC10C
		public TNpcLeisureInteractOp OptionType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TNpcLeisureInteractOp.NONE;
				}
				return (TNpcLeisureInteractOp)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603365A RID: 210522 RVA: 0x006EDF48 File Offset: 0x006EC148
		public TTable? Option<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603365B RID: 210523 RVA: 0x006EDF8C File Offset: 0x006EC18C
		public INpcExitCurrentInteract OptionAsINpcExitCurrentInteract()
		{
			return this.Option<INpcExitCurrentInteract>().Value;
		}

		// Token: 0x0603365C RID: 210524 RVA: 0x006EDFA8 File Offset: 0x006EC1A8
		public INpcSitDown OptionAsINpcSitDown()
		{
			return this.Option<INpcSitDown>().Value;
		}

		// Token: 0x0603365D RID: 210525 RVA: 0x006EDFC4 File Offset: 0x006EC1C4
		public INpcSwing OptionAsINpcSwing()
		{
			return this.Option<INpcSwing>().Value;
		}

		// Token: 0x0603365E RID: 210526 RVA: 0x006EDFE0 File Offset: 0x006EC1E0
		public INpcSwingGetUp OptionAsINpcSwingGetUp()
		{
			return this.Option<INpcSwingGetUp>().Value;
		}

		// Token: 0x0603365F RID: 210527 RVA: 0x006EDFFB File Offset: 0x006EC1FB
		public static Offset<INpcLeisureInteract> CreateINpcLeisureInteract(FlatBufferBuilder builder, TNpcLeisureInteractOp Option_type = TNpcLeisureInteractOp.NONE, int OptionOffset = 0)
		{
			builder.StartTable(2);
			INpcLeisureInteract.AddOption(builder, OptionOffset);
			INpcLeisureInteract.AddOptionType(builder, Option_type);
			return INpcLeisureInteract.EndINpcLeisureInteract(builder);
		}

		// Token: 0x06033660 RID: 210528 RVA: 0x006EE018 File Offset: 0x006EC218
		public static void StartINpcLeisureInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06033661 RID: 210529 RVA: 0x006EE021 File Offset: 0x006EC221
		public static void AddOptionType(FlatBufferBuilder builder, TNpcLeisureInteractOp optionType)
		{
			builder.AddByte(0, (byte)optionType, 0);
		}

		// Token: 0x06033662 RID: 210530 RVA: 0x006EE02C File Offset: 0x006EC22C
		public static void AddOption(FlatBufferBuilder builder, int optionOffset)
		{
			builder.AddOffset(1, optionOffset, 0);
		}

		// Token: 0x06033663 RID: 210531 RVA: 0x006EE037 File Offset: 0x006EC237
		public static Offset<INpcLeisureInteract> EndINpcLeisureInteract(FlatBufferBuilder builder)
		{
			return new Offset<INpcLeisureInteract>(builder.EndTable());
		}

		// Token: 0x06033664 RID: 210532 RVA: 0x006EE044 File Offset: 0x006EC244
		public INpcLeisureInteractT UnPack()
		{
			INpcLeisureInteractT npcLeisureInteractT = new INpcLeisureInteractT();
			this.UnPackTo(npcLeisureInteractT);
			return npcLeisureInteractT;
		}

		// Token: 0x06033665 RID: 210533 RVA: 0x006EE060 File Offset: 0x006EC260
		public void UnPackTo(INpcLeisureInteractT _o)
		{
			_o.Option = new TNpcLeisureInteractOpUnion();
			_o.Option.Type = this.OptionType;
			switch (this.OptionType)
			{
			case TNpcLeisureInteractOp.INpcExitCurrentInteract:
				_o.Option.Value = ((this.Option<INpcExitCurrentInteract>() != null) ? this.Option<INpcExitCurrentInteract>().Value.UnPack() : null);
				return;
			case TNpcLeisureInteractOp.INpcSitDown:
				_o.Option.Value = ((this.Option<INpcSitDown>() != null) ? this.Option<INpcSitDown>().Value.UnPack() : null);
				return;
			case TNpcLeisureInteractOp.INpcSwing:
				_o.Option.Value = ((this.Option<INpcSwing>() != null) ? this.Option<INpcSwing>().Value.UnPack() : null);
				return;
			case TNpcLeisureInteractOp.INpcSwingGetUp:
				_o.Option.Value = ((this.Option<INpcSwingGetUp>() != null) ? this.Option<INpcSwingGetUp>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06033666 RID: 210534 RVA: 0x006EE184 File Offset: 0x006EC384
		public static Offset<INpcLeisureInteract> Pack(FlatBufferBuilder builder, INpcLeisureInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcLeisureInteract>);
			}
			TNpcLeisureInteractOp option_type = (_o.Option == null) ? TNpcLeisureInteractOp.NONE : _o.Option.Type;
			int optionOffset = (_o.Option == null) ? 0 : TNpcLeisureInteractOpUnion.Pack(builder, _o.Option);
			return INpcLeisureInteract.CreateINpcLeisureInteract(builder, option_type, optionOffset);
		}

		// Token: 0x040123E4 RID: 74724
		private Table __p;
	}
}
