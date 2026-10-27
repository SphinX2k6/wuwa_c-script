using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027BF RID: 10175
	public class IChangeTimerType
	{
		// Token: 0x0600E254 RID: 57940 RVA: 0x00216E35 File Offset: 0x00215035
		[NullableContext(1)]
		public static IChangeTimerType Create(IChangeTimerType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChangeTimerType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004498 RID: 17560
		// (get) Token: 0x0600E255 RID: 57941 RVA: 0x00216E54 File Offset: 0x00215054
		public virtual EChangeTimerType Type
		{
			get
			{
				return (EChangeTimerType)this.Instance.Type;
			}
		}

		// Token: 0x04007D81 RID: 32129
		private IChangeTimerType Instance;
	}
}
