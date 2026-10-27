using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F58 RID: 8024
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkItemStyleInnerVoice : ITalkItemStyle
	{
		// Token: 0x0600AEC6 RID: 44742 RVA: 0x0019333C File Offset: 0x0019153C
		private ITalkItemStyleInnerVoice_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkItemStyleInnerVoice 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkItemStyleInnerVoice_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkItemStyleInnerVoice_SetValue());
			}
			return result;
		}

		// Token: 0x0600AEC7 RID: 44743 RVA: 0x00193374 File Offset: 0x00191574
		public static ITalkItemStyleInnerVoice Create([Nullable(2)] ITalkItemStyleInnerVoice instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemStyleInnerVoice
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AEC8 RID: 44744 RVA: 0x00193387 File Offset: 0x00191587
		public static ITalkItemStyleInnerVoice CreateFromSetValue([Nullable(2)] ITalkItemStyleInnerVoice_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkItemStyleInnerVoice
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AEC9 RID: 44745 RVA: 0x0019339A File Offset: 0x0019159A
		public new ITalkItemStyleInnerVoice_SetValue ToSetValue()
		{
			return new ITalkItemStyleInnerVoice_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170035B7 RID: 13751
		// (get) Token: 0x0600AECA RID: 44746 RVA: 0x001933AD File Offset: 0x001915AD
		// (set) Token: 0x0600AECB RID: 44747 RVA: 0x001933D8 File Offset: 0x001915D8
		public override ETalkItemStyle Type
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

		// Token: 0x04006924 RID: 26916
		[Nullable(2)]
		protected new ITalkItemStyleInnerVoice FbInstance;

		// Token: 0x04006925 RID: 26917
		[Nullable(2)]
		protected new ITalkItemStyleInnerVoice_SetValue PocoInterface;
	}
}
