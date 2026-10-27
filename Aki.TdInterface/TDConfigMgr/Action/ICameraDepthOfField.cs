using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200183C RID: 6204
	[NullableContext(1)]
	[Nullable(0)]
	public class ICameraDepthOfField
	{
		// Token: 0x0600851D RID: 34077 RVA: 0x0013CB4C File Offset: 0x0013AD4C
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

		// Token: 0x0600851E RID: 34078 RVA: 0x0013CB84 File Offset: 0x0013AD84
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

		// Token: 0x0600851F RID: 34079 RVA: 0x0013CB97 File Offset: 0x0013AD97
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

		// Token: 0x06008520 RID: 34080 RVA: 0x0013CBAA File Offset: 0x0013ADAA
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

		// Token: 0x17002B89 RID: 11145
		// (get) Token: 0x06008521 RID: 34081 RVA: 0x0013CBE4 File Offset: 0x0013ADE4
		// (set) Token: 0x06008522 RID: 34082 RVA: 0x0013CC1E File Offset: 0x0013AE1E
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

		// Token: 0x17002B8A RID: 11146
		// (get) Token: 0x06008523 RID: 34083 RVA: 0x0013CC2C File Offset: 0x0013AE2C
		// (set) Token: 0x06008524 RID: 34084 RVA: 0x0013CC66 File Offset: 0x0013AE66
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

		// Token: 0x17002B8B RID: 11147
		// (get) Token: 0x06008525 RID: 34085 RVA: 0x0013CC74 File Offset: 0x0013AE74
		// (set) Token: 0x06008526 RID: 34086 RVA: 0x0013CCAE File Offset: 0x0013AEAE
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

		// Token: 0x17002B8C RID: 11148
		// (get) Token: 0x06008527 RID: 34087 RVA: 0x0013CCBC File Offset: 0x0013AEBC
		// (set) Token: 0x06008528 RID: 34088 RVA: 0x0013CCF6 File Offset: 0x0013AEF6
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

		// Token: 0x04005420 RID: 21536
		[Nullable(2)]
		protected ICameraDepthOfField FbInstance;

		// Token: 0x04005421 RID: 21537
		[Nullable(2)]
		protected ICameraDepthOfField_SetValue PocoInterface;
	}
}
