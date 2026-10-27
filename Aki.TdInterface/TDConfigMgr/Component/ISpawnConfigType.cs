using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006E2 RID: 1762
	[NullableContext(1)]
	[Nullable(0)]
	public class ISpawnConfigType
	{
		// Token: 0x060025F8 RID: 9720 RVA: 0x00065FD0 File Offset: 0x000641D0
		private ISpawnConfigType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISpawnConfigType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISpawnConfigType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISpawnConfigType_SetValue());
			}
			return result;
		}

		// Token: 0x060025F9 RID: 9721 RVA: 0x00066008 File Offset: 0x00064208
		public static ISpawnConfigType Create([Nullable(2)] ISpawnConfigType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpawnConfigType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060025FA RID: 9722 RVA: 0x0006601B File Offset: 0x0006421B
		public static ISpawnConfigType CreateFromSetValue([Nullable(2)] ISpawnConfigType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISpawnConfigType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060025FB RID: 9723 RVA: 0x0006602E File Offset: 0x0006422E
		public ISpawnConfigType_SetValue ToSetValue()
		{
			return new ISpawnConfigType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x060025FC RID: 9724 RVA: 0x00066041 File Offset: 0x00064241
		// (set) Token: 0x060025FD RID: 9725 RVA: 0x0006606C File Offset: 0x0006426C
		public virtual ESpawnConfigType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESpawnConfigType.TemplateMatrix;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040019DC RID: 6620
		[Nullable(2)]
		protected ISpawnConfigType FbInstance;

		// Token: 0x040019DD RID: 6621
		[Nullable(2)]
		protected ISpawnConfigType_SetValue PocoInterface;
	}
}
