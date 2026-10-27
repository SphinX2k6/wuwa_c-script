using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017D0 RID: 6096
	[NullableContext(1)]
	[Nullable(0)]
	public class IAkEventMapType
	{
		// Token: 0x060082E9 RID: 33513 RVA: 0x00138F38 File Offset: 0x00137138
		private IAkEventMapType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAkEventMapType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAkEventMapType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAkEventMapType_SetValue());
			}
			return result;
		}

		// Token: 0x060082EA RID: 33514 RVA: 0x00138F70 File Offset: 0x00137170
		public static IAkEventMapType Create([Nullable(2)] IAkEventMapType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAkEventMapType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060082EB RID: 33515 RVA: 0x00138F83 File Offset: 0x00137183
		public static IAkEventMapType CreateFromSetValue([Nullable(2)] IAkEventMapType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAkEventMapType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060082EC RID: 33516 RVA: 0x00138F96 File Offset: 0x00137196
		public IAkEventMapType_SetValue ToSetValue()
		{
			return new IAkEventMapType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002B11 RID: 11025
		// (get) Token: 0x060082ED RID: 33517 RVA: 0x00138FA9 File Offset: 0x001371A9
		// (set) Token: 0x060082EE RID: 33518 RVA: 0x00138FD4 File Offset: 0x001371D4
		public virtual EAkEventMap Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EAkEventMap.PlayMapMusic;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400532E RID: 21294
		[Nullable(2)]
		protected IAkEventMapType FbInstance;

		// Token: 0x0400532F RID: 21295
		[Nullable(2)]
		protected IAkEventMapType_SetValue PocoInterface;
	}
}
