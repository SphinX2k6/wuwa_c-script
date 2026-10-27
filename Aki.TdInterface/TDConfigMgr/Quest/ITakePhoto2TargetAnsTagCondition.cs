using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001178 RID: 4472
	[NullableContext(1)]
	[Nullable(0)]
	public class ITakePhoto2TargetAnsTagCondition
	{
		// Token: 0x06006598 RID: 26008 RVA: 0x000F3C68 File Offset: 0x000F1E68
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

		// Token: 0x06006599 RID: 26009 RVA: 0x000F3CA0 File Offset: 0x000F1EA0
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

		// Token: 0x0600659A RID: 26010 RVA: 0x000F3CB3 File Offset: 0x000F1EB3
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

		// Token: 0x0600659B RID: 26011 RVA: 0x000F3CC6 File Offset: 0x000F1EC6
		public ITakePhoto2TargetAnsTagCondition_SetValue ToSetValue()
		{
			return new ITakePhoto2TargetAnsTagCondition_SetValue
			{
				MontageTag = this.MontageTag
			};
		}

		// Token: 0x1700211D RID: 8477
		// (get) Token: 0x0600659C RID: 26012 RVA: 0x000F3CD9 File Offset: 0x000F1ED9
		// (set) Token: 0x0600659D RID: 26013 RVA: 0x000F3D04 File Offset: 0x000F1F04
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

		// Token: 0x04003CFA RID: 15610
		[Nullable(2)]
		protected ITakePhoto2TargetAnsTagCondition FbInstance;

		// Token: 0x04003CFB RID: 15611
		[Nullable(2)]
		protected ITakePhoto2TargetAnsTagCondition_SetValue PocoInterface;
	}
}
