using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019DB RID: 6619
	public class ICameraSetting
	{
		// Token: 0x06008CDD RID: 36061 RVA: 0x0014D7E8 File Offset: 0x0014B9E8
		private ICameraSetting_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICameraSetting 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICameraSetting_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICameraSetting_SetValue());
			}
			return result;
		}

		// Token: 0x06008CDE RID: 36062 RVA: 0x0014D820 File Offset: 0x0014BA20
		public static ICameraSetting Create([Nullable(2)] ICameraSetting instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICameraSetting
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008CDF RID: 36063 RVA: 0x0014D833 File Offset: 0x0014BA33
		public static ICameraSetting CreateFromSetValue([Nullable(2)] ICameraSetting_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICameraSetting
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008CE0 RID: 36064 RVA: 0x0014D848 File Offset: 0x0014BA48
		public ICameraSetting_SetValue ToSetValue()
		{
			return new ICameraSetting_SetValue
			{
				Aperture = this.Aperture,
				FocalLength = this.FocalLength,
				FocusDistance = this.FocusDistance,
				FocalRegion = this.FocalRegion,
				Fov = this.Fov
			};
		}

		// Token: 0x17002DB2 RID: 11698
		// (get) Token: 0x06008CE1 RID: 36065 RVA: 0x0014D896 File Offset: 0x0014BA96
		// (set) Token: 0x06008CE2 RID: 36066 RVA: 0x0014D8C5 File Offset: 0x0014BAC5
		public virtual float Aperture
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Aperture;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Aperture;
			}
			set
			{
				this.GetOrCreatePoco().Aperture = value;
			}
		}

		// Token: 0x17002DB3 RID: 11699
		// (get) Token: 0x06008CE3 RID: 36067 RVA: 0x0014D8D3 File Offset: 0x0014BAD3
		// (set) Token: 0x06008CE4 RID: 36068 RVA: 0x0014D902 File Offset: 0x0014BB02
		public virtual float FocalLength
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FocalLength;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.FocalLength;
			}
			set
			{
				this.GetOrCreatePoco().FocalLength = value;
			}
		}

		// Token: 0x17002DB4 RID: 11700
		// (get) Token: 0x06008CE5 RID: 36069 RVA: 0x0014D910 File Offset: 0x0014BB10
		// (set) Token: 0x06008CE6 RID: 36070 RVA: 0x0014D93F File Offset: 0x0014BB3F
		public virtual float FocusDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FocusDistance;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.FocusDistance;
			}
			set
			{
				this.GetOrCreatePoco().FocusDistance = value;
			}
		}

		// Token: 0x17002DB5 RID: 11701
		// (get) Token: 0x06008CE7 RID: 36071 RVA: 0x0014D94D File Offset: 0x0014BB4D
		// (set) Token: 0x06008CE8 RID: 36072 RVA: 0x0014D97C File Offset: 0x0014BB7C
		public virtual float FocalRegion
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FocalRegion;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.FocalRegion;
			}
			set
			{
				this.GetOrCreatePoco().FocalRegion = value;
			}
		}

		// Token: 0x17002DB6 RID: 11702
		// (get) Token: 0x06008CE9 RID: 36073 RVA: 0x0014D98C File Offset: 0x0014BB8C
		// (set) Token: 0x06008CEA RID: 36074 RVA: 0x0014D9C6 File Offset: 0x0014BBC6
		public virtual float? Fov
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Fov;
				}
				ICameraSetting_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Fov;
			}
			set
			{
				this.GetOrCreatePoco().Fov = value;
			}
		}

		// Token: 0x040058BF RID: 22719
		[Nullable(2)]
		protected ICameraSetting FbInstance;

		// Token: 0x040058C0 RID: 22720
		[Nullable(2)]
		protected ICameraSetting_SetValue PocoInterface;
	}
}
