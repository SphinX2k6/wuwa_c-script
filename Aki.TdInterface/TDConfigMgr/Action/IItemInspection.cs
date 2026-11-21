using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D11 RID: 7441
	public class IItemInspection : IUiGame
	{
		// Token: 0x06009DFD RID: 40445 RVA: 0x0016B86C File Offset: 0x00169A6C
		private IItemInspection_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IItemInspection 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IItemInspection_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IItemInspection_SetValue());
			}
			return result;
		}

		// Token: 0x06009DFE RID: 40446 RVA: 0x0016B8A4 File Offset: 0x00169AA4
		public static IItemInspection Create([Nullable(2)] IItemInspection instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IItemInspection
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009DFF RID: 40447 RVA: 0x0016B8B7 File Offset: 0x00169AB7
		public static IItemInspection CreateFromSetValue([Nullable(2)] IItemInspection_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IItemInspection
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009E00 RID: 40448 RVA: 0x0016B8CC File Offset: 0x00169ACC
		public new IItemInspection_SetValue ToSetValue()
		{
			return new IItemInspection_SetValue
			{
				Type = this.Type,
				PrefabPath = this.PrefabPath,
				RotateSpeed = this.RotateSpeed,
				InteractPointsConfig = this.InteractPointsConfig,
				RangeCheckConfig = this.RangeCheckConfig,
				TextUiConfig = this.TextUiConfig,
				CanExit = this.CanExit,
				ItemOffsetDistance = this.ItemOffsetDistance,
				ItemInteractFinishEffect = this.ItemInteractFinishEffect
			};
		}

		// Token: 0x17003173 RID: 12659
		// (get) Token: 0x06009E01 RID: 40449 RVA: 0x0016B94A File Offset: 0x00169B4A
		// (set) Token: 0x06009E02 RID: 40450 RVA: 0x0016B975 File Offset: 0x00169B75
		public override ESimpleGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESimpleGameplayType.Cipher;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003174 RID: 12660
		// (get) Token: 0x06009E03 RID: 40451 RVA: 0x0016B983 File Offset: 0x00169B83
		// (set) Token: 0x06009E04 RID: 40452 RVA: 0x0016B9AE File Offset: 0x00169BAE
		public virtual string PrefabPath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PrefabPath;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.PrefabPath;
			}
			set
			{
				this.GetOrCreatePoco().PrefabPath = value;
			}
		}

		// Token: 0x17003175 RID: 12661
		// (get) Token: 0x06009E05 RID: 40453 RVA: 0x0016B9BC File Offset: 0x00169BBC
		// (set) Token: 0x06009E06 RID: 40454 RVA: 0x0016B9EB File Offset: 0x00169BEB
		public virtual float RotateSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RotateSpeed;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.RotateSpeed;
			}
			set
			{
				this.GetOrCreatePoco().RotateSpeed = value;
			}
		}

		// Token: 0x17003176 RID: 12662
		// (get) Token: 0x06009E07 RID: 40455 RVA: 0x0016B9FC File Offset: 0x00169BFC
		// (set) Token: 0x06009E08 RID: 40456 RVA: 0x0016BA5D File Offset: 0x00169C5D
		public virtual ISequenceUnlockPoints InteractPointsConfig
		{
			get
			{
				if (this._InteractPointsConfigInited)
				{
					return this._InteractPointsConfigCache;
				}
				this._InteractPointsConfigInited = true;
				if (this.FbInstance != null)
				{
					this._InteractPointsConfigCache = ISequenceUnlockPoints.Create(this.FbInstance.InteractPointsConfig);
				}
				else
				{
					IItemInspection_SetValue pocoInterface = this.PocoInterface;
					this._InteractPointsConfigCache = ((pocoInterface != null) ? pocoInterface.InteractPointsConfig : null);
				}
				return this._InteractPointsConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().InteractPointsConfig = value;
				this._InteractPointsConfigInited = false;
			}
		}

		// Token: 0x17003177 RID: 12663
		// (get) Token: 0x06009E09 RID: 40457 RVA: 0x0016BA74 File Offset: 0x00169C74
		// (set) Token: 0x06009E0A RID: 40458 RVA: 0x0016BAD5 File Offset: 0x00169CD5
		public virtual IConeRangeCheck RangeCheckConfig
		{
			get
			{
				if (this._RangeCheckConfigInited)
				{
					return this._RangeCheckConfigCache;
				}
				this._RangeCheckConfigInited = true;
				if (this.FbInstance != null)
				{
					this._RangeCheckConfigCache = IConeRangeCheck.Create(this.FbInstance.RangeCheckConfig);
				}
				else
				{
					IItemInspection_SetValue pocoInterface = this.PocoInterface;
					this._RangeCheckConfigCache = ((pocoInterface != null) ? pocoInterface.RangeCheckConfig : null);
				}
				return this._RangeCheckConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().RangeCheckConfig = value;
				this._RangeCheckConfigInited = false;
			}
		}

		// Token: 0x17003178 RID: 12664
		// (get) Token: 0x06009E0B RID: 40459 RVA: 0x0016BAEC File Offset: 0x00169CEC
		// (set) Token: 0x06009E0C RID: 40460 RVA: 0x0016BB4D File Offset: 0x00169D4D
		public virtual IAstrologyTextUiConfig TextUiConfig
		{
			get
			{
				if (this._TextUiConfigInited)
				{
					return this._TextUiConfigCache;
				}
				this._TextUiConfigInited = true;
				if (this.FbInstance != null)
				{
					this._TextUiConfigCache = IAstrologyTextUiConfig.Create(this.FbInstance.TextUiConfig);
				}
				else
				{
					IItemInspection_SetValue pocoInterface = this.PocoInterface;
					this._TextUiConfigCache = ((pocoInterface != null) ? pocoInterface.TextUiConfig : null);
				}
				return this._TextUiConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().TextUiConfig = value;
				this._TextUiConfigInited = false;
			}
		}

		// Token: 0x17003179 RID: 12665
		// (get) Token: 0x06009E0D RID: 40461 RVA: 0x0016BB64 File Offset: 0x00169D64
		// (set) Token: 0x06009E0E RID: 40462 RVA: 0x0016BB9E File Offset: 0x00169D9E
		public virtual bool? CanExit
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CanExit;
				}
				IItemInspection_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CanExit;
			}
			set
			{
				this.GetOrCreatePoco().CanExit = value;
			}
		}

		// Token: 0x1700317A RID: 12666
		// (get) Token: 0x06009E0F RID: 40463 RVA: 0x0016BBAC File Offset: 0x00169DAC
		// (set) Token: 0x06009E10 RID: 40464 RVA: 0x0016BBE6 File Offset: 0x00169DE6
		public virtual float? ItemOffsetDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ItemOffsetDistance;
				}
				IItemInspection_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ItemOffsetDistance;
			}
			set
			{
				this.GetOrCreatePoco().ItemOffsetDistance = value;
			}
		}

		// Token: 0x1700317B RID: 12667
		// (get) Token: 0x06009E11 RID: 40465 RVA: 0x0016BBF4 File Offset: 0x00169DF4
		// (set) Token: 0x06009E12 RID: 40466 RVA: 0x0016BC55 File Offset: 0x00169E55
		[Nullable(2)]
		public virtual IItemInspectFinishEffect ItemInteractFinishEffect
		{
			[NullableContext(2)]
			get
			{
				if (this._ItemInteractFinishEffectInited)
				{
					return this._ItemInteractFinishEffectCache;
				}
				this._ItemInteractFinishEffectInited = true;
				if (this.FbInstance != null)
				{
					this._ItemInteractFinishEffectCache = IItemInspectFinishEffect.Create(this.FbInstance.ItemInteractFinishEffect);
				}
				else
				{
					IItemInspection_SetValue pocoInterface = this.PocoInterface;
					this._ItemInteractFinishEffectCache = ((pocoInterface != null) ? pocoInterface.ItemInteractFinishEffect : null);
				}
				return this._ItemInteractFinishEffectCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().ItemInteractFinishEffect = value;
				this._ItemInteractFinishEffectInited = false;
			}
		}

		// Token: 0x04006064 RID: 24676
		[Nullable(2)]
		protected new IItemInspection FbInstance;

		// Token: 0x04006065 RID: 24677
		[Nullable(2)]
		protected new IItemInspection_SetValue PocoInterface;

		// Token: 0x04006066 RID: 24678
		private ISequenceUnlockPoints _InteractPointsConfigCache;

		// Token: 0x04006067 RID: 24679
		private bool _InteractPointsConfigInited;

		// Token: 0x04006068 RID: 24680
		private IConeRangeCheck _RangeCheckConfigCache;

		// Token: 0x04006069 RID: 24681
		private bool _RangeCheckConfigInited;

		// Token: 0x0400606A RID: 24682
		private IAstrologyTextUiConfig _TextUiConfigCache;

		// Token: 0x0400606B RID: 24683
		private bool _TextUiConfigInited;

		// Token: 0x0400606C RID: 24684
		private IItemInspectFinishEffect _ItemInteractFinishEffectCache;

		// Token: 0x0400606D RID: 24685
		private bool _ItemInteractFinishEffectInited;
	}
}
