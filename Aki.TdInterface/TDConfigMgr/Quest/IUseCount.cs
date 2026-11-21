using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200131A RID: 4890
	public class IUseCount : IProgressBarLeftType
	{
		// Token: 0x06006E25 RID: 28197 RVA: 0x00106040 File Offset: 0x00104240
		private IUseCount_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IUseCount 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IUseCount_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IUseCount_SetValue());
			}
			return result;
		}

		// Token: 0x06006E26 RID: 28198 RVA: 0x00106078 File Offset: 0x00104278
		public static IUseCount Create([Nullable(2)] IUseCount instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUseCount
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006E27 RID: 28199 RVA: 0x0010608B File Offset: 0x0010428B
		public static IUseCount CreateFromSetValue([Nullable(2)] IUseCount_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IUseCount
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006E28 RID: 28200 RVA: 0x0010609E File Offset: 0x0010429E
		public new IUseCount_SetValue ToSetValue()
		{
			return new IUseCount_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700236B RID: 9067
		// (get) Token: 0x06006E29 RID: 28201 RVA: 0x001060B1 File Offset: 0x001042B1
		// (set) Token: 0x06006E2A RID: 28202 RVA: 0x001060DC File Offset: 0x001042DC
		public override EProgressBarLeftType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EProgressBarLeftType.UseCount;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040041B9 RID: 16825
		[Nullable(2)]
		protected new IUseCount FbInstance;

		// Token: 0x040041BA RID: 16826
		[Nullable(2)]
		protected new IUseCount_SetValue PocoInterface;
	}
}
