using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D74 RID: 7540
	[NullableContext(1)]
	[Nullable(0)]
	public class IQiuyuanQinggongExploration4 : ILeisureInteractType
	{
		// Token: 0x0600A1A1 RID: 41377 RVA: 0x00170080 File Offset: 0x0016E280
		private IQiuyuanQinggongExploration4_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQiuyuanQinggongExploration4 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQiuyuanQinggongExploration4_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQiuyuanQinggongExploration4_SetValue());
			}
			return result;
		}

		// Token: 0x0600A1A2 RID: 41378 RVA: 0x001700B8 File Offset: 0x0016E2B8
		public static IQiuyuanQinggongExploration4 Create([Nullable(2)] IQiuyuanQinggongExploration4 instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQiuyuanQinggongExploration4
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A1A3 RID: 41379 RVA: 0x001700CB File Offset: 0x0016E2CB
		public static IQiuyuanQinggongExploration4 CreateFromSetValue([Nullable(2)] IQiuyuanQinggongExploration4_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQiuyuanQinggongExploration4
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A1A4 RID: 41380 RVA: 0x001700DE File Offset: 0x0016E2DE
		public new IQiuyuanQinggongExploration4_SetValue ToSetValue()
		{
			return new IQiuyuanQinggongExploration4_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170031F9 RID: 12793
		// (get) Token: 0x0600A1A5 RID: 41381 RVA: 0x001700F1 File Offset: 0x0016E2F1
		// (set) Token: 0x0600A1A6 RID: 41382 RVA: 0x0017011C File Offset: 0x0016E31C
		public override ELeisureInteract Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELeisureInteract.CustomSkill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006136 RID: 24886
		[Nullable(2)]
		protected new IQiuyuanQinggongExploration4 FbInstance;

		// Token: 0x04006137 RID: 24887
		[Nullable(2)]
		protected new IQiuyuanQinggongExploration4_SetValue PocoInterface;
	}
}
