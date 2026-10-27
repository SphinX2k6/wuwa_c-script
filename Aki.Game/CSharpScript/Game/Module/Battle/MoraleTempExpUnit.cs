using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02005C56 RID: 23638
	public class MoraleTempExpUnit : UiPanelBase
	{
		// Token: 0x0603BC0B RID: 244747 RVA: 0x00E45AEC File Offset: 0x00E43CEC
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

		// Token: 0x0603BC0C RID: 244748 RVA: 0x00E45BB8 File Offset: 0x00E43DB8
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

		// Token: 0x0603BC0D RID: 244749 RVA: 0x00E45D6C File Offset: 0x00E43F6C
		public void Clean()
		{
			this.TweenInComps = null;
			this.TweenOutComps = null;
		}

		// Token: 0x0603BC0E RID: 244750 RVA: 0x00E45D7C File Offset: 0x00E43F7C
		public void SetIndex(int index)
		{
			this.Index = index;
			this.StartProgress = (float)index * 0.1f;
		}

		// Token: 0x0603BC0F RID: 244751 RVA: 0x00E45D93 File Offset: 0x00E43F93
		public bool IsShowUnit(float progress)
		{
			return progress > this.StartProgress;
		}

		// Token: 0x0603BC10 RID: 244752 RVA: 0x00E45D9E File Offset: 0x00E43F9E
		public bool IsHideUnit(float progress)
		{
			return progress <= this.StartProgress;
		}

		// Token: 0x0603BC11 RID: 244753 RVA: 0x00E45DAC File Offset: 0x00E43FAC
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

		// Token: 0x0603BC12 RID: 244754 RVA: 0x00E45DF9 File Offset: 0x00E43FF9
		public void ShowUnit()
		{
			base.SetUiActive(true);
		}

		// Token: 0x0603BC13 RID: 244755 RVA: 0x00E45E02 File Offset: 0x00E44002
		public void HideUnit(bool playAnim = true)
		{
			base.SetUiActive(false);
		}

		// Token: 0x0603BC14 RID: 244756 RVA: 0x00E45E0C File Offset: 0x00E4400C
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

		// Token: 0x0603BC15 RID: 244757 RVA: 0x00E45E74 File Offset: 0x00E44074
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

		// Token: 0x0603BC16 RID: 244758 RVA: 0x00E45EDC File Offset: 0x00E440DC
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

		// Token: 0x0603BC17 RID: 244759 RVA: 0x00E45F3C File Offset: 0x00E4413C
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

		// Token: 0x0603BC18 RID: 244760 RVA: 0x00E45FA4 File Offset: 0x00E441A4
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

		// Token: 0x0401F1D0 RID: 127440
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ULGUIPlayTweenComponent> TweenInComps;

		// Token: 0x0401F1D1 RID: 127441
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ULGUIPlayTweenComponent> TweenOutComps;

		// Token: 0x0401F1D2 RID: 127442
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ULGUIPlayTweenComponent> TweenRedComps;

		// Token: 0x0401F1D3 RID: 127443
		[Nullable(2)]
		private UUISprite ArrowSprite;

		// Token: 0x0401F1D4 RID: 127444
		public int Index;

		// Token: 0x0401F1D5 RID: 127445
		private float StartProgress;

		// Token: 0x0401F1D6 RID: 127446
		private bool IsPlayTweenIn;

		// Token: 0x0401F1D7 RID: 127447
		private bool IsPlayTweenOut;

		// Token: 0x0401F1D8 RID: 127448
		private bool IsPlayTweenRed;

		// Token: 0x0200BE6D RID: 48749
		private enum EUnitChildType
		{
			// Token: 0x040396D1 RID: 235217
			ArrowSprite,
			// Token: 0x040396D2 RID: 235218
			TweenIn,
			// Token: 0x040396D3 RID: 235219
			TweenOut,
			// Token: 0x040396D4 RID: 235220
			TweenBreakOff,
			// Token: 0x040396D5 RID: 235221
			TweenRed
		}
	}
}
