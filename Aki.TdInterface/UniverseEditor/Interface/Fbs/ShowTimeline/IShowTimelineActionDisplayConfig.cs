using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FA6 RID: 16294
	public struct IShowTimelineActionDisplayConfig : IFlatbufferObject
	{
		// Token: 0x17006E3E RID: 28222
		// (get) Token: 0x06016369 RID: 90985 RVA: 0x0032F272 File Offset: 0x0032D472
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601636A RID: 90986 RVA: 0x0032F27F File Offset: 0x0032D47F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601636B RID: 90987 RVA: 0x0032F288 File Offset: 0x0032D488
		public static IShowTimelineActionDisplayConfig GetRootAsIShowTimelineActionDisplayConfig(ByteBuffer _bb)
		{
			return IShowTimelineActionDisplayConfig.GetRootAsIShowTimelineActionDisplayConfig(_bb, default(IShowTimelineActionDisplayConfig));
		}

		// Token: 0x0601636C RID: 90988 RVA: 0x0032F2A4 File Offset: 0x0032D4A4
		public static IShowTimelineActionDisplayConfig GetRootAsIShowTimelineActionDisplayConfig(ByteBuffer _bb, IShowTimelineActionDisplayConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601636D RID: 90989 RVA: 0x0032F2C1 File Offset: 0x0032D4C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601636E RID: 90990 RVA: 0x0032F2D0 File Offset: 0x0032D4D0
		public IShowTimelineActionDisplayConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006E3F RID: 28223
		// (get) Token: 0x0601636F RID: 90991 RVA: 0x0032F2E0 File Offset: 0x0032D4E0
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

		// Token: 0x06016370 RID: 90992 RVA: 0x0032F317 File Offset: 0x0032D517
		public Span<byte> GetShortNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06016371 RID: 90993 RVA: 0x0032F326 File Offset: 0x0032D526
		public byte[] GetShortNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17006E40 RID: 28224
		// (get) Token: 0x06016372 RID: 90994 RVA: 0x0032F334 File Offset: 0x0032D534
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

		// Token: 0x17006E41 RID: 28225
		// (get) Token: 0x06016373 RID: 90995 RVA: 0x0032F370 File Offset: 0x0032D570
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

		// Token: 0x06016374 RID: 90996 RVA: 0x0032F3A7 File Offset: 0x0032D5A7
		public Span<byte> GetSuperscriptBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06016375 RID: 90997 RVA: 0x0032F3B6 File Offset: 0x0032D5B6
		public byte[] GetSuperscriptArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17006E42 RID: 28226
		// (get) Token: 0x06016376 RID: 90998 RVA: 0x0032F3C4 File Offset: 0x0032D5C4
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

		// Token: 0x06016377 RID: 90999 RVA: 0x0032F3FC File Offset: 0x0032D5FC
		public Span<byte> GetDebugTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06016378 RID: 91000 RVA: 0x0032F40C File Offset: 0x0032D60C
		public byte[] GetDebugTextArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x17006E43 RID: 28227
		// (get) Token: 0x06016379 RID: 91001 RVA: 0x0032F41C File Offset: 0x0032D61C
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

		// Token: 0x0601637A RID: 91002 RVA: 0x0032F459 File Offset: 0x0032D659
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

		// Token: 0x0601637B RID: 91003 RVA: 0x0032F48D File Offset: 0x0032D68D
		public static void StartIShowTimelineActionDisplayConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601637C RID: 91004 RVA: 0x0032F496 File Offset: 0x0032D696
		public static void AddShortName(FlatBufferBuilder builder, StringOffset shortNameOffset)
		{
			builder.AddOffset(0, shortNameOffset.Value, 0);
		}

		// Token: 0x0601637D RID: 91005 RVA: 0x0032F4A6 File Offset: 0x0032D6A6
		public static void AddIconSkillId(FlatBufferBuilder builder, int iconSkillId)
		{
			builder.AddInt(1, iconSkillId, 0);
		}

		// Token: 0x0601637E RID: 91006 RVA: 0x0032F4B1 File Offset: 0x0032D6B1
		public static void AddSuperscript(FlatBufferBuilder builder, StringOffset superscriptOffset)
		{
			builder.AddOffset(2, superscriptOffset.Value, 0);
		}

		// Token: 0x0601637F RID: 91007 RVA: 0x0032F4C1 File Offset: 0x0032D6C1
		public static void AddDebugText(FlatBufferBuilder builder, StringOffset debugTextOffset)
		{
			builder.AddOffset(3, debugTextOffset.Value, 0);
		}

		// Token: 0x06016380 RID: 91008 RVA: 0x0032F4D1 File Offset: 0x0032D6D1
		public static void AddSkillGroupId(FlatBufferBuilder builder, int skillGroupId)
		{
			builder.AddInt(4, skillGroupId, 0);
		}

		// Token: 0x06016381 RID: 91009 RVA: 0x0032F4DC File Offset: 0x0032D6DC
		public static Offset<IShowTimelineActionDisplayConfig> EndIShowTimelineActionDisplayConfig(FlatBufferBuilder builder)
		{
			return new Offset<IShowTimelineActionDisplayConfig>(builder.EndTable());
		}

		// Token: 0x06016382 RID: 91010 RVA: 0x0032F4EC File Offset: 0x0032D6EC
		public IShowTimelineActionDisplayConfigT UnPack()
		{
			IShowTimelineActionDisplayConfigT showTimelineActionDisplayConfigT = new IShowTimelineActionDisplayConfigT();
			this.UnPackTo(showTimelineActionDisplayConfigT);
			return showTimelineActionDisplayConfigT;
		}

		// Token: 0x06016383 RID: 91011 RVA: 0x0032F507 File Offset: 0x0032D707
		public void UnPackTo(IShowTimelineActionDisplayConfigT _o)
		{
			_o.ShortName = this.ShortName;
			_o.IconSkillId = this.IconSkillId;
			_o.Superscript = this.Superscript;
			_o.DebugText = this.DebugText;
			_o.SkillGroupId = this.SkillGroupId;
		}

		// Token: 0x06016384 RID: 91012 RVA: 0x0032F548 File Offset: 0x0032D748
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

		// Token: 0x0400BA8B RID: 47755
		private Table __p;
	}
}
