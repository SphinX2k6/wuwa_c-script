using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019C7 RID: 6599
	public class ICameraDepthOfField
	{
		// Token: 0x06008C43 RID: 35907 RVA: 0x0014C340 File Offset: 0x0014A540
		private ICameraDepthOfField_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICameraDepthOfField 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICameraDepthOfField_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICameraDepthOfField_SetValue());
			}
			return result;
		}

		// Token: 0x06008C44 RID: 35908 RVA: 0x0014C378 File Offset: 0x0014A578
		public static ICameraDepthOfField Create([Nullable(2)] ICameraDepthOfField instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICameraDepthOfField
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008C45 RID: 35909 RVA: 0x0014C38B File Offset: 0x0014A58B
		public static ICameraDepthOfField CreateFromSetValue([Nullable(2)] ICameraDepthOfField_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICameraDepthOfField
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008C46 RID: 35910 RVA: 0x0014C39E File Offset: 0x0014A59E
		public ICameraDepthOfField_SetValue ToSetValue()
		{
			return new ICameraDepthOfField_SetValue
			{
				Fstop = this.Fstop,
				Distance = this.Distance,
				BlurAmount = this.BlurAmount,
				BlurRadius = this.BlurRadius
			};
		}

		// Token: 0x17002D83 RID: 11651
		// (get) Token: 0x06008C47 RID: 35911 RVA: 0x0014C3D8 File Offset: 0x0014A5D8
		// (set) Token: 0x06008C48 RID: 35912 RVA: 0x0014C412 File Offset: 0x0014A612
		public virtual float? Fstop
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Fstop;
				}
				ICameraDepthOfField_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Fstop;
			}
			set
			{
				this.GetOrCreatePoco().Fstop = value;
			}
		}

		// Token: 0x17002D84 RID: 11652
		// (get) Token: 0x06008C49 RID: 35913 RVA: 0x0014C420 File Offset: 0x0014A620
		// (set) Token: 0x06008C4A RID: 35914 RVA: 0x0014C45A File Offset: 0x0014A65A
		public virtual float? Distance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Distance;
				}
				ICameraDepthOfField_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Distance;
			}
			set
			{
				this.GetOrCreatePoco().Distance = value;
			}
		}

		// Token: 0x17002D85 RID: 11653
		// (get) Token: 0x06008C4B RID: 35915 RVA: 0x0014C468 File Offset: 0x0014A668
		// (set) Token: 0x06008C4C RID: 35916 RVA: 0x0014C4A2 File Offset: 0x0014A6A2
		public virtual float? BlurAmount
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BlurAmount;
				}
				ICameraDepthOfField_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.BlurAmount;
			}
			set
			{
				this.GetOrCreatePoco().BlurAmount = value;
			}
		}

		// Token: 0x17002D86 RID: 11654
		// (get) Token: 0x06008C4D RID: 35917 RVA: 0x0014C4B0 File Offset: 0x0014A6B0
		// (set) Token: 0x06008C4E RID: 35918 RVA: 0x0014C4EA File Offset: 0x0014A6EA
		public virtual float? BlurRadius
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BlurRadius;
				}
				ICameraDepthOfField_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.BlurRadius;
			}
			set
			{
				this.GetOrCreatePoco().BlurRadius = value;
			}
		}

		// Token: 0x0400586C RID: 22636
		[Nullable(2)]
		protected ICameraDepthOfField FbInstance;

		// Token: 0x0400586D RID: 22637
		[Nullable(2)]
		protected ICameraDepthOfField_SetValue PocoInterface;
	}
}
