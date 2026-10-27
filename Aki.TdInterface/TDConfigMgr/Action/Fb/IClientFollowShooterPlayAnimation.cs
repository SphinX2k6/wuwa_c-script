using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002996 RID: 10646
	[NullableContext(1)]
	[Nullable(0)]
	public class IClientFollowShooterPlayAnimation : IClientFollowShooterLeisureInteractType
	{
		// Token: 0x0600EBAA RID: 60330 RVA: 0x0022759B File Offset: 0x0022579B
		public static IClientFollowShooterPlayAnimation Create(IClientFollowShooterPlayAnimation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientFollowShooterPlayAnimation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A40 RID: 19008
		// (get) Token: 0x0600EBAB RID: 60331 RVA: 0x002275BA File Offset: 0x002257BA
		public override EClientFollowShooterLeisureInteractType Type
		{
			get
			{
				return (EClientFollowShooterLeisureInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17004A41 RID: 19009
		// (get) Token: 0x0600EBAC RID: 60332 RVA: 0x002275C7 File Offset: 0x002257C7
		public virtual string Montage
		{
			get
			{
				return this.Instance.Montage;
			}
		}

		// Token: 0x040081C8 RID: 33224
		private IClientFollowShooterPlayAnimation Instance;
	}
}
