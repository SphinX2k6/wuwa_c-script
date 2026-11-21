using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C09 RID: 3081
	[NullableContext(2)]
	[Nullable(0)]
	public class IOnCollisionCondition : IBulletCreateCondition
	{
		// Token: 0x060046AE RID: 18094 RVA: 0x000B3D95 File Offset: 0x000B1F95
		[NullableContext(0)]
		public static IOnCollisionCondition Create(IOnCollisionCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOnCollisionCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001297 RID: 4759
		// (get) Token: 0x060046AF RID: 18095 RVA: 0x000B3DB4 File Offset: 0x000B1FB4
		public override EBulletCreateCondition Type
		{
			get
			{
				return (EBulletCreateCondition)this.Instance.Type;
			}
		}

		// Token: 0x17001298 RID: 4760
		// (get) Token: 0x060046B0 RID: 18096 RVA: 0x000B3DC1 File Offset: 0x000B1FC1
		public override long BulletId
		{
			get
			{
				return this.Instance.BulletId;
			}
		}

		// Token: 0x17001299 RID: 4761
		// (get) Token: 0x060046B1 RID: 18097 RVA: 0x000B3DCE File Offset: 0x000B1FCE
		public virtual ITriggerCountConfig TriggerCount
		{
			get
			{
				if (this._TriggerCountInited)
				{
					return this._TriggerCountCache;
				}
				this._TriggerCountInited = true;
				this._TriggerCountCache = ITriggerCountConfig.Create(this.Instance.TriggerCount);
				return this._TriggerCountCache;
			}
		}

		// Token: 0x040027AC RID: 10156
		private IOnCollisionCondition Instance;

		// Token: 0x040027AD RID: 10157
		private ITriggerCountConfig _TriggerCountCache;

		// Token: 0x040027AE RID: 10158
		private bool _TriggerCountInited;
	}
}
