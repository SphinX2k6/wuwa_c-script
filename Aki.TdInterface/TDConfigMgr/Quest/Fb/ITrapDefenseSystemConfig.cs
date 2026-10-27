using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020012DE RID: 4830
	[NullableContext(1)]
	[Nullable(0)]
	public class ITrapDefenseSystemConfig : IEnableSystemConfig
	{
		// Token: 0x06006E5E RID: 28254 RVA: 0x0010ABF9 File Offset: 0x00108DF9
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

		// Token: 0x17002275 RID: 8821
		// (get) Token: 0x06006E5F RID: 28255 RVA: 0x0010AC18 File Offset: 0x00108E18
		public override EEnableSystemType Type
		{
			get
			{
				return (EEnableSystemType)this.Instance.Type;
			}
		}

		// Token: 0x17002276 RID: 8822
		// (get) Token: 0x06006E60 RID: 28256 RVA: 0x0010AC25 File Offset: 0x00108E25
		public virtual int TrapDefenseId
		{
			get
			{
				return this.Instance.TrapDefenseId;
			}
		}

		// Token: 0x17002277 RID: 8823
		// (get) Token: 0x06006E61 RID: 28257 RVA: 0x0010AC34 File Offset: 0x00108E34
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

		// Token: 0x04003F3A RID: 16186
		private ITrapDefenseSystemConfig Instance;

		// Token: 0x04003F3B RID: 16187
		private List<ITrapDefenseSystemVar> _VarsCache;

		// Token: 0x04003F3C RID: 16188
		private bool _VarsInited;
	}
}
