using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B99 RID: 7065
	public class IEnterSpecMovieCamera : IEnterMovieCameraType
	{
		// Token: 0x0600961B RID: 38427 RVA: 0x0015D8E4 File Offset: 0x0015BAE4
		private IEnterSpecMovieCamera_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEnterSpecMovieCamera 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEnterSpecMovieCamera_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEnterSpecMovieCamera_SetValue());
			}
			return result;
		}

		// Token: 0x0600961C RID: 38428 RVA: 0x0015D91C File Offset: 0x0015BB1C
		public static IEnterSpecMovieCamera Create([Nullable(2)] IEnterSpecMovieCamera instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnterSpecMovieCamera
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600961D RID: 38429 RVA: 0x0015D92F File Offset: 0x0015BB2F
		public static IEnterSpecMovieCamera CreateFromSetValue([Nullable(2)] IEnterSpecMovieCamera_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEnterSpecMovieCamera
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600961E RID: 38430 RVA: 0x0015D942 File Offset: 0x0015BB42
		public new IEnterSpecMovieCamera_SetValue ToSetValue()
		{
			return new IEnterSpecMovieCamera_SetValue
			{
				Type = this.Type,
				RowName = this.RowName
			};
		}

		// Token: 0x17002FB4 RID: 12212
		// (get) Token: 0x0600961F RID: 38431 RVA: 0x0015D961 File Offset: 0x0015BB61
		// (set) Token: 0x06009620 RID: 38432 RVA: 0x0015D98C File Offset: 0x0015BB8C
		public override EMovieCameraType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMovieCameraType.Common;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002FB5 RID: 12213
		// (get) Token: 0x06009621 RID: 38433 RVA: 0x0015D99A File Offset: 0x0015BB9A
		// (set) Token: 0x06009622 RID: 38434 RVA: 0x0015D9C5 File Offset: 0x0015BBC5
		public virtual string RowName
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RowName;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.RowName;
			}
			set
			{
				this.GetOrCreatePoco().RowName = value;
			}
		}

		// Token: 0x04005CCB RID: 23755
		[Nullable(2)]
		protected new IEnterSpecMovieCamera FbInstance;

		// Token: 0x04005CCC RID: 23756
		[Nullable(2)]
		protected new IEnterSpecMovieCamera_SetValue PocoInterface;
	}
}
