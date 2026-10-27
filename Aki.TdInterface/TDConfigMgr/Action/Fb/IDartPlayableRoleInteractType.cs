using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002873 RID: 10355
	public class IDartPlayableRoleInteractType : IDartInteractTypeBase
	{
		// Token: 0x0600E56F RID: 58735 RVA: 0x0021BB7B File Offset: 0x00219D7B
		[NullableContext(1)]
		public static IDartPlayableRoleInteractType Create(IDartPlayableRoleInteractType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDartPlayableRoleInteractType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700464B RID: 17995
		// (get) Token: 0x0600E570 RID: 58736 RVA: 0x0021BB9A File Offset: 0x00219D9A
		public override EDartInteractType Type
		{
			get
			{
				return (EDartInteractType)this.Instance.Type;
			}
		}

		// Token: 0x1700464C RID: 17996
		// (get) Token: 0x0600E571 RID: 58737 RVA: 0x0021BBA7 File Offset: 0x00219DA7
		public virtual int CompetitorId
		{
			get
			{
				return this.Instance.CompetitorId;
			}
		}

		// Token: 0x04007EDB RID: 32475
		private IDartPlayableRoleInteractType Instance;
	}
}
