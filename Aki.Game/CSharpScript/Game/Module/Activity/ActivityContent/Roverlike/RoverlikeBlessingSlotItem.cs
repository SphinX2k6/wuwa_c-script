using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050B3 RID: 20659
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoverlikeBlessingSlotItem : GridProxyAbstract<IRoverlikeBlessingSlotItemData>
	{
		// Token: 0x06033B5A RID: 211802 RVA: 0x00E79188 File Offset: 0x00E77388
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

		// Token: 0x06033B5B RID: 211803 RVA: 0x00E79233 File Offset: 0x00E77433
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}

		// Token: 0x06033B5C RID: 211804 RVA: 0x00E79248 File Offset: 0x00E77448
		public void PlaySelectAnim()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayOrReplaySequenceByName("Select", false, null);
		}

		// Token: 0x06033B5D RID: 211805 RVA: 0x00E79274 File Offset: 0x00E77474
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

		// Token: 0x06033B5E RID: 211806 RVA: 0x00E79384 File Offset: 0x00E77584
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

		// Token: 0x06033B5F RID: 211807 RVA: 0x00E79424 File Offset: 0x00E77624
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

		// Token: 0x06033B60 RID: 211808 RVA: 0x00E7946E File Offset: 0x00E7766E
		public void SetSelectOn(bool bSelectOn)
		{
			base.GetItem(2).SetUIActive(bSelectOn);
		}

		// Token: 0x06033B61 RID: 211809 RVA: 0x00E7947D File Offset: 0x00E7767D
		public override object GetKey(IRoverlikeBlessingSlotItemData data, int displayIndex)
		{
			return data.SlotId;
		}

		// Token: 0x0401B6B2 RID: 112306
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200AD79 RID: 44409
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040359AD RID: 219565
			public const int BlessSlotQuality = 0;

			// Token: 0x040359AE RID: 219566
			public const int TexIcon = 1;

			// Token: 0x040359AF RID: 219567
			public const int ItemSelectOn = 2;

			// Token: 0x040359B0 RID: 219568
			public const int SpriteIcon = 3;
		}
	}
}
