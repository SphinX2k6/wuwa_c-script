using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002938 RID: 10552
	public class EnableClientFunction : ActionParams
	{
		// Token: 0x0600EA0D RID: 59917 RVA: 0x0022487D File Offset: 0x00222A7D
		[NullableContext(1)]
		public static EnableClientFunction Create(IEnableClientFunction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnableClientFunction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700495F RID: 18783
		// (get) Token: 0x0600EA0E RID: 59918 RVA: 0x0022489C File Offset: 0x00222A9C
		public virtual EEnableClientFunctionType Type
		{
			get
			{
				return (EEnableClientFunctionType)this.Instance.Type;
			}
		}

		// Token: 0x04008116 RID: 33046
		private IEnableClientFunction Instance;
	}
}
