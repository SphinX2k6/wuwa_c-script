using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001446 RID: 5190
	public class ILogicProgramSpecialProcess
	{
		// Token: 0x0600755B RID: 30043 RVA: 0x00119C60 File Offset: 0x00117E60
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

		// Token: 0x17002471 RID: 9329
		// (get) Token: 0x0600755C RID: 30044 RVA: 0x00119C80 File Offset: 0x00117E80
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

		// Token: 0x040042F4 RID: 17140
		private ILogicProgramSpecialProcess Instance;

		// Token: 0x040042F5 RID: 17141
		private List<IDisableUro> _SpecialProcessListCache;

		// Token: 0x040042F6 RID: 17142
		private bool _SpecialProcessListInited;
	}
}
