using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002314 RID: 8980
	public class IWindProtagonistParkour5 : ILeisureInteractType
	{
		// Token: 0x0600C3A4 RID: 50084 RVA: 0x001C154C File Offset: 0x001BF74C
		private IWindProtagonistParkour5_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWindProtagonistParkour5 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWindProtagonistParkour5_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWindProtagonistParkour5_SetValue());
			}
			return result;
		}

		// Token: 0x0600C3A5 RID: 50085 RVA: 0x001C1584 File Offset: 0x001BF784
		public static IWindProtagonistParkour5 Create([Nullable(2)] IWindProtagonistParkour5 instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWindProtagonistParkour5
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C3A6 RID: 50086 RVA: 0x001C1597 File Offset: 0x001BF797
		public static IWindProtagonistParkour5 CreateFromSetValue([Nullable(2)] IWindProtagonistParkour5_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWindProtagonistParkour5
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C3A7 RID: 50087 RVA: 0x001C15AA File Offset: 0x001BF7AA
		public new IWindProtagonistParkour5_SetValue ToSetValue()
		{
			return new IWindProtagonistParkour5_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003B44 RID: 15172
		// (get) Token: 0x0600C3A8 RID: 50088 RVA: 0x001C15BD File Offset: 0x001BF7BD
		// (set) Token: 0x0600C3A9 RID: 50089 RVA: 0x001C15E8 File Offset: 0x001BF7E8
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

		// Token: 0x0400749B RID: 29851
		[Nullable(2)]
		protected new IWindProtagonistParkour5 FbInstance;

		// Token: 0x0400749C RID: 29852
		[Nullable(2)]
		protected new IWindProtagonistParkour5_SetValue PocoInterface;
	}
}
