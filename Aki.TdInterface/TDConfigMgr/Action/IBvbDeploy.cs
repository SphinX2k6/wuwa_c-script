using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001828 RID: 6184
	[NullableContext(2)]
	[Nullable(0)]
	public class IBvbDeploy : IBvbPlayerOperationType
	{
		// Token: 0x060084B5 RID: 33973 RVA: 0x0013BFEC File Offset: 0x0013A1EC
		[NullableContext(1)]
		private IBvbDeploy_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBvbDeploy 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBvbDeploy_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBvbDeploy_SetValue());
			}
			return result;
		}

		// Token: 0x060084B6 RID: 33974 RVA: 0x0013C024 File Offset: 0x0013A224
		[NullableContext(1)]
		public static IBvbDeploy Create([Nullable(2)] IBvbDeploy instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBvbDeploy
			{
				FbInstance = instance
			};
		}

		// Token: 0x060084B7 RID: 33975 RVA: 0x0013C037 File Offset: 0x0013A237
		[NullableContext(1)]
		public static IBvbDeploy CreateFromSetValue([Nullable(2)] IBvbDeploy_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBvbDeploy
			{
				PocoInterface = value
			};
		}

		// Token: 0x060084B8 RID: 33976 RVA: 0x0013C04A File Offset: 0x0013A24A
		[NullableContext(1)]
		public new IBvbDeploy_SetValue ToSetValue()
		{
			return new IBvbDeploy_SetValue
			{
				Type = this.Type,
				HandCardIndex = this.HandCardIndex,
				BoardPosIndex = this.BoardPosIndex,
				BoardPosIndexList = this.BoardPosIndexList
			};
		}

		// Token: 0x17002B73 RID: 11123
		// (get) Token: 0x060084B9 RID: 33977 RVA: 0x0013C081 File Offset: 0x0013A281
		// (set) Token: 0x060084BA RID: 33978 RVA: 0x0013C0AC File Offset: 0x0013A2AC
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

		// Token: 0x17002B74 RID: 11124
		// (get) Token: 0x060084BB RID: 33979 RVA: 0x0013C0BC File Offset: 0x0013A2BC
		// (set) Token: 0x060084BC RID: 33980 RVA: 0x0013C0F6 File Offset: 0x0013A2F6
		public virtual int? HandCardIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HandCardIndex;
				}
				IBvbDeploy_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17002B75 RID: 11125
		// (get) Token: 0x060084BD RID: 33981 RVA: 0x0013C104 File Offset: 0x0013A304
		// (set) Token: 0x060084BE RID: 33982 RVA: 0x0013C13E File Offset: 0x0013A33E
		public virtual int? BoardPosIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BoardPosIndex;
				}
				IBvbDeploy_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17002B76 RID: 11126
		// (get) Token: 0x060084BF RID: 33983 RVA: 0x0013C14C File Offset: 0x0013A34C
		// (set) Token: 0x060084C0 RID: 33984 RVA: 0x0013C173 File Offset: 0x0013A373
		public virtual List<int> BoardPosIndexList
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BoardPosIndexList;
				}
				IBvbDeploy_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x040053F2 RID: 21490
		protected new IBvbDeploy FbInstance;

		// Token: 0x040053F3 RID: 21491
		protected new IBvbDeploy_SetValue PocoInterface;
	}
}
