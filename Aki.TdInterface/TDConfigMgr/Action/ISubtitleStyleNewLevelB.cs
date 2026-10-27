using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EE9 RID: 7913
	[NullableContext(1)]
	[Nullable(0)]
	public class ISubtitleStyleNewLevelB : ISubtitleStyleBase
	{
		// Token: 0x0600A946 RID: 43334 RVA: 0x0017DC84 File Offset: 0x0017BE84
		private ISubtitleStyleNewLevelB_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISubtitleStyleNewLevelB 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISubtitleStyleNewLevelB_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISubtitleStyleNewLevelB_SetValue());
			}
			return result;
		}

		// Token: 0x0600A947 RID: 43335 RVA: 0x0017DCBC File Offset: 0x0017BEBC
		public static ISubtitleStyleNewLevelB Create([Nullable(2)] ISubtitleStyleNewLevelB instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubtitleStyleNewLevelB
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A948 RID: 43336 RVA: 0x0017DCCF File Offset: 0x0017BECF
		public static ISubtitleStyleNewLevelB CreateFromSetValue([Nullable(2)] ISubtitleStyleNewLevelB_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISubtitleStyleNewLevelB
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A949 RID: 43337 RVA: 0x0017DCE2 File Offset: 0x0017BEE2
		public new ISubtitleStyleNewLevelB_SetValue ToSetValue()
		{
			return new ISubtitleStyleNewLevelB_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700339D RID: 13213
		// (get) Token: 0x0600A94A RID: 43338 RVA: 0x0017DCF5 File Offset: 0x0017BEF5
		// (set) Token: 0x0600A94B RID: 43339 RVA: 0x0017DD20 File Offset: 0x0017BF20
		public override ESubtitleStyle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESubtitleStyle.LevelA;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040064BC RID: 25788
		[Nullable(2)]
		protected new ISubtitleStyleNewLevelB FbInstance;

		// Token: 0x040064BD RID: 25789
		[Nullable(2)]
		protected new ISubtitleStyleNewLevelB_SetValue PocoInterface;
	}
}
