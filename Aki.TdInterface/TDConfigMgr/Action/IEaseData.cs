using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B59 RID: 7001
	[JsonConverter(typeof(IEaseDataConverter))]
	public class IEaseData
	{
		// Token: 0x060094B3 RID: 38067 RVA: 0x0015B128 File Offset: 0x00159328
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

		// Token: 0x060094B4 RID: 38068 RVA: 0x0015B160 File Offset: 0x00159360
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

		// Token: 0x060094B5 RID: 38069 RVA: 0x0015B173 File Offset: 0x00159373
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

		// Token: 0x060094B6 RID: 38070 RVA: 0x0015B186 File Offset: 0x00159386
		public IEaseData_SetValue ToSetValue()
		{
			return new IEaseData_SetValue
			{
				Type = this.Type,
				Duration = this.Duration
			};
		}

		// Token: 0x17002F60 RID: 12128
		// (get) Token: 0x060094B7 RID: 38071 RVA: 0x0015B1A5 File Offset: 0x001593A5
		// (set) Token: 0x060094B8 RID: 38072 RVA: 0x0015B1D0 File Offset: 0x001593D0
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

		// Token: 0x17002F61 RID: 12129
		// (get) Token: 0x060094B9 RID: 38073 RVA: 0x0015B1DE File Offset: 0x001593DE
		// (set) Token: 0x060094BA RID: 38074 RVA: 0x0015B20D File Offset: 0x0015940D
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

		// Token: 0x04005C31 RID: 23601
		[Nullable(2)]
		protected IEaseData FbInstance;

		// Token: 0x04005C32 RID: 23602
		[Nullable(2)]
		protected IEaseData_SetValue PocoInterface;
	}
}
