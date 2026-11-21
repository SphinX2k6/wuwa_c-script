using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D0D RID: 7437
	public class IItemGetUiConfigSpecialQuest : IItemGetUiConfigBase
	{
		// Token: 0x06009DE7 RID: 40423 RVA: 0x0016B610 File Offset: 0x00169810
		private IItemGetUiConfigSpecialQuest_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IItemGetUiConfigSpecialQuest 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IItemGetUiConfigSpecialQuest_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IItemGetUiConfigSpecialQuest_SetValue());
			}
			return result;
		}

		// Token: 0x06009DE8 RID: 40424 RVA: 0x0016B648 File Offset: 0x00169848
		public static IItemGetUiConfigSpecialQuest Create([Nullable(2)] IItemGetUiConfigSpecialQuest instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IItemGetUiConfigSpecialQuest
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009DE9 RID: 40425 RVA: 0x0016B65B File Offset: 0x0016985B
		public static IItemGetUiConfigSpecialQuest CreateFromSetValue([Nullable(2)] IItemGetUiConfigSpecialQuest_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IItemGetUiConfigSpecialQuest
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009DEA RID: 40426 RVA: 0x0016B66E File Offset: 0x0016986E
		public new IItemGetUiConfigSpecialQuest_SetValue ToSetValue()
		{
			return new IItemGetUiConfigSpecialQuest_SetValue
			{
				Type = this.Type,
				Title = this.Title,
				ShowDetail = this.ShowDetail
			};
		}

		// Token: 0x1700316E RID: 12654
		// (get) Token: 0x06009DEB RID: 40427 RVA: 0x0016B699 File Offset: 0x00169899
		// (set) Token: 0x06009DEC RID: 40428 RVA: 0x0016B6C4 File Offset: 0x001698C4
		public override EItemGetUiType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return (EItemGetUiType)0;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700316F RID: 12655
		// (get) Token: 0x06009DED RID: 40429 RVA: 0x0016B6D2 File Offset: 0x001698D2
		// (set) Token: 0x06009DEE RID: 40430 RVA: 0x0016B6F9 File Offset: 0x001698F9
		[Nullable(2)]
		public virtual string Title
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Title;
				}
				IItemGetUiConfigSpecialQuest_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Title;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().Title = value;
			}
		}

		// Token: 0x17003170 RID: 12656
		// (get) Token: 0x06009DEF RID: 40431 RVA: 0x0016B708 File Offset: 0x00169908
		// (set) Token: 0x06009DF0 RID: 40432 RVA: 0x0016B742 File Offset: 0x00169942
		public virtual bool? ShowDetail
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ShowDetail;
				}
				IItemGetUiConfigSpecialQuest_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ShowDetail;
			}
			set
			{
				this.GetOrCreatePoco().ShowDetail = value;
			}
		}

		// Token: 0x0400605B RID: 24667
		[Nullable(2)]
		protected new IItemGetUiConfigSpecialQuest FbInstance;

		// Token: 0x0400605C RID: 24668
		[Nullable(2)]
		protected new IItemGetUiConfigSpecialQuest_SetValue PocoInterface;
	}
}
