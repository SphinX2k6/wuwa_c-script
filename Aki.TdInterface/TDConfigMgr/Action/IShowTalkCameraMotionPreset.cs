using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E60 RID: 7776
	[NullableContext(1)]
	[Nullable(0)]
	public class IShowTalkCameraMotionPreset : IShowTalkCameraMotion
	{
		// Token: 0x0600A66B RID: 42603 RVA: 0x00178920 File Offset: 0x00176B20
		private IShowTalkCameraMotionPreset_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IShowTalkCameraMotionPreset 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IShowTalkCameraMotionPreset_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IShowTalkCameraMotionPreset_SetValue());
			}
			return result;
		}

		// Token: 0x0600A66C RID: 42604 RVA: 0x00178958 File Offset: 0x00176B58
		public static IShowTalkCameraMotionPreset Create([Nullable(2)] IShowTalkCameraMotionPreset instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowTalkCameraMotionPreset
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A66D RID: 42605 RVA: 0x0017896B File Offset: 0x00176B6B
		public static IShowTalkCameraMotionPreset CreateFromSetValue([Nullable(2)] IShowTalkCameraMotionPreset_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IShowTalkCameraMotionPreset
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A66E RID: 42606 RVA: 0x0017897E File Offset: 0x00176B7E
		public new IShowTalkCameraMotionPreset_SetValue ToSetValue()
		{
			return new IShowTalkCameraMotionPreset_SetValue
			{
				Type = this.Type,
				Sequence = this.Sequence,
				CamShake = this.CamShake
			};
		}

		// Token: 0x170032FC RID: 13052
		// (get) Token: 0x0600A66F RID: 42607 RVA: 0x001789A9 File Offset: 0x00176BA9
		// (set) Token: 0x0600A670 RID: 42608 RVA: 0x001789D4 File Offset: 0x00176BD4
		public override EShowTalkCameraMotionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EShowTalkCameraMotionType.Preset;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170032FD RID: 13053
		// (get) Token: 0x0600A671 RID: 42609 RVA: 0x001789E2 File Offset: 0x00176BE2
		// (set) Token: 0x0600A672 RID: 42610 RVA: 0x00178A0D File Offset: 0x00176C0D
		public virtual string Sequence
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Sequence;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Sequence;
			}
			set
			{
				this.GetOrCreatePoco().Sequence = value;
			}
		}

		// Token: 0x170032FE RID: 13054
		// (get) Token: 0x0600A673 RID: 42611 RVA: 0x00178A1C File Offset: 0x00176C1C
		// (set) Token: 0x0600A674 RID: 42612 RVA: 0x00178A7D File Offset: 0x00176C7D
		[Nullable(2)]
		public virtual IFlowCameraShake CamShake
		{
			[NullableContext(2)]
			get
			{
				if (this._CamShakeInited)
				{
					return this._CamShakeCache;
				}
				this._CamShakeInited = true;
				if (this.FbInstance != null)
				{
					this._CamShakeCache = IFlowCameraShake.Create(this.FbInstance.CamShake);
				}
				else
				{
					IShowTalkCameraMotionPreset_SetValue pocoInterface = this.PocoInterface;
					this._CamShakeCache = ((pocoInterface != null) ? pocoInterface.CamShake : null);
				}
				return this._CamShakeCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().CamShake = value;
				this._CamShakeInited = false;
			}
		}

		// Token: 0x04006363 RID: 25443
		[Nullable(2)]
		protected new IShowTalkCameraMotionPreset FbInstance;

		// Token: 0x04006364 RID: 25444
		[Nullable(2)]
		protected new IShowTalkCameraMotionPreset_SetValue PocoInterface;

		// Token: 0x04006365 RID: 25445
		private IFlowCameraShake _CamShakeCache;

		// Token: 0x04006366 RID: 25446
		private bool _CamShakeInited;
	}
}
