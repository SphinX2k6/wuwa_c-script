using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AFF RID: 6911
	[NullableContext(1)]
	[Nullable(0)]
	public class IHideMapMark : ToggleMapMarkState
	{
		// Token: 0x06009400 RID: 37888 RVA: 0x00157098 File Offset: 0x00155298
		private IHideMapMark_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHideMapMark 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHideMapMark_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHideMapMark_SetValue());
			}
			return result;
		}

		// Token: 0x06009401 RID: 37889 RVA: 0x001570D0 File Offset: 0x001552D0
		public static IHideMapMark Create([Nullable(2)] IHideMapMark instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHideMapMark
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009402 RID: 37890 RVA: 0x001570E3 File Offset: 0x001552E3
		public static IHideMapMark CreateFromSetValue([Nullable(2)] IHideMapMark_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHideMapMark
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009403 RID: 37891 RVA: 0x001570F6 File Offset: 0x001552F6
		public new IHideMapMark_SetValue ToSetValue()
		{
			return new IHideMapMark_SetValue
			{
				Type = this.Type,
				MarkId = this.MarkId
			};
		}

		// Token: 0x17002ED7 RID: 11991
		// (get) Token: 0x06009404 RID: 37892 RVA: 0x00157115 File Offset: 0x00155315
		// (set) Token: 0x06009405 RID: 37893 RVA: 0x00157140 File Offset: 0x00155340
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

		// Token: 0x17002ED8 RID: 11992
		// (get) Token: 0x06009406 RID: 37894 RVA: 0x0015714E File Offset: 0x0015534E
		// (set) Token: 0x06009407 RID: 37895 RVA: 0x00157179 File Offset: 0x00155379
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

		// Token: 0x04005AD4 RID: 23252
		[Nullable(2)]
		protected new IHideMapMark FbInstance;

		// Token: 0x04005AD5 RID: 23253
		[Nullable(2)]
		protected new IHideMapMark_SetValue PocoInterface;
	}
}
