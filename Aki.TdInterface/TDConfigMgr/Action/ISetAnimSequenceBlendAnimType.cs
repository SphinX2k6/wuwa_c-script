using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E0A RID: 7690
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetAnimSequenceBlendAnimType : IBlendAnimTypeBase
	{
		// Token: 0x0600A485 RID: 42117 RVA: 0x00175198 File Offset: 0x00173398
		private ISetAnimSequenceBlendAnimType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetAnimSequenceBlendAnimType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetAnimSequenceBlendAnimType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetAnimSequenceBlendAnimType_SetValue());
			}
			return result;
		}

		// Token: 0x0600A486 RID: 42118 RVA: 0x001751D0 File Offset: 0x001733D0
		public static ISetAnimSequenceBlendAnimType Create([Nullable(2)] ISetAnimSequenceBlendAnimType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetAnimSequenceBlendAnimType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A487 RID: 42119 RVA: 0x001751E3 File Offset: 0x001733E3
		public static ISetAnimSequenceBlendAnimType CreateFromSetValue([Nullable(2)] ISetAnimSequenceBlendAnimType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetAnimSequenceBlendAnimType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A488 RID: 42120 RVA: 0x001751F6 File Offset: 0x001733F6
		public new ISetAnimSequenceBlendAnimType_SetValue ToSetValue()
		{
			return new ISetAnimSequenceBlendAnimType_SetValue
			{
				Type = this.Type,
				AnimSequence = this.AnimSequence,
				ProtectTime = this.ProtectTime
			};
		}

		// Token: 0x1700328A RID: 12938
		// (get) Token: 0x0600A489 RID: 42121 RVA: 0x00175221 File Offset: 0x00173421
		// (set) Token: 0x0600A48A RID: 42122 RVA: 0x0017524C File Offset: 0x0017344C
		public override EBlendAnimType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EBlendAnimType.StateMachine;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700328B RID: 12939
		// (get) Token: 0x0600A48B RID: 42123 RVA: 0x0017525A File Offset: 0x0017345A
		// (set) Token: 0x0600A48C RID: 42124 RVA: 0x00175285 File Offset: 0x00173485
		public virtual string AnimSequence
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AnimSequence;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.AnimSequence;
			}
			set
			{
				this.GetOrCreatePoco().AnimSequence = value;
			}
		}

		// Token: 0x1700328C RID: 12940
		// (get) Token: 0x0600A48D RID: 42125 RVA: 0x00175294 File Offset: 0x00173494
		// (set) Token: 0x0600A48E RID: 42126 RVA: 0x001752CE File Offset: 0x001734CE
		public virtual float? ProtectTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ProtectTime;
				}
				ISetAnimSequenceBlendAnimType_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ProtectTime;
			}
			set
			{
				this.GetOrCreatePoco().ProtectTime = value;
			}
		}

		// Token: 0x04006281 RID: 25217
		[Nullable(2)]
		protected new ISetAnimSequenceBlendAnimType FbInstance;

		// Token: 0x04006282 RID: 25218
		[Nullable(2)]
		protected new ISetAnimSequenceBlendAnimType_SetValue PocoInterface;
	}
}
