using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200731F RID: 29471
	public struct ITalkOption : IFlatbufferObject
	{
		// Token: 0x1700DFCB RID: 57291
		// (get) Token: 0x0603577B RID: 219003 RVA: 0x00748A85 File Offset: 0x00746C85
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603577C RID: 219004 RVA: 0x00748A92 File Offset: 0x00746C92
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603577D RID: 219005 RVA: 0x00748A9C File Offset: 0x00746C9C
		public static ITalkOption GetRootAsITalkOption(ByteBuffer _bb)
		{
			return ITalkOption.GetRootAsITalkOption(_bb, default(ITalkOption));
		}

		// Token: 0x0603577E RID: 219006 RVA: 0x00748AB8 File Offset: 0x00746CB8
		public static ITalkOption GetRootAsITalkOption(ByteBuffer _bb, ITalkOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603577F RID: 219007 RVA: 0x00748AD5 File Offset: 0x00746CD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035780 RID: 219008 RVA: 0x00748AE4 File Offset: 0x00746CE4
		public ITalkOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DFCC RID: 57292
		// (get) Token: 0x06035781 RID: 219009 RVA: 0x00748AF4 File Offset: 0x00746CF4
		public string TidTalkOption
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035782 RID: 219010 RVA: 0x00748B2B File Offset: 0x00746D2B
		public Span<byte> GetTidTalkOptionBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06035783 RID: 219011 RVA: 0x00748B3A File Offset: 0x00746D3A
		public byte[] GetTidTalkOptionArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700DFCD RID: 57293
		// (get) Token: 0x06035784 RID: 219012 RVA: 0x00748B48 File Offset: 0x00746D48
		public int TextId
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

		// Token: 0x1700DFCE RID: 57294
		// (get) Token: 0x06035785 RID: 219013 RVA: 0x00748B84 File Offset: 0x00746D84
		public int PlotLineId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DFCF RID: 57295
		// (get) Token: 0x06035786 RID: 219014 RVA: 0x00748BC0 File Offset: 0x00746DC0
		public string PlotLineKey
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035787 RID: 219015 RVA: 0x00748BF8 File Offset: 0x00746DF8
		public Span<byte> GetPlotLineKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06035788 RID: 219016 RVA: 0x00748C08 File Offset: 0x00746E08
		public byte[] GetPlotLineKeyArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700DFD0 RID: 57296
		// (get) Token: 0x06035789 RID: 219017 RVA: 0x00748C18 File Offset: 0x00746E18
		public int Icon
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DFD1 RID: 57297
		// (get) Token: 0x0603578A RID: 219018 RVA: 0x00748C58 File Offset: 0x00746E58
		public IChangeIcon? ChangeIcon
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IChangeIcon?(default(IChangeIcon).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700DFD2 RID: 57298
		// (get) Token: 0x0603578B RID: 219019 RVA: 0x00748CB8 File Offset: 0x00746EB8
		public bool ReadMarkEnabled
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0603578C RID: 219020 RVA: 0x00748CF8 File Offset: 0x00746EF8
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DFD3 RID: 57299
		// (get) Token: 0x0603578D RID: 219021 RVA: 0x00748D5C File Offset: 0x00746F5C
		public int ActionsLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700DFD4 RID: 57300
		// (get) Token: 0x0603578E RID: 219022 RVA: 0x00748D88 File Offset: 0x00746F88
		public ETalkOptionStyle OptionStyle
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return ETalkOptionStyle.Default;
				}
				return (ETalkOptionStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DFD5 RID: 57301
		// (get) Token: 0x0603578F RID: 219023 RVA: 0x00748DC8 File Offset: 0x00746FC8
		public TTalkOptionPreCondition PreConditionType
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return TTalkOptionPreCondition.NONE;
				}
				return (TTalkOptionPreCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035790 RID: 219024 RVA: 0x00748E08 File Offset: 0x00747008
		public TTable? PreCondition<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06035791 RID: 219025 RVA: 0x00748E50 File Offset: 0x00747050
		public ITalkOptionCondition PreConditionAsITalkOptionCondition()
		{
			return this.PreCondition<ITalkOptionCondition>().Value;
		}

		// Token: 0x06035792 RID: 219026 RVA: 0x00748E6C File Offset: 0x0074706C
		public ITalkOptionFirstSelect PreConditionAsITalkOptionFirstSelect()
		{
			return this.PreCondition<ITalkOptionFirstSelect>().Value;
		}

		// Token: 0x06035793 RID: 219027 RVA: 0x00748E88 File Offset: 0x00747088
		public ITalkOptionPreOption PreConditionAsITalkOptionPreOption()
		{
			return this.PreCondition<ITalkOptionPreOption>().Value;
		}

		// Token: 0x06035794 RID: 219028 RVA: 0x00748EA4 File Offset: 0x007470A4
		public ITalkOptionSystemCondition PreConditionAsITalkOptionSystemCondition()
		{
			return this.PreCondition<ITalkOptionSystemCondition>().Value;
		}

		// Token: 0x1700DFD6 RID: 57302
		// (get) Token: 0x06035795 RID: 219029 RVA: 0x00748EC0 File Offset: 0x007470C0
		public bool _Folded
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DFD7 RID: 57303
		// (get) Token: 0x06035796 RID: 219030 RVA: 0x00748F00 File Offset: 0x00747100
		public EEditFlag _EditFlag
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return EEditFlag.Add;
				}
				return (EEditFlag)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DFD8 RID: 57304
		// (get) Token: 0x06035797 RID: 219031 RVA: 0x00748F40 File Offset: 0x00747140
		public IOptionLockTip? OptionLockTip
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return new IOptionLockTip?(default(IOptionLockTip).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700DFD9 RID: 57305
		// (get) Token: 0x06035798 RID: 219032 RVA: 0x00748FA0 File Offset: 0x007471A0
		public TTalkOptionParam TypeParamsType
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return TTalkOptionParam.NONE;
				}
				return (TTalkOptionParam)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035799 RID: 219033 RVA: 0x00748FE0 File Offset: 0x007471E0
		public TTable? TypeParams<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603579A RID: 219034 RVA: 0x00749028 File Offset: 0x00747228
		public ITalkOptionPhoneMessageEmoji TypeParamsAsITalkOptionPhoneMessageEmoji()
		{
			return this.TypeParams<ITalkOptionPhoneMessageEmoji>().Value;
		}

		// Token: 0x0603579B RID: 219035 RVA: 0x00749044 File Offset: 0x00747244
		public ITalkOptionQteFailed TypeParamsAsITalkOptionQteFailed()
		{
			return this.TypeParams<ITalkOptionQteFailed>().Value;
		}

		// Token: 0x0603579C RID: 219036 RVA: 0x00749060 File Offset: 0x00747260
		public ITalkOptionQteFailedDelayExec TypeParamsAsITalkOptionQteFailedDelayExec()
		{
			return this.TypeParams<ITalkOptionQteFailedDelayExec>().Value;
		}

		// Token: 0x0603579D RID: 219037 RVA: 0x0074907C File Offset: 0x0074727C
		public ITalkOptionQteSucceed TypeParamsAsITalkOptionQteSucceed()
		{
			return this.TypeParams<ITalkOptionQteSucceed>().Value;
		}

		// Token: 0x0603579E RID: 219038 RVA: 0x00749098 File Offset: 0x00747298
		public ITalkOptionQteSucceedDelayExec TypeParamsAsITalkOptionQteSucceedDelayExec()
		{
			return this.TypeParams<ITalkOptionQteSucceedDelayExec>().Value;
		}

		// Token: 0x0603579F RID: 219039 RVA: 0x007490B4 File Offset: 0x007472B4
		public ITalkOptionRogueRandomEvent TypeParamsAsITalkOptionRogueRandomEvent()
		{
			return this.TypeParams<ITalkOptionRogueRandomEvent>().Value;
		}

		// Token: 0x060357A0 RID: 219040 RVA: 0x007490D0 File Offset: 0x007472D0
		public ITalkOptionVisualNovel TypeParamsAsITalkOptionVisualNovel()
		{
			return this.TypeParams<ITalkOptionVisualNovel>().Value;
		}

		// Token: 0x1700DFDA RID: 57306
		// (get) Token: 0x060357A1 RID: 219041 RVA: 0x007490EC File Offset: 0x007472EC
		public bool HiddenOption
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DFDB RID: 57307
		// (get) Token: 0x060357A2 RID: 219042 RVA: 0x0074912C File Offset: 0x0074732C
		public ushort NullMask
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetUshort(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060357A3 RID: 219043 RVA: 0x0074916C File Offset: 0x0074736C
		public static Offset<ITalkOption> CreateITalkOption(FlatBufferBuilder builder, StringOffset TidTalkOptionOffset = default(StringOffset), int TextId = 0, int PlotLineId = 0, StringOffset PlotLineKeyOffset = default(StringOffset), int Icon = 0, Offset<IChangeIcon> ChangeIconOffset = default(Offset<IChangeIcon>), bool ReadMarkEnabled = false, VectorOffset ActionsOffset = default(VectorOffset), ETalkOptionStyle OptionStyle = ETalkOptionStyle.Default, TTalkOptionPreCondition PreCondition_type = TTalkOptionPreCondition.NONE, int PreConditionOffset = 0, bool _folded = false, EEditFlag _editFlag = EEditFlag.Add, Offset<IOptionLockTip> OptionLockTipOffset = default(Offset<IOptionLockTip>), TTalkOptionParam TypeParams_type = TTalkOptionParam.NONE, int TypeParamsOffset = 0, bool HiddenOption = false, ushort NullMask = 0)
		{
			builder.StartTable(18);
			ITalkOption.AddTypeParams(builder, TypeParamsOffset);
			ITalkOption.AddOptionLockTip(builder, OptionLockTipOffset);
			ITalkOption.AddPreCondition(builder, PreConditionOffset);
			ITalkOption.AddActions(builder, ActionsOffset);
			ITalkOption.AddChangeIcon(builder, ChangeIconOffset);
			ITalkOption.AddIcon(builder, Icon);
			ITalkOption.AddPlotLineKey(builder, PlotLineKeyOffset);
			ITalkOption.AddPlotLineId(builder, PlotLineId);
			ITalkOption.AddTextId(builder, TextId);
			ITalkOption.AddTidTalkOption(builder, TidTalkOptionOffset);
			ITalkOption.AddNullMask(builder, NullMask);
			ITalkOption.AddHiddenOption(builder, HiddenOption);
			ITalkOption.AddTypeParamsType(builder, TypeParams_type);
			ITalkOption.Add_EditFlag(builder, _editFlag);
			ITalkOption.Add_Folded(builder, _folded);
			ITalkOption.AddPreConditionType(builder, PreCondition_type);
			ITalkOption.AddOptionStyle(builder, OptionStyle);
			ITalkOption.AddReadMarkEnabled(builder, ReadMarkEnabled);
			return ITalkOption.EndITalkOption(builder);
		}

		// Token: 0x060357A4 RID: 219044 RVA: 0x00749214 File Offset: 0x00747414
		public static void StartITalkOption(FlatBufferBuilder builder)
		{
			builder.StartTable(18);
		}

		// Token: 0x060357A5 RID: 219045 RVA: 0x0074921E File Offset: 0x0074741E
		public static void AddTidTalkOption(FlatBufferBuilder builder, StringOffset tidTalkOptionOffset)
		{
			builder.AddOffset(0, tidTalkOptionOffset.Value, 0);
		}

		// Token: 0x060357A6 RID: 219046 RVA: 0x0074922E File Offset: 0x0074742E
		public static void AddTextId(FlatBufferBuilder builder, int textId)
		{
			builder.AddInt(1, textId, 0);
		}

		// Token: 0x060357A7 RID: 219047 RVA: 0x00749239 File Offset: 0x00747439
		public static void AddPlotLineId(FlatBufferBuilder builder, int plotLineId)
		{
			builder.AddInt(2, plotLineId, 0);
		}

		// Token: 0x060357A8 RID: 219048 RVA: 0x00749244 File Offset: 0x00747444
		public static void AddPlotLineKey(FlatBufferBuilder builder, StringOffset plotLineKeyOffset)
		{
			builder.AddOffset(3, plotLineKeyOffset.Value, 0);
		}

		// Token: 0x060357A9 RID: 219049 RVA: 0x00749254 File Offset: 0x00747454
		public static void AddIcon(FlatBufferBuilder builder, int icon)
		{
			builder.AddInt(4, icon, 0);
		}

		// Token: 0x060357AA RID: 219050 RVA: 0x0074925F File Offset: 0x0074745F
		public static void AddChangeIcon(FlatBufferBuilder builder, Offset<IChangeIcon> changeIconOffset)
		{
			builder.AddOffset(5, changeIconOffset.Value, 0);
		}

		// Token: 0x060357AB RID: 219051 RVA: 0x0074926F File Offset: 0x0074746F
		public static void AddReadMarkEnabled(FlatBufferBuilder builder, bool readMarkEnabled)
		{
			builder.AddBool(6, readMarkEnabled, false);
		}

		// Token: 0x060357AC RID: 219052 RVA: 0x0074927A File Offset: 0x0074747A
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(7, actionsOffset.Value, 0);
		}

		// Token: 0x060357AD RID: 219053 RVA: 0x0074928C File Offset: 0x0074748C
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060357AE RID: 219054 RVA: 0x007492CC File Offset: 0x007474CC
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060357AF RID: 219055 RVA: 0x007492E6 File Offset: 0x007474E6
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060357B0 RID: 219056 RVA: 0x00749304 File Offset: 0x00747504
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060357B1 RID: 219057 RVA: 0x0074931D File Offset: 0x0074751D
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060357B2 RID: 219058 RVA: 0x00749328 File Offset: 0x00747528
		public static void AddOptionStyle(FlatBufferBuilder builder, ETalkOptionStyle optionStyle)
		{
			builder.AddByte(8, (byte)optionStyle, 0);
		}

		// Token: 0x060357B3 RID: 219059 RVA: 0x00749333 File Offset: 0x00747533
		public static void AddPreConditionType(FlatBufferBuilder builder, TTalkOptionPreCondition preConditionType)
		{
			builder.AddByte(9, (byte)preConditionType, 0);
		}

		// Token: 0x060357B4 RID: 219060 RVA: 0x0074933F File Offset: 0x0074753F
		public static void AddPreCondition(FlatBufferBuilder builder, int preConditionOffset)
		{
			builder.AddOffset(10, preConditionOffset, 0);
		}

		// Token: 0x060357B5 RID: 219061 RVA: 0x0074934B File Offset: 0x0074754B
		public static void Add_Folded(FlatBufferBuilder builder, bool _Folded)
		{
			builder.AddBool(11, _Folded, false);
		}

		// Token: 0x060357B6 RID: 219062 RVA: 0x00749357 File Offset: 0x00747557
		public static void Add_EditFlag(FlatBufferBuilder builder, EEditFlag _EditFlag)
		{
			builder.AddByte(12, (byte)_EditFlag, 0);
		}

		// Token: 0x060357B7 RID: 219063 RVA: 0x00749363 File Offset: 0x00747563
		public static void AddOptionLockTip(FlatBufferBuilder builder, Offset<IOptionLockTip> optionLockTipOffset)
		{
			builder.AddOffset(13, optionLockTipOffset.Value, 0);
		}

		// Token: 0x060357B8 RID: 219064 RVA: 0x00749374 File Offset: 0x00747574
		public static void AddTypeParamsType(FlatBufferBuilder builder, TTalkOptionParam typeParamsType)
		{
			builder.AddByte(14, (byte)typeParamsType, 0);
		}

		// Token: 0x060357B9 RID: 219065 RVA: 0x00749380 File Offset: 0x00747580
		public static void AddTypeParams(FlatBufferBuilder builder, int typeParamsOffset)
		{
			builder.AddOffset(15, typeParamsOffset, 0);
		}

		// Token: 0x060357BA RID: 219066 RVA: 0x0074938C File Offset: 0x0074758C
		public static void AddHiddenOption(FlatBufferBuilder builder, bool hiddenOption)
		{
			builder.AddBool(16, hiddenOption, false);
		}

		// Token: 0x060357BB RID: 219067 RVA: 0x00749398 File Offset: 0x00747598
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(17, nullMask, 0);
		}

		// Token: 0x060357BC RID: 219068 RVA: 0x007493A4 File Offset: 0x007475A4
		public static Offset<ITalkOption> EndITalkOption(FlatBufferBuilder builder)
		{
			return new Offset<ITalkOption>(builder.EndTable());
		}

		// Token: 0x060357BD RID: 219069 RVA: 0x007493B4 File Offset: 0x007475B4
		public ITalkOptionT UnPack()
		{
			ITalkOptionT talkOptionT = new ITalkOptionT();
			this.UnPackTo(talkOptionT);
			return talkOptionT;
		}

		// Token: 0x060357BE RID: 219070 RVA: 0x007493D0 File Offset: 0x007475D0
		public void UnPackTo(ITalkOptionT _o)
		{
			_o.TidTalkOption = this.TidTalkOption;
			_o.TextId = this.TextId;
			_o.PlotLineId = this.PlotLineId;
			_o.PlotLineKey = this.PlotLineKey;
			_o.Icon = this.Icon;
			_o.ChangeIcon = ((this.ChangeIcon != null) ? this.ChangeIcon.Value.UnPack() : null);
			_o.ReadMarkEnabled = this.ReadMarkEnabled;
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
			_o.OptionStyle = this.OptionStyle;
			_o.PreCondition = new TTalkOptionPreConditionUnion();
			_o.PreCondition.Type = this.PreConditionType;
			switch (this.PreConditionType)
			{
			case TTalkOptionPreCondition.ITalkOptionCondition:
				_o.PreCondition.Value = ((this.PreCondition<ITalkOptionCondition>() != null) ? this.PreCondition<ITalkOptionCondition>().Value.UnPack() : null);
				break;
			case TTalkOptionPreCondition.ITalkOptionFirstSelect:
				_o.PreCondition.Value = ((this.PreCondition<ITalkOptionFirstSelect>() != null) ? this.PreCondition<ITalkOptionFirstSelect>().Value.UnPack() : null);
				break;
			case TTalkOptionPreCondition.ITalkOptionPreOption:
				_o.PreCondition.Value = ((this.PreCondition<ITalkOptionPreOption>() != null) ? this.PreCondition<ITalkOptionPreOption>().Value.UnPack() : null);
				break;
			case TTalkOptionPreCondition.ITalkOptionSystemCondition:
				_o.PreCondition.Value = ((this.PreCondition<ITalkOptionSystemCondition>() != null) ? this.PreCondition<ITalkOptionSystemCondition>().Value.UnPack() : null);
				break;
			}
			_o._Folded = this._Folded;
			_o._EditFlag = this._EditFlag;
			_o.OptionLockTip = ((this.OptionLockTip != null) ? this.OptionLockTip.Value.UnPack() : null);
			_o.TypeParams = new TTalkOptionParamUnion();
			_o.TypeParams.Type = this.TypeParamsType;
			switch (this.TypeParamsType)
			{
			case TTalkOptionParam.ITalkOptionPhoneMessageEmoji:
				_o.TypeParams.Value = ((this.TypeParams<ITalkOptionPhoneMessageEmoji>() != null) ? this.TypeParams<ITalkOptionPhoneMessageEmoji>().Value.UnPack() : null);
				break;
			case TTalkOptionParam.ITalkOptionQteFailed:
				_o.TypeParams.Value = ((this.TypeParams<ITalkOptionQteFailed>() != null) ? this.TypeParams<ITalkOptionQteFailed>().Value.UnPack() : null);
				break;
			case TTalkOptionParam.ITalkOptionQteFailedDelayExec:
				_o.TypeParams.Value = ((this.TypeParams<ITalkOptionQteFailedDelayExec>() != null) ? this.TypeParams<ITalkOptionQteFailedDelayExec>().Value.UnPack() : null);
				break;
			case TTalkOptionParam.ITalkOptionQteSucceed:
				_o.TypeParams.Value = ((this.TypeParams<ITalkOptionQteSucceed>() != null) ? this.TypeParams<ITalkOptionQteSucceed>().Value.UnPack() : null);
				break;
			case TTalkOptionParam.ITalkOptionQteSucceedDelayExec:
				_o.TypeParams.Value = ((this.TypeParams<ITalkOptionQteSucceedDelayExec>() != null) ? this.TypeParams<ITalkOptionQteSucceedDelayExec>().Value.UnPack() : null);
				break;
			case TTalkOptionParam.ITalkOptionRogueRandomEvent:
				_o.TypeParams.Value = ((this.TypeParams<ITalkOptionRogueRandomEvent>() != null) ? this.TypeParams<ITalkOptionRogueRandomEvent>().Value.UnPack() : null);
				break;
			case TTalkOptionParam.ITalkOptionVisualNovel:
				_o.TypeParams.Value = ((this.TypeParams<ITalkOptionVisualNovel>() != null) ? this.TypeParams<ITalkOptionVisualNovel>().Value.UnPack() : null);
				break;
			}
			_o.HiddenOption = this.HiddenOption;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060357BF RID: 219071 RVA: 0x00749824 File Offset: 0x00747A24
		public static Offset<ITalkOption> Pack(FlatBufferBuilder builder, ITalkOptionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkOption>);
			}
			StringOffset tidTalkOptionOffset = (_o.TidTalkOption == null) ? default(StringOffset) : builder.CreateString(_o.TidTalkOption);
			StringOffset plotLineKeyOffset = (_o.PlotLineKey == null) ? default(StringOffset) : builder.CreateString(_o.PlotLineKey);
			Offset<IChangeIcon> changeIconOffset = (_o.ChangeIcon == null) ? default(Offset<IChangeIcon>) : IChangeIcon.Pack(builder, _o.ChangeIcon);
			VectorOffset actionsOffset = default(VectorOffset);
			if (_o.Actions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.Actions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.Actions[i]);
				}
				actionsOffset = ITalkOption.CreateActionsVector(builder, array);
			}
			TTalkOptionPreCondition preCondition_type = (_o.PreCondition == null) ? TTalkOptionPreCondition.NONE : _o.PreCondition.Type;
			int preConditionOffset = (_o.PreCondition == null) ? 0 : TTalkOptionPreConditionUnion.Pack(builder, _o.PreCondition);
			Offset<IOptionLockTip> optionLockTipOffset = (_o.OptionLockTip == null) ? default(Offset<IOptionLockTip>) : IOptionLockTip.Pack(builder, _o.OptionLockTip);
			TTalkOptionParam typeParams_type = (_o.TypeParams == null) ? TTalkOptionParam.NONE : _o.TypeParams.Type;
			int typeParamsOffset = (_o.TypeParams == null) ? 0 : TTalkOptionParamUnion.Pack(builder, _o.TypeParams);
			return ITalkOption.CreateITalkOption(builder, tidTalkOptionOffset, _o.TextId, _o.PlotLineId, plotLineKeyOffset, _o.Icon, changeIconOffset, _o.ReadMarkEnabled, actionsOffset, _o.OptionStyle, preCondition_type, preConditionOffset, _o._Folded, _o._EditFlag, optionLockTipOffset, typeParams_type, typeParamsOffset, _o.HiddenOption, _o.NullMask);
		}

		// Token: 0x040120FD RID: 73981
		private Table __p;
	}
}
