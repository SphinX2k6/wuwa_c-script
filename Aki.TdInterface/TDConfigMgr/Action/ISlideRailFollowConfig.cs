using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020BE RID: 8382
	public class ISlideRailFollowConfig
	{
		// Token: 0x0600B1F6 RID: 45558 RVA: 0x0018FE58 File Offset: 0x0018E058
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

		// Token: 0x0600B1F7 RID: 45559 RVA: 0x0018FE90 File Offset: 0x0018E090
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

		// Token: 0x0600B1F8 RID: 45560 RVA: 0x0018FEA3 File Offset: 0x0018E0A3
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

		// Token: 0x0600B1F9 RID: 45561 RVA: 0x0018FEB6 File Offset: 0x0018E0B6
		public ISlideRailFollowConfig_SetValue ToSetValue()
		{
			return new ISlideRailFollowConfig_SetValue
			{
				EntityId = this.EntityId,
				FollowDaPath = this.FollowDaPath
			};
		}

		// Token: 0x170035ED RID: 13805
		// (get) Token: 0x0600B1FA RID: 45562 RVA: 0x0018FED5 File Offset: 0x0018E0D5
		// (set) Token: 0x0600B1FB RID: 45563 RVA: 0x0018FF00 File Offset: 0x0018E100
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

		// Token: 0x170035EE RID: 13806
		// (get) Token: 0x0600B1FC RID: 45564 RVA: 0x0018FF0E File Offset: 0x0018E10E
		// (set) Token: 0x0600B1FD RID: 45565 RVA: 0x0018FF35 File Offset: 0x0018E135
		[Nullable(2)]
		public virtual string FollowDaPath
		{
			[NullableContext(2)]
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
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().FollowDaPath = value;
			}
		}

		// Token: 0x040069AE RID: 27054
		[Nullable(2)]
		protected ISlideRailFollowConfig FbInstance;

		// Token: 0x040069AF RID: 27055
		[Nullable(2)]
		protected ISlideRailFollowConfig_SetValue PocoInterface;
	}
}
