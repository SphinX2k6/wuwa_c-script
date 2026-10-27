using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011FE RID: 4606
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisionSystemQuestDoIdentify : IVisionSystemQuestBase
	{
		// Token: 0x0600688A RID: 26762 RVA: 0x000F9930 File Offset: 0x000F7B30
		private IVisionSystemQuestDoIdentify_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisionSystemQuestDoIdentify 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisionSystemQuestDoIdentify_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisionSystemQuestDoIdentify_SetValue());
			}
			return result;
		}

		// Token: 0x0600688B RID: 26763 RVA: 0x000F9968 File Offset: 0x000F7B68
		public static IVisionSystemQuestDoIdentify Create([Nullable(2)] IVisionSystemQuestDoIdentify instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisionSystemQuestDoIdentify
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600688C RID: 26764 RVA: 0x000F997B File Offset: 0x000F7B7B
		public static IVisionSystemQuestDoIdentify CreateFromSetValue([Nullable(2)] IVisionSystemQuestDoIdentify_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisionSystemQuestDoIdentify
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600688D RID: 26765 RVA: 0x000F998E File Offset: 0x000F7B8E
		public new IVisionSystemQuestDoIdentify_SetValue ToSetValue()
		{
			return new IVisionSystemQuestDoIdentify_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170021CD RID: 8653
		// (get) Token: 0x0600688E RID: 26766 RVA: 0x000F99A1 File Offset: 0x000F7BA1
		// (set) Token: 0x0600688F RID: 26767 RVA: 0x000F99CC File Offset: 0x000F7BCC
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

		// Token: 0x04003E96 RID: 16022
		[Nullable(2)]
		protected new IVisionSystemQuestDoIdentify FbInstance;

		// Token: 0x04003E97 RID: 16023
		[Nullable(2)]
		protected new IVisionSystemQuestDoIdentify_SetValue PocoInterface;
	}
}
