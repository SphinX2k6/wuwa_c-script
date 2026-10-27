using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007352 RID: 29522
	public struct ITalkOptionSystemCondition : IFlatbufferObject
	{
		// Token: 0x1700E027 RID: 57383
		// (get) Token: 0x06035926 RID: 219430 RVA: 0x0074BB24 File Offset: 0x00749D24
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035927 RID: 219431 RVA: 0x0074BB31 File Offset: 0x00749D31
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035928 RID: 219432 RVA: 0x0074BB38 File Offset: 0x00749D38
		public static ITalkOptionSystemCondition GetRootAsITalkOptionSystemCondition(ByteBuffer _bb)
		{
			return ITalkOptionSystemCondition.GetRootAsITalkOptionSystemCondition(_bb, default(ITalkOptionSystemCondition));
		}

		// Token: 0x06035929 RID: 219433 RVA: 0x0074BB54 File Offset: 0x00749D54
		public static ITalkOptionSystemCondition GetRootAsITalkOptionSystemCondition(ByteBuffer _bb, ITalkOptionSystemCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603592A RID: 219434 RVA: 0x0074BB71 File Offset: 0x00749D71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603592B RID: 219435 RVA: 0x0074BB80 File Offset: 0x00749D80
		public ITalkOptionSystemCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E028 RID: 57384
		// (get) Token: 0x0603592C RID: 219436 RVA: 0x0074BB90 File Offset: 0x00749D90
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

		// Token: 0x1700E029 RID: 57385
		// (get) Token: 0x0603592D RID: 219437 RVA: 0x0074BBCC File Offset: 0x00749DCC
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

		// Token: 0x1700E02A RID: 57386
		// (get) Token: 0x0603592E RID: 219438 RVA: 0x0074BC2C File Offset: 0x00749E2C
		public bool HideWhenUnmet
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E02B RID: 57387
		// (get) Token: 0x0603592F RID: 219439 RVA: 0x0074BC6C File Offset: 0x00749E6C
		public bool HideConditionTextWhenUnmet
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E02C RID: 57388
		// (get) Token: 0x06035930 RID: 219440 RVA: 0x0074BCAC File Offset: 0x00749EAC
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

		// Token: 0x06035931 RID: 219441 RVA: 0x0074BCE4 File Offset: 0x00749EE4
		public Span<byte> GetTidReplaceTextWhenUnmetBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06035932 RID: 219442 RVA: 0x0074BCF4 File Offset: 0x00749EF4
		public byte[] GetTidReplaceTextWhenUnmetArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700E02D RID: 57389
		// (get) Token: 0x06035933 RID: 219443 RVA: 0x0074BD04 File Offset: 0x00749F04
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

		// Token: 0x06035934 RID: 219444 RVA: 0x0074BD41 File Offset: 0x00749F41
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

		// Token: 0x06035935 RID: 219445 RVA: 0x0074BD7D File Offset: 0x00749F7D
		public static void StartITalkOptionSystemCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06035936 RID: 219446 RVA: 0x0074BD86 File Offset: 0x00749F86
		public static void AddType(FlatBufferBuilder builder, ETalkOptionPreConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035937 RID: 219447 RVA: 0x0074BD91 File Offset: 0x00749F91
		public static void AddSystem(FlatBufferBuilder builder, Offset<ITalkOptionConditionSolarSchool> systemOffset)
		{
			builder.AddOffset(1, systemOffset.Value, 0);
		}

		// Token: 0x06035938 RID: 219448 RVA: 0x0074BDA1 File Offset: 0x00749FA1
		public static void AddHideWhenUnmet(FlatBufferBuilder builder, bool hideWhenUnmet)
		{
			builder.AddBool(2, hideWhenUnmet, false);
		}

		// Token: 0x06035939 RID: 219449 RVA: 0x0074BDAC File Offset: 0x00749FAC
		public static void AddHideConditionTextWhenUnmet(FlatBufferBuilder builder, bool hideConditionTextWhenUnmet)
		{
			builder.AddBool(3, hideConditionTextWhenUnmet, false);
		}

		// Token: 0x0603593A RID: 219450 RVA: 0x0074BDB7 File Offset: 0x00749FB7
		public static void AddTidReplaceTextWhenUnmet(FlatBufferBuilder builder, StringOffset tidReplaceTextWhenUnmetOffset)
		{
			builder.AddOffset(4, tidReplaceTextWhenUnmetOffset.Value, 0);
		}

		// Token: 0x0603593B RID: 219451 RVA: 0x0074BDC7 File Offset: 0x00749FC7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0603593C RID: 219452 RVA: 0x0074BDD2 File Offset: 0x00749FD2
		public static Offset<ITalkOptionSystemCondition> EndITalkOptionSystemCondition(FlatBufferBuilder builder)
		{
			return new Offset<ITalkOptionSystemCondition>(builder.EndTable());
		}

		// Token: 0x0603593D RID: 219453 RVA: 0x0074BDE0 File Offset: 0x00749FE0
		public ITalkOptionSystemConditionT UnPack()
		{
			ITalkOptionSystemConditionT talkOptionSystemConditionT = new ITalkOptionSystemConditionT();
			this.UnPackTo(talkOptionSystemConditionT);
			return talkOptionSystemConditionT;
		}

		// Token: 0x0603593E RID: 219454 RVA: 0x0074BDFC File Offset: 0x00749FFC
		public void UnPackTo(ITalkOptionSystemConditionT _o)
		{
			_o.Type = this.Type;
			_o.System = ((this.System != null) ? this.System.Value.UnPack() : null);
			_o.HideWhenUnmet = this.HideWhenUnmet;
			_o.HideConditionTextWhenUnmet = this.HideConditionTextWhenUnmet;
			_o.TidReplaceTextWhenUnmet = this.TidReplaceTextWhenUnmet;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603593F RID: 219455 RVA: 0x0074BE74 File Offset: 0x0074A074
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

		// Token: 0x0401214A RID: 74058
		private Table __p;
	}
}
