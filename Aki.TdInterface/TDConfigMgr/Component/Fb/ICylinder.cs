using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B27 RID: 2855
	public class ICylinder
	{
		// Token: 0x0600413C RID: 16700 RVA: 0x000A6607 File Offset: 0x000A4807
		public static ICylinder Create(ICylinder? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICylinder
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000EE9 RID: 3817
		// (get) Token: 0x0600413D RID: 16701 RVA: 0x000A6626 File Offset: 0x000A4826
		public virtual bool IsUse
		{
			get
			{
				return this.Instance.IsUse;
			}
		}

		// Token: 0x17000EEA RID: 3818
		// (get) Token: 0x0600413E RID: 16702 RVA: 0x000A6633 File Offset: 0x000A4833
		public virtual int Radius
		{
			get
			{
				return this.Instance.Radius;
			}
		}

		// Token: 0x17000EEB RID: 3819
		// (get) Token: 0x0600413F RID: 16703 RVA: 0x000A6640 File Offset: 0x000A4840
		public virtual int Height
		{
			get
			{
				return this.Instance.Height;
			}
		}

		// Token: 0x17000EEC RID: 3820
		// (get) Token: 0x06004140 RID: 16704 RVA: 0x000A664D File Offset: 0x000A484D
		public virtual PosA CylinderPos
		{
			get
			{
				if (this._CylinderPosInited)
				{
					return this._CylinderPosCache;
				}
				this._CylinderPosInited = true;
				this._CylinderPosCache = PosA.Create(this.Instance.CylinderPos);
				return this._CylinderPosCache;
			}
		}

		// Token: 0x04002422 RID: 9250
		private ICylinder Instance;

		// Token: 0x04002423 RID: 9251
		[Nullable(2)]
		private PosA _CylinderPosCache;

		// Token: 0x04002424 RID: 9252
		private bool _CylinderPosInited;
	}
}
