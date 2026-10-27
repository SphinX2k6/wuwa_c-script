using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020B9 RID: 8377
	[NullableContext(1)]
	[Nullable(0)]
	public class IWindProtagonistParkour2 : ILeisureInteractType
	{
		// Token: 0x0600B834 RID: 47156 RVA: 0x001AA6D0 File Offset: 0x001A88D0
		private IWindProtagonistParkour2_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWindProtagonistParkour2 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWindProtagonistParkour2_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWindProtagonistParkour2_SetValue());
			}
			return result;
		}

		// Token: 0x0600B835 RID: 47157 RVA: 0x001AA708 File Offset: 0x001A8908
		public static IWindProtagonistParkour2 Create([Nullable(2)] IWindProtagonistParkour2 instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWindProtagonistParkour2
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B836 RID: 47158 RVA: 0x001AA71B File Offset: 0x001A891B
		public static IWindProtagonistParkour2 CreateFromSetValue([Nullable(2)] IWindProtagonistParkour2_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWindProtagonistParkour2
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B837 RID: 47159 RVA: 0x001AA72E File Offset: 0x001A892E
		public new IWindProtagonistParkour2_SetValue ToSetValue()
		{
			return new IWindProtagonistParkour2_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700385D RID: 14429
		// (get) Token: 0x0600B838 RID: 47160 RVA: 0x001AA741 File Offset: 0x001A8941
		// (set) Token: 0x0600B839 RID: 47161 RVA: 0x001AA76C File Offset: 0x001A896C
		public override ELeisureInteract Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELeisureInteract.CustomSkill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006E74 RID: 28276
		[Nullable(2)]
		protected new IWindProtagonistParkour2 FbInstance;

		// Token: 0x04006E75 RID: 28277
		[Nullable(2)]
		protected new IWindProtagonistParkour2_SetValue PocoInterface;
	}
}
