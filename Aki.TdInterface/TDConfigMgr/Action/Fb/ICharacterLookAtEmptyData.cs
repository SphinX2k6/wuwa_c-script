using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002629 RID: 9769
	public class ICharacterLookAtEmptyData : ICharacterLookAtData
	{
		// Token: 0x0600DB45 RID: 56133 RVA: 0x0020A632 File Offset: 0x00208832
		[NullableContext(1)]
		public static ICharacterLookAtEmptyData Create(ICharacterLookAtEmptyData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICharacterLookAtEmptyData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170040B5 RID: 16565
		// (get) Token: 0x0600DB46 RID: 56134 RVA: 0x0020A651 File Offset: 0x00208851
		public override ECharacterLookAt Type
		{
			get
			{
				return (ECharacterLookAt)this.Instance.Type;
			}
		}

		// Token: 0x040079CF RID: 31183
		private ICharacterLookAtEmptyData Instance;
	}
}
