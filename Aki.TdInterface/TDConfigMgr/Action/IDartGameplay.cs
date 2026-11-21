using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AF3 RID: 6899
	public class IDartGameplay : IUiGame
	{
		// Token: 0x06009289 RID: 37513 RVA: 0x001574BC File Offset: 0x001556BC
		private IDartGameplay_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDartGameplay 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDartGameplay_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDartGameplay_SetValue());
			}
			return result;
		}

		// Token: 0x0600928A RID: 37514 RVA: 0x001574F4 File Offset: 0x001556F4
		public static IDartGameplay Create([Nullable(2)] IDartGameplay instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDartGameplay
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600928B RID: 37515 RVA: 0x00157507 File Offset: 0x00155707
		public static IDartGameplay CreateFromSetValue([Nullable(2)] IDartGameplay_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDartGameplay
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600928C RID: 37516 RVA: 0x0015751A File Offset: 0x0015571A
		public new IDartGameplay_SetValue ToSetValue()
		{
			return new IDartGameplay_SetValue
			{
				Type = this.Type,
				MachineEntityId = this.MachineEntityId,
				InteractType = this.InteractType
			};
		}

		// Token: 0x17002EE4 RID: 12004
		// (get) Token: 0x0600928D RID: 37517 RVA: 0x00157545 File Offset: 0x00155745
		// (set) Token: 0x0600928E RID: 37518 RVA: 0x00157570 File Offset: 0x00155770
		public override ESimpleGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESimpleGameplayType.Cipher;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002EE5 RID: 12005
		// (get) Token: 0x0600928F RID: 37519 RVA: 0x0015757E File Offset: 0x0015577E
		// (set) Token: 0x06009290 RID: 37520 RVA: 0x001575A9 File Offset: 0x001557A9
		public virtual int MachineEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MachineEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MachineEntityId;
			}
			set
			{
				this.GetOrCreatePoco().MachineEntityId = value;
			}
		}

		// Token: 0x17002EE6 RID: 12006
		// (get) Token: 0x06009291 RID: 37521 RVA: 0x001575B7 File Offset: 0x001557B7
		// (set) Token: 0x06009292 RID: 37522 RVA: 0x001575DE File Offset: 0x001557DE
		public virtual IDartInteractTypeBase InteractType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InteractType;
				}
				IDartGameplay_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.InteractType;
			}
			set
			{
				this.GetOrCreatePoco().InteractType = value;
			}
		}

		// Token: 0x04005B45 RID: 23365
		[Nullable(2)]
		protected new IDartGameplay FbInstance;

		// Token: 0x04005B46 RID: 23366
		[Nullable(2)]
		protected new IDartGameplay_SetValue PocoInterface;
	}
}
