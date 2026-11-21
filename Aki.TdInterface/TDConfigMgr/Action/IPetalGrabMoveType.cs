using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EE9 RID: 7913
	public class IPetalGrabMoveType
	{
		// Token: 0x0600A875 RID: 43125 RVA: 0x0017ECE4 File Offset: 0x0017CEE4
		private IPetalGrabMoveType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPetalGrabMoveType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPetalGrabMoveType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPetalGrabMoveType_SetValue());
			}
			return result;
		}

		// Token: 0x0600A876 RID: 43126 RVA: 0x0017ED1C File Offset: 0x0017CF1C
		public static IPetalGrabMoveType Create([Nullable(2)] IPetalGrabMoveType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPetalGrabMoveType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A877 RID: 43127 RVA: 0x0017ED2F File Offset: 0x0017CF2F
		public static IPetalGrabMoveType CreateFromSetValue([Nullable(2)] IPetalGrabMoveType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPetalGrabMoveType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A878 RID: 43128 RVA: 0x0017ED42 File Offset: 0x0017CF42
		public IPetalGrabMoveType_SetValue ToSetValue()
		{
			return new IPetalGrabMoveType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170033EB RID: 13291
		// (get) Token: 0x0600A879 RID: 43129 RVA: 0x0017ED55 File Offset: 0x0017CF55
		// (set) Token: 0x0600A87A RID: 43130 RVA: 0x0017ED80 File Offset: 0x0017CF80
		public virtual EPetalGrabMoveType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPetalGrabMoveType.Linear;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006546 RID: 25926
		[Nullable(2)]
		protected IPetalGrabMoveType FbInstance;

		// Token: 0x04006547 RID: 25927
		[Nullable(2)]
		protected IPetalGrabMoveType_SetValue PocoInterface;
	}
}
