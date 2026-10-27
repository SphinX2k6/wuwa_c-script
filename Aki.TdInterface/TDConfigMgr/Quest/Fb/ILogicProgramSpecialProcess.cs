using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020012F6 RID: 4854
	[NullableContext(1)]
	[Nullable(0)]
	public class ILogicProgramSpecialProcess
	{
		// Token: 0x06006EBB RID: 28347 RVA: 0x0010B6F4 File Offset: 0x001098F4
		public static ILogicProgramSpecialProcess Create(ILogicProgramSpecialProcess? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILogicProgramSpecialProcess
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170022A2 RID: 8866
		// (get) Token: 0x06006EBC RID: 28348 RVA: 0x0010B714 File Offset: 0x00109914
		public virtual List<IDisableUro> SpecialProcessList
		{
			get
			{
				if (this._SpecialProcessListInited)
				{
					return this._SpecialProcessListCache;
				}
				this._SpecialProcessListInited = true;
				int specialProcessListLength = this.Instance.SpecialProcessListLength;
				this._SpecialProcessListCache = new List<IDisableUro>(specialProcessListLength);
				for (int i = 0; i < specialProcessListLength; i++)
				{
					this._SpecialProcessListCache.Add(IDisableUro.Create(this.Instance.SpecialProcessList(i)));
				}
				return this._SpecialProcessListCache;
			}
		}

		// Token: 0x04003F78 RID: 16248
		private ILogicProgramSpecialProcess Instance;

		// Token: 0x04003F79 RID: 16249
		private List<IDisableUro> _SpecialProcessListCache;

		// Token: 0x04003F7A RID: 16250
		private bool _SpecialProcessListInited;
	}
}
