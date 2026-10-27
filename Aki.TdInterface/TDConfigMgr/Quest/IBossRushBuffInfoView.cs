using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000EDE RID: 3806
	[NullableContext(1)]
	[Nullable(0)]
	public class IBossRushBuffInfoView : IInformationViewType
	{
		// Token: 0x060053FE RID: 21502 RVA: 0x000CE5E0 File Offset: 0x000CC7E0
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

		// Token: 0x060053FF RID: 21503 RVA: 0x000CE618 File Offset: 0x000CC818
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

		// Token: 0x06005400 RID: 21504 RVA: 0x000CE62B File Offset: 0x000CC82B
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

		// Token: 0x06005401 RID: 21505 RVA: 0x000CE63E File Offset: 0x000CC83E
		public new IBossRushBuffInfoView_SetValue ToSetValue()
		{
			return new IBossRushBuffInfoView_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001C31 RID: 7217
		// (get) Token: 0x06005402 RID: 21506 RVA: 0x000CE651 File Offset: 0x000CC851
		// (set) Token: 0x06005403 RID: 21507 RVA: 0x000CE67C File Offset: 0x000CC87C
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

		// Token: 0x040032D7 RID: 13015
		[Nullable(2)]
		protected new IBossRushBuffInfoView FbInstance;

		// Token: 0x040032D8 RID: 13016
		[Nullable(2)]
		protected new IBossRushBuffInfoView_SetValue PocoInterface;
	}
}
