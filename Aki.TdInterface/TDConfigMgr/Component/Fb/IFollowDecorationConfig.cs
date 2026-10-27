using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D10 RID: 3344
	public class IFollowDecorationConfig
	{
		// Token: 0x06004C58 RID: 19544 RVA: 0x000BE4A2 File Offset: 0x000BC6A2
		[NullableContext(1)]
		public static IFollowDecorationConfig Create(IFollowDecorationConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFollowDecorationConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170017F5 RID: 6133
		// (get) Token: 0x06004C59 RID: 19545 RVA: 0x000BE4C1 File Offset: 0x000BC6C1
		public virtual EFollowDecorationType Type
		{
			get
			{
				return (EFollowDecorationType)this.Instance.Type;
			}
		}

		// Token: 0x04002BB5 RID: 11189
		private IFollowDecorationConfig Instance;
	}
}
