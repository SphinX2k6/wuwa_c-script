using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C74 RID: 7284
	public class IGameplayPose2Interact : ILeisureInteractType
	{
		// Token: 0x06009ADA RID: 39642 RVA: 0x00166220 File Offset: 0x00164420
		private IGameplayPose2Interact_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGameplayPose2Interact 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGameplayPose2Interact_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGameplayPose2Interact_SetValue());
			}
			return result;
		}

		// Token: 0x06009ADB RID: 39643 RVA: 0x00166258 File Offset: 0x00164458
		public static IGameplayPose2Interact Create([Nullable(2)] IGameplayPose2Interact instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGameplayPose2Interact
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009ADC RID: 39644 RVA: 0x0016626B File Offset: 0x0016446B
		public static IGameplayPose2Interact CreateFromSetValue([Nullable(2)] IGameplayPose2Interact_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGameplayPose2Interact
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009ADD RID: 39645 RVA: 0x0016627E File Offset: 0x0016447E
		public new IGameplayPose2Interact_SetValue ToSetValue()
		{
			return new IGameplayPose2Interact_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170030CC RID: 12492
		// (get) Token: 0x06009ADE RID: 39646 RVA: 0x00166291 File Offset: 0x00164491
		// (set) Token: 0x06009ADF RID: 39647 RVA: 0x001662BC File Offset: 0x001644BC
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

		// Token: 0x04005F03 RID: 24323
		[Nullable(2)]
		protected new IGameplayPose2Interact FbInstance;

		// Token: 0x04005F04 RID: 24324
		[Nullable(2)]
		protected new IGameplayPose2Interact_SetValue PocoInterface;
	}
}
