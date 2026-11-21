using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001026 RID: 4134
	public class ICiacconaAvgBoard : IShowUi
	{
		// Token: 0x06005ABE RID: 23230 RVA: 0x000DD2A0 File Offset: 0x000DB4A0
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

		// Token: 0x06005ABF RID: 23231 RVA: 0x000DD2D8 File Offset: 0x000DB4D8
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

		// Token: 0x06005AC0 RID: 23232 RVA: 0x000DD2EB File Offset: 0x000DB4EB
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

		// Token: 0x06005AC1 RID: 23233 RVA: 0x000DD2FE File Offset: 0x000DB4FE
		public new ICiacconaAvgBoard_SetValue ToSetValue()
		{
			return new ICiacconaAvgBoard_SetValue
			{
				Type = this.Type,
				EndingId = this.EndingId
			};
		}

		// Token: 0x17001E22 RID: 7714
		// (get) Token: 0x06005AC2 RID: 23234 RVA: 0x000DD31D File Offset: 0x000DB51D
		// (set) Token: 0x06005AC3 RID: 23235 RVA: 0x000DD348 File Offset: 0x000DB548
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

		// Token: 0x17001E23 RID: 7715
		// (get) Token: 0x06005AC4 RID: 23236 RVA: 0x000DD358 File Offset: 0x000DB558
		// (set) Token: 0x06005AC5 RID: 23237 RVA: 0x000DD392 File Offset: 0x000DB592
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

		// Token: 0x040036AA RID: 13994
		[Nullable(2)]
		protected new ICiacconaAvgBoard FbInstance;

		// Token: 0x040036AB RID: 13995
		[Nullable(2)]
		protected new ICiacconaAvgBoard_SetValue PocoInterface;
	}
}
