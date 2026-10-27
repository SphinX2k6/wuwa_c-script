using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200293F RID: 10559
	public class IMoveOperationType
	{
		// Token: 0x0600EA2D RID: 59949 RVA: 0x00224BCD File Offset: 0x00222DCD
		[NullableContext(1)]
		public static IMoveOperationType Create(IMoveOperationType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMoveOperationType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004971 RID: 18801
		// (get) Token: 0x0600EA2E RID: 59950 RVA: 0x00224BEC File Offset: 0x00222DEC
		public virtual EMoveOperationType Type
		{
			get
			{
				return (EMoveOperationType)this.Instance.Type;
			}
		}

		// Token: 0x04008127 RID: 33063
		private IMoveOperationType Instance;
	}
}
