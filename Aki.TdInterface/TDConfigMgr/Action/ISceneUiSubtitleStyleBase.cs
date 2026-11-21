using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002015 RID: 8213
	public class ISceneUiSubtitleStyleBase : ISceneUiSubtitleConfig
	{
		// Token: 0x0600AE67 RID: 44647 RVA: 0x00189488 File Offset: 0x00187688
		private ISceneUiSubtitleStyleBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneUiSubtitleStyleBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneUiSubtitleStyleBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneUiSubtitleStyleBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600AE68 RID: 44648 RVA: 0x001894C0 File Offset: 0x001876C0
		public static ISceneUiSubtitleStyleBase Create([Nullable(2)] ISceneUiSubtitleStyleBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneUiSubtitleStyleBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AE69 RID: 44649 RVA: 0x001894D3 File Offset: 0x001876D3
		public static ISceneUiSubtitleStyleBase CreateFromSetValue([Nullable(2)] ISceneUiSubtitleStyleBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneUiSubtitleStyleBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AE6A RID: 44650 RVA: 0x001894E8 File Offset: 0x001876E8
		public new ISceneUiSubtitleStyleBase_SetValue ToSetValue()
		{
			return new ISceneUiSubtitleStyleBase_SetValue
			{
				Position = this.Position,
				LockFacingCamera = this.LockFacingCamera,
				IsOccluded = this.IsOccluded,
				LocalizationConfig = this.LocalizationConfig,
				Type = this.Type
			};
		}

		// Token: 0x17003522 RID: 13602
		// (get) Token: 0x0600AE6B RID: 44651 RVA: 0x00189536 File Offset: 0x00187736
		// (set) Token: 0x0600AE6C RID: 44652 RVA: 0x0018955D File Offset: 0x0018775D
		public override ISceneUiSubtitlePositionBase Position
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Position;
				}
				ISceneUiSubtitleStyleBase_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Position;
			}
			set
			{
				this.GetOrCreatePoco().Position = value;
			}
		}

		// Token: 0x17003523 RID: 13603
		// (get) Token: 0x0600AE6D RID: 44653 RVA: 0x0018956C File Offset: 0x0018776C
		// (set) Token: 0x0600AE6E RID: 44654 RVA: 0x001895A6 File Offset: 0x001877A6
		public override bool? LockFacingCamera
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LockFacingCamera;
				}
				ISceneUiSubtitleStyleBase_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LockFacingCamera;
			}
			set
			{
				this.GetOrCreatePoco().LockFacingCamera = value;
			}
		}

		// Token: 0x17003524 RID: 13604
		// (get) Token: 0x0600AE6F RID: 44655 RVA: 0x001895B4 File Offset: 0x001877B4
		// (set) Token: 0x0600AE70 RID: 44656 RVA: 0x001895EE File Offset: 0x001877EE
		public override bool? IsOccluded
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsOccluded;
				}
				ISceneUiSubtitleStyleBase_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsOccluded;
			}
			set
			{
				this.GetOrCreatePoco().IsOccluded = value;
			}
		}

		// Token: 0x17003525 RID: 13605
		// (get) Token: 0x0600AE71 RID: 44657 RVA: 0x001895FC File Offset: 0x001877FC
		// (set) Token: 0x0600AE72 RID: 44658 RVA: 0x0018965D File Offset: 0x0018785D
		[Nullable(2)]
		public override ISceneUiSubtitleLocalizationConfig LocalizationConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._LocalizationConfigInited)
				{
					return this._LocalizationConfigCache;
				}
				this._LocalizationConfigInited = true;
				if (this.FbInstance != null)
				{
					this._LocalizationConfigCache = ISceneUiSubtitleLocalizationConfig.Create(this.FbInstance.LocalizationConfig);
				}
				else
				{
					ISceneUiSubtitleStyleBase_SetValue pocoInterface = this.PocoInterface;
					this._LocalizationConfigCache = ((pocoInterface != null) ? pocoInterface.LocalizationConfig : null);
				}
				return this._LocalizationConfigCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().LocalizationConfig = value;
				this._LocalizationConfigInited = false;
			}
		}

		// Token: 0x17003526 RID: 13606
		// (get) Token: 0x0600AE73 RID: 44659 RVA: 0x00189672 File Offset: 0x00187872
		// (set) Token: 0x0600AE74 RID: 44660 RVA: 0x0018969D File Offset: 0x0018789D
		public virtual ESceneUiSubtitleStyleType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESceneUiSubtitleStyleType.SceneUiSubtitleScatter;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040067F9 RID: 26617
		[Nullable(2)]
		protected new ISceneUiSubtitleStyleBase FbInstance;

		// Token: 0x040067FA RID: 26618
		[Nullable(2)]
		protected new ISceneUiSubtitleStyleBase_SetValue PocoInterface;

		// Token: 0x040067FB RID: 26619
		private ISceneUiSubtitleLocalizationConfig _LocalizationConfigCache;

		// Token: 0x040067FC RID: 26620
		private bool _LocalizationConfigInited;
	}
}
