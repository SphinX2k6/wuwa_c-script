using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070DF RID: 28895
	public struct IShowHighlightExploreSkillIcon : IFlatbufferObject
	{
		// Token: 0x1700D6B0 RID: 54960
		// (get) Token: 0x06033303 RID: 209667 RVA: 0x006E69DD File Offset: 0x006E4BDD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033304 RID: 209668 RVA: 0x006E69EA File Offset: 0x006E4BEA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033305 RID: 209669 RVA: 0x006E69F4 File Offset: 0x006E4BF4
		public static IShowHighlightExploreSkillIcon GetRootAsIShowHighlightExploreSkillIcon(ByteBuffer _bb)
		{
			return IShowHighlightExploreSkillIcon.GetRootAsIShowHighlightExploreSkillIcon(_bb, default(IShowHighlightExploreSkillIcon));
		}

		// Token: 0x06033306 RID: 209670 RVA: 0x006E6A10 File Offset: 0x006E4C10
		public static IShowHighlightExploreSkillIcon GetRootAsIShowHighlightExploreSkillIcon(ByteBuffer _bb, IShowHighlightExploreSkillIcon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033307 RID: 209671 RVA: 0x006E6A2D File Offset: 0x006E4C2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033308 RID: 209672 RVA: 0x006E6A3C File Offset: 0x006E4C3C
		public IShowHighlightExploreSkillIcon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D6B1 RID: 54961
		// (get) Token: 0x06033309 RID: 209673 RVA: 0x006E6A4C File Offset: 0x006E4C4C
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

		// Token: 0x1700D6B2 RID: 54962
		// (get) Token: 0x0603330A RID: 209674 RVA: 0x006E6A88 File Offset: 0x006E4C88
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

		// Token: 0x1700D6B3 RID: 54963
		// (get) Token: 0x0603330B RID: 209675 RVA: 0x006E6AC4 File Offset: 0x006E4CC4
		public int SkillType
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

		// Token: 0x1700D6B4 RID: 54964
		// (get) Token: 0x0603330C RID: 209676 RVA: 0x006E6B00 File Offset: 0x006E4D00
		public float Duration
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D6B5 RID: 54965
		// (get) Token: 0x0603330D RID: 209677 RVA: 0x006E6B44 File Offset: 0x006E4D44
		public bool IsSwitchBack
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D6B6 RID: 54966
		// (get) Token: 0x0603330E RID: 209678 RVA: 0x006E6B84 File Offset: 0x006E4D84
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

		// Token: 0x0603330F RID: 209679 RVA: 0x006E6BC1 File Offset: 0x006E4DC1
		public static Offset<IShowHighlightExploreSkillIcon> CreateIShowHighlightExploreSkillIcon(FlatBufferBuilder builder, EHighlightExploreSkillIconType Type = EHighlightExploreSkillIconType.Show, EHighlightType HighlightType = EHighlightType.CommonWhite, int SkillType = 0, float Duration = 0f, bool IsSwitchBack = false, byte NullMask = 0)
		{
			builder.StartTable(6);
			IShowHighlightExploreSkillIcon.AddDuration(builder, Duration);
			IShowHighlightExploreSkillIcon.AddSkillType(builder, SkillType);
			IShowHighlightExploreSkillIcon.AddNullMask(builder, NullMask);
			IShowHighlightExploreSkillIcon.AddIsSwitchBack(builder, IsSwitchBack);
			IShowHighlightExploreSkillIcon.AddHighlightType(builder, HighlightType);
			IShowHighlightExploreSkillIcon.AddType(builder, Type);
			return IShowHighlightExploreSkillIcon.EndIShowHighlightExploreSkillIcon(builder);
		}

		// Token: 0x06033310 RID: 209680 RVA: 0x006E6BFD File Offset: 0x006E4DFD
		public static void StartIShowHighlightExploreSkillIcon(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06033311 RID: 209681 RVA: 0x006E6C06 File Offset: 0x006E4E06
		public static void AddType(FlatBufferBuilder builder, EHighlightExploreSkillIconType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033312 RID: 209682 RVA: 0x006E6C11 File Offset: 0x006E4E11
		public static void AddHighlightType(FlatBufferBuilder builder, EHighlightType highlightType)
		{
			builder.AddByte(1, (byte)highlightType, 0);
		}

		// Token: 0x06033313 RID: 209683 RVA: 0x006E6C1C File Offset: 0x006E4E1C
		public static void AddSkillType(FlatBufferBuilder builder, int skillType)
		{
			builder.AddInt(2, skillType, 0);
		}

		// Token: 0x06033314 RID: 209684 RVA: 0x006E6C27 File Offset: 0x006E4E27
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(3, duration, 0.0);
		}

		// Token: 0x06033315 RID: 209685 RVA: 0x006E6C3A File Offset: 0x006E4E3A
		public static void AddIsSwitchBack(FlatBufferBuilder builder, bool isSwitchBack)
		{
			builder.AddBool(4, isSwitchBack, false);
		}

		// Token: 0x06033316 RID: 209686 RVA: 0x006E6C45 File Offset: 0x006E4E45
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06033317 RID: 209687 RVA: 0x006E6C50 File Offset: 0x006E4E50
		public static Offset<IShowHighlightExploreSkillIcon> EndIShowHighlightExploreSkillIcon(FlatBufferBuilder builder)
		{
			return new Offset<IShowHighlightExploreSkillIcon>(builder.EndTable());
		}

		// Token: 0x06033318 RID: 209688 RVA: 0x006E6C60 File Offset: 0x006E4E60
		public IShowHighlightExploreSkillIconT UnPack()
		{
			IShowHighlightExploreSkillIconT showHighlightExploreSkillIconT = new IShowHighlightExploreSkillIconT();
			this.UnPackTo(showHighlightExploreSkillIconT);
			return showHighlightExploreSkillIconT;
		}

		// Token: 0x06033319 RID: 209689 RVA: 0x006E6C7C File Offset: 0x006E4E7C
		public void UnPackTo(IShowHighlightExploreSkillIconT _o)
		{
			_o.Type = this.Type;
			_o.HighlightType = this.HighlightType;
			_o.SkillType = this.SkillType;
			_o.Duration = this.Duration;
			_o.IsSwitchBack = this.IsSwitchBack;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603331A RID: 209690 RVA: 0x006E6CD4 File Offset: 0x006E4ED4
		public static Offset<IShowHighlightExploreSkillIcon> Pack(FlatBufferBuilder builder, IShowHighlightExploreSkillIconT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowHighlightExploreSkillIcon>);
			}
			return IShowHighlightExploreSkillIcon.CreateIShowHighlightExploreSkillIcon(builder, _o.Type, _o.HighlightType, _o.SkillType, _o.Duration, _o.IsSwitchBack, _o.NullMask);
		}

		// Token: 0x04011B56 RID: 72534
		private Table __p;
	}
}
