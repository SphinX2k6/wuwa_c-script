using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BBE RID: 27582
	public struct INpcLeisureInteract : IFlatbufferObject
	{
		// Token: 0x1700CCFC RID: 52476
		// (get) Token: 0x06030737 RID: 198455 RVA: 0x0069459E File Offset: 0x0069279E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030738 RID: 198456 RVA: 0x006945AB File Offset: 0x006927AB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030739 RID: 198457 RVA: 0x006945B4 File Offset: 0x006927B4
		public static INpcLeisureInteract GetRootAsINpcLeisureInteract(ByteBuffer _bb)
		{
			return INpcLeisureInteract.GetRootAsINpcLeisureInteract(_bb, default(INpcLeisureInteract));
		}

		// Token: 0x0603073A RID: 198458 RVA: 0x006945D0 File Offset: 0x006927D0
		public static INpcLeisureInteract GetRootAsINpcLeisureInteract(ByteBuffer _bb, INpcLeisureInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603073B RID: 198459 RVA: 0x006945ED File Offset: 0x006927ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603073C RID: 198460 RVA: 0x006945FC File Offset: 0x006927FC
		public INpcLeisureInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CCFD RID: 52477
		// (get) Token: 0x0603073D RID: 198461 RVA: 0x0069460C File Offset: 0x0069280C
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

		// Token: 0x0603073E RID: 198462 RVA: 0x00694648 File Offset: 0x00692848
		public TTable? Option<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603073F RID: 198463 RVA: 0x0069468C File Offset: 0x0069288C
		public INpcExitCurrentInteract OptionAsINpcExitCurrentInteract()
		{
			return this.Option<INpcExitCurrentInteract>().Value;
		}

		// Token: 0x06030740 RID: 198464 RVA: 0x006946A8 File Offset: 0x006928A8
		public INpcSitDown OptionAsINpcSitDown()
		{
			return this.Option<INpcSitDown>().Value;
		}

		// Token: 0x06030741 RID: 198465 RVA: 0x006946C4 File Offset: 0x006928C4
		public INpcSwing OptionAsINpcSwing()
		{
			return this.Option<INpcSwing>().Value;
		}

		// Token: 0x06030742 RID: 198466 RVA: 0x006946E0 File Offset: 0x006928E0
		public INpcSwingGetUp OptionAsINpcSwingGetUp()
		{
			return this.Option<INpcSwingGetUp>().Value;
		}

		// Token: 0x06030743 RID: 198467 RVA: 0x006946FB File Offset: 0x006928FB
		public static Offset<INpcLeisureInteract> CreateINpcLeisureInteract(FlatBufferBuilder builder, TNpcLeisureInteractOp Option_type = TNpcLeisureInteractOp.NONE, int OptionOffset = 0)
		{
			builder.StartTable(2);
			INpcLeisureInteract.AddOption(builder, OptionOffset);
			INpcLeisureInteract.AddOptionType(builder, Option_type);
			return INpcLeisureInteract.EndINpcLeisureInteract(builder);
		}

		// Token: 0x06030744 RID: 198468 RVA: 0x00694718 File Offset: 0x00692918
		public static void StartINpcLeisureInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030745 RID: 198469 RVA: 0x00694721 File Offset: 0x00692921
		public static void AddOptionType(FlatBufferBuilder builder, TNpcLeisureInteractOp optionType)
		{
			builder.AddByte(0, (byte)optionType, 0);
		}

		// Token: 0x06030746 RID: 198470 RVA: 0x0069472C File Offset: 0x0069292C
		public static void AddOption(FlatBufferBuilder builder, int optionOffset)
		{
			builder.AddOffset(1, optionOffset, 0);
		}

		// Token: 0x06030747 RID: 198471 RVA: 0x00694737 File Offset: 0x00692937
		public static Offset<INpcLeisureInteract> EndINpcLeisureInteract(FlatBufferBuilder builder)
		{
			return new Offset<INpcLeisureInteract>(builder.EndTable());
		}

		// Token: 0x06030748 RID: 198472 RVA: 0x00694744 File Offset: 0x00692944
		public INpcLeisureInteractT UnPack()
		{
			INpcLeisureInteractT npcLeisureInteractT = new INpcLeisureInteractT();
			this.UnPackTo(npcLeisureInteractT);
			return npcLeisureInteractT;
		}

		// Token: 0x06030749 RID: 198473 RVA: 0x00694760 File Offset: 0x00692960
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

		// Token: 0x0603074A RID: 198474 RVA: 0x00694884 File Offset: 0x00692A84
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

		// Token: 0x04011495 RID: 70805
		private Table __p;
	}
}
