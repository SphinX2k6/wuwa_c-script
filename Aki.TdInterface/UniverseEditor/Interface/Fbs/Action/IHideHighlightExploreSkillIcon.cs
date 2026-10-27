using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068EE RID: 26862
	public struct IHideHighlightExploreSkillIcon : IFlatbufferObject
	{
		// Token: 0x1700C74D RID: 51021
		// (get) Token: 0x0602EDC3 RID: 191939 RVA: 0x006649B2 File Offset: 0x00662BB2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EDC4 RID: 191940 RVA: 0x006649BF File Offset: 0x00662BBF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EDC5 RID: 191941 RVA: 0x006649C8 File Offset: 0x00662BC8
		public static IHideHighlightExploreSkillIcon GetRootAsIHideHighlightExploreSkillIcon(ByteBuffer _bb)
		{
			return IHideHighlightExploreSkillIcon.GetRootAsIHideHighlightExploreSkillIcon(_bb, default(IHideHighlightExploreSkillIcon));
		}

		// Token: 0x0602EDC6 RID: 191942 RVA: 0x006649E4 File Offset: 0x00662BE4
		public static IHideHighlightExploreSkillIcon GetRootAsIHideHighlightExploreSkillIcon(ByteBuffer _bb, IHideHighlightExploreSkillIcon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EDC7 RID: 191943 RVA: 0x00664A01 File Offset: 0x00662C01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EDC8 RID: 191944 RVA: 0x00664A10 File Offset: 0x00662C10
		public IHideHighlightExploreSkillIcon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C74E RID: 51022
		// (get) Token: 0x0602EDC9 RID: 191945 RVA: 0x00664A20 File Offset: 0x00662C20
		public EHighlightExploreSkillIconType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHighlightExploreSkillIconType.Show;
				}
				return (EHighlightExploreSkillIconType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C74F RID: 51023
		// (get) Token: 0x0602EDCA RID: 191946 RVA: 0x00664A5C File Offset: 0x00662C5C
		public EHighlightType HighlightType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EHighlightType.CommonWhite;
				}
				return (EHighlightType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C750 RID: 51024
		// (get) Token: 0x0602EDCB RID: 191947 RVA: 0x00664A98 File Offset: 0x00662C98
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602EDCC RID: 191948 RVA: 0x00664AD4 File Offset: 0x00662CD4
		public static Offset<IHideHighlightExploreSkillIcon> CreateIHideHighlightExploreSkillIcon(FlatBufferBuilder builder, EHighlightExploreSkillIconType Type = EHighlightExploreSkillIconType.Show, EHighlightType HighlightType = EHighlightType.CommonWhite, byte NullMask = 0)
		{
			builder.StartTable(3);
			IHideHighlightExploreSkillIcon.AddNullMask(builder, NullMask);
			IHideHighlightExploreSkillIcon.AddHighlightType(builder, HighlightType);
			IHideHighlightExploreSkillIcon.AddType(builder, Type);
			return IHideHighlightExploreSkillIcon.EndIHideHighlightExploreSkillIcon(builder);
		}

		// Token: 0x0602EDCD RID: 191949 RVA: 0x00664AF8 File Offset: 0x00662CF8
		public static void StartIHideHighlightExploreSkillIcon(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602EDCE RID: 191950 RVA: 0x00664B01 File Offset: 0x00662D01
		public static void AddType(FlatBufferBuilder builder, EHighlightExploreSkillIconType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EDCF RID: 191951 RVA: 0x00664B0C File Offset: 0x00662D0C
		public static void AddHighlightType(FlatBufferBuilder builder, EHighlightType highlightType)
		{
			builder.AddByte(1, (byte)highlightType, 0);
		}

		// Token: 0x0602EDD0 RID: 191952 RVA: 0x00664B17 File Offset: 0x00662D17
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602EDD1 RID: 191953 RVA: 0x00664B22 File Offset: 0x00662D22
		public static Offset<IHideHighlightExploreSkillIcon> EndIHideHighlightExploreSkillIcon(FlatBufferBuilder builder)
		{
			return new Offset<IHideHighlightExploreSkillIcon>(builder.EndTable());
		}

		// Token: 0x0602EDD2 RID: 191954 RVA: 0x00664B30 File Offset: 0x00662D30
		public IHideHighlightExploreSkillIconT UnPack()
		{
			IHideHighlightExploreSkillIconT hideHighlightExploreSkillIconT = new IHideHighlightExploreSkillIconT();
			this.UnPackTo(hideHighlightExploreSkillIconT);
			return hideHighlightExploreSkillIconT;
		}

		// Token: 0x0602EDD3 RID: 191955 RVA: 0x00664B4B File Offset: 0x00662D4B
		public void UnPackTo(IHideHighlightExploreSkillIconT _o)
		{
			_o.Type = this.Type;
			_o.HighlightType = this.HighlightType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602EDD4 RID: 191956 RVA: 0x00664B74 File Offset: 0x00662D74
		public static Offset<IHideHighlightExploreSkillIcon> Pack(FlatBufferBuilder builder, IHideHighlightExploreSkillIconT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHideHighlightExploreSkillIcon>);
			}
			return IHideHighlightExploreSkillIcon.CreateIHideHighlightExploreSkillIcon(builder, _o.Type, _o.HighlightType, _o.NullMask);
		}

		// Token: 0x0401105D RID: 69725
		private Table __p;
	}
}
