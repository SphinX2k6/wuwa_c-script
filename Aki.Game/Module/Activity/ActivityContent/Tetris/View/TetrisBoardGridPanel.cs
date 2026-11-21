using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Game.Module.Activity.ActivityContent.Tetris.Activity;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris.View
{
	// Token: 0x02002FC1 RID: 12225
	[NullableContext(1)]
	[Nullable(0)]
	public class TetrisBoardGridPanel : UiPanelBase
	{
		// Token: 0x0601D04C RID: 118860 RVA: 0x008DC292 File Offset: 0x008DA492
		public TetrisBoardGridPanel(int row = 0, int column = 0)
		{
		}

		// Token: 0x0601D04E RID: 118862 RVA: 0x008DC324 File Offset: 0x008DA524
		protected unsafe override void OnRegisterComponent()
		{
			int num = 14;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0601D04F RID: 118863 RVA: 0x008DC520 File Offset: 0x008DA720
		protected override void OnStart()
		{
			this.ViewSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.ViewSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceEndEvent), false);
			AUIBaseActor rootActor = this.RootActor;
			if (rootActor == null)
			{
				return;
			}
			rootActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.OnSequencePlayEvent));
		}

		// Token: 0x0601D050 RID: 118864 RVA: 0x008DC578 File Offset: 0x008DA778
		private void OnSequenceEndEvent(string sequenceName)
		{
			Action action;
			if (this.SequenceCallbackMap.Remove(sequenceName, out action))
			{
				action();
			}
		}

		// Token: 0x0601D051 RID: 118865 RVA: 0x008DC59C File Offset: 0x008DA79C
		private void OnSequencePlayEvent(string sequenceName, string eventName)
		{
			Dictionary<string, Action> dictionary;
			Action action;
			if (this.SequencePlayEventCallbackMap.TryGetValue(sequenceName, out dictionary) && dictionary.Remove(eventName, out action))
			{
				action();
			}
		}

		// Token: 0x0601D052 RID: 118866 RVA: 0x008DC5CA File Offset: 0x008DA7CA
		public void Refresh(TetrisCellData data)
		{
			this.ColorId = data.ColorId;
			this.RefreshAttachment(data);
			this.RefreshBg(data);
			this.RefreshSeal(data);
		}

		// Token: 0x0601D053 RID: 118867 RVA: 0x008DC5F0 File Offset: 0x008DA7F0
		public void RefreshWithColorId(int colorId, EBombType bombType = EBombType.None)
		{
			if (colorId == -1)
			{
				return;
			}
			TetrisGem? gemConfig = ActivityTetrisConfig.Instance.GetGemConfig(colorId);
			if (gemConfig != null)
			{
				TetrisGem valueOrDefault = gemConfig.GetValueOrDefault();
				UUISprite sprite = base.GetSprite(0);
				if (sprite != null)
				{
					sprite.SetUIActive(true);
					this.SetSpriteByPath(valueOrDefault.BgPath, sprite, false, null, null);
					sprite.SetAlpha((bombType == EBombType.None) ? 1f : 0.3f);
				}
				UUISprite sprite2 = base.GetSprite(3);
				if (sprite2 != null)
				{
					sprite2.SetUIActive(true);
					sprite2.SetUIItemScale(FVector.OneVector);
					string path;
					if (bombType != EBombType.Bomb)
					{
						if (bombType != EBombType.SuperBomb)
						{
							path = valueOrDefault.IconPath;
						}
						else
						{
							path = valueOrDefault.SuperBombLargeIconPath;
						}
					}
					else
					{
						path = valueOrDefault.BombLargeIconPath;
					}
					this.SetSpriteByPath(path, sprite2, false, null, null);
				}
				UUISprite sprite3 = base.GetSprite(8);
				if (sprite3 != null)
				{
					sprite3.SetUIActive(false);
				}
				UUIItem item = base.GetItem(4);
				if (item != null)
				{
					item.SetUIActive(false);
				}
				UUIItem item2 = base.GetItem(5);
				if (item2 != null)
				{
					item2.SetUIActive(false);
				}
				UUIItem item3 = base.GetItem(6);
				if (item3 != null)
				{
					item3.SetUIActive(false);
				}
				UUISprite sprite4 = base.GetSprite(11);
				UUISprite sprite5 = base.GetSprite(12);
				UUISprite sprite6 = base.GetSprite(13);
				switch (bombType)
				{
				case EBombType.Bomb:
					sprite4.SetUIActive(true);
					this.SetSpriteByPath(valueOrDefault.BombBgPath, sprite4, false, null, null);
					sprite5.SetUIActive(true);
					sprite5.SetColor(FColor.FromHex(valueOrDefault.BombDecorationChargeColorValue));
					sprite6.SetUIActive(true);
					this.SetSpriteByPath(valueOrDefault.BombLargeIconPath, sprite6, false, null, null);
					return;
				case EBombType.SuperBomb:
					sprite4.SetUIActive(true);
					this.SetSpriteByPath(valueOrDefault.SuperBombBgPath, sprite4, false, null, null);
					sprite5.SetUIActive(true);
					sprite5.SetColor(FColor.FromHex(valueOrDefault.BombDecorationChargeColorValue));
					sprite6.SetUIActive(true);
					this.SetSpriteByPath(valueOrDefault.SuperBombLargeIconPath, sprite6, false, null, null);
					return;
				}
				sprite4.SetUIActive(false);
				sprite5.SetUIActive(false);
				sprite6.SetUIActive(false);
				return;
			}
		}

		// Token: 0x0601D054 RID: 118868 RVA: 0x008DC818 File Offset: 0x008DAA18
		private void RefreshSeal(TetrisCellData data)
		{
			TetrisGem? gemConfig = ActivityTetrisConfig.Instance.GetGemConfig(data.ColorId);
			if (data.SealState == ESealState.Layer1)
			{
				UUIItem item = base.GetItem(6);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				UUIItem item2 = base.GetItem(5);
				if (item2 != null)
				{
					item2.SetUIActive(false);
				}
				UUISprite sprite = base.GetSprite(3);
				if (sprite != null)
				{
					bool flag = data.BombType != EBombType.None || data.GemType > EGemType.None;
					sprite.SetUIActive(flag);
					if (flag)
					{
						sprite.SetUIItemScale(FVector.OneVector);
					}
				}
				base.SetTextureByPath(gemConfig.Value.OneSealPath, base.GetTexture(10), null, null);
				return;
			}
			if (data.SealState == ESealState.Layer2)
			{
				UUIItem item3 = base.GetItem(5);
				if (item3 != null)
				{
					item3.SetUIActive(true);
				}
				UUIItem item4 = base.GetItem(6);
				if (item4 != null)
				{
					item4.SetUIActive(false);
				}
				UUISprite sprite2 = base.GetSprite(3);
				if (sprite2 != null)
				{
					bool flag2 = data.BombType != EBombType.None || data.GemType > EGemType.None;
					sprite2.SetUIActive(flag2);
					if (flag2)
					{
						sprite2.SetUIItemScale(FVector.OneVector);
					}
				}
				base.SetTextureByPath(gemConfig.Value.TwoSealPath, base.GetTexture(9), null, null);
				return;
			}
			UUIItem item5 = base.GetItem(6);
			if (item5 != null)
			{
				item5.SetUIActive(false);
			}
			UUIItem item6 = base.GetItem(5);
			if (item6 == null)
			{
				return;
			}
			item6.SetUIActive(false);
		}

		// Token: 0x0601D055 RID: 118869 RVA: 0x008DC984 File Offset: 0x008DAB84
		private void RefreshAttachment(TetrisCellData data)
		{
			UUISprite sprite = base.GetSprite(3);
			if (sprite != null)
			{
				string largeIconPath = data.GetLargeIconPath();
				if (!string.IsNullOrWhiteSpace(largeIconPath))
				{
					sprite.SetUIActive(true);
					sprite.SetUIItemScale(FVector.OneVector);
					sprite.SetAlpha(1f);
					this.SetSpriteByPath(largeIconPath, sprite, false, null, null);
					UUISprite sprite2 = base.GetSprite(13);
					if (sprite2 != null)
					{
						sprite2.SetUIActive(false);
						if (data.BombType != EBombType.None)
						{
							sprite2.SetAlpha(1f);
							this.SetSpriteByPath(largeIconPath, sprite2, false, null, null);
						}
					}
				}
				else
				{
					sprite.SetUIActive(false);
				}
			}
			UUISprite sprite3 = base.GetSprite(11);
			if (sprite3 != null)
			{
				string bombBgPath = data.GetBombBgPath();
				if (!string.IsNullOrWhiteSpace(bombBgPath))
				{
					sprite3.SetUIActive(true);
					this.SetSpriteByPath(bombBgPath, sprite3, false, null, null);
				}
				else
				{
					sprite3.SetUIActive(false);
				}
			}
			UUISprite sprite4 = base.GetSprite(12);
			if (sprite4 != null)
			{
				string bombDecorationColor = data.GetBombDecorationColor(false);
				if (!string.IsNullOrWhiteSpace(bombDecorationColor))
				{
					sprite4.SetUIActive(true);
					sprite4.SetColor(FColor.FromHex(bombDecorationColor));
					return;
				}
				sprite4.SetUIActive(false);
			}
		}

		// Token: 0x0601D056 RID: 118870 RVA: 0x008DCAA4 File Offset: 0x008DACA4
		private void RefreshBg(TetrisCellData data)
		{
			UUISprite sprite = base.GetSprite(0);
			if (sprite != null)
			{
				string bgPath = data.GetBgPath();
				if (!string.IsNullOrWhiteSpace(bgPath))
				{
					sprite.SetUIActive(true);
					sprite.SetAlpha(1f);
					this.SetSpriteByPath(bgPath, sprite, false, null, null);
					return;
				}
				sprite.SetUIActive(false);
			}
		}

		// Token: 0x0601D057 RID: 118871 RVA: 0x008DCAF8 File Offset: 0x008DACF8
		public void ShowDragFrame(int colorId)
		{
			this.IsHighlightFrame = true;
			UUISprite sprite = base.GetSprite(0);
			if (sprite != null)
			{
				sprite.SetUIActive(false);
			}
			UUISprite sprite2 = base.GetSprite(8);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(false);
			}
			UUISprite sprite3 = base.GetSprite(3);
			if (sprite3 != null)
			{
				sprite3.SetUIActive(false);
			}
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUISprite sprite4 = base.GetSprite(11);
			if (sprite4 != null)
			{
				sprite4.SetUIActive(false);
			}
			UUISprite sprite5 = base.GetSprite(12);
			if (sprite5 != null)
			{
				sprite5.SetUIActive(false);
			}
			UUISprite sprite6 = base.GetSprite(13);
			if (sprite6 != null)
			{
				sprite6.SetUIActive(false);
			}
			UUISprite frameSprite = base.GetSprite(1);
			if (frameSprite != null)
			{
				TetrisGem? gemConfig = ActivityTetrisConfig.Instance.GetGemConfig(colorId);
				if (gemConfig != null)
				{
					TetrisGem valueOrDefault = gemConfig.GetValueOrDefault();
					frameSprite.SetUIActive(false);
					this.SetSpriteByPath(valueOrDefault.FramePath, frameSprite, false, null, delegate(bool success)
					{
						if (success && this.IsHighlightFrame && frameSprite.IsValid())
						{
							frameSprite.SetUIActive(true);
						}
					});
				}
			}
		}

		// Token: 0x0601D058 RID: 118872 RVA: 0x008DCC08 File Offset: 0x008DAE08
		public void HideDragFrame()
		{
			this.IsHighlightFrame = false;
			UUISprite sprite = base.GetSprite(1);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(false);
		}

		// Token: 0x0601D059 RID: 118873 RVA: 0x008DCC24 File Offset: 0x008DAE24
		public void SetMaskItemActive(bool active)
		{
			if (!active || this.ColorId == -1)
			{
				UUISprite sprite = base.GetSprite(8);
				if (sprite == null)
				{
					return;
				}
				sprite.SetUIActive(false);
				return;
			}
			else
			{
				this.SetSpriteByPath(ActivityTetrisConfig.Instance.GetGemConfig(this.ColorId).Value.BgPath, base.GetSprite(8), false, null, null);
				UUISprite sprite2 = base.GetSprite(8);
				if (sprite2 == null)
				{
					return;
				}
				sprite2.SetUIActive(true);
				return;
			}
		}

		// Token: 0x0601D05A RID: 118874 RVA: 0x008DCC9C File Offset: 0x008DAE9C
		public void HideGrid()
		{
			this.IsHighlightFrame = false;
			UUISprite sprite = base.GetSprite(0);
			if (sprite != null)
			{
				sprite.SetUIActive(false);
			}
			UUISprite sprite2 = base.GetSprite(8);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(false);
			}
			UUISprite sprite3 = base.GetSprite(3);
			if (sprite3 != null)
			{
				sprite3.SetUIActive(false);
			}
			UUISprite sprite4 = base.GetSprite(1);
			if (sprite4 != null)
			{
				sprite4.SetUIActive(false);
			}
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(6);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			UUIItem item3 = base.GetItem(5);
			if (item3 != null)
			{
				item3.SetUIActive(false);
			}
			UUISprite sprite5 = base.GetSprite(11);
			if (sprite5 != null)
			{
				sprite5.SetUIActive(false);
			}
			UUISprite sprite6 = base.GetSprite(12);
			if (sprite6 != null)
			{
				sprite6.SetUIActive(false);
			}
			UUISprite sprite7 = base.GetSprite(13);
			if (sprite7 != null)
			{
				sprite7.SetUIActive(false);
			}
			this.ColorId = -1;
		}

		// Token: 0x0601D05B RID: 118875 RVA: 0x008DCD78 File Offset: 0x008DAF78
		public void PlayAnim(string sequenceName, [Nullable(2)] Action onComplete = null)
		{
			if (onComplete != null)
			{
				this.SequenceCallbackMap[sequenceName] = onComplete;
			}
			string currentSequence = this.ViewSequencePlayer.GetCurrentSequence();
			if (currentSequence == sequenceName)
			{
				this.ViewSequencePlayer.ReplaySequenceByKey(sequenceName);
				return;
			}
			if (this.CanSequenceOverride(sequenceName, currentSequence))
			{
				this.ViewSequencePlayer.StopPlayingSequence(false, true);
				this.ViewSequencePlayer.PlayLevelSequenceByName(sequenceName, false, null, false);
			}
		}

		// Token: 0x0601D05C RID: 118876 RVA: 0x008DCDE8 File Offset: 0x008DAFE8
		public void PlayLevelSequenceByName(string sequenceName)
		{
			this.ViewSequencePlayer.PlayLevelSequenceByName(sequenceName, false, null, false);
		}

		// Token: 0x0601D05D RID: 118877 RVA: 0x008DCE0C File Offset: 0x008DB00C
		public void StopPlayingSequence(string sequenceName)
		{
			if (this.ViewSequencePlayer.GetCurrentSequence() == sequenceName)
			{
				this.ViewSequencePlayer.StopPlayingSequence(false, true);
			}
		}

		// Token: 0x0601D05E RID: 118878 RVA: 0x008DCE30 File Offset: 0x008DB030
		public void PlaySequenceWithEvent(string sequenceName, string eventName, [Nullable(2)] Action onEvent = null, [Nullable(2)] Action onComplete = null)
		{
			if (onEvent != null)
			{
				Dictionary<string, Action> dictionary;
				if (this.SequencePlayEventCallbackMap.TryGetValue(sequenceName, out dictionary))
				{
					dictionary[eventName] = onEvent;
				}
				else
				{
					this.SequencePlayEventCallbackMap[sequenceName] = new Dictionary<string, Action>
					{
						{
							eventName,
							onEvent
						}
					};
				}
			}
			this.PlayAnim(sequenceName, onComplete);
		}

		// Token: 0x0601D05F RID: 118879 RVA: 0x008DCE7C File Offset: 0x008DB07C
		private bool CanSequenceOverride(string sequenceName1, [Nullable(2)] string sequenceName2)
		{
			return sequenceName2 == null || this.GetSequencePriority(sequenceName1) <= this.GetSequencePriority(sequenceName2);
		}

		// Token: 0x0601D060 RID: 118880 RVA: 0x008DCE98 File Offset: 0x008DB098
		private int GetSequencePriority(string sequenceName)
		{
			for (int i = 0; i < TetrisBoardGridPanel.SequencePriorityList.Length; i++)
			{
				if (Array.IndexOf<string>(TetrisBoardGridPanel.SequencePriorityList[i], sequenceName) >= 0)
				{
					return i + 1;
				}
			}
			return 0;
		}

		// Token: 0x0601D061 RID: 118881 RVA: 0x008DCECC File Offset: 0x008DB0CC
		protected override void OnBeforeDestroy()
		{
			AUIBaseActor rootActor = this.RootActor;
			if (rootActor != null)
			{
				rootActor.OnSequencePlayEvent.Unbind();
			}
			this.ViewSequencePlayer.Clear();
			this.ViewSequencePlayer = null;
			this.SequenceCallbackMap.Clear();
			foreach (Dictionary<string, Action> dictionary in this.SequencePlayEventCallbackMap.Values)
			{
				dictionary.Clear();
			}
			this.SequencePlayEventCallbackMap.Clear();
		}

		// Token: 0x0400F47B RID: 62587
		public int Row = row;

		// Token: 0x0400F47C RID: 62588
		public int Column = column;

		// Token: 0x0400F47D RID: 62589
		public int ColorId = -1;

		// Token: 0x0400F47E RID: 62590
		private bool IsHighlightFrame;

		// Token: 0x0400F47F RID: 62591
		private LevelSequencePlayer ViewSequencePlayer;

		// Token: 0x0400F480 RID: 62592
		private readonly Dictionary<string, Action> SequenceCallbackMap = new Dictionary<string, Action>();

		// Token: 0x0400F481 RID: 62593
		private readonly Dictionary<string, Dictionary<string, Action>> SequencePlayEventCallbackMap = new Dictionary<string, Dictionary<string, Action>>();

		// Token: 0x0400F482 RID: 62594
		private static readonly string[][] SequencePriorityList = new string[][]
		{
			new string[]
			{
				"Bomb",
				"Bomb2"
			},
			new string[]
			{
				"Remove",
				"Remove2"
			},
			new string[]
			{
				"Up"
			}
		};

		// Token: 0x02008C3B RID: 35899
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x0402C62E RID: 181806
			public const int GridBg = 0;

			// Token: 0x0402C62F RID: 181807
			public const int GridFrame = 1;

			// Token: 0x0402C630 RID: 181808
			public const int GridMask = 2;

			// Token: 0x0402C631 RID: 181809
			public const int GridIcon = 3;

			// Token: 0x0402C632 RID: 181810
			public const int Highlight = 4;

			// Token: 0x0402C633 RID: 181811
			public const int BigSeal = 5;

			// Token: 0x0402C634 RID: 181812
			public const int SmallSeal = 6;

			// Token: 0x0402C635 RID: 181813
			public const int EffectItem = 7;

			// Token: 0x0402C636 RID: 181814
			public const int MaskSprite = 8;

			// Token: 0x0402C637 RID: 181815
			public const int BigSealTexture = 9;

			// Token: 0x0402C638 RID: 181816
			public const int SmallSealTexture = 10;

			// Token: 0x0402C639 RID: 181817
			public const int GridIconBg = 11;

			// Token: 0x0402C63A RID: 181818
			public const int GridDecoration = 12;

			// Token: 0x0402C63B RID: 181819
			public const int GridIconGlow = 13;
		}
	}
}
