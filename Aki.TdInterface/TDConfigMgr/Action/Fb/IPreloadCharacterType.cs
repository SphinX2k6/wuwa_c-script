using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029DE RID: 10718
	public class IPreloadCharacterType
	{
		// Token: 0x0600ECC7 RID: 60615 RVA: 0x00228FFE File Offset: 0x002271FE
		[NullableContext(1)]
		public static IPreloadCharacterType Create(IPreloadCharacterType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPreloadCharacterType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004ACD RID: 19149
		// (get) Token: 0x0600ECC8 RID: 60616 RVA: 0x0022901D File Offset: 0x0022721D
		public virtual EPreloadObjectType Type
		{
			get
			{
				return (EPreloadObjectType)this.Instance.Type;
			}
		}

		// Token: 0x04008266 RID: 33382
		private IPreloadCharacterType Instance;
	}
}
