using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006AC RID: 1708
	[NullableContext(1)]
	[Nullable(0)]
	public class ISceneTextGuideUi : ISceneTextTypeBase
	{
		// Token: 0x0600249E RID: 9374 RVA: 0x000631B4 File Offset: 0x000613B4
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

		// Token: 0x0600249F RID: 9375 RVA: 0x000631EC File Offset: 0x000613EC
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

		// Token: 0x060024A0 RID: 9376 RVA: 0x000631FF File Offset: 0x000613FF
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

		// Token: 0x060024A1 RID: 9377 RVA: 0x00063212 File Offset: 0x00061412
		public new ISceneTextGuideUi_SetValue ToSetValue()
		{
			return new ISceneTextGuideUi_SetValue
			{
				Type = this.Type,
				ScaleConfig = this.ScaleConfig,
				Content = this.Content
			};
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x060024A2 RID: 9378 RVA: 0x0006323D File Offset: 0x0006143D
		// (set) Token: 0x060024A3 RID: 9379 RVA: 0x00063268 File Offset: 0x00061468
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

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x060024A4 RID: 9380 RVA: 0x00063278 File Offset: 0x00061478
		// (set) Token: 0x060024A5 RID: 9381 RVA: 0x000632D9 File Offset: 0x000614D9
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

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x060024A6 RID: 9382 RVA: 0x000632F0 File Offset: 0x000614F0
		// (set) Token: 0x060024A7 RID: 9383 RVA: 0x00063351 File Offset: 0x00061551
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

		// Token: 0x0400191E RID: 6430
		[Nullable(2)]
		protected new ISceneTextGuideUi FbInstance;

		// Token: 0x0400191F RID: 6431
		[Nullable(2)]
		protected new ISceneTextGuideUi_SetValue PocoInterface;

		// Token: 0x04001920 RID: 6432
		private ISceneTextGuideUiScaleConfig _ScaleConfigCache;

		// Token: 0x04001921 RID: 6433
		private bool _ScaleConfigInited;

		// Token: 0x04001922 RID: 6434
		private ISceneTextGuideUiContent _ContentCache;

		// Token: 0x04001923 RID: 6435
		private bool _ContentInited;
	}
}
