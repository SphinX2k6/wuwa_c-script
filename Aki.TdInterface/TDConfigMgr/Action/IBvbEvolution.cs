using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200182C RID: 6188
	[NullableContext(2)]
	[Nullable(0)]
	public class IBvbEvolution : IBvbPlayerOperationType
	{
		// Token: 0x060084CB RID: 33995 RVA: 0x0013C250 File Offset: 0x0013A450
		[NullableContext(1)]
		private IBvbEvolution_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBvbEvolution 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBvbEvolution_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBvbEvolution_SetValue());
			}
			return result;
		}

		// Token: 0x060084CC RID: 33996 RVA: 0x0013C288 File Offset: 0x0013A488
		[NullableContext(1)]
		public static IBvbEvolution Create([Nullable(2)] IBvbEvolution instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBvbEvolution
			{
				FbInstance = instance
			};
		}

		// Token: 0x060084CD RID: 33997 RVA: 0x0013C29B File Offset: 0x0013A49B
		[NullableContext(1)]
		public static IBvbEvolution CreateFromSetValue([Nullable(2)] IBvbEvolution_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBvbEvolution
			{
				PocoInterface = value
			};
		}

		// Token: 0x060084CE RID: 33998 RVA: 0x0013C2AE File Offset: 0x0013A4AE
		[NullableContext(1)]
		public new IBvbEvolution_SetValue ToSetValue()
		{
			return new IBvbEvolution_SetValue
			{
				Type = this.Type,
				HandCardIndex = this.HandCardIndex,
				BoardPosIndex = this.BoardPosIndex,
				BoardPosIndexList = this.BoardPosIndexList
			};
		}

		// Token: 0x17002B78 RID: 11128
		// (get) Token: 0x060084CF RID: 33999 RVA: 0x0013C2E5 File Offset: 0x0013A4E5
		// (set) Token: 0x060084D0 RID: 34000 RVA: 0x0013C310 File Offset: 0x0013A510
		public override EBvbPlayerOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EBvbPlayerOperationType.BvbDeploy;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002B79 RID: 11129
		// (get) Token: 0x060084D1 RID: 34001 RVA: 0x0013C320 File Offset: 0x0013A520
		// (set) Token: 0x060084D2 RID: 34002 RVA: 0x0013C35A File Offset: 0x0013A55A
		public virtual int? HandCardIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HandCardIndex;
				}
				IBvbEvolution_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.HandCardIndex;
			}
			set
			{
				this.GetOrCreatePoco().HandCardIndex = value;
			}
		}

		// Token: 0x17002B7A RID: 11130
		// (get) Token: 0x060084D3 RID: 34003 RVA: 0x0013C368 File Offset: 0x0013A568
		// (set) Token: 0x060084D4 RID: 34004 RVA: 0x0013C3A2 File Offset: 0x0013A5A2
		public virtual int? BoardPosIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BoardPosIndex;
				}
				IBvbEvolution_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.BoardPosIndex;
			}
			set
			{
				this.GetOrCreatePoco().BoardPosIndex = value;
			}
		}

		// Token: 0x17002B7B RID: 11131
		// (get) Token: 0x060084D5 RID: 34005 RVA: 0x0013C3B0 File Offset: 0x0013A5B0
		// (set) Token: 0x060084D6 RID: 34006 RVA: 0x0013C3D7 File Offset: 0x0013A5D7
		public virtual List<int> BoardPosIndexList
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BoardPosIndexList;
				}
				IBvbEvolution_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.BoardPosIndexList;
			}
			set
			{
				this.GetOrCreatePoco().BoardPosIndexList = value;
			}
		}

		// Token: 0x040053FB RID: 21499
		protected new IBvbEvolution FbInstance;

		// Token: 0x040053FC RID: 21500
		protected new IBvbEvolution_SetValue PocoInterface;
	}
}
