using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CE0 RID: 23776
	[NullableContext(2)]
	[Nullable(0)]
	public class SkillButtonDotIndicator : UiPanelBase
	{
		// Token: 0x0603C2A6 RID: 246438 RVA: 0x00E67350 File Offset: 0x00E65550
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

		// Token: 0x0603C2A7 RID: 246439 RVA: 0x00E673DA File Offset: 0x00E655DA
		protected override void OnStart()
		{
			base.SkipDestroyActor = true;
			this.InitTweenAnim(1);
			this.InitTweenAnim(2);
			base.SetUiActive(true);
			base.GetTexture(0).SetUIActive(false);
		}

		// Token: 0x0603C2A8 RID: 246440 RVA: 0x00E67405 File Offset: 0x00E65605
		protected override void OnBeforeDestroy()
		{
			if (this.DefaultTextureData != null)
			{
				this.SetIconResource(null);
			}
			base.OnBeforeDestroy();
		}

		// Token: 0x0603C2A9 RID: 246441 RVA: 0x00E6741C File Offset: 0x00E6561C
		private void InitTweenAnim(int componentType)
		{
			if (this.TweenAnimPlayer == null)
			{
				this.TweenAnimPlayer = new BattleUiTweenAnimPlayer();
			}
			this.TweenAnimPlayer.InitTweenAnim(componentType, base.GetItem(componentType), false);
		}

		// Token: 0x0603C2AA RID: 246442 RVA: 0x00E67448 File Offset: 0x00E65648
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

		// Token: 0x0603C2AB RID: 246443 RVA: 0x00E674F8 File Offset: 0x00E656F8
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

		// Token: 0x0401F5DC RID: 128476
		private BattleUiTweenAnimPlayer TweenAnimPlayer;

		// Token: 0x0401F5DD RID: 128477
		private UTexture DefaultTextureData;

		// Token: 0x0200BF3A RID: 48954
		[NullableContext(0)]
		private enum EDotChildType
		{
			// Token: 0x04039AE2 RID: 236258
			LightDot,
			// Token: 0x04039AE3 RID: 236259
			AniIn,
			// Token: 0x04039AE4 RID: 236260
			AniOut
		}
	}
}
