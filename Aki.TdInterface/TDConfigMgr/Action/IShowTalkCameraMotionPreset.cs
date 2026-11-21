using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002095 RID: 8341
	public class IShowTalkCameraMotionPreset : IShowTalkCameraMotion
	{
		// Token: 0x0600B123 RID: 45347 RVA: 0x0018E620 File Offset: 0x0018C820
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

		// Token: 0x0600B124 RID: 45348 RVA: 0x0018E658 File Offset: 0x0018C858
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

		// Token: 0x0600B125 RID: 45349 RVA: 0x0018E66B File Offset: 0x0018C86B
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

		// Token: 0x0600B126 RID: 45350 RVA: 0x0018E67E File Offset: 0x0018C87E
		public new IShowTalkCameraMotionPreset_SetValue ToSetValue()
		{
			return new IShowTalkCameraMotionPreset_SetValue
			{
				Type = this.Type,
				Sequence = this.Sequence,
				CamShake = this.CamShake
			};
		}

		// Token: 0x170035C0 RID: 13760
		// (get) Token: 0x0600B127 RID: 45351 RVA: 0x0018E6A9 File Offset: 0x0018C8A9
		// (set) Token: 0x0600B128 RID: 45352 RVA: 0x0018E6D4 File Offset: 0x0018C8D4
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

		// Token: 0x170035C1 RID: 13761
		// (get) Token: 0x0600B129 RID: 45353 RVA: 0x0018E6E2 File Offset: 0x0018C8E2
		// (set) Token: 0x0600B12A RID: 45354 RVA: 0x0018E70D File Offset: 0x0018C90D
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

		// Token: 0x170035C2 RID: 13762
		// (get) Token: 0x0600B12B RID: 45355 RVA: 0x0018E71C File Offset: 0x0018C91C
		// (set) Token: 0x0600B12C RID: 45356 RVA: 0x0018E77D File Offset: 0x0018C97D
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

		// Token: 0x04006947 RID: 26951
		[Nullable(2)]
		protected new IShowTalkCameraMotionPreset FbInstance;

		// Token: 0x04006948 RID: 26952
		[Nullable(2)]
		protected new IShowTalkCameraMotionPreset_SetValue PocoInterface;

		// Token: 0x04006949 RID: 26953
		private IFlowCameraShake _CamShakeCache;

		// Token: 0x0400694A RID: 26954
		private bool _CamShakeInited;
	}
}
