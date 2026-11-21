using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AF7 RID: 31479
	public struct ITalkOption : IFlatbufferObject
	{
		// Token: 0x1700EBC7 RID: 60359
		// (get) Token: 0x06038AAE RID: 232110 RVA: 0x007AA60D File Offset: 0x007A880D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038AAF RID: 232111 RVA: 0x007AA61A File Offset: 0x007A881A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038AB0 RID: 232112 RVA: 0x007AA624 File Offset: 0x007A8824
		public static ITalkOption GetRootAsITalkOption(ByteBuffer _bb)
		{
			return ITalkOption.GetRootAsITalkOption(_bb, default(ITalkOption));
		}

		// Token: 0x06038AB1 RID: 232113 RVA: 0x007AA640 File Offset: 0x007A8840
		public static ITalkOption GetRootAsITalkOption(ByteBuffer _bb, ITalkOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038AB2 RID: 232114 RVA: 0x007AA65D File Offset: 0x007A885D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038AB3 RID: 232115 RVA: 0x007AA66C File Offset: 0x007A886C
		public ITalkOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EBC8 RID: 60360
		// (get) Token: 0x06038AB4 RID: 232116 RVA: 0x007AA67C File Offset: 0x007A887C
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

		// Token: 0x06038AB5 RID: 232117 RVA: 0x007AA6B3 File Offset: 0x007A88B3
		public Span<byte> GetTidTalkOptionBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06038AB6 RID: 232118 RVA: 0x007AA6C2 File Offset: 0x007A88C2
		public byte[] GetTidTalkOptionArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700EBC9 RID: 60361
		// (get) Token: 0x06038AB7 RID: 232119 RVA: 0x007AA6D0 File Offset: 0x007A88D0
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

		// Token: 0x1700EBCA RID: 60362
		// (get) Token: 0x06038AB8 RID: 232120 RVA: 0x007AA70C File Offset: 0x007A890C
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

		// Token: 0x1700EBCB RID: 60363
		// (get) Token: 0x06038AB9 RID: 232121 RVA: 0x007AA748 File Offset: 0x007A8948
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

		// Token: 0x06038ABA RID: 232122 RVA: 0x007AA780 File Offset: 0x007A8980
		public Span<byte> GetPlotLineKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06038ABB RID: 232123 RVA: 0x007AA790 File Offset: 0x007A8990
		public byte[] GetPlotLineKeyArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700EBCC RID: 60364
		// (get) Token: 0x06038ABC RID: 232124 RVA: 0x007AA7A0 File Offset: 0x007A89A0
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

		// Token: 0x1700EBCD RID: 60365
		// (get) Token: 0x06038ABD RID: 232125 RVA: 0x007AA7E0 File Offset: 0x007A89E0
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

		// Token: 0x1700EBCE RID: 60366
		// (get) Token: 0x06038ABE RID: 232126 RVA: 0x007AA840 File Offset: 0x007A8A40
		public bool ReadMarkEnabled
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06038ABF RID: 232127 RVA: 0x007AA880 File Offset: 0x007A8A80
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700EBCF RID: 60367
		// (get) Token: 0x06038AC0 RID: 232128 RVA: 0x007AA8E4 File Offset: 0x007A8AE4
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

		// Token: 0x1700EBD0 RID: 60368
		// (get) Token: 0x06038AC1 RID: 232129 RVA: 0x007AA910 File Offset: 0x007A8B10
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

		// Token: 0x1700EBD1 RID: 60369
		// (get) Token: 0x06038AC2 RID: 232130 RVA: 0x007AA950 File Offset: 0x007A8B50
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

		// Token: 0x06038AC3 RID: 232131 RVA: 0x007AA990 File Offset: 0x007A8B90
		public TTable? PreCondition<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06038AC4 RID: 232132 RVA: 0x007AA9D8 File Offset: 0x007A8BD8
		public ITalkOptionCondition PreConditionAsITalkOptionCondition()
		{
			return this.PreCondition<ITalkOptionCondition>().Value;
		}

		// Token: 0x06038AC5 RID: 232133 RVA: 0x007AA9F4 File Offset: 0x007A8BF4
		public ITalkOptionFirstSelect PreConditionAsITalkOptionFirstSelect()
		{
			return this.PreCondition<ITalkOptionFirstSelect>().Value;
		}

		// Token: 0x06038AC6 RID: 232134 RVA: 0x007AAA10 File Offset: 0x007A8C10
		public ITalkOptionPreOption PreConditionAsITalkOptionPreOption()
		{
			return this.PreCondition<ITalkOptionPreOption>().Value;
		}

		// Token: 0x06038AC7 RID: 232135 RVA: 0x007AAA2C File Offset: 0x007A8C2C
		public ITalkOptionSystemCondition PreConditionAsITalkOptionSystemCondition()
		{
			return this.PreCondition<ITalkOptionSystemCondition>().Value;
		}

		// Token: 0x1700EBD2 RID: 60370
		// (get) Token: 0x06038AC8 RID: 232136 RVA: 0x007AAA48 File Offset: 0x007A8C48
		public bool _Folded
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700EBD3 RID: 60371
		// (get) Token: 0x06038AC9 RID: 232137 RVA: 0x007AAA88 File Offset: 0x007A8C88
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

		// Token: 0x1700EBD4 RID: 60372
		// (get) Token: 0x06038ACA RID: 232138 RVA: 0x007AAAC8 File Offset: 0x007A8CC8
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

		// Token: 0x1700EBD5 RID: 60373
		// (get) Token: 0x06038ACB RID: 232139 RVA: 0x007AAB28 File Offset: 0x007A8D28
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

		// Token: 0x06038ACC RID: 232140 RVA: 0x007AAB68 File Offset: 0x007A8D68
		public TTable? TypeParams<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06038ACD RID: 232141 RVA: 0x007AABB0 File Offset: 0x007A8DB0
		public ITalkOptionPhoneMessageEmoji TypeParamsAsITalkOptionPhoneMessageEmoji()
		{
			return this.TypeParams<ITalkOptionPhoneMessageEmoji>().Value;
		}

		// Token: 0x06038ACE RID: 232142 RVA: 0x007AABCC File Offset: 0x007A8DCC
		public ITalkOptionQteFailed TypeParamsAsITalkOptionQteFailed()
		{
			return this.TypeParams<ITalkOptionQteFailed>().Value;
		}

		// Token: 0x06038ACF RID: 232143 RVA: 0x007AABE8 File Offset: 0x007A8DE8
		public ITalkOptionQteFailedDelayExec TypeParamsAsITalkOptionQteFailedDelayExec()
		{
			return this.TypeParams<ITalkOptionQteFailedDelayExec>().Value;
		}

		// Token: 0x06038AD0 RID: 232144 RVA: 0x007AAC04 File Offset: 0x007A8E04
		public ITalkOptionQteSucceed TypeParamsAsITalkOptionQteSucceed()
		{
			return this.TypeParams<ITalkOptionQteSucceed>().Value;
		}

		// Token: 0x06038AD1 RID: 232145 RVA: 0x007AAC20 File Offset: 0x007A8E20
		public ITalkOptionQteSucceedDelayExec TypeParamsAsITalkOptionQteSucceedDelayExec()
		{
			return this.TypeParams<ITalkOptionQteSucceedDelayExec>().Value;
		}

		// Token: 0x06038AD2 RID: 232146 RVA: 0x007AAC3C File Offset: 0x007A8E3C
		public ITalkOptionRogueRandomEvent TypeParamsAsITalkOptionRogueRandomEvent()
		{
			return this.TypeParams<ITalkOptionRogueRandomEvent>().Value;
		}

		// Token: 0x06038AD3 RID: 232147 RVA: 0x007AAC58 File Offset: 0x007A8E58
		public ITalkOptionVisualNovel TypeParamsAsITalkOptionVisualNovel()
		{
			return this.TypeParams<ITalkOptionVisualNovel>().Value;
		}

		// Token: 0x1700EBD6 RID: 60374
		// (get) Token: 0x06038AD4 RID: 232148 RVA: 0x007AAC74 File Offset: 0x007A8E74
		public bool HiddenOption
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700EBD7 RID: 60375
		// (get) Token: 0x06038AD5 RID: 232149 RVA: 0x007AACB4 File Offset: 0x007A8EB4
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

		// Token: 0x06038AD6 RID: 232150 RVA: 0x007AACF4 File Offset: 0x007A8EF4
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

		// Token: 0x06038AD7 RID: 232151 RVA: 0x007AAD9C File Offset: 0x007A8F9C
		public static void StartITalkOption(FlatBufferBuilder builder)
		{
			builder.StartTable(18);
		}

		// Token: 0x06038AD8 RID: 232152 RVA: 0x007AADA6 File Offset: 0x007A8FA6
		public static void AddTidTalkOption(FlatBufferBuilder builder, StringOffset tidTalkOptionOffset)
		{
			builder.AddOffset(0, tidTalkOptionOffset.Value, 0);
		}

		// Token: 0x06038AD9 RID: 232153 RVA: 0x007AADB6 File Offset: 0x007A8FB6
		public static void AddTextId(FlatBufferBuilder builder, int textId)
		{
			builder.AddInt(1, textId, 0);
		}

		// Token: 0x06038ADA RID: 232154 RVA: 0x007AADC1 File Offset: 0x007A8FC1
		public static void AddPlotLineId(FlatBufferBuilder builder, int plotLineId)
		{
			builder.AddInt(2, plotLineId, 0);
		}

		// Token: 0x06038ADB RID: 232155 RVA: 0x007AADCC File Offset: 0x007A8FCC
		public static void AddPlotLineKey(FlatBufferBuilder builder, StringOffset plotLineKeyOffset)
		{
			builder.AddOffset(3, plotLineKeyOffset.Value, 0);
		}

		// Token: 0x06038ADC RID: 232156 RVA: 0x007AADDC File Offset: 0x007A8FDC
		public static void AddIcon(FlatBufferBuilder builder, int icon)
		{
			builder.AddInt(4, icon, 0);
		}

		// Token: 0x06038ADD RID: 232157 RVA: 0x007AADE7 File Offset: 0x007A8FE7
		public static void AddChangeIcon(FlatBufferBuilder builder, Offset<IChangeIcon> changeIconOffset)
		{
			builder.AddOffset(5, changeIconOffset.Value, 0);
		}

		// Token: 0x06038ADE RID: 232158 RVA: 0x007AADF7 File Offset: 0x007A8FF7
		public static void AddReadMarkEnabled(FlatBufferBuilder builder, bool readMarkEnabled)
		{
			builder.AddBool(6, readMarkEnabled, false);
		}

		// Token: 0x06038ADF RID: 232159 RVA: 0x007AAE02 File Offset: 0x007A9002
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(7, actionsOffset.Value, 0);
		}

		// Token: 0x06038AE0 RID: 232160 RVA: 0x007AAE14 File Offset: 0x007A9014
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06038AE1 RID: 232161 RVA: 0x007AAE54 File Offset: 0x007A9054
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06038AE2 RID: 232162 RVA: 0x007AAE6E File Offset: 0x007A906E
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06038AE3 RID: 232163 RVA: 0x007AAE8C File Offset: 0x007A908C
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06038AE4 RID: 232164 RVA: 0x007AAEA5 File Offset: 0x007A90A5
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06038AE5 RID: 232165 RVA: 0x007AAEB0 File Offset: 0x007A90B0
		public static void AddOptionStyle(FlatBufferBuilder builder, ETalkOptionStyle optionStyle)
		{
			builder.AddByte(8, (byte)optionStyle, 0);
		}

		// Token: 0x06038AE6 RID: 232166 RVA: 0x007AAEBB File Offset: 0x007A90BB
		public static void AddPreConditionType(FlatBufferBuilder builder, TTalkOptionPreCondition preConditionType)
		{
			builder.AddByte(9, (byte)preConditionType, 0);
		}

		// Token: 0x06038AE7 RID: 232167 RVA: 0x007AAEC7 File Offset: 0x007A90C7
		public static void AddPreCondition(FlatBufferBuilder builder, int preConditionOffset)
		{
			builder.AddOffset(10, preConditionOffset, 0);
		}

		// Token: 0x06038AE8 RID: 232168 RVA: 0x007AAED3 File Offset: 0x007A90D3
		public static void Add_Folded(FlatBufferBuilder builder, bool _Folded)
		{
			builder.AddBool(11, _Folded, false);
		}

		// Token: 0x06038AE9 RID: 232169 RVA: 0x007AAEDF File Offset: 0x007A90DF
		public static void Add_EditFlag(FlatBufferBuilder builder, EEditFlag _EditFlag)
		{
			builder.AddByte(12, (byte)_EditFlag, 0);
		}

		// Token: 0x06038AEA RID: 232170 RVA: 0x007AAEEB File Offset: 0x007A90EB
		public static void AddOptionLockTip(FlatBufferBuilder builder, Offset<IOptionLockTip> optionLockTipOffset)
		{
			builder.AddOffset(13, optionLockTipOffset.Value, 0);
		}

		// Token: 0x06038AEB RID: 232171 RVA: 0x007AAEFC File Offset: 0x007A90FC
		public static void AddTypeParamsType(FlatBufferBuilder builder, TTalkOptionParam typeParamsType)
		{
			builder.AddByte(14, (byte)typeParamsType, 0);
		}

		// Token: 0x06038AEC RID: 232172 RVA: 0x007AAF08 File Offset: 0x007A9108
		public static void AddTypeParams(FlatBufferBuilder builder, int typeParamsOffset)
		{
			builder.AddOffset(15, typeParamsOffset, 0);
		}

		// Token: 0x06038AED RID: 232173 RVA: 0x007AAF14 File Offset: 0x007A9114
		public static void AddHiddenOption(FlatBufferBuilder builder, bool hiddenOption)
		{
			builder.AddBool(16, hiddenOption, false);
		}

		// Token: 0x06038AEE RID: 232174 RVA: 0x007AAF20 File Offset: 0x007A9120
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(17, nullMask, 0);
		}

		// Token: 0x06038AEF RID: 232175 RVA: 0x007AAF2C File Offset: 0x007A912C
		public static Offset<ITalkOption> EndITalkOption(FlatBufferBuilder builder)
		{
			return new Offset<ITalkOption>(builder.EndTable());
		}

		// Token: 0x06038AF0 RID: 232176 RVA: 0x007AAF3C File Offset: 0x007A913C
		public ITalkOptionT UnPack()
		{
			ITalkOptionT talkOptionT = new ITalkOptionT();
			this.UnPackTo(talkOptionT);
			return talkOptionT;
		}

		// Token: 0x06038AF1 RID: 232177 RVA: 0x007AAF58 File Offset: 0x007A9158
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

		// Token: 0x06038AF2 RID: 232178 RVA: 0x007AB3AC File Offset: 0x007A95AC
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

		// Token: 0x04013103 RID: 78083
		private Table __p;
	}
}
