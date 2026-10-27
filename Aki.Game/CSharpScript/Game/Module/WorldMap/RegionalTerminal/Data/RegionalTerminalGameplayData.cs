using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Sheriff;

namespace CSharpScript.Game.Module.WorldMap.RegionalTerminal.Data
{
	// Token: 0x0200485E RID: 18526
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class RegionalTerminalGameplayData
	{
		// Token: 0x060307C6 RID: 198598
		public abstract ERedDotName? GetRedDotName();

		// Token: 0x060307C7 RID: 198599
		public abstract int GetRedDotId();

		// Token: 0x060307C8 RID: 198600
		public abstract bool GetRedDotState();

		// Token: 0x060307C9 RID: 198601
		public abstract void BarFunction();

		// Token: 0x060307CA RID: 198602
		public abstract void TerminalFunction(Action<bool> callback = null);

		// Token: 0x060307CB RID: 198603
		public abstract bool GetShowState();

		// Token: 0x060307CC RID: 198604
		public abstract bool GetLockState();

		// Token: 0x060307CD RID: 198605
		[NullableContext(1)]
		public abstract IRegionalTerminalViewParams GetViewParams();

		// Token: 0x060307CE RID: 198606 RVA: 0x00B421F0 File Offset: 0x00B403F0
		public virtual List<TItem> GetRewardPreviewList()
		{
			int rewardPreview = this.GetGameplayConfig().RewardPreview;
			if (rewardPreview == 0)
			{
				return null;
			}
			return CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(rewardPreview);
		}

		// Token: 0x060307CF RID: 198607 RVA: 0x00B4221C File Offset: 0x00B4041C
		protected AreaTerminal GetGameplayConfig()
		{
			return RegionalTerminalConfig.Instance.GetAreaTerminalByGameplayId(this.Id).Value;
		}

		// Token: 0x060307D0 RID: 198608 RVA: 0x00B42244 File Offset: 0x00B40444
		public void OnSelected()
		{
			if (this.GetRedDotName().GetValueOrDefault() == ERedDotName.SheriffMap)
			{
				SheriffController.Instance.ReadTerminalFirstOpenRedDot();
			}
		}

		// Token: 0x0401A0B8 RID: 106680
		public int Id;

		// Token: 0x0401A0B9 RID: 106681
		public int GameplayId;

		// Token: 0x0401A0BA RID: 106682
		public int GroupId;

		// Token: 0x0401A0BB RID: 106683
		public int SortId;

		// Token: 0x0401A0BC RID: 106684
		public bool CloseTerminalWhenForwarding = true;
	}
}
