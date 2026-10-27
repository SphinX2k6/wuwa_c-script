using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001659 RID: 5721
	[NullableContext(2)]
	[Nullable(0)]
	public class EnterMovieMode : ActionParams
	{
		// Token: 0x06007CB9 RID: 31929 RVA: 0x0012BA90 File Offset: 0x00129C90
		[NullableContext(1)]
		private EnterMovieMode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("EnterMovieMode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			EnterMovieMode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new EnterMovieMode_SetValue());
			}
			return result;
		}

		// Token: 0x06007CBA RID: 31930 RVA: 0x0012BAC8 File Offset: 0x00129CC8
		[NullableContext(1)]
		public static EnterMovieMode Create([Nullable(2)] EnterMovieMode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnterMovieMode
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007CBB RID: 31931 RVA: 0x0012BADB File Offset: 0x00129CDB
		[NullableContext(1)]
		public static EnterMovieMode CreateFromSetValue([Nullable(2)] EnterMovieMode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new EnterMovieMode
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007CBC RID: 31932 RVA: 0x0012BAF0 File Offset: 0x00129CF0
		[NullableContext(1)]
		public EnterMovieMode_SetValue ToSetValue()
		{
			return new EnterMovieMode_SetValue
			{
				MovieCameraConfig = this.MovieCameraConfig,
				EnableFuncConfig = this.EnableFuncConfig,
				BorderAnimDuration = this.BorderAnimDuration,
				DurationType = this.DurationType,
				AutoExitInFlow = this.AutoExitInFlow
			};
		}

		// Token: 0x17002931 RID: 10545
		// (get) Token: 0x06007CBD RID: 31933 RVA: 0x0012BB40 File Offset: 0x00129D40
		// (set) Token: 0x06007CBE RID: 31934 RVA: 0x0012BBA1 File Offset: 0x00129DA1
		public virtual IMovieCameraConfig MovieCameraConfig
		{
			get
			{
				if (this._MovieCameraConfigInited)
				{
					return this._MovieCameraConfigCache;
				}
				this._MovieCameraConfigInited = true;
				if (this.FbInstance != null)
				{
					this._MovieCameraConfigCache = IMovieCameraConfig.Create(this.FbInstance.MovieCameraConfig);
				}
				else
				{
					EnterMovieMode_SetValue pocoInterface = this.PocoInterface;
					this._MovieCameraConfigCache = ((pocoInterface != null) ? pocoInterface.MovieCameraConfig : null);
				}
				return this._MovieCameraConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().MovieCameraConfig = value;
				this._MovieCameraConfigInited = false;
			}
		}

		// Token: 0x17002932 RID: 10546
		// (get) Token: 0x06007CBF RID: 31935 RVA: 0x0012BBB8 File Offset: 0x00129DB8
		// (set) Token: 0x06007CC0 RID: 31936 RVA: 0x0012BC19 File Offset: 0x00129E19
		public virtual IEnableFuncConfig EnableFuncConfig
		{
			get
			{
				if (this._EnableFuncConfigInited)
				{
					return this._EnableFuncConfigCache;
				}
				this._EnableFuncConfigInited = true;
				if (this.FbInstance != null)
				{
					this._EnableFuncConfigCache = IEnableFuncConfig.Create(this.FbInstance.EnableFuncConfig);
				}
				else
				{
					EnterMovieMode_SetValue pocoInterface = this.PocoInterface;
					this._EnableFuncConfigCache = ((pocoInterface != null) ? pocoInterface.EnableFuncConfig : null);
				}
				return this._EnableFuncConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().EnableFuncConfig = value;
				this._EnableFuncConfigInited = false;
			}
		}

		// Token: 0x17002933 RID: 10547
		// (get) Token: 0x06007CC1 RID: 31937 RVA: 0x0012BC30 File Offset: 0x00129E30
		// (set) Token: 0x06007CC2 RID: 31938 RVA: 0x0012BC6A File Offset: 0x00129E6A
		public virtual float? BorderAnimDuration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BorderAnimDuration;
				}
				EnterMovieMode_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.BorderAnimDuration;
			}
			set
			{
				this.GetOrCreatePoco().BorderAnimDuration = value;
			}
		}

		// Token: 0x17002934 RID: 10548
		// (get) Token: 0x06007CC3 RID: 31939 RVA: 0x0012BC78 File Offset: 0x00129E78
		// (set) Token: 0x06007CC4 RID: 31940 RVA: 0x0012BC9F File Offset: 0x00129E9F
		public virtual IEnterMovieModeDurationType DurationType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DurationType;
				}
				EnterMovieMode_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DurationType;
			}
			set
			{
				this.GetOrCreatePoco().DurationType = value;
			}
		}

		// Token: 0x17002935 RID: 10549
		// (get) Token: 0x06007CC5 RID: 31941 RVA: 0x0012BCB0 File Offset: 0x00129EB0
		// (set) Token: 0x06007CC6 RID: 31942 RVA: 0x0012BCEA File Offset: 0x00129EEA
		public virtual bool? AutoExitInFlow
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AutoExitInFlow;
				}
				EnterMovieMode_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AutoExitInFlow;
			}
			set
			{
				this.GetOrCreatePoco().AutoExitInFlow = value;
			}
		}

		// Token: 0x04004CA4 RID: 19620
		protected new EnterMovieMode FbInstance;

		// Token: 0x04004CA5 RID: 19621
		protected EnterMovieMode_SetValue PocoInterface;

		// Token: 0x04004CA6 RID: 19622
		[Nullable(1)]
		private IMovieCameraConfig _MovieCameraConfigCache;

		// Token: 0x04004CA7 RID: 19623
		private bool _MovieCameraConfigInited;

		// Token: 0x04004CA8 RID: 19624
		[Nullable(1)]
		private IEnableFuncConfig _EnableFuncConfigCache;

		// Token: 0x04004CA9 RID: 19625
		private bool _EnableFuncConfigInited;
	}
}
