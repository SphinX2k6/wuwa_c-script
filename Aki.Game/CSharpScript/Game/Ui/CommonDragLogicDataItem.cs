using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004647 RID: 17991
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonDragLogicDataItem<T> where T : class
	{
		// Token: 0x0602E6DB RID: 190171 RVA: 0x00ABA8F6 File Offset: 0x00AB8AF6
		[NullableContext(2)]
		public void SetCurrentData(T data)
		{
			this.CurrentData = data;
		}

		// Token: 0x0602E6DC RID: 190172 RVA: 0x00ABA8FF File Offset: 0x00AB8AFF
		[NullableContext(2)]
		public T GetCurrentData()
		{
			return this.CurrentData;
		}

		// Token: 0x0602E6DD RID: 190173 RVA: 0x00ABA908 File Offset: 0x00AB8B08
		public void SetDragComponent(UUIDraggableComponent drag)
		{
			this.DragComponent = drag;
			this.SourceWidth = this.DragComponent.RootUIComp.Get().Width;
			this.SourceHeight = this.DragComponent.RootUIComp.Get().Height;
		}

		// Token: 0x0602E6DE RID: 190174 RVA: 0x00ABA958 File Offset: 0x00AB8B58
		public void SetCurrentIndex(int index)
		{
			this.Index = index;
		}

		// Token: 0x0602E6DF RID: 190175 RVA: 0x00ABA961 File Offset: 0x00AB8B61
		public int GetCurrentIndex()
		{
			return this.Index;
		}

		// Token: 0x0602E6E0 RID: 190176 RVA: 0x00ABA969 File Offset: 0x00AB8B69
		public virtual bool CheckIfCanDrag()
		{
			return true;
		}

		// Token: 0x0602E6E1 RID: 190177 RVA: 0x00ABA96C File Offset: 0x00AB8B6C
		public virtual bool CheckIfCurrentDragIndex(int index)
		{
			return true;
		}

		// Token: 0x0602E6E2 RID: 190178 RVA: 0x00ABA96F File Offset: 0x00AB8B6F
		public virtual void SetCurrentDragIndex(int index)
		{
		}

		// Token: 0x0602E6E3 RID: 190179 RVA: 0x00ABA971 File Offset: 0x00AB8B71
		public virtual void ClearCurrentDragIndex()
		{
		}

		// Token: 0x0602E6E4 RID: 190180 RVA: 0x00ABA974 File Offset: 0x00AB8B74
		[NullableContext(0)]
		public ValueTuple<float, float> GetMiddlePosition()
		{
			return new ValueTuple<float, float>(this.DragComponent.RootUIComp.Get().GetLGUISpaceCenterAbsolutePosition().X, this.DragComponent.RootUIComp.Get().GetLGUISpaceCenterAbsolutePosition().Y);
		}

		// Token: 0x0602E6E5 RID: 190181 RVA: 0x00ABA9C0 File Offset: 0x00AB8BC0
		public bool CheckIfSelfItem(int index)
		{
			return index == this.Index;
		}

		// Token: 0x0602E6E6 RID: 190182 RVA: 0x00ABA9CC File Offset: 0x00AB8BCC
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

		// Token: 0x0602E6E7 RID: 190183 RVA: 0x00ABAA3C File Offset: 0x00AB8C3C
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

		// Token: 0x0602E6E8 RID: 190184 RVA: 0x00ABAAC8 File Offset: 0x00AB8CC8
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

		// Token: 0x0602E6E9 RID: 190185 RVA: 0x00ABAB53 File Offset: 0x00AB8D53
		public void SetOnUnOverlayCallBack(Action<int> callBack)
		{
			this.OnUnOverlayCallBack = callBack;
		}

		// Token: 0x0602E6EA RID: 190186 RVA: 0x00ABAB5C File Offset: 0x00AB8D5C
		public void SetOnOverlayCallBack(Action<int> callBack)
		{
			this.OnOverlayCallBack = callBack;
		}

		// Token: 0x0602E6EB RID: 190187 RVA: 0x00ABAB65 File Offset: 0x00AB8D65
		public void OnUnOverlay()
		{
			Action<int> onUnOverlayCallBack = this.OnUnOverlayCallBack;
			if (onUnOverlayCallBack == null)
			{
				return;
			}
			onUnOverlayCallBack(this.GetCurrentIndex());
		}

		// Token: 0x0602E6EC RID: 190188 RVA: 0x00ABAB7D File Offset: 0x00AB8D7D
		public void OnOverlay()
		{
			Action<int> onOverlayCallBack = this.OnOverlayCallBack;
			if (onOverlayCallBack == null)
			{
				return;
			}
			onOverlayCallBack(this.GetCurrentIndex());
		}

		// Token: 0x0602E6ED RID: 190189 RVA: 0x00ABAB98 File Offset: 0x00AB8D98
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

		// Token: 0x0602E6EE RID: 190190 RVA: 0x00ABAC89 File Offset: 0x00AB8E89
		public virtual float GetClickTime()
		{
			return 300f;
		}

		// Token: 0x04018E11 RID: 101905
		[Nullable(2)]
		private UUIDraggableComponent DragComponent;

		// Token: 0x04018E12 RID: 101906
		private int Index = -1;

		// Token: 0x04018E13 RID: 101907
		[Nullable(2)]
		private T CurrentData;

		// Token: 0x04018E14 RID: 101908
		private readonly Vector2D BounceX = new Vector2D(0.0, 0.0);

		// Token: 0x04018E15 RID: 101909
		private readonly Vector2D BounceY = new Vector2D(0.0, 0.0);

		// Token: 0x04018E16 RID: 101910
		private float SourceWidth;

		// Token: 0x04018E17 RID: 101911
		private float SourceHeight;

		// Token: 0x04018E18 RID: 101912
		[Nullable(2)]
		private Action<int> OnOverlayCallBack;

		// Token: 0x04018E19 RID: 101913
		[Nullable(2)]
		private Action<int> OnUnOverlayCallBack;
	}
}
