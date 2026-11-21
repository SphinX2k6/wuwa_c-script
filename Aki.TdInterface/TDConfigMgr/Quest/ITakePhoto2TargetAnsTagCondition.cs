using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012B2 RID: 4786
	public class ITakePhoto2TargetAnsTagCondition
	{
		// Token: 0x06006BCF RID: 27599 RVA: 0x00101434 File Offset: 0x000FF634
		private ITakePhoto2TargetAnsTagCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITakePhoto2TargetAnsTagCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITakePhoto2TargetAnsTagCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITakePhoto2TargetAnsTagCondition_SetValue());
			}
			return result;
		}

		// Token: 0x06006BD0 RID: 27600 RVA: 0x0010146C File Offset: 0x000FF66C
		public static ITakePhoto2TargetAnsTagCondition Create([Nullable(2)] ITakePhoto2TargetAnsTagCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITakePhoto2TargetAnsTagCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006BD1 RID: 27601 RVA: 0x0010147F File Offset: 0x000FF67F
		public static ITakePhoto2TargetAnsTagCondition CreateFromSetValue([Nullable(2)] ITakePhoto2TargetAnsTagCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITakePhoto2TargetAnsTagCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006BD2 RID: 27602 RVA: 0x00101492 File Offset: 0x000FF692
		public ITakePhoto2TargetAnsTagCondition_SetValue ToSetValue()
		{
			return new ITakePhoto2TargetAnsTagCondition_SetValue
			{
				MontageTag = this.MontageTag
			};
		}

		// Token: 0x170022DC RID: 8924
		// (get) Token: 0x06006BD3 RID: 27603 RVA: 0x001014A5 File Offset: 0x000FF6A5
		// (set) Token: 0x06006BD4 RID: 27604 RVA: 0x001014D0 File Offset: 0x000FF6D0
		public virtual string MontageTag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MontageTag;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.MontageTag;
			}
			set
			{
				this.GetOrCreatePoco().MontageTag = value;
			}
		}

		// Token: 0x04004062 RID: 16482
		[Nullable(2)]
		protected ITakePhoto2TargetAnsTagCondition FbInstance;

		// Token: 0x04004063 RID: 16483
		[Nullable(2)]
		protected ITakePhoto2TargetAnsTagCondition_SetValue PocoInterface;
	}
}
