using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B2A RID: 11050
	public class IItemInspection : IUiGame
	{
		// Token: 0x0600F311 RID: 62225 RVA: 0x00237CE2 File Offset: 0x00235EE2
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

		// Token: 0x1700496B RID: 18795
		// (get) Token: 0x0600F312 RID: 62226 RVA: 0x00237D01 File Offset: 0x00235F01
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x1700496C RID: 18796
		// (get) Token: 0x0600F313 RID: 62227 RVA: 0x00237D0E File Offset: 0x00235F0E
		public virtual string PrefabPath
		{
			get
			{
				return this.Instance.PrefabPath;
			}
		}

		// Token: 0x1700496D RID: 18797
		// (get) Token: 0x0600F314 RID: 62228 RVA: 0x00237D1B File Offset: 0x00235F1B
		public virtual float RotateSpeed
		{
			get
			{
				return this.Instance.RotateSpeed;
			}
		}

		// Token: 0x1700496E RID: 18798
		// (get) Token: 0x0600F315 RID: 62229 RVA: 0x00237D28 File Offset: 0x00235F28
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

		// Token: 0x1700496F RID: 18799
		// (get) Token: 0x0600F316 RID: 62230 RVA: 0x00237D5C File Offset: 0x00235F5C
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

		// Token: 0x17004970 RID: 18800
		// (get) Token: 0x0600F317 RID: 62231 RVA: 0x00237D90 File Offset: 0x00235F90
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

		// Token: 0x17004971 RID: 18801
		// (get) Token: 0x0600F318 RID: 62232 RVA: 0x00237DC4 File Offset: 0x00235FC4
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

		// Token: 0x17004972 RID: 18802
		// (get) Token: 0x0600F319 RID: 62233 RVA: 0x00237DFC File Offset: 0x00235FFC
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

		// Token: 0x17004973 RID: 18803
		// (get) Token: 0x0600F31A RID: 62234 RVA: 0x00237E32 File Offset: 0x00236032
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

		// Token: 0x04008560 RID: 34144
		private IItemInspection Instance;

		// Token: 0x04008561 RID: 34145
		[Nullable(2)]
		private ISequenceUnlockPoints _InteractPointsConfigCache;

		// Token: 0x04008562 RID: 34146
		private bool _InteractPointsConfigInited;

		// Token: 0x04008563 RID: 34147
		[Nullable(2)]
		private IConeRangeCheck _RangeCheckConfigCache;

		// Token: 0x04008564 RID: 34148
		private bool _RangeCheckConfigInited;

		// Token: 0x04008565 RID: 34149
		[Nullable(2)]
		private IAstrologyTextUiConfig _TextUiConfigCache;

		// Token: 0x04008566 RID: 34150
		private bool _TextUiConfigInited;

		// Token: 0x04008567 RID: 34151
		[Nullable(2)]
		private IItemInspectFinishEffect _ItemInteractFinishEffectCache;

		// Token: 0x04008568 RID: 34152
		private bool _ItemInteractFinishEffectInited;
	}
}
