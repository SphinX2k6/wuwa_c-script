using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.Sequence.NpcPerformState
{
	// Token: 0x02003FF7 RID: 16375
	[NullableContext(1)]
	[Nullable(0)]
	public class SeqNpcPerformStateManager : Singleton
	{
		// Token: 0x0602970A RID: 169738 RVA: 0x00BABAE6 File Offset: 0x00BA9CE6
		private void EnsureInit()
		{
			if (this.Initialized)
			{
				return;
			}
			this.Initialized = true;
			this.Register(new HoldingHandsSeqStateHandler());
			this.Register(new AssistedWalkSeqStateHandler());
			this.Register(new CancelAssistedWalkSeqStateHandler());
		}

		// Token: 0x0602970B RID: 169739 RVA: 0x00BABB19 File Offset: 0x00BA9D19
		private void Register(SeqNpcPerformStateHandler handler)
		{
			this.CaptureHandlerMap[handler.PerformType] = handler;
			this.RestoreHandlerMap[handler.RelationType] = handler;
		}

		// Token: 0x0602970C RID: 169740 RVA: 0x00BABB40 File Offset: 0x00BA9D40
		[return: Nullable(2)]
		public NpcRelation Capture(ENpcGroupPerformType type, string key)
		{
			this.EnsureInit();
			SeqNpcPerformStateHandler seqNpcPerformStateHandler;
			if (!this.CaptureHandlerMap.TryGetValue(type, out seqNpcPerformStateHandler))
			{
				return null;
			}
			return seqNpcPerformStateHandler.Capture(key);
		}

		// Token: 0x0602970D RID: 169741 RVA: 0x00BABB6C File Offset: 0x00BA9D6C
		public void OnBattleCharacterHidden(string reason)
		{
			this.EnsureInit();
			SequenceModel instance = SequenceModel.Instance;
			Dictionary<FName, NpcRelation> dictionary = (instance != null) ? instance.NpcRelationMap : null;
			if (dictionary == null)
			{
				return;
			}
			foreach (NpcRelation npcRelation in dictionary.Values)
			{
				SeqNpcPerformStateHandler seqNpcPerformStateHandler;
				if (this.RestoreHandlerMap.TryGetValue(npcRelation.RelationType, out seqNpcPerformStateHandler))
				{
					seqNpcPerformStateHandler.OnBattleCharacterHidden(npcRelation, reason);
				}
			}
		}

		// Token: 0x0602970E RID: 169742 RVA: 0x00BABBF4 File Offset: 0x00BA9DF4
		public void Restore(NpcRelation relation, string reason)
		{
			this.EnsureInit();
			SeqNpcPerformStateHandler seqNpcPerformStateHandler;
			if (!this.RestoreHandlerMap.TryGetValue(relation.RelationType, out seqNpcPerformStateHandler))
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.HYF;
				string message = "[SeqNpcPerformState] Restore 未注册的关系类型";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("RelationType", relation.RelationType);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			seqNpcPerformStateHandler.Restore(relation, reason);
		}

		// Token: 0x170053DE RID: 21470
		// (get) Token: 0x0602970F RID: 169743 RVA: 0x00BABC56 File Offset: 0x00BA9E56
		public static SeqNpcPerformStateManager Instance
		{
			get
			{
				if (SeqNpcPerformStateManager._instance == null)
				{
					SeqNpcPerformStateManager._instance = new SeqNpcPerformStateManager();
					SeqNpcPerformStateManager._instance.OnInit();
				}
				return SeqNpcPerformStateManager._instance;
			}
		}

		// Token: 0x06029710 RID: 169744 RVA: 0x00BABC79 File Offset: 0x00BA9E79
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06029711 RID: 169745 RVA: 0x00BABC7B File Offset: 0x00BA9E7B
		public static void ResetStaticDefaultValue()
		{
			SeqNpcPerformStateManager instance = SeqNpcPerformStateManager._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			SeqNpcPerformStateManager._instance = null;
		}

		// Token: 0x06029712 RID: 169746 RVA: 0x00BABC94 File Offset: 0x00BA9E94
		static SeqNpcPerformStateManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SeqNpcPerformStateManager.CreateStaticDefaultValue), new Action(SeqNpcPerformStateManager.ResetStaticDefaultValue));
		}

		// Token: 0x040169C7 RID: 92615
		private readonly Dictionary<ENpcGroupPerformType, SeqNpcPerformStateHandler> CaptureHandlerMap = new Dictionary<ENpcGroupPerformType, SeqNpcPerformStateHandler>();

		// Token: 0x040169C8 RID: 92616
		private readonly Dictionary<ENpcRelationType, SeqNpcPerformStateHandler> RestoreHandlerMap = new Dictionary<ENpcRelationType, SeqNpcPerformStateHandler>();

		// Token: 0x040169C9 RID: 92617
		private bool Initialized;

		// Token: 0x040169CA RID: 92618
		[Nullable(2)]
		private static SeqNpcPerformStateManager _instance;
	}
}
