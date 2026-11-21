using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002191 RID: 8593
	public class ITalkItemStyleInnerVoice : ITalkItemStyle
	{
		// Token: 0x0600B998 RID: 47512 RVA: 0x001A9334 File Offset: 0x001A7534
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

		// Token: 0x0600B999 RID: 47513 RVA: 0x001A936C File Offset: 0x001A756C
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

		// Token: 0x0600B99A RID: 47514 RVA: 0x001A937F File Offset: 0x001A757F
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

		// Token: 0x0600B99B RID: 47515 RVA: 0x001A9392 File Offset: 0x001A7592
		public new ITalkItemStyleInnerVoice_SetValue ToSetValue()
		{
			return new ITalkItemStyleInnerVoice_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003882 RID: 14466
		// (get) Token: 0x0600B99C RID: 47516 RVA: 0x001A93A5 File Offset: 0x001A75A5
		// (set) Token: 0x0600B99D RID: 47517 RVA: 0x001A93D0 File Offset: 0x001A75D0
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

		// Token: 0x04006F13 RID: 28435
		[Nullable(2)]
		protected new ITalkItemStyleInnerVoice FbInstance;

		// Token: 0x04006F14 RID: 28436
		[Nullable(2)]
		protected new ITalkItemStyleInnerVoice_SetValue PocoInterface;
	}
}
