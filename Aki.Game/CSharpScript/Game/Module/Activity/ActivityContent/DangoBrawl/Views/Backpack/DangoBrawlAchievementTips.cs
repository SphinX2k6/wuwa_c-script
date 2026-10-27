using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Views.Backpack
{
	// Token: 0x0200684A RID: 26698
	public class DangoBrawlAchievementTips : UiPanelBase
	{
		// Token: 0x06042A4A RID: 272970 RVA: 0x010346DC File Offset: 0x010328DC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06042A4B RID: 272971 RVA: 0x01034788 File Offset: 0x01032988
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlAchievementTips.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlAchievementTips.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042A4C RID: 272972 RVA: 0x010347CB File Offset: 0x010329CB
		protected override void OnBeforeDestroy()
		{
			this.ClearSequencePlayer();
		}

		// Token: 0x06042A4D RID: 272973 RVA: 0x010347D4 File Offset: 0x010329D4
		private void CreateSequencePlayer()
		{
			this.ClearSequencePlayer();
			UUIItem rootItem = base.GetRootItem();
			if (rootItem == null)
			{
				return;
			}
			this.SequencePlayer = new UiSequencePlayer(rootItem);
		}

		// Token: 0x06042A4E RID: 272974 RVA: 0x010347FE File Offset: 0x010329FE
		private void ClearSequencePlayer()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x06042A4F RID: 272975 RVA: 0x01034818 File Offset: 0x01032A18
		public void ShowTips(int configId)
		{
			DangoBrawlItem? itemConfigById = DangoBrawlConfig.Instance.GetItemConfigById(configId);
			if (itemConfigById == null)
			{
				return;
			}
			DangoBrawlOccupationWeaponItem weaponItem = this.WeaponItem;
			if (weaponItem != null)
			{
				weaponItem.Refresh(new DangoBrawlOccupationWeaponItemData
				{
					WeaponId = configId
				}, false, 0);
			}
			DangoBrawlItemQuality? itemQualityConfigById = DangoBrawlConfig.Instance.GetItemQualityConfigById(itemConfigById.Value.Quality);
			if (itemQualityConfigById != null)
			{
				base.SetTextureByPath(itemQualityConfigById.Value.CombineAchievementBgIcon, base.GetTexture(3), null, null);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "DangoBrawlGeneral_1026", Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), itemConfigById.Value.Name, Array.Empty<object>());
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlaySequencePurely("Start", false, false);
		}

		// Token: 0x06042A50 RID: 272976 RVA: 0x010348FC File Offset: 0x01032AFC
		[NullableContext(1)]
		private static string[] GetDescParams(DangoBrawlItem itemConfig)
		{
			StringArray? stringArray = (itemConfig.SpeEffectDescParamLength > 0) ? itemConfig.SpeEffectDescParam(0) : null;
			if (stringArray == null)
			{
				return Array.Empty<string>();
			}
			StringArray value = stringArray.Value;
			string[] array = new string[value.ArrayStringLength];
			for (int i = 0; i < value.ArrayStringLength; i++)
			{
				array[i] = (value.ArrayString(i) ?? string.Empty);
			}
			return array;
		}

		// Token: 0x04022B4F RID: 142159
		[Nullable(2)]
		private DangoBrawlOccupationWeaponItem WeaponItem;

		// Token: 0x04022B50 RID: 142160
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0200CA12 RID: 51730
		private enum EComponents
		{
			// Token: 0x0403D10C RID: 250124
			ProxyPageItem,
			// Token: 0x0403D10D RID: 250125
			TxtTitle,
			// Token: 0x0403D10E RID: 250126
			TxtName,
			// Token: 0x0403D10F RID: 250127
			TexQuality
		}
	}
}
