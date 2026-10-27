using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014EA RID: 5354
	[NullableContext(1)]
	[Nullable(0)]
	public class ChangeTeamPosition : ActionParams
	{
		// Token: 0x060079D2 RID: 31186 RVA: 0x001234C4 File Offset: 0x001216C4
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

		// Token: 0x060079D3 RID: 31187 RVA: 0x001234FC File Offset: 0x001216FC
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

		// Token: 0x060079D4 RID: 31188 RVA: 0x0012350F File Offset: 0x0012170F
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

		// Token: 0x060079D5 RID: 31189 RVA: 0x00123522 File Offset: 0x00121722
		public ChangeTeamPosition_SetValue ToSetValue()
		{
			return new ChangeTeamPosition_SetValue
			{
				PositionId = this.PositionId,
				RestoreToPrevious = this.RestoreToPrevious
			};
		}

		// Token: 0x170028C0 RID: 10432
		// (get) Token: 0x060079D6 RID: 31190 RVA: 0x00123541 File Offset: 0x00121741
		// (set) Token: 0x060079D7 RID: 31191 RVA: 0x0012356C File Offset: 0x0012176C
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

		// Token: 0x170028C1 RID: 10433
		// (get) Token: 0x060079D8 RID: 31192 RVA: 0x0012357C File Offset: 0x0012177C
		// (set) Token: 0x060079D9 RID: 31193 RVA: 0x001235B6 File Offset: 0x001217B6
		public virtual bool? RestoreToPrevious
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RestoreToPrevious;
				}
				ChangeTeamPosition_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.RestoreToPrevious;
			}
			set
			{
				this.GetOrCreatePoco().RestoreToPrevious = value;
			}
		}

		// Token: 0x040046A3 RID: 18083
		[Nullable(2)]
		protected new ChangeTeamPosition FbInstance;

		// Token: 0x040046A4 RID: 18084
		[Nullable(2)]
		protected ChangeTeamPosition_SetValue PocoInterface;
	}
}
