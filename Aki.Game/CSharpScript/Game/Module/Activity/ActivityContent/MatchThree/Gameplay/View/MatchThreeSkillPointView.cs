using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.View
{
	// Token: 0x020064E2 RID: 25826
	[NullableContext(1)]
	[Nullable(0)]
	public class MatchThreeSkillPointView : UiPanelBase
	{
		// Token: 0x06040D59 RID: 265561 RVA: 0x00FB4735 File Offset: 0x00FB2935
		[NullableContext(2)]
		public MatchThreeSkillPointView(UUIItem item)
		{
			if (item == null)
			{
				return;
			}
			base.CreateThenShowByActor(item.GetOwner(), null);
		}

		// Token: 0x06040D5A RID: 265562 RVA: 0x00FB475C File Offset: 0x00FB295C
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

		// Token: 0x06040D5B RID: 265563 RVA: 0x00FB4808 File Offset: 0x00FB2A08
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

		// Token: 0x06040D5C RID: 265564 RVA: 0x00FB48C9 File Offset: 0x00FB2AC9
		public void SetOffsetX(float x)
		{
			if (this.RootItem == null)
			{
				return;
			}
			this.TempLocation.Set((double)x, (double)this.RootItem.GetAnchorOffsetY());
			this.RootItem.SetAnchorOffset(this.TempLocation.ToUeVector2D(true));
		}

		// Token: 0x06040D5D RID: 265565 RVA: 0x00FB4904 File Offset: 0x00FB2B04
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

		// Token: 0x06040D5E RID: 265566 RVA: 0x00FB495C File Offset: 0x00FB2B5C
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

		// Token: 0x06040D5F RID: 265567 RVA: 0x00FB49A1 File Offset: 0x00FB2BA1
		protected override void OnBeforeDestroy()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x04021C68 RID: 138344
		private const string IconColorIdle = "857A7E";

		// Token: 0x04021C69 RID: 138345
		private const string IconColorCharged = "312126";

		// Token: 0x04021C6A RID: 138346
		private const string IconColorReleased = "DF9B28";

		// Token: 0x04021C6B RID: 138347
		private readonly Vector2D TempLocation = Vector2D.Create();

		// Token: 0x04021C6C RID: 138348
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x04021C6D RID: 138349
		private bool PrevCharged;

		// Token: 0x04021C6E RID: 138350
		private bool PrevReleased;

		// Token: 0x0200C721 RID: 50977
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403C28E RID: 246414
			SprBgFill,
			// Token: 0x0403C28F RID: 246415
			PnlDone,
			// Token: 0x0403C290 RID: 246416
			SprIcon,
			// Token: 0x0403C291 RID: 246417
			TxtNum
		}
	}
}
