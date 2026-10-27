using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000719 RID: 1817
	[NullableContext(1)]
	[Nullable(0)]
	public class IStateRepPerfSkillId : IStateRepPerfBase
	{
		// Token: 0x06002713 RID: 10003 RVA: 0x00068104 File Offset: 0x00066304
		private IStateRepPerfSkillId_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IStateRepPerfSkillId 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IStateRepPerfSkillId_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IStateRepPerfSkillId_SetValue());
			}
			return result;
		}

		// Token: 0x06002714 RID: 10004 RVA: 0x0006813C File Offset: 0x0006633C
		public static IStateRepPerfSkillId Create([Nullable(2)] IStateRepPerfSkillId instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStateRepPerfSkillId
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002715 RID: 10005 RVA: 0x0006814F File Offset: 0x0006634F
		public static IStateRepPerfSkillId CreateFromSetValue([Nullable(2)] IStateRepPerfSkillId_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IStateRepPerfSkillId
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002716 RID: 10006 RVA: 0x00068162 File Offset: 0x00066362
		public new IStateRepPerfSkillId_SetValue ToSetValue()
		{
			return new IStateRepPerfSkillId_SetValue
			{
				Type = this.Type,
				SkillId = this.SkillId
			};
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x06002717 RID: 10007 RVA: 0x00068181 File Offset: 0x00066381
		// (set) Token: 0x06002718 RID: 10008 RVA: 0x000681AC File Offset: 0x000663AC
		public override EStateRepPerfType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EStateRepPerfType.SkillId;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x06002719 RID: 10009 RVA: 0x000681BA File Offset: 0x000663BA
		// (set) Token: 0x0600271A RID: 10010 RVA: 0x000681E6 File Offset: 0x000663E6
		public virtual long SkillId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SkillId;
				}
				if (this.PocoInterface == null)
				{
					return 0L;
				}
				return this.PocoInterface.SkillId;
			}
			set
			{
				this.GetOrCreatePoco().SkillId = value;
			}
		}

		// Token: 0x04001A60 RID: 6752
		[Nullable(2)]
		protected new IStateRepPerfSkillId FbInstance;

		// Token: 0x04001A61 RID: 6753
		[Nullable(2)]
		protected new IStateRepPerfSkillId_SetValue PocoInterface;
	}
}
