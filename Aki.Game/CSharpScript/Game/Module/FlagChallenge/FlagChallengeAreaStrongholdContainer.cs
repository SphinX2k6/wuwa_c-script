using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02005A4C RID: 23116
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengeAreaStrongholdContainer : UiPanelBase
	{
		// Token: 0x0603A9DD RID: 240093 RVA: 0x00DF3EDA File Offset: 0x00DF20DA
		public FlagChallengeAreaStrongholdContainer(int activityId, int levelId, int areaId)
		{
			this.ActivityId = activityId;
			this.LevelId = levelId;
			this.AreaId = areaId;
		}

		// Token: 0x0603A9DE RID: 240094 RVA: 0x00DF3F02 File Offset: 0x00DF2102
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x0603A9DF RID: 240095 RVA: 0x00DF3F3C File Offset: 0x00DF213C
		protected override UniTask OnBeforeStartAsync()
		{
			FlagChallengeAreaStrongholdContainer.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FlagChallengeAreaStrongholdContainer.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603A9E0 RID: 240096 RVA: 0x00DF3F80 File Offset: 0x00DF2180
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

		// Token: 0x0603A9E1 RID: 240097 RVA: 0x00DF4020 File Offset: 0x00DF2220
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

		// Token: 0x0603A9E2 RID: 240098 RVA: 0x00DF406B File Offset: 0x00DF226B
		public void SetItemSelectChangeCallback(Action<int> callback)
		{
			this.ItemSelectChangeCallback = callback;
		}

		// Token: 0x0603A9E3 RID: 240099 RVA: 0x00DF4074 File Offset: 0x00DF2274
		public void SetItemSelect(int id)
		{
			FlagChallengeAreaStrongholdItem flagChallengeAreaStrongholdItem;
			if (this.StrongholdItemMap.TryGetValue(id, out flagChallengeAreaStrongholdItem) && flagChallengeAreaStrongholdItem != null)
			{
				flagChallengeAreaStrongholdItem.SetSelected(true, true);
			}
		}

		// Token: 0x0603A9E4 RID: 240100 RVA: 0x00DF409C File Offset: 0x00DF229C
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

		// Token: 0x0603A9E5 RID: 240101 RVA: 0x00DF4114 File Offset: 0x00DF2314
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

		// Token: 0x0401E8B8 RID: 125112
		private readonly int ActivityId;

		// Token: 0x0401E8B9 RID: 125113
		private readonly int LevelId;

		// Token: 0x0401E8BA RID: 125114
		private readonly int AreaId;

		// Token: 0x0401E8BB RID: 125115
		private readonly Dictionary<int, FlagChallengeAreaStrongholdItem> StrongholdItemMap = new Dictionary<int, FlagChallengeAreaStrongholdItem>();

		// Token: 0x0401E8BC RID: 125116
		[Nullable(2)]
		private Action<int> ItemSelectChangeCallback;

		// Token: 0x0401E8BD RID: 125117
		private int? SelectedStrongholdId;
	}
}
