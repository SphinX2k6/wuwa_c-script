using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B41 RID: 2881
	public class ILetGoDestroyCondition : ITeleControlDestroyCondition
	{
		// Token: 0x0600426D RID: 17005 RVA: 0x000A9EA0 File Offset: 0x000A80A0
		[NullableContext(1)]
		public static ILetGoDestroyCondition Create(ILetGoDestroyCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILetGoDestroyCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170011A8 RID: 4520
		// (get) Token: 0x0600426E RID: 17006 RVA: 0x000A9EBF File Offset: 0x000A80BF
		public override ETeleControlDestroyCondition Type
		{
			get
			{
				return (ETeleControlDestroyCondition)this.Instance.Type;
			}
		}

		// Token: 0x0400256E RID: 9582
		private ILetGoDestroyCondition Instance;
	}
}
