using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x02006677 RID: 26231
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class EncircleSelectLevelItemGrid : GridProxyAbstract<IEncircleSelectLevelData>
	{
		// Token: 0x06041BBC RID: 269244 RVA: 0x00FF19F4 File Offset: 0x00FEFBF4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIArtText)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUISprite))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClickedSelectButton))
			};
		}

		// Token: 0x06041BBD RID: 269245 RVA: 0x00FF1B3C File Offset: 0x00FEFD3C
		private void InitTickSystem()
		{
			this.TickId = TickSystem.Instance.Add(new Action<float>(this.RefreshTimeTick), "EncircleSelectLevelItemGrid", ETickingGroup.TG_PrePhysics, true, 0, true).Id;
			if (this.TickId != -1)
			{
				TickSystem.Instance.Pause(this.TickId);
			}
		}

		// Token: 0x06041BBE RID: 269246 RVA: 0x00FF1B8D File Offset: 0x00FEFD8D
		protected override void OnStart()
		{
			this.InitTickSystem();
			this.AddEventListener();
		}

		// Token: 0x06041BBF RID: 269247 RVA: 0x00FF1B9B File Offset: 0x00FEFD9B
		protected void AddEventListener()
		{
			EventSystem.Instance.Add<EncircleChallengePb>(EEventName.EncircleDataUpdate, new Action<EncircleChallengePb>(this.OnEncircleDataUpdate));
		}

		// Token: 0x06041BC0 RID: 269248 RVA: 0x00FF1BB9 File Offset: 0x00FEFDB9
		protected void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.EncircleDataUpdate, new Action<EncircleChallengePb>(this.OnEncircleDataUpdate));
		}

		// Token: 0x06041BC1 RID: 269249 RVA: 0x00FF1BD7 File Offset: 0x00FEFDD7
		protected override void OnBeforeShow()
		{
			if (this.TickId != -1)
			{
				TickSystem.Instance.Resume(this.TickId);
			}
		}

		// Token: 0x06041BC2 RID: 269250 RVA: 0x00FF1BF3 File Offset: 0x00FEFDF3
		public void RefreshView(IEncircleSelectLevelData data)
		{
			this.LevelData = data;
			this.EncircleConfigData = ActivityEncircleConfig.Instance.GetEncircleGroup(this.LevelData.GroupId);
			this.RefreshOpen();
			this.RefreshDesc();
			this.RefreshComplete();
			this.RefreshRedPoint();
		}

		// Token: 0x06041BC3 RID: 269251 RVA: 0x00FF1C30 File Offset: 0x00FEFE30
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

		// Token: 0x06041BC4 RID: 269252 RVA: 0x00FF1DC0 File Offset: 0x00FEFFC0
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

		// Token: 0x06041BC5 RID: 269253 RVA: 0x00FF1E0C File Offset: 0x00FF000C
		private void RefreshDesc()
		{
			UUIArtText artText = base.GetArtText(3);
			if (artText != null)
			{
				artText.SetText((this.Index + 1).ToString());
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), this.EncircleConfigData.Value.LevelTitle, Array.Empty<object>());
		}

		// Token: 0x06041BC6 RID: 269254 RVA: 0x00FF1E64 File Offset: 0x00FF0064
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

		// Token: 0x06041BC7 RID: 269255 RVA: 0x00FF1EEF File Offset: 0x00FF00EF
		public void SetIndex(int index)
		{
			this.Index = index;
		}

		// Token: 0x06041BC8 RID: 269256 RVA: 0x00FF1EF8 File Offset: 0x00FF00F8
		private void OnEncircleDataUpdate(EncircleChallengePb newData)
		{
			if (this.LevelData == null)
			{
				return;
			}
			this.RefreshView(this.LevelData);
		}

		// Token: 0x06041BC9 RID: 269257 RVA: 0x00FF1F10 File Offset: 0x00FF0110
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

		// Token: 0x06041BCA RID: 269258 RVA: 0x00FF1FE9 File Offset: 0x00FF01E9
		protected override void OnAfterHide()
		{
			if (this.TickId != -1)
			{
				TickSystem.Instance.Pause(this.TickId);
			}
		}

		// Token: 0x06041BCB RID: 269259 RVA: 0x00FF2005 File Offset: 0x00FF0205
		protected override void OnBeforeDestroy()
		{
			if (this.TickId != -1)
			{
				TickSystem.Instance.Remove(this.TickId);
				this.TickId = -1;
			}
			this.RemoveEventListener();
		}

		// Token: 0x06041BCC RID: 269260 RVA: 0x00FF202E File Offset: 0x00FF022E
		public void RefreshTimeTick(float deltaTime)
		{
			this.RefreshOpen();
		}

		// Token: 0x0402234F RID: 140111
		private const string NORMAL_COLOR = "FFFFFF";

		// Token: 0x04022350 RID: 140112
		private const string LOCK_COLOR = "C2D1DD";

		// Token: 0x04022351 RID: 140113
		[Nullable(2)]
		private IEncircleSelectLevelData LevelData;

		// Token: 0x04022352 RID: 140114
		private int Index;

		// Token: 0x04022353 RID: 140115
		private bool IsOpen;

		// Token: 0x04022354 RID: 140116
		private bool IsPrevComplete;

		// Token: 0x04022355 RID: 140117
		private int TickId = -1;

		// Token: 0x04022356 RID: 140118
		private EncircleChallengeGroup? EncircleConfigData;
	}
}
