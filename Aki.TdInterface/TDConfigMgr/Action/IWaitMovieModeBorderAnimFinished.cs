using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020B1 RID: 8369
	[NullableContext(1)]
	[Nullable(0)]
	public class IWaitMovieModeBorderAnimFinished : IEnterMovieModeDurationType
	{
		// Token: 0x0600B810 RID: 47120 RVA: 0x001AA354 File Offset: 0x001A8554
		private IWaitMovieModeBorderAnimFinished_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWaitMovieModeBorderAnimFinished 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWaitMovieModeBorderAnimFinished_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWaitMovieModeBorderAnimFinished_SetValue());
			}
			return result;
		}

		// Token: 0x0600B811 RID: 47121 RVA: 0x001AA38C File Offset: 0x001A858C
		public static IWaitMovieModeBorderAnimFinished Create([Nullable(2)] IWaitMovieModeBorderAnimFinished instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWaitMovieModeBorderAnimFinished
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B812 RID: 47122 RVA: 0x001AA39F File Offset: 0x001A859F
		public static IWaitMovieModeBorderAnimFinished CreateFromSetValue([Nullable(2)] IWaitMovieModeBorderAnimFinished_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWaitMovieModeBorderAnimFinished
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B813 RID: 47123 RVA: 0x001AA3B2 File Offset: 0x001A85B2
		public new IWaitMovieModeBorderAnimFinished_SetValue ToSetValue()
		{
			return new IWaitMovieModeBorderAnimFinished_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003857 RID: 14423
		// (get) Token: 0x0600B814 RID: 47124 RVA: 0x001AA3C5 File Offset: 0x001A85C5
		// (set) Token: 0x0600B815 RID: 47125 RVA: 0x001AA3F0 File Offset: 0x001A85F0
		public override EEnterMovieModeDurationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEnterMovieModeDurationType.BorderAnimFinished;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006E66 RID: 28262
		[Nullable(2)]
		protected new IWaitMovieModeBorderAnimFinished FbInstance;

		// Token: 0x04006E67 RID: 28263
		[Nullable(2)]
		protected new IWaitMovieModeBorderAnimFinished_SetValue PocoInterface;
	}
}
