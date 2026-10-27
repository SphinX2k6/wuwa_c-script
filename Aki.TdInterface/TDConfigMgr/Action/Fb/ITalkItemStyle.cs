using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200253F RID: 9535
	public class ITalkItemStyle
	{
		// Token: 0x0600D49B RID: 54427 RVA: 0x001F7CC6 File Offset: 0x001F5EC6
		[NullableContext(1)]
		public static ITalkItemStyle Create(ITalkItemStyle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemStyle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003BDF RID: 15327
		// (get) Token: 0x0600D49C RID: 54428 RVA: 0x001F7CE5 File Offset: 0x001F5EE5
		public virtual ETalkItemStyle Type
		{
			get
			{
				return (ETalkItemStyle)this.Instance.Type;
			}
		}

		// Token: 0x0400748B RID: 29835
		private ITalkItemStyle Instance;
	}
}
