using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C2B RID: 3115
	public class IExtraRangeType
	{
		// Token: 0x0600475E RID: 18270 RVA: 0x000B3BC6 File Offset: 0x000B1DC6
		[NullableContext(1)]
		public static IExtraRangeType Create(IExtraRangeType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExtraRangeType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170014C5 RID: 5317
		// (get) Token: 0x0600475F RID: 18271 RVA: 0x000B3BE5 File Offset: 0x000B1DE5
		public virtual EExtraRangeType Type
		{
			get
			{
				return (EExtraRangeType)this.Instance.Type;
			}
		}

		// Token: 0x04002884 RID: 10372
		private IExtraRangeType Instance;
	}
}
