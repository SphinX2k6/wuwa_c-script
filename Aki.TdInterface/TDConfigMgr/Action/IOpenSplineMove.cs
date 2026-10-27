using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CB0 RID: 7344
	[NullableContext(1)]
	[Nullable(0)]
	public class IOpenSplineMove : ISplineMoveConfig
	{
		// Token: 0x06009DA7 RID: 40359 RVA: 0x00168FF4 File Offset: 0x001671F4
		private IOpenSplineMove_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IOpenSplineMove 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IOpenSplineMove_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IOpenSplineMove_SetValue());
			}
			return result;
		}

		// Token: 0x06009DA8 RID: 40360 RVA: 0x0016902C File Offset: 0x0016722C
		public static IOpenSplineMove Create([Nullable(2)] IOpenSplineMove instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOpenSplineMove
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009DA9 RID: 40361 RVA: 0x0016903F File Offset: 0x0016723F
		public static IOpenSplineMove CreateFromSetValue([Nullable(2)] IOpenSplineMove_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IOpenSplineMove
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009DAA RID: 40362 RVA: 0x00169052 File Offset: 0x00167252
		public new IOpenSplineMove_SetValue ToSetValue()
		{
			return new IOpenSplineMove_SetValue
			{
				Type = this.Type,
				Target = this.Target,
				SplineEntityId = this.SplineEntityId,
				Pattern = this.Pattern
			};
		}

		// Token: 0x17003122 RID: 12578
		// (get) Token: 0x06009DAB RID: 40363 RVA: 0x00169089 File Offset: 0x00167289
		// (set) Token: 0x06009DAC RID: 40364 RVA: 0x001690B4 File Offset: 0x001672B4
		public override ESplineMoveConfigType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESplineMoveConfigType.Open;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003123 RID: 12579
		// (get) Token: 0x06009DAD RID: 40365 RVA: 0x001690C2 File Offset: 0x001672C2
		// (set) Token: 0x06009DAE RID: 40366 RVA: 0x001690E9 File Offset: 0x001672E9
		public override ITargetEntityType Target
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Target;
				}
				IOpenSplineMove_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Target;
			}
			set
			{
				this.GetOrCreatePoco().Target = value;
			}
		}

		// Token: 0x17003124 RID: 12580
		// (get) Token: 0x06009DAF RID: 40367 RVA: 0x001690F7 File Offset: 0x001672F7
		// (set) Token: 0x06009DB0 RID: 40368 RVA: 0x00169122 File Offset: 0x00167322
		public override int SplineEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SplineEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SplineEntityId;
			}
			set
			{
				this.GetOrCreatePoco().SplineEntityId = value;
			}
		}

		// Token: 0x17003125 RID: 12581
		// (get) Token: 0x06009DB1 RID: 40369 RVA: 0x00169130 File Offset: 0x00167330
		// (set) Token: 0x06009DB2 RID: 40370 RVA: 0x00169157 File Offset: 0x00167357
		public virtual ISplineMovePattern Pattern
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Pattern;
				}
				IOpenSplineMove_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Pattern;
			}
			set
			{
				this.GetOrCreatePoco().Pattern = value;
			}
		}

		// Token: 0x04005F6B RID: 24427
		[Nullable(2)]
		protected new IOpenSplineMove FbInstance;

		// Token: 0x04005F6C RID: 24428
		[Nullable(2)]
		protected new IOpenSplineMove_SetValue PocoInterface;
	}
}
