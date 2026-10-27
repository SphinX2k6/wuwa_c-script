using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CC6 RID: 7366
	[NullableContext(1)]
	[Nullable(0)]
	public class IPathLineFacingType
	{
		// Token: 0x06009E1F RID: 40479 RVA: 0x00169C54 File Offset: 0x00167E54
		private IPathLineFacingType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPathLineFacingType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPathLineFacingType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPathLineFacingType_SetValue());
			}
			return result;
		}

		// Token: 0x06009E20 RID: 40480 RVA: 0x00169C8C File Offset: 0x00167E8C
		public static IPathLineFacingType Create([Nullable(2)] IPathLineFacingType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPathLineFacingType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009E21 RID: 40481 RVA: 0x00169C9F File Offset: 0x00167E9F
		public static IPathLineFacingType CreateFromSetValue([Nullable(2)] IPathLineFacingType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPathLineFacingType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009E22 RID: 40482 RVA: 0x00169CB2 File Offset: 0x00167EB2
		public IPathLineFacingType_SetValue ToSetValue()
		{
			return new IPathLineFacingType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700313D RID: 12605
		// (get) Token: 0x06009E23 RID: 40483 RVA: 0x00169CC5 File Offset: 0x00167EC5
		// (set) Token: 0x06009E24 RID: 40484 RVA: 0x00169CF0 File Offset: 0x00167EF0
		public virtual EPathLineFacingType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPathLineFacingType.Current;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005F9C RID: 24476
		[Nullable(2)]
		protected IPathLineFacingType FbInstance;

		// Token: 0x04005F9D RID: 24477
		[Nullable(2)]
		protected IPathLineFacingType_SetValue PocoInterface;
	}
}
