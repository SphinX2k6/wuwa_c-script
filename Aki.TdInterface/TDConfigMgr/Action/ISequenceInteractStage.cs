using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002035 RID: 8245
	public class ISequenceInteractStage
	{
		// Token: 0x0600AF01 RID: 44801 RVA: 0x0018A62C File Offset: 0x0018882C
		private ISequenceInteractStage_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISequenceInteractStage 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISequenceInteractStage_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISequenceInteractStage_SetValue());
			}
			return result;
		}

		// Token: 0x0600AF02 RID: 44802 RVA: 0x0018A664 File Offset: 0x00188864
		public static ISequenceInteractStage Create([Nullable(2)] ISequenceInteractStage instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISequenceInteractStage
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AF03 RID: 44803 RVA: 0x0018A677 File Offset: 0x00188877
		public static ISequenceInteractStage CreateFromSetValue([Nullable(2)] ISequenceInteractStage_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISequenceInteractStage
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AF04 RID: 44804 RVA: 0x0018A68A File Offset: 0x0018888A
		public ISequenceInteractStage_SetValue ToSetValue()
		{
			return new ISequenceInteractStage_SetValue
			{
				EnterStageEffects = this.EnterStageEffects,
				InteractPoints = this.InteractPoints,
				UiTipText = this.UiTipText,
				IsResetAfterStageEnd = this.IsResetAfterStageEnd
			};
		}

		// Token: 0x1700353F RID: 13631
		// (get) Token: 0x0600AF05 RID: 44805 RVA: 0x0018A6C1 File Offset: 0x001888C1
		// (set) Token: 0x0600AF06 RID: 44806 RVA: 0x0018A6E8 File Offset: 0x001888E8
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IInteractEffect> EnterStageEffects
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EnterStageEffects;
				}
				ISequenceInteractStage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EnterStageEffects;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().EnterStageEffects = value;
			}
		}

		// Token: 0x17003540 RID: 13632
		// (get) Token: 0x0600AF07 RID: 44807 RVA: 0x0018A6F8 File Offset: 0x001888F8
		// (set) Token: 0x0600AF08 RID: 44808 RVA: 0x0018A78B File Offset: 0x0018898B
		public virtual List<IInteractPoint> InteractPoints
		{
			get
			{
				if (this._InteractPointsInited)
				{
					return this._InteractPointsCache;
				}
				this._InteractPointsInited = true;
				if (this.FbInstance != null)
				{
					List<IInteractPoint> interactPoints = this.FbInstance.InteractPoints;
					if (interactPoints != null)
					{
						this._InteractPointsCache = new List<IInteractPoint>(interactPoints.Count);
						for (int i = 0; i < interactPoints.Count; i++)
						{
							this._InteractPointsCache.Add(IInteractPoint.Create(interactPoints[i]));
						}
					}
				}
				else
				{
					ISequenceInteractStage_SetValue pocoInterface = this.PocoInterface;
					this._InteractPointsCache = ((pocoInterface != null) ? pocoInterface.InteractPoints : null);
				}
				return this._InteractPointsCache;
			}
			set
			{
				this.GetOrCreatePoco().InteractPoints = value;
				this._InteractPointsInited = false;
			}
		}

		// Token: 0x17003541 RID: 13633
		// (get) Token: 0x0600AF09 RID: 44809 RVA: 0x0018A7A0 File Offset: 0x001889A0
		// (set) Token: 0x0600AF0A RID: 44810 RVA: 0x0018A7C7 File Offset: 0x001889C7
		[Nullable(2)]
		public virtual string UiTipText
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UiTipText;
				}
				ISequenceInteractStage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.UiTipText;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().UiTipText = value;
			}
		}

		// Token: 0x17003542 RID: 13634
		// (get) Token: 0x0600AF0B RID: 44811 RVA: 0x0018A7D8 File Offset: 0x001889D8
		// (set) Token: 0x0600AF0C RID: 44812 RVA: 0x0018A812 File Offset: 0x00188A12
		public virtual bool? IsResetAfterStageEnd
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsResetAfterStageEnd;
				}
				ISequenceInteractStage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsResetAfterStageEnd;
			}
			set
			{
				this.GetOrCreatePoco().IsResetAfterStageEnd = value;
			}
		}

		// Token: 0x04006842 RID: 26690
		[Nullable(2)]
		protected ISequenceInteractStage FbInstance;

		// Token: 0x04006843 RID: 26691
		[Nullable(2)]
		protected ISequenceInteractStage_SetValue PocoInterface;

		// Token: 0x04006844 RID: 26692
		private List<IInteractPoint> _InteractPointsCache;

		// Token: 0x04006845 RID: 26693
		private bool _InteractPointsInited;
	}
}
