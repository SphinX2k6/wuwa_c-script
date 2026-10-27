using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LifePoint
{
	// Token: 0x02006AD0 RID: 27344
	[NullableContext(1)]
	[Nullable(0)]
	public class Grid : UiPanelBase
	{
		// Token: 0x06043EF3 RID: 278259 RVA: 0x010A81DE File Offset: 0x010A63DE
		public Grid(int x, int y, EPieceColorType color, Action<int, int> callback)
		{
			this.X = x;
			this.Y = y;
			this.Color = color;
			this.Callback = callback;
			this.ColorExpressed = color;
		}

		// Token: 0x06043EF4 RID: 278260 RVA: 0x010A8218 File Offset: 0x010A6418
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

		// Token: 0x06043EF5 RID: 278261 RVA: 0x010A8305 File Offset: 0x010A6505
		protected override void OnBeforeCreate()
		{
			this.UiViewSequence = new UiBehaviorLevelSequence(this);
			base.AddUiBehavior(this.UiViewSequence);
		}

		// Token: 0x06043EF6 RID: 278262 RVA: 0x010A8320 File Offset: 0x010A6520
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

		// Token: 0x06043EF7 RID: 278263 RVA: 0x010A8438 File Offset: 0x010A6638
		protected override void OnBeforeDestroy()
		{
			(base.GetRootActor().GetComponentByClass(UUIButtonComponent.StaticClass()) as UUIButtonComponent).OnClickCallBack.Unbind();
			this.UiViewSequence.StopSequenceByKey("Change", false, false);
			this.UiViewSequence = null;
		}

		// Token: 0x06043EF8 RID: 278264 RVA: 0x010A8477 File Offset: 0x010A6677
		private void OnClick()
		{
			this.Callback(this.X, this.Y);
		}

		// Token: 0x06043EF9 RID: 278265 RVA: 0x010A8490 File Offset: 0x010A6690
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

		// Token: 0x06043EFA RID: 278266 RVA: 0x010A8520 File Offset: 0x010A6720
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

		// Token: 0x06043EFB RID: 278267 RVA: 0x010A85A7 File Offset: 0x010A67A7
		public void BeforeReset()
		{
			this.AnimTask_.Clear();
		}

		// Token: 0x06043EFC RID: 278268 RVA: 0x010A85B4 File Offset: 0x010A67B4
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

		// Token: 0x06043EFD RID: 278269 RVA: 0x010A86D8 File Offset: 0x010A68D8
		public void AfterReset()
		{
			base.GetTexture(1).GetParentAsUIItem().SetUIActive(false);
			base.GetTexture(3).GetParentAsUIItem().SetUIActive(false);
			base.GetTexture(1).SetColor(LifePointModel.Instance.InitColor);
			base.GetTexture(3).SetColor(LifePointModel.Instance.InitColor);
		}

		// Token: 0x06043EFE RID: 278270 RVA: 0x010A8738 File Offset: 0x010A6938
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

		// Token: 0x06043EFF RID: 278271 RVA: 0x010A8798 File Offset: 0x010A6998
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

		// Token: 0x0402382A RID: 145450
		public Deque<AnimTask> AnimTask_ = new Deque<AnimTask>(4);

		// Token: 0x0402382B RID: 145451
		public EPieceColorType ColorExpressed;

		// Token: 0x0402382C RID: 145452
		public bool IsBlock;

		// Token: 0x0402382D RID: 145453
		[Nullable(2)]
		private UiBehaviorLevelSequence UiViewSequence;

		// Token: 0x0402382E RID: 145454
		public int X;

		// Token: 0x0402382F RID: 145455
		public int Y;

		// Token: 0x04023830 RID: 145456
		public EPieceColorType Color;

		// Token: 0x04023831 RID: 145457
		public Action<int, int> Callback;
	}
}
