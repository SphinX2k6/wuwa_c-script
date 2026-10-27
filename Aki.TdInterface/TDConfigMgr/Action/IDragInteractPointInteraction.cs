using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019C2 RID: 6594
	[NullableContext(1)]
	[Nullable(0)]
	public class IDragInteractPointInteraction : IInteractPointInteraction
	{
		// Token: 0x06008D43 RID: 36163 RVA: 0x0014B190 File Offset: 0x00149390
		private IDragInteractPointInteraction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDragInteractPointInteraction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDragInteractPointInteraction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDragInteractPointInteraction_SetValue());
			}
			return result;
		}

		// Token: 0x06008D44 RID: 36164 RVA: 0x0014B1C8 File Offset: 0x001493C8
		public static IDragInteractPointInteraction Create([Nullable(2)] IDragInteractPointInteraction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDragInteractPointInteraction
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008D45 RID: 36165 RVA: 0x0014B1DB File Offset: 0x001493DB
		public static IDragInteractPointInteraction CreateFromSetValue([Nullable(2)] IDragInteractPointInteraction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDragInteractPointInteraction
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008D46 RID: 36166 RVA: 0x0014B1EE File Offset: 0x001493EE
		public new IDragInteractPointInteraction_SetValue ToSetValue()
		{
			return new IDragInteractPointInteraction_SetValue
			{
				Type = this.Type,
				DragItemTag = this.DragItemTag,
				CheckDistance = this.CheckDistance
			};
		}

		// Token: 0x17002D53 RID: 11603
		// (get) Token: 0x06008D47 RID: 36167 RVA: 0x0014B219 File Offset: 0x00149419
		// (set) Token: 0x06008D48 RID: 36168 RVA: 0x0014B244 File Offset: 0x00149444
		public override EInteractPointInteractionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInteractPointInteractionType.Drag;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002D54 RID: 11604
		// (get) Token: 0x06008D49 RID: 36169 RVA: 0x0014B252 File Offset: 0x00149452
		// (set) Token: 0x06008D4A RID: 36170 RVA: 0x0014B27D File Offset: 0x0014947D
		public virtual int DragItemTag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DragItemTag;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.DragItemTag;
			}
			set
			{
				this.GetOrCreatePoco().DragItemTag = value;
			}
		}

		// Token: 0x17002D55 RID: 11605
		// (get) Token: 0x06008D4B RID: 36171 RVA: 0x0014B28C File Offset: 0x0014948C
		// (set) Token: 0x06008D4C RID: 36172 RVA: 0x0014B2C6 File Offset: 0x001494C6
		public virtual float? CheckDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CheckDistance;
				}
				IDragInteractPointInteraction_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CheckDistance;
			}
			set
			{
				this.GetOrCreatePoco().CheckDistance = value;
			}
		}

		// Token: 0x040057CA RID: 22474
		[Nullable(2)]
		protected new IDragInteractPointInteraction FbInstance;

		// Token: 0x040057CB RID: 22475
		[Nullable(2)]
		protected new IDragInteractPointInteraction_SetValue PocoInterface;
	}
}
