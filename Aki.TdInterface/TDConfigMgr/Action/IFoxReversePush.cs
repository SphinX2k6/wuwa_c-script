using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001ABF RID: 6847
	[NullableContext(1)]
	[Nullable(0)]
	public class IFoxReversePush : ILeisureInteractType
	{
		// Token: 0x060092D4 RID: 37588 RVA: 0x00155200 File Offset: 0x00153400
		private IFoxReversePush_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFoxReversePush 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFoxReversePush_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFoxReversePush_SetValue());
			}
			return result;
		}

		// Token: 0x060092D5 RID: 37589 RVA: 0x00155238 File Offset: 0x00153438
		public static IFoxReversePush Create([Nullable(2)] IFoxReversePush instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFoxReversePush
			{
				FbInstance = instance
			};
		}

		// Token: 0x060092D6 RID: 37590 RVA: 0x0015524B File Offset: 0x0015344B
		public static IFoxReversePush CreateFromSetValue([Nullable(2)] IFoxReversePush_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFoxReversePush
			{
				PocoInterface = value
			};
		}

		// Token: 0x060092D7 RID: 37591 RVA: 0x00155260 File Offset: 0x00153460
		public new IFoxReversePush_SetValue ToSetValue()
		{
			return new IFoxReversePush_SetValue
			{
				Type = this.Type,
				SplineEntityId = this.SplineEntityId,
				SeqEntityId = this.SeqEntityId,
				SliderTag = this.SliderTag,
				Radius = this.Radius
			};
		}

		// Token: 0x17002EA1 RID: 11937
		// (get) Token: 0x060092D8 RID: 37592 RVA: 0x001552AE File Offset: 0x001534AE
		// (set) Token: 0x060092D9 RID: 37593 RVA: 0x001552D9 File Offset: 0x001534D9
		public override ELeisureInteract Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELeisureInteract.CustomSkill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002EA2 RID: 11938
		// (get) Token: 0x060092DA RID: 37594 RVA: 0x001552E7 File Offset: 0x001534E7
		// (set) Token: 0x060092DB RID: 37595 RVA: 0x00155312 File Offset: 0x00153512
		public virtual int SplineEntityId
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

		// Token: 0x17002EA3 RID: 11939
		// (get) Token: 0x060092DC RID: 37596 RVA: 0x00155320 File Offset: 0x00153520
		// (set) Token: 0x060092DD RID: 37597 RVA: 0x0015534B File Offset: 0x0015354B
		public virtual int SeqEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SeqEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SeqEntityId;
			}
			set
			{
				this.GetOrCreatePoco().SeqEntityId = value;
			}
		}

		// Token: 0x17002EA4 RID: 11940
		// (get) Token: 0x060092DE RID: 37598 RVA: 0x00155359 File Offset: 0x00153559
		// (set) Token: 0x060092DF RID: 37599 RVA: 0x00155384 File Offset: 0x00153584
		public virtual string SliderTag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SliderTag;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.SliderTag;
			}
			set
			{
				this.GetOrCreatePoco().SliderTag = value;
			}
		}

		// Token: 0x17002EA5 RID: 11941
		// (get) Token: 0x060092E0 RID: 37600 RVA: 0x00155392 File Offset: 0x00153592
		// (set) Token: 0x060092E1 RID: 37601 RVA: 0x001553C1 File Offset: 0x001535C1
		public virtual float Radius
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Radius;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Radius;
			}
			set
			{
				this.GetOrCreatePoco().Radius = value;
			}
		}

		// Token: 0x04005A58 RID: 23128
		[Nullable(2)]
		protected new IFoxReversePush FbInstance;

		// Token: 0x04005A59 RID: 23129
		[Nullable(2)]
		protected new IFoxReversePush_SetValue PocoInterface;
	}
}
