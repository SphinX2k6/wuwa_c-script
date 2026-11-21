using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DB7 RID: 7607
	public class IMechStuntBurrow : IMechStuntConfigType
	{
		// Token: 0x0600A197 RID: 41367 RVA: 0x001724EC File Offset: 0x001706EC
		private IMechStuntBurrow_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMechStuntBurrow 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMechStuntBurrow_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMechStuntBurrow_SetValue());
			}
			return result;
		}

		// Token: 0x0600A198 RID: 41368 RVA: 0x00172524 File Offset: 0x00170724
		public static IMechStuntBurrow Create([Nullable(2)] IMechStuntBurrow instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechStuntBurrow
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A199 RID: 41369 RVA: 0x00172537 File Offset: 0x00170737
		public static IMechStuntBurrow CreateFromSetValue([Nullable(2)] IMechStuntBurrow_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMechStuntBurrow
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A19A RID: 41370 RVA: 0x0017254A File Offset: 0x0017074A
		public new IMechStuntBurrow_SetValue ToSetValue()
		{
			return new IMechStuntBurrow_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003247 RID: 12871
		// (get) Token: 0x0600A19B RID: 41371 RVA: 0x0017255D File Offset: 0x0017075D
		// (set) Token: 0x0600A19C RID: 41372 RVA: 0x00172588 File Offset: 0x00170788
		public override EMechStuntType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMechStuntType.Dive;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006220 RID: 25120
		[Nullable(2)]
		protected new IMechStuntBurrow FbInstance;

		// Token: 0x04006221 RID: 25121
		[Nullable(2)]
		protected new IMechStuntBurrow_SetValue PocoInterface;
	}
}
