using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B94 RID: 7060
	[NullableContext(1)]
	[Nullable(0)]
	public class ILimitPlayerMoveNew : ILimitPlayerOption
	{
		// Token: 0x06009723 RID: 38691 RVA: 0x0015CB70 File Offset: 0x0015AD70
		private ILimitPlayerMoveNew_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILimitPlayerMoveNew 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILimitPlayerMoveNew_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILimitPlayerMoveNew_SetValue());
			}
			return result;
		}

		// Token: 0x06009724 RID: 38692 RVA: 0x0015CBA8 File Offset: 0x0015ADA8
		public static ILimitPlayerMoveNew Create([Nullable(2)] ILimitPlayerMoveNew instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILimitPlayerMoveNew
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009725 RID: 38693 RVA: 0x0015CBBB File Offset: 0x0015ADBB
		public static ILimitPlayerMoveNew CreateFromSetValue([Nullable(2)] ILimitPlayerMoveNew_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILimitPlayerMoveNew
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009726 RID: 38694 RVA: 0x0015CBD0 File Offset: 0x0015ADD0
		public new ILimitPlayerMoveNew_SetValue ToSetValue()
		{
			return new ILimitPlayerMoveNew_SetValue
			{
				Type = this.Type,
				Forward = this.Forward,
				Back = this.Back,
				Left = this.Left,
				Right = this.Right
			};
		}

		// Token: 0x17002F8A RID: 12170
		// (get) Token: 0x06009727 RID: 38695 RVA: 0x0015CC1E File Offset: 0x0015AE1E
		// (set) Token: 0x06009728 RID: 38696 RVA: 0x0015CC49 File Offset: 0x0015AE49
		public override ELimitPlayOperation Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELimitPlayOperation.AllowCamera;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002F8B RID: 12171
		// (get) Token: 0x06009729 RID: 38697 RVA: 0x0015CC57 File Offset: 0x0015AE57
		// (set) Token: 0x0600972A RID: 38698 RVA: 0x0015CC82 File Offset: 0x0015AE82
		public virtual bool Forward
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Forward;
				}
				return this.PocoInterface != null && this.PocoInterface.Forward;
			}
			set
			{
				this.GetOrCreatePoco().Forward = value;
			}
		}

		// Token: 0x17002F8C RID: 12172
		// (get) Token: 0x0600972B RID: 38699 RVA: 0x0015CC90 File Offset: 0x0015AE90
		// (set) Token: 0x0600972C RID: 38700 RVA: 0x0015CCBB File Offset: 0x0015AEBB
		public virtual bool Back
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Back;
				}
				return this.PocoInterface != null && this.PocoInterface.Back;
			}
			set
			{
				this.GetOrCreatePoco().Back = value;
			}
		}

		// Token: 0x17002F8D RID: 12173
		// (get) Token: 0x0600972D RID: 38701 RVA: 0x0015CCC9 File Offset: 0x0015AEC9
		// (set) Token: 0x0600972E RID: 38702 RVA: 0x0015CCF4 File Offset: 0x0015AEF4
		public virtual bool Left
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Left;
				}
				return this.PocoInterface != null && this.PocoInterface.Left;
			}
			set
			{
				this.GetOrCreatePoco().Left = value;
			}
		}

		// Token: 0x17002F8E RID: 12174
		// (get) Token: 0x0600972F RID: 38703 RVA: 0x0015CD02 File Offset: 0x0015AF02
		// (set) Token: 0x06009730 RID: 38704 RVA: 0x0015CD2D File Offset: 0x0015AF2D
		public virtual bool Right
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Right;
				}
				return this.PocoInterface != null && this.PocoInterface.Right;
			}
			set
			{
				this.GetOrCreatePoco().Right = value;
			}
		}

		// Token: 0x04005C49 RID: 23625
		[Nullable(2)]
		protected new ILimitPlayerMoveNew FbInstance;

		// Token: 0x04005C4A RID: 23626
		[Nullable(2)]
		protected new ILimitPlayerMoveNew_SetValue PocoInterface;
	}
}
