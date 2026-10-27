using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AD3 RID: 6867
	[NullableContext(1)]
	[Nullable(0)]
	public class IGetUp : ILeisureInteractType
	{
		// Token: 0x06009334 RID: 37684 RVA: 0x00155C34 File Offset: 0x00153E34
		private IGetUp_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGetUp 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGetUp_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGetUp_SetValue());
			}
			return result;
		}

		// Token: 0x06009335 RID: 37685 RVA: 0x00155C6C File Offset: 0x00153E6C
		public static IGetUp Create([Nullable(2)] IGetUp instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGetUp
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009336 RID: 37686 RVA: 0x00155C7F File Offset: 0x00153E7F
		public static IGetUp CreateFromSetValue([Nullable(2)] IGetUp_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGetUp
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009337 RID: 37687 RVA: 0x00155C92 File Offset: 0x00153E92
		public new IGetUp_SetValue ToSetValue()
		{
			return new IGetUp_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002EB3 RID: 11955
		// (get) Token: 0x06009338 RID: 37688 RVA: 0x00155CA5 File Offset: 0x00153EA5
		// (set) Token: 0x06009339 RID: 37689 RVA: 0x00155CD0 File Offset: 0x00153ED0
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

		// Token: 0x04005A82 RID: 23170
		[Nullable(2)]
		protected new IGetUp FbInstance;

		// Token: 0x04005A83 RID: 23171
		[Nullable(2)]
		protected new IGetUp_SetValue PocoInterface;
	}
}
