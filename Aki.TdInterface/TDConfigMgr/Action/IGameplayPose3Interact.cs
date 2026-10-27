using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001ACF RID: 6863
	[NullableContext(1)]
	[Nullable(0)]
	public class IGameplayPose3Interact : ILeisureInteractType
	{
		// Token: 0x06009324 RID: 37668 RVA: 0x00155ABC File Offset: 0x00153CBC
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

		// Token: 0x06009325 RID: 37669 RVA: 0x00155AF4 File Offset: 0x00153CF4
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

		// Token: 0x06009326 RID: 37670 RVA: 0x00155B07 File Offset: 0x00153D07
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

		// Token: 0x06009327 RID: 37671 RVA: 0x00155B1A File Offset: 0x00153D1A
		public new IGameplayPose3Interact_SetValue ToSetValue()
		{
			return new IGameplayPose3Interact_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002EB1 RID: 11953
		// (get) Token: 0x06009328 RID: 37672 RVA: 0x00155B2D File Offset: 0x00153D2D
		// (set) Token: 0x06009329 RID: 37673 RVA: 0x00155B58 File Offset: 0x00153D58
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

		// Token: 0x04005A7C RID: 23164
		[Nullable(2)]
		protected new IGameplayPose3Interact FbInstance;

		// Token: 0x04005A7D RID: 23165
		[Nullable(2)]
		protected new IGameplayPose3Interact_SetValue PocoInterface;
	}
}
