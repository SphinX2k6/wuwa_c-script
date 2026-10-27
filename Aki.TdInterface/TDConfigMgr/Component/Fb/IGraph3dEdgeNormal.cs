using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E41 RID: 3649
	public class IGraph3dEdgeNormal : IGraph3dEdgeBase
	{
		// Token: 0x06005272 RID: 21106 RVA: 0x000CAFD1 File Offset: 0x000C91D1
		[NullableContext(1)]
		public static IGraph3dEdgeNormal Create(IGraph3dEdgeNormal? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGraph3dEdgeNormal
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001BAD RID: 7085
		// (get) Token: 0x06005273 RID: 21107 RVA: 0x000CAFF0 File Offset: 0x000C91F0
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17001BAE RID: 7086
		// (get) Token: 0x06005274 RID: 21108 RVA: 0x000CAFFD File Offset: 0x000C91FD
		public override int From
		{
			get
			{
				return this.Instance.From;
			}
		}

		// Token: 0x17001BAF RID: 7087
		// (get) Token: 0x06005275 RID: 21109 RVA: 0x000CB00A File Offset: 0x000C920A
		public override int To
		{
			get
			{
				return this.Instance.To;
			}
		}

		// Token: 0x04002F86 RID: 12166
		private IGraph3dEdgeNormal Instance;
	}
}
