using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DBB RID: 7611
	public class IMechStuntConfigType
	{
		// Token: 0x0600A1A7 RID: 41383 RVA: 0x00172664 File Offset: 0x00170864
		private IMechStuntConfigType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMechStuntConfigType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMechStuntConfigType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMechStuntConfigType_SetValue());
			}
			return result;
		}

		// Token: 0x0600A1A8 RID: 41384 RVA: 0x0017269C File Offset: 0x0017089C
		public static IMechStuntConfigType Create([Nullable(2)] IMechStuntConfigType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechStuntConfigType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A1A9 RID: 41385 RVA: 0x001726AF File Offset: 0x001708AF
		public static IMechStuntConfigType CreateFromSetValue([Nullable(2)] IMechStuntConfigType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMechStuntConfigType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A1AA RID: 41386 RVA: 0x001726C2 File Offset: 0x001708C2
		public IMechStuntConfigType_SetValue ToSetValue()
		{
			return new IMechStuntConfigType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003249 RID: 12873
		// (get) Token: 0x0600A1AB RID: 41387 RVA: 0x001726D5 File Offset: 0x001708D5
		// (set) Token: 0x0600A1AC RID: 41388 RVA: 0x00172700 File Offset: 0x00170900
		public virtual EMechStuntType Type
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

		// Token: 0x04006226 RID: 25126
		[Nullable(2)]
		protected IMechStuntConfigType FbInstance;

		// Token: 0x04006227 RID: 25127
		[Nullable(2)]
		protected IMechStuntConfigType_SetValue PocoInterface;
	}
}
