using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BA2 RID: 7074
	[NullableContext(1)]
	[Nullable(0)]
	public class ILongPressInteractStyleConfig
	{
		// Token: 0x06009783 RID: 38787 RVA: 0x0015D890 File Offset: 0x0015BA90
		private ILongPressInteractStyleConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILongPressInteractStyleConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILongPressInteractStyleConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILongPressInteractStyleConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06009784 RID: 38788 RVA: 0x0015D8C8 File Offset: 0x0015BAC8
		public static ILongPressInteractStyleConfig Create([Nullable(2)] ILongPressInteractStyleConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILongPressInteractStyleConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009785 RID: 38789 RVA: 0x0015D8DB File Offset: 0x0015BADB
		public static ILongPressInteractStyleConfig CreateFromSetValue([Nullable(2)] ILongPressInteractStyleConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILongPressInteractStyleConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009786 RID: 38790 RVA: 0x0015D8EE File Offset: 0x0015BAEE
		public ILongPressInteractStyleConfig_SetValue ToSetValue()
		{
			return new ILongPressInteractStyleConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002FA5 RID: 12197
		// (get) Token: 0x06009787 RID: 38791 RVA: 0x0015D901 File Offset: 0x0015BB01
		// (set) Token: 0x06009788 RID: 38792 RVA: 0x0015D92C File Offset: 0x0015BB2C
		public virtual ELongPressInteractStyle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELongPressInteractStyle.Default;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005C80 RID: 23680
		[Nullable(2)]
		protected ILongPressInteractStyleConfig FbInstance;

		// Token: 0x04005C81 RID: 23681
		[Nullable(2)]
		protected ILongPressInteractStyleConfig_SetValue PocoInterface;
	}
}
