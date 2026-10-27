using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EF9 RID: 7929
	[NullableContext(1)]
	[Nullable(0)]
	public class ISwingGetUp : ILeisureInteractType
	{
		// Token: 0x0600A992 RID: 43410 RVA: 0x0017E43C File Offset: 0x0017C63C
		private ISwingGetUp_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISwingGetUp 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISwingGetUp_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISwingGetUp_SetValue());
			}
			return result;
		}

		// Token: 0x0600A993 RID: 43411 RVA: 0x0017E474 File Offset: 0x0017C674
		public static ISwingGetUp Create([Nullable(2)] ISwingGetUp instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISwingGetUp
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A994 RID: 43412 RVA: 0x0017E487 File Offset: 0x0017C687
		public static ISwingGetUp CreateFromSetValue([Nullable(2)] ISwingGetUp_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISwingGetUp
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A995 RID: 43413 RVA: 0x0017E49A File Offset: 0x0017C69A
		public new ISwingGetUp_SetValue ToSetValue()
		{
			return new ISwingGetUp_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170033AB RID: 13227
		// (get) Token: 0x0600A996 RID: 43414 RVA: 0x0017E4AD File Offset: 0x0017C6AD
		// (set) Token: 0x0600A997 RID: 43415 RVA: 0x0017E4D8 File Offset: 0x0017C6D8
		public override ELeisureInteract Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELeisureInteract.CustomSkill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040064DC RID: 25820
		[Nullable(2)]
		protected new ISwingGetUp FbInstance;

		// Token: 0x040064DD RID: 25821
		[Nullable(2)]
		protected new ISwingGetUp_SetValue PocoInterface;
	}
}
