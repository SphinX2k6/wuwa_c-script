using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008CE RID: 2254
	public class LevitateMagnetComponent : IComponentBase
	{
		// Token: 0x060030B7 RID: 12471 RVA: 0x0007D288 File Offset: 0x0007B488
		private LevitateMagnetComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("LevitateMagnetComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			LevitateMagnetComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new LevitateMagnetComponent_SetValue());
			}
			return result;
		}

		// Token: 0x060030B8 RID: 12472 RVA: 0x0007D2C0 File Offset: 0x0007B4C0
		public static LevitateMagnetComponent Create([Nullable(2)] LevitateMagnetComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new LevitateMagnetComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060030B9 RID: 12473 RVA: 0x0007D2D3 File Offset: 0x0007B4D3
		public static LevitateMagnetComponent CreateFromSetValue([Nullable(2)] LevitateMagnetComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new LevitateMagnetComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060030BA RID: 12474 RVA: 0x0007D2E6 File Offset: 0x0007B4E6
		public new LevitateMagnetComponent_SetValue ToSetValue()
		{
			return new LevitateMagnetComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				MoveSpeed = this.MoveSpeed,
				Test = this.Test
			};
		}

		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x060030BB RID: 12475 RVA: 0x0007D320 File Offset: 0x0007B520
		// (set) Token: 0x060030BC RID: 12476 RVA: 0x0007D35A File Offset: 0x0007B55A
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				LevitateMagnetComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x060030BD RID: 12477 RVA: 0x0007D368 File Offset: 0x0007B568
		// (set) Token: 0x060030BE RID: 12478 RVA: 0x0007D392 File Offset: 0x0007B592
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000CAB RID: 3243
		// (get) Token: 0x060030BF RID: 12479 RVA: 0x0007D3A0 File Offset: 0x0007B5A0
		// (set) Token: 0x060030C0 RID: 12480 RVA: 0x0007D3CB File Offset: 0x0007B5CB
		public virtual int MoveSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MoveSpeed;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MoveSpeed;
			}
			set
			{
				this.GetOrCreatePoco().MoveSpeed = value;
			}
		}

		// Token: 0x17000CAC RID: 3244
		// (get) Token: 0x060030C1 RID: 12481 RVA: 0x0007D3DC File Offset: 0x0007B5DC
		// (set) Token: 0x060030C2 RID: 12482 RVA: 0x0007D416 File Offset: 0x0007B616
		public virtual int? Test
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Test;
				}
				LevitateMagnetComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Test;
			}
			set
			{
				this.GetOrCreatePoco().Test = value;
			}
		}

		// Token: 0x0400202E RID: 8238
		[Nullable(2)]
		protected new LevitateMagnetComponent FbInstance;

		// Token: 0x0400202F RID: 8239
		[Nullable(2)]
		protected new LevitateMagnetComponent_SetValue PocoInterface;
	}
}
