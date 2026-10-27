using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E04 RID: 7684
	[NullableContext(1)]
	[Nullable(0)]
	public class ISequenceUnlockPoints : IInteractPointConfig
	{
		// Token: 0x0600A467 RID: 42087 RVA: 0x00174E28 File Offset: 0x00173028
		private ISequenceUnlockPoints_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISequenceUnlockPoints 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISequenceUnlockPoints_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISequenceUnlockPoints_SetValue());
			}
			return result;
		}

		// Token: 0x0600A468 RID: 42088 RVA: 0x00174E60 File Offset: 0x00173060
		public static ISequenceUnlockPoints Create([Nullable(2)] ISequenceUnlockPoints instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISequenceUnlockPoints
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A469 RID: 42089 RVA: 0x00174E73 File Offset: 0x00173073
		public static ISequenceUnlockPoints CreateFromSetValue([Nullable(2)] ISequenceUnlockPoints_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISequenceUnlockPoints
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A46A RID: 42090 RVA: 0x00174E86 File Offset: 0x00173086
		public new ISequenceUnlockPoints_SetValue ToSetValue()
		{
			return new ISequenceUnlockPoints_SetValue
			{
				Type = this.Type,
				Stages = this.Stages
			};
		}

		// Token: 0x17003284 RID: 12932
		// (get) Token: 0x0600A46B RID: 42091 RVA: 0x00174EA5 File Offset: 0x001730A5
		// (set) Token: 0x0600A46C RID: 42092 RVA: 0x00174ED0 File Offset: 0x001730D0
		public override EInteractUnlockType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInteractUnlockType.Sequence;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003285 RID: 12933
		// (get) Token: 0x0600A46D RID: 42093 RVA: 0x00174EE0 File Offset: 0x001730E0
		// (set) Token: 0x0600A46E RID: 42094 RVA: 0x00174F73 File Offset: 0x00173173
		public virtual List<ISequenceInteractStage> Stages
		{
			get
			{
				if (this._StagesInited)
				{
					return this._StagesCache;
				}
				this._StagesInited = true;
				if (this.FbInstance != null)
				{
					List<ISequenceInteractStage> stages = this.FbInstance.Stages;
					if (stages != null)
					{
						this._StagesCache = new List<ISequenceInteractStage>(stages.Count);
						for (int i = 0; i < stages.Count; i++)
						{
							this._StagesCache.Add(ISequenceInteractStage.Create(stages[i]));
						}
					}
				}
				else
				{
					ISequenceUnlockPoints_SetValue pocoInterface = this.PocoInterface;
					this._StagesCache = ((pocoInterface != null) ? pocoInterface.Stages : null);
				}
				return this._StagesCache;
			}
			set
			{
				this.GetOrCreatePoco().Stages = value;
				this._StagesInited = false;
			}
		}

		// Token: 0x04006273 RID: 25203
		[Nullable(2)]
		protected new ISequenceUnlockPoints FbInstance;

		// Token: 0x04006274 RID: 25204
		[Nullable(2)]
		protected new ISequenceUnlockPoints_SetValue PocoInterface;

		// Token: 0x04006275 RID: 25205
		private List<ISequenceInteractStage> _StagesCache;

		// Token: 0x04006276 RID: 25206
		private bool _StagesInited;
	}
}
