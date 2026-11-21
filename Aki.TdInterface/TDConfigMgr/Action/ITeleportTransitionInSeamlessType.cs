using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021E7 RID: 8679
	[NullableContext(2)]
	[Nullable(0)]
	public class ITeleportTransitionInSeamlessType : ITeleportTransitionType
	{
		// Token: 0x0600BD14 RID: 48404 RVA: 0x001B54CC File Offset: 0x001B36CC
		[NullableContext(0)]
		private ITeleportTransitionInSeamlessType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITeleportTransitionInSeamlessType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITeleportTransitionInSeamlessType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITeleportTransitionInSeamlessType_SetValue());
			}
			return result;
		}

		// Token: 0x0600BD15 RID: 48405 RVA: 0x001B5504 File Offset: 0x001B3704
		[NullableContext(0)]
		public static ITeleportTransitionInSeamlessType Create([Nullable(2)] ITeleportTransitionInSeamlessType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportTransitionInSeamlessType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BD16 RID: 48406 RVA: 0x001B5517 File Offset: 0x001B3717
		[NullableContext(0)]
		public static ITeleportTransitionInSeamlessType CreateFromSetValue([Nullable(2)] ITeleportTransitionInSeamlessType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITeleportTransitionInSeamlessType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BD17 RID: 48407 RVA: 0x001B552C File Offset: 0x001B372C
		[NullableContext(0)]
		public new ITeleportTransitionInSeamlessType_SetValue ToSetValue()
		{
			return new ITeleportTransitionInSeamlessType_SetValue
			{
				Type = this.Type,
				EffectDaPath = this.EffectDaPath,
				LeastTime = this.LeastTime,
				EffectExpandTime = this.EffectExpandTime,
				EffectCollapseTime = this.EffectCollapseTime,
				SceneEffectDaPath = this.SceneEffectDaPath,
				TransitionWeatherDaPath = this.TransitionWeatherDaPath,
				FloorSettings = this.FloorSettings,
				IsTeleportInPlace = this.IsTeleportInPlace,
				KeepMovementStates = this.KeepMovementStates,
				SeamlessTeleportFinishConfig = this.SeamlessTeleportFinishConfig,
				IsNormalStreamingLoad = this.IsNormalStreamingLoad
			};
		}

		// Token: 0x170039BF RID: 14783
		// (get) Token: 0x0600BD18 RID: 48408 RVA: 0x001B55CE File Offset: 0x001B37CE
		// (set) Token: 0x0600BD19 RID: 48409 RVA: 0x001B55F9 File Offset: 0x001B37F9
		public override ETeleportTransitionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETeleportTransitionType.PlayMp4;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170039C0 RID: 14784
		// (get) Token: 0x0600BD1A RID: 48410 RVA: 0x001B5607 File Offset: 0x001B3807
		// (set) Token: 0x0600BD1B RID: 48411 RVA: 0x001B5632 File Offset: 0x001B3832
		[Nullable(0)]
		public virtual string EffectDaPath
		{
			[NullableContext(0)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EffectDaPath;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.EffectDaPath;
			}
			[NullableContext(0)]
			set
			{
				this.GetOrCreatePoco().EffectDaPath = value;
			}
		}

		// Token: 0x170039C1 RID: 14785
		// (get) Token: 0x0600BD1C RID: 48412 RVA: 0x001B5640 File Offset: 0x001B3840
		// (set) Token: 0x0600BD1D RID: 48413 RVA: 0x001B566F File Offset: 0x001B386F
		public virtual float LeastTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LeastTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.LeastTime;
			}
			set
			{
				this.GetOrCreatePoco().LeastTime = value;
			}
		}

		// Token: 0x170039C2 RID: 14786
		// (get) Token: 0x0600BD1E RID: 48414 RVA: 0x001B567D File Offset: 0x001B387D
		// (set) Token: 0x0600BD1F RID: 48415 RVA: 0x001B56AC File Offset: 0x001B38AC
		public virtual float EffectExpandTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EffectExpandTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.EffectExpandTime;
			}
			set
			{
				this.GetOrCreatePoco().EffectExpandTime = value;
			}
		}

		// Token: 0x170039C3 RID: 14787
		// (get) Token: 0x0600BD20 RID: 48416 RVA: 0x001B56BA File Offset: 0x001B38BA
		// (set) Token: 0x0600BD21 RID: 48417 RVA: 0x001B56E9 File Offset: 0x001B38E9
		public virtual float EffectCollapseTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EffectCollapseTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.EffectCollapseTime;
			}
			set
			{
				this.GetOrCreatePoco().EffectCollapseTime = value;
			}
		}

		// Token: 0x170039C4 RID: 14788
		// (get) Token: 0x0600BD22 RID: 48418 RVA: 0x001B56F7 File Offset: 0x001B38F7
		// (set) Token: 0x0600BD23 RID: 48419 RVA: 0x001B571E File Offset: 0x001B391E
		public virtual string SceneEffectDaPath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SceneEffectDaPath;
				}
				ITeleportTransitionInSeamlessType_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SceneEffectDaPath;
			}
			set
			{
				this.GetOrCreatePoco().SceneEffectDaPath = value;
			}
		}

		// Token: 0x170039C5 RID: 14789
		// (get) Token: 0x0600BD24 RID: 48420 RVA: 0x001B572C File Offset: 0x001B392C
		// (set) Token: 0x0600BD25 RID: 48421 RVA: 0x001B5753 File Offset: 0x001B3953
		public virtual string TransitionWeatherDaPath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TransitionWeatherDaPath;
				}
				ITeleportTransitionInSeamlessType_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TransitionWeatherDaPath;
			}
			set
			{
				this.GetOrCreatePoco().TransitionWeatherDaPath = value;
			}
		}

		// Token: 0x170039C6 RID: 14790
		// (get) Token: 0x0600BD26 RID: 48422 RVA: 0x001B5764 File Offset: 0x001B3964
		// (set) Token: 0x0600BD27 RID: 48423 RVA: 0x001B57C5 File Offset: 0x001B39C5
		public virtual IFloorSettings FloorSettings
		{
			get
			{
				if (this._FloorSettingsInited)
				{
					return this._FloorSettingsCache;
				}
				this._FloorSettingsInited = true;
				if (this.FbInstance != null)
				{
					this._FloorSettingsCache = IFloorSettings.Create(this.FbInstance.FloorSettings);
				}
				else
				{
					ITeleportTransitionInSeamlessType_SetValue pocoInterface = this.PocoInterface;
					this._FloorSettingsCache = ((pocoInterface != null) ? pocoInterface.FloorSettings : null);
				}
				return this._FloorSettingsCache;
			}
			set
			{
				this.GetOrCreatePoco().FloorSettings = value;
				this._FloorSettingsInited = false;
			}
		}

		// Token: 0x170039C7 RID: 14791
		// (get) Token: 0x0600BD28 RID: 48424 RVA: 0x001B57DC File Offset: 0x001B39DC
		// (set) Token: 0x0600BD29 RID: 48425 RVA: 0x001B5816 File Offset: 0x001B3A16
		public virtual bool? IsTeleportInPlace
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsTeleportInPlace;
				}
				ITeleportTransitionInSeamlessType_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsTeleportInPlace;
			}
			set
			{
				this.GetOrCreatePoco().IsTeleportInPlace = value;
			}
		}

		// Token: 0x170039C8 RID: 14792
		// (get) Token: 0x0600BD2A RID: 48426 RVA: 0x001B5824 File Offset: 0x001B3A24
		// (set) Token: 0x0600BD2B RID: 48427 RVA: 0x001B584B File Offset: 0x001B3A4B
		public virtual List<EKeepMovementState> KeepMovementStates
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.KeepMovementStates;
				}
				ITeleportTransitionInSeamlessType_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.KeepMovementStates;
			}
			set
			{
				this.GetOrCreatePoco().KeepMovementStates = value;
			}
		}

		// Token: 0x170039C9 RID: 14793
		// (get) Token: 0x0600BD2C RID: 48428 RVA: 0x001B585C File Offset: 0x001B3A5C
		// (set) Token: 0x0600BD2D RID: 48429 RVA: 0x001B58BD File Offset: 0x001B3ABD
		public virtual ISeamlessTeleportFinishConfig SeamlessTeleportFinishConfig
		{
			get
			{
				if (this._SeamlessTeleportFinishConfigInited)
				{
					return this._SeamlessTeleportFinishConfigCache;
				}
				this._SeamlessTeleportFinishConfigInited = true;
				if (this.FbInstance != null)
				{
					this._SeamlessTeleportFinishConfigCache = ISeamlessTeleportFinishConfig.Create(this.FbInstance.SeamlessTeleportFinishConfig);
				}
				else
				{
					ITeleportTransitionInSeamlessType_SetValue pocoInterface = this.PocoInterface;
					this._SeamlessTeleportFinishConfigCache = ((pocoInterface != null) ? pocoInterface.SeamlessTeleportFinishConfig : null);
				}
				return this._SeamlessTeleportFinishConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().SeamlessTeleportFinishConfig = value;
				this._SeamlessTeleportFinishConfigInited = false;
			}
		}

		// Token: 0x170039CA RID: 14794
		// (get) Token: 0x0600BD2E RID: 48430 RVA: 0x001B58D4 File Offset: 0x001B3AD4
		// (set) Token: 0x0600BD2F RID: 48431 RVA: 0x001B590E File Offset: 0x001B3B0E
		public virtual bool? IsNormalStreamingLoad
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsNormalStreamingLoad;
				}
				ITeleportTransitionInSeamlessType_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsNormalStreamingLoad;
			}
			set
			{
				this.GetOrCreatePoco().IsNormalStreamingLoad = value;
			}
		}

		// Token: 0x04007188 RID: 29064
		protected new ITeleportTransitionInSeamlessType FbInstance;

		// Token: 0x04007189 RID: 29065
		protected new ITeleportTransitionInSeamlessType_SetValue PocoInterface;

		// Token: 0x0400718A RID: 29066
		[Nullable(0)]
		private IFloorSettings _FloorSettingsCache;

		// Token: 0x0400718B RID: 29067
		private bool _FloorSettingsInited;

		// Token: 0x0400718C RID: 29068
		[Nullable(0)]
		private ISeamlessTeleportFinishConfig _SeamlessTeleportFinishConfigCache;

		// Token: 0x0400718D RID: 29069
		private bool _SeamlessTeleportFinishConfigInited;
	}
}
