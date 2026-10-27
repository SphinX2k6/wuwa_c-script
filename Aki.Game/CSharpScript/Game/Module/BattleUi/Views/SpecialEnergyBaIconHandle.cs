using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E1A RID: 24090
	[NullableContext(2)]
	[Nullable(0)]
	public class SpecialEnergyBaIconHandle
	{
		// Token: 0x0603D427 RID: 250919 RVA: 0x00EC3516 File Offset: 0x00EC1716
		[NullableContext(1)]
		public void Init(UUITexture[] iconTextureList, [Nullable(2)] UUIItem animItem = null)
		{
			this.IconTextureList = iconTextureList;
			this.AnimItem = animItem;
		}

		// Token: 0x0603D428 RID: 250920 RVA: 0x00EC3528 File Offset: 0x00EC1728
		public void SetIcon(string iconPath)
		{
			UUITexture[] iconTextureList = this.IconTextureList;
			for (int i = 0; i < iconTextureList.Length; i++)
			{
				iconTextureList[i].SetUIActive(false);
			}
			if (string.IsNullOrEmpty(iconPath))
			{
				return;
			}
			this.LoadIconId = ResourceSystem.Instance.LoadAsync<UTexture2D>(iconPath, delegate([Nullable(2)] UTexture2D iconTextureData, string _)
			{
				this.LoadIconId = -1;
				if (iconTextureData == null)
				{
					return;
				}
				foreach (UUITexture uuitexture in this.IconTextureList)
				{
					uuitexture.SetUIActive(true);
					uuitexture.SetTexture(iconTextureData);
				}
			}, 103, "js_undefined");
		}

		// Token: 0x0603D429 RID: 250921 RVA: 0x00EC3580 File Offset: 0x00EC1780
		public void PlayEndAnim(bool isPlay)
		{
			if (this.IsPlayingEndAnim == isPlay)
			{
				return;
			}
			this.IsPlayingEndAnim = isPlay;
			this.InitTweenAnim();
			if (isPlay)
			{
				using (List<ULGUIPlayTweenComponent>.Enumerator enumerator = this.AnimationList.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						ULGUIPlayTweenComponent ulguiplayTweenComponent = enumerator.Current;
						ulguiplayTweenComponent.Play();
					}
					return;
				}
			}
			foreach (ULGUIPlayTweenComponent ulguiplayTweenComponent2 in this.AnimationList)
			{
				ulguiplayTweenComponent2.Stop();
			}
			UUITexture[] iconTextureList = this.IconTextureList;
			for (int i = 0; i < iconTextureList.Length; i++)
			{
				iconTextureList[i].SetAlpha(1f);
			}
		}

		// Token: 0x0603D42A RID: 250922 RVA: 0x00EC364C File Offset: 0x00EC184C
		private void InitTweenAnim()
		{
			if (this.AnimationList != null)
			{
				return;
			}
			this.AnimationList = new List<ULGUIPlayTweenComponent>();
			if (this.AnimItem != null)
			{
				TArray<UActorComponent> tarray = this.AnimItem.GetOwner().K2_GetComponentsByClass(ULGUIPlayTweenComponent.StaticClass());
				for (int i = 0; i < tarray.Num(); i++)
				{
					ULGUIPlayTweenComponent item = tarray.Get(i) as ULGUIPlayTweenComponent;
					this.AnimationList.Add(item);
				}
			}
		}

		// Token: 0x0603D42B RID: 250923 RVA: 0x00EC36BA File Offset: 0x00EC18BA
		public void OnBeforeDestroy()
		{
			this.PlayEndAnim(false);
			if (this.LoadIconId != -1)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.LoadIconId);
				this.LoadIconId = -1;
			}
		}

		// Token: 0x0401FF1F RID: 130847
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private UUITexture[] IconTextureList;

		// Token: 0x0401FF20 RID: 130848
		private UUIItem AnimItem;

		// Token: 0x0401FF21 RID: 130849
		private int LoadIconId = -1;

		// Token: 0x0401FF22 RID: 130850
		private bool IsPlayingEndAnim;

		// Token: 0x0401FF23 RID: 130851
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ULGUIPlayTweenComponent> AnimationList;
	}
}
