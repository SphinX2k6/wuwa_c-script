using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005C8E RID: 23694
	public class LevelEventEnableHostility : LevelEventBase
	{
		// Token: 0x0603A1F5 RID: 238069 RVA: 0x01062DB8 File Offset: 0x01060FB8
		public LevelEventEnableHostility(int id) : base(id)
		{
		}

		// Token: 0x0603A1F6 RID: 238070 RVA: 0x01062DC4 File Offset: 0x01060FC4
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			EnableHostility enableHostility = inParams as EnableHostility;
			if (enableHostility == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.ZS, "参数不合法", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.FinishExecute(false, false, true);
				return;
			}
			this.IsEnable = enableHostility.IsEnable;
			this.EntityIds = enableHostility.EntityIds;
			foreach (int num in this.EntityIds)
			{
				EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(num);
				if (entityByPbDataId == null || !entityByPbDataId.Valid)
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.LevelEvent;
					ELogAuthor author = ELogAuthor.ZS;
					string message = "实体不存在 可能已被销毁";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityId", num);
					instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else if (!this.IsEnable)
				{
					CharacterAiComponent component = entityByPbDataId.Entity.GetComponent<CharacterAiComponent>();
					if (component != null)
					{
						component.SetAiTickLock(true);
					}
					CharacterAiComponent component2 = entityByPbDataId.Entity.GetComponent<CharacterAiComponent>();
					if (component2 != null)
					{
						component2.SetAiHateConfig("10");
					}
				}
				else
				{
					CharacterAiComponent component3 = entityByPbDataId.Entity.GetComponent<CharacterAiComponent>();
					if (component3 != null)
					{
						component3.SetAiHateConfig("");
					}
					CharacterAiComponent component4 = entityByPbDataId.Entity.GetComponent<CharacterAiComponent>();
					if (component4 != null)
					{
						component4.SetAiTickLock(false);
					}
				}
			}
			base.FinishExecute(true, false, true);
		}

		// Token: 0x0401EB83 RID: 125827
		[Nullable(2)]
		private List<int> EntityIds;

		// Token: 0x0401EB84 RID: 125828
		private bool IsEnable;
	}
}
