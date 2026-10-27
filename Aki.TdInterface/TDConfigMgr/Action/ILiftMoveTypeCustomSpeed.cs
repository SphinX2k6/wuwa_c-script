using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B84 RID: 7044
	[NullableContext(1)]
	[Nullable(0)]
	public class ILiftMoveTypeCustomSpeed : ILiftMoveType
	{
		// Token: 0x060096D5 RID: 38613 RVA: 0x0015C384 File Offset: 0x0015A584
		private ILiftMoveTypeCustomSpeed_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILiftMoveTypeCustomSpeed 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILiftMoveTypeCustomSpeed_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILiftMoveTypeCustomSpeed_SetValue());
			}
			return result;
		}

		// Token: 0x060096D6 RID: 38614 RVA: 0x0015C3BC File Offset: 0x0015A5BC
		public static ILiftMoveTypeCustomSpeed Create([Nullable(2)] ILiftMoveTypeCustomSpeed instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiftMoveTypeCustomSpeed
			{
				FbInstance = instance
			};
		}

		// Token: 0x060096D7 RID: 38615 RVA: 0x0015C3CF File Offset: 0x0015A5CF
		public static ILiftMoveTypeCustomSpeed CreateFromSetValue([Nullable(2)] ILiftMoveTypeCustomSpeed_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILiftMoveTypeCustomSpeed
			{
				PocoInterface = value
			};
		}

		// Token: 0x060096D8 RID: 38616 RVA: 0x0015C3E2 File Offset: 0x0015A5E2
		public new ILiftMoveTypeCustomSpeed_SetValue ToSetValue()
		{
			return new ILiftMoveTypeCustomSpeed_SetValue
			{
				Type = this.Type,
				TotalTime = this.TotalTime,
				TimePathCurve = this.TimePathCurve
			};
		}

		// Token: 0x17002F7B RID: 12155
		// (get) Token: 0x060096D9 RID: 38617 RVA: 0x0015C40D File Offset: 0x0015A60D
		// (set) Token: 0x060096DA RID: 38618 RVA: 0x0015C438 File Offset: 0x0015A638
		public override ELiftMoveType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELiftMoveType.Default;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002F7C RID: 12156
		// (get) Token: 0x060096DB RID: 38619 RVA: 0x0015C446 File Offset: 0x0015A646
		// (set) Token: 0x060096DC RID: 38620 RVA: 0x0015C475 File Offset: 0x0015A675
		public virtual float TotalTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TotalTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.TotalTime;
			}
			set
			{
				this.GetOrCreatePoco().TotalTime = value;
			}
		}

		// Token: 0x17002F7D RID: 12157
		// (get) Token: 0x060096DD RID: 38621 RVA: 0x0015C483 File Offset: 0x0015A683
		// (set) Token: 0x060096DE RID: 38622 RVA: 0x0015C4AE File Offset: 0x0015A6AE
		public virtual string TimePathCurve
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TimePathCurve;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TimePathCurve;
			}
			set
			{
				this.GetOrCreatePoco().TimePathCurve = value;
			}
		}

		// Token: 0x04005C2A RID: 23594
		[Nullable(2)]
		protected new ILiftMoveTypeCustomSpeed FbInstance;

		// Token: 0x04005C2B RID: 23595
		[Nullable(2)]
		protected new ILiftMoveTypeCustomSpeed_SetValue PocoInterface;
	}
}
