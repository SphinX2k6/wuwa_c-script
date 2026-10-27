using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x0200504B RID: 20555
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotAspectTransformView : UiPanelBase
	{
		// Token: 0x060349B3 RID: 215475 RVA: 0x00C6D2C8 File Offset: 0x00C6B4C8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060349B4 RID: 215476 RVA: 0x00C6D334 File Offset: 0x00C6B534
		protected override void OnStart()
		{
			this.Texture1 = base.GetTexture(0);
			UUITexture texture = this.Texture1;
			if (texture != null)
			{
				texture.SetUIActive(false);
			}
			UUITexture texture2 = this.Texture1;
			if (texture2 != null)
			{
				texture2.SetAlpha(1f);
			}
			this.Texture2 = base.GetTexture(1);
			UUITexture texture3 = this.Texture2;
			if (texture3 != null)
			{
				texture3.SetUIActive(false);
			}
			UUITexture texture4 = this.Texture2;
			if (texture4 != null)
			{
				texture4.SetAlpha(1f);
			}
			base.GetRootItem().GetRenderCanvas().bPostTickUpdate = true;
			base.GetRootItem().SetRaycastTarget(false);
			EventSystem.Instance.Add(EEventName.UIViewPortSizeChanged, new Action(this.OnSizeChanged));
		}

		// Token: 0x060349B5 RID: 215477 RVA: 0x00C6D3E1 File Offset: 0x00C6B5E1
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.UIViewPortSizeChanged, new Action(this.OnSizeChanged));
		}

		// Token: 0x060349B6 RID: 215478 RVA: 0x00C6D3FC File Offset: 0x00C6B5FC
		protected override void OnBeforeShow()
		{
		}

		// Token: 0x060349B7 RID: 215479 RVA: 0x00C6D3FE File Offset: 0x00C6B5FE
		protected override void OnAfterShow()
		{
		}

		// Token: 0x060349B8 RID: 215480 RVA: 0x00C6D400 File Offset: 0x00C6B600
		protected override void OnBeforeHide()
		{
			if (this.TickHandle == -1)
			{
				return;
			}
			TickSystem.Instance.Remove(this.TickHandle);
			this.TickHandle = -1;
		}

		// Token: 0x060349B9 RID: 215481 RVA: 0x00C6D424 File Offset: 0x00C6B624
		public void EnableAutoBlendOut(float blendTime)
		{
			this.BlendTime = blendTime;
			this.BeforeRatio = this.RootItem.GetWidth() / this.RootItem.GetHeight();
			this.StartBySizeChanged = true;
		}

		// Token: 0x060349BA RID: 215482 RVA: 0x00C6D454 File Offset: 0x00C6B654
		public void ManualBlendOut(float blendTime, float startRatio, Action callback = null, bool autoClose = true)
		{
			this.BlendTime = blendTime;
			this.Callback = callback;
			this.AutoClose = autoClose;
			this.BeforeRatio = startRatio;
			this.AfterRatio = this.RootItem.GetWidth() / this.RootItem.GetHeight();
			this.StartTransform();
		}

		// Token: 0x060349BB RID: 215483 RVA: 0x00C6D4A4 File Offset: 0x00C6B6A4
		public void SetAspectRatio(float ratio)
		{
			UUITexture texture = this.Texture1;
			if (texture != null)
			{
				texture.SetUIActive(true);
			}
			UUITexture texture2 = this.Texture2;
			if (texture2 != null)
			{
				texture2.SetUIActive(true);
			}
			UUITexture texture3 = this.Texture1;
			if (texture3 != null)
			{
				texture3.SetStretchRight(0f);
			}
			UUITexture texture4 = this.Texture2;
			if (texture4 != null)
			{
				texture4.SetStretchRight(0f);
			}
			UUITexture texture5 = this.Texture1;
			if (texture5 != null)
			{
				texture5.SetStretchLeft(0f);
			}
			UUITexture texture6 = this.Texture2;
			if (texture6 != null)
			{
				texture6.SetStretchLeft(0f);
			}
			UUITexture texture7 = this.Texture1;
			if (texture7 != null)
			{
				texture7.SetStretchTop(0f);
			}
			UUITexture texture8 = this.Texture2;
			if (texture8 != null)
			{
				texture8.SetStretchTop(0f);
			}
			UUITexture texture9 = this.Texture1;
			if (texture9 != null)
			{
				texture9.SetStretchBottom(0f);
			}
			UUITexture texture10 = this.Texture2;
			if (texture10 != null)
			{
				texture10.SetStretchBottom(0f);
			}
			float width = this.RootItem.GetWidth();
			float height = this.RootItem.GetHeight();
			float num = width / height;
			if (ratio < num)
			{
				float num2 = height * ratio;
				float num3 = width / 2f + num2 / 2f;
				UUITexture texture11 = this.Texture1;
				if (texture11 != null)
				{
					texture11.SetStretchRight(num3);
				}
				UUITexture texture12 = this.Texture2;
				if (texture12 == null)
				{
					return;
				}
				texture12.SetStretchLeft(num3);
				return;
			}
			else
			{
				float num4 = width / ratio;
				float num5 = height / 2f + num4 / 2f;
				UUITexture texture13 = this.Texture1;
				if (texture13 != null)
				{
					texture13.SetStretchTop(num5);
				}
				UUITexture texture14 = this.Texture2;
				if (texture14 == null)
				{
					return;
				}
				texture14.SetStretchBottom(num5);
				return;
			}
		}

		// Token: 0x060349BC RID: 215484 RVA: 0x00C6D61C File Offset: 0x00C6B81C
		private void OnTick(float delta)
		{
			if (this.Duration > this.BlendTime)
			{
				if (this.AutoClose)
				{
					PlotController.Instance.RemoveAspectTransformView();
				}
				else
				{
					base.Hide(null);
				}
				Action callback = this.Callback;
				if (callback == null)
				{
					return;
				}
				callback();
				return;
			}
			else
			{
				this.Duration += delta;
				this.CurrentValue += delta * this.Speed;
				if (this.IsWidthBlend)
				{
					UUITexture texture = this.Texture1;
					if (texture != null)
					{
						texture.SetStretchRight(this.CurrentValue);
					}
					UUITexture texture2 = this.Texture2;
					if (texture2 == null)
					{
						return;
					}
					texture2.SetStretchLeft(this.CurrentValue);
					return;
				}
				else
				{
					UUITexture texture3 = this.Texture1;
					if (texture3 != null)
					{
						texture3.SetStretchTop(this.CurrentValue);
					}
					UUITexture texture4 = this.Texture2;
					if (texture4 == null)
					{
						return;
					}
					texture4.SetStretchBottom(this.CurrentValue);
					return;
				}
			}
		}

		// Token: 0x060349BD RID: 215485 RVA: 0x00C6D6EC File Offset: 0x00C6B8EC
		private void OnSizeChanged()
		{
			if (!this.StartBySizeChanged)
			{
				return;
			}
			float width = this.RootItem.GetWidth();
			float height = this.RootItem.GetHeight();
			this.AfterRatio = width / height;
			this.StartBySizeChanged = false;
			this.StartTransform();
		}

		// Token: 0x060349BE RID: 215486 RVA: 0x00C6D730 File Offset: 0x00C6B930
		private void StartTransform()
		{
			UUITexture texture = this.Texture1;
			if (texture != null)
			{
				texture.SetUIActive(true);
			}
			UUITexture texture2 = this.Texture2;
			if (texture2 != null)
			{
				texture2.SetUIActive(true);
			}
			UUITexture texture3 = this.Texture1;
			if (texture3 != null)
			{
				texture3.SetStretchRight(0f);
			}
			UUITexture texture4 = this.Texture2;
			if (texture4 != null)
			{
				texture4.SetStretchRight(0f);
			}
			UUITexture texture5 = this.Texture1;
			if (texture5 != null)
			{
				texture5.SetStretchLeft(0f);
			}
			UUITexture texture6 = this.Texture2;
			if (texture6 != null)
			{
				texture6.SetStretchLeft(0f);
			}
			UUITexture texture7 = this.Texture1;
			if (texture7 != null)
			{
				texture7.SetStretchTop(0f);
			}
			UUITexture texture8 = this.Texture2;
			if (texture8 != null)
			{
				texture8.SetStretchTop(0f);
			}
			UUITexture texture9 = this.Texture1;
			if (texture9 != null)
			{
				texture9.SetStretchBottom(0f);
			}
			UUITexture texture10 = this.Texture2;
			if (texture10 != null)
			{
				texture10.SetStretchBottom(0f);
			}
			float width = this.RootItem.GetWidth();
			float height = this.RootItem.GetHeight();
			if (this.BeforeRatio < this.AfterRatio)
			{
				this.IsWidthBlend = true;
				float num = height * this.BeforeRatio;
				float num2 = width / 2f + num / 2f;
				UUITexture texture11 = this.Texture1;
				if (texture11 != null)
				{
					texture11.SetStretchRight(num2);
				}
				UUITexture texture12 = this.Texture2;
				if (texture12 != null)
				{
					texture12.SetStretchLeft(num2);
				}
				this.Speed = (width - num) / 2f / this.BlendTime;
				this.CurrentValue = num2;
			}
			else
			{
				this.IsWidthBlend = false;
				float num3 = width / this.BeforeRatio;
				float num4 = height / 2f + num3 / 2f;
				UUITexture texture13 = this.Texture1;
				if (texture13 != null)
				{
					texture13.SetStretchTop(num4);
				}
				UUITexture texture14 = this.Texture2;
				if (texture14 != null)
				{
					texture14.SetStretchBottom(num4);
				}
				this.Speed = (height - num3) / 2f / this.BlendTime;
				this.CurrentValue = num4;
			}
			this.TickHandle = TickSystem.Instance.Add(new Action<float>(this.OnTick), "PlotAspectTransformView", ETickingGroup.TG_PrePhysics, false, 0, false).Id;
		}

		// Token: 0x0401C090 RID: 114832
		private bool StartBySizeChanged;

		// Token: 0x0401C091 RID: 114833
		private UUITexture Texture1;

		// Token: 0x0401C092 RID: 114834
		private UUITexture Texture2;

		// Token: 0x0401C093 RID: 114835
		private float BeforeRatio;

		// Token: 0x0401C094 RID: 114836
		private float AfterRatio;

		// Token: 0x0401C095 RID: 114837
		private float BlendTime;

		// Token: 0x0401C096 RID: 114838
		private float Duration;

		// Token: 0x0401C097 RID: 114839
		private float Speed;

		// Token: 0x0401C098 RID: 114840
		private float CurrentValue;

		// Token: 0x0401C099 RID: 114841
		private bool IsWidthBlend;

		// Token: 0x0401C09A RID: 114842
		private int TickHandle = -1;

		// Token: 0x0401C09B RID: 114843
		private bool AutoClose;

		// Token: 0x0401C09C RID: 114844
		private Action Callback;

		// Token: 0x0200B1A5 RID: 45477
		[NullableContext(0)]
		private static class EChildItem
		{
			// Token: 0x04035DFF RID: 220671
			public const int Texture1 = 0;

			// Token: 0x04035E00 RID: 220672
			public const int Texture2 = 1;
		}
	}
}
