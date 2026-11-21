using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DFF RID: 19967
	[NullableContext(2)]
	[Nullable(0)]
	public class SpecialEnergyBaIconHandle
	{
		// Token: 0x060323B6 RID: 205750 RVA: 0x00E14A76 File Offset: 0x00E12C76
		[NullableContext(1)]
		public void Init(UUITexture[] iconTextureList, [Nullable(2)] UUIItem animItem = null)
		{
			this.IconTextureList = iconTextureList;
			this.AnimItem = animItem;
		}

		// Token: 0x060323B7 RID: 205751 RVA: 0x00E14A88 File Offset: 0x00E12C88
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

		// Token: 0x060323B8 RID: 205752 RVA: 0x00E14AE0 File Offset: 0x00E12CE0
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

		// Token: 0x060323B9 RID: 205753 RVA: 0x00E14BAC File Offset: 0x00E12DAC
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

		// Token: 0x060323BA RID: 205754 RVA: 0x00E14C1A File Offset: 0x00E12E1A
		public void OnBeforeDestroy()
		{
			this.PlayEndAnim(false);
			if (this.LoadIconId != -1)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.LoadIconId);
				this.LoadIconId = -1;
			}
		}

		// Token: 0x0401A9E6 RID: 109030
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private UUITexture[] IconTextureList;

		// Token: 0x0401A9E7 RID: 109031
		private UUIItem AnimItem;

		// Token: 0x0401A9E8 RID: 109032
		private int LoadIconId = -1;

		// Token: 0x0401A9E9 RID: 109033
		private bool IsPlayingEndAnim;

		// Token: 0x0401A9EA RID: 109034
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ULGUIPlayTweenComponent> AnimationList;
	}
}
