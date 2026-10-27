using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001812 RID: 6162
	[NullableContext(2)]
	[Nullable(0)]
	public class IBounce : ILeisureInteractType
	{
		// Token: 0x06008441 RID: 33857 RVA: 0x0013B2D8 File Offset: 0x001394D8
		[NullableContext(1)]
		private IBounce_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBounce 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBounce_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBounce_SetValue());
			}
			return result;
		}

		// Token: 0x06008442 RID: 33858 RVA: 0x0013B310 File Offset: 0x00139510
		[NullableContext(1)]
		public static IBounce Create([Nullable(2)] IBounce instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBounce
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008443 RID: 33859 RVA: 0x0013B323 File Offset: 0x00139523
		[NullableContext(1)]
		public static IBounce CreateFromSetValue([Nullable(2)] IBounce_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBounce
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008444 RID: 33860 RVA: 0x0013B336 File Offset: 0x00139536
		[NullableContext(1)]
		public new IBounce_SetValue ToSetValue()
		{
			return new IBounce_SetValue
			{
				Type = this.Type,
				Height = this.Height,
				Time = this.Time,
				MotionCurve = this.MotionCurve
			};
		}

		// Token: 0x17002B5A RID: 11098
		// (get) Token: 0x06008445 RID: 33861 RVA: 0x0013B36D File Offset: 0x0013956D
		// (set) Token: 0x06008446 RID: 33862 RVA: 0x0013B398 File Offset: 0x00139598
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

		// Token: 0x17002B5B RID: 11099
		// (get) Token: 0x06008447 RID: 33863 RVA: 0x0013B3A6 File Offset: 0x001395A6
		// (set) Token: 0x06008448 RID: 33864 RVA: 0x0013B3D1 File Offset: 0x001395D1
		public virtual int Height
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Height;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Height;
			}
			set
			{
				this.GetOrCreatePoco().Height = value;
			}
		}

		// Token: 0x17002B5C RID: 11100
		// (get) Token: 0x06008449 RID: 33865 RVA: 0x0013B3E0 File Offset: 0x001395E0
		// (set) Token: 0x0600844A RID: 33866 RVA: 0x0013B41A File Offset: 0x0013961A
		public virtual float? Time
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Time;
				}
				IBounce_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Time;
			}
			set
			{
				this.GetOrCreatePoco().Time = value;
			}
		}

		// Token: 0x17002B5D RID: 11101
		// (get) Token: 0x0600844B RID: 33867 RVA: 0x0013B428 File Offset: 0x00139628
		// (set) Token: 0x0600844C RID: 33868 RVA: 0x0013B44F File Offset: 0x0013964F
		public virtual string MotionCurve
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MotionCurve;
				}
				IBounce_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MotionCurve;
			}
			set
			{
				this.GetOrCreatePoco().MotionCurve = value;
			}
		}

		// Token: 0x040053BB RID: 21435
		protected new IBounce FbInstance;

		// Token: 0x040053BC RID: 21436
		protected new IBounce_SetValue PocoInterface;
	}
}
