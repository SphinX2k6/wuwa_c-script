using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002857 RID: 10327
	[NullableContext(1)]
	[Nullable(0)]
	public class IItemInspection : IUiGame
	{
		// Token: 0x0600E4EC RID: 58604 RVA: 0x0021AE7E File Offset: 0x0021907E
		public static IItemInspection Create(IItemInspection? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IItemInspection
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004600 RID: 17920
		// (get) Token: 0x0600E4ED RID: 58605 RVA: 0x0021AE9D File Offset: 0x0021909D
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x17004601 RID: 17921
		// (get) Token: 0x0600E4EE RID: 58606 RVA: 0x0021AEAA File Offset: 0x002190AA
		public virtual string PrefabPath
		{
			get
			{
				return this.Instance.PrefabPath;
			}
		}

		// Token: 0x17004602 RID: 17922
		// (get) Token: 0x0600E4EF RID: 58607 RVA: 0x0021AEB7 File Offset: 0x002190B7
		public virtual float RotateSpeed
		{
			get
			{
				return this.Instance.RotateSpeed;
			}
		}

		// Token: 0x17004603 RID: 17923
		// (get) Token: 0x0600E4F0 RID: 58608 RVA: 0x0021AEC4 File Offset: 0x002190C4
		public virtual ISequenceUnlockPoints InteractPointsConfig
		{
			get
			{
				if (this._InteractPointsConfigInited)
				{
					return this._InteractPointsConfigCache;
				}
				this._InteractPointsConfigInited = true;
				this._InteractPointsConfigCache = ISequenceUnlockPoints.Create(this.Instance.InteractPointsConfig);
				return this._InteractPointsConfigCache;
			}
		}

		// Token: 0x17004604 RID: 17924
		// (get) Token: 0x0600E4F1 RID: 58609 RVA: 0x0021AEF8 File Offset: 0x002190F8
		public virtual IConeRangeCheck RangeCheckConfig
		{
			get
			{
				if (this._RangeCheckConfigInited)
				{
					return this._RangeCheckConfigCache;
				}
				this._RangeCheckConfigInited = true;
				this._RangeCheckConfigCache = IConeRangeCheck.Create(this.Instance.RangeCheckConfig);
				return this._RangeCheckConfigCache;
			}
		}

		// Token: 0x17004605 RID: 17925
		// (get) Token: 0x0600E4F2 RID: 58610 RVA: 0x0021AF2C File Offset: 0x0021912C
		public virtual IAstrologyTextUiConfig TextUiConfig
		{
			get
			{
				if (this._TextUiConfigInited)
				{
					return this._TextUiConfigCache;
				}
				this._TextUiConfigInited = true;
				this._TextUiConfigCache = IAstrologyTextUiConfig.Create(this.Instance.TextUiConfig);
				return this._TextUiConfigCache;
			}
		}

		// Token: 0x17004606 RID: 17926
		// (get) Token: 0x0600E4F3 RID: 58611 RVA: 0x0021AF60 File Offset: 0x00219160
		public virtual bool? CanExit
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.CanExit);
			}
		}

		// Token: 0x17004607 RID: 17927
		// (get) Token: 0x0600E4F4 RID: 58612 RVA: 0x0021AF98 File Offset: 0x00219198
		public virtual float? ItemOffsetDistance
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new float?(this.Instance.ItemOffsetDistance);
			}
		}

		// Token: 0x17004608 RID: 17928
		// (get) Token: 0x0600E4F5 RID: 58613 RVA: 0x0021AFCE File Offset: 0x002191CE
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
				this._ItemInteractFinishEffectCache = IItemInspectFinishEffect.Create(this.Instance.ItemInteractFinishEffect);
				return this._ItemInteractFinishEffectCache;
			}
		}

		// Token: 0x04007EA3 RID: 32419
		private IItemInspection Instance;

		// Token: 0x04007EA4 RID: 32420
		[Nullable(2)]
		private ISequenceUnlockPoints _InteractPointsConfigCache;

		// Token: 0x04007EA5 RID: 32421
		private bool _InteractPointsConfigInited;

		// Token: 0x04007EA6 RID: 32422
		[Nullable(2)]
		private IConeRangeCheck _RangeCheckConfigCache;

		// Token: 0x04007EA7 RID: 32423
		private bool _RangeCheckConfigInited;

		// Token: 0x04007EA8 RID: 32424
		[Nullable(2)]
		private IAstrologyTextUiConfig _TextUiConfigCache;

		// Token: 0x04007EA9 RID: 32425
		private bool _TextUiConfigInited;

		// Token: 0x04007EAA RID: 32426
		[Nullable(2)]
		private IItemInspectFinishEffect _ItemInteractFinishEffectCache;

		// Token: 0x04007EAB RID: 32427
		private bool _ItemInteractFinishEffectInited;
	}
}
