using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace Aki.Game.Module.Activity.ActivityContent.Encircle.View
{
	// Token: 0x02003027 RID: 12327
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class EncircleSelectLevelItemGrid : GridProxyAbstract<IEncircleSelectLevelData>
	{
		// Token: 0x0601D3E4 RID: 119780 RVA: 0x008EDB0C File Offset: 0x008EBD0C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 12;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickedSelectButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0601D3E5 RID: 119781 RVA: 0x008EDD00 File Offset: 0x008EBF00
		private void InitTickSystem()
		{
			this.TickId = TickSystem.Instance.Add(new Action<float>(this.RefreshTimeTick), "EncircleSelectLevelItemGrid", ETickingGroup.TG_PrePhysics, true, 0, true).Id;
			if (this.TickId != -1)
			{
				TickSystem.Instance.Pause(this.TickId);
			}
		}

		// Token: 0x0601D3E6 RID: 119782 RVA: 0x008EDD51 File Offset: 0x008EBF51
		protected override void OnStart()
		{
			this.InitTickSystem();
			this.AddEventListener();
		}

		// Token: 0x0601D3E7 RID: 119783 RVA: 0x008EDD5F File Offset: 0x008EBF5F
		protected void AddEventListener()
		{
			EventSystem.Instance.Add<EncircleChallengePb>(EEventName.EncircleDataUpdate, new Action<EncircleChallengePb>(this.OnEncircleDataUpdate));
		}

		// Token: 0x0601D3E8 RID: 119784 RVA: 0x008EDD7D File Offset: 0x008EBF7D
		protected void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.EncircleDataUpdate, new Action<EncircleChallengePb>(this.OnEncircleDataUpdate));
		}

		// Token: 0x0601D3E9 RID: 119785 RVA: 0x008EDD9B File Offset: 0x008EBF9B
		protected override void OnBeforeShow()
		{
			if (this.TickId != -1)
			{
				TickSystem.Instance.Resume(this.TickId);
			}
		}

		// Token: 0x0601D3EA RID: 119786 RVA: 0x008EDDB7 File Offset: 0x008EBFB7
		public void RefreshView(IEncircleSelectLevelData data)
		{
			this.LevelData = data;
			this.EncircleConfigData = ActivityEncircleConfig.Instance.GetEncircleGroup(this.LevelData.GroupId);
			this.RefreshOpen();
			this.RefreshDesc();
			this.RefreshComplete();
			this.RefreshRedPoint();
		}

		// Token: 0x0601D3EB RID: 119787 RVA: 0x008EDDF4 File Offset: 0x008EBFF4
		private void RefreshOpen()
		{
			ActivityEncircleData encircleData = ActivityEncircleController.Instance.GetEncircleData();
			if (encircleData == null)
			{
				return;
			}
			this.IsOpen = encircleData.CheckChallengeIsOpen(this.EncircleConfigData.Value.Challenges(0));
			this.IsPrevComplete = encircleData.CheckPreChallengeComplete(this.EncircleConfigData.Value.Challenges(0));
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(this.IsOpen && this.IsPrevComplete);
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 != null)
			{
				item2.SetUIActive(!this.IsOpen || !this.IsPrevComplete);
			}
			UUIItem item3 = base.GetItem(5);
			if (item3 != null)
			{
				item3.SetUIActive(!this.IsOpen);
			}
			UUISprite sprite = base.GetSprite(11);
			if (sprite != null)
			{
				sprite.SetUIActive(this.IsOpen);
			}
			if (!this.IsOpen)
			{
				UUIText text = base.GetText(6);
				if (text != null)
				{
					text.SetText(encircleData.GetUnlockDesc(this.EncircleConfigData.Value.Challenges(0)), true);
				}
			}
			if (!this.IsOpen || !this.IsPrevComplete)
			{
				UUIText text2 = base.GetText(4);
				if (text2 != null)
				{
					text2.SetColor(FColor.FromHex("C2D1DD"));
				}
				UUISprite sprite2 = base.GetSprite(11);
				if (sprite2 == null)
				{
					return;
				}
				sprite2.SetColor(FColor.FromHex("C2D1DD"));
				return;
			}
			else
			{
				UUIText text3 = base.GetText(4);
				if (text3 != null)
				{
					text3.SetColor(FColor.FromHex("FFFFFF"));
				}
				UUISprite sprite3 = base.GetSprite(11);
				if (sprite3 == null)
				{
					return;
				}
				sprite3.SetColor(FColor.FromHex("FFFFFF"));
				return;
			}
		}

		// Token: 0x0601D3EC RID: 119788 RVA: 0x008EDF84 File Offset: 0x008EC184
		private void RefreshRedPoint()
		{
			ActivityEncircleData encircleData = ActivityEncircleController.Instance.GetEncircleData();
			if (encircleData == null)
			{
				return;
			}
			bool uiactive = encircleData.CheckGroupRedPointShow(this.EncircleConfigData.Value.Id);
			UUIItem item = base.GetItem(10);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(uiactive);
		}

		// Token: 0x0601D3ED RID: 119789 RVA: 0x008EDFD0 File Offset: 0x008EC1D0
		private void RefreshDesc()
		{
			UUIArtText artText = base.GetArtText(3);
			if (artText != null)
			{
				artText.SetText((this.Index + 1).ToString());
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), this.EncircleConfigData.Value.LevelTitle, Array.Empty<object>());
		}

		// Token: 0x0601D3EE RID: 119790 RVA: 0x008EE028 File Offset: 0x008EC228
		private void RefreshComplete()
		{
			ActivityEncircleData encircleData = ActivityEncircleController.Instance.GetEncircleData();
			if (encircleData == null)
			{
				return;
			}
			bool uiactive = encircleData.CheckChallengeComplete(this.EncircleConfigData.Value.Challenges(0));
			UUIItem item = base.GetItem(7);
			if (item != null)
			{
				item.SetUIActive(uiactive);
			}
			bool uiactive2 = encircleData.CheckChallengeComplete(this.EncircleConfigData.Value.Challenges(1));
			UUIItem item2 = base.GetItem(8);
			if (item2 != null)
			{
				item2.SetUIActive(uiactive2);
			}
			UUIItem item3 = base.GetItem(9);
			if (item3 == null)
			{
				return;
			}
			item3.SetUIActive(uiactive2);
		}

		// Token: 0x0601D3EF RID: 119791 RVA: 0x008EE0B3 File Offset: 0x008EC2B3
		public void SetIndex(int index)
		{
			this.Index = index;
		}

		// Token: 0x0601D3F0 RID: 119792 RVA: 0x008EE0BC File Offset: 0x008EC2BC
		private void OnEncircleDataUpdate(EncircleChallengePb newData)
		{
			if (this.LevelData == null)
			{
				return;
			}
			this.RefreshView(this.LevelData);
		}

		// Token: 0x0601D3F1 RID: 119793 RVA: 0x008EE0D4 File Offset: 0x008EC2D4
		private void OnClickedSelectButton()
		{
			if (!this.IsOpen)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Encirle_LevelLockTips_Text", Array.Empty<object>());
				return;
			}
			if (this.IsPrevComplete)
			{
				DetailArgs param = new DetailArgs
				{
					GroupId = this.LevelData.GroupId
				};
				UiManager.Instance.OpenView(EUiViewName.EncircleLevelDetailView, param, null);
				return;
			}
			EncircleChallenge? encircleChallengeConfig = ActivityEncircleConfig.Instance.GetEncircleChallengeConfig(this.EncircleConfigData.Value.Challenges(0));
			EncircleChallenge? encircleChallengeConfig2 = ActivityEncircleConfig.Instance.GetEncircleChallengeConfig(encircleChallengeConfig.Value.PreId);
			if (encircleChallengeConfig2 == null)
			{
				return;
			}
			string levelTitle = encircleChallengeConfig2.Value.LevelTitle;
			string multiTextByKey = TextConfig.Instance.GetMultiTextByKey(levelTitle, levelTitle);
			ScrollingTipsController.Instance.ShowTipsByTextId("Encirle_DifficultyLockTips_Text", new object[]
			{
				multiTextByKey
			});
		}

		// Token: 0x0601D3F2 RID: 119794 RVA: 0x008EE1AD File Offset: 0x008EC3AD
		protected override void OnAfterHide()
		{
			if (this.TickId != -1)
			{
				TickSystem.Instance.Pause(this.TickId);
			}
		}

		// Token: 0x0601D3F3 RID: 119795 RVA: 0x008EE1C9 File Offset: 0x008EC3C9
		protected override void OnBeforeDestroy()
		{
			if (this.TickId != -1)
			{
				TickSystem.Instance.Remove(this.TickId);
				this.TickId = -1;
			}
			this.RemoveEventListener();
		}

		// Token: 0x0601D3F4 RID: 119796 RVA: 0x008EE1F2 File Offset: 0x008EC3F2
		public void RefreshTimeTick(float deltaTime)
		{
			this.RefreshOpen();
		}

		// Token: 0x0400F659 RID: 63065
		private const string NORMAL_COLOR = "FFFFFF";

		// Token: 0x0400F65A RID: 63066
		private const string LOCK_COLOR = "C2D1DD";

		// Token: 0x0400F65B RID: 63067
		[Nullable(2)]
		private IEncircleSelectLevelData LevelData;

		// Token: 0x0400F65C RID: 63068
		private int Index;

		// Token: 0x0400F65D RID: 63069
		private bool IsOpen;

		// Token: 0x0400F65E RID: 63070
		private bool IsPrevComplete;

		// Token: 0x0400F65F RID: 63071
		private int TickId = -1;

		// Token: 0x0400F660 RID: 63072
		private EncircleChallengeGroup? EncircleConfigData;
	}
}
