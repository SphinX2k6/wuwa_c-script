using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuickHack.View
{
	// Token: 0x02004F91 RID: 20369
	[NullableContext(2)]
	[Nullable(0)]
	public class QuickHackRamBar
	{
		// Token: 0x0603428F RID: 213647 RVA: 0x00C3E73C File Offset: 0x00C3C93C
		[NullableContext(1)]
		public void Init(UUISprite darkBlueSprite, UUISprite blueSprite, UUISprite redSpriteA, UUISprite redSpriteB, UUIItem ramItem, [Nullable(2)] UCurveFloat selectedCurve)
		{
			this.IsInit = true;
			this.DarkBlueSprite = darkBlueSprite;
			this.BlueSprite = blueSprite;
			this.RedSpriteA = redSpriteA;
			this.RedSpriteB = redSpriteB;
			this.RamItem = ramItem;
			if (selectedCurve != null && selectedCurve.IsValid())
			{
				this.SelectedRamFrameInterval = 16f;
				this.SelectedCurve = selectedCurve;
			}
			TArray<UActorComponent> tarray = ramItem.GetOwner().K2_GetComponentsByClass(ULGUIPlayTweenComponent.StaticClass());
			int num = tarray.Num();
			for (int i = 0; i < num; i++)
			{
				this.RamItemAnimList.Add(tarray.Get(i) as ULGUIPlayTweenComponent);
			}
			if (this.RamItemAnimList.Count > 0)
			{
				ULGUIPlayTween playTween = this.RamItemAnimList[0].GetPlayTween();
				if (playTween != null)
				{
					FLGUIPlayTweenCompleteDynamicDelegate flguiplayTweenCompleteDynamicDelegate = DelegateUtils.ToManualReleaseDelegate<FLGUIPlayTweenCompleteDynamicDelegate>(new Action(this.NextReduceRamAnim));
					this.Wrapper = playTween.RegisterOnComplete(flguiplayTweenCompleteDynamicDelegate);
					this.CallbackTween = playTween;
				}
			}
		}

		// Token: 0x06034290 RID: 213648 RVA: 0x00C3E824 File Offset: 0x00C3CA24
		public void Clear()
		{
			this.IsInit = false;
			this.Current = 0;
			this.Max = 0;
			this.Used = 0;
			this.Selected = 0;
			this.DarkBlueSprite = null;
			this.BlueSprite = null;
			this.RedSpriteA = null;
			this.RedSpriteB = null;
			this.RamItem = null;
			this.PlayingReduceRamSize = 0;
			this.SelectedCurve = null;
			this.SelectedRamFrameInterval = 0f;
			this.IsPlayingRamSelected = false;
			this.PlayingRamSelectedDuration = 0f;
			this.PlayingReduceRamIndex = -1;
			this.PlayingReduceRamSize = 0;
			foreach (ULGUIPlayTweenComponent ulguiplayTweenComponent in this.RamItemAnimList)
			{
				ulguiplayTweenComponent.Stop();
			}
			this.RamItemAnimList.Clear();
			if (this.CallbackTween != null && this.Wrapper != null)
			{
				this.CallbackTween.UnregisterOnComplete(this.Wrapper);
			}
			this.CallbackTween = null;
			this.Wrapper = null;
			DelegateUtils.ReleaseManualReleaseDelegate(new Action(this.NextReduceRamAnim));
		}

		// Token: 0x06034291 RID: 213649 RVA: 0x00C3E944 File Offset: 0x00C3CB44
		public void TickRamBar(float delta)
		{
			if (this.IsInit && this.IsPlayingRamSelected)
			{
				UCurveFloat selectedCurve = this.SelectedCurve;
				if (selectedCurve != null && selectedCurve.IsValid() && this.SelectedRamFrameInterval > 0f)
				{
					float inTime = this.PlayingRamSelectedDuration / this.SelectedRamFrameInterval % 34f;
					float floatValue = this.SelectedCurve.GetFloatValue(inTime);
					float anchorOffsetY = MathUtils.Instance.RangeClamp(floatValue, 0f, 1f, 0f, 6f);
					this.BlueSprite.SetAnchorOffsetY(anchorOffsetY);
					this.PlayingRamSelectedDuration += delta;
					return;
				}
			}
		}

		// Token: 0x06034292 RID: 213650 RVA: 0x00C3E9E4 File Offset: 0x00C3CBE4
		public void RefreshRam(int current, int max, bool playReduceAnim = false)
		{
			if (!this.IsInit)
			{
				return;
			}
			if (current < 0 || max < 0 || current > max)
			{
				return;
			}
			if (this.Current == current && this.Max == max)
			{
				return;
			}
			int reduceSize = (current < this.Current) ? (this.Current - current) : 0;
			this.Current = current;
			this.Max = max;
			this.Used = ((this.Max > this.Current) ? (this.Max - this.Current) : 0);
			this.RefreshAllRamView(playReduceAnim, reduceSize);
		}

		// Token: 0x06034293 RID: 213651 RVA: 0x00C3EA69 File Offset: 0x00C3CC69
		public void SelectRam(int value)
		{
			if (!this.IsInit)
			{
				return;
			}
			if (this.Selected == value)
			{
				return;
			}
			this.Selected = value;
			this.RefreshEnableRamView();
			if (value > 0)
			{
				this.StartRamSelectedAnim();
				return;
			}
			this.StopRamSelectedAnim();
		}

		// Token: 0x06034294 RID: 213652 RVA: 0x00C3EA9C File Offset: 0x00C3CC9C
		private void RefreshEnableRamView()
		{
			float leftX = this.GetLeftX();
			int num = (this.Current > this.Selected) ? (this.Current - this.Selected) : 0;
			this.UpdateItem(this.DarkBlueSprite, leftX, 0, num, true);
			this.UpdateItem(this.BlueSprite, leftX, num, this.Selected, true);
		}

		// Token: 0x06034295 RID: 213653 RVA: 0x00C3EAF4 File Offset: 0x00C3CCF4
		private void RefreshAllRamView(bool playReduceAnim = false, int reduceSize = 0)
		{
			float leftX = this.GetLeftX();
			int num = (this.Current > this.Selected) ? (this.Current - this.Selected) : 0;
			this.UpdateItem(this.DarkBlueSprite, leftX, 0, num, true);
			this.UpdateItem(this.BlueSprite, leftX, num, this.Selected, true);
			if (playReduceAnim && reduceSize > 0)
			{
				this.StartReduceRamAnim(reduceSize);
				return;
			}
			if (this.IsPlayingReduceRam)
			{
				int num2 = this.PlayingReduceRamIndex - this.Current;
				if (num2 >= 0)
				{
					this.UpdateItem(this.RedSpriteA, leftX, this.Current, num2, true);
					return;
				}
				foreach (ULGUIPlayTweenComponent ulguiplayTweenComponent in this.RamItemAnimList)
				{
					ulguiplayTweenComponent.Stop();
				}
			}
			this.StopReduceRamAnim();
		}

		// Token: 0x06034296 RID: 213654 RVA: 0x00C3EBD4 File Offset: 0x00C3CDD4
		private void StartRamSelectedAnim()
		{
			if (this.IsPlayingRamSelected)
			{
				return;
			}
			this.IsPlayingRamSelected = true;
			this.BlueSprite.SetAnchorOffsetY(0f);
			this.PlayingRamSelectedDuration = 0f;
		}

		// Token: 0x06034297 RID: 213655 RVA: 0x00C3EC01 File Offset: 0x00C3CE01
		private void StopRamSelectedAnim()
		{
			if (!this.IsPlayingRamSelected)
			{
				return;
			}
			this.IsPlayingRamSelected = false;
		}

		// Token: 0x06034298 RID: 213656 RVA: 0x00C3EC14 File Offset: 0x00C3CE14
		private void StartReduceRamAnim(int reduceSize)
		{
			if (this.IsPlayingReduceRam)
			{
				this.PlayingReduceRamSize += reduceSize;
				int num = this.PlayingReduceRamIndex - this.Current;
				if (num >= 0)
				{
					this.UpdateItem(this.RedSpriteA, this.GetLeftX(), this.Current, num, true);
				}
				return;
			}
			this.IsPlayingReduceRam = true;
			this.RedSpriteA.SetUIActive(true);
			this.RamItem.SetUIActive(true);
			this.PlayingReduceRamIndex = this.Current + reduceSize - 1;
			this.PlayingReduceRamSize += reduceSize;
			this.NextReduceRamAnim();
		}

		// Token: 0x06034299 RID: 213657 RVA: 0x00C3ECA8 File Offset: 0x00C3CEA8
		private void NextReduceRamAnim()
		{
			if (!this.IsInit || !this.IsPlayingReduceRam)
			{
				return;
			}
			if (this.PlayingReduceRamSize <= 0)
			{
				this.StopReduceRamAnim();
				return;
			}
			int num = this.PlayingReduceRamIndex - this.Current;
			if (num < 0)
			{
				this.StopReduceRamAnim();
				return;
			}
			this.PlayingReduceRamIndex--;
			this.PlayingReduceRamSize--;
			float leftX = this.GetLeftX();
			this.UpdateItem(this.RedSpriteA, leftX, this.Current, num, true);
			int num2 = this.Current + num;
			this.UpdateItem(this.RamItem, leftX, num2, 1, false);
			foreach (ULGUIPlayTweenComponent ulguiplayTweenComponent in this.RamItemAnimList)
			{
				ulguiplayTweenComponent.Play();
			}
			int size = this.Used - num - 1;
			this.UpdateItem(this.RedSpriteB, leftX, num2 + 1, size, true);
		}

		// Token: 0x0603429A RID: 213658 RVA: 0x00C3EDA4 File Offset: 0x00C3CFA4
		private void StopReduceRamAnim()
		{
			this.IsPlayingReduceRam = false;
			this.UpdateItem(this.RedSpriteB, this.GetLeftX(), this.Current, this.Used, true);
			this.RedSpriteA.SetUIActive(false);
			this.RamItem.SetUIActive(false);
			this.PlayingReduceRamIndex = -1;
			this.PlayingReduceRamSize = 0;
		}

		// Token: 0x0603429B RID: 213659 RVA: 0x00C3EDFD File Offset: 0x00C3CFFD
		private float GetLeftX()
		{
			return -((float)this.Max / 2f) * 28f;
		}

		// Token: 0x0603429C RID: 213660 RVA: 0x00C3EE14 File Offset: 0x00C3D014
		[NullableContext(1)]
		private void UpdateItem(UUIItem item, float startX, int preSize, int size, bool updateWidth = true)
		{
			float num = (float)(size * 28);
			float anchorOffsetX = startX + (float)(preSize * 28) + num / 2f;
			item.SetAnchorOffsetX(anchorOffsetX);
			if (updateWidth)
			{
				item.SetWidth(num);
			}
		}

		// Token: 0x0401BB9B RID: 113563
		private bool IsInit;

		// Token: 0x0401BB9C RID: 113564
		private int Current;

		// Token: 0x0401BB9D RID: 113565
		private int Max;

		// Token: 0x0401BB9E RID: 113566
		private int Used;

		// Token: 0x0401BB9F RID: 113567
		private int Selected;

		// Token: 0x0401BBA0 RID: 113568
		private UUISprite DarkBlueSprite;

		// Token: 0x0401BBA1 RID: 113569
		private UUISprite BlueSprite;

		// Token: 0x0401BBA2 RID: 113570
		private UUISprite RedSpriteA;

		// Token: 0x0401BBA3 RID: 113571
		private UUISprite RedSpriteB;

		// Token: 0x0401BBA4 RID: 113572
		private UUIItem RamItem;

		// Token: 0x0401BBA5 RID: 113573
		private UCurveFloat SelectedCurve;

		// Token: 0x0401BBA6 RID: 113574
		private float SelectedRamFrameInterval;

		// Token: 0x0401BBA7 RID: 113575
		private bool IsPlayingRamSelected;

		// Token: 0x0401BBA8 RID: 113576
		private float PlayingRamSelectedDuration;

		// Token: 0x0401BBA9 RID: 113577
		private bool IsPlayingReduceRam;

		// Token: 0x0401BBAA RID: 113578
		private int PlayingReduceRamIndex = -1;

		// Token: 0x0401BBAB RID: 113579
		private int PlayingReduceRamSize;

		// Token: 0x0401BBAC RID: 113580
		[Nullable(1)]
		private readonly List<ULGUIPlayTweenComponent> RamItemAnimList = new List<ULGUIPlayTweenComponent>();

		// Token: 0x0401BBAD RID: 113581
		private ULGUIPlayTween CallbackTween;

		// Token: 0x0401BBAE RID: 113582
		private FLGUIDelegateHandleWrapper Wrapper;
	}
}
