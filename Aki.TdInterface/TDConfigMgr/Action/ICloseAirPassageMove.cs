using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A65 RID: 6757
	public class ICloseAirPassageMove : ICloseSplineMovePattern
	{
		// Token: 0x06008F99 RID: 36761 RVA: 0x0015242C File Offset: 0x0015062C
		private ICloseAirPassageMove_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICloseAirPassageMove 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICloseAirPassageMove_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICloseAirPassageMove_SetValue());
			}
			return result;
		}

		// Token: 0x06008F9A RID: 36762 RVA: 0x00152464 File Offset: 0x00150664
		public static ICloseAirPassageMove Create([Nullable(2)] ICloseAirPassageMove instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICloseAirPassageMove
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008F9B RID: 36763 RVA: 0x00152477 File Offset: 0x00150677
		public static ICloseAirPassageMove CreateFromSetValue([Nullable(2)] ICloseAirPassageMove_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICloseAirPassageMove
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008F9C RID: 36764 RVA: 0x0015248A File Offset: 0x0015068A
		public new ICloseAirPassageMove_SetValue ToSetValue()
		{
			return new ICloseAirPassageMove_SetValue
			{
				Type = this.Type,
				GravitySwitchAngularVelocity = this.GravitySwitchAngularVelocity
			};
		}

		// Token: 0x17002E41 RID: 11841
		// (get) Token: 0x06008F9D RID: 36765 RVA: 0x001524A9 File Offset: 0x001506A9
		// (set) Token: 0x06008F9E RID: 36766 RVA: 0x001524D4 File Offset: 0x001506D4
		public override ESplineMovePattern Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESplineMovePattern.PathLine;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002E42 RID: 11842
		// (get) Token: 0x06008F9F RID: 36767 RVA: 0x001524E4 File Offset: 0x001506E4
		// (set) Token: 0x06008FA0 RID: 36768 RVA: 0x0015251E File Offset: 0x0015071E
		public override float? GravitySwitchAngularVelocity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GravitySwitchAngularVelocity;
				}
				ICloseAirPassageMove_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.GravitySwitchAngularVelocity;
			}
			set
			{
				this.GetOrCreatePoco().GravitySwitchAngularVelocity = value;
			}
		}

		// Token: 0x040059FC RID: 23036
		[Nullable(2)]
		protected new ICloseAirPassageMove FbInstance;

		// Token: 0x040059FD RID: 23037
		[Nullable(2)]
		protected new ICloseAirPassageMove_SetValue PocoInterface;
	}
}
