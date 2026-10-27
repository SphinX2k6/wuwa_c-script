using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026A4 RID: 9892
	[NullableContext(2)]
	[Nullable(0)]
	public class ITeleportTransitionInSeamlessType : ITeleportTransitionType
	{
		// Token: 0x0600DD60 RID: 56672 RVA: 0x0020E336 File Offset: 0x0020C536
		[NullableContext(1)]
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

		// Token: 0x170041DA RID: 16858
		// (get) Token: 0x0600DD61 RID: 56673 RVA: 0x0020E355 File Offset: 0x0020C555
		public override ETeleportTransitionType Type
		{
			get
			{
				return (ETeleportTransitionType)this.Instance.Type;
			}
		}

		// Token: 0x170041DB RID: 16859
		// (get) Token: 0x0600DD62 RID: 56674 RVA: 0x0020E362 File Offset: 0x0020C562
		[Nullable(1)]
		public virtual string EffectDaPath
		{
			[NullableContext(1)]
			get
			{
				return this.Instance.EffectDaPath;
			}
		}

		// Token: 0x170041DC RID: 16860
		// (get) Token: 0x0600DD63 RID: 56675 RVA: 0x0020E36F File Offset: 0x0020C56F
		public virtual float LeastTime
		{
			get
			{
				return this.Instance.LeastTime;
			}
		}

		// Token: 0x170041DD RID: 16861
		// (get) Token: 0x0600DD64 RID: 56676 RVA: 0x0020E37C File Offset: 0x0020C57C
		public virtual float EffectExpandTime
		{
			get
			{
				return this.Instance.EffectExpandTime;
			}
		}

		// Token: 0x170041DE RID: 16862
		// (get) Token: 0x0600DD65 RID: 56677 RVA: 0x0020E389 File Offset: 0x0020C589
		public virtual float EffectCollapseTime
		{
			get
			{
				return this.Instance.EffectCollapseTime;
			}
		}

		// Token: 0x170041DF RID: 16863
		// (get) Token: 0x0600DD66 RID: 56678 RVA: 0x0020E396 File Offset: 0x0020C596
		public virtual string SceneEffectDaPath
		{
			get
			{
				return this.Instance.SceneEffectDaPath;
			}
		}

		// Token: 0x170041E0 RID: 16864
		// (get) Token: 0x0600DD67 RID: 56679 RVA: 0x0020E3A3 File Offset: 0x0020C5A3
		public virtual string TransitionWeatherDaPath
		{
			get
			{
				return this.Instance.TransitionWeatherDaPath;
			}
		}

		// Token: 0x170041E1 RID: 16865
		// (get) Token: 0x0600DD68 RID: 56680 RVA: 0x0020E3B0 File Offset: 0x0020C5B0
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

		// Token: 0x170041E2 RID: 16866
		// (get) Token: 0x0600DD69 RID: 56681 RVA: 0x0020E3E4 File Offset: 0x0020C5E4
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

		// Token: 0x170041E3 RID: 16867
		// (get) Token: 0x0600DD6A RID: 56682 RVA: 0x0020E41C File Offset: 0x0020C61C
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

		// Token: 0x170041E4 RID: 16868
		// (get) Token: 0x0600DD6B RID: 56683 RVA: 0x0020E491 File Offset: 0x0020C691
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

		// Token: 0x170041E5 RID: 16869
		// (get) Token: 0x0600DD6C RID: 56684 RVA: 0x0020E4C8 File Offset: 0x0020C6C8
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

		// Token: 0x04007AF4 RID: 31476
		private ITeleportTransitionInSeamlessType Instance;

		// Token: 0x04007AF5 RID: 31477
		private IFloorSettings _FloorSettingsCache;

		// Token: 0x04007AF6 RID: 31478
		private bool _FloorSettingsInited;

		// Token: 0x04007AF7 RID: 31479
		private List<EKeepMovementState> _KeepMovementStatesCache;

		// Token: 0x04007AF8 RID: 31480
		private bool _KeepMovementStatesInited;

		// Token: 0x04007AF9 RID: 31481
		private ISeamlessTeleportFinishConfig _SeamlessTeleportFinishConfigCache;

		// Token: 0x04007AFA RID: 31482
		private bool _SeamlessTeleportFinishConfigInited;
	}
}
