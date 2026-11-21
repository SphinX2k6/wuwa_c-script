using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B2A RID: 31530
	public struct ITalkOptionSystemCondition : IFlatbufferObject
	{
		// Token: 0x1700EC23 RID: 60451
		// (get) Token: 0x06038C59 RID: 232537 RVA: 0x007AD6AC File Offset: 0x007AB8AC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038C5A RID: 232538 RVA: 0x007AD6B9 File Offset: 0x007AB8B9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038C5B RID: 232539 RVA: 0x007AD6C0 File Offset: 0x007AB8C0
		public static ITalkOptionSystemCondition GetRootAsITalkOptionSystemCondition(ByteBuffer _bb)
		{
			return ITalkOptionSystemCondition.GetRootAsITalkOptionSystemCondition(_bb, default(ITalkOptionSystemCondition));
		}

		// Token: 0x06038C5C RID: 232540 RVA: 0x007AD6DC File Offset: 0x007AB8DC
		public static ITalkOptionSystemCondition GetRootAsITalkOptionSystemCondition(ByteBuffer _bb, ITalkOptionSystemCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038C5D RID: 232541 RVA: 0x007AD6F9 File Offset: 0x007AB8F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038C5E RID: 232542 RVA: 0x007AD708 File Offset: 0x007AB908
		public ITalkOptionSystemCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EC24 RID: 60452
		// (get) Token: 0x06038C5F RID: 232543 RVA: 0x007AD718 File Offset: 0x007AB918
		public ETalkOptionPreConditionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETalkOptionPreConditionType.PreOption;
				}
				return (ETalkOptionPreConditionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700EC25 RID: 60453
		// (get) Token: 0x06038C60 RID: 232544 RVA: 0x007AD754 File Offset: 0x007AB954
		public ITalkOptionConditionSolarSchool? System
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ITalkOptionConditionSolarSchool?(default(ITalkOptionConditionSolarSchool).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700EC26 RID: 60454
		// (get) Token: 0x06038C61 RID: 232545 RVA: 0x007AD7B4 File Offset: 0x007AB9B4
		public bool HideWhenUnmet
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700EC27 RID: 60455
		// (get) Token: 0x06038C62 RID: 232546 RVA: 0x007AD7F4 File Offset: 0x007AB9F4
		public bool HideConditionTextWhenUnmet
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700EC28 RID: 60456
		// (get) Token: 0x06038C63 RID: 232547 RVA: 0x007AD834 File Offset: 0x007ABA34
		public string TidReplaceTextWhenUnmet
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06038C64 RID: 232548 RVA: 0x007AD86C File Offset: 0x007ABA6C
		public Span<byte> GetTidReplaceTextWhenUnmetBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06038C65 RID: 232549 RVA: 0x007AD87C File Offset: 0x007ABA7C
		public byte[] GetTidReplaceTextWhenUnmetArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700EC29 RID: 60457
		// (get) Token: 0x06038C66 RID: 232550 RVA: 0x007AD88C File Offset: 0x007ABA8C
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

		// Token: 0x06038C67 RID: 232551 RVA: 0x007AD8C9 File Offset: 0x007ABAC9
		public static Offset<ITalkOptionSystemCondition> CreateITalkOptionSystemCondition(FlatBufferBuilder builder, ETalkOptionPreConditionType Type = ETalkOptionPreConditionType.PreOption, Offset<ITalkOptionConditionSolarSchool> SystemOffset = default(Offset<ITalkOptionConditionSolarSchool>), bool HideWhenUnmet = false, bool HideConditionTextWhenUnmet = false, StringOffset TidReplaceTextWhenUnmetOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			ITalkOptionSystemCondition.AddTidReplaceTextWhenUnmet(builder, TidReplaceTextWhenUnmetOffset);
			ITalkOptionSystemCondition.AddSystem(builder, SystemOffset);
			ITalkOptionSystemCondition.AddNullMask(builder, NullMask);
			ITalkOptionSystemCondition.AddHideConditionTextWhenUnmet(builder, HideConditionTextWhenUnmet);
			ITalkOptionSystemCondition.AddHideWhenUnmet(builder, HideWhenUnmet);
			ITalkOptionSystemCondition.AddType(builder, Type);
			return ITalkOptionSystemCondition.EndITalkOptionSystemCondition(builder);
		}

		// Token: 0x06038C68 RID: 232552 RVA: 0x007AD905 File Offset: 0x007ABB05
		public static void StartITalkOptionSystemCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06038C69 RID: 232553 RVA: 0x007AD90E File Offset: 0x007ABB0E
		public static void AddType(FlatBufferBuilder builder, ETalkOptionPreConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06038C6A RID: 232554 RVA: 0x007AD919 File Offset: 0x007ABB19
		public static void AddSystem(FlatBufferBuilder builder, Offset<ITalkOptionConditionSolarSchool> systemOffset)
		{
			builder.AddOffset(1, systemOffset.Value, 0);
		}

		// Token: 0x06038C6B RID: 232555 RVA: 0x007AD929 File Offset: 0x007ABB29
		public static void AddHideWhenUnmet(FlatBufferBuilder builder, bool hideWhenUnmet)
		{
			builder.AddBool(2, hideWhenUnmet, false);
		}

		// Token: 0x06038C6C RID: 232556 RVA: 0x007AD934 File Offset: 0x007ABB34
		public static void AddHideConditionTextWhenUnmet(FlatBufferBuilder builder, bool hideConditionTextWhenUnmet)
		{
			builder.AddBool(3, hideConditionTextWhenUnmet, false);
		}

		// Token: 0x06038C6D RID: 232557 RVA: 0x007AD93F File Offset: 0x007ABB3F
		public static void AddTidReplaceTextWhenUnmet(FlatBufferBuilder builder, StringOffset tidReplaceTextWhenUnmetOffset)
		{
			builder.AddOffset(4, tidReplaceTextWhenUnmetOffset.Value, 0);
		}

		// Token: 0x06038C6E RID: 232558 RVA: 0x007AD94F File Offset: 0x007ABB4F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06038C6F RID: 232559 RVA: 0x007AD95A File Offset: 0x007ABB5A
		public static Offset<ITalkOptionSystemCondition> EndITalkOptionSystemCondition(FlatBufferBuilder builder)
		{
			return new Offset<ITalkOptionSystemCondition>(builder.EndTable());
		}

		// Token: 0x06038C70 RID: 232560 RVA: 0x007AD968 File Offset: 0x007ABB68
		public ITalkOptionSystemConditionT UnPack()
		{
			ITalkOptionSystemConditionT talkOptionSystemConditionT = new ITalkOptionSystemConditionT();
			this.UnPackTo(talkOptionSystemConditionT);
			return talkOptionSystemConditionT;
		}

		// Token: 0x06038C71 RID: 232561 RVA: 0x007AD984 File Offset: 0x007ABB84
		public void UnPackTo(ITalkOptionSystemConditionT _o)
		{
			_o.Type = this.Type;
			_o.System = ((this.System != null) ? this.System.Value.UnPack() : null);
			_o.HideWhenUnmet = this.HideWhenUnmet;
			_o.HideConditionTextWhenUnmet = this.HideConditionTextWhenUnmet;
			_o.TidReplaceTextWhenUnmet = this.TidReplaceTextWhenUnmet;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06038C72 RID: 232562 RVA: 0x007AD9FC File Offset: 0x007ABBFC
		public static Offset<ITalkOptionSystemCondition> Pack(FlatBufferBuilder builder, ITalkOptionSystemConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkOptionSystemCondition>);
			}
			Offset<ITalkOptionConditionSolarSchool> systemOffset = (_o.System == null) ? default(Offset<ITalkOptionConditionSolarSchool>) : ITalkOptionConditionSolarSchool.Pack(builder, _o.System);
			StringOffset tidReplaceTextWhenUnmetOffset = (_o.TidReplaceTextWhenUnmet == null) ? default(StringOffset) : builder.CreateString(_o.TidReplaceTextWhenUnmet);
			return ITalkOptionSystemCondition.CreateITalkOptionSystemCondition(builder, _o.Type, systemOffset, _o.HideWhenUnmet, _o.HideConditionTextWhenUnmet, tidReplaceTextWhenUnmetOffset, _o.NullMask);
		}

		// Token: 0x04013150 RID: 78160
		private Table __p;
	}
}
