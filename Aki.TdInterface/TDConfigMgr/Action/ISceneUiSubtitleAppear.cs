using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002003 RID: 8195
	public class ISceneUiSubtitleAppear : ISceneUiSubtitleStyleBase
	{
		// Token: 0x0600AE01 RID: 44545 RVA: 0x00188808 File Offset: 0x00186A08
		private ISceneUiSubtitleAppear_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneUiSubtitleAppear 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneUiSubtitleAppear_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneUiSubtitleAppear_SetValue());
			}
			return result;
		}

		// Token: 0x0600AE02 RID: 44546 RVA: 0x00188840 File Offset: 0x00186A40
		public static ISceneUiSubtitleAppear Create([Nullable(2)] ISceneUiSubtitleAppear instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneUiSubtitleAppear
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AE03 RID: 44547 RVA: 0x00188853 File Offset: 0x00186A53
		public static ISceneUiSubtitleAppear CreateFromSetValue([Nullable(2)] ISceneUiSubtitleAppear_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneUiSubtitleAppear
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AE04 RID: 44548 RVA: 0x00188868 File Offset: 0x00186A68
		public new ISceneUiSubtitleAppear_SetValue ToSetValue()
		{
			return new ISceneUiSubtitleAppear_SetValue
			{
				Position = this.Position,
				LockFacingCamera = this.LockFacingCamera,
				IsOccluded = this.IsOccluded,
				LocalizationConfig = this.LocalizationConfig,
				Type = this.Type
			};
		}

		// Token: 0x1700350A RID: 13578
		// (get) Token: 0x0600AE05 RID: 44549 RVA: 0x001888B6 File Offset: 0x00186AB6
		// (set) Token: 0x0600AE06 RID: 44550 RVA: 0x001888DD File Offset: 0x00186ADD
		public override ISceneUiSubtitlePositionBase Position
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Position;
				}
				ISceneUiSubtitleAppear_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700350B RID: 13579
		// (get) Token: 0x0600AE07 RID: 44551 RVA: 0x001888EC File Offset: 0x00186AEC
		// (set) Token: 0x0600AE08 RID: 44552 RVA: 0x00188926 File Offset: 0x00186B26
		public override bool? LockFacingCamera
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LockFacingCamera;
				}
				ISceneUiSubtitleAppear_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700350C RID: 13580
		// (get) Token: 0x0600AE09 RID: 44553 RVA: 0x00188934 File Offset: 0x00186B34
		// (set) Token: 0x0600AE0A RID: 44554 RVA: 0x0018896E File Offset: 0x00186B6E
		public override bool? IsOccluded
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsOccluded;
				}
				ISceneUiSubtitleAppear_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700350D RID: 13581
		// (get) Token: 0x0600AE0B RID: 44555 RVA: 0x0018897C File Offset: 0x00186B7C
		// (set) Token: 0x0600AE0C RID: 44556 RVA: 0x001889DD File Offset: 0x00186BDD
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
					ISceneUiSubtitleAppear_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700350E RID: 13582
		// (get) Token: 0x0600AE0D RID: 44557 RVA: 0x001889F2 File Offset: 0x00186BF2
		// (set) Token: 0x0600AE0E RID: 44558 RVA: 0x00188A1D File Offset: 0x00186C1D
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

		// Token: 0x040067C5 RID: 26565
		[Nullable(2)]
		protected new ISceneUiSubtitleAppear FbInstance;

		// Token: 0x040067C6 RID: 26566
		[Nullable(2)]
		protected new ISceneUiSubtitleAppear_SetValue PocoInterface;

		// Token: 0x040067C7 RID: 26567
		private ISceneUiSubtitleLocalizationConfig _LocalizationConfigCache;

		// Token: 0x040067C8 RID: 26568
		private bool _LocalizationConfigInited;
	}
}
