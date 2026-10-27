using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001968 RID: 6504
	[NullableContext(1)]
	[Nullable(0)]
	public class IDartGameplay : IUiGame
	{
		// Token: 0x06008B53 RID: 35667 RVA: 0x00147A80 File Offset: 0x00145C80
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

		// Token: 0x06008B54 RID: 35668 RVA: 0x00147AB8 File Offset: 0x00145CB8
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

		// Token: 0x06008B55 RID: 35669 RVA: 0x00147ACB File Offset: 0x00145CCB
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

		// Token: 0x06008B56 RID: 35670 RVA: 0x00147ADE File Offset: 0x00145CDE
		public new IDartGameplay_SetValue ToSetValue()
		{
			return new IDartGameplay_SetValue
			{
				Type = this.Type,
				MachineEntityId = this.MachineEntityId,
				InteractType = this.InteractType
			};
		}

		// Token: 0x17002CE2 RID: 11490
		// (get) Token: 0x06008B57 RID: 35671 RVA: 0x00147B09 File Offset: 0x00145D09
		// (set) Token: 0x06008B58 RID: 35672 RVA: 0x00147B34 File Offset: 0x00145D34
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

		// Token: 0x17002CE3 RID: 11491
		// (get) Token: 0x06008B59 RID: 35673 RVA: 0x00147B42 File Offset: 0x00145D42
		// (set) Token: 0x06008B5A RID: 35674 RVA: 0x00147B6D File Offset: 0x00145D6D
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

		// Token: 0x17002CE4 RID: 11492
		// (get) Token: 0x06008B5B RID: 35675 RVA: 0x00147B7B File Offset: 0x00145D7B
		// (set) Token: 0x06008B5C RID: 35676 RVA: 0x00147BA2 File Offset: 0x00145DA2
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

		// Token: 0x040056F1 RID: 22257
		[Nullable(2)]
		protected new IDartGameplay FbInstance;

		// Token: 0x040056F2 RID: 22258
		[Nullable(2)]
		protected new IDartGameplay_SetValue PocoInterface;
	}
}
