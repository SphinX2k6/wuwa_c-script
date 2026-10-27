using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001023 RID: 4131
	[NullableContext(1)]
	[Nullable(0)]
	public class IMowBuffDistribute : IShowUi
	{
		// Token: 0x06005C2A RID: 23594 RVA: 0x000DF57C File Offset: 0x000DD77C
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

		// Token: 0x06005C2B RID: 23595 RVA: 0x000DF5B4 File Offset: 0x000DD7B4
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

		// Token: 0x06005C2C RID: 23596 RVA: 0x000DF5C7 File Offset: 0x000DD7C7
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

		// Token: 0x06005C2D RID: 23597 RVA: 0x000DF5DA File Offset: 0x000DD7DA
		public new IMowBuffDistribute_SetValue ToSetValue()
		{
			return new IMowBuffDistribute_SetValue
			{
				Type = this.Type,
				BoardId = this.BoardId
			};
		}

		// Token: 0x17001E62 RID: 7778
		// (get) Token: 0x06005C2E RID: 23598 RVA: 0x000DF5F9 File Offset: 0x000DD7F9
		// (set) Token: 0x06005C2F RID: 23599 RVA: 0x000DF624 File Offset: 0x000DD824
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

		// Token: 0x17001E63 RID: 7779
		// (get) Token: 0x06005C30 RID: 23600 RVA: 0x000DF632 File Offset: 0x000DD832
		// (set) Token: 0x06005C31 RID: 23601 RVA: 0x000DF65D File Offset: 0x000DD85D
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

		// Token: 0x04003775 RID: 14197
		[Nullable(2)]
		protected new IMowBuffDistribute FbInstance;

		// Token: 0x04003776 RID: 14198
		[Nullable(2)]
		protected new IMowBuffDistribute_SetValue PocoInterface;
	}
}
