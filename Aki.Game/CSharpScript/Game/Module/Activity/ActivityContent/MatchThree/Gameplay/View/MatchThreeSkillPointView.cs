using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.View
{
	// Token: 0x02005460 RID: 21600
	[NullableContext(1)]
	[Nullable(0)]
	public class MatchThreeSkillPointView : UiPanelBase
	{
		// Token: 0x06035A1D RID: 219677 RVA: 0x00EFB765 File Offset: 0x00EF9965
		[NullableContext(2)]
		public MatchThreeSkillPointView(UUIItem item)
		{
			if (item == null)
			{
				return;
			}
			base.CreateThenShowByActor(item.GetOwner(), null);
		}

		// Token: 0x06035A1E RID: 219678 RVA: 0x00EFB78C File Offset: 0x00EF998C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06035A1F RID: 219679 RVA: 0x00EFB838 File Offset: 0x00EF9A38
		public void Refresh(SkillPointDisplayData data)
		{
			this.PlayStateAnim(data);
			UUIText text = base.GetText(3);
			if (text != null)
			{
				text.SetText(data.EnergyNode.ToString(), true);
			}
			UUISprite sprite = base.GetSprite(0);
			if (sprite != null)
			{
				sprite.SetUIActive(data.Charged);
			}
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(data.Released);
			}
			UUISprite sprite2 = base.GetSprite(2);
			if (sprite2 != null)
			{
				if (!string.IsNullOrEmpty(data.Icon))
				{
					this.SetSpriteByPath(data.Icon, sprite2, false, null, null);
				}
				sprite2.SetColor(FColor.FromHex(data.Released ? "DF9B28" : (data.Charged ? "312126" : "857A7E")));
			}
		}

		// Token: 0x06035A20 RID: 219680 RVA: 0x00EFB8F9 File Offset: 0x00EF9AF9
		public void SetOffsetX(float x)
		{
			if (this.RootItem == null)
			{
				return;
			}
			this.TempLocation.Set((double)x, (double)this.RootItem.GetAnchorOffsetY());
			this.RootItem.SetAnchorOffset(this.TempLocation.ToUeVector2D(true));
		}

		// Token: 0x06035A21 RID: 219681 RVA: 0x00EFB934 File Offset: 0x00EF9B34
		private void PlayStateAnim(SkillPointDisplayData data)
		{
			bool charged = data.Charged;
			bool released = data.Released;
			if (charged && !this.PrevCharged)
			{
				this.PlayAnim("Up");
			}
			if (released && !this.PrevReleased)
			{
				this.PlayAnim("Get");
			}
			this.PrevCharged = charged;
			this.PrevReleased = released;
		}

		// Token: 0x06035A22 RID: 219682 RVA: 0x00EFB98C File Offset: 0x00EF9B8C
		private void PlayAnim(string sequence)
		{
			if (this.RootItem == null)
			{
				return;
			}
			if (this.SequencePlayer == null)
			{
				this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			}
			this.SequencePlayer.PlaySequence(sequence, false, null);
		}

		// Token: 0x06035A23 RID: 219683 RVA: 0x00EFB9D1 File Offset: 0x00EF9BD1
		protected override void OnBeforeDestroy()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x0401C599 RID: 116121
		private const string IconColorIdle = "857A7E";

		// Token: 0x0401C59A RID: 116122
		private const string IconColorCharged = "312126";

		// Token: 0x0401C59B RID: 116123
		private const string IconColorReleased = "DF9B28";

		// Token: 0x0401C59C RID: 116124
		private readonly Vector2D TempLocation = Vector2D.Create();

		// Token: 0x0401C59D RID: 116125
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0401C59E RID: 116126
		private bool PrevCharged;

		// Token: 0x0401C59F RID: 116127
		private bool PrevReleased;

		// Token: 0x0200B107 RID: 45319
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04036BE9 RID: 224233
			SprBgFill,
			// Token: 0x04036BEA RID: 224234
			PnlDone,
			// Token: 0x04036BEB RID: 224235
			SprIcon,
			// Token: 0x04036BEC RID: 224236
			TxtNum
		}
	}
}
