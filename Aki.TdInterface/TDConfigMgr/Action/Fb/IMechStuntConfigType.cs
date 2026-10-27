using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200280A RID: 10250
	public class IMechStuntConfigType
	{
		// Token: 0x0600E375 RID: 58229 RVA: 0x00218652 File Offset: 0x00216852
		[NullableContext(1)]
		public static IMechStuntConfigType Create(IMechStuntConfigType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechStuntConfigType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004523 RID: 17699
		// (get) Token: 0x0600E376 RID: 58230 RVA: 0x00218671 File Offset: 0x00216871
		public virtual EMechStuntType Type
		{
			get
			{
				return (EMechStuntType)this.Instance.Type;
			}
		}

		// Token: 0x04007DF0 RID: 32240
		private IMechStuntConfigType Instance;
	}
}
