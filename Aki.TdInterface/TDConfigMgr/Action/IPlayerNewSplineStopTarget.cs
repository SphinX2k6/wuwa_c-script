using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F19 RID: 7961
	public class IPlayerNewSplineStopTarget : INewSplineStopTarget
	{
		// Token: 0x0600A969 RID: 43369 RVA: 0x001808B0 File Offset: 0x0017EAB0
		private IPlayerNewSplineStopTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPlayerNewSplineStopTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPlayerNewSplineStopTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPlayerNewSplineStopTarget_SetValue());
			}
			return result;
		}

		// Token: 0x0600A96A RID: 43370 RVA: 0x001808E8 File Offset: 0x0017EAE8
		public static IPlayerNewSplineStopTarget Create([Nullable(2)] IPlayerNewSplineStopTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayerNewSplineStopTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A96B RID: 43371 RVA: 0x001808FB File Offset: 0x0017EAFB
		public static IPlayerNewSplineStopTarget CreateFromSetValue([Nullable(2)] IPlayerNewSplineStopTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPlayerNewSplineStopTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A96C RID: 43372 RVA: 0x0018090E File Offset: 0x0017EB0E
		public new IPlayerNewSplineStopTarget_SetValue ToSetValue()
		{
			return new IPlayerNewSplineStopTarget_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700341D RID: 13341
		// (get) Token: 0x0600A96D RID: 43373 RVA: 0x00180921 File Offset: 0x0017EB21
		// (set) Token: 0x0600A96E RID: 43374 RVA: 0x0018094C File Offset: 0x0017EB4C
		public override ENewSplineMoveTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENewSplineMoveTargetType.Player;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040065BA RID: 26042
		[Nullable(2)]
		protected new IPlayerNewSplineStopTarget FbInstance;

		// Token: 0x040065BB RID: 26043
		[Nullable(2)]
		protected new IPlayerNewSplineStopTarget_SetValue PocoInterface;
	}
}
