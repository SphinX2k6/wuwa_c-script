using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D16 RID: 3350
	[NullableContext(2)]
	[Nullable(0)]
	public class IConnectorEffectConfig
	{
		// Token: 0x06004C73 RID: 19571 RVA: 0x000BE7C6 File Offset: 0x000BC9C6
		[NullableContext(1)]
		public static IConnectorEffectConfig Create(IConnectorEffectConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IConnectorEffectConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001804 RID: 6148
		// (get) Token: 0x06004C74 RID: 19572 RVA: 0x000BE7E5 File Offset: 0x000BC9E5
		[Nullable(1)]
		public virtual string EffectPath
		{
			[NullableContext(1)]
			get
			{
				return this.Instance.EffectPath;
			}
		}

		// Token: 0x17001805 RID: 6149
		// (get) Token: 0x06004C75 RID: 19573 RVA: 0x000BE7F2 File Offset: 0x000BC9F2
		public virtual string StartPoint
		{
			get
			{
				return this.Instance.StartPoint;
			}
		}

		// Token: 0x17001806 RID: 6150
		// (get) Token: 0x06004C76 RID: 19574 RVA: 0x000BE7FF File Offset: 0x000BC9FF
		public virtual string EndPoint
		{
			get
			{
				return this.Instance.EndPoint;
			}
		}

		// Token: 0x04002BC3 RID: 11203
		private IConnectorEffectConfig Instance;
	}
}
