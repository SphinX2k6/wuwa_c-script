using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200188C RID: 6284
	public class ExecResurrection : ActionParams
	{
		// Token: 0x060083F5 RID: 33781 RVA: 0x0013B5E4 File Offset: 0x001397E4
		private ExecResurrection_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ExecResurrection 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ExecResurrection_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ExecResurrection_SetValue());
			}
			return result;
		}

		// Token: 0x060083F6 RID: 33782 RVA: 0x0013B61C File Offset: 0x0013981C
		public static ExecResurrection Create([Nullable(2)] ExecResurrection instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ExecResurrection
			{
				FbInstance = instance
			};
		}

		// Token: 0x060083F7 RID: 33783 RVA: 0x0013B62F File Offset: 0x0013982F
		public static ExecResurrection CreateFromSetValue([Nullable(2)] ExecResurrection_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ExecResurrection
			{
				PocoInterface = value
			};
		}

		// Token: 0x060083F8 RID: 33784 RVA: 0x0013B642 File Offset: 0x00139842
		public ExecResurrection_SetValue ToSetValue()
		{
			return new ExecResurrection_SetValue
			{
				ReviveId = this.ReviveId
			};
		}

		// Token: 0x17002B2F RID: 11055
		// (get) Token: 0x060083F9 RID: 33785 RVA: 0x0013B655 File Offset: 0x00139855
		// (set) Token: 0x060083FA RID: 33786 RVA: 0x0013B680 File Offset: 0x00139880
		public virtual int ReviveId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ReviveId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ReviveId;
			}
			set
			{
				this.GetOrCreatePoco().ReviveId = value;
			}
		}

		// Token: 0x04005411 RID: 21521
		[Nullable(2)]
		protected new ExecResurrection FbInstance;

		// Token: 0x04005412 RID: 21522
		[Nullable(2)]
		protected ExecResurrection_SetValue PocoInterface;
	}
}
