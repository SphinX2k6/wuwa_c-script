using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi
{
	// Token: 0x02003C8C RID: 15500
	[NullableContext(2)]
	[Nullable(0)]
	public class RoleElementDragger
	{
		// Token: 0x06027A54 RID: 162388 RVA: 0x00B1A5EC File Offset: 0x00B187EC
		[NullableContext(1)]
		public RoleElementDragger(UUIDraggableComponent dragComponent, UUIItem panel, UUIItem attachItem, List<UUIItem> elementItems)
		{
			this.DragComponent = dragComponent;
			this.Panel = panel;
			this.AttachItem = attachItem;
			this.ElementItems = elementItems;
			int count = this.ElementItems.Count;
			this.BaseXList = new float[count];
			for (int i = 0; i < count; i++)
			{
				this.BaseXList[i] = this.ElementItems[i].GetAnchorOffsetX();
			}
			this.AttachX = this.CalcAttachX();
			this.DragComponent.OnPointerBeginDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPanelBeginDrag));
			this.DragComponent.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPanelDrag));
			this.DragComponent.OnPointerEndDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPanelEndDrag));
			this.DragComponent.NavigateToPrevDelegate.Bind(new Action(this.OnNavigatePrev));
			this.DragComponent.NavigateToNextDelegate.Bind(new Action(this.OnNavigateNext));
		}

		// Token: 0x06027A55 RID: 162389 RVA: 0x00B1A727 File Offset: 0x00B18927
		private void OnNavigatePrev()
		{
			this.NavigateStep(-1);
		}

		// Token: 0x06027A56 RID: 162390 RVA: 0x00B1A730 File Offset: 0x00B18930
		private void OnNavigateNext()
		{
			this.NavigateStep(1);
		}

		// Token: 0x06027A57 RID: 162391 RVA: 0x00B1A73C File Offset: 0x00B1893C
		private void NavigateStep(int direction)
		{
			Func<bool> canNavigate = this.CanNavigate;
			if (canNavigate != null && !canNavigate())
			{
				return;
			}
			if (this.EaseTickId != -1 || this.DragState)
			{
				return;
			}
			int num = this.GetCurAttachedIndex() + direction;
			if (num < 0 || num >= this.ElementItems.Count)
			{
				return;
			}
			this.AttachByIndex(num, true);
		}

		// Token: 0x06027A58 RID: 162392 RVA: 0x00B1A797 File Offset: 0x00B18997
		public void SetAttachThreshold(float threshold)
		{
			this.AttachThreshold = threshold;
		}

		// Token: 0x06027A59 RID: 162393 RVA: 0x00B1A7A0 File Offset: 0x00B189A0
		public void SetEaseDuration(float duration)
		{
			this.EaseDuration = duration;
		}

		// Token: 0x06027A5A RID: 162394 RVA: 0x00B1A7A9 File Offset: 0x00B189A9
		public void SetChangeSpeed(int speed)
		{
			this.ChangeSpeed = (float)speed * 0.01f;
		}

		// Token: 0x06027A5B RID: 162395 RVA: 0x00B1A7B9 File Offset: 0x00B189B9
		[NullableContext(1)]
		public void SetTrajectoryCurve(string path)
		{
			ResourceSystem.Instance.LoadAsync<UCurveFloat>(path, delegate([Nullable(2)] UCurveFloat curve, string _)
			{
				this.TrajectoryCurve = curve;
				this.ApplyLayout();
			}, 100, "js_undefined");
		}

		// Token: 0x06027A5C RID: 162396 RVA: 0x00B1A7DA File Offset: 0x00B189DA
		[NullableContext(1)]
		public void SetAlphaCurve(string path)
		{
			ResourceSystem.Instance.LoadAsync<UCurveFloat>(path, delegate([Nullable(2)] UCurveFloat curve, string _)
			{
				this.AlphaCurve = curve;
				this.ApplyLayout();
			}, 100, "js_undefined");
		}

		// Token: 0x06027A5D RID: 162397 RVA: 0x00B1A7FB File Offset: 0x00B189FB
		[NullableContext(1)]
		public void SetScaleCurve(string path)
		{
			ResourceSystem.Instance.LoadAsync<UCurveFloat>(path, delegate([Nullable(2)] UCurveFloat curve, string _)
			{
				this.ScaleCurve = curve;
				this.ApplyLayout();
			}, 100, "js_undefined");
		}

		// Token: 0x06027A5E RID: 162398 RVA: 0x00B1A81C File Offset: 0x00B18A1C
		private float CalcAttachX()
		{
			if (this.ElementItems.Count == 0)
			{
				return 0f;
			}
			FVector lguispaceCenterAbsolutePosition = this.ElementItems[0].GetLGUISpaceCenterAbsolutePosition();
			FVector lguispaceCenterAbsolutePosition2 = this.AttachItem.GetLGUISpaceCenterAbsolutePosition();
			return this.BaseXList[0] + (lguispaceCenterAbsolutePosition2.X - lguispaceCenterAbsolutePosition.X);
		}

		// Token: 0x06027A5F RID: 162399 RVA: 0x00B1A870 File Offset: 0x00B18A70
		public int GetCurAttachedIndex()
		{
			return this.CurAttachedIndex;
		}

		// Token: 0x06027A60 RID: 162400 RVA: 0x00B1A878 File Offset: 0x00B18A78
		public void AttachByIndex(int index, bool animate = true)
		{
			if (index == this.CurAttachedIndex)
			{
				return;
			}
			this.DragState = false;
			if (this.CandidateIndex >= 0)
			{
				Action<int> onCandidateExit = this.OnCandidateExit;
				if (onCandidateExit != null)
				{
					onCandidateExit(this.CandidateIndex);
				}
				this.CandidateIndex = -1;
			}
			if (this.CurAttachedIndex >= 0 && this.CurAttachedIndex != index)
			{
				Action<int> onCurrentItemUndock = this.OnCurrentItemUndock;
				if (onCurrentItemUndock != null)
				{
					onCurrentItemUndock(this.CurAttachedIndex);
				}
			}
			this.SnapToIndex(index, true, animate, animate);
		}

		// Token: 0x06027A61 RID: 162401 RVA: 0x00B1A8F0 File Offset: 0x00B18AF0
		private void OnPanelBeginDrag(ULGUIPointerEventData eventData)
		{
			this.RemoveEaseTick();
			this.DragState = true;
			ValueTuple<double, double> pointerLguiPos = this.GetPointerLguiPos();
			this.StartPointerX = pointerLguiPos.Item1;
			this.StartScrollX = this.ScrollX;
			this.CurUndocked = false;
			this.CandidateIndex = -1;
		}

		// Token: 0x06027A62 RID: 162402 RVA: 0x00B1A938 File Offset: 0x00B18B38
		private void OnPanelDrag(ULGUIPointerEventData eventData)
		{
			if (!this.DragState)
			{
				return;
			}
			double item = this.GetPointerLguiPos().Item1;
			this.ScrollX = (float)((double)this.StartScrollX + (double)this.ChangeSpeed * (item - this.StartPointerX));
			this.ApplyLayout();
			this.UpdateThresholdState();
		}

		// Token: 0x06027A63 RID: 162403 RVA: 0x00B1A988 File Offset: 0x00B18B88
		private void OnPanelEndDrag(ULGUIPointerEventData eventData)
		{
			if (!this.DragState)
			{
				return;
			}
			this.DragState = false;
			if (!this.CurUndocked && this.CurAttachedIndex >= 0)
			{
				this.StartEase(this.DockedScrollX, null, false);
				return;
			}
			int num = this.FindNearestIndex();
			if (num >= 0)
			{
				this.SnapToIndex(num, true, true, true);
			}
		}

		// Token: 0x06027A64 RID: 162404 RVA: 0x00B1A9DC File Offset: 0x00B18BDC
		private void ApplyLayout()
		{
			for (int i = 0; i < this.ElementItems.Count; i++)
			{
				float num = this.BaseXList[i] + this.ScrollX;
				this.ElementItems[i].SetAnchorOffsetX(num);
				if (this.TrajectoryCurve != null)
				{
					this.ElementItems[i].SetAnchorOffsetY(this.TrajectoryCurve.GetFloatValue(num));
				}
				if (this.AlphaCurve != null)
				{
					Action<int, float> onItemAlphaChange = this.OnItemAlphaChange;
					if (onItemAlphaChange != null)
					{
						onItemAlphaChange(i, this.AlphaCurve.GetFloatValue(num));
					}
				}
				if (this.ScaleCurve != null)
				{
					this.ElementItems[i].SetUIItemScale(new FVector(this.ScaleCurve.GetFloatValue(num)));
				}
			}
		}

		// Token: 0x06027A65 RID: 162405 RVA: 0x00B1AA9C File Offset: 0x00B18C9C
		private float ItemX(int index)
		{
			return this.BaseXList[index] + this.ScrollX;
		}

		// Token: 0x06027A66 RID: 162406 RVA: 0x00B1AAAD File Offset: 0x00B18CAD
		private void UpdateThresholdState()
		{
			if (!this.CurUndocked)
			{
				if (this.IsAttachedInThreshold())
				{
					return;
				}
				this.CurUndocked = true;
				Action<int> onCurrentItemUndock = this.OnCurrentItemUndock;
				if (onCurrentItemUndock != null)
				{
					onCurrentItemUndock(this.CurAttachedIndex);
				}
			}
			this.UpdateCandidateState();
		}

		// Token: 0x06027A67 RID: 162407 RVA: 0x00B1AAE8 File Offset: 0x00B18CE8
		private void UpdateCandidateState()
		{
			int num = this.FindNearestInThreshold();
			if (num != this.CandidateIndex)
			{
				if (this.CandidateIndex >= 0)
				{
					Action<int> onCandidateExit = this.OnCandidateExit;
					if (onCandidateExit != null)
					{
						onCandidateExit(this.CandidateIndex);
					}
				}
				this.CandidateIndex = num;
				if (this.CandidateIndex >= 0)
				{
					Action<int> onCandidateEnter = this.OnCandidateEnter;
					if (onCandidateEnter == null)
					{
						return;
					}
					onCandidateEnter(this.CandidateIndex);
				}
			}
		}

		// Token: 0x06027A68 RID: 162408 RVA: 0x00B1AB4B File Offset: 0x00B18D4B
		private bool IsAttachedInThreshold()
		{
			return this.CurAttachedIndex >= 0 && this.CurAttachedIndex < this.ElementItems.Count && MathF.Abs(this.ItemX(this.CurAttachedIndex) - this.AttachX) < this.AttachThreshold;
		}

		// Token: 0x06027A69 RID: 162409 RVA: 0x00B1AB8C File Offset: 0x00B18D8C
		private int FindNearestInThreshold()
		{
			int result = -1;
			float num = float.MaxValue;
			for (int i = 0; i < this.ElementItems.Count; i++)
			{
				float num2 = MathF.Abs(this.ItemX(i) - this.AttachX);
				if (num2 < this.AttachThreshold && num2 < num)
				{
					num = num2;
					result = i;
				}
			}
			return result;
		}

		// Token: 0x06027A6A RID: 162410 RVA: 0x00B1ABE0 File Offset: 0x00B18DE0
		private int FindNearestIndex()
		{
			int result = -1;
			float num = float.MaxValue;
			for (int i = 0; i < this.ElementItems.Count; i++)
			{
				float num2 = MathF.Abs(this.ItemX(i) - this.AttachX);
				if (num2 < num)
				{
					num = num2;
					result = i;
				}
			}
			return result;
		}

		// Token: 0x06027A6B RID: 162411 RVA: 0x00B1AC28 File Offset: 0x00B18E28
		private void SnapToIndex(int index, bool fireSnapped, bool animate = true, bool trackCandidate = false)
		{
			if (index < 0 || index >= this.ElementItems.Count)
			{
				return;
			}
			float num = this.AttachX - this.BaseXList[index];
			this.CurAttachedIndex = index;
			this.DockedScrollX = num;
			if (!animate)
			{
				this.RemoveEaseTick();
				this.ScrollX = num;
				this.ApplyLayout();
				if (fireSnapped)
				{
					this.FinishSnap(index);
				}
				return;
			}
			this.StartEase(num, delegate
			{
				if (fireSnapped)
				{
					this.FinishSnap(index);
				}
			}, trackCandidate);
		}

		// Token: 0x06027A6C RID: 162412 RVA: 0x00B1ACD5 File Offset: 0x00B18ED5
		private void FinishSnap(int index)
		{
			this.CurUndocked = false;
			this.CandidateIndex = -1;
			Action<int> onSnapped = this.OnSnapped;
			if (onSnapped == null)
			{
				return;
			}
			onSnapped(index);
		}

		// Token: 0x06027A6D RID: 162413 RVA: 0x00B1ACF8 File Offset: 0x00B18EF8
		private void StartEase(float targetScroll, Action onDone, bool trackCandidate = false)
		{
			this.RemoveEaseTick();
			this.EaseStartScroll = this.ScrollX;
			this.EaseTargetScroll = targetScroll;
			this.EaseElapsed = 0f;
			this.EaseDoneCallback = onDone;
			this.EaseTrackCandidate = trackCandidate;
			this.EaseTickId = TickSystem.Instance.Add(new Action<float>(this.OnEaseTick), "RoleElementEaseTick", ETickingGroup.TG_PrePhysics, true, 0, true).Id;
		}

		// Token: 0x06027A6E RID: 162414 RVA: 0x00B1AD64 File Offset: 0x00B18F64
		private void OnEaseTick(float _)
		{
			this.EaseElapsed += Time.Instance.DeltaTime;
			float num = (this.EaseDuration <= 0f) ? 1f : Math.Clamp(this.EaseElapsed / this.EaseDuration, 0f, 1f);
			float num2 = 1f - num;
			float num3 = 1f - num2 * num2 * num2;
			this.ScrollX = this.EaseStartScroll + (this.EaseTargetScroll - this.EaseStartScroll) * num3;
			this.ApplyLayout();
			if (this.EaseTrackCandidate)
			{
				this.UpdateCandidateState();
			}
			if (num >= 1f)
			{
				this.RemoveEaseTick();
				Action easeDoneCallback = this.EaseDoneCallback;
				this.EaseDoneCallback = null;
				if (easeDoneCallback == null)
				{
					return;
				}
				easeDoneCallback();
			}
		}

		// Token: 0x06027A6F RID: 162415 RVA: 0x00B1AE22 File Offset: 0x00B19022
		private void RemoveEaseTick()
		{
			if (this.EaseTickId != -1)
			{
				TickSystem.Instance.Remove(this.EaseTickId);
				this.EaseTickId = -1;
			}
		}

		// Token: 0x06027A70 RID: 162416 RVA: 0x00B1AE48 File Offset: 0x00B19048
		[NullableContext(0)]
		private ValueTuple<double, double> GetPointerLguiPos()
		{
			FVector? pointerEventDataPosition = LguiEventSystemManager.Instance.GetPointerEventDataPosition(0);
			Vector2D vector2D = Vector2D.Create((double)pointerEventDataPosition.Value.X, (double)pointerEventDataPosition.Value.Y);
			Vector2D vector2D2 = vector2D;
			ULGUICanvasScaler canvasScaler = UiLayer.Instance.UiRootItem.GetCanvasScaler();
			FVector2D fvector2D = vector2D.ToUeVector2D(false);
			vector2D2.FromUeVector2D(canvasScaler.ConvertPositionFromViewportToLGUICanvas(fvector2D));
			return new ValueTuple<double, double>(vector2D.X, vector2D.Y);
		}

		// Token: 0x06027A71 RID: 162417 RVA: 0x00B1AEBC File Offset: 0x00B190BC
		public void Dispose()
		{
			this.RemoveEaseTick();
			this.DragState = false;
			this.CandidateIndex = -1;
			this.DragComponent.OnPointerBeginDragCallBack.Unbind();
			this.DragComponent.OnPointerDragCallBack.Unbind();
			this.DragComponent.OnPointerEndDragCallBack.Unbind();
			this.DragComponent.NavigateToPrevDelegate.Unbind();
			this.DragComponent.NavigateToNextDelegate.Unbind();
		}

		// Token: 0x04015A05 RID: 88581
		private const float DEFAULT_EASE_DURATION = 350f;

		// Token: 0x04015A06 RID: 88582
		private const float DEFAULT_ATTACH_THRESHOLD = 80f;

		// Token: 0x04015A07 RID: 88583
		private const float DEFAULT_CHANGE_SPEED = 1f;

		// Token: 0x04015A08 RID: 88584
		[Nullable(1)]
		private readonly UUIDraggableComponent DragComponent;

		// Token: 0x04015A09 RID: 88585
		[Nullable(1)]
		private readonly UUIItem Panel;

		// Token: 0x04015A0A RID: 88586
		[Nullable(1)]
		private readonly UUIItem AttachItem;

		// Token: 0x04015A0B RID: 88587
		[Nullable(1)]
		private readonly List<UUIItem> ElementItems;

		// Token: 0x04015A0C RID: 88588
		[Nullable(1)]
		private readonly float[] BaseXList;

		// Token: 0x04015A0D RID: 88589
		private readonly float AttachX;

		// Token: 0x04015A0E RID: 88590
		private float EaseDuration = 350f;

		// Token: 0x04015A0F RID: 88591
		private float AttachThreshold = 80f;

		// Token: 0x04015A10 RID: 88592
		private float ChangeSpeed = 1f;

		// Token: 0x04015A11 RID: 88593
		private UCurveFloat TrajectoryCurve;

		// Token: 0x04015A12 RID: 88594
		private UCurveFloat AlphaCurve;

		// Token: 0x04015A13 RID: 88595
		private UCurveFloat ScaleCurve;

		// Token: 0x04015A14 RID: 88596
		private float ScrollX;

		// Token: 0x04015A15 RID: 88597
		private float DockedScrollX;

		// Token: 0x04015A16 RID: 88598
		private bool DragState;

		// Token: 0x04015A17 RID: 88599
		private int CurAttachedIndex = -1;

		// Token: 0x04015A18 RID: 88600
		private bool CurUndocked;

		// Token: 0x04015A19 RID: 88601
		private int CandidateIndex = -1;

		// Token: 0x04015A1A RID: 88602
		private double StartPointerX;

		// Token: 0x04015A1B RID: 88603
		private float StartScrollX;

		// Token: 0x04015A1C RID: 88604
		private int EaseTickId = -1;

		// Token: 0x04015A1D RID: 88605
		private float EaseElapsed;

		// Token: 0x04015A1E RID: 88606
		private float EaseStartScroll;

		// Token: 0x04015A1F RID: 88607
		private float EaseTargetScroll;

		// Token: 0x04015A20 RID: 88608
		private Action EaseDoneCallback;

		// Token: 0x04015A21 RID: 88609
		private bool EaseTrackCandidate;

		// Token: 0x04015A22 RID: 88610
		public Action<int> OnCurrentItemUndock;

		// Token: 0x04015A23 RID: 88611
		public Action<int> OnCandidateEnter;

		// Token: 0x04015A24 RID: 88612
		public Action<int> OnCandidateExit;

		// Token: 0x04015A25 RID: 88613
		public Action<int> OnSnapped;

		// Token: 0x04015A26 RID: 88614
		public Action<int, float> OnItemAlphaChange;

		// Token: 0x04015A27 RID: 88615
		public Func<bool> CanNavigate;
	}
}
