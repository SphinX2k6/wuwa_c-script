using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000604 RID: 1540
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlayerAttachTarget : IAttachTarget
	{
		// Token: 0x060020E2 RID: 8418 RVA: 0x0005B680 File Offset: 0x00059880
		private IPlayerAttachTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPlayerAttachTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPlayerAttachTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPlayerAttachTarget_SetValue());
			}
			return result;
		}

		// Token: 0x060020E3 RID: 8419 RVA: 0x0005B6B8 File Offset: 0x000598B8
		public static IPlayerAttachTarget Create([Nullable(2)] IPlayerAttachTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayerAttachTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x060020E4 RID: 8420 RVA: 0x0005B6CB File Offset: 0x000598CB
		public static IPlayerAttachTarget CreateFromSetValue([Nullable(2)] IPlayerAttachTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPlayerAttachTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x060020E5 RID: 8421 RVA: 0x0005B6DE File Offset: 0x000598DE
		public new IPlayerAttachTarget_SetValue ToSetValue()
		{
			return new IPlayerAttachTarget_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x060020E6 RID: 8422 RVA: 0x0005B6F1 File Offset: 0x000598F1
		// (set) Token: 0x060020E7 RID: 8423 RVA: 0x0005B71C File Offset: 0x0005991C
		public override EAttachType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EAttachType.Actor;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400170A RID: 5898
		[Nullable(2)]
		protected new IPlayerAttachTarget FbInstance;

		// Token: 0x0400170B RID: 5899
		[Nullable(2)]
		protected new IPlayerAttachTarget_SetValue PocoInterface;
	}
}
