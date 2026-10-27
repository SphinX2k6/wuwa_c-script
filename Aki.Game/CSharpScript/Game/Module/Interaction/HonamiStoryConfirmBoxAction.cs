using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x0200584D RID: 22605
	public class HonamiStoryConfirmBoxAction : InteractConfirmBoxActionBase
	{
		// Token: 0x06039769 RID: 235369 RVA: 0x00DA4328 File Offset: 0x00DA2528
		[NullableContext(2)]
		protected override ConfirmBoxDataNew ConfigConfirmBoxData()
		{
			IHonamiStoryCorruptedChestConfirmBox honamiStoryCorruptedChestConfirmBox = this.Context.Option.ConfirmBox.Type as IHonamiStoryCorruptedChestConfirmBox;
			if (honamiStoryCorruptedChestConfirmBox == null)
			{
				return null;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew((EConfirmBoxConfigId)honamiStoryCorruptedChestConfirmBox.Id);
			confirmBoxDataNew.SetTextArgs(new string[]
			{
				this.GetLifeSupportCost().ToString()
			});
			confirmBoxDataNew.FunctionMap[1] = delegate()
			{
				base.ExecuteFinish(false);
			};
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				base.ExecuteFinish(true);
			};
			return confirmBoxDataNew;
		}

		// Token: 0x0603976A RID: 235370 RVA: 0x00DA43AF File Offset: 0x00DA25AF
		public float GetHonamiStoryLifeSupport()
		{
			return FormationAttributeController.Instance.GetValue(EFormationAttributeId.HonamiStoryLifeSupport);
		}

		// Token: 0x0603976B RID: 235371 RVA: 0x00DA43C0 File Offset: 0x00DA25C0
		public int GetLifeSupportCost()
		{
			InteractSecondConfirmContext context = this.Context;
			object obj;
			if (context == null)
			{
				obj = null;
			}
			else
			{
				CommonInteractOption option = context.Option;
				obj = ((option != null) ? option.Type : null);
			}
			IInteractActions interactActions = obj as IInteractActions;
			int num = 0;
			if (interactActions != null)
			{
				foreach (ActionInfo actionInfo in interactActions.Actions)
				{
					if (actionInfo.Name == EAction.HonamiStoryReceiveCorruptedChestReward)
					{
						HonamiStoryReceiveCorruptedChestReward honamiStoryReceiveCorruptedChestReward = actionInfo.Params as HonamiStoryReceiveCorruptedChestReward;
						if (honamiStoryReceiveCorruptedChestReward != null)
						{
							int? costGroup = honamiStoryReceiveCorruptedChestReward.CostGroup;
							int num2 = 0;
							if (costGroup.GetValueOrDefault() > num2 & costGroup != null)
							{
								num += HonamiStoryUtil.GetSteadyConsumeByCostGroup(honamiStoryReceiveCorruptedChestReward.CostGroup.GetValueOrDefault());
								continue;
							}
						}
						if (honamiStoryReceiveCorruptedChestReward != null)
						{
							num += honamiStoryReceiveCorruptedChestReward.Cost;
						}
					}
				}
			}
			return num;
		}
	}
}
