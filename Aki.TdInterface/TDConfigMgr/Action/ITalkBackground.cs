using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200214F RID: 8527
	public class ITalkBackground
	{
		// Token: 0x0600B4FC RID: 46332 RVA: 0x001954C4 File Offset: 0x001936C4
		private ITalkBackground_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkBackground 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkBackground_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkBackground_SetValue());
			}
			return result;
		}

		// Token: 0x0600B4FD RID: 46333 RVA: 0x001954FC File Offset: 0x001936FC
		public static ITalkBackground Create([Nullable(2)] ITalkBackground instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkBackground
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B4FE RID: 46334 RVA: 0x0019550F File Offset: 0x0019370F
		public static ITalkBackground CreateFromSetValue([Nullable(2)] ITalkBackground_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkBackground
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B4FF RID: 46335 RVA: 0x00195522 File Offset: 0x00193722
		public ITalkBackground_SetValue ToSetValue()
		{
			return new ITalkBackground_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003697 RID: 13975
		// (get) Token: 0x0600B500 RID: 46336 RVA: 0x00195535 File Offset: 0x00193735
		// (set) Token: 0x0600B501 RID: 46337 RVA: 0x00195560 File Offset: 0x00193760
		public virtual ETalkBackgroundType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETalkBackgroundType.Clean;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006B0D RID: 27405
		[Nullable(2)]
		protected ITalkBackground FbInstance;

		// Token: 0x04006B0E RID: 27406
		[Nullable(2)]
		protected ITalkBackground_SetValue PocoInterface;
	}
}
