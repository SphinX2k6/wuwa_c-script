using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019D4 RID: 6612
	[NullableContext(1)]
	[Nullable(0)]
	public class IElementalBoxTargetPosTypeBase
	{
		// Token: 0x06008D9F RID: 36255 RVA: 0x0014BB64 File Offset: 0x00149D64
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

		// Token: 0x06008DA0 RID: 36256 RVA: 0x0014BB9C File Offset: 0x00149D9C
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

		// Token: 0x06008DA1 RID: 36257 RVA: 0x0014BBAF File Offset: 0x00149DAF
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

		// Token: 0x06008DA2 RID: 36258 RVA: 0x0014BBC2 File Offset: 0x00149DC2
		public IElementalBoxTargetPosTypeBase_SetValue ToSetValue()
		{
			return new IElementalBoxTargetPosTypeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002D66 RID: 11622
		// (get) Token: 0x06008DA3 RID: 36259 RVA: 0x0014BBD5 File Offset: 0x00149DD5
		// (set) Token: 0x06008DA4 RID: 36260 RVA: 0x0014BC00 File Offset: 0x00149E00
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

		// Token: 0x040057F3 RID: 22515
		[Nullable(2)]
		protected IElementalBoxTargetPosTypeBase FbInstance;

		// Token: 0x040057F4 RID: 22516
		[Nullable(2)]
		protected IElementalBoxTargetPosTypeBase_SetValue PocoInterface;
	}
}
