using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B5D RID: 2909
	[NullableContext(1)]
	[Nullable(0)]
	public class IItemLockingConfig
	{
		// Token: 0x06004303 RID: 17155 RVA: 0x000AAEDF File Offset: 0x000A90DF
		public static IItemLockingConfig Create(IItemLockingConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IItemLockingConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001206 RID: 4614
		// (get) Token: 0x06004304 RID: 17156 RVA: 0x000AAEFE File Offset: 0x000A90FE
		public virtual string EffectPath
		{
			get
			{
				return this.Instance.EffectPath;
			}
		}

		// Token: 0x17001207 RID: 4615
		// (get) Token: 0x06004305 RID: 17157 RVA: 0x000AAF0C File Offset: 0x000A910C
		public virtual ETeleControlLockingPerform? TeleControlPerform
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new ETeleControlLockingPerform?((ETeleControlLockingPerform)this.Instance.TeleControlPerform);
			}
		}

		// Token: 0x040025CE RID: 9678
		private IItemLockingConfig Instance;
	}
}
