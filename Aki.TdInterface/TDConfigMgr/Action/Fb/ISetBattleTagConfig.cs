using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026E5 RID: 9957
	public class ISetBattleTagConfig
	{
		// Token: 0x0600DE6D RID: 56941 RVA: 0x0020FFEC File Offset: 0x0020E1EC
		[NullableContext(1)]
		public static ISetBattleTagConfig Create(ISetBattleTagConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetBattleTagConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004265 RID: 16997
		// (get) Token: 0x0600DE6E RID: 56942 RVA: 0x0021000B File Offset: 0x0020E20B
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17004266 RID: 16998
		// (get) Token: 0x0600DE6F RID: 56943 RVA: 0x00210018 File Offset: 0x0020E218
		public virtual int TagConfigId
		{
			get
			{
				return this.Instance.TagConfigId;
			}
		}

		// Token: 0x17004267 RID: 16999
		// (get) Token: 0x0600DE70 RID: 56944 RVA: 0x00210028 File Offset: 0x0020E228
		public virtual int? DelayTime
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.DelayTime);
			}
		}

		// Token: 0x04007B77 RID: 31607
		private ISetBattleTagConfig Instance;
	}
}
