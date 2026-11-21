using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuickHack.View
{
	// Token: 0x02003F5A RID: 16218
	[NullableContext(2)]
	[Nullable(0)]
	public class QuickHackRamBar
	{
		// Token: 0x060290FD RID: 168189 RVA: 0x00B87EE8 File Offset: 0x00B860E8
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

		// Token: 0x060290FE RID: 168190 RVA: 0x00B87FD0 File Offset: 0x00B861D0
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

		// Token: 0x060290FF RID: 168191 RVA: 0x00B880F0 File Offset: 0x00B862F0
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

		// Token: 0x06029100 RID: 168192 RVA: 0x00B88190 File Offset: 0x00B86390
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

		// Token: 0x06029101 RID: 168193 RVA: 0x00B88215 File Offset: 0x00B86415
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

		// Token: 0x06029102 RID: 168194 RVA: 0x00B88248 File Offset: 0x00B86448
		private void RefreshEnableRamView()
		{
			float leftX = this.GetLeftX();
			int num = (this.Current > this.Selected) ? (this.Current - this.Selected) : 0;
			this.UpdateItem(this.DarkBlueSprite, leftX, 0, num, true);
			this.UpdateItem(this.BlueSprite, leftX, num, this.Selected, true);
		}

		// Token: 0x06029103 RID: 168195 RVA: 0x00B882A0 File Offset: 0x00B864A0
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

		// Token: 0x06029104 RID: 168196 RVA: 0x00B88380 File Offset: 0x00B86580
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

		// Token: 0x06029105 RID: 168197 RVA: 0x00B883AD File Offset: 0x00B865AD
		private void StopRamSelectedAnim()
		{
			if (!this.IsPlayingRamSelected)
			{
				return;
			}
			this.IsPlayingRamSelected = false;
		}

		// Token: 0x06029106 RID: 168198 RVA: 0x00B883C0 File Offset: 0x00B865C0
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

		// Token: 0x06029107 RID: 168199 RVA: 0x00B88454 File Offset: 0x00B86654
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

		// Token: 0x06029108 RID: 168200 RVA: 0x00B88550 File Offset: 0x00B86750
		private void StopReduceRamAnim()
		{
			this.IsPlayingReduceRam = false;
			this.UpdateItem(this.RedSpriteB, this.GetLeftX(), this.Current, this.Used, true);
			this.RedSpriteA.SetUIActive(false);
			this.RamItem.SetUIActive(false);
			this.PlayingReduceRamIndex = -1;
			this.PlayingReduceRamSize = 0;
		}

		// Token: 0x06029109 RID: 168201 RVA: 0x00B885A9 File Offset: 0x00B867A9
		private float GetLeftX()
		{
			return -((float)this.Max / 2f) * 28f;
		}

		// Token: 0x0602910A RID: 168202 RVA: 0x00B885C0 File Offset: 0x00B867C0
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

		// Token: 0x04016570 RID: 91504
		private bool IsInit;

		// Token: 0x04016571 RID: 91505
		private int Current;

		// Token: 0x04016572 RID: 91506
		private int Max;

		// Token: 0x04016573 RID: 91507
		private int Used;

		// Token: 0x04016574 RID: 91508
		private int Selected;

		// Token: 0x04016575 RID: 91509
		private UUISprite DarkBlueSprite;

		// Token: 0x04016576 RID: 91510
		private UUISprite BlueSprite;

		// Token: 0x04016577 RID: 91511
		private UUISprite RedSpriteA;

		// Token: 0x04016578 RID: 91512
		private UUISprite RedSpriteB;

		// Token: 0x04016579 RID: 91513
		private UUIItem RamItem;

		// Token: 0x0401657A RID: 91514
		private UCurveFloat SelectedCurve;

		// Token: 0x0401657B RID: 91515
		private float SelectedRamFrameInterval;

		// Token: 0x0401657C RID: 91516
		private bool IsPlayingRamSelected;

		// Token: 0x0401657D RID: 91517
		private float PlayingRamSelectedDuration;

		// Token: 0x0401657E RID: 91518
		private bool IsPlayingReduceRam;

		// Token: 0x0401657F RID: 91519
		private int PlayingReduceRamIndex = -1;

		// Token: 0x04016580 RID: 91520
		private int PlayingReduceRamSize;

		// Token: 0x04016581 RID: 91521
		[Nullable(1)]
		private readonly List<ULGUIPlayTweenComponent> RamItemAnimList = new List<ULGUIPlayTweenComponent>();

		// Token: 0x04016582 RID: 91522
		private ULGUIPlayTween CallbackTween;

		// Token: 0x04016583 RID: 91523
		private FLGUIDelegateHandleWrapper Wrapper;
	}
}
