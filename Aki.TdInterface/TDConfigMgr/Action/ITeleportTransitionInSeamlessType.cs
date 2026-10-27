using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FA4 RID: 8100
	[NullableContext(2)]
	[Nullable(0)]
	public class ITeleportTransitionInSeamlessType : ITeleportTransitionType
	{
		// Token: 0x0600B210 RID: 45584 RVA: 0x0019F11C File Offset: 0x0019D31C
		[NullableContext(1)]
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

		// Token: 0x0600B211 RID: 45585 RVA: 0x0019F154 File Offset: 0x0019D354
		[NullableContext(1)]
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

		// Token: 0x0600B212 RID: 45586 RVA: 0x0019F167 File Offset: 0x0019D367
		[NullableContext(1)]
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

		// Token: 0x0600B213 RID: 45587 RVA: 0x0019F17C File Offset: 0x0019D37C
		[NullableContext(1)]
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

		// Token: 0x170036EA RID: 14058
		// (get) Token: 0x0600B214 RID: 45588 RVA: 0x0019F21E File Offset: 0x0019D41E
		// (set) Token: 0x0600B215 RID: 45589 RVA: 0x0019F249 File Offset: 0x0019D449
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

		// Token: 0x170036EB RID: 14059
		// (get) Token: 0x0600B216 RID: 45590 RVA: 0x0019F257 File Offset: 0x0019D457
		// (set) Token: 0x0600B217 RID: 45591 RVA: 0x0019F282 File Offset: 0x0019D482
		[Nullable(1)]
		public virtual string EffectDaPath
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				this.GetOrCreatePoco().EffectDaPath = value;
			}
		}

		// Token: 0x170036EC RID: 14060
		// (get) Token: 0x0600B218 RID: 45592 RVA: 0x0019F290 File Offset: 0x0019D490
		// (set) Token: 0x0600B219 RID: 45593 RVA: 0x0019F2BF File Offset: 0x0019D4BF
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

		// Token: 0x170036ED RID: 14061
		// (get) Token: 0x0600B21A RID: 45594 RVA: 0x0019F2CD File Offset: 0x0019D4CD
		// (set) Token: 0x0600B21B RID: 45595 RVA: 0x0019F2FC File Offset: 0x0019D4FC
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

		// Token: 0x170036EE RID: 14062
		// (get) Token: 0x0600B21C RID: 45596 RVA: 0x0019F30A File Offset: 0x0019D50A
		// (set) Token: 0x0600B21D RID: 45597 RVA: 0x0019F339 File Offset: 0x0019D539
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

		// Token: 0x170036EF RID: 14063
		// (get) Token: 0x0600B21E RID: 45598 RVA: 0x0019F347 File Offset: 0x0019D547
		// (set) Token: 0x0600B21F RID: 45599 RVA: 0x0019F36E File Offset: 0x0019D56E
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

		// Token: 0x170036F0 RID: 14064
		// (get) Token: 0x0600B220 RID: 45600 RVA: 0x0019F37C File Offset: 0x0019D57C
		// (set) Token: 0x0600B221 RID: 45601 RVA: 0x0019F3A3 File Offset: 0x0019D5A3
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

		// Token: 0x170036F1 RID: 14065
		// (get) Token: 0x0600B222 RID: 45602 RVA: 0x0019F3B4 File Offset: 0x0019D5B4
		// (set) Token: 0x0600B223 RID: 45603 RVA: 0x0019F415 File Offset: 0x0019D615
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

		// Token: 0x170036F2 RID: 14066
		// (get) Token: 0x0600B224 RID: 45604 RVA: 0x0019F42C File Offset: 0x0019D62C
		// (set) Token: 0x0600B225 RID: 45605 RVA: 0x0019F466 File Offset: 0x0019D666
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

		// Token: 0x170036F3 RID: 14067
		// (get) Token: 0x0600B226 RID: 45606 RVA: 0x0019F474 File Offset: 0x0019D674
		// (set) Token: 0x0600B227 RID: 45607 RVA: 0x0019F49B File Offset: 0x0019D69B
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

		// Token: 0x170036F4 RID: 14068
		// (get) Token: 0x0600B228 RID: 45608 RVA: 0x0019F4AC File Offset: 0x0019D6AC
		// (set) Token: 0x0600B229 RID: 45609 RVA: 0x0019F50D File Offset: 0x0019D70D
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

		// Token: 0x170036F5 RID: 14069
		// (get) Token: 0x0600B22A RID: 45610 RVA: 0x0019F524 File Offset: 0x0019D724
		// (set) Token: 0x0600B22B RID: 45611 RVA: 0x0019F55E File Offset: 0x0019D75E
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

		// Token: 0x04006B8D RID: 27533
		protected new ITeleportTransitionInSeamlessType FbInstance;

		// Token: 0x04006B8E RID: 27534
		protected new ITeleportTransitionInSeamlessType_SetValue PocoInterface;

		// Token: 0x04006B8F RID: 27535
		[Nullable(1)]
		private IFloorSettings _FloorSettingsCache;

		// Token: 0x04006B90 RID: 27536
		private bool _FloorSettingsInited;

		// Token: 0x04006B91 RID: 27537
		[Nullable(1)]
		private ISeamlessTeleportFinishConfig _SeamlessTeleportFinishConfigCache;

		// Token: 0x04006B92 RID: 27538
		private bool _SeamlessTeleportFinishConfigInited;
	}
}
