using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02004A28 RID: 18984
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengeAreaStrongholdContainer : UiPanelBase
	{
		// Token: 0x0602F926 RID: 194854 RVA: 0x00D4445E File Offset: 0x00D4265E
		public FlagChallengeAreaStrongholdContainer(int activityId, int levelId, int areaId)
		{
			this.ActivityId = activityId;
			this.LevelId = levelId;
			this.AreaId = areaId;
		}

		// Token: 0x0602F927 RID: 194855 RVA: 0x00D44486 File Offset: 0x00D42686
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x0602F928 RID: 194856 RVA: 0x00D444C0 File Offset: 0x00D426C0
		protected override UniTask OnBeforeStartAsync()
		{
			FlagChallengeAreaStrongholdContainer.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FlagChallengeAreaStrongholdContainer.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602F929 RID: 194857 RVA: 0x00D44504 File Offset: 0x00D42704
		protected override void OnStart()
		{
			EFlagChallengeUiStyleType uiStyle = (EFlagChallengeUiStyleType)FlagChallengeConfig.Instance.GetLevelConfig(this.LevelId).Value.UiStyle;
			int uiPos = FlagChallengeConfig.Instance.GetAreaConfig(this.AreaId).Value.UiPos;
			string dynamicRes = FlagChallengeUtils.GetDynamicRes(uiStyle, "AreaDetailItemBg", uiPos);
			UUITexture bgTex = base.GetTexture(0);
			base.SetTextureByPath(UiResourceConfig.Instance.GetResourcePath(dynamicRes), bgTex, null, delegate(bool _)
			{
				bgTex.SetSizeFromTexture();
			});
		}

		// Token: 0x0602F92A RID: 194858 RVA: 0x00D445A4 File Offset: 0x00D427A4
		private UniTask CreateStrongholdItemAsync(FlagChallengeStrongholdData data)
		{
			FlagChallengeAreaStrongholdContainer.<CreateStrongholdItemAsync>d__10 <CreateStrongholdItemAsync>d__;
			<CreateStrongholdItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateStrongholdItemAsync>d__.<>4__this = this;
			<CreateStrongholdItemAsync>d__.data = data;
			<CreateStrongholdItemAsync>d__.<>1__state = -1;
			<CreateStrongholdItemAsync>d__.<>t__builder.Start<FlagChallengeAreaStrongholdContainer.<CreateStrongholdItemAsync>d__10>(ref <CreateStrongholdItemAsync>d__);
			return <CreateStrongholdItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602F92B RID: 194859 RVA: 0x00D445EF File Offset: 0x00D427EF
		public void SetItemSelectChangeCallback(Action<int> callback)
		{
			this.ItemSelectChangeCallback = callback;
		}

		// Token: 0x0602F92C RID: 194860 RVA: 0x00D445F8 File Offset: 0x00D427F8
		public void SetItemSelect(int id)
		{
			FlagChallengeAreaStrongholdItem flagChallengeAreaStrongholdItem;
			if (this.StrongholdItemMap.TryGetValue(id, out flagChallengeAreaStrongholdItem) && flagChallengeAreaStrongholdItem != null)
			{
				flagChallengeAreaStrongholdItem.SetSelected(true, true);
			}
		}

		// Token: 0x0602F92D RID: 194861 RVA: 0x00D44620 File Offset: 0x00D42820
		private void OnItemToggleCallback(int id)
		{
			if (this.SelectedStrongholdId != null)
			{
				int? selectedStrongholdId = this.SelectedStrongholdId;
				FlagChallengeAreaStrongholdItem flagChallengeAreaStrongholdItem;
				if (!(selectedStrongholdId.GetValueOrDefault() == id & selectedStrongholdId != null) && this.StrongholdItemMap.TryGetValue(this.SelectedStrongholdId.Value, out flagChallengeAreaStrongholdItem))
				{
					flagChallengeAreaStrongholdItem.SetSelected(false, false);
				}
			}
			this.SelectedStrongholdId = new int?(id);
			Action<int> itemSelectChangeCallback = this.ItemSelectChangeCallback;
			if (itemSelectChangeCallback == null)
			{
				return;
			}
			itemSelectChangeCallback(id);
		}

		// Token: 0x0602F92E RID: 194862 RVA: 0x00D44698 File Offset: 0x00D42898
		[NullableContext(2)]
		public FlagChallengeAreaStrongholdItem GetBossStrongholdItem()
		{
			foreach (FlagChallengeAreaStrongholdItem flagChallengeAreaStrongholdItem in this.StrongholdItemMap.Values)
			{
				if (flagChallengeAreaStrongholdItem.GetIsBoss())
				{
					return flagChallengeAreaStrongholdItem;
				}
			}
			return null;
		}

		// Token: 0x0401935F RID: 103263
		private readonly int ActivityId;

		// Token: 0x04019360 RID: 103264
		private readonly int LevelId;

		// Token: 0x04019361 RID: 103265
		private readonly int AreaId;

		// Token: 0x04019362 RID: 103266
		private readonly Dictionary<int, FlagChallengeAreaStrongholdItem> StrongholdItemMap = new Dictionary<int, FlagChallengeAreaStrongholdItem>();

		// Token: 0x04019363 RID: 103267
		[Nullable(2)]
		private Action<int> ItemSelectChangeCallback;

		// Token: 0x04019364 RID: 103268
		private int? SelectedStrongholdId;
	}
}
