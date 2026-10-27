using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006135 RID: 24885
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoverlikeBlessingSlotItem : GridProxyAbstract<IRoverlikeBlessingSlotItemData>
	{
		// Token: 0x0603EE9A RID: 257690 RVA: 0x00F322A8 File Offset: 0x00F304A8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603EE9B RID: 257691 RVA: 0x00F32353 File Offset: 0x00F30553
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}

		// Token: 0x0603EE9C RID: 257692 RVA: 0x00F32368 File Offset: 0x00F30568
		public void PlaySelectAnim()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayOrReplaySequenceByName("Select", false, null);
		}

		// Token: 0x0603EE9D RID: 257693 RVA: 0x00F32394 File Offset: 0x00F30594
		public override void Refresh(IRoverlikeBlessingSlotItemData data, bool isSelected, int gridIndex)
		{
			UUITexture texture = base.GetTexture(1);
			UUISprite sprite = base.GetSprite(3);
			UUISprite sprite2 = base.GetSprite(0);
			if (data.Id <= 0)
			{
				sprite2.SetUIActive(false);
				string slotEmptyIconPath = this.GetSlotEmptyIconPath(data.SlotId);
				if (string.IsNullOrEmpty(slotEmptyIconPath))
				{
					texture.SetUIActive(false);
					sprite.SetUIActive(false);
					return;
				}
				this.SetIconByPath(slotEmptyIconPath, texture, sprite);
				return;
			}
			else
			{
				RoverRogueBless? blessConfig = RoverlikeConfig.Instance.GetBlessConfig(data.Id);
				if (blessConfig == null)
				{
					return;
				}
				RoverRogueBlessRole? blessRoleConfig = RoverlikeConfig.Instance.GetBlessRoleConfig(blessConfig.Value.BlessRoleId);
				if (blessRoleConfig != null)
				{
					this.SetIconByPath(blessRoleConfig.Value.IconPath, texture, sprite);
				}
				RoverRogueQuality? qualityConfig = RoverlikeConfig.Instance.GetQualityConfig(blessConfig.Value.Quality);
				if (qualityConfig != null)
				{
					this.SetSpriteByPath(qualityConfig.Value.BlessSlotQuality, sprite2, false, null, null);
					sprite2.SetUIActive(true);
				}
				return;
			}
		}

		// Token: 0x0603EE9E RID: 257694 RVA: 0x00F324A4 File Offset: 0x00F306A4
		[NullableContext(2)]
		private string GetSlotEmptyIconPath(int slotId)
		{
			RoverlikeActivityController instance = RoverlikeActivityController.Instance;
			RoverRogueActivity? roverRogueActivity;
			if (instance == null)
			{
				roverRogueActivity = null;
			}
			else
			{
				RoverlikeActivityData currentActivityData = instance.GetCurrentActivityData();
				roverRogueActivity = ((currentActivityData != null) ? currentActivityData.GetParamConfig() : null);
			}
			RoverRogueActivity? roverRogueActivity2 = roverRogueActivity;
			if (roverRogueActivity2 == null)
			{
				return null;
			}
			RoverRogueActivity value = roverRogueActivity2.Value;
			for (int i = 0; i < value.SlotEmptyIconLength; i++)
			{
				DicIntString? dicIntString = value.SlotEmptyIcon(i);
				if (dicIntString != null && dicIntString.GetValueOrDefault().Key == slotId)
				{
					return dicIntString.Value.Value;
				}
			}
			return null;
		}

		// Token: 0x0603EE9F RID: 257695 RVA: 0x00F32544 File Offset: 0x00F30744
		private void SetIconByPath(string iconPath, UUITexture iconTexture, UUISprite iconSprite)
		{
			bool flag = iconPath.Contains("Atlas");
			iconTexture.SetUIActive(!flag);
			iconSprite.SetUIActive(flag);
			if (flag)
			{
				this.SetSpriteByPath(iconPath, iconSprite, false, null, null);
				return;
			}
			base.SetTextureShowUntilLoaded(iconPath, iconTexture, null);
		}

		// Token: 0x0603EEA0 RID: 257696 RVA: 0x00F3258E File Offset: 0x00F3078E
		public void SetSelectOn(bool bSelectOn)
		{
			base.GetItem(2).SetUIActive(bSelectOn);
		}

		// Token: 0x0603EEA1 RID: 257697 RVA: 0x00F3259D File Offset: 0x00F3079D
		public override object GetKey(IRoverlikeBlessingSlotItemData data, int displayIndex)
		{
			return data.SlotId;
		}

		// Token: 0x04020D85 RID: 134533
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200C392 RID: 50066
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403B04C RID: 241740
			public const int BlessSlotQuality = 0;

			// Token: 0x0403B04D RID: 241741
			public const int TexIcon = 1;

			// Token: 0x0403B04E RID: 241742
			public const int ItemSelectOn = 2;

			// Token: 0x0403B04F RID: 241743
			public const int SpriteIcon = 3;
		}
	}
}
