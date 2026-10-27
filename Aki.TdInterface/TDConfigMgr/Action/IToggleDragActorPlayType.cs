using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FD0 RID: 8144
	[NullableContext(1)]
	[Nullable(0)]
	public class IToggleDragActorPlayType
	{
		// Token: 0x0600B332 RID: 45874 RVA: 0x001A14A8 File Offset: 0x0019F6A8
		private IToggleDragActorPlayType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IToggleDragActorPlayType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IToggleDragActorPlayType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IToggleDragActorPlayType_SetValue());
			}
			return result;
		}

		// Token: 0x0600B333 RID: 45875 RVA: 0x001A14E0 File Offset: 0x0019F6E0
		public static IToggleDragActorPlayType Create([Nullable(2)] IToggleDragActorPlayType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IToggleDragActorPlayType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B334 RID: 45876 RVA: 0x001A14F3 File Offset: 0x0019F6F3
		public static IToggleDragActorPlayType CreateFromSetValue([Nullable(2)] IToggleDragActorPlayType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IToggleDragActorPlayType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B335 RID: 45877 RVA: 0x001A1506 File Offset: 0x0019F706
		public IToggleDragActorPlayType_SetValue ToSetValue()
		{
			return new IToggleDragActorPlayType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003739 RID: 14137
		// (get) Token: 0x0600B336 RID: 45878 RVA: 0x001A1519 File Offset: 0x0019F719
		// (set) Token: 0x0600B337 RID: 45879 RVA: 0x001A1544 File Offset: 0x0019F744
		public virtual EToggleDragActorPlayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EToggleDragActorPlayType.Enable;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006C22 RID: 27682
		[Nullable(2)]
		protected IToggleDragActorPlayType FbInstance;

		// Token: 0x04006C23 RID: 27683
		[Nullable(2)]
		protected IToggleDragActorPlayType_SetValue PocoInterface;
	}
}
