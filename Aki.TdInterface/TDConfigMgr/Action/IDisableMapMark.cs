using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019AE RID: 6574
	[NullableContext(1)]
	[Nullable(0)]
	public class IDisableMapMark : ToggleMapMarkState
	{
		// Token: 0x06008CBD RID: 36029 RVA: 0x0014A1B4 File Offset: 0x001483B4
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

		// Token: 0x06008CBE RID: 36030 RVA: 0x0014A1EC File Offset: 0x001483EC
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

		// Token: 0x06008CBF RID: 36031 RVA: 0x0014A1FF File Offset: 0x001483FF
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

		// Token: 0x06008CC0 RID: 36032 RVA: 0x0014A212 File Offset: 0x00148412
		public new IDisableMapMark_SetValue ToSetValue()
		{
			return new IDisableMapMark_SetValue
			{
				Type = this.Type,
				MarkId = this.MarkId
			};
		}

		// Token: 0x17002D2E RID: 11566
		// (get) Token: 0x06008CC1 RID: 36033 RVA: 0x0014A231 File Offset: 0x00148431
		// (set) Token: 0x06008CC2 RID: 36034 RVA: 0x0014A25C File Offset: 0x0014845C
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

		// Token: 0x17002D2F RID: 11567
		// (get) Token: 0x06008CC3 RID: 36035 RVA: 0x0014A26A File Offset: 0x0014846A
		// (set) Token: 0x06008CC4 RID: 36036 RVA: 0x0014A295 File Offset: 0x00148495
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

		// Token: 0x0400578D RID: 22413
		[Nullable(2)]
		protected new IDisableMapMark FbInstance;

		// Token: 0x0400578E RID: 22414
		[Nullable(2)]
		protected new IDisableMapMark_SetValue PocoInterface;
	}
}
