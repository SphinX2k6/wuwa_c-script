using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001041 RID: 4161
	[NullableContext(1)]
	[Nullable(0)]
	public class IPhotographSubTarget
	{
		// Token: 0x06005D3A RID: 23866 RVA: 0x000E1D34 File Offset: 0x000DFF34
		private IPhotographSubTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPhotographSubTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPhotographSubTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPhotographSubTarget_SetValue());
			}
			return result;
		}

		// Token: 0x06005D3B RID: 23867 RVA: 0x000E1D6C File Offset: 0x000DFF6C
		public static IPhotographSubTarget Create([Nullable(2)] IPhotographSubTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhotographSubTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005D3C RID: 23868 RVA: 0x000E1D7F File Offset: 0x000DFF7F
		public static IPhotographSubTarget CreateFromSetValue([Nullable(2)] IPhotographSubTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPhotographSubTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005D3D RID: 23869 RVA: 0x000E1D92 File Offset: 0x000DFF92
		public IPhotographSubTarget_SetValue ToSetValue()
		{
			return new IPhotographSubTarget_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001EBD RID: 7869
		// (get) Token: 0x06005D3E RID: 23870 RVA: 0x000E1DA5 File Offset: 0x000DFFA5
		// (set) Token: 0x06005D3F RID: 23871 RVA: 0x000E1DD0 File Offset: 0x000DFFD0
		public virtual EPhotographSubTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPhotographSubTargetType.SpecificRole;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003828 RID: 14376
		[Nullable(2)]
		protected IPhotographSubTarget FbInstance;

		// Token: 0x04003829 RID: 14377
		[Nullable(2)]
		protected IPhotographSubTarget_SetValue PocoInterface;
	}
}
