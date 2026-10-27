using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EA5 RID: 7845
	[NullableContext(1)]
	[Nullable(0)]
	public class ISplineMoveTargetType
	{
		// Token: 0x0600A7D6 RID: 42966 RVA: 0x0017B24C File Offset: 0x0017944C
		private ISplineMoveTargetType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISplineMoveTargetType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISplineMoveTargetType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISplineMoveTargetType_SetValue());
			}
			return result;
		}

		// Token: 0x0600A7D7 RID: 42967 RVA: 0x0017B284 File Offset: 0x00179484
		public static ISplineMoveTargetType Create([Nullable(2)] ISplineMoveTargetType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISplineMoveTargetType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A7D8 RID: 42968 RVA: 0x0017B297 File Offset: 0x00179497
		public static ISplineMoveTargetType CreateFromSetValue([Nullable(2)] ISplineMoveTargetType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISplineMoveTargetType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A7D9 RID: 42969 RVA: 0x0017B2AA File Offset: 0x001794AA
		public ISplineMoveTargetType_SetValue ToSetValue()
		{
			return new ISplineMoveTargetType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700334B RID: 13131
		// (get) Token: 0x0600A7DA RID: 42970 RVA: 0x0017B2BD File Offset: 0x001794BD
		// (set) Token: 0x0600A7DB RID: 42971 RVA: 0x0017B2E8 File Offset: 0x001794E8
		public virtual ESplineMoveTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESplineMoveTargetType.Entity;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400640C RID: 25612
		[Nullable(2)]
		protected ISplineMoveTargetType FbInstance;

		// Token: 0x0400640D RID: 25613
		[Nullable(2)]
		protected ISplineMoveTargetType_SetValue PocoInterface;
	}
}
