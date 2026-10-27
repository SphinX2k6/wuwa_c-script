using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x02006414 RID: 25620
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MotorFightLevelItem : GridProxyAbstract<MotorFightLevelData>
	{
		// Token: 0x060406F8 RID: 263928 RVA: 0x00F96840 File Offset: 0x00F94A40
		protected unsafe override void OnRegisterComponent()
		{
			int num = 19;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnButtonClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060406F9 RID: 263929 RVA: 0x00F96B22 File Offset: 0x00F94D22
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x060406FA RID: 263930 RVA: 0x00F96B38 File Offset: 0x00F94D38
		[NullableContext(1)]
		public override void Refresh(MotorFightLevelData data, bool isSelected, int gridIndex)
		{
			this.LevelData = data;
			EMotorFightLevelType id = data.IsUnLock ? data.Type : EMotorFightLevelType.Lock;
			MotorFightLevelType? motorFightLevelType = MotorFightConfig.Instance.GetMotorFightLevelType((int)id);
			base.SetTextureByPath(motorFightLevelType.Value.Hold, base.GetTexture(1), null, null);
			base.SetTextureByPath(motorFightLevelType.Value.Mask, base.GetTexture(2), null, null);
			base.SetTextureByPath(motorFightLevelType.Value.Light, base.GetTexture(3), null, null);
			base.SetTextureByPath(motorFightLevelType.Value.Bg, base.GetTexture(4), null, null);
			base.SetTextureByPath(motorFightLevelType.Value.Title, base.GetTexture(6), null, null);
			string path = data.IsUnLock ? data.LevelTexture : "/Game/Aki/UI/UIResources/UiActivity/Image/Activity31/MotorcycleBattle/Level/T_MotorcycleLevelLock.T_MotorcycleLevelLock";
			base.SetTextureByPath(path, base.GetTexture(5), null, null);
			bool flag = data.Type == EMotorFightLevelType.Endless;
			UUIArtText artText = base.GetArtText(7);
			if (artText != null)
			{
				artText.SetUIActive(!flag);
			}
			UUIArtText artText2 = base.GetArtText(7);
			if (artText2 != null)
			{
				artText2.SetText(data.Number);
			}
			UUISprite sprite = base.GetSprite(8);
			if (sprite != null)
			{
				sprite.SetUIActive(flag);
			}
			UUIItem item = base.GetItem(9);
			if (item != null)
			{
				item.SetUIActive(!data.IsUnLock);
			}
			UUIItem item2 = base.GetItem(10);
			if (item2 != null)
			{
				item2.SetUIActive(data.HasLevelRedDot);
			}
			UUIItem item3 = base.GetItem(11);
			if (item3 != null)
			{
				item3.SetUIActive(!flag && data.IsFinished);
			}
			UUITexture texture = base.GetTexture(12);
			if (texture != null)
			{
				texture.SetUIActive(false);
			}
			UUITexture texture2 = base.GetTexture(14);
			if (texture2 != null)
			{
				texture2.SetUIActive(false);
			}
			UUITexture texture3 = base.GetTexture(13);
			if (texture3 != null)
			{
				texture3.SetUIActive(false);
			}
			UUIItem item4 = base.GetItem(16);
			if (item4 != null)
			{
				item4.SetUIActive(flag && data.IsUnLock);
			}
			this.PlaySequence();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(17), "MotorFightGame_LevelBestScore", new <>z__ReadOnlySingleElementList<object>(data.BestScore));
			this.RefreshUnlockText();
			if (data.PreMotorFightLevelData != null)
			{
				int offset = data.Row - data.PreMotorFightLevelData.Row;
				int index = this.GetIndex(offset);
				UUITexture texture4 = base.GetTexture(index);
				if (texture4 != null)
				{
					texture4.SetUIActive(true);
				}
			}
			if (this.LevelData != null && !this.LevelData.IsUnLock)
			{
				this.AddTimer();
				return;
			}
			this.RemoveTimer();
		}

		// Token: 0x060406FB RID: 263931 RVA: 0x00F96DEC File Offset: 0x00F94FEC
		private void RefreshUnlockText()
		{
			if (!this.LevelData.IsUnLock)
			{
				if (!this.LevelData.IsReachUnlockTime())
				{
					string localTextNew = ConfigMultiTextLang.GetLocalTextNew("MotorFightGame_LevelCondition_02", null);
					string remainTimeText = ActivityModel.Instance.GetRemainTimeText(this.LevelData.UnlockTime, localTextNew);
					UUIText text = base.GetText(15);
					if (text == null)
					{
						return;
					}
					text.SetText(remainTimeText, true);
					return;
				}
				else
				{
					LguiUtil.Instance.SetLocalTextNew(base.GetText(15), "MotorFightGame_LevelCondition_01", Array.Empty<object>());
				}
			}
		}

		// Token: 0x060406FC RID: 263932 RVA: 0x00F96E67 File Offset: 0x00F95067
		private int GetIndex(int offset)
		{
			if (offset == 0)
			{
				return 12;
			}
			if (offset == -1)
			{
				return 13;
			}
			return 14;
		}

		// Token: 0x060406FD RID: 263933 RVA: 0x00F96E78 File Offset: 0x00F95078
		private void PlaySequence()
		{
			if (this.LevelData.HasLevelRedDot || this.LevelData.IsFinished)
			{
				string sequenceName = this.LevelData.HasLevelRedDot ? "NewLevel" : "Complete";
				LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
				if (levelSequencePlayer == null)
				{
					return;
				}
				levelSequencePlayer.PlayLevelSequenceByName(sequenceName, false, null, false);
			}
		}

		// Token: 0x060406FE RID: 263934 RVA: 0x00F96ED5 File Offset: 0x00F950D5
		private void UpdateUnlock()
		{
			if (this.LevelData != null && this.LevelData.IsUnLock)
			{
				this.Refresh(this.LevelData, false, 0);
			}
		}

		// Token: 0x060406FF RID: 263935 RVA: 0x00F96EFA File Offset: 0x00F950FA
		private void AddTimer()
		{
			this.RemoveTimer();
			this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
			{
				this.RefreshUnlockText();
				this.UpdateUnlock();
			}, (float)TimeUtil.Instance.InverseMillisecond, 1f, null, null, true);
		}

		// Token: 0x06040700 RID: 263936 RVA: 0x00F96F31 File Offset: 0x00F95131
		private void RemoveTimer()
		{
			if (this.TimerHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
		}

		// Token: 0x06040701 RID: 263937 RVA: 0x00F96F53 File Offset: 0x00F95153
		protected override void OnBeforeDestroy()
		{
			if (this.LevelSequencePlayer != null)
			{
				this.LevelSequencePlayer.Clear();
				this.LevelSequencePlayer = null;
			}
		}

		// Token: 0x06040702 RID: 263938 RVA: 0x00F96F70 File Offset: 0x00F95170
		private void OnButtonClick()
		{
			if (!this.LevelData.IsUnLock)
			{
				if (!this.LevelData.IsReachUnlockTime())
				{
					string localTextNew = ConfigMultiTextLang.GetLocalTextNew("MotorFightGame_LevelCondition_02", null);
					string remainTimeText = ActivityModel.Instance.GetRemainTimeText(this.LevelData.UnlockTime, localTextNew);
					ScrollingTipsController.Instance.ShowTipsByText(remainTimeText);
					return;
				}
				ScrollingTipsController.Instance.ShowTipsByTextId("MotorFightGame_LevelCondition_01", Array.Empty<object>());
				return;
			}
			else
			{
				MotorFightActivityData motorFightActivityData = MotorFightController.Instance.GetMotorFightActivityData();
				if (motorFightActivityData.HasLastSavedLevelData())
				{
					UiManager.Instance.OpenView(EUiViewName.MotorFightArchiveTip, this.LevelData.Id, null);
					return;
				}
				MotorFightLevelDetailViewModel param = new MotorFightLevelDetailViewModel(motorFightActivityData, this.LevelData);
				UiManager.Instance.OpenView(EUiViewName.MotorFightLevelDetailView, param, null);
				if (this.LevelData.HasLevelRedDot)
				{
					this.LevelData.ReadLevelRedDot();
					EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.LevelData.ActivityId);
				}
				UUIItem item = base.GetItem(10);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(false);
				return;
			}
		}

		// Token: 0x06040703 RID: 263939 RVA: 0x00F97073 File Offset: 0x00F95273
		public UUIItem GetNavigationItem()
		{
			return base.GetItem(18);
		}

		// Token: 0x0402180B RID: 137227
		[Nullable(1)]
		public const string MOTOR_FIGHT_LOCK_LEVEL_TEXTURE_PATH = "/Game/Aki/UI/UIResources/UiActivity/Image/Activity31/MotorcycleBattle/Level/T_MotorcycleLevelLock.T_MotorcycleLevelLock";

		// Token: 0x0402180C RID: 137228
		private MotorFightLevelData LevelData;

		// Token: 0x0402180D RID: 137229
		private TimerHandle TimerHandle;

		// Token: 0x0402180E RID: 137230
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200C638 RID: 50744
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403BD76 RID: 245110
			public const int BtnRoot = 0;

			// Token: 0x0403BD77 RID: 245111
			public const int TextureHold = 1;

			// Token: 0x0403BD78 RID: 245112
			public const int TextureMask = 2;

			// Token: 0x0403BD79 RID: 245113
			public const int TextureLight = 3;

			// Token: 0x0403BD7A RID: 245114
			public const int TextureBg = 4;

			// Token: 0x0403BD7B RID: 245115
			public const int TextureLevel = 5;

			// Token: 0x0403BD7C RID: 245116
			public const int TextureTitle = 6;

			// Token: 0x0403BD7D RID: 245117
			public const int ArtText = 7;

			// Token: 0x0403BD7E RID: 245118
			public const int SpriteEndLess = 8;

			// Token: 0x0403BD7F RID: 245119
			public const int ItemLockPanel = 9;

			// Token: 0x0403BD80 RID: 245120
			public const int ItemNewPanel = 10;

			// Token: 0x0403BD81 RID: 245121
			public const int ItemFinishPanel = 11;

			// Token: 0x0403BD82 RID: 245122
			public const int TextureLineCenter = 12;

			// Token: 0x0403BD83 RID: 245123
			public const int TextureLineDown = 13;

			// Token: 0x0403BD84 RID: 245124
			public const int TextureLineUp = 14;

			// Token: 0x0403BD85 RID: 245125
			public const int TextUnlock = 15;

			// Token: 0x0403BD86 RID: 245126
			public const int ItemBestScorePanel = 16;

			// Token: 0x0403BD87 RID: 245127
			public const int TextBestScore = 17;

			// Token: 0x0403BD88 RID: 245128
			public const int ItemNavigation = 18;
		}
	}
}
