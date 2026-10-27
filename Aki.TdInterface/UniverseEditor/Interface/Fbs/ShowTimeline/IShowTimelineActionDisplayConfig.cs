using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003B9E RID: 15262
	public struct IShowTimelineActionDisplayConfig : IFlatbufferObject
	{
		// Token: 0x1700689F RID: 26783
		// (get) Token: 0x06014E9F RID: 85663 RVA: 0x00308CDA File Offset: 0x00306EDA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014EA0 RID: 85664 RVA: 0x00308CE7 File Offset: 0x00306EE7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014EA1 RID: 85665 RVA: 0x00308CF0 File Offset: 0x00306EF0
		public static IShowTimelineActionDisplayConfig GetRootAsIShowTimelineActionDisplayConfig(ByteBuffer _bb)
		{
			return IShowTimelineActionDisplayConfig.GetRootAsIShowTimelineActionDisplayConfig(_bb, default(IShowTimelineActionDisplayConfig));
		}

		// Token: 0x06014EA2 RID: 85666 RVA: 0x00308D0C File Offset: 0x00306F0C
		public static IShowTimelineActionDisplayConfig GetRootAsIShowTimelineActionDisplayConfig(ByteBuffer _bb, IShowTimelineActionDisplayConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014EA3 RID: 85667 RVA: 0x00308D29 File Offset: 0x00306F29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014EA4 RID: 85668 RVA: 0x00308D38 File Offset: 0x00306F38
		public IShowTimelineActionDisplayConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170068A0 RID: 26784
		// (get) Token: 0x06014EA5 RID: 85669 RVA: 0x00308D48 File Offset: 0x00306F48
		public string ShortName
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

		// Token: 0x06014EA6 RID: 85670 RVA: 0x00308D7F File Offset: 0x00306F7F
		public Span<byte> GetShortNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06014EA7 RID: 85671 RVA: 0x00308D8E File Offset: 0x00306F8E
		public byte[] GetShortNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x170068A1 RID: 26785
		// (get) Token: 0x06014EA8 RID: 85672 RVA: 0x00308D9C File Offset: 0x00306F9C
		public int IconSkillId
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

		// Token: 0x170068A2 RID: 26786
		// (get) Token: 0x06014EA9 RID: 85673 RVA: 0x00308DD8 File Offset: 0x00306FD8
		public string Superscript
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

		// Token: 0x06014EAA RID: 85674 RVA: 0x00308E0F File Offset: 0x0030700F
		public Span<byte> GetSuperscriptBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06014EAB RID: 85675 RVA: 0x00308E1E File Offset: 0x0030701E
		public byte[] GetSuperscriptArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x170068A3 RID: 26787
		// (get) Token: 0x06014EAC RID: 85676 RVA: 0x00308E2C File Offset: 0x0030702C
		public string DebugText
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

		// Token: 0x06014EAD RID: 85677 RVA: 0x00308E64 File Offset: 0x00307064
		public Span<byte> GetDebugTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06014EAE RID: 85678 RVA: 0x00308E74 File Offset: 0x00307074
		public byte[] GetDebugTextArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x170068A4 RID: 26788
		// (get) Token: 0x06014EAF RID: 85679 RVA: 0x00308E84 File Offset: 0x00307084
		public int SkillGroupId
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

		// Token: 0x06014EB0 RID: 85680 RVA: 0x00308EC1 File Offset: 0x003070C1
		public static Offset<IShowTimelineActionDisplayConfig> CreateIShowTimelineActionDisplayConfig(FlatBufferBuilder builder, StringOffset ShortNameOffset = default(StringOffset), int IconSkillId = 0, StringOffset SuperscriptOffset = default(StringOffset), StringOffset DebugTextOffset = default(StringOffset), int SkillGroupId = 0)
		{
			builder.StartTable(5);
			IShowTimelineActionDisplayConfig.AddSkillGroupId(builder, SkillGroupId);
			IShowTimelineActionDisplayConfig.AddDebugText(builder, DebugTextOffset);
			IShowTimelineActionDisplayConfig.AddSuperscript(builder, SuperscriptOffset);
			IShowTimelineActionDisplayConfig.AddIconSkillId(builder, IconSkillId);
			IShowTimelineActionDisplayConfig.AddShortName(builder, ShortNameOffset);
			return IShowTimelineActionDisplayConfig.EndIShowTimelineActionDisplayConfig(builder);
		}

		// Token: 0x06014EB1 RID: 85681 RVA: 0x00308EF5 File Offset: 0x003070F5
		public static void StartIShowTimelineActionDisplayConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06014EB2 RID: 85682 RVA: 0x00308EFE File Offset: 0x003070FE
		public static void AddShortName(FlatBufferBuilder builder, StringOffset shortNameOffset)
		{
			builder.AddOffset(0, shortNameOffset.Value, 0);
		}

		// Token: 0x06014EB3 RID: 85683 RVA: 0x00308F0E File Offset: 0x0030710E
		public static void AddIconSkillId(FlatBufferBuilder builder, int iconSkillId)
		{
			builder.AddInt(1, iconSkillId, 0);
		}

		// Token: 0x06014EB4 RID: 85684 RVA: 0x00308F19 File Offset: 0x00307119
		public static void AddSuperscript(FlatBufferBuilder builder, StringOffset superscriptOffset)
		{
			builder.AddOffset(2, superscriptOffset.Value, 0);
		}

		// Token: 0x06014EB5 RID: 85685 RVA: 0x00308F29 File Offset: 0x00307129
		public static void AddDebugText(FlatBufferBuilder builder, StringOffset debugTextOffset)
		{
			builder.AddOffset(3, debugTextOffset.Value, 0);
		}

		// Token: 0x06014EB6 RID: 85686 RVA: 0x00308F39 File Offset: 0x00307139
		public static void AddSkillGroupId(FlatBufferBuilder builder, int skillGroupId)
		{
			builder.AddInt(4, skillGroupId, 0);
		}

		// Token: 0x06014EB7 RID: 85687 RVA: 0x00308F44 File Offset: 0x00307144
		public static Offset<IShowTimelineActionDisplayConfig> EndIShowTimelineActionDisplayConfig(FlatBufferBuilder builder)
		{
			return new Offset<IShowTimelineActionDisplayConfig>(builder.EndTable());
		}

		// Token: 0x06014EB8 RID: 85688 RVA: 0x00308F54 File Offset: 0x00307154
		public IShowTimelineActionDisplayConfigT UnPack()
		{
			IShowTimelineActionDisplayConfigT showTimelineActionDisplayConfigT = new IShowTimelineActionDisplayConfigT();
			this.UnPackTo(showTimelineActionDisplayConfigT);
			return showTimelineActionDisplayConfigT;
		}

		// Token: 0x06014EB9 RID: 85689 RVA: 0x00308F6F File Offset: 0x0030716F
		public void UnPackTo(IShowTimelineActionDisplayConfigT _o)
		{
			_o.ShortName = this.ShortName;
			_o.IconSkillId = this.IconSkillId;
			_o.Superscript = this.Superscript;
			_o.DebugText = this.DebugText;
			_o.SkillGroupId = this.SkillGroupId;
		}

		// Token: 0x06014EBA RID: 85690 RVA: 0x00308FB0 File Offset: 0x003071B0
		public static Offset<IShowTimelineActionDisplayConfig> Pack(FlatBufferBuilder builder, IShowTimelineActionDisplayConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowTimelineActionDisplayConfig>);
			}
			StringOffset shortNameOffset = (_o.ShortName == null) ? default(StringOffset) : builder.CreateString(_o.ShortName);
			StringOffset superscriptOffset = (_o.Superscript == null) ? default(StringOffset) : builder.CreateString(_o.Superscript);
			StringOffset debugTextOffset = (_o.DebugText == null) ? default(StringOffset) : builder.CreateString(_o.DebugText);
			return IShowTimelineActionDisplayConfig.CreateIShowTimelineActionDisplayConfig(builder, shortNameOffset, _o.IconSkillId, superscriptOffset, debugTextOffset, _o.SkillGroupId);
		}

		// Token: 0x0400B10E RID: 45326
		private Table __p;
	}
}
