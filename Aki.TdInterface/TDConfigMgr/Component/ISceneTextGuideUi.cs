using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200074D RID: 1869
	public class ISceneTextGuideUi : ISceneTextTypeBase
	{
		// Token: 0x060027BA RID: 10170 RVA: 0x0006A17C File Offset: 0x0006837C
		private ISceneTextGuideUi_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneTextGuideUi 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneTextGuideUi_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneTextGuideUi_SetValue());
			}
			return result;
		}

		// Token: 0x060027BB RID: 10171 RVA: 0x0006A1B4 File Offset: 0x000683B4
		public static ISceneTextGuideUi Create([Nullable(2)] ISceneTextGuideUi instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneTextGuideUi
			{
				FbInstance = instance
			};
		}

		// Token: 0x060027BC RID: 10172 RVA: 0x0006A1C7 File Offset: 0x000683C7
		public static ISceneTextGuideUi CreateFromSetValue([Nullable(2)] ISceneTextGuideUi_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneTextGuideUi
			{
				PocoInterface = value
			};
		}

		// Token: 0x060027BD RID: 10173 RVA: 0x0006A1DA File Offset: 0x000683DA
		public new ISceneTextGuideUi_SetValue ToSetValue()
		{
			return new ISceneTextGuideUi_SetValue
			{
				Type = this.Type,
				ScaleConfig = this.ScaleConfig,
				Content = this.Content
			};
		}

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x060027BE RID: 10174 RVA: 0x0006A205 File Offset: 0x00068405
		// (set) Token: 0x060027BF RID: 10175 RVA: 0x0006A230 File Offset: 0x00068430
		public override ESceneTextType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESceneTextType.SubtitleWithVoice;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x060027C0 RID: 10176 RVA: 0x0006A240 File Offset: 0x00068440
		// (set) Token: 0x060027C1 RID: 10177 RVA: 0x0006A2A1 File Offset: 0x000684A1
		public virtual ISceneTextGuideUiScaleConfig ScaleConfig
		{
			get
			{
				if (this._ScaleConfigInited)
				{
					return this._ScaleConfigCache;
				}
				this._ScaleConfigInited = true;
				if (this.FbInstance != null)
				{
					this._ScaleConfigCache = ISceneTextGuideUiScaleConfig.Create(this.FbInstance.ScaleConfig);
				}
				else
				{
					ISceneTextGuideUi_SetValue pocoInterface = this.PocoInterface;
					this._ScaleConfigCache = ((pocoInterface != null) ? pocoInterface.ScaleConfig : null);
				}
				return this._ScaleConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().ScaleConfig = value;
				this._ScaleConfigInited = false;
			}
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x060027C2 RID: 10178 RVA: 0x0006A2B8 File Offset: 0x000684B8
		// (set) Token: 0x060027C3 RID: 10179 RVA: 0x0006A319 File Offset: 0x00068519
		public virtual ISceneTextGuideUiContent Content
		{
			get
			{
				if (this._ContentInited)
				{
					return this._ContentCache;
				}
				this._ContentInited = true;
				if (this.FbInstance != null)
				{
					this._ContentCache = ISceneTextGuideUiContent.Create(this.FbInstance.Content);
				}
				else
				{
					ISceneTextGuideUi_SetValue pocoInterface = this.PocoInterface;
					this._ContentCache = ((pocoInterface != null) ? pocoInterface.Content : null);
				}
				return this._ContentCache;
			}
			set
			{
				this.GetOrCreatePoco().Content = value;
				this._ContentInited = false;
			}
		}

		// Token: 0x04001B1B RID: 6939
		[Nullable(2)]
		protected new ISceneTextGuideUi FbInstance;

		// Token: 0x04001B1C RID: 6940
		[Nullable(2)]
		protected new ISceneTextGuideUi_SetValue PocoInterface;

		// Token: 0x04001B1D RID: 6941
		private ISceneTextGuideUiScaleConfig _ScaleConfigCache;

		// Token: 0x04001B1E RID: 6942
		private bool _ScaleConfigInited;

		// Token: 0x04001B1F RID: 6943
		private ISceneTextGuideUiContent _ContentCache;

		// Token: 0x04001B20 RID: 6944
		private bool _ContentInited;
	}
}
