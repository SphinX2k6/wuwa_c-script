using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200114F RID: 4431
	public class IMowBuffDistribute : IShowUi
	{
		// Token: 0x0600620C RID: 25100 RVA: 0x000EC274 File Offset: 0x000EA474
		private IMowBuffDistribute_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMowBuffDistribute 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMowBuffDistribute_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMowBuffDistribute_SetValue());
			}
			return result;
		}

		// Token: 0x0600620D RID: 25101 RVA: 0x000EC2AC File Offset: 0x000EA4AC
		public static IMowBuffDistribute Create([Nullable(2)] IMowBuffDistribute instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMowBuffDistribute
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600620E RID: 25102 RVA: 0x000EC2BF File Offset: 0x000EA4BF
		public static IMowBuffDistribute CreateFromSetValue([Nullable(2)] IMowBuffDistribute_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMowBuffDistribute
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600620F RID: 25103 RVA: 0x000EC2D2 File Offset: 0x000EA4D2
		public new IMowBuffDistribute_SetValue ToSetValue()
		{
			return new IMowBuffDistribute_SetValue
			{
				Type = this.Type,
				BoardId = this.BoardId
			};
		}

		// Token: 0x1700200C RID: 8204
		// (get) Token: 0x06006210 RID: 25104 RVA: 0x000EC2F1 File Offset: 0x000EA4F1
		// (set) Token: 0x06006211 RID: 25105 RVA: 0x000EC31C File Offset: 0x000EA51C
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

		// Token: 0x1700200D RID: 8205
		// (get) Token: 0x06006212 RID: 25106 RVA: 0x000EC32A File Offset: 0x000EA52A
		// (set) Token: 0x06006213 RID: 25107 RVA: 0x000EC355 File Offset: 0x000EA555
		public virtual int BoardId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BoardId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.BoardId;
			}
			set
			{
				this.GetOrCreatePoco().BoardId = value;
			}
		}

		// Token: 0x04003AB0 RID: 15024
		[Nullable(2)]
		protected new IMowBuffDistribute FbInstance;

		// Token: 0x04003AB1 RID: 15025
		[Nullable(2)]
		protected new IMowBuffDistribute_SetValue PocoInterface;
	}
}
