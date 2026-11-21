using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000763 RID: 1891
	public class ISequenceTrackControlPoint
	{
		// Token: 0x06002850 RID: 10320 RVA: 0x0006B614 File Offset: 0x00069814
		private ISequenceTrackControlPoint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISequenceTrackControlPoint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISequenceTrackControlPoint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISequenceTrackControlPoint_SetValue());
			}
			return result;
		}

		// Token: 0x06002851 RID: 10321 RVA: 0x0006B64C File Offset: 0x0006984C
		public static ISequenceTrackControlPoint Create([Nullable(2)] ISequenceTrackControlPoint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISequenceTrackControlPoint
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002852 RID: 10322 RVA: 0x0006B65F File Offset: 0x0006985F
		public static ISequenceTrackControlPoint CreateFromSetValue([Nullable(2)] ISequenceTrackControlPoint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISequenceTrackControlPoint
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002853 RID: 10323 RVA: 0x0006B672 File Offset: 0x00069872
		public ISequenceTrackControlPoint_SetValue ToSetValue()
		{
			return new ISequenceTrackControlPoint_SetValue
			{
				Mark = this.Mark
			};
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x06002854 RID: 10324 RVA: 0x0006B685 File Offset: 0x00069885
		// (set) Token: 0x06002855 RID: 10325 RVA: 0x0006B6B0 File Offset: 0x000698B0
		public virtual string Mark
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Mark;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Mark;
			}
			set
			{
				this.GetOrCreatePoco().Mark = value;
			}
		}

		// Token: 0x04001B6F RID: 7023
		[Nullable(2)]
		protected ISequenceTrackControlPoint FbInstance;

		// Token: 0x04001B70 RID: 7024
		[Nullable(2)]
		protected ISequenceTrackControlPoint_SetValue PocoInterface;
	}
}
