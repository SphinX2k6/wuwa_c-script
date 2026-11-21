using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E10 RID: 3600
	public class IConnectorEffectConfig
	{
		// Token: 0x0600518D RID: 20877 RVA: 0x000C9E9A File Offset: 0x000C809A
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

		// Token: 0x17001968 RID: 6504
		// (get) Token: 0x0600518E RID: 20878 RVA: 0x000C9EB9 File Offset: 0x000C80B9
		public virtual string EffectPath
		{
			get
			{
				return this.Instance.EffectPath;
			}
		}

		// Token: 0x17001969 RID: 6505
		// (get) Token: 0x0600518F RID: 20879 RVA: 0x000C9EC6 File Offset: 0x000C80C6
		[Nullable(2)]
		public virtual string StartPoint
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.StartPoint;
			}
		}

		// Token: 0x1700196A RID: 6506
		// (get) Token: 0x06005190 RID: 20880 RVA: 0x000C9ED3 File Offset: 0x000C80D3
		[Nullable(2)]
		public virtual string EndPoint
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.EndPoint;
			}
		}

		// Token: 0x04002E83 RID: 11907
		private IConnectorEffectConfig Instance;
	}
}
