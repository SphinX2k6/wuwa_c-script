using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.Marks.SubPanel;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x020044F4 RID: 17652
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffAnomalyMarkItemView : ConfigMarkItemView
	{
		// Token: 0x0602C92F RID: 182575 RVA: 0x00C836CB File Offset: 0x00C818CB
		public SheriffAnomalyMarkItemView(SheriffAnomalyMarkItem markItem) : base(markItem)
		{
		}

		// Token: 0x0602C930 RID: 182576 RVA: 0x00C836D4 File Offset: 0x00C818D4
		protected override UniTask OnBeforeStartAsync()
		{
			SheriffAnomalyMarkItemView.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SheriffAnomalyMarkItemView.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602C931 RID: 182577 RVA: 0x00C83717 File Offset: 0x00C81917
		protected override void OnBeforeDestroy()
		{
			SheriffAnomalyMarkUi sheriffAnomalyMarkUi = this.SheriffAnomalyMarkUi;
			if (sheriffAnomalyMarkUi != null)
			{
				sheriffAnomalyMarkUi.Destroy(null);
			}
			base.OnBeforeDestroy();
		}

		// Token: 0x0602C932 RID: 182578 RVA: 0x00C83734 File Offset: 0x00C81934
		protected override void OnViewRefresh()
		{
			if (this.Holder.NeedPlayStartSequence)
			{
				this.Holder.NeedPlayStartSequence = false;
				this.Holder.NeedPlayShowOrHideSeq = null;
				LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
				if (levelSequencePlayer != null)
				{
					levelSequencePlayer.StopCurrentSequence(false, false);
				}
				LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
				if (levelSequencePlayer2 == null)
				{
					return;
				}
				levelSequencePlayer2.PlayLevelSequenceByName("Start", false, null, false);
			}
		}

		// Token: 0x0602C933 RID: 182579 RVA: 0x00C8379C File Offset: 0x00C8199C
		protected override void OnSafeUpdate(Vector playerLocation, bool bDragging = false, bool bIsScale = false)
		{
			MapModel instance = MapModel.Instance;
			if (instance != null && instance.IsExtraUiMarkType(this.Holder.MapType, this.Holder.MarkType))
			{
				SheriffAnomalyMarkUi sheriffAnomalyMarkUi = this.SheriffAnomalyMarkUi;
				if (sheriffAnomalyMarkUi != null)
				{
					sheriffAnomalyMarkUi.SetData(this.Holder.MarkId);
				}
				SheriffAnomalyMarkUi sheriffAnomalyMarkUi2 = this.SheriffAnomalyMarkUi;
				if (sheriffAnomalyMarkUi2 != null)
				{
					sheriffAnomalyMarkUi2.SetUiActive(true);
				}
				UUISprite sprite = base.GetSprite(1);
				if (sprite == null)
				{
					return;
				}
				sprite.SetUIActive(false);
				return;
			}
			else
			{
				SheriffAnomalyMarkUi sheriffAnomalyMarkUi3 = this.SheriffAnomalyMarkUi;
				if (sheriffAnomalyMarkUi3 != null)
				{
					sheriffAnomalyMarkUi3.SetUiActive(false);
				}
				UUISprite sprite2 = base.GetSprite(1);
				if (sprite2 == null)
				{
					return;
				}
				sprite2.SetUIActive(true);
				return;
			}
		}

		// Token: 0x0602C934 RID: 182580 RVA: 0x00C83838 File Offset: 0x00C81A38
		[NullableContext(2)]
		public override UUIItem GetIconItem()
		{
			MapModel instance = MapModel.Instance;
			if (instance == null || !instance.IsExtraUiMarkType(this.Holder.MapType, this.Holder.MarkType))
			{
				return base.GetIconItem();
			}
			SheriffAnomalyMarkUi sheriffAnomalyMarkUi = this.SheriffAnomalyMarkUi;
			if (sheriffAnomalyMarkUi == null)
			{
				return null;
			}
			return sheriffAnomalyMarkUi.GetRootItem();
		}

		// Token: 0x04017EAB RID: 97963
		[Nullable(2)]
		private SheriffAnomalyMarkUi SheriffAnomalyMarkUi;
	}
}
