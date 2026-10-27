using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B3B RID: 2875
	[NullableContext(2)]
	[Nullable(0)]
	public class IOnCollisionCondition : IBulletCreateCondition
	{
		// Token: 0x06004255 RID: 16981 RVA: 0x000A9CD1 File Offset: 0x000A7ED1
		[NullableContext(1)]
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

		// Token: 0x1700119C RID: 4508
		// (get) Token: 0x06004256 RID: 16982 RVA: 0x000A9CF0 File Offset: 0x000A7EF0
		public override EBulletCreateCondition Type
		{
			get
			{
				return (EBulletCreateCondition)this.Instance.Type;
			}
		}

		// Token: 0x1700119D RID: 4509
		// (get) Token: 0x06004257 RID: 16983 RVA: 0x000A9CFD File Offset: 0x000A7EFD
		public override long BulletId
		{
			get
			{
				return this.Instance.BulletId;
			}
		}

		// Token: 0x1700119E RID: 4510
		// (get) Token: 0x06004258 RID: 16984 RVA: 0x000A9D0A File Offset: 0x000A7F0A
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

		// Token: 0x04002564 RID: 9572
		private IOnCollisionCondition Instance;

		// Token: 0x04002565 RID: 9573
		private ITriggerCountConfig _TriggerCountCache;

		// Token: 0x04002566 RID: 9574
		private bool _TriggerCountInited;
	}
}
