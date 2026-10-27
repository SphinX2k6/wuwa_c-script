using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026D6 RID: 9942
	public class ISetBattleTagType
	{
		// Token: 0x0600DE34 RID: 56884 RVA: 0x0020FA03 File Offset: 0x0020DC03
		[NullableContext(1)]
		public static ISetBattleTagType Create(ISetBattleTagType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetBattleTagType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700424A RID: 16970
		// (get) Token: 0x0600DE35 RID: 56885 RVA: 0x0020FA22 File Offset: 0x0020DC22
		public virtual ESetBattleTagType Type
		{
			get
			{
				return (ESetBattleTagType)this.Instance.Type;
			}
		}

		// Token: 0x04007B5E RID: 31582
		private ISetBattleTagType Instance;
	}
}
