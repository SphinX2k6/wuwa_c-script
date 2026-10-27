using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B2D RID: 6957
	[NullableContext(1)]
	[Nullable(0)]
	public class IInfrActivityRoadProcess : IInfrActivityBuildStageOption
	{
		// Token: 0x060094E8 RID: 38120 RVA: 0x001587E8 File Offset: 0x001569E8
		private IInfrActivityRoadProcess_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInfrActivityRoadProcess 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInfrActivityRoadProcess_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInfrActivityRoadProcess_SetValue());
			}
			return result;
		}

		// Token: 0x060094E9 RID: 38121 RVA: 0x00158820 File Offset: 0x00156A20
		public static IInfrActivityRoadProcess Create([Nullable(2)] IInfrActivityRoadProcess instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInfrActivityRoadProcess
			{
				FbInstance = instance
			};
		}

		// Token: 0x060094EA RID: 38122 RVA: 0x00158833 File Offset: 0x00156A33
		public static IInfrActivityRoadProcess CreateFromSetValue([Nullable(2)] IInfrActivityRoadProcess_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInfrActivityRoadProcess
			{
				PocoInterface = value
			};
		}

		// Token: 0x060094EB RID: 38123 RVA: 0x00158846 File Offset: 0x00156A46
		public new IInfrActivityRoadProcess_SetValue ToSetValue()
		{
			return new IInfrActivityRoadProcess_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x17002F06 RID: 12038
		// (get) Token: 0x060094EC RID: 38124 RVA: 0x00158865 File Offset: 0x00156A65
		// (set) Token: 0x060094ED RID: 38125 RVA: 0x00158890 File Offset: 0x00156A90
		public override EInfrActivityBuildStageType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInfrActivityBuildStageType.Infrastructure;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002F07 RID: 12039
		// (get) Token: 0x060094EE RID: 38126 RVA: 0x0015889E File Offset: 0x00156A9E
		// (set) Token: 0x060094EF RID: 38127 RVA: 0x001588C9 File Offset: 0x00156AC9
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x04005B31 RID: 23345
		[Nullable(2)]
		protected new IInfrActivityRoadProcess FbInstance;

		// Token: 0x04005B32 RID: 23346
		[Nullable(2)]
		protected new IInfrActivityRoadProcess_SetValue PocoInterface;
	}
}
