using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FF4 RID: 4084
	public class IBossRushBuffInfoView : IInformationViewType
	{
		// Token: 0x0600597A RID: 22906 RVA: 0x000DA788 File Offset: 0x000D8988
		private IBossRushBuffInfoView_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBossRushBuffInfoView 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBossRushBuffInfoView_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBossRushBuffInfoView_SetValue());
			}
			return result;
		}

		// Token: 0x0600597B RID: 22907 RVA: 0x000DA7C0 File Offset: 0x000D89C0
		public static IBossRushBuffInfoView Create([Nullable(2)] IBossRushBuffInfoView instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBossRushBuffInfoView
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600597C RID: 22908 RVA: 0x000DA7D3 File Offset: 0x000D89D3
		public static IBossRushBuffInfoView CreateFromSetValue([Nullable(2)] IBossRushBuffInfoView_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBossRushBuffInfoView
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600597D RID: 22909 RVA: 0x000DA7E6 File Offset: 0x000D89E6
		public new IBossRushBuffInfoView_SetValue ToSetValue()
		{
			return new IBossRushBuffInfoView_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001DC9 RID: 7625
		// (get) Token: 0x0600597E RID: 22910 RVA: 0x000DA7F9 File Offset: 0x000D89F9
		// (set) Token: 0x0600597F RID: 22911 RVA: 0x000DA824 File Offset: 0x000D8A24
		public override EInformationViewType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInformationViewType.LevelPlay;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040035E4 RID: 13796
		[Nullable(2)]
		protected new IBossRushBuffInfoView FbInstance;

		// Token: 0x040035E5 RID: 13797
		[Nullable(2)]
		protected new IBossRushBuffInfoView_SetValue PocoInterface;
	}
}
