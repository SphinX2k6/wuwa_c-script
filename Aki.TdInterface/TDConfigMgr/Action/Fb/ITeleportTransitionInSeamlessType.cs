using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002967 RID: 10599
	[NullableContext(2)]
	[Nullable(0)]
	public class ITeleportTransitionInSeamlessType : ITeleportTransitionType
	{
		// Token: 0x0600EB37 RID: 60215 RVA: 0x0022AAD6 File Offset: 0x00228CD6
		[NullableContext(0)]
		public static ITeleportTransitionInSeamlessType Create(ITeleportTransitionInSeamlessType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportTransitionInSeamlessType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004517 RID: 17687
		// (get) Token: 0x0600EB38 RID: 60216 RVA: 0x0022AAF5 File Offset: 0x00228CF5
		public override ETeleportTransitionType Type
		{
			get
			{
				return (ETeleportTransitionType)this.Instance.Type;
			}
		}

		// Token: 0x17004518 RID: 17688
		// (get) Token: 0x0600EB39 RID: 60217 RVA: 0x0022AB02 File Offset: 0x00228D02
		[Nullable(0)]
		public virtual string EffectDaPath
		{
			[NullableContext(0)]
			get
			{
				return this.Instance.EffectDaPath;
			}
		}

		// Token: 0x17004519 RID: 17689
		// (get) Token: 0x0600EB3A RID: 60218 RVA: 0x0022AB0F File Offset: 0x00228D0F
		public virtual float LeastTime
		{
			get
			{
				return this.Instance.LeastTime;
			}
		}

		// Token: 0x1700451A RID: 17690
		// (get) Token: 0x0600EB3B RID: 60219 RVA: 0x0022AB1C File Offset: 0x00228D1C
		public virtual float EffectExpandTime
		{
			get
			{
				return this.Instance.EffectExpandTime;
			}
		}

		// Token: 0x1700451B RID: 17691
		// (get) Token: 0x0600EB3C RID: 60220 RVA: 0x0022AB29 File Offset: 0x00228D29
		public virtual float EffectCollapseTime
		{
			get
			{
				return this.Instance.EffectCollapseTime;
			}
		}

		// Token: 0x1700451C RID: 17692
		// (get) Token: 0x0600EB3D RID: 60221 RVA: 0x0022AB36 File Offset: 0x00228D36
		public virtual string SceneEffectDaPath
		{
			get
			{
				return this.Instance.SceneEffectDaPath;
			}
		}

		// Token: 0x1700451D RID: 17693
		// (get) Token: 0x0600EB3E RID: 60222 RVA: 0x0022AB43 File Offset: 0x00228D43
		public virtual string TransitionWeatherDaPath
		{
			get
			{
				return this.Instance.TransitionWeatherDaPath;
			}
		}

		// Token: 0x1700451E RID: 17694
		// (get) Token: 0x0600EB3F RID: 60223 RVA: 0x0022AB50 File Offset: 0x00228D50
		public virtual IFloorSettings FloorSettings
		{
			get
			{
				if (this._FloorSettingsInited)
				{
					return this._FloorSettingsCache;
				}
				this._FloorSettingsInited = true;
				this._FloorSettingsCache = IFloorSettings.Create(this.Instance.FloorSettings);
				return this._FloorSettingsCache;
			}
		}

		// Token: 0x1700451F RID: 17695
		// (get) Token: 0x0600EB40 RID: 60224 RVA: 0x0022AB84 File Offset: 0x00228D84
		public virtual bool? IsTeleportInPlace
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsTeleportInPlace);
			}
		}

		// Token: 0x17004520 RID: 17696
		// (get) Token: 0x0600EB41 RID: 60225 RVA: 0x0022ABBC File Offset: 0x00228DBC
		public virtual List<EKeepMovementState> KeepMovementStates
		{
			get
			{
				if (this._KeepMovementStatesInited)
				{
					return this._KeepMovementStatesCache;
				}
				this._KeepMovementStatesInited = true;
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int keepMovementStatesLength = this.Instance.KeepMovementStatesLength;
				this._KeepMovementStatesCache = new List<EKeepMovementState>(keepMovementStatesLength);
				for (int i = 0; i < keepMovementStatesLength; i++)
				{
					this._KeepMovementStatesCache.Add((EKeepMovementState)this.Instance.KeepMovementStates(i));
				}
				return this._KeepMovementStatesCache;
			}
		}

		// Token: 0x17004521 RID: 17697
		// (get) Token: 0x0600EB42 RID: 60226 RVA: 0x0022AC31 File Offset: 0x00228E31
		public virtual ISeamlessTeleportFinishConfig SeamlessTeleportFinishConfig
		{
			get
			{
				if (this._SeamlessTeleportFinishConfigInited)
				{
					return this._SeamlessTeleportFinishConfigCache;
				}
				this._SeamlessTeleportFinishConfigInited = true;
				this._SeamlessTeleportFinishConfigCache = ISeamlessTeleportFinishConfig.Create(this.Instance.SeamlessTeleportFinishConfig);
				return this._SeamlessTeleportFinishConfigCache;
			}
		}

		// Token: 0x17004522 RID: 17698
		// (get) Token: 0x0600EB43 RID: 60227 RVA: 0x0022AC68 File Offset: 0x00228E68
		public virtual bool? IsNormalStreamingLoad
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsNormalStreamingLoad);
			}
		}

		// Token: 0x04008191 RID: 33169
		private ITeleportTransitionInSeamlessType Instance;

		// Token: 0x04008192 RID: 33170
		private IFloorSettings _FloorSettingsCache;

		// Token: 0x04008193 RID: 33171
		private bool _FloorSettingsInited;

		// Token: 0x04008194 RID: 33172
		private List<EKeepMovementState> _KeepMovementStatesCache;

		// Token: 0x04008195 RID: 33173
		private bool _KeepMovementStatesInited;

		// Token: 0x04008196 RID: 33174
		private ISeamlessTeleportFinishConfig _SeamlessTeleportFinishConfigCache;

		// Token: 0x04008197 RID: 33175
		private bool _SeamlessTeleportFinishConfigInited;
	}
}
