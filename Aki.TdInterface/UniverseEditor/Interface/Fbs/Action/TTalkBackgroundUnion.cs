using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FF8 RID: 32760
	public class TTalkBackgroundUnion
	{
		// Token: 0x1700F31D RID: 62237
		// (get) Token: 0x0603AF5F RID: 241503 RVA: 0x007EB26E File Offset: 0x007E946E
		// (set) Token: 0x0603AF60 RID: 241504 RVA: 0x007EB276 File Offset: 0x007E9476
		public TTalkBackground Type { get; set; }

		// Token: 0x1700F31E RID: 62238
		// (get) Token: 0x0603AF61 RID: 241505 RVA: 0x007EB27F File Offset: 0x007E947F
		// (set) Token: 0x0603AF62 RID: 241506 RVA: 0x007EB287 File Offset: 0x007E9487
		public object Value { get; set; }

		// Token: 0x0603AF63 RID: 241507 RVA: 0x007EB290 File Offset: 0x007E9490
		public TTalkBackgroundUnion()
		{
			this.Type = TTalkBackground.NONE;
			this.Value = null;
		}

		// Token: 0x0603AF64 RID: 241508 RVA: 0x007EB2A6 File Offset: 0x007E94A6
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AF65 RID: 241509 RVA: 0x007EB2B8 File Offset: 0x007E94B8
		public ITalkBackgroundCleanT AsITalkBackgroundClean()
		{
			return this.As<ITalkBackgroundCleanT>();
		}

		// Token: 0x0603AF66 RID: 241510 RVA: 0x007EB2C0 File Offset: 0x007E94C0
		public static TTalkBackgroundUnion FromITalkBackgroundClean(ITalkBackgroundCleanT _italkbackgroundclean)
		{
			return new TTalkBackgroundUnion
			{
				Type = TTalkBackground.ITalkBackgroundClean,
				Value = _italkbackgroundclean
			};
		}

		// Token: 0x0603AF67 RID: 241511 RVA: 0x007EB2D5 File Offset: 0x007E94D5
		public ITalkBackgroundIconT AsITalkBackgroundIcon()
		{
			return this.As<ITalkBackgroundIconT>();
		}

		// Token: 0x0603AF68 RID: 241512 RVA: 0x007EB2DD File Offset: 0x007E94DD
		public static TTalkBackgroundUnion FromITalkBackgroundIcon(ITalkBackgroundIconT _italkbackgroundicon)
		{
			return new TTalkBackgroundUnion
			{
				Type = TTalkBackground.ITalkBackgroundIcon,
				Value = _italkbackgroundicon
			};
		}

		// Token: 0x0603AF69 RID: 241513 RVA: 0x007EB2F2 File Offset: 0x007E94F2
		public ITalkBackgroundImageT AsITalkBackgroundImage()
		{
			return this.As<ITalkBackgroundImageT>();
		}

		// Token: 0x0603AF6A RID: 241514 RVA: 0x007EB2FA File Offset: 0x007E94FA
		public static TTalkBackgroundUnion FromITalkBackgroundImage(ITalkBackgroundImageT _italkbackgroundimage)
		{
			return new TTalkBackgroundUnion
			{
				Type = TTalkBackground.ITalkBackgroundImage,
				Value = _italkbackgroundimage
			};
		}

		// Token: 0x0603AF6B RID: 241515 RVA: 0x007EB30F File Offset: 0x007E950F
		public ITalkBackgroundImageByMcGenderT AsITalkBackgroundImageByMcGender()
		{
			return this.As<ITalkBackgroundImageByMcGenderT>();
		}

		// Token: 0x0603AF6C RID: 241516 RVA: 0x007EB317 File Offset: 0x007E9517
		public static TTalkBackgroundUnion FromITalkBackgroundImageByMcGender(ITalkBackgroundImageByMcGenderT _italkbackgroundimagebymcgender)
		{
			return new TTalkBackgroundUnion
			{
				Type = TTalkBackground.ITalkBackgroundImageByMcGender,
				Value = _italkbackgroundimagebymcgender
			};
		}

		// Token: 0x0603AF6D RID: 241517 RVA: 0x007EB32C File Offset: 0x007E952C
		public ITalkBackgroundSpineImageT AsITalkBackgroundSpineImage()
		{
			return this.As<ITalkBackgroundSpineImageT>();
		}

		// Token: 0x0603AF6E RID: 241518 RVA: 0x007EB334 File Offset: 0x007E9534
		public static TTalkBackgroundUnion FromITalkBackgroundSpineImage(ITalkBackgroundSpineImageT _italkbackgroundspineimage)
		{
			return new TTalkBackgroundUnion
			{
				Type = TTalkBackground.ITalkBackgroundSpineImage,
				Value = _italkbackgroundspineimage
			};
		}

		// Token: 0x0603AF6F RID: 241519 RVA: 0x007EB34C File Offset: 0x007E954C
		public static int Pack(FlatBufferBuilder builder, TTalkBackgroundUnion _o)
		{
			switch (_o.Type)
			{
			case TTalkBackground.ITalkBackgroundClean:
				return ITalkBackgroundClean.Pack(builder, _o.AsITalkBackgroundClean()).Value;
			case TTalkBackground.ITalkBackgroundIcon:
				return ITalkBackgroundIcon.Pack(builder, _o.AsITalkBackgroundIcon()).Value;
			case TTalkBackground.ITalkBackgroundImage:
				return ITalkBackgroundImage.Pack(builder, _o.AsITalkBackgroundImage()).Value;
			case TTalkBackground.ITalkBackgroundImageByMcGender:
				return ITalkBackgroundImageByMcGender.Pack(builder, _o.AsITalkBackgroundImageByMcGender()).Value;
			case TTalkBackground.ITalkBackgroundSpineImage:
				return ITalkBackgroundSpineImage.Pack(builder, _o.AsITalkBackgroundSpineImage()).Value;
			default:
				return 0;
			}
		}
	}
}
