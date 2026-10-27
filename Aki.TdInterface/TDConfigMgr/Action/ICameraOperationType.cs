using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200184A RID: 6218
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(ICameraOperationTypeConverter))]
	public class ICameraOperationType
	{
		// Token: 0x06008591 RID: 34193 RVA: 0x0013DA88 File Offset: 0x0013BC88
		private ICameraOperationType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICameraOperationType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICameraOperationType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICameraOperationType_SetValue());
			}
			return result;
		}

		// Token: 0x06008592 RID: 34194 RVA: 0x0013DAC0 File Offset: 0x0013BCC0
		public static ICameraOperationType Create([Nullable(2)] ICameraOperationType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICameraOperationType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008593 RID: 34195 RVA: 0x0013DAD3 File Offset: 0x0013BCD3
		public static ICameraOperationType CreateFromSetValue([Nullable(2)] ICameraOperationType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICameraOperationType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008594 RID: 34196 RVA: 0x0013DAE6 File Offset: 0x0013BCE6
		public ICameraOperationType_SetValue ToSetValue()
		{
			return new ICameraOperationType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002BAE RID: 11182
		// (get) Token: 0x06008595 RID: 34197 RVA: 0x0013DAF9 File Offset: 0x0013BCF9
		// (set) Token: 0x06008596 RID: 34198 RVA: 0x0013DB24 File Offset: 0x0013BD24
		public virtual ECameraOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECameraOperationType.Enable;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400545B RID: 21595
		[Nullable(2)]
		protected ICameraOperationType FbInstance;

		// Token: 0x0400545C RID: 21596
		[Nullable(2)]
		protected ICameraOperationType_SetValue PocoInterface;
	}
}
