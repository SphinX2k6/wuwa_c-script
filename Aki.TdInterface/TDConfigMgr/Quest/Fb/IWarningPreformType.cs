using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001429 RID: 5161
	public class IWarningPreformType
	{
		// Token: 0x06007569 RID: 30057 RVA: 0x0011878A File Offset: 0x0011698A
		[NullableContext(1)]
		public static IWarningPreformType Create(IWarningPreformType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWarningPreformType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170026EA RID: 9962
		// (get) Token: 0x0600756A RID: 30058 RVA: 0x001187A9 File Offset: 0x001169A9
		public virtual EWarningPreformType Type
		{
			get
			{
				return (EWarningPreformType)this.Instance.Type;
			}
		}

		// Token: 0x04004403 RID: 17411
		private IWarningPreformType Instance;
	}
}
