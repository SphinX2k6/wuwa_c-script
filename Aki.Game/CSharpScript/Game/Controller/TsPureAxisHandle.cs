using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Controller
{
	// Token: 0x020063FE RID: 25598
	[NullableContext(2)]
	[Nullable(0)]
	public class TsPureAxisHandle
	{
		// Token: 0x0603E14F RID: 254287 RVA: 0x01202E2A File Offset: 0x0120102A
		[NullableContext(1)]
		public void Initialize(TsBasePlayerController playerController)
		{
			this.PlayerController = playerController;
			this.OnInputStat = Stat.Create("TsPureAxisHandle.OnInputAxis", "", "STATGROUP_KuroBattle");
		}

		// Token: 0x0603E150 RID: 254288 RVA: 0x01202E50 File Offset: 0x01201050
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

		// Token: 0x0603E151 RID: 254289 RVA: 0x01202EB4 File Offset: 0x012010B4
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

		// Token: 0x0603E152 RID: 254290 RVA: 0x01202FA7 File Offset: 0x012011A7
		private void OnInputAxis(float value)
		{
			this.OnInputAxisCallback(this.AxisName, value, false);
		}

		// Token: 0x0603E153 RID: 254291 RVA: 0x01202FBC File Offset: 0x012011BC
		private void OnAlwaysInputAxis(float value)
		{
			this.OnInputAxisCallback(this.AxisName, value, true);
		}

		// Token: 0x04020F23 RID: 134947
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

		// Token: 0x04020F24 RID: 134948
		private TsBasePlayerController PlayerController;

		// Token: 0x04020F25 RID: 134949
		private string AxisName;

		// Token: 0x04020F26 RID: 134950
		private Stat OnInputStat;

		// Token: 0x04020F27 RID: 134951
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<string, float, bool> OnInputAxisCallback;

		// Token: 0x04020F28 RID: 134952
		private FAxisBindingDelegate OnInputAxisDelegate;

		// Token: 0x04020F29 RID: 134953
		private FAxisBindingDelegate OnAlwaysInputAxisDelegate;
	}
}
