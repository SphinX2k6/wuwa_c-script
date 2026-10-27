using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200251F RID: 9503
	public class ITalkBackground
	{
		// Token: 0x0600D3F4 RID: 54260 RVA: 0x001F660E File Offset: 0x001F480E
		[NullableContext(1)]
		public static ITalkBackground Create(ITalkBackground? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkBackground
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B78 RID: 15224
		// (get) Token: 0x0600D3F5 RID: 54261 RVA: 0x001F662D File Offset: 0x001F482D
		public virtual ETalkBackgroundType Type
		{
			get
			{
				return (ETalkBackgroundType)this.Instance.Type;
			}
		}

		// Token: 0x04007425 RID: 29733
		private ITalkBackground Instance;
	}
}
