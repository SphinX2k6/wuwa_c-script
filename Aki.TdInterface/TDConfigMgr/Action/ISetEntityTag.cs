using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200204F RID: 8271
	public class ISetEntityTag
	{
		// Token: 0x0600AF87 RID: 44935 RVA: 0x0018B5D8 File Offset: 0x001897D8
		private ISetEntityTag_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetEntityTag 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetEntityTag_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetEntityTag_SetValue());
			}
			return result;
		}

		// Token: 0x0600AF88 RID: 44936 RVA: 0x0018B610 File Offset: 0x00189810
		public static ISetEntityTag Create([Nullable(2)] ISetEntityTag instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetEntityTag
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AF89 RID: 44937 RVA: 0x0018B623 File Offset: 0x00189823
		public static ISetEntityTag CreateFromSetValue([Nullable(2)] ISetEntityTag_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetEntityTag
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AF8A RID: 44938 RVA: 0x0018B638 File Offset: 0x00189838
		public ISetEntityTag_SetValue ToSetValue()
		{
			return new ISetEntityTag_SetValue
			{
				EntityId = this.EntityId,
				GameplayTag = this.GameplayTag,
				SetType = this.SetType,
				DelayTime = this.DelayTime,
				BeforeHide = this.BeforeHide
			};
		}

		// Token: 0x1700355B RID: 13659
		// (get) Token: 0x0600AF8B RID: 44939 RVA: 0x0018B686 File Offset: 0x00189886
		// (set) Token: 0x0600AF8C RID: 44940 RVA: 0x0018B6B1 File Offset: 0x001898B1
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x1700355C RID: 13660
		// (get) Token: 0x0600AF8D RID: 44941 RVA: 0x0018B6BF File Offset: 0x001898BF
		// (set) Token: 0x0600AF8E RID: 44942 RVA: 0x0018B6EA File Offset: 0x001898EA
		public virtual string GameplayTag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GameplayTag;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.GameplayTag;
			}
			set
			{
				this.GetOrCreatePoco().GameplayTag = value;
			}
		}

		// Token: 0x1700355D RID: 13661
		// (get) Token: 0x0600AF8F RID: 44943 RVA: 0x0018B6F8 File Offset: 0x001898F8
		// (set) Token: 0x0600AF90 RID: 44944 RVA: 0x0018B723 File Offset: 0x00189923
		public virtual ESetEntityTagType SetType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SetType;
				}
				if (this.PocoInterface == null)
				{
					return ESetEntityTagType.Add;
				}
				return this.PocoInterface.SetType;
			}
			set
			{
				this.GetOrCreatePoco().SetType = value;
			}
		}

		// Token: 0x1700355E RID: 13662
		// (get) Token: 0x0600AF91 RID: 44945 RVA: 0x0018B734 File Offset: 0x00189934
		// (set) Token: 0x0600AF92 RID: 44946 RVA: 0x0018B76E File Offset: 0x0018996E
		public virtual float? DelayTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayTime;
				}
				ISetEntityTag_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DelayTime;
			}
			set
			{
				this.GetOrCreatePoco().DelayTime = value;
			}
		}

		// Token: 0x1700355F RID: 13663
		// (get) Token: 0x0600AF93 RID: 44947 RVA: 0x0018B77C File Offset: 0x0018997C
		// (set) Token: 0x0600AF94 RID: 44948 RVA: 0x0018B7B6 File Offset: 0x001899B6
		public virtual bool? BeforeHide
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BeforeHide;
				}
				ISetEntityTag_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.BeforeHide;
			}
			set
			{
				this.GetOrCreatePoco().BeforeHide = value;
			}
		}

		// Token: 0x04006882 RID: 26754
		[Nullable(2)]
		protected ISetEntityTag FbInstance;

		// Token: 0x04006883 RID: 26755
		[Nullable(2)]
		protected ISetEntityTag_SetValue PocoInterface;
	}
}
