using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200133C RID: 4924
	public class IVisionSystemQuestSetActivated : IVisionSystemQuestBase
	{
		// Token: 0x06006ED3 RID: 28371 RVA: 0x001072F8 File Offset: 0x001054F8
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

		// Token: 0x06006ED4 RID: 28372 RVA: 0x00107330 File Offset: 0x00105530
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

		// Token: 0x06006ED5 RID: 28373 RVA: 0x00107343 File Offset: 0x00105543
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

		// Token: 0x06006ED6 RID: 28374 RVA: 0x00107356 File Offset: 0x00105556
		public new IVisionSystemQuestSetActivated_SetValue ToSetValue()
		{
			return new IVisionSystemQuestSetActivated_SetValue
			{
				Type = this.Type,
				SetType = this.SetType
			};
		}

		// Token: 0x1700238F RID: 9103
		// (get) Token: 0x06006ED7 RID: 28375 RVA: 0x00107375 File Offset: 0x00105575
		// (set) Token: 0x06006ED8 RID: 28376 RVA: 0x001073A0 File Offset: 0x001055A0
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

		// Token: 0x17002390 RID: 9104
		// (get) Token: 0x06006ED9 RID: 28377 RVA: 0x001073AE File Offset: 0x001055AE
		// (set) Token: 0x06006EDA RID: 28378 RVA: 0x001073D9 File Offset: 0x001055D9
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

		// Token: 0x04004207 RID: 16903
		[Nullable(2)]
		protected new IVisionSystemQuestSetActivated FbInstance;

		// Token: 0x04004208 RID: 16904
		[Nullable(2)]
		protected new IVisionSystemQuestSetActivated_SetValue PocoInterface;
	}
}
