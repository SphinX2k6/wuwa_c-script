using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x0200401A RID: 16410
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotAspectTransformView : UiPanelBase
	{
		// Token: 0x06029895 RID: 170133 RVA: 0x00BBA43C File Offset: 0x00BB863C
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

		// Token: 0x06029896 RID: 170134 RVA: 0x00BBA4A8 File Offset: 0x00BB86A8
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

		// Token: 0x06029897 RID: 170135 RVA: 0x00BBA555 File Offset: 0x00BB8755
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.UIViewPortSizeChanged, new Action(this.OnSizeChanged));
		}

		// Token: 0x06029898 RID: 170136 RVA: 0x00BBA570 File Offset: 0x00BB8770
		protected override void OnBeforeShow()
		{
		}

		// Token: 0x06029899 RID: 170137 RVA: 0x00BBA572 File Offset: 0x00BB8772
		protected override void OnAfterShow()
		{
		}

		// Token: 0x0602989A RID: 170138 RVA: 0x00BBA574 File Offset: 0x00BB8774
		protected override void OnBeforeHide()
		{
			if (this.TickHandle == -1)
			{
				return;
			}
			TickSystem.Instance.Remove(this.TickHandle);
			this.TickHandle = -1;
		}

		// Token: 0x0602989B RID: 170139 RVA: 0x00BBA598 File Offset: 0x00BB8798
		public void EnableAutoBlendOut(float blendTime)
		{
			this.BlendTime = blendTime;
			this.BeforeRatio = this.RootItem.GetWidth() / this.RootItem.GetHeight();
			this.StartBySizeChanged = true;
		}

		// Token: 0x0602989C RID: 170140 RVA: 0x00BBA5C8 File Offset: 0x00BB87C8
		public void ManualBlendOut(float blendTime, float startRatio, Action callback = null, bool autoClose = true)
		{
			this.BlendTime = blendTime;
			this.Callback = callback;
			this.AutoClose = autoClose;
			this.BeforeRatio = startRatio;
			this.AfterRatio = this.RootItem.GetWidth() / this.RootItem.GetHeight();
			this.StartTransform();
		}

		// Token: 0x0602989D RID: 170141 RVA: 0x00BBA618 File Offset: 0x00BB8818
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

		// Token: 0x0602989E RID: 170142 RVA: 0x00BBA790 File Offset: 0x00BB8990
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

		// Token: 0x0602989F RID: 170143 RVA: 0x00BBA860 File Offset: 0x00BB8A60
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

		// Token: 0x060298A0 RID: 170144 RVA: 0x00BBA8A4 File Offset: 0x00BB8AA4
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

		// Token: 0x04016AB3 RID: 92851
		private bool StartBySizeChanged;

		// Token: 0x04016AB4 RID: 92852
		private UUITexture Texture1;

		// Token: 0x04016AB5 RID: 92853
		private UUITexture Texture2;

		// Token: 0x04016AB6 RID: 92854
		private float BeforeRatio;

		// Token: 0x04016AB7 RID: 92855
		private float AfterRatio;

		// Token: 0x04016AB8 RID: 92856
		private float BlendTime;

		// Token: 0x04016AB9 RID: 92857
		private float Duration;

		// Token: 0x04016ABA RID: 92858
		private float Speed;

		// Token: 0x04016ABB RID: 92859
		private float CurrentValue;

		// Token: 0x04016ABC RID: 92860
		private bool IsWidthBlend;

		// Token: 0x04016ABD RID: 92861
		private int TickHandle = -1;

		// Token: 0x04016ABE RID: 92862
		private bool AutoClose;

		// Token: 0x04016ABF RID: 92863
		private Action Callback;

		// Token: 0x02009BDF RID: 39903
		[NullableContext(0)]
		private static class EChildItem
		{
			// Token: 0x04030854 RID: 198740
			public const int Texture1 = 0;

			// Token: 0x04030855 RID: 198741
			public const int Texture2 = 1;
		}
	}
}
