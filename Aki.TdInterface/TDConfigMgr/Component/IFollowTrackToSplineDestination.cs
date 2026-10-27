using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003B4 RID: 948
	[NullableContext(1)]
	[Nullable(0)]
	public class IFollowTrackToSplineDestination : IFollowTrackEndType
	{
		// Token: 0x060012E9 RID: 4841 RVA: 0x0003DE8C File Offset: 0x0003C08C
		private IFollowTrackToSplineDestination_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFollowTrackToSplineDestination 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFollowTrackToSplineDestination_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFollowTrackToSplineDestination_SetValue());
			}
			return result;
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x0003DEC4 File Offset: 0x0003C0C4
		public static IFollowTrackToSplineDestination Create([Nullable(2)] IFollowTrackToSplineDestination instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFollowTrackToSplineDestination
			{
				FbInstance = instance
			};
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x0003DED7 File Offset: 0x0003C0D7
		public static IFollowTrackToSplineDestination CreateFromSetValue([Nullable(2)] IFollowTrackToSplineDestination_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFollowTrackToSplineDestination
			{
				PocoInterface = value
			};
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x0003DEEA File Offset: 0x0003C0EA
		public new IFollowTrackToSplineDestination_SetValue ToSetValue()
		{
			return new IFollowTrackToSplineDestination_SetValue
			{
				Type = this.Type,
				ChangeSelfState = this.ChangeSelfState
			};
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x060012ED RID: 4845 RVA: 0x0003DF09 File Offset: 0x0003C109
		// (set) Token: 0x060012EE RID: 4846 RVA: 0x0003DF34 File Offset: 0x0003C134
		public override EFollowTrackEndType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFollowTrackEndType.ToStart;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x060012EF RID: 4847 RVA: 0x0003DF42 File Offset: 0x0003C142
		// (set) Token: 0x060012F0 RID: 4848 RVA: 0x0003DF6D File Offset: 0x0003C16D
		public virtual string ChangeSelfState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ChangeSelfState;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ChangeSelfState;
			}
			set
			{
				this.GetOrCreatePoco().ChangeSelfState = value;
			}
		}

		// Token: 0x04000F21 RID: 3873
		[Nullable(2)]
		protected new IFollowTrackToSplineDestination FbInstance;

		// Token: 0x04000F22 RID: 3874
		[Nullable(2)]
		protected new IFollowTrackToSplineDestination_SetValue PocoInterface;
	}
}
