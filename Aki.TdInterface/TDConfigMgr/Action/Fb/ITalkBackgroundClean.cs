using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002520 RID: 9504
	public class ITalkBackgroundClean : ITalkBackground
	{
		// Token: 0x0600D3F7 RID: 54263 RVA: 0x001F6642 File Offset: 0x001F4842
		[NullableContext(1)]
		public static ITalkBackgroundClean Create(ITalkBackgroundClean? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkBackgroundClean
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B79 RID: 15225
		// (get) Token: 0x0600D3F8 RID: 54264 RVA: 0x001F6661 File Offset: 0x001F4861
		public override ETalkBackgroundType Type
		{
			get
			{
				return (ETalkBackgroundType)this.Instance.Type;
			}
		}

		// Token: 0x04007426 RID: 29734
		private ITalkBackgroundClean Instance;
	}
}
