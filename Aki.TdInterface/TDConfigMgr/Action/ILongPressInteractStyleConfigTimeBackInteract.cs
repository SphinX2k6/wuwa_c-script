using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BA6 RID: 7078
	[NullableContext(2)]
	[Nullable(0)]
	public class ILongPressInteractStyleConfigTimeBackInteract : ILongPressInteractStyleConfig
	{
		// Token: 0x06009793 RID: 38803 RVA: 0x0015DA08 File Offset: 0x0015BC08
		[NullableContext(1)]
		private ILongPressInteractStyleConfigTimeBackInteract_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILongPressInteractStyleConfigTimeBackInteract 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILongPressInteractStyleConfigTimeBackInteract_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILongPressInteractStyleConfigTimeBackInteract_SetValue());
			}
			return result;
		}

		// Token: 0x06009794 RID: 38804 RVA: 0x0015DA40 File Offset: 0x0015BC40
		[NullableContext(1)]
		public static ILongPressInteractStyleConfigTimeBackInteract Create([Nullable(2)] ILongPressInteractStyleConfigTimeBackInteract instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILongPressInteractStyleConfigTimeBackInteract
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009795 RID: 38805 RVA: 0x0015DA53 File Offset: 0x0015BC53
		[NullableContext(1)]
		public static ILongPressInteractStyleConfigTimeBackInteract CreateFromSetValue([Nullable(2)] ILongPressInteractStyleConfigTimeBackInteract_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILongPressInteractStyleConfigTimeBackInteract
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009796 RID: 38806 RVA: 0x0015DA66 File Offset: 0x0015BC66
		[NullableContext(1)]
		public new ILongPressInteractStyleConfigTimeBackInteract_SetValue ToSetValue()
		{
			return new ILongPressInteractStyleConfigTimeBackInteract_SetValue
			{
				Type = this.Type,
				TidContent = this.TidContent,
				StartProgress = this.StartProgress,
				EdTidContent = this.EdTidContent
			};
		}

		// Token: 0x17002FA7 RID: 12199
		// (get) Token: 0x06009797 RID: 38807 RVA: 0x0015DA9D File Offset: 0x0015BC9D
		// (set) Token: 0x06009798 RID: 38808 RVA: 0x0015DAC8 File Offset: 0x0015BCC8
		public override ELongPressInteractStyle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELongPressInteractStyle.Default;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002FA8 RID: 12200
		// (get) Token: 0x06009799 RID: 38809 RVA: 0x0015DAD6 File Offset: 0x0015BCD6
		// (set) Token: 0x0600979A RID: 38810 RVA: 0x0015DAFD File Offset: 0x0015BCFD
		public virtual string TidContent
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidContent;
				}
				ILongPressInteractStyleConfigTimeBackInteract_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TidContent;
			}
			set
			{
				this.GetOrCreatePoco().TidContent = value;
			}
		}

		// Token: 0x17002FA9 RID: 12201
		// (get) Token: 0x0600979B RID: 38811 RVA: 0x0015DB0C File Offset: 0x0015BD0C
		// (set) Token: 0x0600979C RID: 38812 RVA: 0x0015DB46 File Offset: 0x0015BD46
		public virtual float? StartProgress
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StartProgress;
				}
				ILongPressInteractStyleConfigTimeBackInteract_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.StartProgress;
			}
			set
			{
				this.GetOrCreatePoco().StartProgress = value;
			}
		}

		// Token: 0x17002FAA RID: 12202
		// (get) Token: 0x0600979D RID: 38813 RVA: 0x0015DB54 File Offset: 0x0015BD54
		// (set) Token: 0x0600979E RID: 38814 RVA: 0x0015DB6B File Offset: 0x0015BD6B
		public virtual string EdTidContent
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidContent;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdTidContent = value;
			}
		}

		// Token: 0x04005C86 RID: 23686
		protected new ILongPressInteractStyleConfigTimeBackInteract FbInstance;

		// Token: 0x04005C87 RID: 23687
		protected new ILongPressInteractStyleConfigTimeBackInteract_SetValue PocoInterface;
	}
}
