using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013A0 RID: 5024
	public class IMowBuffDistribute : IShowUi
	{
		// Token: 0x060072D1 RID: 29393 RVA: 0x00113D39 File Offset: 0x00111F39
		[NullableContext(1)]
		public static IMowBuffDistribute Create(IMowBuffDistribute? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMowBuffDistribute
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002564 RID: 9572
		// (get) Token: 0x060072D2 RID: 29394 RVA: 0x00113D58 File Offset: 0x00111F58
		public override EShowUiType Type
		{
			get
			{
				return (EShowUiType)this.Instance.Type;
			}
		}

		// Token: 0x17002565 RID: 9573
		// (get) Token: 0x060072D3 RID: 29395 RVA: 0x00113D65 File Offset: 0x00111F65
		public virtual int BoardId
		{
			get
			{
				return this.Instance.BoardId;
			}
		}

		// Token: 0x0400425E RID: 16990
		private IMowBuffDistribute Instance;
	}
}
