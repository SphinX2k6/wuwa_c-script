using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004336 RID: 17206
	public class TVisionSystemQuestUnion
	{
		// Token: 0x17007986 RID: 31110
		// (get) Token: 0x0601982D RID: 104493 RVA: 0x003A75BE File Offset: 0x003A57BE
		// (set) Token: 0x0601982E RID: 104494 RVA: 0x003A75C6 File Offset: 0x003A57C6
		public TVisionSystemQuest Type { get; set; }

		// Token: 0x17007987 RID: 31111
		// (get) Token: 0x0601982F RID: 104495 RVA: 0x003A75CF File Offset: 0x003A57CF
		// (set) Token: 0x06019830 RID: 104496 RVA: 0x003A75D7 File Offset: 0x003A57D7
		public object Value { get; set; }

		// Token: 0x06019831 RID: 104497 RVA: 0x003A75E0 File Offset: 0x003A57E0
		public TVisionSystemQuestUnion()
		{
			this.Type = TVisionSystemQuest.NONE;
			this.Value = null;
		}

		// Token: 0x06019832 RID: 104498 RVA: 0x003A75F6 File Offset: 0x003A57F6
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06019833 RID: 104499 RVA: 0x003A7608 File Offset: 0x003A5808
		public IVisionSystemQuestDoIdentifyT AsIVisionSystemQuestDoIdentify()
		{
			return this.As<IVisionSystemQuestDoIdentifyT>();
		}

		// Token: 0x06019834 RID: 104500 RVA: 0x003A7610 File Offset: 0x003A5810
		public static TVisionSystemQuestUnion FromIVisionSystemQuestDoIdentify(IVisionSystemQuestDoIdentifyT _ivisionsystemquestdoidentify)
		{
			return new TVisionSystemQuestUnion
			{
				Type = TVisionSystemQuest.IVisionSystemQuestDoIdentify,
				Value = _ivisionsystemquestdoidentify
			};
		}

		// Token: 0x06019835 RID: 104501 RVA: 0x003A7625 File Offset: 0x003A5825
		public IVisionSystemQuestSetActivatedT AsIVisionSystemQuestSetActivated()
		{
			return this.As<IVisionSystemQuestSetActivatedT>();
		}

		// Token: 0x06019836 RID: 104502 RVA: 0x003A762D File Offset: 0x003A582D
		public static TVisionSystemQuestUnion FromIVisionSystemQuestSetActivated(IVisionSystemQuestSetActivatedT _ivisionsystemquestsetactivated)
		{
			return new TVisionSystemQuestUnion
			{
				Type = TVisionSystemQuest.IVisionSystemQuestSetActivated,
				Value = _ivisionsystemquestsetactivated
			};
		}

		// Token: 0x06019837 RID: 104503 RVA: 0x003A7642 File Offset: 0x003A5842
		public IVisionSystemQuestTargetLevelT AsIVisionSystemQuestTargetLevel()
		{
			return this.As<IVisionSystemQuestTargetLevelT>();
		}

		// Token: 0x06019838 RID: 104504 RVA: 0x003A764A File Offset: 0x003A584A
		public static TVisionSystemQuestUnion FromIVisionSystemQuestTargetLevel(IVisionSystemQuestTargetLevelT _ivisionsystemquesttargetlevel)
		{
			return new TVisionSystemQuestUnion
			{
				Type = TVisionSystemQuest.IVisionSystemQuestTargetLevel,
				Value = _ivisionsystemquesttargetlevel
			};
		}

		// Token: 0x06019839 RID: 104505 RVA: 0x003A7660 File Offset: 0x003A5860
		public static int Pack(FlatBufferBuilder builder, TVisionSystemQuestUnion _o)
		{
			switch (_o.Type)
			{
			case TVisionSystemQuest.IVisionSystemQuestDoIdentify:
				return IVisionSystemQuestDoIdentify.Pack(builder, _o.AsIVisionSystemQuestDoIdentify()).Value;
			case TVisionSystemQuest.IVisionSystemQuestSetActivated:
				return IVisionSystemQuestSetActivated.Pack(builder, _o.AsIVisionSystemQuestSetActivated()).Value;
			case TVisionSystemQuest.IVisionSystemQuestTargetLevel:
				return IVisionSystemQuestTargetLevel.Pack(builder, _o.AsIVisionSystemQuestTargetLevel()).Value;
			default:
				return 0;
			}
		}
	}
}
