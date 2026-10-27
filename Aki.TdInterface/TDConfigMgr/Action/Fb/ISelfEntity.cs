using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027BB RID: 10171
	public class ISelfEntity : ITargetEntityType
	{
		// Token: 0x0600E246 RID: 57926 RVA: 0x00216CFF File Offset: 0x00214EFF
		[NullableContext(1)]
		public static ISelfEntity Create(ISelfEntity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISelfEntity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004492 RID: 17554
		// (get) Token: 0x0600E247 RID: 57927 RVA: 0x00216D1E File Offset: 0x00214F1E
		public override ETargetEntityType Type
		{
			get
			{
				return (ETargetEntityType)this.Instance.Type;
			}
		}

		// Token: 0x04007D7B RID: 32123
		private ISelfEntity Instance;
	}
}
