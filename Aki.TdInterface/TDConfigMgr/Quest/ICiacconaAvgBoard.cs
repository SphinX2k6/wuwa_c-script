using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F10 RID: 3856
	[NullableContext(1)]
	[Nullable(0)]
	public class ICiacconaAvgBoard : IShowUi
	{
		// Token: 0x06005542 RID: 21826 RVA: 0x000D10F8 File Offset: 0x000CF2F8
		private ICiacconaAvgBoard_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICiacconaAvgBoard 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICiacconaAvgBoard_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICiacconaAvgBoard_SetValue());
			}
			return result;
		}

		// Token: 0x06005543 RID: 21827 RVA: 0x000D1130 File Offset: 0x000CF330
		public static ICiacconaAvgBoard Create([Nullable(2)] ICiacconaAvgBoard instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICiacconaAvgBoard
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005544 RID: 21828 RVA: 0x000D1143 File Offset: 0x000CF343
		public static ICiacconaAvgBoard CreateFromSetValue([Nullable(2)] ICiacconaAvgBoard_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICiacconaAvgBoard
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005545 RID: 21829 RVA: 0x000D1156 File Offset: 0x000CF356
		public new ICiacconaAvgBoard_SetValue ToSetValue()
		{
			return new ICiacconaAvgBoard_SetValue
			{
				Type = this.Type,
				EndingId = this.EndingId
			};
		}

		// Token: 0x17001C8A RID: 7306
		// (get) Token: 0x06005546 RID: 21830 RVA: 0x000D1175 File Offset: 0x000CF375
		// (set) Token: 0x06005547 RID: 21831 RVA: 0x000D11A0 File Offset: 0x000CF3A0
		public override EShowUiType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EShowUiType.All;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17001C8B RID: 7307
		// (get) Token: 0x06005548 RID: 21832 RVA: 0x000D11B0 File Offset: 0x000CF3B0
		// (set) Token: 0x06005549 RID: 21833 RVA: 0x000D11EA File Offset: 0x000CF3EA
		public virtual int? EndingId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EndingId;
				}
				ICiacconaAvgBoard_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EndingId;
			}
			set
			{
				this.GetOrCreatePoco().EndingId = value;
			}
		}

		// Token: 0x0400339D RID: 13213
		[Nullable(2)]
		protected new ICiacconaAvgBoard FbInstance;

		// Token: 0x0400339E RID: 13214
		[Nullable(2)]
		protected new ICiacconaAvgBoard_SetValue PocoInterface;
	}
}
