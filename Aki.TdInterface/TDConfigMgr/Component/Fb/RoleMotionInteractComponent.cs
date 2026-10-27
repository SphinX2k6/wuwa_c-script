using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B20 RID: 2848
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleMotionInteractComponent : IComponentBase
	{
		// Token: 0x060041C7 RID: 16839 RVA: 0x000A8BE2 File Offset: 0x000A6DE2
		public static RoleMotionInteractComponent Create(IRoleMotionInteractComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RoleMotionInteractComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001144 RID: 4420
		// (get) Token: 0x060041C8 RID: 16840 RVA: 0x000A8C04 File Offset: 0x000A6E04
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17001145 RID: 4421
		// (get) Token: 0x060041C9 RID: 16841 RVA: 0x000A8C3C File Offset: 0x000A6E3C
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001146 RID: 4422
		// (get) Token: 0x060041CA RID: 16842 RVA: 0x000A8C52 File Offset: 0x000A6E52
		public virtual IPetalGrabRoleMotionInteract MotionInteractConfig
		{
			get
			{
				if (this._MotionInteractConfigInited)
				{
					return this._MotionInteractConfigCache;
				}
				this._MotionInteractConfigInited = true;
				this._MotionInteractConfigCache = IPetalGrabRoleMotionInteract.Create(this.Instance.MotionInteractConfig);
				return this._MotionInteractConfigCache;
			}
		}

		// Token: 0x04002517 RID: 9495
		private IRoleMotionInteractComponent Instance;

		// Token: 0x04002518 RID: 9496
		[Nullable(2)]
		private IPetalGrabRoleMotionInteract _MotionInteractConfigCache;

		// Token: 0x04002519 RID: 9497
		private bool _MotionInteractConfigInited;
	}
}
