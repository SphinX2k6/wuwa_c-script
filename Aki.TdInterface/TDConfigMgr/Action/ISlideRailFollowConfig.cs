using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E89 RID: 7817
	[NullableContext(2)]
	[Nullable(0)]
	public class ISlideRailFollowConfig
	{
		// Token: 0x0600A73E RID: 42814 RVA: 0x0017A158 File Offset: 0x00178358
		[NullableContext(1)]
		private ISlideRailFollowConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISlideRailFollowConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISlideRailFollowConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISlideRailFollowConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A73F RID: 42815 RVA: 0x0017A190 File Offset: 0x00178390
		[NullableContext(1)]
		public static ISlideRailFollowConfig Create([Nullable(2)] ISlideRailFollowConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISlideRailFollowConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A740 RID: 42816 RVA: 0x0017A1A3 File Offset: 0x001783A3
		[NullableContext(1)]
		public static ISlideRailFollowConfig CreateFromSetValue([Nullable(2)] ISlideRailFollowConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISlideRailFollowConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A741 RID: 42817 RVA: 0x0017A1B6 File Offset: 0x001783B6
		[NullableContext(1)]
		public ISlideRailFollowConfig_SetValue ToSetValue()
		{
			return new ISlideRailFollowConfig_SetValue
			{
				EntityId = this.EntityId,
				FollowDaPath = this.FollowDaPath
			};
		}

		// Token: 0x17003329 RID: 13097
		// (get) Token: 0x0600A742 RID: 42818 RVA: 0x0017A1D5 File Offset: 0x001783D5
		// (set) Token: 0x0600A743 RID: 42819 RVA: 0x0017A200 File Offset: 0x00178400
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x1700332A RID: 13098
		// (get) Token: 0x0600A744 RID: 42820 RVA: 0x0017A20E File Offset: 0x0017840E
		// (set) Token: 0x0600A745 RID: 42821 RVA: 0x0017A235 File Offset: 0x00178435
		public virtual string FollowDaPath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FollowDaPath;
				}
				ISlideRailFollowConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FollowDaPath;
			}
			set
			{
				this.GetOrCreatePoco().FollowDaPath = value;
			}
		}

		// Token: 0x040063CA RID: 25546
		protected ISlideRailFollowConfig FbInstance;

		// Token: 0x040063CB RID: 25547
		protected ISlideRailFollowConfig_SetValue PocoInterface;
	}
}
