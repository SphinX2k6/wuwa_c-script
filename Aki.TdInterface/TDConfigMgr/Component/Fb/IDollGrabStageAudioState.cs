using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DF5 RID: 3573
	[NullableContext(1)]
	[Nullable(0)]
	public class IDollGrabStageAudioState
	{
		// Token: 0x060050F0 RID: 20720 RVA: 0x000C7CD0 File Offset: 0x000C5ED0
		public static IDollGrabStageAudioState Create(IDollGrabStageAudioState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDollGrabStageAudioState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001AC3 RID: 6851
		// (get) Token: 0x060050F1 RID: 20721 RVA: 0x000C7CEF File Offset: 0x000C5EEF
		public virtual string Group
		{
			get
			{
				return this.Instance.Group;
			}
		}

		// Token: 0x17001AC4 RID: 6852
		// (get) Token: 0x060050F2 RID: 20722 RVA: 0x000C7CFC File Offset: 0x000C5EFC
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x04002E86 RID: 11910
		private IDollGrabStageAudioState Instance;
	}
}
