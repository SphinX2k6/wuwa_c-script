using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.UI;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020022FC RID: 8956
[NullableContext(1)]
[Nullable(0)]
public class PanelQteController : UiControllerBase
{
	// Token: 0x06011AB8 RID: 72376 RVA: 0x004575B0 File Offset: 0x004557B0
	public int StartAnimNotifyQte(int qteId, USkeletalMeshComponent meshComp, long? preMessageId)
	{
		if (!this.CheckCanStartQte())
		{
			return -1;
		}
		return this.StartQte(new PanelQteContext
		{
			QteId = qteId,
			PreMessageId = preMessageId,
			Source = new EPanelQteSource?(EPanelQteSource.AnimNotify),
			SourceMeshComp = meshComp,
			SourceActor = meshComp.GetOwner()
		});
	}

	// Token: 0x06011AB9 RID: 72377 RVA: 0x00457604 File Offset: 0x00455804
	[NullableContext(2)]
	public int StartBuffQte(int qteId, long buffId, int buffHandleId, Entity buffOwner, long? preMessageId)
	{
		if (!this.CheckCanStartQte())
		{
			return -1;
		}
		if (buffOwner != null)
		{
			int id = buffOwner.Id;
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			int? num = (baseCharacter != null) ? new int?(baseCharacter.EntityId) : null;
			if (id == num.GetValueOrDefault() & num != null)
			{
				PanelQteContext panelQteContext = new PanelQteContext();
				panelQteContext.QteId = qteId;
				panelQteContext.Source = new EPanelQteSource?(EPanelQteSource.Buff);
				panelQteContext.PreMessageId = preMessageId;
				panelQteContext.SourceBuffId = new long?(buffId);
				panelQteContext.SourceBuffHandleId = buffHandleId;
				PanelQteContext panelQteContext2 = panelQteContext;
				BaseActorComponent component = buffOwner.GetComponent<BaseActorComponent>();
				panelQteContext2.SourceActor = ((component != null) ? component.Owner : null);
				panelQteContext.SourceEntityHandle = CharacterModel.Instance.GetHandleByEntity(buffOwner);
				panelQteContext.IsInitSourceEntity = true;
				return this.StartQte(panelQteContext);
			}
		}
		return -1;
	}

	// Token: 0x06011ABA RID: 72378 RVA: 0x004576C8 File Offset: 0x004558C8
	public int StartLevelSequenceQte(int qteId, AActor actor)
	{
		if (!this.CheckCanStartQte())
		{
			return -1;
		}
		return this.StartQte(new PanelQteContext
		{
			QteId = qteId,
			Source = new EPanelQteSource?(EPanelQteSource.LevelSequence),
			SourceActor = actor
		});
	}

	// Token: 0x06011ABB RID: 72379 RVA: 0x00457708 File Offset: 0x00455908
	public int StartLevelEventQte(int qteId)
	{
		if (!this.CheckCanStartQte())
		{
			return -1;
		}
		return this.StartQte(new PanelQteContext
		{
			QteId = qteId,
			Source = new EPanelQteSource?(EPanelQteSource.LevelEvent)
		});
	}

	// Token: 0x06011ABC RID: 72380 RVA: 0x00457740 File Offset: 0x00455940
	public bool StopQte(int handleId, bool bForce = false)
	{
		if (!PanelQteModel.Instance.StopQte(handleId))
		{
			return false;
		}
		PanelQteModel instance = PanelQteModel.Instance;
		if (instance.IsHideAllBattleUi)
		{
			BattleUiModel.Instance.ChildViewData.ShowBattleView(EBattleUiVisibleReason.PanelQte, 0);
			instance.IsHideAllBattleUi = false;
		}
		else
		{
			int[] hideBattleUiChildren = instance.HideBattleUiChildren;
			if (hideBattleUiChildren != null)
			{
				List<EBattleUiChild> list = new List<EBattleUiChild>();
				foreach (int item in hideBattleUiChildren)
				{
					list.Add((EBattleUiChild)item);
				}
				BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.PanelQte, list, true, true, 0);
				instance.HideBattleUiChildren = null;
			}
		}
		if (instance.DisableFightInput)
		{
			BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
			BaseTagComponent baseTagComponent;
			if (((curRoleData != null) ? curRoleData.EntityHandle : null) == instance.CurRoleEntity)
			{
				baseTagComponent = curRoleData.GameplayTagComponent;
			}
			else
			{
				EntityHandle curRoleEntity = instance.CurRoleEntity;
				BaseTagComponent baseTagComponent2;
				if (curRoleEntity == null)
				{
					baseTagComponent2 = null;
				}
				else
				{
					WorldEntity entity = curRoleEntity.Entity;
					baseTagComponent2 = ((entity != null) ? entity.GetComponent<BaseTagComponent>() : null);
				}
				baseTagComponent = baseTagComponent2;
			}
			if (baseTagComponent != null)
			{
				foreach (int value in this._disableInputTagIds)
				{
					baseTagComponent.RemoveTag(new int?(value));
				}
			}
			else
			{
				Log.Instance.Error(ELogModule.PanelQte, ELogAuthor.CFT, "界面qte结束时，场上角色已经被销毁了", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			instance.CurRoleEntity = null;
			instance.DisableFightInput = false;
		}
		EventSystem.Instance.Emit<int, bool>(EEventName.PanelQteEnd, handleId, PanelQteModel.Instance.IsQteSuccess());
		if (!bForce)
		{
			PanelQteModel.Instance.HandleResult();
		}
		return true;
	}

	// Token: 0x06011ABD RID: 72381 RVA: 0x004578B7 File Offset: 0x00455AB7
	private bool CheckCanStartQte()
	{
		return !PanelQteModel.Instance.IsInQte.GetValueOrDefault() && GameModeModel.Instance.WorldDone && BattleUiModel.Instance.GetCurRoleData() != null;
	}

	// Token: 0x06011ABE RID: 72382 RVA: 0x004578EC File Offset: 0x00455AEC
	private int StartQte(PanelQteContext context)
	{
		SPanelQte panelQteConfig = PanelQteModel.Instance.GetPanelQteConfig(context.QteId);
		if (panelQteConfig == null)
		{
			return -1;
		}
		context.Config = panelQteConfig;
		PanelQteModel instance = PanelQteModel.Instance;
		int num = instance.StartQte(context);
		int num2 = (int)context.Config.ViewType;
		switch (num2)
		{
		case 0:
			if (UiManager.Instance.IsViewOpen(EUiViewName.FrozenQteView))
			{
				UiManager.Instance.CloseView(EUiViewName.FrozenQteView, null);
			}
			UiManager.Instance.OpenView(EUiViewName.FrozenQteView, num, null);
			break;
		case 1:
			if (UiManager.Instance.IsViewOpen(EUiViewName.InteractQteView))
			{
				UiManager.Instance.CloseView(EUiViewName.InteractQteView, null);
			}
			UiManager.Instance.OpenView(EUiViewName.InteractQteView, num, null);
			instance.DisableFightInput = true;
			break;
		case 2:
			context.BuffIndex = (int)Math.Floor(MathUtils.Instance.Random.NextDouble() * (double)panelQteConfig.MaxSuccessCount);
			if (UiManager.Instance.IsViewOpen(EUiViewName.YouHuQteView))
			{
				UiManager.Instance.CloseView(EUiViewName.YouHuQteView, null);
			}
			UiManager.Instance.OpenView(EUiViewName.YouHuQteView, num, null);
			break;
		case 3:
			if (UiManager.Instance.IsViewOpen(EUiViewName.FreeRunningQteView))
			{
				UiManager.Instance.CloseView(EUiViewName.FreeRunningQteView, null);
			}
			UiManager.Instance.OpenView(EUiViewName.FreeRunningQteView, num, null);
			instance.DisableFightInput = true;
			break;
		default:
		{
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.PanelQte;
			ELogAuthor author = ELogAuthor.CFT;
			string message = "QTE界面类型没有实现";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("", num2);
			instance2.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			break;
		}
		}
		if (panelQteConfig.HideAllBattleUi)
		{
			instance.IsHideAllBattleUi = true;
			BattleUiModel.Instance.ChildViewData.HideBattleView(EBattleUiVisibleReason.PanelQte, new <>z__ReadOnlySingleElementList<EBattleUiChild>(EBattleUiChild.PanelQTE), 0);
		}
		else
		{
			instance.IsHideAllBattleUi = false;
			int num3 = panelQteConfig.HideUIElement.Num();
			if (num3 > 0)
			{
				List<EBattleUiChild> list = new List<EBattleUiChild>();
				List<int> list2 = new List<int>();
				for (int i = 0; i < num3; i++)
				{
					int item = (int)panelQteConfig.HideUIElement.Get(i);
					list.Add((EBattleUiChild)item);
					list2.Add(item);
				}
				BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.PanelQte, list, false, true, 0);
				instance.HideBattleUiChildren = list2.ToArray();
			}
			else
			{
				instance.HideBattleUiChildren = null;
			}
		}
		if (instance.DisableFightInput)
		{
			BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
			if (curRoleData != null)
			{
				EntityHandle entityHandle = curRoleData.EntityHandle;
				BaseTagComponent gameplayTagComponent = curRoleData.GameplayTagComponent;
				if (gameplayTagComponent != null)
				{
					foreach (int value in this._disableInputTagIds)
					{
						gameplayTagComponent.AddTag(new int?(value));
					}
					instance.CurRoleEntity = entityHandle;
				}
			}
		}
		EventSystem.Instance.Emit<int>(EEventName.PanelQteStart, num);
		return num;
	}

	// Token: 0x06011ABF RID: 72383 RVA: 0x00457BCD File Offset: 0x00455DCD
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<bool, ETeamGroupType, ETeamLivingState, ETeamLivingState>(EEventName.OnTeamLivingStateChange, new Action<bool, ETeamGroupType, ETeamLivingState, ETeamLivingState>(this.OnTeamLivingStateChange));
	}

	// Token: 0x06011AC0 RID: 72384 RVA: 0x00457BEB File Offset: 0x00455DEB
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnTeamLivingStateChange, new Action<bool, ETeamGroupType, ETeamLivingState, ETeamLivingState>(this.OnTeamLivingStateChange));
	}

	// Token: 0x06011AC1 RID: 72385 RVA: 0x00457C0C File Offset: 0x00455E0C
	private void OnTeamLivingStateChange(bool isMyTeam, ETeamGroupType groupType, ETeamLivingState state, ETeamLivingState oldState)
	{
		if (isMyTeam && groupType == ETeamGroupType.Battle && state == ETeamLivingState.Dead)
		{
			PanelQteContext context = PanelQteModel.Instance.GetContext();
			if (context != null && context.QteHandleId != 0)
			{
				this.StopQte(context.QteHandleId, true);
			}
		}
	}

	// Token: 0x170016A9 RID: 5801
	// (get) Token: 0x06011AC2 RID: 72386 RVA: 0x00457C48 File Offset: 0x00455E48
	public static PanelQteController Instance
	{
		get
		{
			return PanelQteController._Instance;
		}
	}

	// Token: 0x06011AC3 RID: 72387 RVA: 0x00457C4F File Offset: 0x00455E4F
	public static PanelQteController GetOrCreateInstance()
	{
		if (PanelQteController._Instance == null)
		{
			PanelQteController.CreateInstance();
		}
		return PanelQteController._Instance;
	}

	// Token: 0x06011AC4 RID: 72388 RVA: 0x00457C63 File Offset: 0x00455E63
	public static bool CreateInstance()
	{
		if (PanelQteController._Instance != null)
		{
			return true;
		}
		PanelQteController._Instance = new PanelQteController();
		return true;
	}

	// Token: 0x06011AC5 RID: 72389 RVA: 0x00457C79 File Offset: 0x00455E79
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06011AC6 RID: 72390 RVA: 0x00457C7B File Offset: 0x00455E7B
	public static void ResetStaticDefaultValue()
	{
		PanelQteController._Instance = null;
	}

	// Token: 0x06011AC7 RID: 72391 RVA: 0x00457C83 File Offset: 0x00455E83
	static PanelQteController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PanelQteController.CreateStaticDefaultValue), new Action(PanelQteController.ResetStaticDefaultValue));
	}

	// Token: 0x04008605 RID: 34309
	private readonly int[] _disableInputTagIds = new int[]
	{
		GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止攻击"],
		GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止技能"],
		GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止大招"],
		GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止闪避"],
		GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止幻象1"],
		GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止跳跃"],
		GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止攀爬"],
		GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止幻象2"],
		GameplayTagDefine.EGameplayTagId["角色.Common.BUFF通用标识.不能切人"]
	};

	// Token: 0x04008606 RID: 34310
	[Nullable(2)]
	private static PanelQteController _Instance;
}
