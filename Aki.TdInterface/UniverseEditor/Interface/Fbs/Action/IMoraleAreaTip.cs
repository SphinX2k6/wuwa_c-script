using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200723D RID: 29245
	public struct IMoraleAreaTip : IFlatbufferObject
	{
		// Token: 0x1700D638 RID: 54840
		// (get) Token: 0x06032EA2 RID: 208546 RVA: 0x006DFC44 File Offset: 0x006DDE44
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032EA3 RID: 208547 RVA: 0x006DFC51 File Offset: 0x006DDE51
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032EA4 RID: 208548 RVA: 0x006DFC58 File Offset: 0x006DDE58
		public static IMoraleAreaTip GetRootAsIMoraleAreaTip(ByteBuffer _bb)
		{
			return IMoraleAreaTip.GetRootAsIMoraleAreaTip(_bb, default(IMoraleAreaTip));
		}

		// Token: 0x06032EA5 RID: 208549 RVA: 0x006DFC74 File Offset: 0x006DDE74
		public static IMoraleAreaTip GetRootAsIMoraleAreaTip(ByteBuffer _bb, IMoraleAreaTip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032EA6 RID: 208550 RVA: 0x006DFC91 File Offset: 0x006DDE91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032EA7 RID: 208551 RVA: 0x006DFCA0 File Offset: 0x006DDEA0
		public IMoraleAreaTip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D639 RID: 54841
		// (get) Token: 0x06032EA8 RID: 208552 RVA: 0x006DFCB0 File Offset: 0x006DDEB0
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

		// Token: 0x1700D63A RID: 54842
		// (get) Token: 0x06032EA9 RID: 208553 RVA: 0x006DFCEC File Offset: 0x006DDEEC
		public string TidAreaNameText
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

		// Token: 0x06032EAA RID: 208554 RVA: 0x006DFD23 File Offset: 0x006DDF23
		public Span<byte> GetTidAreaNameTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06032EAB RID: 208555 RVA: 0x006DFD32 File Offset: 0x006DDF32
		public byte[] GetTidAreaNameTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700D63B RID: 54843
		// (get) Token: 0x06032EAC RID: 208556 RVA: 0x006DFD40 File Offset: 0x006DDF40
		public string TidRecommendText
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

		// Token: 0x06032EAD RID: 208557 RVA: 0x006DFD77 File Offset: 0x006DDF77
		public Span<byte> GetTidRecommendTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06032EAE RID: 208558 RVA: 0x006DFD86 File Offset: 0x006DDF86
		public byte[] GetTidRecommendTextArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700D63C RID: 54844
		// (get) Token: 0x06032EAF RID: 208559 RVA: 0x006DFD94 File Offset: 0x006DDF94
		public EMoraleAreaType AreaType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return EMoraleAreaType.MoraleArea1;
				}
				return (EMoraleAreaType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D63D RID: 54845
		// (get) Token: 0x06032EB0 RID: 208560 RVA: 0x006DFDD4 File Offset: 0x006DDFD4
		public EMoraleUiType UiType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return EMoraleUiType.MoraleUi24;
				}
				return (EMoraleUiType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D63E RID: 54846
		// (get) Token: 0x06032EB1 RID: 208561 RVA: 0x006DFE14 File Offset: 0x006DE014
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032EB2 RID: 208562 RVA: 0x006DFE51 File Offset: 0x006DE051
		public static Offset<IMoraleAreaTip> CreateIMoraleAreaTip(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset TidAreaNameTextOffset = default(StringOffset), StringOffset TidRecommendTextOffset = default(StringOffset), EMoraleAreaType AreaType = EMoraleAreaType.MoraleArea1, EMoraleUiType UiType = EMoraleUiType.MoraleUi24, byte NullMask = 0)
		{
			builder.StartTable(6);
			IMoraleAreaTip.AddTidRecommendText(builder, TidRecommendTextOffset);
			IMoraleAreaTip.AddTidAreaNameText(builder, TidAreaNameTextOffset);
			IMoraleAreaTip.AddNullMask(builder, NullMask);
			IMoraleAreaTip.AddUiType(builder, UiType);
			IMoraleAreaTip.AddAreaType(builder, AreaType);
			IMoraleAreaTip.AddType(builder, Type);
			return IMoraleAreaTip.EndIMoraleAreaTip(builder);
		}

		// Token: 0x06032EB3 RID: 208563 RVA: 0x006DFE8D File Offset: 0x006DE08D
		public static void StartIMoraleAreaTip(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06032EB4 RID: 208564 RVA: 0x006DFE96 File Offset: 0x006DE096
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032EB5 RID: 208565 RVA: 0x006DFEA1 File Offset: 0x006DE0A1
		public static void AddTidAreaNameText(FlatBufferBuilder builder, StringOffset tidAreaNameTextOffset)
		{
			builder.AddOffset(1, tidAreaNameTextOffset.Value, 0);
		}

		// Token: 0x06032EB6 RID: 208566 RVA: 0x006DFEB1 File Offset: 0x006DE0B1
		public static void AddTidRecommendText(FlatBufferBuilder builder, StringOffset tidRecommendTextOffset)
		{
			builder.AddOffset(2, tidRecommendTextOffset.Value, 0);
		}

		// Token: 0x06032EB7 RID: 208567 RVA: 0x006DFEC1 File Offset: 0x006DE0C1
		public static void AddAreaType(FlatBufferBuilder builder, EMoraleAreaType areaType)
		{
			builder.AddByte(3, (byte)areaType, 0);
		}

		// Token: 0x06032EB8 RID: 208568 RVA: 0x006DFECC File Offset: 0x006DE0CC
		public static void AddUiType(FlatBufferBuilder builder, EMoraleUiType uiType)
		{
			builder.AddByte(4, (byte)uiType, 0);
		}

		// Token: 0x06032EB9 RID: 208569 RVA: 0x006DFED7 File Offset: 0x006DE0D7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06032EBA RID: 208570 RVA: 0x006DFEE2 File Offset: 0x006DE0E2
		public static Offset<IMoraleAreaTip> EndIMoraleAreaTip(FlatBufferBuilder builder)
		{
			return new Offset<IMoraleAreaTip>(builder.EndTable());
		}

		// Token: 0x06032EBB RID: 208571 RVA: 0x006DFEF0 File Offset: 0x006DE0F0
		public IMoraleAreaTipT UnPack()
		{
			IMoraleAreaTipT moraleAreaTipT = new IMoraleAreaTipT();
			this.UnPackTo(moraleAreaTipT);
			return moraleAreaTipT;
		}

		// Token: 0x06032EBC RID: 208572 RVA: 0x006DFF0C File Offset: 0x006DE10C
		public void UnPackTo(IMoraleAreaTipT _o)
		{
			_o.Type = this.Type;
			_o.TidAreaNameText = this.TidAreaNameText;
			_o.TidRecommendText = this.TidRecommendText;
			_o.AreaType = this.AreaType;
			_o.UiType = this.UiType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06032EBD RID: 208573 RVA: 0x006DFF64 File Offset: 0x006DE164
		public static Offset<IMoraleAreaTip> Pack(FlatBufferBuilder builder, IMoraleAreaTipT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMoraleAreaTip>);
			}
			StringOffset tidAreaNameTextOffset = (_o.TidAreaNameText == null) ? default(StringOffset) : builder.CreateString(_o.TidAreaNameText);
			StringOffset tidRecommendTextOffset = (_o.TidRecommendText == null) ? default(StringOffset) : builder.CreateString(_o.TidRecommendText);
			return IMoraleAreaTip.CreateIMoraleAreaTip(builder, _o.Type, tidAreaNameTextOffset, tidRecommendTextOffset, _o.AreaType, _o.UiType, _o.NullMask);
		}

		// Token: 0x0401228A RID: 74378
		private Table __p;
	}
}
