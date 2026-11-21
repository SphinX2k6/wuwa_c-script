using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B37 RID: 6967
	public class IDisableMapMark : ToggleMapMarkState
	{
		// Token: 0x060093ED RID: 37869 RVA: 0x00159B04 File Offset: 0x00157D04
		private IDisableMapMark_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDisableMapMark 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDisableMapMark_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDisableMapMark_SetValue());
			}
			return result;
		}

		// Token: 0x060093EE RID: 37870 RVA: 0x00159B3C File Offset: 0x00157D3C
		public static IDisableMapMark Create([Nullable(2)] IDisableMapMark instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableMapMark
			{
				FbInstance = instance
			};
		}

		// Token: 0x060093EF RID: 37871 RVA: 0x00159B4F File Offset: 0x00157D4F
		public static IDisableMapMark CreateFromSetValue([Nullable(2)] IDisableMapMark_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDisableMapMark
			{
				PocoInterface = value
			};
		}

		// Token: 0x060093F0 RID: 37872 RVA: 0x00159B62 File Offset: 0x00157D62
		public new IDisableMapMark_SetValue ToSetValue()
		{
			return new IDisableMapMark_SetValue
			{
				Type = this.Type,
				MarkId = this.MarkId
			};
		}

		// Token: 0x17002F30 RID: 12080
		// (get) Token: 0x060093F1 RID: 37873 RVA: 0x00159B81 File Offset: 0x00157D81
		// (set) Token: 0x060093F2 RID: 37874 RVA: 0x00159BAC File Offset: 0x00157DAC
		public override EMapMarkState Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMapMarkState.Show;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002F31 RID: 12081
		// (get) Token: 0x060093F3 RID: 37875 RVA: 0x00159BBA File Offset: 0x00157DBA
		// (set) Token: 0x060093F4 RID: 37876 RVA: 0x00159BE5 File Offset: 0x00157DE5
		public virtual int MarkId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MarkId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MarkId;
			}
			set
			{
				this.GetOrCreatePoco().MarkId = value;
			}
		}

		// Token: 0x04005BDB RID: 23515
		[Nullable(2)]
		protected new IDisableMapMark FbInstance;

		// Token: 0x04005BDC RID: 23516
		[Nullable(2)]
		protected new IDisableMapMark_SetValue PocoInterface;
	}
}
