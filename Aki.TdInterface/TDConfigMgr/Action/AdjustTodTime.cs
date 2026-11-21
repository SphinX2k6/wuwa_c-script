using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020015F8 RID: 5624
	public class AdjustTodTime : ActionParams
	{
		// Token: 0x06007F03 RID: 32515 RVA: 0x0012F19C File Offset: 0x0012D39C
		private AdjustTodTime_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("AdjustTodTime 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			AdjustTodTime_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new AdjustTodTime_SetValue());
			}
			return result;
		}

		// Token: 0x06007F04 RID: 32516 RVA: 0x0012F1D4 File Offset: 0x0012D3D4
		public static AdjustTodTime Create([Nullable(2)] AdjustTodTime instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AdjustTodTime
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007F05 RID: 32517 RVA: 0x0012F1E7 File Offset: 0x0012D3E7
		public static AdjustTodTime CreateFromSetValue([Nullable(2)] AdjustTodTime_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new AdjustTodTime
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007F06 RID: 32518 RVA: 0x0012F1FA File Offset: 0x0012D3FA
		public AdjustTodTime_SetValue ToSetValue()
		{
			return new AdjustTodTime_SetValue
			{
				Hour = this.Hour,
				Min = this.Min,
				ShowUi = this.ShowUi
			};
		}

		// Token: 0x17002A4C RID: 10828
		// (get) Token: 0x06007F07 RID: 32519 RVA: 0x0012F225 File Offset: 0x0012D425
		// (set) Token: 0x06007F08 RID: 32520 RVA: 0x0012F250 File Offset: 0x0012D450
		public virtual int Hour
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Hour;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Hour;
			}
			set
			{
				this.GetOrCreatePoco().Hour = value;
			}
		}

		// Token: 0x17002A4D RID: 10829
		// (get) Token: 0x06007F09 RID: 32521 RVA: 0x0012F25E File Offset: 0x0012D45E
		// (set) Token: 0x06007F0A RID: 32522 RVA: 0x0012F289 File Offset: 0x0012D489
		public virtual int Min
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Min;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Min;
			}
			set
			{
				this.GetOrCreatePoco().Min = value;
			}
		}

		// Token: 0x17002A4E RID: 10830
		// (get) Token: 0x06007F0B RID: 32523 RVA: 0x0012F297 File Offset: 0x0012D497
		// (set) Token: 0x06007F0C RID: 32524 RVA: 0x0012F2C2 File Offset: 0x0012D4C2
		public virtual bool ShowUi
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ShowUi;
				}
				return this.PocoInterface != null && this.PocoInterface.ShowUi;
			}
			set
			{
				this.GetOrCreatePoco().ShowUi = value;
			}
		}

		// Token: 0x0400497D RID: 18813
		[Nullable(2)]
		protected new AdjustTodTime FbInstance;

		// Token: 0x0400497E RID: 18814
		[Nullable(2)]
		protected AdjustTodTime_SetValue PocoInterface;
	}
}
