using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046CE RID: 18126
	public class IVisionSystemQuestBase_UnionUnion
	{
		// Token: 0x17007EED RID: 32493
		// (get) Token: 0x0601AA31 RID: 109105 RVA: 0x003C97A9 File Offset: 0x003C79A9
		// (set) Token: 0x0601AA32 RID: 109106 RVA: 0x003C97B1 File Offset: 0x003C79B1
		public IVisionSystemQuestBase_Union Type { get; set; }

		// Token: 0x17007EEE RID: 32494
		// (get) Token: 0x0601AA33 RID: 109107 RVA: 0x003C97BA File Offset: 0x003C79BA
		// (set) Token: 0x0601AA34 RID: 109108 RVA: 0x003C97C2 File Offset: 0x003C79C2
		public object Value { get; set; }

		// Token: 0x0601AA35 RID: 109109 RVA: 0x003C97CB File Offset: 0x003C79CB
		public IVisionSystemQuestBase_UnionUnion()
		{
			this.Type = IVisionSystemQuestBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601AA36 RID: 109110 RVA: 0x003C97E1 File Offset: 0x003C79E1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AA37 RID: 109111 RVA: 0x003C97F3 File Offset: 0x003C79F3
		public IVisionSystemQuestBaseT AsIVisionSystemQuestBase()
		{
			return this.As<IVisionSystemQuestBaseT>();
		}

		// Token: 0x0601AA38 RID: 109112 RVA: 0x003C97FB File Offset: 0x003C79FB
		public static IVisionSystemQuestBase_UnionUnion FromIVisionSystemQuestBase(IVisionSystemQuestBaseT _ivisionsystemquestbase)
		{
			return new IVisionSystemQuestBase_UnionUnion
			{
				Type = IVisionSystemQuestBase_Union.IVisionSystemQuestBase,
				Value = _ivisionsystemquestbase
			};
		}

		// Token: 0x0601AA39 RID: 109113 RVA: 0x003C9810 File Offset: 0x003C7A10
		public IVisionSystemQuestTargetLevelT AsIVisionSystemQuestTargetLevel()
		{
			return this.As<IVisionSystemQuestTargetLevelT>();
		}

		// Token: 0x0601AA3A RID: 109114 RVA: 0x003C9818 File Offset: 0x003C7A18
		public static IVisionSystemQuestBase_UnionUnion FromIVisionSystemQuestTargetLevel(IVisionSystemQuestTargetLevelT _ivisionsystemquesttargetlevel)
		{
			return new IVisionSystemQuestBase_UnionUnion
			{
				Type = IVisionSystemQuestBase_Union.IVisionSystemQuestTargetLevel,
				Value = _ivisionsystemquesttargetlevel
			};
		}

		// Token: 0x0601AA3B RID: 109115 RVA: 0x003C982D File Offset: 0x003C7A2D
		public IVisionSystemQuestSetActivatedT AsIVisionSystemQuestSetActivated()
		{
			return this.As<IVisionSystemQuestSetActivatedT>();
		}

		// Token: 0x0601AA3C RID: 109116 RVA: 0x003C9835 File Offset: 0x003C7A35
		public static IVisionSystemQuestBase_UnionUnion FromIVisionSystemQuestSetActivated(IVisionSystemQuestSetActivatedT _ivisionsystemquestsetactivated)
		{
			return new IVisionSystemQuestBase_UnionUnion
			{
				Type = IVisionSystemQuestBase_Union.IVisionSystemQuestSetActivated,
				Value = _ivisionsystemquestsetactivated
			};
		}

		// Token: 0x0601AA3D RID: 109117 RVA: 0x003C984A File Offset: 0x003C7A4A
		public IVisionSystemQuestDoIdentifyT AsIVisionSystemQuestDoIdentify()
		{
			return this.As<IVisionSystemQuestDoIdentifyT>();
		}

		// Token: 0x0601AA3E RID: 109118 RVA: 0x003C9852 File Offset: 0x003C7A52
		public static IVisionSystemQuestBase_UnionUnion FromIVisionSystemQuestDoIdentify(IVisionSystemQuestDoIdentifyT _ivisionsystemquestdoidentify)
		{
			return new IVisionSystemQuestBase_UnionUnion
			{
				Type = IVisionSystemQuestBase_Union.IVisionSystemQuestDoIdentify,
				Value = _ivisionsystemquestdoidentify
			};
		}

		// Token: 0x0601AA3F RID: 109119 RVA: 0x003C9868 File Offset: 0x003C7A68
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
