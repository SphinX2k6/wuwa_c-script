using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BD0 RID: 3024
	public class INpcSpecialMarkBase
	{
		// Token: 0x0600457E RID: 17790 RVA: 0x000AFF81 File Offset: 0x000AE181
		[NullableContext(1)]
		public static INpcSpecialMarkBase Create(INpcSpecialMarkBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcSpecialMarkBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700139B RID: 5019
		// (get) Token: 0x0600457F RID: 17791 RVA: 0x000AFFA0 File Offset: 0x000AE1A0
		public virtual ESpecialNpcMarkType Type
		{
			get
			{
				return (ESpecialNpcMarkType)this.Instance.Type;
			}
		}

		// Token: 0x04002789 RID: 10121
		private INpcSpecialMarkBase Instance;
	}
}
