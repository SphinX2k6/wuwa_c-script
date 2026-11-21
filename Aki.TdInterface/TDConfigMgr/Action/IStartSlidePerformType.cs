using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020EE RID: 8430
	public class IStartSlidePerformType
	{
		// Token: 0x0600B2F2 RID: 45810 RVA: 0x00191AC4 File Offset: 0x0018FCC4
		private IStartSlidePerformType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IStartSlidePerformType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IStartSlidePerformType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IStartSlidePerformType_SetValue());
			}
			return result;
		}

		// Token: 0x0600B2F3 RID: 45811 RVA: 0x00191AFC File Offset: 0x0018FCFC
		public static IStartSlidePerformType Create([Nullable(2)] IStartSlidePerformType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStartSlidePerformType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B2F4 RID: 45812 RVA: 0x00191B0F File Offset: 0x0018FD0F
		public static IStartSlidePerformType CreateFromSetValue([Nullable(2)] IStartSlidePerformType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IStartSlidePerformType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B2F5 RID: 45813 RVA: 0x00191B22 File Offset: 0x0018FD22
		public IStartSlidePerformType_SetValue ToSetValue()
		{
			return new IStartSlidePerformType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003623 RID: 13859
		// (get) Token: 0x0600B2F6 RID: 45814 RVA: 0x00191B35 File Offset: 0x0018FD35
		// (set) Token: 0x0600B2F7 RID: 45815 RVA: 0x00191B60 File Offset: 0x0018FD60
		public virtual ESlidePerformType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESlidePerformType.SlopeSlide;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006A20 RID: 27168
		[Nullable(2)]
		protected IStartSlidePerformType FbInstance;

		// Token: 0x04006A21 RID: 27169
		[Nullable(2)]
		protected IStartSlidePerformType_SetValue PocoInterface;
	}
}
