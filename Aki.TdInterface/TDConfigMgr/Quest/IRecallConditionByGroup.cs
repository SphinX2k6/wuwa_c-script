using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010DA RID: 4314
	[NullableContext(1)]
	[Nullable(0)]
	public class IRecallConditionByGroup : IRecallConditionBase
	{
		// Token: 0x06006192 RID: 24978 RVA: 0x000EB868 File Offset: 0x000E9A68
		private IRecallConditionByGroup_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRecallConditionByGroup 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRecallConditionByGroup_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRecallConditionByGroup_SetValue());
			}
			return result;
		}

		// Token: 0x06006193 RID: 24979 RVA: 0x000EB8A0 File Offset: 0x000E9AA0
		public static IRecallConditionByGroup Create([Nullable(2)] IRecallConditionByGroup instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRecallConditionByGroup
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006194 RID: 24980 RVA: 0x000EB8B3 File Offset: 0x000E9AB3
		public static IRecallConditionByGroup CreateFromSetValue([Nullable(2)] IRecallConditionByGroup_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRecallConditionByGroup
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006195 RID: 24981 RVA: 0x000EB8C6 File Offset: 0x000E9AC6
		public new IRecallConditionByGroup_SetValue ToSetValue()
		{
			return new IRecallConditionByGroup_SetValue
			{
				Type = this.Type,
				Operation = this.Operation,
				GroupIds = this.GroupIds
			};
		}

		// Token: 0x17002006 RID: 8198
		// (get) Token: 0x06006196 RID: 24982 RVA: 0x000EB8F1 File Offset: 0x000E9AF1
		// (set) Token: 0x06006197 RID: 24983 RVA: 0x000EB91C File Offset: 0x000E9B1C
		public override ERecallConditionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERecallConditionType.ByEntityType;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002007 RID: 8199
		// (get) Token: 0x06006198 RID: 24984 RVA: 0x000EB92A File Offset: 0x000E9B2A
		// (set) Token: 0x06006199 RID: 24985 RVA: 0x000EB955 File Offset: 0x000E9B55
		public override ERecallOperation Operation
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Operation;
				}
				if (this.PocoInterface == null)
				{
					return ERecallOperation.Include;
				}
				return this.PocoInterface.Operation;
			}
			set
			{
				this.GetOrCreatePoco().Operation = value;
			}
		}

		// Token: 0x17002008 RID: 8200
		// (get) Token: 0x0600619A RID: 24986 RVA: 0x000EB963 File Offset: 0x000E9B63
		// (set) Token: 0x0600619B RID: 24987 RVA: 0x000EB98A File Offset: 0x000E9B8A
		public virtual List<int> GroupIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GroupIds;
				}
				IRecallConditionByGroup_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.GroupIds;
			}
			set
			{
				this.GetOrCreatePoco().GroupIds = value;
			}
		}

		// Token: 0x04003AB7 RID: 15031
		[Nullable(2)]
		protected new IRecallConditionByGroup FbInstance;

		// Token: 0x04003AB8 RID: 15032
		[Nullable(2)]
		protected new IRecallConditionByGroup_SetValue PocoInterface;
	}
}
