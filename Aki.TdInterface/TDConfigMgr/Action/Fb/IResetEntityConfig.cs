using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200297E RID: 10622
	public class IResetEntityConfig
	{
		// Token: 0x0600EB56 RID: 60246 RVA: 0x00226D12 File Offset: 0x00224F12
		[NullableContext(1)]
		public static IResetEntityConfig Create(IResetEntityConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IResetEntityConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A1C RID: 18972
		// (get) Token: 0x0600EB57 RID: 60247 RVA: 0x00226D31 File Offset: 0x00224F31
		public virtual EResetEntityType Type
		{
			get
			{
				return (EResetEntityType)this.Instance.Type;
			}
		}

		// Token: 0x0400819A RID: 33178
		private IResetEntityConfig Instance;
	}
}
