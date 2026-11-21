using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F17 RID: 7959
	public class IPlayerNewSplineMoveTarget : INewSplineMoveTarget
	{
		// Token: 0x0600A961 RID: 43361 RVA: 0x001807F4 File Offset: 0x0017E9F4
		private IPlayerNewSplineMoveTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPlayerNewSplineMoveTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPlayerNewSplineMoveTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPlayerNewSplineMoveTarget_SetValue());
			}
			return result;
		}

		// Token: 0x0600A962 RID: 43362 RVA: 0x0018082C File Offset: 0x0017EA2C
		public static IPlayerNewSplineMoveTarget Create([Nullable(2)] IPlayerNewSplineMoveTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayerNewSplineMoveTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A963 RID: 43363 RVA: 0x0018083F File Offset: 0x0017EA3F
		public static IPlayerNewSplineMoveTarget CreateFromSetValue([Nullable(2)] IPlayerNewSplineMoveTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPlayerNewSplineMoveTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A964 RID: 43364 RVA: 0x00180852 File Offset: 0x0017EA52
		public new IPlayerNewSplineMoveTarget_SetValue ToSetValue()
		{
			return new IPlayerNewSplineMoveTarget_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700341C RID: 13340
		// (get) Token: 0x0600A965 RID: 43365 RVA: 0x00180865 File Offset: 0x0017EA65
		// (set) Token: 0x0600A966 RID: 43366 RVA: 0x00180890 File Offset: 0x0017EA90
		public override ENewSplineMoveTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENewSplineMoveTargetType.Player;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040065B7 RID: 26039
		[Nullable(2)]
		protected new IPlayerNewSplineMoveTarget FbInstance;

		// Token: 0x040065B8 RID: 26040
		[Nullable(2)]
		protected new IPlayerNewSplineMoveTarget_SetValue PocoInterface;
	}
}
