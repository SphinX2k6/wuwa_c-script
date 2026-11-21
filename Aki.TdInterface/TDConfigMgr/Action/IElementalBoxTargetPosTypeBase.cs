using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B61 RID: 7009
	public class IElementalBoxTargetPosTypeBase
	{
		// Token: 0x060094E1 RID: 38113 RVA: 0x0015B670 File Offset: 0x00159870
		private IElementalBoxTargetPosTypeBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IElementalBoxTargetPosTypeBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IElementalBoxTargetPosTypeBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IElementalBoxTargetPosTypeBase_SetValue());
			}
			return result;
		}

		// Token: 0x060094E2 RID: 38114 RVA: 0x0015B6A8 File Offset: 0x001598A8
		public static IElementalBoxTargetPosTypeBase Create([Nullable(2)] IElementalBoxTargetPosTypeBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IElementalBoxTargetPosTypeBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x060094E3 RID: 38115 RVA: 0x0015B6BB File Offset: 0x001598BB
		public static IElementalBoxTargetPosTypeBase CreateFromSetValue([Nullable(2)] IElementalBoxTargetPosTypeBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IElementalBoxTargetPosTypeBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x060094E4 RID: 38116 RVA: 0x0015B6CE File Offset: 0x001598CE
		public IElementalBoxTargetPosTypeBase_SetValue ToSetValue()
		{
			return new IElementalBoxTargetPosTypeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002F6B RID: 12139
		// (get) Token: 0x060094E5 RID: 38117 RVA: 0x0015B6E1 File Offset: 0x001598E1
		// (set) Token: 0x060094E6 RID: 38118 RVA: 0x0015B70C File Offset: 0x0015990C
		public virtual EElementalBoxTargetPosType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EElementalBoxTargetPosType.PrefabElementalBoxTargetPos;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005C48 RID: 23624
		[Nullable(2)]
		protected IElementalBoxTargetPosTypeBase FbInstance;

		// Token: 0x04005C49 RID: 23625
		[Nullable(2)]
		protected IElementalBoxTargetPosTypeBase_SetValue PocoInterface;
	}
}
