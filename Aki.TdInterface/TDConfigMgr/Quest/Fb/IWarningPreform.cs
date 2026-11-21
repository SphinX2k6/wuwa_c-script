using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001584 RID: 5508
	public class IWarningPreform
	{
		// Token: 0x06007C38 RID: 31800 RVA: 0x001272D8 File Offset: 0x001254D8
		public static IWarningPreform Create(IWarningPreform? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWarningPreform
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170028D2 RID: 10450
		// (get) Token: 0x06007C39 RID: 31801 RVA: 0x001272F7 File Offset: 0x001254F7
		public virtual IWarningPreformType Type
		{
			get
			{
				if (this._TypeInited)
				{
					return this._TypeCache;
				}
				this._TypeInited = true;
				this._TypeCache = QuestReadHelper.ReadIWarningPreform_Type(this.Instance);
				return this._TypeCache;
			}
		}

		// Token: 0x0400479C RID: 18332
		private IWarningPreform Instance;

		// Token: 0x0400479D RID: 18333
		private IWarningPreformType _TypeCache;

		// Token: 0x0400479E RID: 18334
		private bool _TypeInited;
	}
}
