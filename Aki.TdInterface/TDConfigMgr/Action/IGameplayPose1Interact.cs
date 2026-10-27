using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001ACB RID: 6859
	[NullableContext(1)]
	[Nullable(0)]
	public class IGameplayPose1Interact : ILeisureInteractType
	{
		// Token: 0x06009314 RID: 37652 RVA: 0x00155944 File Offset: 0x00153B44
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

		// Token: 0x06009315 RID: 37653 RVA: 0x0015597C File Offset: 0x00153B7C
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

		// Token: 0x06009316 RID: 37654 RVA: 0x0015598F File Offset: 0x00153B8F
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

		// Token: 0x06009317 RID: 37655 RVA: 0x001559A2 File Offset: 0x00153BA2
		public new IGameplayPose1Interact_SetValue ToSetValue()
		{
			return new IGameplayPose1Interact_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002EAF RID: 11951
		// (get) Token: 0x06009318 RID: 37656 RVA: 0x001559B5 File Offset: 0x00153BB5
		// (set) Token: 0x06009319 RID: 37657 RVA: 0x001559E0 File Offset: 0x00153BE0
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

		// Token: 0x04005A76 RID: 23158
		[Nullable(2)]
		protected new IGameplayPose1Interact FbInstance;

		// Token: 0x04005A77 RID: 23159
		[Nullable(2)]
		protected new IGameplayPose1Interact_SetValue PocoInterface;
	}
}
