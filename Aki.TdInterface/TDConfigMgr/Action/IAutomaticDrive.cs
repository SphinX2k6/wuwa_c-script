using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001975 RID: 6517
	public class IAutomaticDrive
	{
		// Token: 0x06008AA1 RID: 35489 RVA: 0x00149698 File Offset: 0x00147898
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

		// Token: 0x06008AA2 RID: 35490 RVA: 0x001496D0 File Offset: 0x001478D0
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

		// Token: 0x06008AA3 RID: 35491 RVA: 0x001496E3 File Offset: 0x001478E3
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

		// Token: 0x06008AA4 RID: 35492 RVA: 0x001496F6 File Offset: 0x001478F6
		public IAutomaticDrive_SetValue ToSetValue()
		{
			return new IAutomaticDrive_SetValue
			{
				StandbyTime = this.StandbyTime
			};
		}

		// Token: 0x17002D2D RID: 11565
		// (get) Token: 0x06008AA5 RID: 35493 RVA: 0x00149709 File Offset: 0x00147909
		// (set) Token: 0x06008AA6 RID: 35494 RVA: 0x00149738 File Offset: 0x00147938
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

		// Token: 0x040057B8 RID: 22456
		[Nullable(2)]
		protected IAutomaticDrive FbInstance;

		// Token: 0x040057B9 RID: 22457
		[Nullable(2)]
		protected IAutomaticDrive_SetValue PocoInterface;
	}
}
