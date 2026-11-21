using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001643 RID: 5699
	public class ChangeTeamPosition : ActionParams
	{
		// Token: 0x0600809F RID: 32927 RVA: 0x00132110 File Offset: 0x00130310
		private ChangeTeamPosition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ChangeTeamPosition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ChangeTeamPosition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ChangeTeamPosition_SetValue());
			}
			return result;
		}

		// Token: 0x060080A0 RID: 32928 RVA: 0x00132148 File Offset: 0x00130348
		public static ChangeTeamPosition Create([Nullable(2)] ChangeTeamPosition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeTeamPosition
			{
				FbInstance = instance
			};
		}

		// Token: 0x060080A1 RID: 32929 RVA: 0x0013215B File Offset: 0x0013035B
		public static ChangeTeamPosition CreateFromSetValue([Nullable(2)] ChangeTeamPosition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ChangeTeamPosition
			{
				PocoInterface = value
			};
		}

		// Token: 0x060080A2 RID: 32930 RVA: 0x0013216E File Offset: 0x0013036E
		public ChangeTeamPosition_SetValue ToSetValue()
		{
			return new ChangeTeamPosition_SetValue
			{
				PositionId = this.PositionId,
				TeamType = this.TeamType
			};
		}

		// Token: 0x17002AAA RID: 10922
		// (get) Token: 0x060080A3 RID: 32931 RVA: 0x0013218D File Offset: 0x0013038D
		// (set) Token: 0x060080A4 RID: 32932 RVA: 0x001321B8 File Offset: 0x001303B8
		public virtual int PositionId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PositionId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.PositionId;
			}
			set
			{
				this.GetOrCreatePoco().PositionId = value;
			}
		}

		// Token: 0x17002AAB RID: 10923
		// (get) Token: 0x060080A5 RID: 32933 RVA: 0x001321C6 File Offset: 0x001303C6
		// (set) Token: 0x060080A6 RID: 32934 RVA: 0x001321ED File Offset: 0x001303ED
		[Nullable(2)]
		public virtual ITeamType TeamType
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TeamType;
				}
				ChangeTeamPosition_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TeamType;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().TeamType = value;
			}
		}

		// Token: 0x04004A3E RID: 19006
		[Nullable(2)]
		protected new ChangeTeamPosition FbInstance;

		// Token: 0x04004A3F RID: 19007
		[Nullable(2)]
		protected ChangeTeamPosition_SetValue PocoInterface;
	}
}
