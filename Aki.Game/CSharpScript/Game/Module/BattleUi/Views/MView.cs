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
	// Token: 0x02005DA6 RID: 23974
	public class MView : UiTickViewBase
	{
		// Token: 0x0603CDFE RID: 249342 RVA: 0x00E9F693 File Offset: 0x00E9D893
		[NullableContext(1)]
		public MView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603CDFF RID: 249343 RVA: 0x00E9F6A8 File Offset: 0x00E9D8A8
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

		// Token: 0x0603CE00 RID: 249344 RVA: 0x00E9F6F0 File Offset: 0x00E9D8F0
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.MReady, new Action(this.UpdateMask));
		}

		// Token: 0x0603CE01 RID: 249345 RVA: 0x00E9F70E File Offset: 0x00E9D90E
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.MReady, new Action(this.UpdateMask));
		}

		// Token: 0x0603CE02 RID: 249346 RVA: 0x00E9F72C File Offset: 0x00E9D92C
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

		// Token: 0x0603CE03 RID: 249347 RVA: 0x00E9F758 File Offset: 0x00E9D958
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

		// Token: 0x0603CE04 RID: 249348 RVA: 0x00E9F78D File Offset: 0x00E9D98D
		private void UpdateMask()
		{
			this.InitMask();
		}

		// Token: 0x0603CE05 RID: 249349 RVA: 0x00E9F798 File Offset: 0x00E9D998
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

		// Token: 0x0401FB59 RID: 129881
		private const int CHECK_INTERVAL = 1000;

		// Token: 0x0401FB5A RID: 129882
		private bool MaskReady;

		// Token: 0x0401FB5B RID: 129883
		[Nullable(1)]
		private string MaskPath = "";

		// Token: 0x0401FB5C RID: 129884
		private int MaskCheckTimeMs;

		// Token: 0x0401FB5D RID: 129885
		private int Index;

		// Token: 0x0200C080 RID: 49280
		private enum EComponents
		{
			// Token: 0x0403A176 RID: 237942
			ItemMask
		}
	}
}
