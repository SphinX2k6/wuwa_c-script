using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029E0 RID: 10720
	public class IPreloadPhantomCharacterForSkill : IPreloadCharacterType
	{
		// Token: 0x0600ECCE RID: 60622 RVA: 0x002290D1 File Offset: 0x002272D1
		[NullableContext(1)]
		public static IPreloadPhantomCharacterForSkill Create(IPreloadPhantomCharacterForSkill? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPreloadPhantomCharacterForSkill
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004AD0 RID: 19152
		// (get) Token: 0x0600ECCF RID: 60623 RVA: 0x002290F0 File Offset: 0x002272F0
		public override EPreloadObjectType Type
		{
			get
			{
				return (EPreloadObjectType)this.Instance.Type;
			}
		}

		// Token: 0x17004AD1 RID: 19153
		// (get) Token: 0x0600ECD0 RID: 60624 RVA: 0x002290FD File Offset: 0x002272FD
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x0400826A RID: 33386
		private IPreloadPhantomCharacterForSkill Instance;
	}
}
