using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F3D RID: 3901
	public class IGraph3dEdgeNormal : IGraph3dEdgeBase
	{
		// Token: 0x06005799 RID: 22425 RVA: 0x000D6899 File Offset: 0x000D4A99
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

		// Token: 0x17001D1A RID: 7450
		// (get) Token: 0x0600579A RID: 22426 RVA: 0x000D68B8 File Offset: 0x000D4AB8
		public override int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x17001D1B RID: 7451
		// (get) Token: 0x0600579B RID: 22427 RVA: 0x000D68C5 File Offset: 0x000D4AC5
		public override int From
		{
			get
			{
				return this.Instance.From;
			}
		}

		// Token: 0x17001D1C RID: 7452
		// (get) Token: 0x0600579C RID: 22428 RVA: 0x000D68D2 File Offset: 0x000D4AD2
		public override int To
		{
			get
			{
				return this.Instance.To;
			}
		}

		// Token: 0x0400324E RID: 12878
		private IGraph3dEdgeNormal Instance;
	}
}
