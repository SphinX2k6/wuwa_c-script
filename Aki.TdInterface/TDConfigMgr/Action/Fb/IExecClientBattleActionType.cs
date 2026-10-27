using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026F0 RID: 9968
	public class IExecClientBattleActionType
	{
		// Token: 0x0600DE9B RID: 56987 RVA: 0x002105FA File Offset: 0x0020E7FA
		[NullableContext(1)]
		public static IExecClientBattleActionType Create(IExecClientBattleActionType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExecClientBattleActionType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700427D RID: 17021
		// (get) Token: 0x0600DE9C RID: 56988 RVA: 0x00210619 File Offset: 0x0020E819
		public virtual EExecClientBattleActionType Type
		{
			get
			{
				return (EExecClientBattleActionType)this.Instance.Type;
			}
		}

		// Token: 0x04007B92 RID: 31634
		private IExecClientBattleActionType Instance;
	}
}
