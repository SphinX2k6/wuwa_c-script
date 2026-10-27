using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DAD RID: 3501
	public class IMonsterChooseType
	{
		// Token: 0x06004F89 RID: 20361 RVA: 0x000C4F52 File Offset: 0x000C3152
		[NullableContext(1)]
		public static IMonsterChooseType Create(IMonsterChooseType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterChooseType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170019EC RID: 6636
		// (get) Token: 0x06004F8A RID: 20362 RVA: 0x000C4F71 File Offset: 0x000C3171
		public virtual EMonsterChooseType Type
		{
			get
			{
				return (EMonsterChooseType)this.Instance.Type;
			}
		}

		// Token: 0x04002DA2 RID: 11682
		private IMonsterChooseType Instance;
	}
}
