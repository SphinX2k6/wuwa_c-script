using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020012D9 RID: 4825
	public class IEavesdropGamePlayConfig : ISpecialGamePlayConfig
	{
		// Token: 0x06006E43 RID: 28227 RVA: 0x0010A9A6 File Offset: 0x00108BA6
		[NullableContext(1)]
		public static IEavesdropGamePlayConfig Create(IEavesdropGamePlayConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEavesdropGamePlayConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002264 RID: 8804
		// (get) Token: 0x06006E44 RID: 28228 RVA: 0x0010A9C5 File Offset: 0x00108BC5
		public override ESpecialGamePlayConfigType Type
		{
			get
			{
				return (ESpecialGamePlayConfigType)this.Instance.Type;
			}
		}

		// Token: 0x17002265 RID: 8805
		// (get) Token: 0x06006E45 RID: 28229 RVA: 0x0010A9D2 File Offset: 0x00108BD2
		public virtual int EavesdropEntityId
		{
			get
			{
				return this.Instance.EavesdropEntityId;
			}
		}

		// Token: 0x17002266 RID: 8806
		// (get) Token: 0x06006E46 RID: 28230 RVA: 0x0010A9DF File Offset: 0x00108BDF
		public virtual int HintRangeEntityId
		{
			get
			{
				return this.Instance.HintRangeEntityId;
			}
		}

		// Token: 0x17002267 RID: 8807
		// (get) Token: 0x06006E47 RID: 28231 RVA: 0x0010A9EC File Offset: 0x00108BEC
		public virtual int ListenableRangeEntityId
		{
			get
			{
				return this.Instance.ListenableRangeEntityId;
			}
		}

		// Token: 0x17002268 RID: 8808
		// (get) Token: 0x06006E48 RID: 28232 RVA: 0x0010A9F9 File Offset: 0x00108BF9
		public virtual int TooCloseRangeEntityId
		{
			get
			{
				return this.Instance.TooCloseRangeEntityId;
			}
		}

		// Token: 0x17002269 RID: 8809
		// (get) Token: 0x06006E49 RID: 28233 RVA: 0x0010AA06 File Offset: 0x00108C06
		public virtual int HintTag
		{
			get
			{
				return this.Instance.HintTag;
			}
		}

		// Token: 0x1700226A RID: 8810
		// (get) Token: 0x06006E4A RID: 28234 RVA: 0x0010AA13 File Offset: 0x00108C13
		public virtual int ListenableTag
		{
			get
			{
				return this.Instance.ListenableTag;
			}
		}

		// Token: 0x1700226B RID: 8811
		// (get) Token: 0x06006E4B RID: 28235 RVA: 0x0010AA20 File Offset: 0x00108C20
		public virtual int TooCloseTag
		{
			get
			{
				return this.Instance.TooCloseTag;
			}
		}

		// Token: 0x1700226C RID: 8812
		// (get) Token: 0x06006E4C RID: 28236 RVA: 0x0010AA2D File Offset: 0x00108C2D
		public virtual int ListenedTag
		{
			get
			{
				return this.Instance.ListenedTag;
			}
		}

		// Token: 0x04003F2F RID: 16175
		private IEavesdropGamePlayConfig Instance;
	}
}
