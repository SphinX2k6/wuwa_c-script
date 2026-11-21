using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E6B RID: 7787
	public class INpcGroupSequenceMontageBlendAnimType : INpcGroupSequenceBlendAnimTypeBase
	{
		// Token: 0x0600A585 RID: 42373 RVA: 0x001797FC File Offset: 0x001779FC
		private INpcGroupSequenceMontageBlendAnimType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcGroupSequenceMontageBlendAnimType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcGroupSequenceMontageBlendAnimType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcGroupSequenceMontageBlendAnimType_SetValue());
			}
			return result;
		}

		// Token: 0x0600A586 RID: 42374 RVA: 0x00179834 File Offset: 0x00177A34
		public static INpcGroupSequenceMontageBlendAnimType Create([Nullable(2)] INpcGroupSequenceMontageBlendAnimType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcGroupSequenceMontageBlendAnimType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A587 RID: 42375 RVA: 0x00179847 File Offset: 0x00177A47
		public static INpcGroupSequenceMontageBlendAnimType CreateFromSetValue([Nullable(2)] INpcGroupSequenceMontageBlendAnimType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcGroupSequenceMontageBlendAnimType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A588 RID: 42376 RVA: 0x0017985A File Offset: 0x00177A5A
		public new INpcGroupSequenceMontageBlendAnimType_SetValue ToSetValue()
		{
			return new INpcGroupSequenceMontageBlendAnimType_SetValue
			{
				Type = this.Type,
				MontageId = this.MontageId
			};
		}

		// Token: 0x17003330 RID: 13104
		// (get) Token: 0x0600A589 RID: 42377 RVA: 0x00179879 File Offset: 0x00177A79
		// (set) Token: 0x0600A58A RID: 42378 RVA: 0x001798A4 File Offset: 0x00177AA4
		public override ENpcGroupSequenceBlendAnimType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENpcGroupSequenceBlendAnimType.AnimSequence;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003331 RID: 13105
		// (get) Token: 0x0600A58B RID: 42379 RVA: 0x001798B2 File Offset: 0x00177AB2
		// (set) Token: 0x0600A58C RID: 42380 RVA: 0x001798DD File Offset: 0x00177ADD
		public virtual int MontageId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MontageId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MontageId;
			}
			set
			{
				this.GetOrCreatePoco().MontageId = value;
			}
		}

		// Token: 0x040063F5 RID: 25589
		[Nullable(2)]
		protected new INpcGroupSequenceMontageBlendAnimType FbInstance;

		// Token: 0x040063F6 RID: 25590
		[Nullable(2)]
		protected new INpcGroupSequenceMontageBlendAnimType_SetValue PocoInterface;
	}
}
