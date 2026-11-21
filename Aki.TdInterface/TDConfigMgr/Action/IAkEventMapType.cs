using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001957 RID: 6487
	public class IAkEventMapType
	{
		// Token: 0x060089FB RID: 35323 RVA: 0x00148520 File Offset: 0x00146720
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

		// Token: 0x060089FC RID: 35324 RVA: 0x00148558 File Offset: 0x00146758
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

		// Token: 0x060089FD RID: 35325 RVA: 0x0014856B File Offset: 0x0014676B
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

		// Token: 0x060089FE RID: 35326 RVA: 0x0014857E File Offset: 0x0014677E
		public IAkEventMapType_SetValue ToSetValue()
		{
			return new IAkEventMapType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002D07 RID: 11527
		// (get) Token: 0x060089FF RID: 35327 RVA: 0x00148591 File Offset: 0x00146791
		// (set) Token: 0x06008A00 RID: 35328 RVA: 0x001485BC File Offset: 0x001467BC
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

		// Token: 0x04005772 RID: 22386
		[Nullable(2)]
		protected IAkEventMapType FbInstance;

		// Token: 0x04005773 RID: 22387
		[Nullable(2)]
		protected IAkEventMapType_SetValue PocoInterface;
	}
}
