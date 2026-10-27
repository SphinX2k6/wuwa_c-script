using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002125 RID: 8485
	[NullableContext(1)]
	[Nullable(0)]
	public class PosAndRot : PosA
	{
		// Token: 0x0600BAE2 RID: 47842 RVA: 0x001AFD1C File Offset: 0x001ADF1C
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

		// Token: 0x0600BAE3 RID: 47843 RVA: 0x001AFD54 File Offset: 0x001ADF54
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

		// Token: 0x0600BAE4 RID: 47844 RVA: 0x001AFD67 File Offset: 0x001ADF67
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

		// Token: 0x0600BAE5 RID: 47845 RVA: 0x001AFD7C File Offset: 0x001ADF7C
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

		// Token: 0x17003913 RID: 14611
		// (get) Token: 0x0600BAE6 RID: 47846 RVA: 0x001AFDD8 File Offset: 0x001ADFD8
		// (set) Token: 0x0600BAE7 RID: 47847 RVA: 0x001AFE12 File Offset: 0x001AE012
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

		// Token: 0x17003914 RID: 14612
		// (get) Token: 0x0600BAE8 RID: 47848 RVA: 0x001AFE20 File Offset: 0x001AE020
		// (set) Token: 0x0600BAE9 RID: 47849 RVA: 0x001AFE5A File Offset: 0x001AE05A
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

		// Token: 0x17003915 RID: 14613
		// (get) Token: 0x0600BAEA RID: 47850 RVA: 0x001AFE68 File Offset: 0x001AE068
		// (set) Token: 0x0600BAEB RID: 47851 RVA: 0x001AFEA2 File Offset: 0x001AE0A2
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

		// Token: 0x17003916 RID: 14614
		// (get) Token: 0x0600BAEC RID: 47852 RVA: 0x001AFEB0 File Offset: 0x001AE0B0
		// (set) Token: 0x0600BAED RID: 47853 RVA: 0x001AFEEA File Offset: 0x001AE0EA
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

		// Token: 0x17003917 RID: 14615
		// (get) Token: 0x0600BAEE RID: 47854 RVA: 0x001AFEF8 File Offset: 0x001AE0F8
		// (set) Token: 0x0600BAEF RID: 47855 RVA: 0x001AFF32 File Offset: 0x001AE132
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

		// Token: 0x17003918 RID: 14616
		// (get) Token: 0x0600BAF0 RID: 47856 RVA: 0x001AFF40 File Offset: 0x001AE140
		// (set) Token: 0x0600BAF1 RID: 47857 RVA: 0x001AFF7A File Offset: 0x001AE17A
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

		// Token: 0x04006FD8 RID: 28632
		[Nullable(2)]
		protected new PosAndRot FbInstance;

		// Token: 0x04006FD9 RID: 28633
		[Nullable(2)]
		protected new PosAndRot_SetValue PocoInterface;
	}
}
