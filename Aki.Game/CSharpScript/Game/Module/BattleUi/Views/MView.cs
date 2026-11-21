using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.BaseConfig;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D88 RID: 19848
	public class MView : UiTickViewBase
	{
		// Token: 0x06031D5B RID: 204123 RVA: 0x00DEFF4B File Offset: 0x00DEE14B
		[NullableContext(1)]
		public MView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06031D5C RID: 204124 RVA: 0x00DEFF60 File Offset: 0x00DEE160
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031D5D RID: 204125 RVA: 0x00DEFFA8 File Offset: 0x00DEE1A8
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.MReady, new Action(this.UpdateMask));
		}

		// Token: 0x06031D5E RID: 204126 RVA: 0x00DEFFC6 File Offset: 0x00DEE1C6
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.MReady, new Action(this.UpdateMask));
		}

		// Token: 0x06031D5F RID: 204127 RVA: 0x00DEFFE4 File Offset: 0x00DEE1E4
		protected override void OnStart()
		{
			if (!BaseConfigController.Instance.GetRptIsOpen())
			{
				this.MaskReady = true;
				return;
			}
			this.MaskPath = LoginModel.Instance.GetWaterMarkPath();
			this.InitMask();
		}

		// Token: 0x06031D60 RID: 204128 RVA: 0x00DF0010 File Offset: 0x00DEE210
		protected override void OnTick(float deltaTime)
		{
			if (this.MaskReady)
			{
				return;
			}
			if (this.MaskCheckTimeMs > 1000)
			{
				this.MaskCheckTimeMs = 0;
				this.InitMask();
				return;
			}
			this.MaskCheckTimeMs += (int)deltaTime;
		}

		// Token: 0x06031D61 RID: 204129 RVA: 0x00DF0045 File Offset: 0x00DEE245
		private void UpdateMask()
		{
			this.InitMask();
		}

		// Token: 0x06031D62 RID: 204130 RVA: 0x00DF0050 File Offset: 0x00DEE250
		private void InitMask()
		{
			if (UKuroStaticLibrary.FileExists(this.MaskPath))
			{
				this.MaskReady = true;
				UUITexture texture = base.GetTexture(0);
				string maskPath = this.MaskPath;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Mask");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.Index);
				UTexture2D utexture2D = ULGUIBPLibrary.CreateTexture2DFromPath(maskPath, defaultInterpolatedStringHandler.ToStringAndClear(), 0);
				this.Index++;
				if (utexture2D != null)
				{
					if (texture != null)
					{
						texture.SetTexture(utexture2D);
					}
					if (texture != null)
					{
						texture.SetUIActive(true);
					}
				}
			}
		}

		// Token: 0x0401A611 RID: 108049
		private const int CHECK_INTERVAL = 1000;

		// Token: 0x0401A612 RID: 108050
		private bool MaskReady;

		// Token: 0x0401A613 RID: 108051
		[Nullable(1)]
		private string MaskPath = "";

		// Token: 0x0401A614 RID: 108052
		private int MaskCheckTimeMs;

		// Token: 0x0401A615 RID: 108053
		private int Index;

		// Token: 0x0200AA86 RID: 43654
		private enum EComponents
		{
			// Token: 0x04034B39 RID: 215865
			ItemMask
		}
	}
}
