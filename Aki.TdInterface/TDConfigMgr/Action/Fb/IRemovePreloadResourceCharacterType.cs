using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029E5 RID: 10725
	public class IRemovePreloadResourceCharacterType
	{
		// Token: 0x0600ECE1 RID: 60641 RVA: 0x002292AB File Offset: 0x002274AB
		[NullableContext(1)]
		public static IRemovePreloadResourceCharacterType Create(IRemovePreloadResourceCharacterType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRemovePreloadResourceCharacterType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004AD9 RID: 19161
		// (get) Token: 0x0600ECE2 RID: 60642 RVA: 0x002292CA File Offset: 0x002274CA
		public virtual ERemovePreloadResourceObjectType Type
		{
			get
			{
				return (ERemovePreloadResourceObjectType)this.Instance.Type;
			}
		}

		// Token: 0x04008275 RID: 33397
		private IRemovePreloadResourceCharacterType Instance;
	}
}
