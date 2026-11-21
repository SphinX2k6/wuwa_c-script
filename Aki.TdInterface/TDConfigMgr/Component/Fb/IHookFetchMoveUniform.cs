using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BF0 RID: 3056
	public class IHookFetchMoveUniform : IHookFetchMoveModeBase
	{
		// Token: 0x06004628 RID: 17960 RVA: 0x000B2D86 File Offset: 0x000B0F86
		public static IHookFetchMoveUniform Create(IHookFetchMoveUniform? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHookFetchMoveUniform
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001243 RID: 4675
		// (get) Token: 0x06004629 RID: 17961 RVA: 0x000B2DA5 File Offset: 0x000B0FA5
		public override EHookFetchMoveMode Type
		{
			get
			{
				return (EHookFetchMoveMode)this.Instance.Type;
			}
		}

		// Token: 0x17001244 RID: 4676
		// (get) Token: 0x0600462A RID: 17962 RVA: 0x000B2DB2 File Offset: 0x000B0FB2
		public virtual float Speed
		{
			get
			{
				return this.Instance.Speed;
			}
		}

		// Token: 0x04002763 RID: 10083
		private IHookFetchMoveUniform Instance;
	}
}
