using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024D8 RID: 9432
	[NullableContext(1)]
	[Nullable(0)]
	public class WaitUntilLevelSequenceReachMark : ActionParams
	{
		// Token: 0x0600D2A2 RID: 53922 RVA: 0x001F3F49 File Offset: 0x001F2149
		public static WaitUntilLevelSequenceReachMark Create(IWaitUntilLevelSequenceReachMark? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new WaitUntilLevelSequenceReachMark
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003AB4 RID: 15028
		// (get) Token: 0x0600D2A3 RID: 53923 RVA: 0x001F3F68 File Offset: 0x001F2168
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17003AB5 RID: 15029
		// (get) Token: 0x0600D2A4 RID: 53924 RVA: 0x001F3F75 File Offset: 0x001F2175
		public virtual string Mark
		{
			get
			{
				return this.Instance.Mark;
			}
		}

		// Token: 0x04007386 RID: 29574
		private IWaitUntilLevelSequenceReachMark Instance;
	}
}
