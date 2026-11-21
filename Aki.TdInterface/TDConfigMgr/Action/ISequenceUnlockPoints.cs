using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002037 RID: 8247
	public class ISequenceUnlockPoints : IInteractPointConfig
	{
		// Token: 0x0600AF0F RID: 44815 RVA: 0x0018A830 File Offset: 0x00188A30
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

		// Token: 0x0600AF10 RID: 44816 RVA: 0x0018A868 File Offset: 0x00188A68
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

		// Token: 0x0600AF11 RID: 44817 RVA: 0x0018A87B File Offset: 0x00188A7B
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

		// Token: 0x0600AF12 RID: 44818 RVA: 0x0018A88E File Offset: 0x00188A8E
		public new ISequenceUnlockPoints_SetValue ToSetValue()
		{
			return new ISequenceUnlockPoints_SetValue
			{
				Type = this.Type,
				Stages = this.Stages
			};
		}

		// Token: 0x17003543 RID: 13635
		// (get) Token: 0x0600AF13 RID: 44819 RVA: 0x0018A8AD File Offset: 0x00188AAD
		// (set) Token: 0x0600AF14 RID: 44820 RVA: 0x0018A8D8 File Offset: 0x00188AD8
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

		// Token: 0x17003544 RID: 13636
		// (get) Token: 0x0600AF15 RID: 44821 RVA: 0x0018A8E8 File Offset: 0x00188AE8
		// (set) Token: 0x0600AF16 RID: 44822 RVA: 0x0018A97B File Offset: 0x00188B7B
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

		// Token: 0x0400684A RID: 26698
		[Nullable(2)]
		protected new ISequenceUnlockPoints FbInstance;

		// Token: 0x0400684B RID: 26699
		[Nullable(2)]
		protected new ISequenceUnlockPoints_SetValue PocoInterface;

		// Token: 0x0400684C RID: 26700
		private List<ISequenceInteractStage> _StagesCache;

		// Token: 0x0400684D RID: 26701
		private bool _StagesInited;
	}
}
