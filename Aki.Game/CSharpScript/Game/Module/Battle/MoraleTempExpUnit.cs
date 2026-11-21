using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02004C36 RID: 19510
	public class MoraleTempExpUnit : UiPanelBase
	{
		// Token: 0x06030B56 RID: 199510 RVA: 0x00D95EB8 File Offset: 0x00D940B8
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

		// Token: 0x06030B57 RID: 199511 RVA: 0x00D95F84 File Offset: 0x00D94184
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
			if (tarray2 != null)
			{
				foreach (UActorComponent uactorComponent in tarray2)
				{
					if (this.TweenInComps == null)
					{
						this.TweenInComps = new List<ULGUIPlayTweenComponent>();
					}
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
			if (tarray4 != null)
			{
				foreach (UActorComponent uactorComponent2 in tarray4)
				{
					if (this.TweenOutComps == null)
					{
						this.TweenOutComps = new List<ULGUIPlayTweenComponent>();
					}
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
			if (tarray6 != null)
			{
				foreach (UActorComponent uactorComponent3 in tarray6)
				{
					if (this.TweenRedComps == null)
					{
						this.TweenRedComps = new List<ULGUIPlayTweenComponent>();
					}
					this.TweenRedComps.Add((ULGUIPlayTweenComponent)uactorComponent3);
				}
			}
			this.ArrowSprite = base.GetSprite(0);
		}

		// Token: 0x06030B58 RID: 199512 RVA: 0x00D9614C File Offset: 0x00D9434C
		public void Clean()
		{
			this.TweenInComps = null;
			this.TweenOutComps = null;
		}

		// Token: 0x06030B59 RID: 199513 RVA: 0x00D9615C File Offset: 0x00D9435C
		public void SetIndex(int index)
		{
			this.Index = index;
			this.StartProgress = (float)index * 0.1f;
		}

		// Token: 0x06030B5A RID: 199514 RVA: 0x00D96173 File Offset: 0x00D94373
		public bool IsShowUnit(float progress)
		{
			return progress > this.StartProgress;
		}

		// Token: 0x06030B5B RID: 199515 RVA: 0x00D9617E File Offset: 0x00D9437E
		public bool IsHideUnit(float progress)
		{
			return progress <= this.StartProgress;
		}

		// Token: 0x06030B5C RID: 199516 RVA: 0x00D9618C File Offset: 0x00D9438C
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

		// Token: 0x06030B5D RID: 199517 RVA: 0x00D961D9 File Offset: 0x00D943D9
		public void ShowUnit()
		{
			base.SetUiActive(true);
		}

		// Token: 0x06030B5E RID: 199518 RVA: 0x00D961E2 File Offset: 0x00D943E2
		public void HideUnit(bool playAnim = true)
		{
			base.SetUiActive(false);
		}

		// Token: 0x06030B5F RID: 199519 RVA: 0x00D961EC File Offset: 0x00D943EC
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

		// Token: 0x06030B60 RID: 199520 RVA: 0x00D96254 File Offset: 0x00D94454
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

		// Token: 0x06030B61 RID: 199521 RVA: 0x00D962BC File Offset: 0x00D944BC
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

		// Token: 0x06030B62 RID: 199522 RVA: 0x00D9631C File Offset: 0x00D9451C
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

		// Token: 0x06030B63 RID: 199523 RVA: 0x00D96384 File Offset: 0x00D94584
		public void PlayTweenAnim(MoraleTempExpView.ETweenAnimType tweenType)
		{
			switch (tweenType)
			{
			case MoraleTempExpView.ETweenAnimType.In:
				this.PlayTweenIn();
				return;
			case MoraleTempExpView.ETweenAnimType.Out:
				this.PlayTweenOut();
				return;
			case MoraleTempExpView.ETweenAnimType.Break:
				break;
			case MoraleTempExpView.ETweenAnimType.Red:
				this.PlayTweenRed();
				break;
			default:
				return;
			}
		}

		// Token: 0x04019C81 RID: 105601
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ULGUIPlayTweenComponent> TweenInComps;

		// Token: 0x04019C82 RID: 105602
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ULGUIPlayTweenComponent> TweenOutComps;

		// Token: 0x04019C83 RID: 105603
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ULGUIPlayTweenComponent> TweenRedComps;

		// Token: 0x04019C84 RID: 105604
		[Nullable(2)]
		private UUISprite ArrowSprite;

		// Token: 0x04019C85 RID: 105605
		public int Index;

		// Token: 0x04019C86 RID: 105606
		private float StartProgress;

		// Token: 0x04019C87 RID: 105607
		private bool IsPlayTweenIn;

		// Token: 0x04019C88 RID: 105608
		private bool IsPlayTweenOut;

		// Token: 0x04019C89 RID: 105609
		private bool IsPlayTweenRed;

		// Token: 0x0200A873 RID: 43123
		private enum EUnitChildType
		{
			// Token: 0x04034092 RID: 213138
			ArrowSprite,
			// Token: 0x04034093 RID: 213139
			TweenIn,
			// Token: 0x04034094 RID: 213140
			TweenOut,
			// Token: 0x04034095 RID: 213141
			TweenBreakOff,
			// Token: 0x04034096 RID: 213142
			TweenRed
		}
	}
}
