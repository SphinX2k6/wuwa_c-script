using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200230C RID: 8972
	public class IWindProtagonistParkour1 : ILeisureInteractType
	{
		// Token: 0x0600C384 RID: 50052 RVA: 0x001C125C File Offset: 0x001BF45C
		private IWindProtagonistParkour1_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWindProtagonistParkour1 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWindProtagonistParkour1_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWindProtagonistParkour1_SetValue());
			}
			return result;
		}

		// Token: 0x0600C385 RID: 50053 RVA: 0x001C1294 File Offset: 0x001BF494
		public static IWindProtagonistParkour1 Create([Nullable(2)] IWindProtagonistParkour1 instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWindProtagonistParkour1
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C386 RID: 50054 RVA: 0x001C12A7 File Offset: 0x001BF4A7
		public static IWindProtagonistParkour1 CreateFromSetValue([Nullable(2)] IWindProtagonistParkour1_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWindProtagonistParkour1
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C387 RID: 50055 RVA: 0x001C12BA File Offset: 0x001BF4BA
		public new IWindProtagonistParkour1_SetValue ToSetValue()
		{
			return new IWindProtagonistParkour1_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003B40 RID: 15168
		// (get) Token: 0x0600C388 RID: 50056 RVA: 0x001C12CD File Offset: 0x001BF4CD
		// (set) Token: 0x0600C389 RID: 50057 RVA: 0x001C12F8 File Offset: 0x001BF4F8
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

		// Token: 0x0400748F RID: 29839
		[Nullable(2)]
		protected new IWindProtagonistParkour1 FbInstance;

		// Token: 0x04007490 RID: 29840
		[Nullable(2)]
		protected new IWindProtagonistParkour1_SetValue PocoInterface;
	}
}
