using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002386 RID: 9094
	public class PosAndRot : PosA
	{
		// Token: 0x0600C670 RID: 50800 RVA: 0x001C6ED0 File Offset: 0x001C50D0
		private PosAndRot_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("PosAndRot 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			PosAndRot_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new PosAndRot_SetValue());
			}
			return result;
		}

		// Token: 0x0600C671 RID: 50801 RVA: 0x001C6F08 File Offset: 0x001C5108
		public static PosAndRot Create([Nullable(2)] PosAndRot instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PosAndRot
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C672 RID: 50802 RVA: 0x001C6F1B File Offset: 0x001C511B
		public static PosAndRot CreateFromSetValue([Nullable(2)] PosAndRot_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new PosAndRot
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C673 RID: 50803 RVA: 0x001C6F30 File Offset: 0x001C5130
		public new PosAndRot_SetValue ToSetValue()
		{
			return new PosAndRot_SetValue
			{
				X = this.X,
				Y = this.Y,
				Z = this.Z,
				A = this.A,
				Roll = this.Roll,
				Pitch = this.Pitch
			};
		}

		// Token: 0x17003C00 RID: 15360
		// (get) Token: 0x0600C674 RID: 50804 RVA: 0x001C6F8C File Offset: 0x001C518C
		// (set) Token: 0x0600C675 RID: 50805 RVA: 0x001C6FC6 File Offset: 0x001C51C6
		public override float? X
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.X;
				}
				PosAndRot_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.X;
			}
			set
			{
				this.GetOrCreatePoco().X = value;
			}
		}

		// Token: 0x17003C01 RID: 15361
		// (get) Token: 0x0600C676 RID: 50806 RVA: 0x001C6FD4 File Offset: 0x001C51D4
		// (set) Token: 0x0600C677 RID: 50807 RVA: 0x001C700E File Offset: 0x001C520E
		public override float? Y
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Y;
				}
				PosAndRot_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Y;
			}
			set
			{
				this.GetOrCreatePoco().Y = value;
			}
		}

		// Token: 0x17003C02 RID: 15362
		// (get) Token: 0x0600C678 RID: 50808 RVA: 0x001C701C File Offset: 0x001C521C
		// (set) Token: 0x0600C679 RID: 50809 RVA: 0x001C7056 File Offset: 0x001C5256
		public override float? Z
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Z;
				}
				PosAndRot_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Z;
			}
			set
			{
				this.GetOrCreatePoco().Z = value;
			}
		}

		// Token: 0x17003C03 RID: 15363
		// (get) Token: 0x0600C67A RID: 50810 RVA: 0x001C7064 File Offset: 0x001C5264
		// (set) Token: 0x0600C67B RID: 50811 RVA: 0x001C709E File Offset: 0x001C529E
		public override float? A
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.A;
				}
				PosAndRot_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.A;
			}
			set
			{
				this.GetOrCreatePoco().A = value;
			}
		}

		// Token: 0x17003C04 RID: 15364
		// (get) Token: 0x0600C67C RID: 50812 RVA: 0x001C70AC File Offset: 0x001C52AC
		// (set) Token: 0x0600C67D RID: 50813 RVA: 0x001C70E6 File Offset: 0x001C52E6
		public virtual float? Roll
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Roll;
				}
				PosAndRot_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Roll;
			}
			set
			{
				this.GetOrCreatePoco().Roll = value;
			}
		}

		// Token: 0x17003C05 RID: 15365
		// (get) Token: 0x0600C67E RID: 50814 RVA: 0x001C70F4 File Offset: 0x001C52F4
		// (set) Token: 0x0600C67F RID: 50815 RVA: 0x001C712E File Offset: 0x001C532E
		public virtual float? Pitch
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Pitch;
				}
				PosAndRot_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Pitch;
			}
			set
			{
				this.GetOrCreatePoco().Pitch = value;
			}
		}

		// Token: 0x0400760D RID: 30221
		[Nullable(2)]
		protected new PosAndRot FbInstance;

		// Token: 0x0400760E RID: 30222
		[Nullable(2)]
		protected new PosAndRot_SetValue PocoInterface;
	}
}
