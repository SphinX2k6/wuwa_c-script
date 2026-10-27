using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003B0 RID: 944
	[NullableContext(1)]
	[Nullable(0)]
	public class IFollowTrackEndType
	{
		// Token: 0x060012D5 RID: 4821 RVA: 0x0003DC4C File Offset: 0x0003BE4C
		private IFollowTrackEndType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFollowTrackEndType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFollowTrackEndType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFollowTrackEndType_SetValue());
			}
			return result;
		}

		// Token: 0x060012D6 RID: 4822 RVA: 0x0003DC84 File Offset: 0x0003BE84
		public static IFollowTrackEndType Create([Nullable(2)] IFollowTrackEndType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFollowTrackEndType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060012D7 RID: 4823 RVA: 0x0003DC97 File Offset: 0x0003BE97
		public static IFollowTrackEndType CreateFromSetValue([Nullable(2)] IFollowTrackEndType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFollowTrackEndType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x0003DCAA File Offset: 0x0003BEAA
		public IFollowTrackEndType_SetValue ToSetValue()
		{
			return new IFollowTrackEndType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x060012D9 RID: 4825 RVA: 0x0003DCBD File Offset: 0x0003BEBD
		// (set) Token: 0x060012DA RID: 4826 RVA: 0x0003DCE8 File Offset: 0x0003BEE8
		public virtual EFollowTrackEndType Type
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

		// Token: 0x04000F17 RID: 3863
		[Nullable(2)]
		protected IFollowTrackEndType FbInstance;

		// Token: 0x04000F18 RID: 3864
		[Nullable(2)]
		protected IFollowTrackEndType_SetValue PocoInterface;
	}
}
