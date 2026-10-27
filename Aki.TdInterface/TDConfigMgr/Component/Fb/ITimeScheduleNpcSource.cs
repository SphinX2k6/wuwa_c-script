using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DDF RID: 3551
	public class ITimeScheduleNpcSource
	{
		// Token: 0x06005082 RID: 20610 RVA: 0x000C6D4D File Offset: 0x000C4F4D
		[NullableContext(1)]
		public static ITimeScheduleNpcSource Create(ITimeScheduleNpcSource? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeScheduleNpcSource
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A81 RID: 6785
		// (get) Token: 0x06005083 RID: 20611 RVA: 0x000C6D6C File Offset: 0x000C4F6C
		public virtual ETimeScheduleNpcSourceType Type
		{
			get
			{
				return (ETimeScheduleNpcSourceType)this.Instance.Type;
			}
		}

		// Token: 0x04002E38 RID: 11832
		private ITimeScheduleNpcSource Instance;
	}
}
