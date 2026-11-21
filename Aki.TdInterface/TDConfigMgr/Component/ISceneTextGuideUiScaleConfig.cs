using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000753 RID: 1875
	public class ISceneTextGuideUiScaleConfig
	{
		// Token: 0x060027DE RID: 10206 RVA: 0x0006A624 File Offset: 0x00068824
		private ISceneTextGuideUiScaleConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneTextGuideUiScaleConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneTextGuideUiScaleConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneTextGuideUiScaleConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060027DF RID: 10207 RVA: 0x0006A65C File Offset: 0x0006885C
		public static ISceneTextGuideUiScaleConfig Create([Nullable(2)] ISceneTextGuideUiScaleConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneTextGuideUiScaleConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060027E0 RID: 10208 RVA: 0x0006A66F File Offset: 0x0006886F
		public static ISceneTextGuideUiScaleConfig CreateFromSetValue([Nullable(2)] ISceneTextGuideUiScaleConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneTextGuideUiScaleConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060027E1 RID: 10209 RVA: 0x0006A684 File Offset: 0x00068884
		public ISceneTextGuideUiScaleConfig_SetValue ToSetValue()
		{
			return new ISceneTextGuideUiScaleConfig_SetValue
			{
				MinDist = this.MinDist,
				MaxDist = this.MaxDist,
				MinScale = this.MinScale,
				MaxScale = this.MaxScale,
				ScaleType = this.ScaleType
			};
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x060027E2 RID: 10210 RVA: 0x0006A6D2 File Offset: 0x000688D2
		// (set) Token: 0x060027E3 RID: 10211 RVA: 0x0006A6FD File Offset: 0x000688FD
		public virtual int MinDist
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MinDist;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MinDist;
			}
			set
			{
				this.GetOrCreatePoco().MinDist = value;
			}
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x060027E4 RID: 10212 RVA: 0x0006A70B File Offset: 0x0006890B
		// (set) Token: 0x060027E5 RID: 10213 RVA: 0x0006A736 File Offset: 0x00068936
		public virtual int MaxDist
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxDist;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MaxDist;
			}
			set
			{
				this.GetOrCreatePoco().MaxDist = value;
			}
		}

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x060027E6 RID: 10214 RVA: 0x0006A744 File Offset: 0x00068944
		// (set) Token: 0x060027E7 RID: 10215 RVA: 0x0006A773 File Offset: 0x00068973
		public virtual float MinScale
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MinScale;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.MinScale;
			}
			set
			{
				this.GetOrCreatePoco().MinScale = value;
			}
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x060027E8 RID: 10216 RVA: 0x0006A781 File Offset: 0x00068981
		// (set) Token: 0x060027E9 RID: 10217 RVA: 0x0006A7B0 File Offset: 0x000689B0
		public virtual float MaxScale
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxScale;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.MaxScale;
			}
			set
			{
				this.GetOrCreatePoco().MaxScale = value;
			}
		}

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x060027EA RID: 10218 RVA: 0x0006A7BE File Offset: 0x000689BE
		// (set) Token: 0x060027EB RID: 10219 RVA: 0x0006A7E9 File Offset: 0x000689E9
		public virtual ESceneTextGuideUiScaleType ScaleType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ScaleType;
				}
				if (this.PocoInterface == null)
				{
					return ESceneTextGuideUiScaleType.FarBigNearSmall;
				}
				return this.PocoInterface.ScaleType;
			}
			set
			{
				this.GetOrCreatePoco().ScaleType = value;
			}
		}

		// Token: 0x04001B30 RID: 6960
		[Nullable(2)]
		protected ISceneTextGuideUiScaleConfig FbInstance;

		// Token: 0x04001B31 RID: 6961
		[Nullable(2)]
		protected ISceneTextGuideUiScaleConfig_SetValue PocoInterface;
	}
}
