using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078AB RID: 30891
	public struct IShowHighlightExploreSkillIcon : IFlatbufferObject
	{
		// Token: 0x1700E293 RID: 58003
		// (get) Token: 0x060365A5 RID: 222629 RVA: 0x00746FE9 File Offset: 0x007451E9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060365A6 RID: 222630 RVA: 0x00746FF6 File Offset: 0x007451F6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060365A7 RID: 222631 RVA: 0x00747000 File Offset: 0x00745200
		public static IShowHighlightExploreSkillIcon GetRootAsIShowHighlightExploreSkillIcon(ByteBuffer _bb)
		{
			return IShowHighlightExploreSkillIcon.GetRootAsIShowHighlightExploreSkillIcon(_bb, default(IShowHighlightExploreSkillIcon));
		}

		// Token: 0x060365A8 RID: 222632 RVA: 0x0074701C File Offset: 0x0074521C
		public static IShowHighlightExploreSkillIcon GetRootAsIShowHighlightExploreSkillIcon(ByteBuffer _bb, IShowHighlightExploreSkillIcon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060365A9 RID: 222633 RVA: 0x00747039 File Offset: 0x00745239
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060365AA RID: 222634 RVA: 0x00747048 File Offset: 0x00745248
		public IShowHighlightExploreSkillIcon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E294 RID: 58004
		// (get) Token: 0x060365AB RID: 222635 RVA: 0x00747058 File Offset: 0x00745258
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

		// Token: 0x1700E295 RID: 58005
		// (get) Token: 0x060365AC RID: 222636 RVA: 0x00747094 File Offset: 0x00745294
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

		// Token: 0x1700E296 RID: 58006
		// (get) Token: 0x060365AD RID: 222637 RVA: 0x007470D0 File Offset: 0x007452D0
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

		// Token: 0x1700E297 RID: 58007
		// (get) Token: 0x060365AE RID: 222638 RVA: 0x0074710C File Offset: 0x0074530C
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

		// Token: 0x1700E298 RID: 58008
		// (get) Token: 0x060365AF RID: 222639 RVA: 0x00747150 File Offset: 0x00745350
		public bool IsSwitchBack
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E299 RID: 58009
		// (get) Token: 0x060365B0 RID: 222640 RVA: 0x00747190 File Offset: 0x00745390
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

		// Token: 0x060365B1 RID: 222641 RVA: 0x007471CD File Offset: 0x007453CD
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

		// Token: 0x060365B2 RID: 222642 RVA: 0x00747209 File Offset: 0x00745409
		public static void StartIShowHighlightExploreSkillIcon(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060365B3 RID: 222643 RVA: 0x00747212 File Offset: 0x00745412
		public static void AddType(FlatBufferBuilder builder, EHighlightExploreSkillIconType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060365B4 RID: 222644 RVA: 0x0074721D File Offset: 0x0074541D
		public static void AddHighlightType(FlatBufferBuilder builder, EHighlightType highlightType)
		{
			builder.AddByte(1, (byte)highlightType, 0);
		}

		// Token: 0x060365B5 RID: 222645 RVA: 0x00747228 File Offset: 0x00745428
		public static void AddSkillType(FlatBufferBuilder builder, int skillType)
		{
			builder.AddInt(2, skillType, 0);
		}

		// Token: 0x060365B6 RID: 222646 RVA: 0x00747233 File Offset: 0x00745433
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(3, duration, 0.0);
		}

		// Token: 0x060365B7 RID: 222647 RVA: 0x00747246 File Offset: 0x00745446
		public static void AddIsSwitchBack(FlatBufferBuilder builder, bool isSwitchBack)
		{
			builder.AddBool(4, isSwitchBack, false);
		}

		// Token: 0x060365B8 RID: 222648 RVA: 0x00747251 File Offset: 0x00745451
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060365B9 RID: 222649 RVA: 0x0074725C File Offset: 0x0074545C
		public static Offset<IShowHighlightExploreSkillIcon> EndIShowHighlightExploreSkillIcon(FlatBufferBuilder builder)
		{
			return new Offset<IShowHighlightExploreSkillIcon>(builder.EndTable());
		}

		// Token: 0x060365BA RID: 222650 RVA: 0x0074726C File Offset: 0x0074546C
		public IShowHighlightExploreSkillIconT UnPack()
		{
			IShowHighlightExploreSkillIconT showHighlightExploreSkillIconT = new IShowHighlightExploreSkillIconT();
			this.UnPackTo(showHighlightExploreSkillIconT);
			return showHighlightExploreSkillIconT;
		}

		// Token: 0x060365BB RID: 222651 RVA: 0x00747288 File Offset: 0x00745488
		public void UnPackTo(IShowHighlightExploreSkillIconT _o)
		{
			_o.Type = this.Type;
			_o.HighlightType = this.HighlightType;
			_o.SkillType = this.SkillType;
			_o.Duration = this.Duration;
			_o.IsSwitchBack = this.IsSwitchBack;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060365BC RID: 222652 RVA: 0x007472E0 File Offset: 0x007454E0
		public static Offset<IShowHighlightExploreSkillIcon> Pack(FlatBufferBuilder builder, IShowHighlightExploreSkillIconT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowHighlightExploreSkillIcon>);
			}
			return IShowHighlightExploreSkillIcon.CreateIShowHighlightExploreSkillIcon(builder, _o.Type, _o.HighlightType, _o.SkillType, _o.Duration, _o.IsSwitchBack, _o.NullMask);
		}

		// Token: 0x04012B44 RID: 76612
		private Table __p;
	}
}
