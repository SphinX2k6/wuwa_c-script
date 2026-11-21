using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CC2 RID: 19650
	[NullableContext(2)]
	[Nullable(0)]
	public class SkillButtonDotIndicator : UiPanelBase
	{
		// Token: 0x060311FC RID: 201212 RVA: 0x00DB7904 File Offset: 0x00DB5B04
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060311FD RID: 201213 RVA: 0x00DB798E File Offset: 0x00DB5B8E
		protected override void OnStart()
		{
			base.SkipDestroyActor = true;
			this.InitTweenAnim(1);
			this.InitTweenAnim(2);
			base.SetUiActive(true);
			base.GetTexture(0).SetUIActive(false);
		}

		// Token: 0x060311FE RID: 201214 RVA: 0x00DB79B9 File Offset: 0x00DB5BB9
		protected override void OnBeforeDestroy()
		{
			if (this.DefaultTextureData != null)
			{
				this.SetIconResource(null);
			}
			base.OnBeforeDestroy();
		}

		// Token: 0x060311FF RID: 201215 RVA: 0x00DB79D0 File Offset: 0x00DB5BD0
		private void InitTweenAnim(int componentType)
		{
			if (this.TweenAnimPlayer == null)
			{
				this.TweenAnimPlayer = new BattleUiTweenAnimPlayer();
			}
			this.TweenAnimPlayer.InitTweenAnim(componentType, base.GetItem(componentType), false);
		}

		// Token: 0x06031200 RID: 201216 RVA: 0x00DB79FC File Offset: 0x00DB5BFC
		public void SetDotState(bool bIn, bool force = false)
		{
			if (force)
			{
				UUITexture texture = base.GetTexture(0);
				texture.SetUIActive(bIn);
				texture.SetAlpha(bIn > false);
				return;
			}
			if (this.TweenAnimPlayer == null)
			{
				return;
			}
			UUITexture texture2 = base.GetTexture(0);
			bool flag = texture2.bIsUIActive && texture2.GetAlpha() == 1f;
			bool flag2 = !texture2.bIsUIActive || texture2.GetAlpha() == 0f;
			if (bIn && flag)
			{
				return;
			}
			if (!bIn && flag2)
			{
				return;
			}
			if (!texture2.bIsUIActive)
			{
				texture2.SetUIActive(true);
			}
			this.TweenAnimPlayer.StopTweenAnim((!bIn) ? 1 : 2);
			this.TweenAnimPlayer.PlayTweenAnim(bIn ? 1 : 2);
		}

		// Token: 0x06031201 RID: 201217 RVA: 0x00DB7AAC File Offset: 0x00DB5CAC
		public void SetIconResource(UTexture textureData)
		{
			UUITexture texture = base.GetTexture(0);
			if (texture == null)
			{
				return;
			}
			if (textureData != null)
			{
				if (this.DefaultTextureData == null)
				{
					this.DefaultTextureData = texture.GetTexture();
				}
				texture.SetTexture(textureData);
				return;
			}
			if (this.DefaultTextureData != null)
			{
				texture.SetTexture(this.DefaultTextureData);
				this.DefaultTextureData = null;
			}
		}

		// Token: 0x0401A095 RID: 106645
		private BattleUiTweenAnimPlayer TweenAnimPlayer;

		// Token: 0x0401A096 RID: 106646
		private UTexture DefaultTextureData;

		// Token: 0x0200A940 RID: 43328
		[NullableContext(0)]
		private enum EDotChildType
		{
			// Token: 0x040344A4 RID: 214180
			LightDot,
			// Token: 0x040344A5 RID: 214181
			AniIn,
			// Token: 0x040344A6 RID: 214182
			AniOut
		}
	}
}
