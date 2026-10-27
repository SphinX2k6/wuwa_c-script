using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200294B RID: 10571
	public class IEnableSectionalCameraOperation : ICameraOperationType
	{
		// Token: 0x0600EA72 RID: 60018 RVA: 0x00225596 File Offset: 0x00223796
		[NullableContext(1)]
		public static IEnableSectionalCameraOperation Create(IEnableSectionalCameraOperation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableSectionalCameraOperation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700499E RID: 18846
		// (get) Token: 0x0600EA73 RID: 60019 RVA: 0x002255B5 File Offset: 0x002237B5
		public override ECameraOperationType Type
		{
			get
			{
				return (ECameraOperationType)this.Instance.Type;
			}
		}

		// Token: 0x1700499F RID: 18847
		// (get) Token: 0x0600EA74 RID: 60020 RVA: 0x002255C4 File Offset: 0x002237C4
		public virtual bool? EnableRotate
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.EnableRotate);
			}
		}

		// Token: 0x170049A0 RID: 18848
		// (get) Token: 0x0600EA75 RID: 60021 RVA: 0x002255FC File Offset: 0x002237FC
		public virtual bool? EnableZoom
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.EnableZoom);
			}
		}

		// Token: 0x0400813B RID: 33083
		private IEnableSectionalCameraOperation Instance;
	}
}
