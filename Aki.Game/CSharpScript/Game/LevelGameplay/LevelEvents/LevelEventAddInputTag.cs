using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.LevelGamePlay.Guarantee;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006AF0 RID: 27376
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventAddInputTag : LevelEventBase
	{
		// Token: 0x06043FDA RID: 278490 RVA: 0x010AE23B File Offset: 0x010AC43B
		public LevelEventAddInputTag(int id) : base(id)
		{
		}

		// Token: 0x06043FDB RID: 278491 RVA: 0x010AE250 File Offset: 0x010AC450
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (inParams == null)
			{
				return;
			}
			LimitPlayerOperation limitPlayerOperation = inParams as LimitPlayerOperation;
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			Entity entity;
			if (baseCharacter == null)
			{
				entity = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
				entity = ((characterActorComponent != null) ? characterActorComponent.Entity : null);
			}
			Entity entity2 = entity;
			EventSystem.Instance.Emit<string>(EEventName.ForceReleaseInput, this.Reason);
			string text;
			switch (limitPlayerOperation.Type.Type)
			{
			case ELimitPlayOperation.AllowCamera:
				text = "FightInputRoot.FightInput.AxisInput.CameraInput";
				break;
			case ELimitPlayOperation.AllowAction:
				text = "FightInputRoot.FightInput.ActionInput";
				break;
			case ELimitPlayOperation.AllowMove:
				if ((limitPlayerOperation.Type as ILimitPlayerMove).IsOnlyForward.GetValueOrDefault())
				{
					InputController.Instance.SetMoveControlEnabled(true, false, false, false);
				}
				text = "FightInputRoot.FightInput.AxisInput.MoveInput";
				break;
			case ELimitPlayOperation.AllowMoveNew:
			{
				ILimitPlayerMoveNew limitPlayerMoveNew = limitPlayerOperation.Type as ILimitPlayerMoveNew;
				InputController.Instance.SetMoveControlEnabled(limitPlayerMoveNew.Forward, limitPlayerMoveNew.Back, limitPlayerMoveNew.Left, limitPlayerMoveNew.Right);
				text = "FightInputRoot.FightInput.AxisInput.MoveInput";
				if (entity2 != null && entity2.Valid)
				{
					BaseTagComponent component = entity2.GetComponent<BaseTagComponent>();
					if (component != null)
					{
						component.AddTag(new int?(GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.禁止冲刺"]));
					}
				}
				break;
			}
			case ELimitPlayOperation.AllowUi:
				text = "UiInputRoot";
				break;
			case ELimitPlayOperation.AllowMouse:
				text = "UiInputRoot.MouseInputTag";
				break;
			case ELimitPlayOperation.BlockAll:
				text = "BlockAllInputTag";
				break;
			default:
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelEvent;
				ELogAuthor author = ELogAuthor.WY;
				string message = "没有定义ELimitPlayOperation对应什么InputTag!";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ELimitPlayOperation", limitPlayerOperation.Type);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			}
			if (LevelEventLockInputState.Instance.IsLockInput())
			{
				LevelEventLockInputState.Instance.InputTagNames.Add(text);
				InputDistributeController.Instance.RefreshInputTag();
				return;
			}
			InputDistributeModel.Instance.SetInputDistributeTag(text);
			LevelEventLockInputState.Instance.Lock(new List<string>
			{
				text
			});
		}

		// Token: 0x06043FDC RID: 278492 RVA: 0x010AE418 File Offset: 0x010AC618
		protected override void OnUpdateGuarantee()
		{
			GuaranteeActionInfo p = new GuaranteeActionInfo
			{
				Name = EGuaranteeAction.UnLimitPlayerOperation
			};
			EventSystem.Instance.Emit<string, GeneralContext, GuaranteeActionInfo, bool?>(EEventName.AddGuaranteeAction, this.Type, this.BaseContext, p, null);
		}

		// Token: 0x0402388A RID: 145546
		private readonly string Reason = "Input Limited Action";
	}
}
