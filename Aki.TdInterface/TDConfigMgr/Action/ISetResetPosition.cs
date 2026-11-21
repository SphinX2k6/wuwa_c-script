using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002075 RID: 8309
	public class ISetResetPosition : ISetTeleControlConfig
	{
		// Token: 0x0600B06B RID: 45163 RVA: 0x0018D1B8 File Offset: 0x0018B3B8
		private ISetResetPosition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetResetPosition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetResetPosition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetResetPosition_SetValue());
			}
			return result;
		}

		// Token: 0x0600B06C RID: 45164 RVA: 0x0018D1F0 File Offset: 0x0018B3F0
		public static ISetResetPosition Create([Nullable(2)] ISetResetPosition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetResetPosition
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B06D RID: 45165 RVA: 0x0018D203 File Offset: 0x0018B403
		public static ISetResetPosition CreateFromSetValue([Nullable(2)] ISetResetPosition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetResetPosition
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B06E RID: 45166 RVA: 0x0018D216 File Offset: 0x0018B416
		public new ISetResetPosition_SetValue ToSetValue()
		{
			return new ISetResetPosition_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId,
				PositionEntityId = this.PositionEntityId
			};
		}

		// Token: 0x17003594 RID: 13716
		// (get) Token: 0x0600B06F RID: 45167 RVA: 0x0018D241 File Offset: 0x0018B441
		// (set) Token: 0x0600B070 RID: 45168 RVA: 0x0018D26C File Offset: 0x0018B46C
		public override ESetTeleControlType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESetTeleControlType.OpenGravity;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003595 RID: 13717
		// (get) Token: 0x0600B071 RID: 45169 RVA: 0x0018D27A File Offset: 0x0018B47A
		// (set) Token: 0x0600B072 RID: 45170 RVA: 0x0018D2A5 File Offset: 0x0018B4A5
		public override int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x17003596 RID: 13718
		// (get) Token: 0x0600B073 RID: 45171 RVA: 0x0018D2B3 File Offset: 0x0018B4B3
		// (set) Token: 0x0600B074 RID: 45172 RVA: 0x0018D2DE File Offset: 0x0018B4DE
		public virtual int PositionEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PositionEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.PositionEntityId;
			}
			set
			{
				this.GetOrCreatePoco().PositionEntityId = value;
			}
		}

		// Token: 0x040068F5 RID: 26869
		[Nullable(2)]
		protected new ISetResetPosition FbInstance;

		// Token: 0x040068F6 RID: 26870
		[Nullable(2)]
		protected new ISetResetPosition_SetValue PocoInterface;
	}
}
