using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E31 RID: 3633
	public class IEntityMatchAllCharacter : IEntityMatchConfig
	{
		// Token: 0x0600524A RID: 21066 RVA: 0x000CB88E File Offset: 0x000C9A8E
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

		// Token: 0x170019E3 RID: 6627
		// (get) Token: 0x0600524B RID: 21067 RVA: 0x000CB8AD File Offset: 0x000C9AAD
		public override EEntityMatchType Type
		{
			get
			{
				return (EEntityMatchType)this.Instance.Type;
			}
		}

		// Token: 0x04002EFE RID: 12030
		private IEntityMatchAllCharacter Instance;
	}
}
