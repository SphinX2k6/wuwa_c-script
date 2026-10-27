using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F86 RID: 8070
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkOptionVisualNovel : ITalkOptionParamType
	{
		// Token: 0x0600B184 RID: 45444 RVA: 0x0019E364 File Offset: 0x0019C564
		private ITalkOptionVisualNovel_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkOptionVisualNovel 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkOptionVisualNovel_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkOptionVisualNovel_SetValue());
			}
			return result;
		}

		// Token: 0x0600B185 RID: 45445 RVA: 0x0019E39C File Offset: 0x0019C59C
		public static ITalkOptionVisualNovel Create([Nullable(2)] ITalkOptionVisualNovel instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOptionVisualNovel
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B186 RID: 45446 RVA: 0x0019E3AF File Offset: 0x0019C5AF
		public static ITalkOptionVisualNovel CreateFromSetValue([Nullable(2)] ITalkOptionVisualNovel_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkOptionVisualNovel
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B187 RID: 45447 RVA: 0x0019E3C2 File Offset: 0x0019C5C2
		public new ITalkOptionVisualNovel_SetValue ToSetValue()
		{
			return new ITalkOptionVisualNovel_SetValue
			{
				Type = this.Type,
				PlotOptionId = this.PlotOptionId,
				OptionPerformances = this.OptionPerformances
			};
		}

		// Token: 0x170036D1 RID: 14033
		// (get) Token: 0x0600B188 RID: 45448 RVA: 0x0019E3ED File Offset: 0x0019C5ED
		// (set) Token: 0x0600B189 RID: 45449 RVA: 0x0019E418 File Offset: 0x0019C618
		public override ETalkOptionParamType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETalkOptionParamType.QteSucceed;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170036D2 RID: 14034
		// (get) Token: 0x0600B18A RID: 45450 RVA: 0x0019E428 File Offset: 0x0019C628
		// (set) Token: 0x0600B18B RID: 45451 RVA: 0x0019E462 File Offset: 0x0019C662
		public virtual int? PlotOptionId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PlotOptionId;
				}
				ITalkOptionVisualNovel_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PlotOptionId;
			}
			set
			{
				this.GetOrCreatePoco().PlotOptionId = value;
			}
		}

		// Token: 0x170036D3 RID: 14035
		// (get) Token: 0x0600B18C RID: 45452 RVA: 0x0019E470 File Offset: 0x0019C670
		// (set) Token: 0x0600B18D RID: 45453 RVA: 0x0019E497 File Offset: 0x0019C697
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IVisualNovelPerformanceBase> OptionPerformances
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.OptionPerformances;
				}
				ITalkOptionVisualNovel_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.OptionPerformances;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().OptionPerformances = value;
			}
		}

		// Token: 0x04006B56 RID: 27478
		[Nullable(2)]
		protected new ITalkOptionVisualNovel FbInstance;

		// Token: 0x04006B57 RID: 27479
		[Nullable(2)]
		protected new ITalkOptionVisualNovel_SetValue PocoInterface;
	}
}
