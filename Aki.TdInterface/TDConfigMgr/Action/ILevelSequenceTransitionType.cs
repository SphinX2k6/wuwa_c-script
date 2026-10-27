using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B78 RID: 7032
	[NullableContext(1)]
	[Nullable(0)]
	public class ILevelSequenceTransitionType
	{
		// Token: 0x06009691 RID: 38545 RVA: 0x0015BB38 File Offset: 0x00159D38
		private ILevelSequenceTransitionType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILevelSequenceTransitionType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILevelSequenceTransitionType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILevelSequenceTransitionType_SetValue());
			}
			return result;
		}

		// Token: 0x06009692 RID: 38546 RVA: 0x0015BB70 File Offset: 0x00159D70
		public static ILevelSequenceTransitionType Create([Nullable(2)] ILevelSequenceTransitionType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILevelSequenceTransitionType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009693 RID: 38547 RVA: 0x0015BB83 File Offset: 0x00159D83
		public static ILevelSequenceTransitionType CreateFromSetValue([Nullable(2)] ILevelSequenceTransitionType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILevelSequenceTransitionType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009694 RID: 38548 RVA: 0x0015BB96 File Offset: 0x00159D96
		public ILevelSequenceTransitionType_SetValue ToSetValue()
		{
			return new ILevelSequenceTransitionType_SetValue
			{
				Type = this.Type,
				Duration = this.Duration
			};
		}

		// Token: 0x17002F6B RID: 12139
		// (get) Token: 0x06009695 RID: 38549 RVA: 0x0015BBB5 File Offset: 0x00159DB5
		// (set) Token: 0x06009696 RID: 38550 RVA: 0x0015BBE0 File Offset: 0x00159DE0
		public virtual ELevelSequenceTransition Type
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

		// Token: 0x17002F6C RID: 12140
		// (get) Token: 0x06009697 RID: 38551 RVA: 0x0015BBF0 File Offset: 0x00159DF0
		// (set) Token: 0x06009698 RID: 38552 RVA: 0x0015BC2A File Offset: 0x00159E2A
		public virtual float? Duration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Duration;
				}
				ILevelSequenceTransitionType_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04005C08 RID: 23560
		[Nullable(2)]
		protected ILevelSequenceTransitionType FbInstance;

		// Token: 0x04005C09 RID: 23561
		[Nullable(2)]
		protected ILevelSequenceTransitionType_SetValue PocoInterface;
	}
}
