using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.Marks.MarkItemView.Components;
using CSharpScript.Game.Module.WorldMap;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView
{
	// Token: 0x02005522 RID: 21794
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffQuestMarkItemView : ConfigMarkItemView
	{
		// Token: 0x06037A65 RID: 227941 RVA: 0x00D35A7A File Offset: 0x00D33C7A
		public SheriffQuestMarkItemView(SheriffQuestMarkItem holder) : base(holder)
		{
		}

		// Token: 0x06037A66 RID: 227942 RVA: 0x00D35AA0 File Offset: 0x00D33CA0
		protected override void OnViewRefresh()
		{
			base.OnViewRefresh();
			SheriffQuestMarkItem sheriffQuestMarkItem = (SheriffQuestMarkItem)this.Holder;
			base.MarkItemNameHandle.SetName(new MarkItemParam
			{
				Txt = PublicUtil.Instance.GetConfigTextByKey(QuestNewModel.Instance.GetQuestConfig(sheriffQuestMarkItem.QuestId).TidName),
				FontSize = new int?(SheriffQuestMarkItemView.FONT_SIZE),
				AnchorOffset = new FVector2D?(this.NameAnchorOffset.ToUeVector2D(false)),
				OutlineSize = new float?((float)2),
				OutlineColor = new FColor?(FColor.FromHex("#292929"))
			});
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

		// Token: 0x06037A67 RID: 227943 RVA: 0x00D35B98 File Offset: 0x00D33D98
		protected override void OnSafeUpdate(Vector playerLocation, bool bDragging = false, bool bIsScale = false)
		{
			float num = WorldMapModel.Instance.MapScale * 100f;
			SheriffQuestMarkItem sheriffQuestMarkItem = (SheriffQuestMarkItem)this.Holder;
			bool visible = num > (float)sheriffQuestMarkItem.TextVisibleScale;
			base.MarkItemNameHandle.SetVisible(visible);
		}

		// Token: 0x0401D429 RID: 119849
		private static readonly int FONT_SIZE = 36;

		// Token: 0x0401D42A RID: 119850
		private readonly Vector2D NameAnchorOffset = new Vector2D(0.0, -60.0);
	}
}
