using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021C1 RID: 8641
	public class ITalkOptionVisualNovel : ITalkOptionParamType
	{
		// Token: 0x0600BC5E RID: 48222 RVA: 0x001B42B8 File Offset: 0x001B24B8
		private ITalkOptionVisualNovel_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkOptionVisualNovel 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkOptionVisualNovel_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkOptionVisualNovel_SetValue());
			}
			return result;
		}

		// Token: 0x0600BC5F RID: 48223 RVA: 0x001B42F0 File Offset: 0x001B24F0
		public static ITalkOptionVisualNovel Create([Nullable(2)] ITalkOptionVisualNovel instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOptionVisualNovel
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BC60 RID: 48224 RVA: 0x001B4303 File Offset: 0x001B2503
		public static ITalkOptionVisualNovel CreateFromSetValue([Nullable(2)] ITalkOptionVisualNovel_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkOptionVisualNovel
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BC61 RID: 48225 RVA: 0x001B4316 File Offset: 0x001B2516
		public new ITalkOptionVisualNovel_SetValue ToSetValue()
		{
			return new ITalkOptionVisualNovel_SetValue
			{
				Type = this.Type,
				PlotOptionId = this.PlotOptionId,
				OptionPerformances = this.OptionPerformances,
				DoubleConfirm = this.DoubleConfirm
			};
		}

		// Token: 0x1700399D RID: 14749
		// (get) Token: 0x0600BC62 RID: 48226 RVA: 0x001B434D File Offset: 0x001B254D
		// (set) Token: 0x0600BC63 RID: 48227 RVA: 0x001B4378 File Offset: 0x001B2578
		public override ETalkOptionParamType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETalkOptionParamType.QteSucceed;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700399E RID: 14750
		// (get) Token: 0x0600BC64 RID: 48228 RVA: 0x001B4388 File Offset: 0x001B2588
		// (set) Token: 0x0600BC65 RID: 48229 RVA: 0x001B43C2 File Offset: 0x001B25C2
		public virtual int? PlotOptionId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PlotOptionId;
				}
				ITalkOptionVisualNovel_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PlotOptionId;
			}
			set
			{
				this.GetOrCreatePoco().PlotOptionId = value;
			}
		}

		// Token: 0x1700399F RID: 14751
		// (get) Token: 0x0600BC66 RID: 48230 RVA: 0x001B43D0 File Offset: 0x001B25D0
		// (set) Token: 0x0600BC67 RID: 48231 RVA: 0x001B43F7 File Offset: 0x001B25F7
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IVisualNovelPerformanceBase> OptionPerformances
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
					return this.FbInstance.OptionPerformances;
				}
				ITalkOptionVisualNovel_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.OptionPerformances;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().OptionPerformances = value;
			}
		}

		// Token: 0x170039A0 RID: 14752
		// (get) Token: 0x0600BC68 RID: 48232 RVA: 0x001B4408 File Offset: 0x001B2608
		// (set) Token: 0x0600BC69 RID: 48233 RVA: 0x001B4469 File Offset: 0x001B2669
		[Nullable(2)]
		public virtual ITalkOptionVisualNovelDoubleConfirm DoubleConfirm
		{
			[NullableContext(2)]
			get
			{
				if (this._DoubleConfirmInited)
				{
					return this._DoubleConfirmCache;
				}
				this._DoubleConfirmInited = true;
				if (this.FbInstance != null)
				{
					this._DoubleConfirmCache = ITalkOptionVisualNovelDoubleConfirm.Create(this.FbInstance.DoubleConfirm);
				}
				else
				{
					ITalkOptionVisualNovel_SetValue pocoInterface = this.PocoInterface;
					this._DoubleConfirmCache = ((pocoInterface != null) ? pocoInterface.DoubleConfirm : null);
				}
				return this._DoubleConfirmCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().DoubleConfirm = value;
				this._DoubleConfirmInited = false;
			}
		}

		// Token: 0x0400713E RID: 28990
		[Nullable(2)]
		protected new ITalkOptionVisualNovel FbInstance;

		// Token: 0x0400713F RID: 28991
		[Nullable(2)]
		protected new ITalkOptionVisualNovel_SetValue PocoInterface;

		// Token: 0x04007140 RID: 28992
		private ITalkOptionVisualNovelDoubleConfirm _DoubleConfirmCache;

		// Token: 0x04007141 RID: 28993
		private bool _DoubleConfirmInited;
	}
}
