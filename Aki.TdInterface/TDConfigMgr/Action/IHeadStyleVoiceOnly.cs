using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CA0 RID: 7328
	public class IHeadStyleVoiceOnly : IHeadStyle
	{
		// Token: 0x06009BA6 RID: 39846 RVA: 0x00167658 File Offset: 0x00165858
		private IHeadStyleVoiceOnly_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHeadStyleVoiceOnly 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHeadStyleVoiceOnly_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHeadStyleVoiceOnly_SetValue());
			}
			return result;
		}

		// Token: 0x06009BA7 RID: 39847 RVA: 0x00167690 File Offset: 0x00165890
		public static IHeadStyleVoiceOnly Create([Nullable(2)] IHeadStyleVoiceOnly instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHeadStyleVoiceOnly
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009BA8 RID: 39848 RVA: 0x001676A3 File Offset: 0x001658A3
		public static IHeadStyleVoiceOnly CreateFromSetValue([Nullable(2)] IHeadStyleVoiceOnly_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHeadStyleVoiceOnly
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009BA9 RID: 39849 RVA: 0x001676B6 File Offset: 0x001658B6
		public new IHeadStyleVoiceOnly_SetValue ToSetValue()
		{
			return new IHeadStyleVoiceOnly_SetValue
			{
				Type = this.Type,
				WhoId = this.WhoId
			};
		}

		// Token: 0x170030F0 RID: 12528
		// (get) Token: 0x06009BAA RID: 39850 RVA: 0x001676D5 File Offset: 0x001658D5
		// (set) Token: 0x06009BAB RID: 39851 RVA: 0x00167700 File Offset: 0x00165900
		public override EHeadStyle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHeadStyle.Normal;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170030F1 RID: 12529
		// (get) Token: 0x06009BAC RID: 39852 RVA: 0x0016770E File Offset: 0x0016590E
		// (set) Token: 0x06009BAD RID: 39853 RVA: 0x00167739 File Offset: 0x00165939
		public virtual int WhoId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.WhoId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.WhoId;
			}
			set
			{
				this.GetOrCreatePoco().WhoId = value;
			}
		}

		// Token: 0x04005F55 RID: 24405
		[Nullable(2)]
		protected new IHeadStyleVoiceOnly FbInstance;

		// Token: 0x04005F56 RID: 24406
		[Nullable(2)]
		protected new IHeadStyleVoiceOnly_SetValue PocoInterface;
	}
}
