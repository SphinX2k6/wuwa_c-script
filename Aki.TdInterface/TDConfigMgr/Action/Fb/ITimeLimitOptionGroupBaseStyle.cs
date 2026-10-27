using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002529 RID: 9513
	public class ITimeLimitOptionGroupBaseStyle
	{
		// Token: 0x0600D41C RID: 54300 RVA: 0x001F6939 File Offset: 0x001F4B39
		[NullableContext(1)]
		public static ITimeLimitOptionGroupBaseStyle Create(ITimeLimitOptionGroupBaseStyle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeLimitOptionGroupBaseStyle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B8C RID: 15244
		// (get) Token: 0x0600D41D RID: 54301 RVA: 0x001F6958 File Offset: 0x001F4B58
		public virtual ETimeLimitOptionGroupStyle Type
		{
			get
			{
				return (ETimeLimitOptionGroupStyle)this.Instance.Type;
			}
		}

		// Token: 0x04007431 RID: 29745
		private ITimeLimitOptionGroupBaseStyle Instance;
	}
}
