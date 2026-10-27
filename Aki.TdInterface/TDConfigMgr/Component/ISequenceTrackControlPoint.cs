using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006C2 RID: 1730
	[NullableContext(1)]
	[Nullable(0)]
	public class ISequenceTrackControlPoint
	{
		// Token: 0x06002530 RID: 9520 RVA: 0x000645A4 File Offset: 0x000627A4
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

		// Token: 0x06002531 RID: 9521 RVA: 0x000645DC File Offset: 0x000627DC
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

		// Token: 0x06002532 RID: 9522 RVA: 0x000645EF File Offset: 0x000627EF
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

		// Token: 0x06002533 RID: 9523 RVA: 0x00064602 File Offset: 0x00062802
		public ISequenceTrackControlPoint_SetValue ToSetValue()
		{
			return new ISequenceTrackControlPoint_SetValue
			{
				Mark = this.Mark
			};
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x06002534 RID: 9524 RVA: 0x00064615 File Offset: 0x00062815
		// (set) Token: 0x06002535 RID: 9525 RVA: 0x00064640 File Offset: 0x00062840
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

		// Token: 0x04001970 RID: 6512
		[Nullable(2)]
		protected ISequenceTrackControlPoint FbInstance;

		// Token: 0x04001971 RID: 6513
		[Nullable(2)]
		protected ISequenceTrackControlPoint_SetValue PocoInterface;
	}
}
