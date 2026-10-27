using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006B2 RID: 1714
	[NullableContext(1)]
	[Nullable(0)]
	public class ISceneTextGuideUiScaleConfig
	{
		// Token: 0x060024C2 RID: 9410 RVA: 0x0006365C File Offset: 0x0006185C
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

		// Token: 0x060024C3 RID: 9411 RVA: 0x00063694 File Offset: 0x00061894
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

		// Token: 0x060024C4 RID: 9412 RVA: 0x000636A7 File Offset: 0x000618A7
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

		// Token: 0x060024C5 RID: 9413 RVA: 0x000636BC File Offset: 0x000618BC
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

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x060024C6 RID: 9414 RVA: 0x0006370A File Offset: 0x0006190A
		// (set) Token: 0x060024C7 RID: 9415 RVA: 0x00063735 File Offset: 0x00061935
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

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x060024C8 RID: 9416 RVA: 0x00063743 File Offset: 0x00061943
		// (set) Token: 0x060024C9 RID: 9417 RVA: 0x0006376E File Offset: 0x0006196E
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

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x060024CA RID: 9418 RVA: 0x0006377C File Offset: 0x0006197C
		// (set) Token: 0x060024CB RID: 9419 RVA: 0x000637AB File Offset: 0x000619AB
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

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x060024CC RID: 9420 RVA: 0x000637B9 File Offset: 0x000619B9
		// (set) Token: 0x060024CD RID: 9421 RVA: 0x000637E8 File Offset: 0x000619E8
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

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x060024CE RID: 9422 RVA: 0x000637F6 File Offset: 0x000619F6
		// (set) Token: 0x060024CF RID: 9423 RVA: 0x00063821 File Offset: 0x00061A21
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

		// Token: 0x04001933 RID: 6451
		[Nullable(2)]
		protected ISceneTextGuideUiScaleConfig FbInstance;

		// Token: 0x04001934 RID: 6452
		[Nullable(2)]
		protected ISceneTextGuideUiScaleConfig_SetValue PocoInterface;
	}
}
