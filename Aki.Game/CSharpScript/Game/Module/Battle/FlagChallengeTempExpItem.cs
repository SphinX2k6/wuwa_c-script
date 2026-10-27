using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.FlagChallenge;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02005C43 RID: 23619
	public class FlagChallengeTempExpItem : UiPanelBase
	{
		// Token: 0x0603BAA2 RID: 244386 RVA: 0x00E3D434 File Offset: 0x00E3B634
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603BAA3 RID: 244387 RVA: 0x00E3D500 File Offset: 0x00E3B700
		protected override void OnStart()
		{
			base.OnStart();
			base.SetUiActive(false);
			UUIItem item = base.GetItem(1);
			TArray<UActorComponent> tarray;
			if (item == null)
			{
				tarray = null;
			}
			else
			{
				AActor owner = item.GetOwner();
				tarray = ((owner != null) ? owner.K2_GetComponentsByClass(ULGUIPlayTweenComponent.StaticClass()) : null);
			}
			TArray<UActorComponent> tarray2 = tarray;
			if (tarray2 != null && tarray2.Num() > 0)
			{
				if (this.TweenInComps == null)
				{
					this.TweenInComps = new List<ULGUIPlayTweenComponent>();
				}
				foreach (UActorComponent uactorComponent in tarray2)
				{
					this.TweenInComps.Add((ULGUIPlayTweenComponent)uactorComponent);
				}
			}
			UUIItem item2 = base.GetItem(2);
			TArray<UActorComponent> tarray3;
			if (item2 == null)
			{
				tarray3 = null;
			}
			else
			{
				AActor owner2 = item2.GetOwner();
				tarray3 = ((owner2 != null) ? owner2.K2_GetComponentsByClass(ULGUIPlayTweenComponent.StaticClass()) : null);
			}
			TArray<UActorComponent> tarray4 = tarray3;
			if (tarray4 != null && tarray4.Num() > 0)
			{
				if (this.TweenOutComps == null)
				{
					this.TweenOutComps = new List<ULGUIPlayTweenComponent>();
				}
				foreach (UActorComponent uactorComponent2 in tarray4)
				{
					this.TweenOutComps.Add((ULGUIPlayTweenComponent)uactorComponent2);
				}
			}
			UUIItem item3 = base.GetItem(4);
			TArray<UActorComponent> tarray5;
			if (item3 == null)
			{
				tarray5 = null;
			}
			else
			{
				AActor owner3 = item3.GetOwner();
				tarray5 = ((owner3 != null) ? owner3.K2_GetComponentsByClass(ULGUIPlayTweenComponent.StaticClass()) : null);
			}
			TArray<UActorComponent> tarray6 = tarray5;
			if (tarray6 != null && tarray6.Num() > 0)
			{
				if (this.TweenRedComps == null)
				{
					this.TweenRedComps = new List<ULGUIPlayTweenComponent>();
				}
				foreach (UActorComponent uactorComponent3 in tarray6)
				{
					this.TweenRedComps.Add((ULGUIPlayTweenComponent)uactorComponent3);
				}
			}
			this.ArrowSprite = base.GetSprite(0);
		}

		// Token: 0x0603BAA4 RID: 244388 RVA: 0x00E3D6D0 File Offset: 0x00E3B8D0
		public void Clean()
		{
			this.TweenInComps = null;
			this.TweenOutComps = null;
		}

		// Token: 0x0603BAA5 RID: 244389 RVA: 0x00E3D6E0 File Offset: 0x00E3B8E0
		public void SetIndex(int index)
		{
			this.Index = index;
			this.StartProgress = (float)index * 0.1f;
		}

		// Token: 0x0603BAA6 RID: 244390 RVA: 0x00E3D6F7 File Offset: 0x00E3B8F7
		public int GetIndex()
		{
			return this.Index;
		}

		// Token: 0x0603BAA7 RID: 244391 RVA: 0x00E3D6FF File Offset: 0x00E3B8FF
		public bool IsShowItem(float progress)
		{
			return progress > this.StartProgress;
		}

		// Token: 0x0603BAA8 RID: 244392 RVA: 0x00E3D70A File Offset: 0x00E3B90A
		public bool IsHideItem(float progress)
		{
			return progress <= this.StartProgress;
		}

		// Token: 0x0603BAA9 RID: 244393 RVA: 0x00E3D718 File Offset: 0x00E3B918
		public void Reset()
		{
			if (this.IsPlayTweenOut)
			{
				this.StopTweenOut();
				UUISprite arrowSprite = this.ArrowSprite;
				if (arrowSprite != null)
				{
					arrowSprite.SetAlpha(1f);
				}
			}
			bool isPlayTweenRed = this.IsPlayTweenRed;
			this.IsPlayTweenIn = false;
			this.IsPlayTweenOut = false;
			this.IsPlayTweenRed = false;
		}

		// Token: 0x0603BAAA RID: 244394 RVA: 0x00E3D765 File Offset: 0x00E3B965
		public void ShowItem()
		{
			base.SetUiActive(true);
		}

		// Token: 0x0603BAAB RID: 244395 RVA: 0x00E3D76E File Offset: 0x00E3B96E
		public void HideItem(bool playAnim = true)
		{
			base.SetUiActive(false);
		}

		// Token: 0x0603BAAC RID: 244396 RVA: 0x00E3D778 File Offset: 0x00E3B978
		public void PlayTweenIn()
		{
			if (this.TweenInComps == null || this.IsPlayTweenIn)
			{
				return;
			}
			this.IsPlayTweenIn = true;
			foreach (ULGUIPlayTweenComponent ulguiplayTweenComponent in this.TweenInComps)
			{
				ulguiplayTweenComponent.Play();
			}
		}

		// Token: 0x0603BAAD RID: 244397 RVA: 0x00E3D7E0 File Offset: 0x00E3B9E0
		public void PlayTweenOut()
		{
			if (this.TweenOutComps == null || this.IsPlayTweenOut)
			{
				return;
			}
			this.IsPlayTweenOut = true;
			foreach (ULGUIPlayTweenComponent ulguiplayTweenComponent in this.TweenOutComps)
			{
				ulguiplayTweenComponent.Play();
			}
		}

		// Token: 0x0603BAAE RID: 244398 RVA: 0x00E3D848 File Offset: 0x00E3BA48
		public void PlayTweenRed()
		{
			if (this.TweenRedComps == null)
			{
				return;
			}
			this.IsPlayTweenRed = true;
			foreach (ULGUIPlayTweenComponent ulguiplayTweenComponent in this.TweenRedComps)
			{
				ulguiplayTweenComponent.Play();
			}
		}

		// Token: 0x0603BAAF RID: 244399 RVA: 0x00E3D8A8 File Offset: 0x00E3BAA8
		public void StopTweenOut()
		{
			if (this.TweenOutComps == null || !this.IsPlayTweenOut)
			{
				return;
			}
			this.IsPlayTweenOut = false;
			foreach (ULGUIPlayTweenComponent ulguiplayTweenComponent in this.TweenOutComps)
			{
				ulguiplayTweenComponent.Stop();
			}
		}

		// Token: 0x0603BAB0 RID: 244400 RVA: 0x00E3D910 File Offset: 0x00E3BB10
		public void PlayTweenAnim(EFlagChallengeExpItemTweenAnimType tweenType)
		{
			switch (tweenType)
			{
			case EFlagChallengeExpItemTweenAnimType.In:
				this.PlayTweenIn();
				return;
			case EFlagChallengeExpItemTweenAnimType.Out:
				this.PlayTweenOut();
				return;
			case EFlagChallengeExpItemTweenAnimType.Break:
				break;
			case EFlagChallengeExpItemTweenAnimType.Red:
				this.PlayTweenRed();
				break;
			default:
				return;
			}
		}

		// Token: 0x0401F0F5 RID: 127221
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ULGUIPlayTweenComponent> TweenInComps;

		// Token: 0x0401F0F6 RID: 127222
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ULGUIPlayTweenComponent> TweenOutComps;

		// Token: 0x0401F0F7 RID: 127223
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ULGUIPlayTweenComponent> TweenRedComps;

		// Token: 0x0401F0F8 RID: 127224
		[Nullable(2)]
		private UUISprite ArrowSprite;

		// Token: 0x0401F0F9 RID: 127225
		private int Index;

		// Token: 0x0401F0FA RID: 127226
		private float StartProgress;

		// Token: 0x0401F0FB RID: 127227
		private bool IsPlayTweenIn;

		// Token: 0x0401F0FC RID: 127228
		private bool IsPlayTweenOut;

		// Token: 0x0401F0FD RID: 127229
		private bool IsPlayTweenRed;

		// Token: 0x0200BE3F RID: 48703
		private enum EComponentType
		{
			// Token: 0x040395F3 RID: 234995
			ArrowSprite,
			// Token: 0x040395F4 RID: 234996
			TweenIn,
			// Token: 0x040395F5 RID: 234997
			TweenOut,
			// Token: 0x040395F6 RID: 234998
			TweenBreakOff,
			// Token: 0x040395F7 RID: 234999
			TweenRed
		}
	}
}
