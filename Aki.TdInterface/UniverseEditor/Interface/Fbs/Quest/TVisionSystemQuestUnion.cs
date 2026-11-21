using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004798 RID: 18328
	public class TVisionSystemQuestUnion
	{
		// Token: 0x17007FBB RID: 32699
		// (get) Token: 0x0601AFBB RID: 110523 RVA: 0x003D2FE6 File Offset: 0x003D11E6
		// (set) Token: 0x0601AFBC RID: 110524 RVA: 0x003D2FEE File Offset: 0x003D11EE
		public TVisionSystemQuest Type { get; set; }

		// Token: 0x17007FBC RID: 32700
		// (get) Token: 0x0601AFBD RID: 110525 RVA: 0x003D2FF7 File Offset: 0x003D11F7
		// (set) Token: 0x0601AFBE RID: 110526 RVA: 0x003D2FFF File Offset: 0x003D11FF
		public object Value { get; set; }

		// Token: 0x0601AFBF RID: 110527 RVA: 0x003D3008 File Offset: 0x003D1208
		public TVisionSystemQuestUnion()
		{
			this.Type = TVisionSystemQuest.NONE;
			this.Value = null;
		}

		// Token: 0x0601AFC0 RID: 110528 RVA: 0x003D301E File Offset: 0x003D121E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AFC1 RID: 110529 RVA: 0x003D3030 File Offset: 0x003D1230
		public IVisionSystemQuestDoIdentifyT AsIVisionSystemQuestDoIdentify()
		{
			return this.As<IVisionSystemQuestDoIdentifyT>();
		}

		// Token: 0x0601AFC2 RID: 110530 RVA: 0x003D3038 File Offset: 0x003D1238
		public static TVisionSystemQuestUnion FromIVisionSystemQuestDoIdentify(IVisionSystemQuestDoIdentifyT _ivisionsystemquestdoidentify)
		{
			return new TVisionSystemQuestUnion
			{
				Type = TVisionSystemQuest.IVisionSystemQuestDoIdentify,
				Value = _ivisionsystemquestdoidentify
			};
		}

		// Token: 0x0601AFC3 RID: 110531 RVA: 0x003D304D File Offset: 0x003D124D
		public IVisionSystemQuestSetActivatedT AsIVisionSystemQuestSetActivated()
		{
			return this.As<IVisionSystemQuestSetActivatedT>();
		}

		// Token: 0x0601AFC4 RID: 110532 RVA: 0x003D3055 File Offset: 0x003D1255
		public static TVisionSystemQuestUnion FromIVisionSystemQuestSetActivated(IVisionSystemQuestSetActivatedT _ivisionsystemquestsetactivated)
		{
			return new TVisionSystemQuestUnion
			{
				Type = TVisionSystemQuest.IVisionSystemQuestSetActivated,
				Value = _ivisionsystemquestsetactivated
			};
		}

		// Token: 0x0601AFC5 RID: 110533 RVA: 0x003D306A File Offset: 0x003D126A
		public IVisionSystemQuestTargetLevelT AsIVisionSystemQuestTargetLevel()
		{
			return this.As<IVisionSystemQuestTargetLevelT>();
		}

		// Token: 0x0601AFC6 RID: 110534 RVA: 0x003D3072 File Offset: 0x003D1272
		public static TVisionSystemQuestUnion FromIVisionSystemQuestTargetLevel(IVisionSystemQuestTargetLevelT _ivisionsystemquesttargetlevel)
		{
			return new TVisionSystemQuestUnion
			{
				Type = TVisionSystemQuest.IVisionSystemQuestTargetLevel,
				Value = _ivisionsystemquesttargetlevel
			};
		}

		// Token: 0x0601AFC7 RID: 110535 RVA: 0x003D3088 File Offset: 0x003D1288
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
