using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.FlagChallenge;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02004C23 RID: 19491
	public class FlagChallengeTempExpItem : UiPanelBase
	{
		// Token: 0x060309ED RID: 199149 RVA: 0x00D8D7A4 File Offset: 0x00D8B9A4
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

		// Token: 0x060309EE RID: 199150 RVA: 0x00D8D870 File Offset: 0x00D8BA70
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

		// Token: 0x060309EF RID: 199151 RVA: 0x00D8DA54 File Offset: 0x00D8BC54
		public void Clean()
		{
			this.TweenInComps = null;
			this.TweenOutComps = null;
		}

		// Token: 0x060309F0 RID: 199152 RVA: 0x00D8DA64 File Offset: 0x00D8BC64
		public void SetIndex(int index)
		{
			this.Index = index;
			this.StartProgress = (float)index * 0.1f;
		}

		// Token: 0x060309F1 RID: 199153 RVA: 0x00D8DA7B File Offset: 0x00D8BC7B
		public int GetIndex()
		{
			return this.Index;
		}

		// Token: 0x060309F2 RID: 199154 RVA: 0x00D8DA83 File Offset: 0x00D8BC83
		public bool IsShowItem(float progress)
		{
			return progress > this.StartProgress;
		}

		// Token: 0x060309F3 RID: 199155 RVA: 0x00D8DA8E File Offset: 0x00D8BC8E
		public bool IsHideItem(float progress)
		{
			return progress <= this.StartProgress;
		}

		// Token: 0x060309F4 RID: 199156 RVA: 0x00D8DA9C File Offset: 0x00D8BC9C
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

		// Token: 0x060309F5 RID: 199157 RVA: 0x00D8DAE9 File Offset: 0x00D8BCE9
		public void ShowItem()
		{
			base.SetUiActive(true);
		}

		// Token: 0x060309F6 RID: 199158 RVA: 0x00D8DAF2 File Offset: 0x00D8BCF2
		public void HideItem(bool playAnim = true)
		{
			base.SetUiActive(false);
		}

		// Token: 0x060309F7 RID: 199159 RVA: 0x00D8DAFC File Offset: 0x00D8BCFC
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

		// Token: 0x060309F8 RID: 199160 RVA: 0x00D8DB64 File Offset: 0x00D8BD64
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

		// Token: 0x060309F9 RID: 199161 RVA: 0x00D8DBCC File Offset: 0x00D8BDCC
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

		// Token: 0x060309FA RID: 199162 RVA: 0x00D8DC2C File Offset: 0x00D8BE2C
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

		// Token: 0x060309FB RID: 199163 RVA: 0x00D8DC94 File Offset: 0x00D8BE94
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

		// Token: 0x04019BA6 RID: 105382
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ULGUIPlayTweenComponent> TweenInComps;

		// Token: 0x04019BA7 RID: 105383
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ULGUIPlayTweenComponent> TweenOutComps;

		// Token: 0x04019BA8 RID: 105384
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ULGUIPlayTweenComponent> TweenRedComps;

		// Token: 0x04019BA9 RID: 105385
		[Nullable(2)]
		private UUISprite ArrowSprite;

		// Token: 0x04019BAA RID: 105386
		private int Index;

		// Token: 0x04019BAB RID: 105387
		private float StartProgress;

		// Token: 0x04019BAC RID: 105388
		private bool IsPlayTweenIn;

		// Token: 0x04019BAD RID: 105389
		private bool IsPlayTweenOut;

		// Token: 0x04019BAE RID: 105390
		private bool IsPlayTweenRed;

		// Token: 0x0200A847 RID: 43079
		private enum EComponentType
		{
			// Token: 0x04033FB6 RID: 212918
			ArrowSprite,
			// Token: 0x04033FB7 RID: 212919
			TweenIn,
			// Token: 0x04033FB8 RID: 212920
			TweenOut,
			// Token: 0x04033FB9 RID: 212921
			TweenBreakOff,
			// Token: 0x04033FBA RID: 212922
			TweenRed
		}
	}
}
