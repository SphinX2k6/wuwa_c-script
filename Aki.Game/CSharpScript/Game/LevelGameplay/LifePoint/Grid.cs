using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LifePoint
{
	// Token: 0x02005C48 RID: 23624
	[NullableContext(1)]
	[Nullable(0)]
	public class Grid : UiPanelBase
	{
		// Token: 0x0603A03C RID: 237628 RVA: 0x0105188E File Offset: 0x0104FA8E
		public Grid(int x, int y, EPieceColorType color, Action<int, int> callback)
		{
			this.X = x;
			this.Y = y;
			this.Color = color;
			this.Callback = callback;
			this.ColorExpressed = color;
		}

		// Token: 0x0603A03D RID: 237629 RVA: 0x010518C8 File Offset: 0x0104FAC8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603A03E RID: 237630 RVA: 0x010519B5 File Offset: 0x0104FBB5
		protected override void OnBeforeCreate()
		{
			this.UiViewSequence = new UiBehaviorLevelSequence(this);
			base.AddUiBehavior(this.UiViewSequence);
		}

		// Token: 0x0603A03F RID: 237631 RVA: 0x010519D0 File Offset: 0x0104FBD0
		protected override void OnStart()
		{
			this.IsBlock = (this.ColorExpressed == EPieceColorType.Gray);
			UTexture2D texture;
			LifePointModel.Instance.GridTextureMap.TryGetValue(this.Color, out texture);
			base.GetTexture(0).SetTexture(texture);
			bool uiactive = this.Color == LifePointModel.Instance.Config.ColorBoard.TargetColor;
			base.GetTexture(2).GetParentAsUIItem().SetUIActive(uiactive);
			UTexture2D texture2;
			LifePointModel.Instance.HitGridTextureMap.TryGetValue(this.Color, out texture2);
			base.GetTexture(2).SetTexture(texture2);
			base.GetTexture(1).GetParentAsUIItem().SetUIActive(false);
			base.GetTexture(3).GetParentAsUIItem().SetUIActive(false);
			base.GetTexture(5).SetUIActive(this.IsBlock);
			base.GetItem(4).SetUIActive(!this.IsBlock);
			if (!this.IsBlock)
			{
				(base.GetRootActor().GetComponentByClass(UUIButtonComponent.StaticClass()) as UUIButtonComponent).OnClickCallBack.Bind(new Action(this.OnClick));
			}
		}

		// Token: 0x0603A040 RID: 237632 RVA: 0x01051AE8 File Offset: 0x0104FCE8
		protected override void OnBeforeDestroy()
		{
			(base.GetRootActor().GetComponentByClass(UUIButtonComponent.StaticClass()) as UUIButtonComponent).OnClickCallBack.Unbind();
			this.UiViewSequence.StopSequenceByKey("Change", false, false);
			this.UiViewSequence = null;
		}

		// Token: 0x0603A041 RID: 237633 RVA: 0x01051B27 File Offset: 0x0104FD27
		private void OnClick()
		{
			this.Callback(this.X, this.Y);
		}

		// Token: 0x0603A042 RID: 237634 RVA: 0x01051B40 File Offset: 0x0104FD40
		public void Paint(EPieceColorType color, int order, EDirection direction)
		{
			this.Color = color;
			float num = LifePointModel.Instance.CalcCountDownTime(order);
			AnimTask animTask = AnimTask.Get((float)Time.Instance.Now + num, color, LifePointModel.Instance.DirectionParam[direction], LifePointModel.Instance.CalPlayRate(num), order);
			while (this.AnimTask_.Size > 0 && this.AnimTask_.Rear.Time >= animTask.Time)
			{
				this.AnimTask_.RemoveRear();
			}
			this.AnimTask_.AddRear(animTask);
		}

		// Token: 0x0603A043 RID: 237635 RVA: 0x01051BD0 File Offset: 0x0104FDD0
		public void TryBlendAnim(EPieceColorType color, int order, EDirection direction)
		{
			double a = Time.Instance.Now + (double)LifePointModel.Instance.CalcCountDownTime(order);
			for (int i = 0; i < this.AnimTask_.Size; i++)
			{
				AnimTask animTask = this.AnimTask_.Get(i);
				if (animTask != null && animTask.Color == color && MathUtils.Instance.IsNearlyEqual(a, (double)animTask.Time, new double?((double)1)))
				{
					animTask.DirectionParam = LifePointModel.Instance.BlendDirectionParam(animTask.DirectionParam, direction);
					return;
				}
			}
		}

		// Token: 0x0603A044 RID: 237636 RVA: 0x01051C57 File Offset: 0x0104FE57
		public void BeforeReset()
		{
			this.AnimTask_.Clear();
		}

		// Token: 0x0603A045 RID: 237637 RVA: 0x01051C64 File Offset: 0x0104FE64
		public void Reset(EPieceColorType color)
		{
			if (this.IsBlock)
			{
				return;
			}
			Dictionary<EPieceColorType, UTexture2D> dictionary = (this.ColorExpressed == LifePointModel.Instance.Config.ColorBoard.TargetColor) ? LifePointModel.Instance.HitGridTextureMap : LifePointModel.Instance.GridTextureMap;
			this.UiViewSequence.StopPrevSequence(false, true);
			UUITexture texture = base.GetTexture(1);
			UUITexture texture2 = base.GetTexture(3);
			texture.SetTexture(dictionary[this.ColorExpressed]);
			texture2.SetTexture(dictionary[this.ColorExpressed]);
			texture.GetParentAsUIItem().SetUIActive(true);
			texture2.GetParentAsUIItem().SetUIActive(true);
			bool isHit = color == LifePointModel.Instance.Config.ColorBoard.TargetColor;
			UTexture2D baseTexture = LifePointModel.Instance.GridTextureMap[color];
			UTexture2D spTexture = LifePointModel.Instance.HitGridTextureMap[color];
			TimerSystem.Instance.Next(delegate(float _)
			{
				this.GetTexture(0).SetTexture(baseTexture);
				this.GetTexture(2).GetParentAsUIItem().SetUIActive(isHit);
				this.GetTexture(2).SetTexture(spTexture);
			}, null, null);
			this.Color = color;
			this.ColorExpressed = this.Color;
		}

		// Token: 0x0603A046 RID: 237638 RVA: 0x01051D88 File Offset: 0x0104FF88
		public void AfterReset()
		{
			base.GetTexture(1).GetParentAsUIItem().SetUIActive(false);
			base.GetTexture(3).GetParentAsUIItem().SetUIActive(false);
			base.GetTexture(1).SetColor(LifePointModel.Instance.InitColor);
			base.GetTexture(3).SetColor(LifePointModel.Instance.InitColor);
		}

		// Token: 0x0603A047 RID: 237639 RVA: 0x01051DE8 File Offset: 0x0104FFE8
		public bool CheckAnim()
		{
			if (this.AnimTask_.Size == 0)
			{
				return this.UiViewSequence.IsInSequence();
			}
			if ((double)this.AnimTask_.Front.Time > Time.Instance.Now)
			{
				return true;
			}
			AnimTask animTask = this.AnimTask_.RemoveFront();
			this.PlayAnim(animTask);
			animTask.Recycle();
			return true;
		}

		// Token: 0x0603A048 RID: 237640 RVA: 0x01051E48 File Offset: 0x01050048
		private void PlayAnim(AnimTask animTask)
		{
			bool isHit = animTask.Color == LifePointModel.Instance.Config.ColorBoard.TargetColor;
			Dictionary<EPieceColorType, UTexture2D> dictionary = (this.ColorExpressed == LifePointModel.Instance.Config.ColorBoard.TargetColor) ? LifePointModel.Instance.HitGridTextureMap : LifePointModel.Instance.GridTextureMap;
			UTexture2D baseTexture = LifePointModel.Instance.GridTextureMap[animTask.Color];
			UTexture2D spTexture = LifePointModel.Instance.HitGridTextureMap[animTask.Color];
			TimerSystem.Instance.Next(delegate(float _)
			{
				this.GetTexture(0).SetTexture(baseTexture);
				this.GetTexture(2).GetParentAsUIItem().SetUIActive(isHit);
				this.GetTexture(2).SetTexture(spTexture);
			}, null, null);
			UUITexture texture = base.GetTexture(1);
			UUITexture texture2 = base.GetTexture(3);
			texture.SetTexture(dictionary[this.ColorExpressed]);
			texture2.SetTexture(dictionary[this.ColorExpressed]);
			texture.GetParentAsUIItem().SetUIActive(true);
			texture2.GetParentAsUIItem().SetUIActive(true);
			if (animTask.DirectionParam < 0f)
			{
				if (this.UiViewSequence.HasSequenceNameInPlaying("PointChange"))
				{
					this.UiViewSequence.ReplaySequence("PointChange");
				}
				else
				{
					this.UiViewSequence.PlaySequence("PointChange", false, null);
				}
			}
			else
			{
				texture.SetCustomMaterialScalarParameter(LifePointModel.Instance.ParamName, animTask.DirectionParam);
				texture2.SetCustomMaterialScalarParameter(LifePointModel.Instance.ParamName, animTask.DirectionParam);
				if (this.UiViewSequence.HasSequenceNameInPlaying("Change"))
				{
					this.UiViewSequence.ReplaySequence("Change");
				}
				else
				{
					this.UiViewSequence.PlaySequence("Change", false, new float?(animTask.PlayRate));
				}
			}
			this.ColorExpressed = animTask.Color;
			float[] array;
			if (!LifePointModel.Instance.AudioMap.TryGetValue(animTask.Order, out array))
			{
				array = new float[2];
			}
			array[0] = array[0] + 1f;
			array[1] = animTask.PlayRate;
			LifePointModel.Instance.AudioMap[animTask.Order] = array;
		}

		// Token: 0x0401EACA RID: 125642
		public Deque<AnimTask> AnimTask_ = new Deque<AnimTask>(4);

		// Token: 0x0401EACB RID: 125643
		public EPieceColorType ColorExpressed;

		// Token: 0x0401EACC RID: 125644
		public bool IsBlock;

		// Token: 0x0401EACD RID: 125645
		[Nullable(2)]
		private UiBehaviorLevelSequence UiViewSequence;

		// Token: 0x0401EACE RID: 125646
		public int X;

		// Token: 0x0401EACF RID: 125647
		public int Y;

		// Token: 0x0401EAD0 RID: 125648
		public EPieceColorType Color;

		// Token: 0x0401EAD1 RID: 125649
		public Action<int, int> Callback;
	}
}
