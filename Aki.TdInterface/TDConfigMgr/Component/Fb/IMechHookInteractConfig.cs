using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BD6 RID: 3030
	[NullableContext(2)]
	[Nullable(0)]
	public class IMechHookInteractConfig
	{
		// Token: 0x06004587 RID: 17799 RVA: 0x000B15AB File Offset: 0x000AF7AB
		[NullableContext(0)]
		public static IMechHookInteractConfig Create(IMechHookInteractConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechHookInteractConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170011D6 RID: 4566
		// (get) Token: 0x06004588 RID: 17800 RVA: 0x000B15CA File Offset: 0x000AF7CA
		[Nullable(0)]
		public virtual IMechHookInteractType InteractType
		{
			[NullableContext(0)]
			get
			{
				if (this._InteractTypeInited)
				{
					return this._InteractTypeCache;
				}
				this._InteractTypeInited = true;
				this._InteractTypeCache = ComponentReadHelper.ReadIMechHookInteractConfig_InteractType(this.Instance);
				return this._InteractTypeCache;
			}
		}

		// Token: 0x170011D7 RID: 4567
		// (get) Token: 0x06004589 RID: 17801 RVA: 0x000B15F9 File Offset: 0x000AF7F9
		public virtual IMechHookAcceleration MechHookAcceleration
		{
			get
			{
				if (this._MechHookAccelerationInited)
				{
					return this._MechHookAccelerationCache;
				}
				this._MechHookAccelerationInited = true;
				this._MechHookAccelerationCache = IMechHookAcceleration.Create(this.Instance.MechHookAcceleration);
				return this._MechHookAccelerationCache;
			}
		}

		// Token: 0x170011D8 RID: 4568
		// (get) Token: 0x0600458A RID: 17802 RVA: 0x000B162D File Offset: 0x000AF82D
		public virtual IInteractSectorRange SectorRange
		{
			get
			{
				if (this._SectorRangeInited)
				{
					return this._SectorRangeCache;
				}
				this._SectorRangeInited = true;
				this._SectorRangeCache = IInteractSectorRange.Create(this.Instance.SectorRange);
				return this._SectorRangeCache;
			}
		}

		// Token: 0x170011D9 RID: 4569
		// (get) Token: 0x0600458B RID: 17803 RVA: 0x000B1664 File Offset: 0x000AF864
		public virtual float? Radius
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.Radius);
			}
		}

		// Token: 0x170011DA RID: 4570
		// (get) Token: 0x0600458C RID: 17804 RVA: 0x000B169C File Offset: 0x000AF89C
		public virtual float? NonInteractiveInnerRadius
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new float?(this.Instance.NonInteractiveInnerRadius);
			}
		}

		// Token: 0x040026F7 RID: 9975
		private IMechHookInteractConfig Instance;

		// Token: 0x040026F8 RID: 9976
		[Nullable(0)]
		private IMechHookInteractType _InteractTypeCache;

		// Token: 0x040026F9 RID: 9977
		private bool _InteractTypeInited;

		// Token: 0x040026FA RID: 9978
		private IMechHookAcceleration _MechHookAccelerationCache;

		// Token: 0x040026FB RID: 9979
		private bool _MechHookAccelerationInited;

		// Token: 0x040026FC RID: 9980
		private IInteractSectorRange _SectorRangeCache;

		// Token: 0x040026FD RID: 9981
		private bool _SectorRangeInited;
	}
}
