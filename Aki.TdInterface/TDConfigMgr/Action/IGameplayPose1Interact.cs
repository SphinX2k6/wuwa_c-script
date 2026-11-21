using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C72 RID: 7282
	public class IGameplayPose1Interact : ILeisureInteractType
	{
		// Token: 0x06009AD2 RID: 39634 RVA: 0x00166164 File Offset: 0x00164364
		private IGameplayPose1Interact_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGameplayPose1Interact 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGameplayPose1Interact_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGameplayPose1Interact_SetValue());
			}
			return result;
		}

		// Token: 0x06009AD3 RID: 39635 RVA: 0x0016619C File Offset: 0x0016439C
		public static IGameplayPose1Interact Create([Nullable(2)] IGameplayPose1Interact instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGameplayPose1Interact
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009AD4 RID: 39636 RVA: 0x001661AF File Offset: 0x001643AF
		public static IGameplayPose1Interact CreateFromSetValue([Nullable(2)] IGameplayPose1Interact_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGameplayPose1Interact
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009AD5 RID: 39637 RVA: 0x001661C2 File Offset: 0x001643C2
		public new IGameplayPose1Interact_SetValue ToSetValue()
		{
			return new IGameplayPose1Interact_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170030CB RID: 12491
		// (get) Token: 0x06009AD6 RID: 39638 RVA: 0x001661D5 File Offset: 0x001643D5
		// (set) Token: 0x06009AD7 RID: 39639 RVA: 0x00166200 File Offset: 0x00164400
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

		// Token: 0x04005F00 RID: 24320
		[Nullable(2)]
		protected new IGameplayPose1Interact FbInstance;

		// Token: 0x04005F01 RID: 24321
		[Nullable(2)]
		protected new IGameplayPose1Interact_SetValue PocoInterface;
	}
}
