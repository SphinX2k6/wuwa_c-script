using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B16 RID: 27414
	public class LevelEventEnableHostility : LevelEventBase
	{
		// Token: 0x060440A3 RID: 278691 RVA: 0x010B952C File Offset: 0x010B772C
		public LevelEventEnableHostility(int id) : base(id)
		{
		}

		// Token: 0x060440A4 RID: 278692 RVA: 0x010B9538 File Offset: 0x010B7738
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

		// Token: 0x040238E1 RID: 145633
		[Nullable(2)]
		private List<int> EntityIds;

		// Token: 0x040238E2 RID: 145634
		private bool IsEnable;
	}
}
