using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DBF RID: 7615
	public class IMechStuntHighSpeed : IMechStuntConfigType
	{
		// Token: 0x0600A1B7 RID: 41399 RVA: 0x001727DC File Offset: 0x001709DC
		private IMechStuntHighSpeed_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMechStuntHighSpeed 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMechStuntHighSpeed_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMechStuntHighSpeed_SetValue());
			}
			return result;
		}

		// Token: 0x0600A1B8 RID: 41400 RVA: 0x00172814 File Offset: 0x00170A14
		public static IMechStuntHighSpeed Create([Nullable(2)] IMechStuntHighSpeed instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechStuntHighSpeed
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A1B9 RID: 41401 RVA: 0x00172827 File Offset: 0x00170A27
		public static IMechStuntHighSpeed CreateFromSetValue([Nullable(2)] IMechStuntHighSpeed_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMechStuntHighSpeed
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A1BA RID: 41402 RVA: 0x0017283A File Offset: 0x00170A3A
		public new IMechStuntHighSpeed_SetValue ToSetValue()
		{
			return new IMechStuntHighSpeed_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700324B RID: 12875
		// (get) Token: 0x0600A1BB RID: 41403 RVA: 0x0017284D File Offset: 0x00170A4D
		// (set) Token: 0x0600A1BC RID: 41404 RVA: 0x00172878 File Offset: 0x00170A78
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

		// Token: 0x0400622C RID: 25132
		[Nullable(2)]
		protected new IMechStuntHighSpeed FbInstance;

		// Token: 0x0400622D RID: 25133
		[Nullable(2)]
		protected new IMechStuntHighSpeed_SetValue PocoInterface;
	}
}
