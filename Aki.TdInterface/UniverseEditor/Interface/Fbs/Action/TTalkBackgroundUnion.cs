using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077C0 RID: 30656
	public class TTalkBackgroundUnion
	{
		// Token: 0x1700E6C3 RID: 59075
		// (get) Token: 0x060379DC RID: 227804 RVA: 0x00785C5C File Offset: 0x00783E5C
		// (set) Token: 0x060379DD RID: 227805 RVA: 0x00785C64 File Offset: 0x00783E64
		public TTalkBackground Type { get; set; }

		// Token: 0x1700E6C4 RID: 59076
		// (get) Token: 0x060379DE RID: 227806 RVA: 0x00785C6D File Offset: 0x00783E6D
		// (set) Token: 0x060379DF RID: 227807 RVA: 0x00785C75 File Offset: 0x00783E75
		public object Value { get; set; }

		// Token: 0x060379E0 RID: 227808 RVA: 0x00785C7E File Offset: 0x00783E7E
		public TTalkBackgroundUnion()
		{
			this.Type = TTalkBackground.NONE;
			this.Value = null;
		}

		// Token: 0x060379E1 RID: 227809 RVA: 0x00785C94 File Offset: 0x00783E94
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060379E2 RID: 227810 RVA: 0x00785CA6 File Offset: 0x00783EA6
		public ITalkBackgroundCleanT AsITalkBackgroundClean()
		{
			return this.As<ITalkBackgroundCleanT>();
		}

		// Token: 0x060379E3 RID: 227811 RVA: 0x00785CAE File Offset: 0x00783EAE
		public static TTalkBackgroundUnion FromITalkBackgroundClean(ITalkBackgroundCleanT _italkbackgroundclean)
		{
			return new TTalkBackgroundUnion
			{
				Type = TTalkBackground.ITalkBackgroundClean,
				Value = _italkbackgroundclean
			};
		}

		// Token: 0x060379E4 RID: 227812 RVA: 0x00785CC3 File Offset: 0x00783EC3
		public ITalkBackgroundIconT AsITalkBackgroundIcon()
		{
			return this.As<ITalkBackgroundIconT>();
		}

		// Token: 0x060379E5 RID: 227813 RVA: 0x00785CCB File Offset: 0x00783ECB
		public static TTalkBackgroundUnion FromITalkBackgroundIcon(ITalkBackgroundIconT _italkbackgroundicon)
		{
			return new TTalkBackgroundUnion
			{
				Type = TTalkBackground.ITalkBackgroundIcon,
				Value = _italkbackgroundicon
			};
		}

		// Token: 0x060379E6 RID: 227814 RVA: 0x00785CE0 File Offset: 0x00783EE0
		public ITalkBackgroundImageT AsITalkBackgroundImage()
		{
			return this.As<ITalkBackgroundImageT>();
		}

		// Token: 0x060379E7 RID: 227815 RVA: 0x00785CE8 File Offset: 0x00783EE8
		public static TTalkBackgroundUnion FromITalkBackgroundImage(ITalkBackgroundImageT _italkbackgroundimage)
		{
			return new TTalkBackgroundUnion
			{
				Type = TTalkBackground.ITalkBackgroundImage,
				Value = _italkbackgroundimage
			};
		}

		// Token: 0x060379E8 RID: 227816 RVA: 0x00785CFD File Offset: 0x00783EFD
		public ITalkBackgroundImageByMcGenderT AsITalkBackgroundImageByMcGender()
		{
			return this.As<ITalkBackgroundImageByMcGenderT>();
		}

		// Token: 0x060379E9 RID: 227817 RVA: 0x00785D05 File Offset: 0x00783F05
		public static TTalkBackgroundUnion FromITalkBackgroundImageByMcGender(ITalkBackgroundImageByMcGenderT _italkbackgroundimagebymcgender)
		{
			return new TTalkBackgroundUnion
			{
				Type = TTalkBackground.ITalkBackgroundImageByMcGender,
				Value = _italkbackgroundimagebymcgender
			};
		}

		// Token: 0x060379EA RID: 227818 RVA: 0x00785D1A File Offset: 0x00783F1A
		public ITalkBackgroundSpineImageT AsITalkBackgroundSpineImage()
		{
			return this.As<ITalkBackgroundSpineImageT>();
		}

		// Token: 0x060379EB RID: 227819 RVA: 0x00785D22 File Offset: 0x00783F22
		public static TTalkBackgroundUnion FromITalkBackgroundSpineImage(ITalkBackgroundSpineImageT _italkbackgroundspineimage)
		{
			return new TTalkBackgroundUnion
			{
				Type = TTalkBackground.ITalkBackgroundSpineImage,
				Value = _italkbackgroundspineimage
			};
		}

		// Token: 0x060379EC RID: 227820 RVA: 0x00785D38 File Offset: 0x00783F38
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
