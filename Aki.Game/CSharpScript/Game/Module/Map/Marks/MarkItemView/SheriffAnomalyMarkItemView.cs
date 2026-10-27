using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.Marks.SubPanel;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x02005521 RID: 21793
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffAnomalyMarkItemView : ConfigMarkItemView
	{
		// Token: 0x06037A60 RID: 227936 RVA: 0x00D358DB File Offset: 0x00D33ADB
		public SheriffAnomalyMarkItemView(SheriffAnomalyMarkItem markItem) : base(markItem)
		{
		}

		// Token: 0x06037A61 RID: 227937 RVA: 0x00D358E4 File Offset: 0x00D33AE4
		protected override UniTask OnBeforeStartAsync()
		{
			SheriffAnomalyMarkItemView.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SheriffAnomalyMarkItemView.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037A62 RID: 227938 RVA: 0x00D35928 File Offset: 0x00D33B28
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

		// Token: 0x06037A63 RID: 227939 RVA: 0x00D35990 File Offset: 0x00D33B90
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

		// Token: 0x06037A64 RID: 227940 RVA: 0x00D35A2C File Offset: 0x00D33C2C
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

		// Token: 0x0401D428 RID: 119848
		[Nullable(2)]
		private SheriffAnomalyMarkUi SheriffAnomalyMarkUi;
	}
}
