using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001ACD RID: 6861
	[NullableContext(1)]
	[Nullable(0)]
	public class IGameplayPose2Interact : ILeisureInteractType
	{
		// Token: 0x0600931C RID: 37660 RVA: 0x00155A00 File Offset: 0x00153C00
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

		// Token: 0x0600931D RID: 37661 RVA: 0x00155A38 File Offset: 0x00153C38
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

		// Token: 0x0600931E RID: 37662 RVA: 0x00155A4B File Offset: 0x00153C4B
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

		// Token: 0x0600931F RID: 37663 RVA: 0x00155A5E File Offset: 0x00153C5E
		public new IGameplayPose2Interact_SetValue ToSetValue()
		{
			return new IGameplayPose2Interact_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002EB0 RID: 11952
		// (get) Token: 0x06009320 RID: 37664 RVA: 0x00155A71 File Offset: 0x00153C71
		// (set) Token: 0x06009321 RID: 37665 RVA: 0x00155A9C File Offset: 0x00153C9C
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

		// Token: 0x04005A79 RID: 23161
		[Nullable(2)]
		protected new IGameplayPose2Interact FbInstance;

		// Token: 0x04005A7A RID: 23162
		[Nullable(2)]
		protected new IGameplayPose2Interact_SetValue PocoInterface;
	}
}
