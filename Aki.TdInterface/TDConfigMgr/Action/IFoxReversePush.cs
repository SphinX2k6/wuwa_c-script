using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C5E RID: 7262
	public class IFoxReversePush : ILeisureInteractType
	{
		// Token: 0x06009A6C RID: 39532 RVA: 0x00165620 File Offset: 0x00163820
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

		// Token: 0x06009A6D RID: 39533 RVA: 0x00165658 File Offset: 0x00163858
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

		// Token: 0x06009A6E RID: 39534 RVA: 0x0016566B File Offset: 0x0016386B
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

		// Token: 0x06009A6F RID: 39535 RVA: 0x00165680 File Offset: 0x00163880
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

		// Token: 0x170030B6 RID: 12470
		// (get) Token: 0x06009A70 RID: 39536 RVA: 0x001656CE File Offset: 0x001638CE
		// (set) Token: 0x06009A71 RID: 39537 RVA: 0x001656F9 File Offset: 0x001638F9
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

		// Token: 0x170030B7 RID: 12471
		// (get) Token: 0x06009A72 RID: 39538 RVA: 0x00165707 File Offset: 0x00163907
		// (set) Token: 0x06009A73 RID: 39539 RVA: 0x00165732 File Offset: 0x00163932
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

		// Token: 0x170030B8 RID: 12472
		// (get) Token: 0x06009A74 RID: 39540 RVA: 0x00165740 File Offset: 0x00163940
		// (set) Token: 0x06009A75 RID: 39541 RVA: 0x0016576B File Offset: 0x0016396B
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

		// Token: 0x170030B9 RID: 12473
		// (get) Token: 0x06009A76 RID: 39542 RVA: 0x00165779 File Offset: 0x00163979
		// (set) Token: 0x06009A77 RID: 39543 RVA: 0x001657A4 File Offset: 0x001639A4
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

		// Token: 0x170030BA RID: 12474
		// (get) Token: 0x06009A78 RID: 39544 RVA: 0x001657B2 File Offset: 0x001639B2
		// (set) Token: 0x06009A79 RID: 39545 RVA: 0x001657E1 File Offset: 0x001639E1
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

		// Token: 0x04005ED1 RID: 24273
		[Nullable(2)]
		protected new IFoxReversePush FbInstance;

		// Token: 0x04005ED2 RID: 24274
		[Nullable(2)]
		protected new IFoxReversePush_SetValue PocoInterface;
	}
}
