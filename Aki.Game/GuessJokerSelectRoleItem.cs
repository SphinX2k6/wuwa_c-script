using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Activity.ActivityContent.SpringManor;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001077 RID: 4215
public class GuessJokerSelectRoleItem : GridProxyAbstract<int>
{
	// Token: 0x06006CE7 RID: 27879 RVA: 0x00160E5C File Offset: 0x0015F05C
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

	// Token: 0x170008CB RID: 2251
	// (get) Token: 0x06006CE8 RID: 27880 RVA: 0x00160F08 File Offset: 0x0015F108
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

	// Token: 0x06006CE9 RID: 27881 RVA: 0x00160F44 File Offset: 0x0015F144
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

	// Token: 0x06006CEA RID: 27882 RVA: 0x00160FCC File Offset: 0x0015F1CC
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

	// Token: 0x06006CEB RID: 27883 RVA: 0x00161078 File Offset: 0x0015F278
	[NullableContext(1)]
	public void BindClickCallBack(Action<GuessJokerSelectRoleItem> clickCallBack)
	{
		this.ClickCallBack = clickCallBack;
	}

	// Token: 0x06006CEC RID: 27884 RVA: 0x00161081 File Offset: 0x0015F281
	private void OnClickToggle(EToggleState state)
	{
		Action<GuessJokerSelectRoleItem> clickCallBack = this.ClickCallBack;
		if (clickCallBack == null)
		{
			return;
		}
		clickCallBack(this);
	}

	// Token: 0x06006CED RID: 27885 RVA: 0x00161094 File Offset: 0x0015F294
	public override void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x06006CEE RID: 27886 RVA: 0x001610A6 File Offset: 0x0015F2A6
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06006CEF RID: 27887 RVA: 0x001610B8 File Offset: 0x0015F2B8
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

	// Token: 0x04003272 RID: 12914
	private int LevelId;

	// Token: 0x04003273 RID: 12915
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<GuessJokerSelectRoleItem> ClickCallBack;
}
