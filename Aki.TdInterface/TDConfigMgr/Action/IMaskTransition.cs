using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DA7 RID: 7591
	[NullableContext(2)]
	[Nullable(0)]
	public class IMaskTransition : ILevelSequenceTransitionType
	{
		// Token: 0x0600A11F RID: 41247 RVA: 0x0017154C File Offset: 0x0016F74C
		[NullableContext(0)]
		private IMaskTransition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMaskTransition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMaskTransition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMaskTransition_SetValue());
			}
			return result;
		}

		// Token: 0x0600A120 RID: 41248 RVA: 0x00171584 File Offset: 0x0016F784
		[NullableContext(0)]
		public static IMaskTransition Create([Nullable(2)] IMaskTransition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMaskTransition
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A121 RID: 41249 RVA: 0x00171597 File Offset: 0x0016F797
		[NullableContext(0)]
		public static IMaskTransition CreateFromSetValue([Nullable(2)] IMaskTransition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMaskTransition
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A122 RID: 41250 RVA: 0x001715AC File Offset: 0x0016F7AC
		[NullableContext(0)]
		public new IMaskTransition_SetValue ToSetValue()
		{
			return new IMaskTransition_SetValue
			{
				Type = this.Type,
				Duration = this.Duration,
				Mask = this.Mask,
				FadeIn = this.FadeIn,
				FadeOut = this.FadeOut
			};
		}

		// Token: 0x17003223 RID: 12835
		// (get) Token: 0x0600A123 RID: 41251 RVA: 0x001715FA File Offset: 0x0016F7FA
		// (set) Token: 0x0600A124 RID: 41252 RVA: 0x00171625 File Offset: 0x0016F825
		public override ELevelSequenceTransition Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELevelSequenceTransition.Camera;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003224 RID: 12836
		// (get) Token: 0x0600A125 RID: 41253 RVA: 0x00171634 File Offset: 0x0016F834
		// (set) Token: 0x0600A126 RID: 41254 RVA: 0x0017166E File Offset: 0x0016F86E
		public override float? Duration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Duration;
				}
				IMaskTransition_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Duration;
			}
			set
			{
				this.GetOrCreatePoco().Duration = value;
			}
		}

		// Token: 0x17003225 RID: 12837
		// (get) Token: 0x0600A127 RID: 41255 RVA: 0x0017167C File Offset: 0x0016F87C
		// (set) Token: 0x0600A128 RID: 41256 RVA: 0x001716A7 File Offset: 0x0016F8A7
		public virtual ETransitionMask Mask
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Mask;
				}
				if (this.PocoInterface == null)
				{
					return ETransitionMask.BlackMask;
				}
				return this.PocoInterface.Mask;
			}
			set
			{
				this.GetOrCreatePoco().Mask = value;
			}
		}

		// Token: 0x17003226 RID: 12838
		// (get) Token: 0x0600A129 RID: 41257 RVA: 0x001716B8 File Offset: 0x0016F8B8
		// (set) Token: 0x0600A12A RID: 41258 RVA: 0x00171719 File Offset: 0x0016F919
		public virtual IEaseData FadeIn
		{
			get
			{
				if (this._FadeInInited)
				{
					return this._FadeInCache;
				}
				this._FadeInInited = true;
				if (this.FbInstance != null)
				{
					this._FadeInCache = IEaseData.Create(this.FbInstance.FadeIn);
				}
				else
				{
					IMaskTransition_SetValue pocoInterface = this.PocoInterface;
					this._FadeInCache = ((pocoInterface != null) ? pocoInterface.FadeIn : null);
				}
				return this._FadeInCache;
			}
			set
			{
				this.GetOrCreatePoco().FadeIn = value;
				this._FadeInInited = false;
			}
		}

		// Token: 0x17003227 RID: 12839
		// (get) Token: 0x0600A12B RID: 41259 RVA: 0x00171730 File Offset: 0x0016F930
		// (set) Token: 0x0600A12C RID: 41260 RVA: 0x00171791 File Offset: 0x0016F991
		public virtual IEaseData FadeOut
		{
			get
			{
				if (this._FadeOutInited)
				{
					return this._FadeOutCache;
				}
				this._FadeOutInited = true;
				if (this.FbInstance != null)
				{
					this._FadeOutCache = IEaseData.Create(this.FbInstance.FadeOut);
				}
				else
				{
					IMaskTransition_SetValue pocoInterface = this.PocoInterface;
					this._FadeOutCache = ((pocoInterface != null) ? pocoInterface.FadeOut : null);
				}
				return this._FadeOutCache;
			}
			set
			{
				this.GetOrCreatePoco().FadeOut = value;
				this._FadeOutInited = false;
			}
		}

		// Token: 0x040061E2 RID: 25058
		protected new IMaskTransition FbInstance;

		// Token: 0x040061E3 RID: 25059
		protected new IMaskTransition_SetValue PocoInterface;

		// Token: 0x040061E4 RID: 25060
		[Nullable(0)]
		private IEaseData _FadeInCache;

		// Token: 0x040061E5 RID: 25061
		private bool _FadeInInited;

		// Token: 0x040061E6 RID: 25062
		[Nullable(0)]
		private IEaseData _FadeOutCache;

		// Token: 0x040061E7 RID: 25063
		private bool _FadeOutInited;
	}
}
