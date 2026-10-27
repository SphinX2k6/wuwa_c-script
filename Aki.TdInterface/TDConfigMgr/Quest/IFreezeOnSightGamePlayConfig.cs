using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F9D RID: 3997
	[NullableContext(1)]
	[Nullable(0)]
	public class IFreezeOnSightGamePlayConfig : ISpecialGamePlayConfig
	{
		// Token: 0x06005910 RID: 22800 RVA: 0x000D9270 File Offset: 0x000D7470
		private IFreezeOnSightGamePlayConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFreezeOnSightGamePlayConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFreezeOnSightGamePlayConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFreezeOnSightGamePlayConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06005911 RID: 22801 RVA: 0x000D92A8 File Offset: 0x000D74A8
		public static IFreezeOnSightGamePlayConfig Create([Nullable(2)] IFreezeOnSightGamePlayConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFreezeOnSightGamePlayConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005912 RID: 22802 RVA: 0x000D92BB File Offset: 0x000D74BB
		public static IFreezeOnSightGamePlayConfig CreateFromSetValue([Nullable(2)] IFreezeOnSightGamePlayConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFreezeOnSightGamePlayConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005913 RID: 22803 RVA: 0x000D92CE File Offset: 0x000D74CE
		public new IFreezeOnSightGamePlayConfig_SetValue ToSetValue()
		{
			return new IFreezeOnSightGamePlayConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001D9E RID: 7582
		// (get) Token: 0x06005914 RID: 22804 RVA: 0x000D92E1 File Offset: 0x000D74E1
		// (set) Token: 0x06005915 RID: 22805 RVA: 0x000D930C File Offset: 0x000D750C
		public override ESpecialGamePlayConfigType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESpecialGamePlayConfigType.Stalking;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040035C7 RID: 13767
		[Nullable(2)]
		protected new IFreezeOnSightGamePlayConfig FbInstance;

		// Token: 0x040035C8 RID: 13768
		[Nullable(2)]
		protected new IFreezeOnSightGamePlayConfig_SetValue PocoInterface;
	}
}
