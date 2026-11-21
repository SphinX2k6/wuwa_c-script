using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C76 RID: 7286
	public class IGameplayPose3Interact : ILeisureInteractType
	{
		// Token: 0x06009AE2 RID: 39650 RVA: 0x001662DC File Offset: 0x001644DC
		private IGameplayPose3Interact_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGameplayPose3Interact 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGameplayPose3Interact_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGameplayPose3Interact_SetValue());
			}
			return result;
		}

		// Token: 0x06009AE3 RID: 39651 RVA: 0x00166314 File Offset: 0x00164514
		public static IGameplayPose3Interact Create([Nullable(2)] IGameplayPose3Interact instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGameplayPose3Interact
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009AE4 RID: 39652 RVA: 0x00166327 File Offset: 0x00164527
		public static IGameplayPose3Interact CreateFromSetValue([Nullable(2)] IGameplayPose3Interact_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGameplayPose3Interact
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009AE5 RID: 39653 RVA: 0x0016633A File Offset: 0x0016453A
		public new IGameplayPose3Interact_SetValue ToSetValue()
		{
			return new IGameplayPose3Interact_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170030CD RID: 12493
		// (get) Token: 0x06009AE6 RID: 39654 RVA: 0x0016634D File Offset: 0x0016454D
		// (set) Token: 0x06009AE7 RID: 39655 RVA: 0x00166378 File Offset: 0x00164578
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

		// Token: 0x04005F06 RID: 24326
		[Nullable(2)]
		protected new IGameplayPose3Interact FbInstance;

		// Token: 0x04005F07 RID: 24327
		[Nullable(2)]
		protected new IGameplayPose3Interact_SetValue PocoInterface;
	}
}
