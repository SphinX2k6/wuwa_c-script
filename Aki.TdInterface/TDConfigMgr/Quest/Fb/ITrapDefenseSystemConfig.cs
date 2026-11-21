using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001424 RID: 5156
	public class ITrapDefenseSystemConfig : IEnableSystemConfig
	{
		// Token: 0x060074DE RID: 29918 RVA: 0x00118EF9 File Offset: 0x001170F9
		public static ITrapDefenseSystemConfig Create(ITrapDefenseSystemConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrapDefenseSystemConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002438 RID: 9272
		// (get) Token: 0x060074DF RID: 29919 RVA: 0x00118F18 File Offset: 0x00117118
		public override EEnableSystemType Type
		{
			get
			{
				return (EEnableSystemType)this.Instance.Type;
			}
		}

		// Token: 0x17002439 RID: 9273
		// (get) Token: 0x060074E0 RID: 29920 RVA: 0x00118F25 File Offset: 0x00117125
		public virtual int TrapDefenseId
		{
			get
			{
				return this.Instance.TrapDefenseId;
			}
		}

		// Token: 0x1700243A RID: 9274
		// (get) Token: 0x060074E1 RID: 29921 RVA: 0x00118F34 File Offset: 0x00117134
		public virtual List<ITrapDefenseSystemVar> Vars
		{
			get
			{
				if (this._VarsInited)
				{
					return this._VarsCache;
				}
				this._VarsInited = true;
				int varsLength = this.Instance.VarsLength;
				this._VarsCache = new List<ITrapDefenseSystemVar>(varsLength);
				for (int i = 0; i < varsLength; i++)
				{
					this._VarsCache.Add(ITrapDefenseSystemVar.Create(this.Instance.Vars(i)));
				}
				return this._VarsCache;
			}
		}

		// Token: 0x040042A8 RID: 17064
		private ITrapDefenseSystemConfig Instance;

		// Token: 0x040042A9 RID: 17065
		private List<ITrapDefenseSystemVar> _VarsCache;

		// Token: 0x040042AA RID: 17066
		private bool _VarsInited;
	}
}
