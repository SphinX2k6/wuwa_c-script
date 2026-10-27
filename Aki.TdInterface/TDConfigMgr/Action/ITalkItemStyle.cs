using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F56 RID: 8022
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkItemStyle
	{
		// Token: 0x0600AEBE RID: 44734 RVA: 0x00193280 File Offset: 0x00191480
		private ITalkItemStyle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkItemStyle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkItemStyle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkItemStyle_SetValue());
			}
			return result;
		}

		// Token: 0x0600AEBF RID: 44735 RVA: 0x001932B8 File Offset: 0x001914B8
		public static ITalkItemStyle Create([Nullable(2)] ITalkItemStyle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemStyle
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AEC0 RID: 44736 RVA: 0x001932CB File Offset: 0x001914CB
		public static ITalkItemStyle CreateFromSetValue([Nullable(2)] ITalkItemStyle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkItemStyle
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AEC1 RID: 44737 RVA: 0x001932DE File Offset: 0x001914DE
		public ITalkItemStyle_SetValue ToSetValue()
		{
			return new ITalkItemStyle_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170035B6 RID: 13750
		// (get) Token: 0x0600AEC2 RID: 44738 RVA: 0x001932F1 File Offset: 0x001914F1
		// (set) Token: 0x0600AEC3 RID: 44739 RVA: 0x0019331C File Offset: 0x0019151C
		public virtual ETalkItemStyle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETalkItemStyle.InnerVoice;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006921 RID: 26913
		[Nullable(2)]
		protected ITalkItemStyle FbInstance;

		// Token: 0x04006922 RID: 26914
		[Nullable(2)]
		protected ITalkItemStyle_SetValue PocoInterface;
	}
}
