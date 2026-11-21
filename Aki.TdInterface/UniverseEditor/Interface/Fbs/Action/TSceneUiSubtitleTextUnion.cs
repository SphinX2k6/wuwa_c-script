using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FAD RID: 32685
	public class TSceneUiSubtitleTextUnion
	{
		// Token: 0x1700F2EB RID: 62187
		// (get) Token: 0x0603AE03 RID: 241155 RVA: 0x007E9306 File Offset: 0x007E7506
		// (set) Token: 0x0603AE04 RID: 241156 RVA: 0x007E930E File Offset: 0x007E750E
		public TSceneUiSubtitleText Type { get; set; }

		// Token: 0x1700F2EC RID: 62188
		// (get) Token: 0x0603AE05 RID: 241157 RVA: 0x007E9317 File Offset: 0x007E7517
		// (set) Token: 0x0603AE06 RID: 241158 RVA: 0x007E931F File Offset: 0x007E751F
		public object Value { get; set; }

		// Token: 0x0603AE07 RID: 241159 RVA: 0x007E9328 File Offset: 0x007E7528
		public TSceneUiSubtitleTextUnion()
		{
			this.Type = TSceneUiSubtitleText.NONE;
			this.Value = null;
		}

		// Token: 0x0603AE08 RID: 241160 RVA: 0x007E933E File Offset: 0x007E753E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AE09 RID: 241161 RVA: 0x007E9350 File Offset: 0x007E7550
		public ISceneUiSubtitleTextFlowT AsISceneUiSubtitleTextFlow()
		{
			return this.As<ISceneUiSubtitleTextFlowT>();
		}

		// Token: 0x0603AE0A RID: 241162 RVA: 0x007E9358 File Offset: 0x007E7558
		public static TSceneUiSubtitleTextUnion FromISceneUiSubtitleTextFlow(ISceneUiSubtitleTextFlowT _isceneuisubtitletextflow)
		{
			return new TSceneUiSubtitleTextUnion
			{
				Type = TSceneUiSubtitleText.ISceneUiSubtitleTextFlow,
				Value = _isceneuisubtitletextflow
			};
		}

		// Token: 0x0603AE0B RID: 241163 RVA: 0x007E936D File Offset: 0x007E756D
		public ISceneUiSubtitleTextKeyT AsISceneUiSubtitleTextKey()
		{
			return this.As<ISceneUiSubtitleTextKeyT>();
		}

		// Token: 0x0603AE0C RID: 241164 RVA: 0x007E9375 File Offset: 0x007E7575
		public static TSceneUiSubtitleTextUnion FromISceneUiSubtitleTextKey(ISceneUiSubtitleTextKeyT _isceneuisubtitletextkey)
		{
			return new TSceneUiSubtitleTextUnion
			{
				Type = TSceneUiSubtitleText.ISceneUiSubtitleTextKey,
				Value = _isceneuisubtitletextkey
			};
		}

		// Token: 0x0603AE0D RID: 241165 RVA: 0x007E938C File Offset: 0x007E758C
		public static int Pack(FlatBufferBuilder builder, TSceneUiSubtitleTextUnion _o)
		{
			TSceneUiSubtitleText type = _o.Type;
			if (type == TSceneUiSubtitleText.ISceneUiSubtitleTextFlow)
			{
				return ISceneUiSubtitleTextFlow.Pack(builder, _o.AsISceneUiSubtitleTextFlow()).Value;
			}
			if (type != TSceneUiSubtitleText.ISceneUiSubtitleTextKey)
			{
				return 0;
			}
			return ISceneUiSubtitleTextKey.Pack(builder, _o.AsISceneUiSubtitleTextKey()).Value;
		}
	}
}
