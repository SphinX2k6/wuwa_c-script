using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001202 RID: 4610
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisionSystemQuestTargetLevel : IVisionSystemQuestBase
	{
		// Token: 0x0600689C RID: 26780 RVA: 0x000F9AEC File Offset: 0x000F7CEC
		private IVisionSystemQuestTargetLevel_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisionSystemQuestTargetLevel 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisionSystemQuestTargetLevel_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisionSystemQuestTargetLevel_SetValue());
			}
			return result;
		}

		// Token: 0x0600689D RID: 26781 RVA: 0x000F9B24 File Offset: 0x000F7D24
		public static IVisionSystemQuestTargetLevel Create([Nullable(2)] IVisionSystemQuestTargetLevel instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisionSystemQuestTargetLevel
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600689E RID: 26782 RVA: 0x000F9B37 File Offset: 0x000F7D37
		public static IVisionSystemQuestTargetLevel CreateFromSetValue([Nullable(2)] IVisionSystemQuestTargetLevel_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisionSystemQuestTargetLevel
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600689F RID: 26783 RVA: 0x000F9B4A File Offset: 0x000F7D4A
		public new IVisionSystemQuestTargetLevel_SetValue ToSetValue()
		{
			return new IVisionSystemQuestTargetLevel_SetValue
			{
				Type = this.Type,
				TargetLevel = this.TargetLevel
			};
		}

		// Token: 0x170021D0 RID: 8656
		// (get) Token: 0x060068A0 RID: 26784 RVA: 0x000F9B69 File Offset: 0x000F7D69
		// (set) Token: 0x060068A1 RID: 26785 RVA: 0x000F9B94 File Offset: 0x000F7D94
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

		// Token: 0x170021D1 RID: 8657
		// (get) Token: 0x060068A2 RID: 26786 RVA: 0x000F9BA2 File Offset: 0x000F7DA2
		// (set) Token: 0x060068A3 RID: 26787 RVA: 0x000F9BCD File Offset: 0x000F7DCD
		public virtual int TargetLevel
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetLevel;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TargetLevel;
			}
			set
			{
				this.GetOrCreatePoco().TargetLevel = value;
			}
		}

		// Token: 0x04003E9D RID: 16029
		[Nullable(2)]
		protected new IVisionSystemQuestTargetLevel FbInstance;

		// Token: 0x04003E9E RID: 16030
		[Nullable(2)]
		protected new IVisionSystemQuestTargetLevel_SetValue PocoInterface;
	}
}
