using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001854 RID: 6228
	[NullableContext(1)]
	[Nullable(0)]
	public class ICameraTransition : ILevelSequenceTransitionType
	{
		// Token: 0x060085CF RID: 34255 RVA: 0x0013E2AC File Offset: 0x0013C4AC
		private ICameraTransition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICameraTransition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICameraTransition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICameraTransition_SetValue());
			}
			return result;
		}

		// Token: 0x060085D0 RID: 34256 RVA: 0x0013E2E4 File Offset: 0x0013C4E4
		public static ICameraTransition Create([Nullable(2)] ICameraTransition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICameraTransition
			{
				FbInstance = instance
			};
		}

		// Token: 0x060085D1 RID: 34257 RVA: 0x0013E2F7 File Offset: 0x0013C4F7
		public static ICameraTransition CreateFromSetValue([Nullable(2)] ICameraTransition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICameraTransition
			{
				PocoInterface = value
			};
		}

		// Token: 0x060085D2 RID: 34258 RVA: 0x0013E30A File Offset: 0x0013C50A
		public new ICameraTransition_SetValue ToSetValue()
		{
			return new ICameraTransition_SetValue
			{
				Type = this.Type,
				Duration = this.Duration
			};
		}

		// Token: 0x17002BBE RID: 11198
		// (get) Token: 0x060085D3 RID: 34259 RVA: 0x0013E329 File Offset: 0x0013C529
		// (set) Token: 0x060085D4 RID: 34260 RVA: 0x0013E354 File Offset: 0x0013C554
		public override ELevelSequenceTransition Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELevelSequenceTransition.Camera;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002BBF RID: 11199
		// (get) Token: 0x060085D5 RID: 34261 RVA: 0x0013E364 File Offset: 0x0013C564
		// (set) Token: 0x060085D6 RID: 34262 RVA: 0x0013E39E File Offset: 0x0013C59E
		public override float? Duration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Duration;
				}
				ICameraTransition_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Duration;
			}
			set
			{
				this.GetOrCreatePoco().Duration = value;
			}
		}

		// Token: 0x0400547D RID: 21629
		[Nullable(2)]
		protected new ICameraTransition FbInstance;

		// Token: 0x0400547E RID: 21630
		[Nullable(2)]
		protected new ICameraTransition_SetValue PocoInterface;
	}
}
