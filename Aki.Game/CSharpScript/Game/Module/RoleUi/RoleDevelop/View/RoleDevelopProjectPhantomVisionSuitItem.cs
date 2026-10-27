using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02004D44 RID: 19780
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleDevelopProjectPhantomVisionSuitItem : GridProxyAbstract<RoleDevelopPhantomVisionSuitItemData>
	{
		// Token: 0x060331A5 RID: 209317 RVA: 0x00BE8E34 File Offset: 0x00BE7034
		protected unsafe override void OnRegisterComponent()
		{
			int num = 12;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
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
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060331A6 RID: 209318 RVA: 0x00BE8FEC File Offset: 0x00BE71EC
		protected override UniTask OnBeforeStartAsync()
		{
			RoleDevelopProjectPhantomVisionSuitItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevelopProjectPhantomVisionSuitItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060331A7 RID: 209319 RVA: 0x00BE9030 File Offset: 0x00BE7230
		private UniTask InitButtonItem()
		{
			RoleDevelopProjectPhantomVisionSuitItem.<InitButtonItem>d__7 <InitButtonItem>d__;
			<InitButtonItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitButtonItem>d__.<>4__this = this;
			<InitButtonItem>d__.<>1__state = -1;
			<InitButtonItem>d__.<>t__builder.Start<RoleDevelopProjectPhantomVisionSuitItem.<InitButtonItem>d__7>(ref <InitButtonItem>d__);
			return <InitButtonItem>d__.<>t__builder.Task;
		}

		// Token: 0x060331A8 RID: 209320 RVA: 0x00BE9074 File Offset: 0x00BE7274
		private UniTask InitItemBaseCurrentVision()
		{
			RoleDevelopProjectPhantomVisionSuitItem.<InitItemBaseCurrentVision>d__8 <InitItemBaseCurrentVision>d__;
			<InitItemBaseCurrentVision>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitItemBaseCurrentVision>d__.<>4__this = this;
			<InitItemBaseCurrentVision>d__.<>1__state = -1;
			<InitItemBaseCurrentVision>d__.<>t__builder.Start<RoleDevelopProjectPhantomVisionSuitItem.<InitItemBaseCurrentVision>d__8>(ref <InitItemBaseCurrentVision>d__);
			return <InitItemBaseCurrentVision>d__.<>t__builder.Task;
		}

		// Token: 0x060331A9 RID: 209321 RVA: 0x00BE90B8 File Offset: 0x00BE72B8
		public override void Refresh(RoleDevelopPhantomVisionSuitItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.ButtonConfirm.SetLocalTextNew(data.ButtonName, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.Name, Array.Empty<object>());
			if (data.ItemType == EPhantomSuitItemType.Dungeon)
			{
				base.GetSprite(4).SetUIActive(false);
				base.GetTexture(5).SetUIActive(true);
				base.SetTextureByPath(data.TypeIcon, base.GetTexture(5), null, null);
				this.RefreshNightMareDesc(data.DungeonId);
				this.RefreshDoubleIcon(data.DungeonId);
				base.GetItem(8).SetUIActive(true);
				base.GetItem(9).SetUIActive(false);
			}
			else if (data.ItemType == EPhantomSuitItemType.Phantom)
			{
				base.GetSprite(4).SetUIActive(true);
				base.GetTexture(5).SetUIActive(false);
				UUIText text = base.GetText(6);
				if (text != null)
				{
					text.SetUIActive(false);
				}
				base.GetItem(7).SetUIActive(false);
				base.GetItem(8).SetUIActive(false);
				base.GetItem(9).SetUIActive(true);
				this.ItemBaseCurrentVision.Refresh(new RoleDevelopPhantomVisionSuitListItemData
				{
					MonsterData = data.MonsterDataList[0]
				}, false, 0);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(11), data.Name, Array.Empty<object>());
			}
			List<RoleDevelopPhantomVisionSuitListItemData> list = new List<RoleDevelopPhantomVisionSuitListItemData>();
			if (data.RewardDataList != null)
			{
				foreach (DropRewardItemData rewardData in data.RewardDataList)
				{
					list.Add(new RoleDevelopPhantomVisionSuitListItemData
					{
						RewardData = rewardData
					});
				}
			}
			this.ItemLayout.RefreshByData(list, null, false);
		}

		// Token: 0x060331AA RID: 209322 RVA: 0x00BE9284 File Offset: 0x00BE7484
		private RoleDevelopProjectPhantomVisionSuitListItem CreateItem()
		{
			return new RoleDevelopProjectPhantomVisionSuitListItem();
		}

		// Token: 0x060331AB RID: 209323 RVA: 0x00BE928C File Offset: 0x00BE748C
		private void OnClickConfirm(int value)
		{
			if (this.Data == null)
			{
				return;
			}
			if (this.Data.ItemType == EPhantomSuitItemType.Phantom)
			{
				CalabashController.Instance.JumpToCalabashCollectTabView(this.Data.MonsterDataList[0].MonsterId);
			}
			else
			{
				this.JumpToDungeon(this.Data.DungeonId);
			}
			if (this.Data.LogRoleId != null && this.Data.LogMainPage != null && this.Data.LogSubPage != null)
			{
				RoleController.Instance.LogRoleDevelopClick(this.Data.LogRoleId.Value, this.Data.LogMainPage.Value, this.Data.LogSubPage.Value, null);
			}
		}

		// Token: 0x060331AC RID: 209324 RVA: 0x00BE9370 File Offset: 0x00BE7570
		private void JumpToDungeon(int dungeonId)
		{
			if (GameModeController.Instance.IsInInstance())
			{
				GenericPromptController.Instance.ShowPromptByCode("DungeonDetection", Array.Empty<object>());
				return;
			}
			SilentAreaDetectionRecord silentAreaDetectData = AdventureGuideModel.Instance.GetSilentAreaDetectData(dungeonId);
			if (silentAreaDetectData == null)
			{
				return;
			}
			if (AdventureGuideModel.Instance.TryAdventureJumpBySilent(silentAreaDetectData))
			{
				return;
			}
			if (silentAreaDetectData.Conf.JumpType == 2)
			{
				AdventureGuideModel.Instance.SetFromManualDetect(true);
				AdventureGuideController.Instance.RequestForDetection(DetectionType.SilentArea, silentAreaDetectData.Conf.LevelPlayList(), dungeonId);
				ScrollingTipsController.Instance.ShowTipsByTextId("TeleportMarkNotUnlock", Array.Empty<object>());
				return;
			}
			if (!AdventureGuideController.Instance.IsMarkUnlock(silentAreaDetectData.Conf.MarkId))
			{
				return;
			}
			AdventureGuideModel.Instance.SetFromManualDetect(true);
			AdventureGuideController.Instance.RequestForDetection(DetectionType.SilentArea, silentAreaDetectData.Conf.LevelPlayList(), dungeonId);
		}

		// Token: 0x060331AD RID: 209325 RVA: 0x00BE9448 File Offset: 0x00BE7648
		private void RefreshDoubleIcon(int dungeonId)
		{
			SilentAreaDetectionRecord silentAreaDetectData = AdventureGuideModel.Instance.GetSilentAreaDetectData(dungeonId);
			bool uiactive = silentAreaDetectData != null && RoleDevelopUtil.IsDungeonShowDouble((EDungeonType)silentAreaDetectData.Conf.Secondary);
			base.GetItem(7).SetUIActive(uiactive);
		}

		// Token: 0x060331AE RID: 209326 RVA: 0x00BE9488 File Offset: 0x00BE7688
		private void RefreshNightMareDesc(int dungeonId)
		{
			UUIText text = base.GetText(6);
			SilentAreaDetectionRecord silentAreaDetectData = AdventureGuideModel.Instance.GetSilentAreaDetectData(dungeonId);
			if (silentAreaDetectData == null || (silentAreaDetectData.Conf.Secondary != 63 && silentAreaDetectData.Conf.Secondary != 64))
			{
				if (text != null)
				{
					text.SetUIActive(false);
				}
				return;
			}
			AdventureGuideModel instance = AdventureGuideModel.Instance;
			ValueTuple<long, int> valueTuple;
			if (instance.GetIsDetectionPreOpenByRecord(silentAreaDetectData))
			{
				valueTuple = instance.GetNightMarePreOpenTarget(instance.GetPreOpenDetectionConf(silentAreaDetectData.Conf.Id, ESoundAreaDataType.SilentArea, silentAreaDetectData.Conf.PreOpenId).Value.InstanceID);
			}
			else
			{
				int[] array = silentAreaDetectData.Conf.LevelPlayList();
				ValueTuple<int, int> nightMareTarget = instance.GetNightMareTarget(new int?(silentAreaDetectData.Conf.MapId), (array != null && array.Length != 0) ? new int?(array[0]) : null);
				valueTuple = new ValueTuple<long, int>((long)nightMareTarget.Item1, nightMareTarget.Item2);
			}
			if (valueTuple.Item2 < 0)
			{
				if (text != null)
				{
					text.SetUIActive(false);
					return;
				}
			}
			else
			{
				if (text != null)
				{
					text.SetUIActive(true);
				}
				LguiUtil.Instance.SetLocalTextNew(text, "NightMareLeftTimes", new <>z__ReadOnlyArray<object>(new object[]
				{
					valueTuple.Item1,
					valueTuple.Item2
				}));
			}
		}

		// Token: 0x0401B2A9 RID: 111273
		[Nullable(2)]
		private RoleDevelopPhantomVisionSuitItemData Data;

		// Token: 0x0401B2AA RID: 111274
		private ButtonItem ButtonConfirm;

		// Token: 0x0401B2AB RID: 111275
		private GenericLayout<RoleDevelopProjectPhantomVisionSuitListItem, RoleDevelopPhantomVisionSuitListItemData> ItemLayout;

		// Token: 0x0401B2AC RID: 111276
		[Nullable(2)]
		private RoleDevelopProjectPhantomVisionSuitListItem ItemBaseCurrentVision;

		// Token: 0x0200AEAA RID: 44714
		[NullableContext(0)]
		public static class EComponentType
		{
			// Token: 0x040350A1 RID: 217249
			public const int TxtName = 0;

			// Token: 0x040350A2 RID: 217250
			public const int PanelDetailLayout = 1;

			// Token: 0x040350A3 RID: 217251
			public const int ItemBase = 2;

			// Token: 0x040350A4 RID: 217252
			public const int BtnConfirm = 3;

			// Token: 0x040350A5 RID: 217253
			public const int IconSprite = 4;

			// Token: 0x040350A6 RID: 217254
			public const int IconTexture = 5;

			// Token: 0x040350A7 RID: 217255
			public const int TxtDesc = 6;

			// Token: 0x040350A8 RID: 217256
			public const int ItemDouble = 7;

			// Token: 0x040350A9 RID: 217257
			public const int PnlNormal = 8;

			// Token: 0x040350AA RID: 217258
			public const int PnlCurrentVision = 9;

			// Token: 0x040350AB RID: 217259
			public const int ItemBaseCurrentVision = 10;

			// Token: 0x040350AC RID: 217260
			public const int TextNameCurrentVision = 11;
		}
	}
}
