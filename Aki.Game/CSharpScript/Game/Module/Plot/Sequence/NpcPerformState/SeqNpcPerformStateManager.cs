using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.Sequence.NpcPerformState
{
	// Token: 0x0200502D RID: 20525
	[NullableContext(1)]
	[Nullable(0)]
	public class SeqNpcPerformStateManager : Singleton
	{
		// Token: 0x06034867 RID: 215143 RVA: 0x00C6056E File Offset: 0x00C5E76E
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

		// Token: 0x06034868 RID: 215144 RVA: 0x00C605A1 File Offset: 0x00C5E7A1
		private void Register(SeqNpcPerformStateHandler handler)
		{
			this.CaptureHandlerMap[handler.PerformType] = handler;
			this.RestoreHandlerMap[handler.RelationType] = handler;
		}

		// Token: 0x06034869 RID: 215145 RVA: 0x00C605C8 File Offset: 0x00C5E7C8
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

		// Token: 0x0603486A RID: 215146 RVA: 0x00C605F4 File Offset: 0x00C5E7F4
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

		// Token: 0x0603486B RID: 215147 RVA: 0x00C6067C File Offset: 0x00C5E87C
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

		// Token: 0x17008029 RID: 32809
		// (get) Token: 0x0603486C RID: 215148 RVA: 0x00C606DE File Offset: 0x00C5E8DE
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

		// Token: 0x0603486D RID: 215149 RVA: 0x00C60701 File Offset: 0x00C5E901
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603486E RID: 215150 RVA: 0x00C60703 File Offset: 0x00C5E903
		public static void ResetStaticDefaultValue()
		{
			SeqNpcPerformStateManager instance = SeqNpcPerformStateManager._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			SeqNpcPerformStateManager._instance = null;
		}

		// Token: 0x0603486F RID: 215151 RVA: 0x00C6071C File Offset: 0x00C5E91C
		static SeqNpcPerformStateManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SeqNpcPerformStateManager.CreateStaticDefaultValue), new Action(SeqNpcPerformStateManager.ResetStaticDefaultValue));
		}

		// Token: 0x0401BFDC RID: 114652
		private readonly Dictionary<ENpcGroupPerformType, SeqNpcPerformStateHandler> CaptureHandlerMap = new Dictionary<ENpcGroupPerformType, SeqNpcPerformStateHandler>();

		// Token: 0x0401BFDD RID: 114653
		private readonly Dictionary<ENpcRelationType, SeqNpcPerformStateHandler> RestoreHandlerMap = new Dictionary<ENpcRelationType, SeqNpcPerformStateHandler>();

		// Token: 0x0401BFDE RID: 114654
		private bool Initialized;

		// Token: 0x0401BFDF RID: 114655
		[Nullable(2)]
		private static SeqNpcPerformStateManager _instance;
	}
}
