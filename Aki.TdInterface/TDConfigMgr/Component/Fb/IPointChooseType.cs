using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DB0 RID: 3504
	public class IPointChooseType
	{
		// Token: 0x06004F94 RID: 20372 RVA: 0x000C5065 File Offset: 0x000C3265
		[NullableContext(1)]
		public static IPointChooseType Create(IPointChooseType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPointChooseType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170019F1 RID: 6641
		// (get) Token: 0x06004F95 RID: 20373 RVA: 0x000C5084 File Offset: 0x000C3284
		public virtual EPointChooseType Type
		{
			get
			{
				return (EPointChooseType)this.Instance.Type;
			}
		}

		// Token: 0x04002DA7 RID: 11687
		private IPointChooseType Instance;
	}
}
