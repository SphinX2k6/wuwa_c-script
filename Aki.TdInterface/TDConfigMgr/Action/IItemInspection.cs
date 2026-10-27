using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B64 RID: 7012
	[NullableContext(1)]
	[Nullable(0)]
	public class IItemInspection : IUiGame
	{
		// Token: 0x0600961B RID: 38427 RVA: 0x0015ACC0 File Offset: 0x00158EC0
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

		// Token: 0x0600961C RID: 38428 RVA: 0x0015ACF8 File Offset: 0x00158EF8
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

		// Token: 0x0600961D RID: 38429 RVA: 0x0015AD0B File Offset: 0x00158F0B
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

		// Token: 0x0600961E RID: 38430 RVA: 0x0015AD20 File Offset: 0x00158F20
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

		// Token: 0x17002F4E RID: 12110
		// (get) Token: 0x0600961F RID: 38431 RVA: 0x0015AD9E File Offset: 0x00158F9E
		// (set) Token: 0x06009620 RID: 38432 RVA: 0x0015ADC9 File Offset: 0x00158FC9
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

		// Token: 0x17002F4F RID: 12111
		// (get) Token: 0x06009621 RID: 38433 RVA: 0x0015ADD7 File Offset: 0x00158FD7
		// (set) Token: 0x06009622 RID: 38434 RVA: 0x0015AE02 File Offset: 0x00159002
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

		// Token: 0x17002F50 RID: 12112
		// (get) Token: 0x06009623 RID: 38435 RVA: 0x0015AE10 File Offset: 0x00159010
		// (set) Token: 0x06009624 RID: 38436 RVA: 0x0015AE3F File Offset: 0x0015903F
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

		// Token: 0x17002F51 RID: 12113
		// (get) Token: 0x06009625 RID: 38437 RVA: 0x0015AE50 File Offset: 0x00159050
		// (set) Token: 0x06009626 RID: 38438 RVA: 0x0015AEB1 File Offset: 0x001590B1
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

		// Token: 0x17002F52 RID: 12114
		// (get) Token: 0x06009627 RID: 38439 RVA: 0x0015AEC8 File Offset: 0x001590C8
		// (set) Token: 0x06009628 RID: 38440 RVA: 0x0015AF29 File Offset: 0x00159129
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

		// Token: 0x17002F53 RID: 12115
		// (get) Token: 0x06009629 RID: 38441 RVA: 0x0015AF40 File Offset: 0x00159140
		// (set) Token: 0x0600962A RID: 38442 RVA: 0x0015AFA1 File Offset: 0x001591A1
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

		// Token: 0x17002F54 RID: 12116
		// (get) Token: 0x0600962B RID: 38443 RVA: 0x0015AFB8 File Offset: 0x001591B8
		// (set) Token: 0x0600962C RID: 38444 RVA: 0x0015AFF2 File Offset: 0x001591F2
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

		// Token: 0x17002F55 RID: 12117
		// (get) Token: 0x0600962D RID: 38445 RVA: 0x0015B000 File Offset: 0x00159200
		// (set) Token: 0x0600962E RID: 38446 RVA: 0x0015B03A File Offset: 0x0015923A
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

		// Token: 0x17002F56 RID: 12118
		// (get) Token: 0x0600962F RID: 38447 RVA: 0x0015B048 File Offset: 0x00159248
		// (set) Token: 0x06009630 RID: 38448 RVA: 0x0015B0A9 File Offset: 0x001592A9
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

		// Token: 0x04005BCB RID: 23499
		[Nullable(2)]
		protected new IItemInspection FbInstance;

		// Token: 0x04005BCC RID: 23500
		[Nullable(2)]
		protected new IItemInspection_SetValue PocoInterface;

		// Token: 0x04005BCD RID: 23501
		private ISequenceUnlockPoints _InteractPointsConfigCache;

		// Token: 0x04005BCE RID: 23502
		private bool _InteractPointsConfigInited;

		// Token: 0x04005BCF RID: 23503
		private IConeRangeCheck _RangeCheckConfigCache;

		// Token: 0x04005BD0 RID: 23504
		private bool _RangeCheckConfigInited;

		// Token: 0x04005BD1 RID: 23505
		private IAstrologyTextUiConfig _TextUiConfigCache;

		// Token: 0x04005BD2 RID: 23506
		private bool _TextUiConfigInited;

		// Token: 0x04005BD3 RID: 23507
		private IItemInspectFinishEffect _ItemInteractFinishEffectCache;

		// Token: 0x04005BD4 RID: 23508
		private bool _ItemInteractFinishEffectInited;
	}
}
