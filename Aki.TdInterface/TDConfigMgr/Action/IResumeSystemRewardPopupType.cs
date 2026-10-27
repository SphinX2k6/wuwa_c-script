using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DBA RID: 7610
	[NullableContext(1)]
	[Nullable(0)]
	public class IResumeSystemRewardPopupType
	{
		// Token: 0x0600A303 RID: 41731 RVA: 0x00172658 File Offset: 0x00170858
		private IResumeSystemRewardPopupType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IResumeSystemRewardPopupType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IResumeSystemRewardPopupType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IResumeSystemRewardPopupType_SetValue());
			}
			return result;
		}

		// Token: 0x0600A304 RID: 41732 RVA: 0x00172690 File Offset: 0x00170890
		public static IResumeSystemRewardPopupType Create([Nullable(2)] IResumeSystemRewardPopupType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IResumeSystemRewardPopupType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A305 RID: 41733 RVA: 0x001726A3 File Offset: 0x001708A3
		public static IResumeSystemRewardPopupType CreateFromSetValue([Nullable(2)] IResumeSystemRewardPopupType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IResumeSystemRewardPopupType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A306 RID: 41734 RVA: 0x001726B6 File Offset: 0x001708B6
		public IResumeSystemRewardPopupType_SetValue ToSetValue()
		{
			return new IResumeSystemRewardPopupType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003241 RID: 12865
		// (get) Token: 0x0600A307 RID: 41735 RVA: 0x001726C9 File Offset: 0x001708C9
		// (set) Token: 0x0600A308 RID: 41736 RVA: 0x001726F4 File Offset: 0x001708F4
		public virtual ESystemType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESystemType.Shop;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040061D0 RID: 25040
		[Nullable(2)]
		protected IResumeSystemRewardPopupType FbInstance;

		// Token: 0x040061D1 RID: 25041
		[Nullable(2)]
		protected IResumeSystemRewardPopupType_SetValue PocoInterface;
	}
}
