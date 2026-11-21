using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F67 RID: 8039
	public class IProgramSpecialConfigBase
	{
		// Token: 0x0600AB01 RID: 43777 RVA: 0x00183674 File Offset: 0x00181874
		private IProgramSpecialConfigBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IProgramSpecialConfigBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IProgramSpecialConfigBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IProgramSpecialConfigBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600AB02 RID: 43778 RVA: 0x001836AC File Offset: 0x001818AC
		public static IProgramSpecialConfigBase Create([Nullable(2)] IProgramSpecialConfigBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IProgramSpecialConfigBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AB03 RID: 43779 RVA: 0x001836BF File Offset: 0x001818BF
		public static IProgramSpecialConfigBase CreateFromSetValue([Nullable(2)] IProgramSpecialConfigBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IProgramSpecialConfigBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AB04 RID: 43780 RVA: 0x001836D2 File Offset: 0x001818D2
		public IProgramSpecialConfigBase_SetValue ToSetValue()
		{
			return new IProgramSpecialConfigBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003474 RID: 13428
		// (get) Token: 0x0600AB05 RID: 43781 RVA: 0x001836E5 File Offset: 0x001818E5
		// (set) Token: 0x0600AB06 RID: 43782 RVA: 0x00183710 File Offset: 0x00181910
		public virtual EPlayMovieProgramSpecialConfigType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPlayMovieProgramSpecialConfigType.Mp4UiReplaceMaterial;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006679 RID: 26233
		[Nullable(2)]
		protected IProgramSpecialConfigBase FbInstance;

		// Token: 0x0400667A RID: 26234
		[Nullable(2)]
		protected IProgramSpecialConfigBase_SetValue PocoInterface;
	}
}
