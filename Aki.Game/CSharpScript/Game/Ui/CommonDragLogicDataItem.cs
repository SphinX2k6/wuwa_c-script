using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003578 RID: 13688
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonDragLogicDataItem<T> where T : class
	{
		// Token: 0x06022E25 RID: 142885 RVA: 0x009E7F26 File Offset: 0x009E6126
		[NullableContext(2)]
		public void SetCurrentData(T data)
		{
			this.CurrentData = data;
		}

		// Token: 0x06022E26 RID: 142886 RVA: 0x009E7F2F File Offset: 0x009E612F
		[NullableContext(2)]
		public T GetCurrentData()
		{
			return this.CurrentData;
		}

		// Token: 0x06022E27 RID: 142887 RVA: 0x009E7F38 File Offset: 0x009E6138
		public void SetDragComponent(UUIDraggableComponent drag)
		{
			this.DragComponent = drag;
			this.SourceWidth = this.DragComponent.RootUIComp.Get().Width;
			this.SourceHeight = this.DragComponent.RootUIComp.Get().Height;
		}

		// Token: 0x06022E28 RID: 142888 RVA: 0x009E7F88 File Offset: 0x009E6188
		public void SetCurrentIndex(int index)
		{
			this.Index = index;
		}

		// Token: 0x06022E29 RID: 142889 RVA: 0x009E7F91 File Offset: 0x009E6191
		public int GetCurrentIndex()
		{
			return this.Index;
		}

		// Token: 0x06022E2A RID: 142890 RVA: 0x009E7F99 File Offset: 0x009E6199
		public virtual bool CheckIfCanDrag()
		{
			return true;
		}

		// Token: 0x06022E2B RID: 142891 RVA: 0x009E7F9C File Offset: 0x009E619C
		public virtual bool CheckIfCurrentDragIndex(int index)
		{
			return true;
		}

		// Token: 0x06022E2C RID: 142892 RVA: 0x009E7F9F File Offset: 0x009E619F
		public virtual void SetCurrentDragIndex(int index)
		{
		}

		// Token: 0x06022E2D RID: 142893 RVA: 0x009E7FA1 File Offset: 0x009E61A1
		public virtual void ClearCurrentDragIndex()
		{
		}

		// Token: 0x06022E2E RID: 142894 RVA: 0x009E7FA4 File Offset: 0x009E61A4
		[NullableContext(0)]
		public ValueTuple<float, float> GetMiddlePosition()
		{
			return new ValueTuple<float, float>(this.DragComponent.RootUIComp.Get().GetLGUISpaceCenterAbsolutePosition().X, this.DragComponent.RootUIComp.Get().GetLGUISpaceCenterAbsolutePosition().Y);
		}

		// Token: 0x06022E2F RID: 142895 RVA: 0x009E7FF0 File Offset: 0x009E61F0
		public bool CheckIfSelfItem(int index)
		{
			return index == this.Index;
		}

		// Token: 0x06022E30 RID: 142896 RVA: 0x009E7FFC File Offset: 0x009E61FC
		public bool CheckOverlap(Vector2D inX, Vector2D inY)
		{
			double x = inX.X;
			double y = inX.Y;
			double x2 = inY.X;
			double y2 = inY.Y;
			double x3 = this.GetBounceX().X;
			double y3 = this.GetBounceX().Y;
			double x4 = this.GetBounceY().X;
			double y4 = this.GetBounceY().Y;
			return x < y3 && x3 < y && x2 < y4 && x4 < y2;
		}

		// Token: 0x06022E31 RID: 142897 RVA: 0x009E806C File Offset: 0x009E626C
		public Vector2D GetBounceX()
		{
			float num = PhantomBattleConfig.Instance.GetVisionScrollerOffsetX() * (float)PhantomBattleConfig.Instance.GetVisionScrollerOffsetXDir();
			TWeakObjectPtr<UUIItem> rootUIComp = this.DragComponent.RootUIComp;
			float num2 = this.SourceWidth / 2f;
			float num3 = rootUIComp.Get().GetLGUISpaceCenterAbsolutePosition().X - num2;
			float num4 = rootUIComp.Get().GetLGUISpaceCenterAbsolutePosition().X + num2;
			this.BounceX.X = (double)(num3 - num);
			this.BounceX.Y = (double)(num4 - num);
			return this.BounceX;
		}

		// Token: 0x06022E32 RID: 142898 RVA: 0x009E80F8 File Offset: 0x009E62F8
		public Vector2D GetBounceY()
		{
			float num = PhantomBattleConfig.Instance.GetVisionScrollerOffsetY() * (float)PhantomBattleConfig.Instance.GetVisionScrollerOffsetYDir();
			TWeakObjectPtr<UUIItem> rootUIComp = this.DragComponent.RootUIComp;
			float num2 = this.SourceHeight / 2f;
			float num3 = rootUIComp.Get().GetLGUISpaceCenterAbsolutePosition().Y - num2;
			float num4 = rootUIComp.Get().GetLGUISpaceCenterAbsolutePosition().Y + num2;
			this.BounceY.X = (double)(num3 - num);
			this.BounceY.Y = (double)(num4 - num);
			return this.BounceY;
		}

		// Token: 0x06022E33 RID: 142899 RVA: 0x009E8183 File Offset: 0x009E6383
		public void SetOnUnOverlayCallBack(Action<int> callBack)
		{
			this.OnUnOverlayCallBack = callBack;
		}

		// Token: 0x06022E34 RID: 142900 RVA: 0x009E818C File Offset: 0x009E638C
		public void SetOnOverlayCallBack(Action<int> callBack)
		{
			this.OnOverlayCallBack = callBack;
		}

		// Token: 0x06022E35 RID: 142901 RVA: 0x009E8195 File Offset: 0x009E6395
		public void OnUnOverlay()
		{
			Action<int> onUnOverlayCallBack = this.OnUnOverlayCallBack;
			if (onUnOverlayCallBack == null)
			{
				return;
			}
			onUnOverlayCallBack(this.GetCurrentIndex());
		}

		// Token: 0x06022E36 RID: 142902 RVA: 0x009E81AD File Offset: 0x009E63AD
		public void OnOverlay()
		{
			Action<int> onOverlayCallBack = this.OnOverlayCallBack;
			if (onOverlayCallBack == null)
			{
				return;
			}
			onOverlayCallBack(this.GetCurrentIndex());
		}

		// Token: 0x06022E37 RID: 142903 RVA: 0x009E81C8 File Offset: 0x009E63C8
		public int GetOverlapIndex(List<CommonDragLogicDataItem<T>> targets)
		{
			int count = targets.Count;
			if (count == 0)
			{
				return -1;
			}
			ValueTuple<float, float> middlePosition = this.GetMiddlePosition();
			int currentIndex = targets[0].GetCurrentIndex();
			ValueTuple<float, float> middlePosition2 = targets[0].GetMiddlePosition();
			float num = middlePosition.Item1 * middlePosition.Item1;
			float num2 = middlePosition.Item2 * middlePosition.Item2;
			float num3 = Math.Abs(num - middlePosition2.Item1 * middlePosition2.Item1);
			float num4 = Math.Abs(num2 - middlePosition2.Item2 * middlePosition2.Item2);
			float num5 = num3 + num4;
			for (int i = 0; i < count; i++)
			{
				middlePosition2 = targets[i].GetMiddlePosition();
				float num6 = Math.Abs(num - middlePosition2.Item1 * middlePosition2.Item1);
				num4 = Math.Abs(num2 - middlePosition2.Item2 * middlePosition2.Item2);
				float num7 = num6 + num4;
				if (num5 > num7)
				{
					num5 = num7;
					currentIndex = targets[i].GetCurrentIndex();
				}
			}
			return currentIndex;
		}

		// Token: 0x06022E38 RID: 142904 RVA: 0x009E82B9 File Offset: 0x009E64B9
		public virtual float GetClickTime()
		{
			return 300f;
		}

		// Token: 0x0401346A RID: 78954
		[Nullable(2)]
		private UUIDraggableComponent DragComponent;

		// Token: 0x0401346B RID: 78955
		private int Index = -1;

		// Token: 0x0401346C RID: 78956
		[Nullable(2)]
		private T CurrentData;

		// Token: 0x0401346D RID: 78957
		private readonly Vector2D BounceX = new Vector2D(0.0, 0.0);

		// Token: 0x0401346E RID: 78958
		private readonly Vector2D BounceY = new Vector2D(0.0, 0.0);

		// Token: 0x0401346F RID: 78959
		private float SourceWidth;

		// Token: 0x04013470 RID: 78960
		private float SourceHeight;

		// Token: 0x04013471 RID: 78961
		[Nullable(2)]
		private Action<int> OnOverlayCallBack;

		// Token: 0x04013472 RID: 78962
		[Nullable(2)]
		private Action<int> OnUnOverlayCallBack;
	}
}
