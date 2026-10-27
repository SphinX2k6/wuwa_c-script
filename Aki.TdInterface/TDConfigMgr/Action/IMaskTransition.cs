using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BC0 RID: 7104
	[NullableContext(2)]
	[Nullable(0)]
	public class IMaskTransition : ILevelSequenceTransitionType
	{
		// Token: 0x0600981B RID: 38939 RVA: 0x0015EA8C File Offset: 0x0015CC8C
		[NullableContext(1)]
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

		// Token: 0x0600981C RID: 38940 RVA: 0x0015EAC4 File Offset: 0x0015CCC4
		[NullableContext(1)]
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

		// Token: 0x0600981D RID: 38941 RVA: 0x0015EAD7 File Offset: 0x0015CCD7
		[NullableContext(1)]
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

		// Token: 0x0600981E RID: 38942 RVA: 0x0015EAEC File Offset: 0x0015CCEC
		[NullableContext(1)]
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

		// Token: 0x17002FC4 RID: 12228
		// (get) Token: 0x0600981F RID: 38943 RVA: 0x0015EB3A File Offset: 0x0015CD3A
		// (set) Token: 0x06009820 RID: 38944 RVA: 0x0015EB65 File Offset: 0x0015CD65
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

		// Token: 0x17002FC5 RID: 12229
		// (get) Token: 0x06009821 RID: 38945 RVA: 0x0015EB74 File Offset: 0x0015CD74
		// (set) Token: 0x06009822 RID: 38946 RVA: 0x0015EBAE File Offset: 0x0015CDAE
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

		// Token: 0x17002FC6 RID: 12230
		// (get) Token: 0x06009823 RID: 38947 RVA: 0x0015EBBC File Offset: 0x0015CDBC
		// (set) Token: 0x06009824 RID: 38948 RVA: 0x0015EBE7 File Offset: 0x0015CDE7
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

		// Token: 0x17002FC7 RID: 12231
		// (get) Token: 0x06009825 RID: 38949 RVA: 0x0015EBF8 File Offset: 0x0015CDF8
		// (set) Token: 0x06009826 RID: 38950 RVA: 0x0015EC59 File Offset: 0x0015CE59
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

		// Token: 0x17002FC8 RID: 12232
		// (get) Token: 0x06009827 RID: 38951 RVA: 0x0015EC70 File Offset: 0x0015CE70
		// (set) Token: 0x06009828 RID: 38952 RVA: 0x0015ECD1 File Offset: 0x0015CED1
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

		// Token: 0x04005CCD RID: 23757
		protected new IMaskTransition FbInstance;

		// Token: 0x04005CCE RID: 23758
		protected new IMaskTransition_SetValue PocoInterface;

		// Token: 0x04005CCF RID: 23759
		[Nullable(1)]
		private IEaseData _FadeInCache;

		// Token: 0x04005CD0 RID: 23760
		private bool _FadeInInited;

		// Token: 0x04005CD1 RID: 23761
		[Nullable(1)]
		private IEaseData _FadeOutCache;

		// Token: 0x04005CD2 RID: 23762
		private bool _FadeOutInited;
	}
}
