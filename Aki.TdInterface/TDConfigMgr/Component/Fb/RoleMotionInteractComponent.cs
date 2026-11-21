using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BEE RID: 3054
	public class RoleMotionInteractComponent : IComponentBase
	{
		// Token: 0x06004620 RID: 17952 RVA: 0x000B2CA9 File Offset: 0x000B0EA9
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

		// Token: 0x1700123F RID: 4671
		// (get) Token: 0x06004621 RID: 17953 RVA: 0x000B2CC8 File Offset: 0x000B0EC8
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

		// Token: 0x17001240 RID: 4672
		// (get) Token: 0x06004622 RID: 17954 RVA: 0x000B2D00 File Offset: 0x000B0F00
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001241 RID: 4673
		// (get) Token: 0x06004623 RID: 17955 RVA: 0x000B2D16 File Offset: 0x000B0F16
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

		// Token: 0x0400275F RID: 10079
		private IRoleMotionInteractComponent Instance;

		// Token: 0x04002760 RID: 10080
		[Nullable(2)]
		private IPetalGrabRoleMotionInteract _MotionInteractConfigCache;

		// Token: 0x04002761 RID: 10081
		private bool _MotionInteractConfigInited;
	}
}
