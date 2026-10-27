using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B3C RID: 2876
	public class IOnMatchingCondition : IBulletCreateCondition
	{
		// Token: 0x0600425A RID: 16986 RVA: 0x000A9D46 File Offset: 0x000A7F46
		[NullableContext(1)]
		public static IOnMatchingCondition Create(IOnMatchingCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOnMatchingCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700119F RID: 4511
		// (get) Token: 0x0600425B RID: 16987 RVA: 0x000A9D65 File Offset: 0x000A7F65
		public override EBulletCreateCondition Type
		{
			get
			{
				return (EBulletCreateCondition)this.Instance.Type;
			}
		}

		// Token: 0x170011A0 RID: 4512
		// (get) Token: 0x0600425C RID: 16988 RVA: 0x000A9D72 File Offset: 0x000A7F72
		public override long BulletId
		{
			get
			{
				return this.Instance.BulletId;
			}
		}

		// Token: 0x04002567 RID: 9575
		private IOnMatchingCondition Instance;
	}
}
