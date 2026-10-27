using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004272 RID: 17010
	public class IVisionSystemQuestBase_UnionUnion
	{
		// Token: 0x170078BC RID: 30908
		// (get) Token: 0x060192C5 RID: 103109 RVA: 0x0039E0D1 File Offset: 0x0039C2D1
		// (set) Token: 0x060192C6 RID: 103110 RVA: 0x0039E0D9 File Offset: 0x0039C2D9
		public IVisionSystemQuestBase_Union Type { get; set; }

		// Token: 0x170078BD RID: 30909
		// (get) Token: 0x060192C7 RID: 103111 RVA: 0x0039E0E2 File Offset: 0x0039C2E2
		// (set) Token: 0x060192C8 RID: 103112 RVA: 0x0039E0EA File Offset: 0x0039C2EA
		public object Value { get; set; }

		// Token: 0x060192C9 RID: 103113 RVA: 0x0039E0F3 File Offset: 0x0039C2F3
		public IVisionSystemQuestBase_UnionUnion()
		{
			this.Type = IVisionSystemQuestBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060192CA RID: 103114 RVA: 0x0039E109 File Offset: 0x0039C309
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060192CB RID: 103115 RVA: 0x0039E11B File Offset: 0x0039C31B
		public IVisionSystemQuestBaseT AsIVisionSystemQuestBase()
		{
			return this.As<IVisionSystemQuestBaseT>();
		}

		// Token: 0x060192CC RID: 103116 RVA: 0x0039E123 File Offset: 0x0039C323
		public static IVisionSystemQuestBase_UnionUnion FromIVisionSystemQuestBase(IVisionSystemQuestBaseT _ivisionsystemquestbase)
		{
			return new IVisionSystemQuestBase_UnionUnion
			{
				Type = IVisionSystemQuestBase_Union.IVisionSystemQuestBase,
				Value = _ivisionsystemquestbase
			};
		}

		// Token: 0x060192CD RID: 103117 RVA: 0x0039E138 File Offset: 0x0039C338
		public IVisionSystemQuestTargetLevelT AsIVisionSystemQuestTargetLevel()
		{
			return this.As<IVisionSystemQuestTargetLevelT>();
		}

		// Token: 0x060192CE RID: 103118 RVA: 0x0039E140 File Offset: 0x0039C340
		public static IVisionSystemQuestBase_UnionUnion FromIVisionSystemQuestTargetLevel(IVisionSystemQuestTargetLevelT _ivisionsystemquesttargetlevel)
		{
			return new IVisionSystemQuestBase_UnionUnion
			{
				Type = IVisionSystemQuestBase_Union.IVisionSystemQuestTargetLevel,
				Value = _ivisionsystemquesttargetlevel
			};
		}

		// Token: 0x060192CF RID: 103119 RVA: 0x0039E155 File Offset: 0x0039C355
		public IVisionSystemQuestSetActivatedT AsIVisionSystemQuestSetActivated()
		{
			return this.As<IVisionSystemQuestSetActivatedT>();
		}

		// Token: 0x060192D0 RID: 103120 RVA: 0x0039E15D File Offset: 0x0039C35D
		public static IVisionSystemQuestBase_UnionUnion FromIVisionSystemQuestSetActivated(IVisionSystemQuestSetActivatedT _ivisionsystemquestsetactivated)
		{
			return new IVisionSystemQuestBase_UnionUnion
			{
				Type = IVisionSystemQuestBase_Union.IVisionSystemQuestSetActivated,
				Value = _ivisionsystemquestsetactivated
			};
		}

		// Token: 0x060192D1 RID: 103121 RVA: 0x0039E172 File Offset: 0x0039C372
		public IVisionSystemQuestDoIdentifyT AsIVisionSystemQuestDoIdentify()
		{
			return this.As<IVisionSystemQuestDoIdentifyT>();
		}

		// Token: 0x060192D2 RID: 103122 RVA: 0x0039E17A File Offset: 0x0039C37A
		public static IVisionSystemQuestBase_UnionUnion FromIVisionSystemQuestDoIdentify(IVisionSystemQuestDoIdentifyT _ivisionsystemquestdoidentify)
		{
			return new IVisionSystemQuestBase_UnionUnion
			{
				Type = IVisionSystemQuestBase_Union.IVisionSystemQuestDoIdentify,
				Value = _ivisionsystemquestdoidentify
			};
		}

		// Token: 0x060192D3 RID: 103123 RVA: 0x0039E190 File Offset: 0x0039C390
		public static int Pack(FlatBufferBuilder builder, IVisionSystemQuestBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IVisionSystemQuestBase_Union.IVisionSystemQuestBase:
				return IVisionSystemQuestBase.Pack(builder, _o.AsIVisionSystemQuestBase()).Value;
			case IVisionSystemQuestBase_Union.IVisionSystemQuestTargetLevel:
				return IVisionSystemQuestTargetLevel.Pack(builder, _o.AsIVisionSystemQuestTargetLevel()).Value;
			case IVisionSystemQuestBase_Union.IVisionSystemQuestSetActivated:
				return IVisionSystemQuestSetActivated.Pack(builder, _o.AsIVisionSystemQuestSetActivated()).Value;
			case IVisionSystemQuestBase_Union.IVisionSystemQuestDoIdentify:
				return IVisionSystemQuestDoIdentify.Pack(builder, _o.AsIVisionSystemQuestDoIdentify()).Value;
			default:
				return 0;
			}
		}
	}
}
