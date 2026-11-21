using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002013 RID: 8211
	public class ISceneUiSubtitleScatter : ISceneUiSubtitleStyleBase
	{
		// Token: 0x0600AE57 RID: 44631 RVA: 0x00189254 File Offset: 0x00187454
		private ISceneUiSubtitleScatter_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneUiSubtitleScatter 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneUiSubtitleScatter_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneUiSubtitleScatter_SetValue());
			}
			return result;
		}

		// Token: 0x0600AE58 RID: 44632 RVA: 0x0018928C File Offset: 0x0018748C
		public static ISceneUiSubtitleScatter Create([Nullable(2)] ISceneUiSubtitleScatter instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneUiSubtitleScatter
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AE59 RID: 44633 RVA: 0x0018929F File Offset: 0x0018749F
		public static ISceneUiSubtitleScatter CreateFromSetValue([Nullable(2)] ISceneUiSubtitleScatter_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneUiSubtitleScatter
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AE5A RID: 44634 RVA: 0x001892B4 File Offset: 0x001874B4
		public new ISceneUiSubtitleScatter_SetValue ToSetValue()
		{
			return new ISceneUiSubtitleScatter_SetValue
			{
				Position = this.Position,
				LockFacingCamera = this.LockFacingCamera,
				IsOccluded = this.IsOccluded,
				LocalizationConfig = this.LocalizationConfig,
				Type = this.Type
			};
		}

		// Token: 0x1700351D RID: 13597
		// (get) Token: 0x0600AE5B RID: 44635 RVA: 0x00189302 File Offset: 0x00187502
		// (set) Token: 0x0600AE5C RID: 44636 RVA: 0x00189329 File Offset: 0x00187529
		public override ISceneUiSubtitlePositionBase Position
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Position;
				}
				ISceneUiSubtitleScatter_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700351E RID: 13598
		// (get) Token: 0x0600AE5D RID: 44637 RVA: 0x00189338 File Offset: 0x00187538
		// (set) Token: 0x0600AE5E RID: 44638 RVA: 0x00189372 File Offset: 0x00187572
		public override bool? LockFacingCamera
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LockFacingCamera;
				}
				ISceneUiSubtitleScatter_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700351F RID: 13599
		// (get) Token: 0x0600AE5F RID: 44639 RVA: 0x00189380 File Offset: 0x00187580
		// (set) Token: 0x0600AE60 RID: 44640 RVA: 0x001893BA File Offset: 0x001875BA
		public override bool? IsOccluded
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsOccluded;
				}
				ISceneUiSubtitleScatter_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003520 RID: 13600
		// (get) Token: 0x0600AE61 RID: 44641 RVA: 0x001893C8 File Offset: 0x001875C8
		// (set) Token: 0x0600AE62 RID: 44642 RVA: 0x00189429 File Offset: 0x00187629
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
					ISceneUiSubtitleScatter_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003521 RID: 13601
		// (get) Token: 0x0600AE63 RID: 44643 RVA: 0x0018943E File Offset: 0x0018763E
		// (set) Token: 0x0600AE64 RID: 44644 RVA: 0x00189469 File Offset: 0x00187669
		public override ESceneUiSubtitleStyleType Type
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

		// Token: 0x040067F0 RID: 26608
		[Nullable(2)]
		protected new ISceneUiSubtitleScatter FbInstance;

		// Token: 0x040067F1 RID: 26609
		[Nullable(2)]
		protected new ISceneUiSubtitleScatter_SetValue PocoInterface;

		// Token: 0x040067F2 RID: 26610
		private ISceneUiSubtitleLocalizationConfig _LocalizationConfigCache;

		// Token: 0x040067F3 RID: 26611
		private bool _LocalizationConfigInited;
	}
}
