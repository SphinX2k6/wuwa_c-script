using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024EA RID: 9450
	public class ILevelPlayVarContext : IVarContext
	{
		// Token: 0x0600D2F8 RID: 54008 RVA: 0x001F4ABF File Offset: 0x001F2CBF
		[NullableContext(1)]
		public static ILevelPlayVarContext Create(ILevelPlayVarContext? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILevelPlayVarContext
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003AE6 RID: 15078
		// (get) Token: 0x0600D2F9 RID: 54009 RVA: 0x001F4ADE File Offset: 0x001F2CDE
		public override EVarContext Type
		{
			get
			{
				return (EVarContext)this.Instance.Type;
			}
		}

		// Token: 0x17003AE7 RID: 15079
		// (get) Token: 0x0600D2FA RID: 54010 RVA: 0x001F4AEB File Offset: 0x001F2CEB
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x040073B4 RID: 29620
		private ILevelPlayVarContext Instance;
	}
}
