using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012D4 RID: 4820
	public class ITetrisSingleBlock
	{
		// Token: 0x06006C87 RID: 27783 RVA: 0x00102B7C File Offset: 0x00100D7C
		private ITetrisSingleBlock_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITetrisSingleBlock 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITetrisSingleBlock_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITetrisSingleBlock_SetValue());
			}
			return result;
		}

		// Token: 0x06006C88 RID: 27784 RVA: 0x00102BB4 File Offset: 0x00100DB4
		public static ITetrisSingleBlock Create([Nullable(2)] ITetrisSingleBlock instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITetrisSingleBlock
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006C89 RID: 27785 RVA: 0x00102BC7 File Offset: 0x00100DC7
		public static ITetrisSingleBlock CreateFromSetValue([Nullable(2)] ITetrisSingleBlock_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITetrisSingleBlock
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006C8A RID: 27786 RVA: 0x00102BDA File Offset: 0x00100DDA
		public ITetrisSingleBlock_SetValue ToSetValue()
		{
			return new ITetrisSingleBlock_SetValue
			{
				StyleName = this.StyleName
			};
		}

		// Token: 0x17002305 RID: 8965
		// (get) Token: 0x06006C8B RID: 27787 RVA: 0x00102BED File Offset: 0x00100DED
		// (set) Token: 0x06006C8C RID: 27788 RVA: 0x00102C18 File Offset: 0x00100E18
		public virtual string StyleName
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StyleName;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.StyleName;
			}
			set
			{
				this.GetOrCreatePoco().StyleName = value;
			}
		}

		// Token: 0x040040CB RID: 16587
		[Nullable(2)]
		protected ITetrisSingleBlock FbInstance;

		// Token: 0x040040CC RID: 16588
		[Nullable(2)]
		protected ITetrisSingleBlock_SetValue PocoInterface;
	}
}
