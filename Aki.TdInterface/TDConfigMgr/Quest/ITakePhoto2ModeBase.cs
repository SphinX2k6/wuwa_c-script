using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012A4 RID: 4772
	public class ITakePhoto2ModeBase
	{
		// Token: 0x06006B81 RID: 27521 RVA: 0x00100A9C File Offset: 0x000FEC9C
		private ITakePhoto2ModeBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITakePhoto2ModeBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITakePhoto2ModeBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITakePhoto2ModeBase_SetValue());
			}
			return result;
		}

		// Token: 0x06006B82 RID: 27522 RVA: 0x00100AD4 File Offset: 0x000FECD4
		public static ITakePhoto2ModeBase Create([Nullable(2)] ITakePhoto2ModeBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITakePhoto2ModeBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006B83 RID: 27523 RVA: 0x00100AE7 File Offset: 0x000FECE7
		public static ITakePhoto2ModeBase CreateFromSetValue([Nullable(2)] ITakePhoto2ModeBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITakePhoto2ModeBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006B84 RID: 27524 RVA: 0x00100AFA File Offset: 0x000FECFA
		public ITakePhoto2ModeBase_SetValue ToSetValue()
		{
			return new ITakePhoto2ModeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170022CA RID: 8906
		// (get) Token: 0x06006B85 RID: 27525 RVA: 0x00100B0D File Offset: 0x000FED0D
		// (set) Token: 0x06006B86 RID: 27526 RVA: 0x00100B38 File Offset: 0x000FED38
		public virtual ETakePhoto2Mode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETakePhoto2Mode.BeforeYourEyes;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04004038 RID: 16440
		[Nullable(2)]
		protected ITakePhoto2ModeBase FbInstance;

		// Token: 0x04004039 RID: 16441
		[Nullable(2)]
		protected ITakePhoto2ModeBase_SetValue PocoInterface;
	}
}
