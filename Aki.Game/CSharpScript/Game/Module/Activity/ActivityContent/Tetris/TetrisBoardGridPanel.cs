using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02005FF7 RID: 24567
	[NullableContext(1)]
	[Nullable(0)]
	public class TetrisBoardGridPanel : TetrisGridPanel
	{
		// Token: 0x0603E3E5 RID: 254949 RVA: 0x00F06AC1 File Offset: 0x00F04CC1
		public TetrisBoardGridPanel(int row, int column) : base(row, column)
		{
		}

		// Token: 0x0603E3E6 RID: 254950 RVA: 0x00F06AE0 File Offset: 0x00F04CE0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUISprite)),
				new ValueTuple<int, Type>(3, typeof(UUISprite)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUISprite)),
				new ValueTuple<int, Type>(9, typeof(UUITexture)),
				new ValueTuple<int, Type>(10, typeof(UUITexture))
			};
		}

		// Token: 0x0603E3E7 RID: 254951 RVA: 0x00F06BEC File Offset: 0x00F04DEC
		protected override void OnStart()
		{
			this.ViewSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.ViewSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceEndEvent), false);
		}

		// Token: 0x0603E3E8 RID: 254952 RVA: 0x00F06C18 File Offset: 0x00F04E18
		private void OnSequenceEndEvent(string sequenceName)
		{
			Action action;
			if (this.SequenceCallbackMap.TryGetValue(sequenceName, out action) && action != null)
			{
				action();
			}
		}

		// Token: 0x0603E3E9 RID: 254953 RVA: 0x00F06C3E File Offset: 0x00F04E3E
		public void Refresh(TetrisCellData data)
		{
			this.ColorId = data.ColorId;
			this.RefreshGem(data);
			this.RefreshBg(data);
			this.RefreshSeal(data);
		}

		// Token: 0x0603E3EA RID: 254954 RVA: 0x00F06C64 File Offset: 0x00F04E64
		public void RefreshWithColorId(int colorId)
		{
			if (colorId == -1)
			{
				return;
			}
			TetrisGem? gemConfig = ActivityTetrisConfig.Instance.GetGemConfig(colorId);
			if (gemConfig == null)
			{
				return;
			}
			UUISprite sprite = base.GetSprite(0);
			if (sprite != null)
			{
				sprite.SetUIActive(true);
			}
			this.SetSpriteByPath(gemConfig.Value.BgPath, base.GetSprite(0), false, null, null);
			UUISprite sprite2 = base.GetSprite(3);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(true);
			}
			this.SetSpriteByPath(gemConfig.Value.IconPath, base.GetSprite(3), false, null, null);
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
			if (item3 == null)
			{
				return;
			}
			item3.SetUIActive(false);
		}

		// Token: 0x0603E3EB RID: 254955 RVA: 0x00F06D4C File Offset: 0x00F04F4C
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
					sprite.SetUIActive(data.GemType > EGemType.None);
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
					sprite2.SetUIActive(data.GemType > EGemType.None);
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

		// Token: 0x0603E3EC RID: 254956 RVA: 0x00F06E74 File Offset: 0x00F05074
		private void RefreshGem(TetrisCellData data)
		{
			UUISprite sprite = base.GetSprite(3);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(true);
			sprite.SetAlpha(1f);
			TetrisGem? gemConfig = ActivityTetrisConfig.Instance.GetGemConfig(data.ColorId);
			this.SetSpriteByPath((data.GemType == EGemType.None) ? gemConfig.Value.IconPath : gemConfig.Value.GemPath, sprite, false, null, null);
		}

		// Token: 0x0603E3ED RID: 254957 RVA: 0x00F06EEC File Offset: 0x00F050EC
		private void RefreshBg(TetrisCellData data)
		{
			UUISprite sprite = base.GetSprite(0);
			if (sprite != null)
			{
				sprite.SetUIActive(true);
			}
			UUISprite sprite2 = base.GetSprite(0);
			if (sprite2 != null)
			{
				sprite2.SetAlpha(1f);
			}
			this.SetSpriteByPath(ActivityTetrisConfig.Instance.GetGemConfig(data.ColorId).Value.BgPath, base.GetSprite(0), false, null, null);
		}

		// Token: 0x0603E3EE RID: 254958 RVA: 0x00F06F5C File Offset: 0x00F0515C
		public void ShowDragFrame(int colorId)
		{
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
			UUISprite sprite4 = base.GetSprite(1);
			if (sprite4 != null)
			{
				TetrisGem? gemConfig = ActivityTetrisConfig.Instance.GetGemConfig(colorId);
				if (gemConfig != null)
				{
					this.SetSpriteByPath(gemConfig.Value.FramePath, sprite4, false, null, null);
				}
				sprite4.SetUIActive(true);
			}
		}

		// Token: 0x0603E3EF RID: 254959 RVA: 0x00F07000 File Offset: 0x00F05200
		public void HideDragFrame()
		{
			UUISprite sprite = base.GetSprite(1);
			if (sprite != null)
			{
				sprite.SetUIActive(false);
			}
		}

		// Token: 0x0603E3F0 RID: 254960 RVA: 0x00F07020 File Offset: 0x00F05220
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

		// Token: 0x0603E3F1 RID: 254961 RVA: 0x00F07098 File Offset: 0x00F05298
		public void HideGrid()
		{
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
			this.ColorId = -1;
		}

		// Token: 0x0603E3F2 RID: 254962 RVA: 0x00F0710C File Offset: 0x00F0530C
		public void PlayAnim(string sequenceName, [Nullable(2)] Action onComplete = null)
		{
			if (this.ViewSequencePlayer.GetCurrentSequence() == sequenceName)
			{
				this.ViewSequencePlayer.ReplaySequenceByKey(sequenceName);
			}
			else
			{
				this.ViewSequencePlayer.StopPlayingSequence(false, true);
				this.ViewSequencePlayer.PlayLevelSequenceByName(sequenceName, false, null, false);
			}
			if (onComplete != null)
			{
				if (this.SequenceCallbackMap.ContainsKey(sequenceName))
				{
					this.SequenceCallbackMap[sequenceName] = onComplete;
					return;
				}
				this.SequenceCallbackMap.Add(sequenceName, onComplete);
			}
		}

		// Token: 0x0603E3F3 RID: 254963 RVA: 0x00F0718C File Offset: 0x00F0538C
		public void PlayLevelSequenceByName(string sequenceName)
		{
			this.ViewSequencePlayer.PlayLevelSequenceByName(sequenceName, false, null, false);
		}

		// Token: 0x0603E3F4 RID: 254964 RVA: 0x00F071B0 File Offset: 0x00F053B0
		public void StopPlayingSequence(string sequenceName)
		{
			if (this.ViewSequencePlayer.GetCurrentSequence() == sequenceName)
			{
				this.ViewSequencePlayer.StopPlayingSequence(false, true);
			}
		}

		// Token: 0x0603E3F5 RID: 254965 RVA: 0x00F071D2 File Offset: 0x00F053D2
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer viewSequencePlayer = this.ViewSequencePlayer;
			if (viewSequencePlayer != null)
			{
				viewSequencePlayer.Clear();
			}
			this.ViewSequencePlayer = null;
			this.SequenceCallbackMap.Clear();
		}

		// Token: 0x04020828 RID: 133160
		[Nullable(2)]
		private LevelSequencePlayer ViewSequencePlayer;

		// Token: 0x04020829 RID: 133161
		public int ColorId = -1;

		// Token: 0x0402082A RID: 133162
		private readonly Dictionary<string, Action> SequenceCallbackMap = new Dictionary<string, Action>();
	}
}
