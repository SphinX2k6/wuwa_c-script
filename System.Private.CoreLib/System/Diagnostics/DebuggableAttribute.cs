using System;

namespace System.Diagnostics
{
	// Token: 0x0200087F RID: 2175
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module, AllowMultiple = false)]
	public sealed class DebuggableAttribute : Attribute
	{
		// Token: 0x06008934 RID: 35124 RVA: 0x0014DA53 File Offset: 0x0014BC53
		public DebuggableAttribute(bool isJITTrackingEnabled, bool isJITOptimizerDisabled)
		{
			this.DebuggingFlags = 0;
			if (isJITTrackingEnabled)
			{
				this.DebuggingFlags |= DebuggableAttribute.DebuggingModes.Default;
			}
			if (isJITOptimizerDisabled)
			{
				this.DebuggingFlags |= DebuggableAttribute.DebuggingModes.DisableOptimizations;
			}
		}

		// Token: 0x06008935 RID: 35125 RVA: 0x0014DA88 File Offset: 0x0014BC88
		public DebuggableAttribute(DebuggableAttribute.DebuggingModes modes)
		{
			this.DebuggingFlags = modes;
		}

		// Token: 0x17001212 RID: 4626
		// (get) Token: 0x06008936 RID: 35126 RVA: 0x0014DA97 File Offset: 0x0014BC97
		public bool IsJITTrackingEnabled
		{
			get
			{
				return (this.DebuggingFlags & DebuggableAttribute.DebuggingModes.Default) > DebuggableAttribute.DebuggingModes.None;
			}
		}

		// Token: 0x17001213 RID: 4627
		// (get) Token: 0x06008937 RID: 35127 RVA: 0x0014DAA4 File Offset: 0x0014BCA4
		public bool IsJITOptimizerDisabled
		{
			get
			{
				return (this.DebuggingFlags & DebuggableAttribute.DebuggingModes.DisableOptimizations) > DebuggableAttribute.DebuggingModes.None;
			}
		}

		// Token: 0x17001214 RID: 4628
		// (get) Token: 0x06008938 RID: 35128 RVA: 0x0014DAB5 File Offset: 0x0014BCB5
		public DebuggableAttribute.DebuggingModes DebuggingFlags { get; }

		// Token: 0x02000880 RID: 2176
		[Flags]
		public enum DebuggingModes
		{
			// Token: 0x04001E28 RID: 7720
			None = 0,
			// Token: 0x04001E29 RID: 7721
			Default = 1,
			// Token: 0x04001E2A RID: 7722
			DisableOptimizations = 256,
			// Token: 0x04001E2B RID: 7723
			IgnoreSymbolStoreSequencePoints = 2,
			// Token: 0x04001E2C RID: 7724
			EnableEditAndContinue = 4
		}
	}
}
