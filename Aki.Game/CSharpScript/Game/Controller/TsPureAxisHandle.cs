using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Controller
{
	// Token: 0x0200727F RID: 29311
	[NullableContext(2)]
	[Nullable(0)]
	public class TsPureAxisHandle
	{
		// Token: 0x06047D8F RID: 294287 RVA: 0x012623E6 File Offset: 0x012605E6
		[NullableContext(1)]
		public void Initialize(TsBasePlayerController playerController)
		{
			this.PlayerController = playerController;
			this.OnInputStat = Stat.Create("TsPureAxisHandle.OnInputAxis", "", "STATGROUP_KuroBattle");
		}

		// Token: 0x06047D90 RID: 294288 RVA: 0x0126240C File Offset: 0x0126060C
		public void Reset()
		{
			this.PlayerController = null;
			this.AxisName = null;
			this.OnInputAxisCallback = null;
			if (this.OnInputAxisDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.OnInputAxis));
				this.OnInputAxisDelegate = null;
			}
			if (this.OnAlwaysInputAxisDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.OnAlwaysInputAxis));
				this.OnAlwaysInputAxisDelegate = null;
			}
		}

		// Token: 0x06047D91 RID: 294289 RVA: 0x01262470 File Offset: 0x01260670
		[NullableContext(1)]
		public void AddAxisBinding(string axisName, Action<string, float, bool> onInputAxis)
		{
			if (onInputAxis == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Controller;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "添加Axis输入绑定时，回调不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("axisName", axisName);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.AxisName = axisName;
			this.OnInputAxisCallback = onInputAxis;
			if (TsPureAxisHandle.OptimizeTickAxisName.Contains(axisName))
			{
				if (this.OnInputAxisDelegate == null)
				{
					this.OnInputAxisDelegate = DelegateUtils.ToManualReleaseDelegate<FAxisBindingDelegate>(new Action<float>(this.OnInputAxis));
				}
				UKuroInputDelegateLibrary.RegisterAxisBinding(FNameUtil.GetDynamicFName(axisName) ?? FName.NAME_None, this.PlayerController, this.OnInputAxisDelegate);
				return;
			}
			if (this.OnAlwaysInputAxisDelegate == null)
			{
				this.OnAlwaysInputAxisDelegate = DelegateUtils.ToManualReleaseDelegate<FAxisBindingDelegate>(new Action<float>(this.OnAlwaysInputAxis));
			}
			UKuroInputDelegateLibrary.RegisterAxisBinding(FNameUtil.GetDynamicFName(axisName) ?? FName.NAME_None, this.PlayerController, this.OnAlwaysInputAxisDelegate);
		}

		// Token: 0x06047D92 RID: 294290 RVA: 0x01262563 File Offset: 0x01260763
		private void OnInputAxis(float value)
		{
			this.OnInputAxisCallback(this.AxisName, value, false);
		}

		// Token: 0x06047D93 RID: 294291 RVA: 0x01262578 File Offset: 0x01260778
		private void OnAlwaysInputAxis(float value)
		{
			this.OnInputAxisCallback(this.AxisName, value, true);
		}

		// Token: 0x04025C63 RID: 154723
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly List<string> OptimizeTickAxisName = new List<string>
		{
			"LookUp",
			"LookUpRate",
			"MoveForward",
			"MoveRight",
			"Turn",
			"Zoom",
			"MouseMove",
			"WheelAxis"
		};

		// Token: 0x04025C64 RID: 154724
		private TsBasePlayerController PlayerController;

		// Token: 0x04025C65 RID: 154725
		private string AxisName;

		// Token: 0x04025C66 RID: 154726
		private Stat OnInputStat;

		// Token: 0x04025C67 RID: 154727
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<string, float, bool> OnInputAxisCallback;

		// Token: 0x04025C68 RID: 154728
		private FAxisBindingDelegate OnInputAxisDelegate;

		// Token: 0x04025C69 RID: 154729
		private FAxisBindingDelegate OnAlwaysInputAxisDelegate;
	}
}
