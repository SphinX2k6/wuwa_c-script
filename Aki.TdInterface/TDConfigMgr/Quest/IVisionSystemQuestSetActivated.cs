using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001200 RID: 4608
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisionSystemQuestSetActivated : IVisionSystemQuestBase
	{
		// Token: 0x06006892 RID: 26770 RVA: 0x000F99EC File Offset: 0x000F7BEC
		private IVisionSystemQuestSetActivated_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisionSystemQuestSetActivated 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisionSystemQuestSetActivated_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisionSystemQuestSetActivated_SetValue());
			}
			return result;
		}

		// Token: 0x06006893 RID: 26771 RVA: 0x000F9A24 File Offset: 0x000F7C24
		public static IVisionSystemQuestSetActivated Create([Nullable(2)] IVisionSystemQuestSetActivated instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisionSystemQuestSetActivated
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006894 RID: 26772 RVA: 0x000F9A37 File Offset: 0x000F7C37
		public static IVisionSystemQuestSetActivated CreateFromSetValue([Nullable(2)] IVisionSystemQuestSetActivated_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisionSystemQuestSetActivated
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006895 RID: 26773 RVA: 0x000F9A4A File Offset: 0x000F7C4A
		public new IVisionSystemQuestSetActivated_SetValue ToSetValue()
		{
			return new IVisionSystemQuestSetActivated_SetValue
			{
				Type = this.Type,
				SetType = this.SetType
			};
		}

		// Token: 0x170021CE RID: 8654
		// (get) Token: 0x06006896 RID: 26774 RVA: 0x000F9A69 File Offset: 0x000F7C69
		// (set) Token: 0x06006897 RID: 26775 RVA: 0x000F9A94 File Offset: 0x000F7C94
		public override EVisionSystemQuestType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVisionSystemQuestType.HasVisionGetTargetLevel;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170021CF RID: 8655
		// (get) Token: 0x06006898 RID: 26776 RVA: 0x000F9AA2 File Offset: 0x000F7CA2
		// (set) Token: 0x06006899 RID: 26777 RVA: 0x000F9ACD File Offset: 0x000F7CCD
		public virtual EVisionSetType SetType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SetType;
				}
				if (this.PocoInterface == null)
				{
					return (EVisionSetType)0;
				}
				return this.PocoInterface.SetType;
			}
			set
			{
				this.GetOrCreatePoco().SetType = value;
			}
		}

		// Token: 0x04003E99 RID: 16025
		[Nullable(2)]
		protected new IVisionSystemQuestSetActivated FbInstance;

		// Token: 0x04003E9A RID: 16026
		[Nullable(2)]
		protected new IVisionSystemQuestSetActivated_SetValue PocoInterface;
	}
}
