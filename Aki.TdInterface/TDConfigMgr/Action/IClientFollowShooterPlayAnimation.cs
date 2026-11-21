using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A47 RID: 6727
	public class IClientFollowShooterPlayAnimation : IClientFollowShooterLeisureInteractType
	{
		// Token: 0x06008F03 RID: 36611 RVA: 0x00151474 File Offset: 0x0014F674
		private IClientFollowShooterPlayAnimation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IClientFollowShooterPlayAnimation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IClientFollowShooterPlayAnimation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IClientFollowShooterPlayAnimation_SetValue());
			}
			return result;
		}

		// Token: 0x06008F04 RID: 36612 RVA: 0x001514AC File Offset: 0x0014F6AC
		public static IClientFollowShooterPlayAnimation Create([Nullable(2)] IClientFollowShooterPlayAnimation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientFollowShooterPlayAnimation
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008F05 RID: 36613 RVA: 0x001514BF File Offset: 0x0014F6BF
		public static IClientFollowShooterPlayAnimation CreateFromSetValue([Nullable(2)] IClientFollowShooterPlayAnimation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IClientFollowShooterPlayAnimation
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008F06 RID: 36614 RVA: 0x001514D2 File Offset: 0x0014F6D2
		public new IClientFollowShooterPlayAnimation_SetValue ToSetValue()
		{
			return new IClientFollowShooterPlayAnimation_SetValue
			{
				Type = this.Type,
				Montage = this.Montage
			};
		}

		// Token: 0x17002E23 RID: 11811
		// (get) Token: 0x06008F07 RID: 36615 RVA: 0x001514F1 File Offset: 0x0014F6F1
		// (set) Token: 0x06008F08 RID: 36616 RVA: 0x0015151C File Offset: 0x0014F71C
		public override EClientFollowShooterLeisureInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EClientFollowShooterLeisureInteractType.PlayAnimation;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002E24 RID: 11812
		// (get) Token: 0x06008F09 RID: 36617 RVA: 0x0015152A File Offset: 0x0014F72A
		// (set) Token: 0x06008F0A RID: 36618 RVA: 0x00151555 File Offset: 0x0014F755
		public virtual string Montage
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Montage;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Montage;
			}
			set
			{
				this.GetOrCreatePoco().Montage = value;
			}
		}

		// Token: 0x040059BA RID: 22970
		[Nullable(2)]
		protected new IClientFollowShooterPlayAnimation FbInstance;

		// Token: 0x040059BB RID: 22971
		[Nullable(2)]
		protected new IClientFollowShooterPlayAnimation_SetValue PocoInterface;
	}
}
