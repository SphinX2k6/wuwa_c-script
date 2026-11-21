using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C1E RID: 3102
	public class IHoldingTrackTarget
	{
		// Token: 0x06004710 RID: 18192 RVA: 0x000B45E0 File Offset: 0x000B27E0
		public static IHoldingTrackTarget Create(IHoldingTrackTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHoldingTrackTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170012CF RID: 4815
		// (get) Token: 0x06004711 RID: 18193 RVA: 0x000B45FF File Offset: 0x000B27FF
		public virtual string EffectPath
		{
			get
			{
				return this.Instance.EffectPath;
			}
		}

		// Token: 0x170012D0 RID: 4816
		// (get) Token: 0x06004712 RID: 18194 RVA: 0x000B460C File Offset: 0x000B280C
		public virtual int EffectLength
		{
			get
			{
				return this.Instance.EffectLength;
			}
		}

		// Token: 0x170012D1 RID: 4817
		// (get) Token: 0x06004713 RID: 18195 RVA: 0x000B4619 File Offset: 0x000B2819
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x040027DB RID: 10203
		private IHoldingTrackTarget Instance;
	}
}
