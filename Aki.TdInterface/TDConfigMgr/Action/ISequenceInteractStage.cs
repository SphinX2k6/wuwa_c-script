using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E02 RID: 7682
	[NullableContext(1)]
	[Nullable(0)]
	public class ISequenceInteractStage
	{
		// Token: 0x0600A459 RID: 42073 RVA: 0x00174C24 File Offset: 0x00172E24
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

		// Token: 0x0600A45A RID: 42074 RVA: 0x00174C5C File Offset: 0x00172E5C
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

		// Token: 0x0600A45B RID: 42075 RVA: 0x00174C6F File Offset: 0x00172E6F
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

		// Token: 0x0600A45C RID: 42076 RVA: 0x00174C82 File Offset: 0x00172E82
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

		// Token: 0x17003280 RID: 12928
		// (get) Token: 0x0600A45D RID: 42077 RVA: 0x00174CB9 File Offset: 0x00172EB9
		// (set) Token: 0x0600A45E RID: 42078 RVA: 0x00174CE0 File Offset: 0x00172EE0
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IInteractEffect> EnterStageEffects
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().EnterStageEffects = value;
			}
		}

		// Token: 0x17003281 RID: 12929
		// (get) Token: 0x0600A45F RID: 42079 RVA: 0x00174CF0 File Offset: 0x00172EF0
		// (set) Token: 0x0600A460 RID: 42080 RVA: 0x00174D83 File Offset: 0x00172F83
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

		// Token: 0x17003282 RID: 12930
		// (get) Token: 0x0600A461 RID: 42081 RVA: 0x00174D98 File Offset: 0x00172F98
		// (set) Token: 0x0600A462 RID: 42082 RVA: 0x00174DBF File Offset: 0x00172FBF
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

		// Token: 0x17003283 RID: 12931
		// (get) Token: 0x0600A463 RID: 42083 RVA: 0x00174DD0 File Offset: 0x00172FD0
		// (set) Token: 0x0600A464 RID: 42084 RVA: 0x00174E0A File Offset: 0x0017300A
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

		// Token: 0x0400626B RID: 25195
		[Nullable(2)]
		protected ISequenceInteractStage FbInstance;

		// Token: 0x0400626C RID: 25196
		[Nullable(2)]
		protected ISequenceInteractStage_SetValue PocoInterface;

		// Token: 0x0400626D RID: 25197
		private List<IInteractPoint> _InteractPointsCache;

		// Token: 0x0400626E RID: 25198
		private bool _InteractPointsInited;
	}
}
