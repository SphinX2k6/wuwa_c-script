using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017EC RID: 6124
	[NullableContext(1)]
	[Nullable(0)]
	public class IAutomaticDrive
	{
		// Token: 0x06008385 RID: 33669 RVA: 0x00139FB0 File Offset: 0x001381B0
		private IAutomaticDrive_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAutomaticDrive 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAutomaticDrive_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAutomaticDrive_SetValue());
			}
			return result;
		}

		// Token: 0x06008386 RID: 33670 RVA: 0x00139FE8 File Offset: 0x001381E8
		public static IAutomaticDrive Create([Nullable(2)] IAutomaticDrive instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAutomaticDrive
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008387 RID: 33671 RVA: 0x00139FFB File Offset: 0x001381FB
		public static IAutomaticDrive CreateFromSetValue([Nullable(2)] IAutomaticDrive_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAutomaticDrive
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008388 RID: 33672 RVA: 0x0013A00E File Offset: 0x0013820E
		public IAutomaticDrive_SetValue ToSetValue()
		{
			return new IAutomaticDrive_SetValue
			{
				StandbyTime = this.StandbyTime
			};
		}

		// Token: 0x17002B35 RID: 11061
		// (get) Token: 0x06008389 RID: 33673 RVA: 0x0013A021 File Offset: 0x00138221
		// (set) Token: 0x0600838A RID: 33674 RVA: 0x0013A050 File Offset: 0x00138250
		public virtual float StandbyTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StandbyTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.StandbyTime;
			}
			set
			{
				this.GetOrCreatePoco().StandbyTime = value;
			}
		}

		// Token: 0x04005370 RID: 21360
		[Nullable(2)]
		protected IAutomaticDrive FbInstance;

		// Token: 0x04005371 RID: 21361
		[Nullable(2)]
		protected IAutomaticDrive_SetValue PocoInterface;
	}
}
