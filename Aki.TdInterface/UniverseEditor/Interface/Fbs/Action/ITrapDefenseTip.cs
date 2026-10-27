using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200746C RID: 29804
	public struct ITrapDefenseTip : IFlatbufferObject
	{
		// Token: 0x1700E233 RID: 57907
		// (get) Token: 0x0603624A RID: 221770 RVA: 0x0075C85E File Offset: 0x0075AA5E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603624B RID: 221771 RVA: 0x0075C86B File Offset: 0x0075AA6B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603624C RID: 221772 RVA: 0x0075C874 File Offset: 0x0075AA74
		public static ITrapDefenseTip GetRootAsITrapDefenseTip(ByteBuffer _bb)
		{
			return ITrapDefenseTip.GetRootAsITrapDefenseTip(_bb, default(ITrapDefenseTip));
		}

		// Token: 0x0603624D RID: 221773 RVA: 0x0075C890 File Offset: 0x0075AA90
		public static ITrapDefenseTip GetRootAsITrapDefenseTip(ByteBuffer _bb, ITrapDefenseTip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603624E RID: 221774 RVA: 0x0075C8AD File Offset: 0x0075AAAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603624F RID: 221775 RVA: 0x0075C8BC File Offset: 0x0075AABC
		public ITrapDefenseTip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E234 RID: 57908
		// (get) Token: 0x06036250 RID: 221776 RVA: 0x0075C8CC File Offset: 0x0075AACC
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

		// Token: 0x1700E235 RID: 57909
		// (get) Token: 0x06036251 RID: 221777 RVA: 0x0075C908 File Offset: 0x0075AB08
		public string MainText
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

		// Token: 0x06036252 RID: 221778 RVA: 0x0075C93F File Offset: 0x0075AB3F
		public Span<byte> GetMainTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06036253 RID: 221779 RVA: 0x0075C94E File Offset: 0x0075AB4E
		public byte[] GetMainTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700E236 RID: 57910
		// (get) Token: 0x06036254 RID: 221780 RVA: 0x0075C95C File Offset: 0x0075AB5C
		public ETrapDefenseTipType TipType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ETrapDefenseTipType.OpenNewAreaTip;
				}
				return (ETrapDefenseTipType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036255 RID: 221781 RVA: 0x0075C998 File Offset: 0x0075AB98
		public static Offset<ITrapDefenseTip> CreateITrapDefenseTip(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset MainTextOffset = default(StringOffset), ETrapDefenseTipType TipType = ETrapDefenseTipType.OpenNewAreaTip)
		{
			builder.StartTable(3);
			ITrapDefenseTip.AddMainText(builder, MainTextOffset);
			ITrapDefenseTip.AddTipType(builder, TipType);
			ITrapDefenseTip.AddType(builder, Type);
			return ITrapDefenseTip.EndITrapDefenseTip(builder);
		}

		// Token: 0x06036256 RID: 221782 RVA: 0x0075C9BC File Offset: 0x0075ABBC
		public static void StartITrapDefenseTip(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06036257 RID: 221783 RVA: 0x0075C9C5 File Offset: 0x0075ABC5
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036258 RID: 221784 RVA: 0x0075C9D0 File Offset: 0x0075ABD0
		public static void AddMainText(FlatBufferBuilder builder, StringOffset mainTextOffset)
		{
			builder.AddOffset(1, mainTextOffset.Value, 0);
		}

		// Token: 0x06036259 RID: 221785 RVA: 0x0075C9E0 File Offset: 0x0075ABE0
		public static void AddTipType(FlatBufferBuilder builder, ETrapDefenseTipType tipType)
		{
			builder.AddByte(2, (byte)tipType, 0);
		}

		// Token: 0x0603625A RID: 221786 RVA: 0x0075C9EB File Offset: 0x0075ABEB
		public static Offset<ITrapDefenseTip> EndITrapDefenseTip(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefenseTip>(builder.EndTable());
		}

		// Token: 0x0603625B RID: 221787 RVA: 0x0075C9F8 File Offset: 0x0075ABF8
		public ITrapDefenseTipT UnPack()
		{
			ITrapDefenseTipT trapDefenseTipT = new ITrapDefenseTipT();
			this.UnPackTo(trapDefenseTipT);
			return trapDefenseTipT;
		}

		// Token: 0x0603625C RID: 221788 RVA: 0x0075CA13 File Offset: 0x0075AC13
		public void UnPackTo(ITrapDefenseTipT _o)
		{
			_o.Type = this.Type;
			_o.MainText = this.MainText;
			_o.TipType = this.TipType;
		}

		// Token: 0x0603625D RID: 221789 RVA: 0x0075CA3C File Offset: 0x0075AC3C
		public static Offset<ITrapDefenseTip> Pack(FlatBufferBuilder builder, ITrapDefenseTipT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefenseTip>);
			}
			StringOffset mainTextOffset = (_o.MainText == null) ? default(StringOffset) : builder.CreateString(_o.MainText);
			return ITrapDefenseTip.CreateITrapDefenseTip(builder, _o.Type, mainTextOffset, _o.TipType);
		}

		// Token: 0x040122F7 RID: 74487
		private Table __p;
	}
}
