using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Activity.ActivityContent.SpringManor;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200052B RID: 1323
public class GuessJokerSelectRoleItem : GridProxyAbstract<int>
{
	// Token: 0x0600407C RID: 16508 RVA: 0x00169790 File Offset: 0x00167990
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUISprite)),
			new ValueTuple<int, Type>(4, typeof(UUISprite))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle))
		};
	}

	// Token: 0x170008EB RID: 2283
	// (get) Token: 0x0600407D RID: 16509 RVA: 0x0016983C File Offset: 0x00167A3C
	public int Level
	{
		get
		{
			if (this.LevelId == 0)
			{
				Log.Instance.Error(ELogModule.GuessJokerCard, ELogAuthor.LRC, "GuessJokerSelectRoleItem获取LevelId为0", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return this.LevelId;
		}
	}

	// Token: 0x0600407E RID: 16510 RVA: 0x00169878 File Offset: 0x00167A78
	public override void Refresh(int levelId, bool isSelected, int gridIndex)
	{
		this.LevelId = levelId;
		int aiRole = GuessJokerConfig.Instance.GetJokerLevelById(levelId).Value.AiRole;
		base.SetRoleIcon(RoleConfig.Instance.GetRoleConfig(aiRole).Value.RoleHeadIconCircle, base.GetTexture(1), aiRole, null, null);
		SpringManorData activityData = SpringManorModel.Instance.ActivityData;
		if (activityData == null)
		{
			return;
		}
		if (activityData.GetGuessJokerGameData(levelId) == null)
		{
			return;
		}
		this.RefreshRedDot();
	}

	// Token: 0x0600407F RID: 16511 RVA: 0x00169900 File Offset: 0x00167B00
	public void RefreshRedDot()
	{
		SpringManorData activityData = SpringManorModel.Instance.ActivityData;
		if (activityData == null)
		{
			return;
		}
		IGuessJokerLevelInfo guessJokerGameData = activityData.GetGuessJokerGameData(this.LevelId);
		if (guessJokerGameData == null)
		{
			return;
		}
		bool unlock = guessJokerGameData.Unlock;
		bool firstPass = guessJokerGameData.FirstPass;
		bool rewardGet = guessJokerGameData.RewardGet;
		HashSet<int> hashSet = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.GuessJokerUnlockLevelClicked, null) ?? new HashSet<int>();
		bool uiactive = (unlock && !firstPass && !hashSet.Contains(this.LevelId)) || (firstPass && !rewardGet);
		base.GetItem(2).SetUIActive(uiactive);
		base.GetSprite(4).SetUIActive(firstPass && rewardGet);
		base.GetSprite(3).SetUIActive(!unlock);
	}

	// Token: 0x06004080 RID: 16512 RVA: 0x001699AC File Offset: 0x00167BAC
	[NullableContext(1)]
	public void BindClickCallBack(Action<GuessJokerSelectRoleItem> clickCallBack)
	{
		this.ClickCallBack = clickCallBack;
	}

	// Token: 0x06004081 RID: 16513 RVA: 0x001699B5 File Offset: 0x00167BB5
	private void OnClickToggle(EToggleState state)
	{
		Action<GuessJokerSelectRoleItem> clickCallBack = this.ClickCallBack;
		if (clickCallBack == null)
		{
			return;
		}
		clickCallBack(this);
	}

	// Token: 0x06004082 RID: 16514 RVA: 0x001699C8 File Offset: 0x00167BC8
	public override void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x06004083 RID: 16515 RVA: 0x001699DA File Offset: 0x00167BDA
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06004084 RID: 16516 RVA: 0x001699EC File Offset: 0x00167BEC
	[NullableContext(2)]
	public UUIItem GuideGetToggleItem()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return null;
		}
		return extendToggle.RootUIComp.Get();
	}

	// Token: 0x0400330B RID: 13067
	private int LevelId;

	// Token: 0x0400330C RID: 13068
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<GuessJokerSelectRoleItem> ClickCallBack;
}
