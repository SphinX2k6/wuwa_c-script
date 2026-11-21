using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001250 RID: 4688
	public class ISaveConfigType
	{
		// Token: 0x060068FF RID: 26879 RVA: 0x000FB30C File Offset: 0x000F950C
		private ISaveConfigType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISaveConfigType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISaveConfigType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISaveConfigType_SetValue());
			}
			return result;
		}

		// Token: 0x06006900 RID: 26880 RVA: 0x000FB344 File Offset: 0x000F9544
		public static ISaveConfigType Create([Nullable(2)] ISaveConfigType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISaveConfigType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006901 RID: 26881 RVA: 0x000FB357 File Offset: 0x000F9557
		public static ISaveConfigType CreateFromSetValue([Nullable(2)] ISaveConfigType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISaveConfigType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006902 RID: 26882 RVA: 0x000FB36A File Offset: 0x000F956A
		public ISaveConfigType_SetValue ToSetValue()
		{
			return new ISaveConfigType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002206 RID: 8710
		// (get) Token: 0x06006903 RID: 26883 RVA: 0x000FB37D File Offset: 0x000F957D
		// (set) Token: 0x06006904 RID: 26884 RVA: 0x000FB3A8 File Offset: 0x000F95A8
		public virtual ESaveConfig Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESaveConfig.SaveNew;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003EAE RID: 16046
		[Nullable(2)]
		protected ISaveConfigType FbInstance;

		// Token: 0x04003EAF RID: 16047
		[Nullable(2)]
		protected ISaveConfigType_SetValue PocoInterface;
	}
}
