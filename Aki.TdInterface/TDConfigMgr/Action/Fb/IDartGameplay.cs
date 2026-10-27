using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002874 RID: 10356
	[NullableContext(1)]
	[Nullable(0)]
	public class IDartGameplay : IUiGame
	{
		// Token: 0x0600E573 RID: 58739 RVA: 0x0021BBBC File Offset: 0x00219DBC
		public static IDartGameplay Create(IDartGameplay? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDartGameplay
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700464D RID: 17997
		// (get) Token: 0x0600E574 RID: 58740 RVA: 0x0021BBDB File Offset: 0x00219DDB
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x1700464E RID: 17998
		// (get) Token: 0x0600E575 RID: 58741 RVA: 0x0021BBE8 File Offset: 0x00219DE8
		public virtual int MachineEntityId
		{
			get
			{
				return this.Instance.MachineEntityId;
			}
		}

		// Token: 0x1700464F RID: 17999
		// (get) Token: 0x0600E576 RID: 58742 RVA: 0x0021BBF5 File Offset: 0x00219DF5
		public virtual IDartInteractTypeBase InteractType
		{
			get
			{
				if (this._InteractTypeInited)
				{
					return this._InteractTypeCache;
				}
				this._InteractTypeInited = true;
				this._InteractTypeCache = ActionReadHelper.ReadIDartGameplay_InteractType(this.Instance);
				return this._InteractTypeCache;
			}
		}

		// Token: 0x04007EDC RID: 32476
		private IDartGameplay Instance;

		// Token: 0x04007EDD RID: 32477
		private IDartInteractTypeBase _InteractTypeCache;

		// Token: 0x04007EDE RID: 32478
		private bool _InteractTypeInited;
	}
}
