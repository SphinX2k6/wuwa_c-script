using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019DF RID: 6623
	public class ICameraTransition : ILevelSequenceTransitionType
	{
		// Token: 0x06008CF5 RID: 36085 RVA: 0x0014DAA0 File Offset: 0x0014BCA0
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

		// Token: 0x06008CF6 RID: 36086 RVA: 0x0014DAD8 File Offset: 0x0014BCD8
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

		// Token: 0x06008CF7 RID: 36087 RVA: 0x0014DAEB File Offset: 0x0014BCEB
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

		// Token: 0x06008CF8 RID: 36088 RVA: 0x0014DAFE File Offset: 0x0014BCFE
		public new ICameraTransition_SetValue ToSetValue()
		{
			return new ICameraTransition_SetValue
			{
				Type = this.Type,
				Duration = this.Duration
			};
		}

		// Token: 0x17002DB8 RID: 11704
		// (get) Token: 0x06008CF9 RID: 36089 RVA: 0x0014DB1D File Offset: 0x0014BD1D
		// (set) Token: 0x06008CFA RID: 36090 RVA: 0x0014DB48 File Offset: 0x0014BD48
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

		// Token: 0x17002DB9 RID: 11705
		// (get) Token: 0x06008CFB RID: 36091 RVA: 0x0014DB58 File Offset: 0x0014BD58
		// (set) Token: 0x06008CFC RID: 36092 RVA: 0x0014DB92 File Offset: 0x0014BD92
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

		// Token: 0x040058C9 RID: 22729
		[Nullable(2)]
		protected new ICameraTransition FbInstance;

		// Token: 0x040058CA RID: 22730
		[Nullable(2)]
		protected new ICameraTransition_SetValue PocoInterface;
	}
}
