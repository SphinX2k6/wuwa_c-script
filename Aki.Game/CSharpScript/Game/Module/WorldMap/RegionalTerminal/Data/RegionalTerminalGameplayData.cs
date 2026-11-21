using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Sheriff;

namespace CSharpScript.Game.Module.WorldMap.RegionalTerminal.Data
{
	// Token: 0x0200378F RID: 14223
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class RegionalTerminalGameplayData
	{
		// Token: 0x06024F95 RID: 151445
		public abstract ERedDotName? GetRedDotName();

		// Token: 0x06024F96 RID: 151446
		public abstract int GetRedDotId();

		// Token: 0x06024F97 RID: 151447
		public abstract bool GetRedDotState();

		// Token: 0x06024F98 RID: 151448
		public abstract void BarFunction();

		// Token: 0x06024F99 RID: 151449
		public abstract void TerminalFunction(Action<bool> callback = null);

		// Token: 0x06024F9A RID: 151450
		public abstract bool GetShowState();

		// Token: 0x06024F9B RID: 151451
		public abstract bool GetLockState();

		// Token: 0x06024F9C RID: 151452
		[NullableContext(1)]
		public abstract IRegionalTerminalViewParams GetViewParams();

		// Token: 0x06024F9D RID: 151453 RVA: 0x00A72434 File Offset: 0x00A70634
		public virtual List<TItem> GetRewardPreviewList()
		{
			int rewardPreview = this.GetGameplayConfig().RewardPreview;
			if (rewardPreview == 0)
			{
				return null;
			}
			return CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(rewardPreview);
		}

		// Token: 0x06024F9E RID: 151454 RVA: 0x00A72460 File Offset: 0x00A70660
		protected AreaTerminal GetGameplayConfig()
		{
			return RegionalTerminalConfig.Instance.GetAreaTerminalByGameplayId(this.Id).Value;
		}

		// Token: 0x06024F9F RID: 151455 RVA: 0x00A72488 File Offset: 0x00A70688
		public void OnSelected()
		{
			if (this.GetRedDotName().GetValueOrDefault() == ERedDotName.SheriffMap)
			{
				SheriffController.Instance.ReadTerminalFirstOpenRedDot();
			}
		}

		// Token: 0x0401476C RID: 83820
		public int Id;

		// Token: 0x0401476D RID: 83821
		public int GameplayId;

		// Token: 0x0401476E RID: 83822
		public int GroupId;

		// Token: 0x0401476F RID: 83823
		public int SortId;

		// Token: 0x04014770 RID: 83824
		public bool CloseTerminalWhenForwarding = true;
	}
}
