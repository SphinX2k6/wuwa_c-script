using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003B6 RID: 950
	[NullableContext(1)]
	[Nullable(0)]
	public class IFollowTrackToStart : IFollowTrackEndType
	{
		// Token: 0x060012F3 RID: 4851 RVA: 0x0003DF8C File Offset: 0x0003C18C
		private IFollowTrackToStart_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFollowTrackToStart 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFollowTrackToStart_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFollowTrackToStart_SetValue());
			}
			return result;
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x0003DFC4 File Offset: 0x0003C1C4
		public static IFollowTrackToStart Create([Nullable(2)] IFollowTrackToStart instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFollowTrackToStart
			{
				FbInstance = instance
			};
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x0003DFD7 File Offset: 0x0003C1D7
		public static IFollowTrackToStart CreateFromSetValue([Nullable(2)] IFollowTrackToStart_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFollowTrackToStart
			{
				PocoInterface = value
			};
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x0003DFEA File Offset: 0x0003C1EA
		public new IFollowTrackToStart_SetValue ToSetValue()
		{
			return new IFollowTrackToStart_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x060012F7 RID: 4855 RVA: 0x0003DFFD File Offset: 0x0003C1FD
		// (set) Token: 0x060012F8 RID: 4856 RVA: 0x0003E028 File Offset: 0x0003C228
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

		// Token: 0x04000F25 RID: 3877
		[Nullable(2)]
		protected new IFollowTrackToStart FbInstance;

		// Token: 0x04000F26 RID: 3878
		[Nullable(2)]
		protected new IFollowTrackToStart_SetValue PocoInterface;
	}
}
