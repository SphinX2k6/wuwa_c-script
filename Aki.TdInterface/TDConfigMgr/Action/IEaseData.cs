using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019CC RID: 6604
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(IEaseDataConverter))]
	public class IEaseData
	{
		// Token: 0x06008D71 RID: 36209 RVA: 0x0014B61C File Offset: 0x0014981C
		private IEaseData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEaseData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEaseData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEaseData_SetValue());
			}
			return result;
		}

		// Token: 0x06008D72 RID: 36210 RVA: 0x0014B654 File Offset: 0x00149854
		public static IEaseData Create([Nullable(2)] IEaseData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEaseData
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008D73 RID: 36211 RVA: 0x0014B667 File Offset: 0x00149867
		public static IEaseData CreateFromSetValue([Nullable(2)] IEaseData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEaseData
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008D74 RID: 36212 RVA: 0x0014B67A File Offset: 0x0014987A
		public IEaseData_SetValue ToSetValue()
		{
			return new IEaseData_SetValue
			{
				Type = this.Type,
				Duration = this.Duration
			};
		}

		// Token: 0x17002D5B RID: 11611
		// (get) Token: 0x06008D75 RID: 36213 RVA: 0x0014B699 File Offset: 0x00149899
		// (set) Token: 0x06008D76 RID: 36214 RVA: 0x0014B6C4 File Offset: 0x001498C4
		public virtual EEaseType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEaseType.Linear;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002D5C RID: 11612
		// (get) Token: 0x06008D77 RID: 36215 RVA: 0x0014B6D2 File Offset: 0x001498D2
		// (set) Token: 0x06008D78 RID: 36216 RVA: 0x0014B701 File Offset: 0x00149901
		public virtual float Duration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Duration;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Duration;
			}
			set
			{
				this.GetOrCreatePoco().Duration = value;
			}
		}

		// Token: 0x040057DC RID: 22492
		[Nullable(2)]
		protected IEaseData FbInstance;

		// Token: 0x040057DD RID: 22493
		[Nullable(2)]
		protected IEaseData_SetValue PocoInterface;
	}
}
