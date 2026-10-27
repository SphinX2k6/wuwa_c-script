using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B42 RID: 2882
	public class ICreateBulletDestroyCondition : ITeleControlDestroyCondition
	{
		// Token: 0x06004270 RID: 17008 RVA: 0x000A9ED4 File Offset: 0x000A80D4
		[NullableContext(1)]
		public static ICreateBulletDestroyCondition Create(ICreateBulletDestroyCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICreateBulletDestroyCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170011A9 RID: 4521
		// (get) Token: 0x06004271 RID: 17009 RVA: 0x000A9EF3 File Offset: 0x000A80F3
		public override ETeleControlDestroyCondition Type
		{
			get
			{
				return (ETeleControlDestroyCondition)this.Instance.Type;
			}
		}

		// Token: 0x0400256F RID: 9583
		private ICreateBulletDestroyCondition Instance;
	}
}
