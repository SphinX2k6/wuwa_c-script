using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FCC RID: 8140
	[NullableContext(1)]
	[Nullable(0)]
	public class IToggleDragActorPlayDisable : IToggleDragActorPlayType
	{
		// Token: 0x0600B310 RID: 45840 RVA: 0x001A10A0 File Offset: 0x0019F2A0
		private IToggleDragActorPlayDisable_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IToggleDragActorPlayDisable 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IToggleDragActorPlayDisable_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IToggleDragActorPlayDisable_SetValue());
			}
			return result;
		}

		// Token: 0x0600B311 RID: 45841 RVA: 0x001A10D8 File Offset: 0x0019F2D8
		public static IToggleDragActorPlayDisable Create([Nullable(2)] IToggleDragActorPlayDisable instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IToggleDragActorPlayDisable
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B312 RID: 45842 RVA: 0x001A10EB File Offset: 0x0019F2EB
		public static IToggleDragActorPlayDisable CreateFromSetValue([Nullable(2)] IToggleDragActorPlayDisable_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IToggleDragActorPlayDisable
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B313 RID: 45843 RVA: 0x001A10FE File Offset: 0x0019F2FE
		public new IToggleDragActorPlayDisable_SetValue ToSetValue()
		{
			return new IToggleDragActorPlayDisable_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700372E RID: 14126
		// (get) Token: 0x0600B314 RID: 45844 RVA: 0x001A1111 File Offset: 0x0019F311
		// (set) Token: 0x0600B315 RID: 45845 RVA: 0x001A113C File Offset: 0x0019F33C
		public override EToggleDragActorPlayType Type
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

		// Token: 0x04006C11 RID: 27665
		[Nullable(2)]
		protected new IToggleDragActorPlayDisable FbInstance;

		// Token: 0x04006C12 RID: 27666
		[Nullable(2)]
		protected new IToggleDragActorPlayDisable_SetValue PocoInterface;
	}
}
