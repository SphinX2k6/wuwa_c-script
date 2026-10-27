using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200119A RID: 4506
	[NullableContext(1)]
	[Nullable(0)]
	public class ITetrisSingleBlock
	{
		// Token: 0x06006650 RID: 26192 RVA: 0x000F53B0 File Offset: 0x000F35B0
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

		// Token: 0x06006651 RID: 26193 RVA: 0x000F53E8 File Offset: 0x000F35E8
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

		// Token: 0x06006652 RID: 26194 RVA: 0x000F53FB File Offset: 0x000F35FB
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

		// Token: 0x06006653 RID: 26195 RVA: 0x000F540E File Offset: 0x000F360E
		public ITetrisSingleBlock_SetValue ToSetValue()
		{
			return new ITetrisSingleBlock_SetValue
			{
				StyleName = this.StyleName
			};
		}

		// Token: 0x17002146 RID: 8518
		// (get) Token: 0x06006654 RID: 26196 RVA: 0x000F5421 File Offset: 0x000F3621
		// (set) Token: 0x06006655 RID: 26197 RVA: 0x000F544C File Offset: 0x000F364C
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

		// Token: 0x04003D63 RID: 15715
		[Nullable(2)]
		protected ITetrisSingleBlock FbInstance;

		// Token: 0x04003D64 RID: 15716
		[Nullable(2)]
		protected ITetrisSingleBlock_SetValue PocoInterface;
	}
}
