using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B43 RID: 2883
	public class IThrowDestroyCondition : ITeleControlDestroyCondition
	{
		// Token: 0x06004273 RID: 17011 RVA: 0x000A9F08 File Offset: 0x000A8108
		[NullableContext(1)]
		public static IThrowDestroyCondition Create(IThrowDestroyCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IThrowDestroyCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170011AA RID: 4522
		// (get) Token: 0x06004274 RID: 17012 RVA: 0x000A9F27 File Offset: 0x000A8127
		public override ETeleControlDestroyCondition Type
		{
			get
			{
				return (ETeleControlDestroyCondition)this.Instance.Type;
			}
		}

		// Token: 0x170011AB RID: 4523
		// (get) Token: 0x06004275 RID: 17013 RVA: 0x000A9F34 File Offset: 0x000A8134
		public virtual float DelayTime
		{
			get
			{
				return this.Instance.DelayTime;
			}
		}

		// Token: 0x04002570 RID: 9584
		private IThrowDestroyCondition Instance;
	}
}
