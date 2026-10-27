using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B72 RID: 7026
	[NullableContext(1)]
	[Nullable(0)]
	public class ILeisureInteractType
	{
		// Token: 0x06009675 RID: 38517 RVA: 0x0015B86C File Offset: 0x00159A6C
		private ILeisureInteractType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILeisureInteractType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILeisureInteractType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILeisureInteractType_SetValue());
			}
			return result;
		}

		// Token: 0x06009676 RID: 38518 RVA: 0x0015B8A4 File Offset: 0x00159AA4
		public static ILeisureInteractType Create([Nullable(2)] ILeisureInteractType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILeisureInteractType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009677 RID: 38519 RVA: 0x0015B8B7 File Offset: 0x00159AB7
		public static ILeisureInteractType CreateFromSetValue([Nullable(2)] ILeisureInteractType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILeisureInteractType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009678 RID: 38520 RVA: 0x0015B8CA File Offset: 0x00159ACA
		public ILeisureInteractType_SetValue ToSetValue()
		{
			return new ILeisureInteractType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002F66 RID: 12134
		// (get) Token: 0x06009679 RID: 38521 RVA: 0x0015B8DD File Offset: 0x00159ADD
		// (set) Token: 0x0600967A RID: 38522 RVA: 0x0015B908 File Offset: 0x00159B08
		public virtual ELeisureInteract Type
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

		// Token: 0x04005BFD RID: 23549
		[Nullable(2)]
		protected ILeisureInteractType FbInstance;

		// Token: 0x04005BFE RID: 23550
		[Nullable(2)]
		protected ILeisureInteractType_SetValue PocoInterface;
	}
}
