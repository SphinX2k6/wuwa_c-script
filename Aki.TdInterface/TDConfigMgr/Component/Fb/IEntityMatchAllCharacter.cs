using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D37 RID: 3383
	public class IEntityMatchAllCharacter : IEntityMatchConfig
	{
		// Token: 0x06004D2E RID: 19758 RVA: 0x000C014A File Offset: 0x000BE34A
		[NullableContext(1)]
		public static IEntityMatchAllCharacter Create(IEntityMatchAllCharacter? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityMatchAllCharacter
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700187D RID: 6269
		// (get) Token: 0x06004D2F RID: 19759 RVA: 0x000C0169 File Offset: 0x000BE369
		public override EEntityMatchType Type
		{
			get
			{
				return (EEntityMatchType)this.Instance.Type;
			}
		}

		// Token: 0x04002C3E RID: 11326
		private IEntityMatchAllCharacter Instance;
	}
}
