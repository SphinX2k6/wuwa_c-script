using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200278F RID: 10127
	public class ILevelPlayVarContext : IVarContext
	{
		// Token: 0x0600E04E RID: 57422 RVA: 0x00210357 File Offset: 0x0020E557
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

		// Token: 0x17003DDE RID: 15838
		// (get) Token: 0x0600E04F RID: 57423 RVA: 0x00210376 File Offset: 0x0020E576
		public override EVarContext Type
		{
			get
			{
				return (EVarContext)this.Instance.Type;
			}
		}

		// Token: 0x17003DDF RID: 15839
		// (get) Token: 0x0600E050 RID: 57424 RVA: 0x00210383 File Offset: 0x0020E583
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x04007A01 RID: 31233
		private ILevelPlayVarContext Instance;
	}
}
