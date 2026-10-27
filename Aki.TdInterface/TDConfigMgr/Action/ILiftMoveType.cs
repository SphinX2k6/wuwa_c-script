using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B80 RID: 7040
	[NullableContext(1)]
	[Nullable(0)]
	public class ILiftMoveType
	{
		// Token: 0x060096C5 RID: 38597 RVA: 0x0015C20C File Offset: 0x0015A40C
		private ILiftMoveType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILiftMoveType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILiftMoveType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILiftMoveType_SetValue());
			}
			return result;
		}

		// Token: 0x060096C6 RID: 38598 RVA: 0x0015C244 File Offset: 0x0015A444
		public static ILiftMoveType Create([Nullable(2)] ILiftMoveType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiftMoveType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060096C7 RID: 38599 RVA: 0x0015C257 File Offset: 0x0015A457
		public static ILiftMoveType CreateFromSetValue([Nullable(2)] ILiftMoveType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILiftMoveType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060096C8 RID: 38600 RVA: 0x0015C26A File Offset: 0x0015A46A
		public ILiftMoveType_SetValue ToSetValue()
		{
			return new ILiftMoveType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002F79 RID: 12153
		// (get) Token: 0x060096C9 RID: 38601 RVA: 0x0015C27D File Offset: 0x0015A47D
		// (set) Token: 0x060096CA RID: 38602 RVA: 0x0015C2A8 File Offset: 0x0015A4A8
		public virtual ELiftMoveType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELiftMoveType.Default;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005C24 RID: 23588
		[Nullable(2)]
		protected ILiftMoveType FbInstance;

		// Token: 0x04005C25 RID: 23589
		[Nullable(2)]
		protected ILiftMoveType_SetValue PocoInterface;
	}
}
