using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002077 RID: 8311
	public class ISetSpineAnimationType
	{
		// Token: 0x0600B077 RID: 45175 RVA: 0x0018D2FC File Offset: 0x0018B4FC
		private ISetSpineAnimationType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetSpineAnimationType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetSpineAnimationType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetSpineAnimationType_SetValue());
			}
			return result;
		}

		// Token: 0x0600B078 RID: 45176 RVA: 0x0018D334 File Offset: 0x0018B534
		public static ISetSpineAnimationType Create([Nullable(2)] ISetSpineAnimationType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetSpineAnimationType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B079 RID: 45177 RVA: 0x0018D347 File Offset: 0x0018B547
		public static ISetSpineAnimationType CreateFromSetValue([Nullable(2)] ISetSpineAnimationType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetSpineAnimationType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B07A RID: 45178 RVA: 0x0018D35A File Offset: 0x0018B55A
		public ISetSpineAnimationType_SetValue ToSetValue()
		{
			return new ISetSpineAnimationType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003597 RID: 13719
		// (get) Token: 0x0600B07B RID: 45179 RVA: 0x0018D36D File Offset: 0x0018B56D
		// (set) Token: 0x0600B07C RID: 45180 RVA: 0x0018D398 File Offset: 0x0018B598
		public virtual ESetSpineAnimation Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESetSpineAnimation.Play;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040068FA RID: 26874
		[Nullable(2)]
		protected ISetSpineAnimationType FbInstance;

		// Token: 0x040068FB RID: 26875
		[Nullable(2)]
		protected ISetSpineAnimationType_SetValue PocoInterface;
	}
}
