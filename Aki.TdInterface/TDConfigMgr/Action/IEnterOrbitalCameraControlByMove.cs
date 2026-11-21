using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B93 RID: 7059
	public class IEnterOrbitalCameraControlByMove : IEnterOrbitalCameraType
	{
		// Token: 0x060095F7 RID: 38391 RVA: 0x0015D504 File Offset: 0x0015B704
		private IEnterOrbitalCameraControlByMove_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEnterOrbitalCameraControlByMove 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEnterOrbitalCameraControlByMove_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEnterOrbitalCameraControlByMove_SetValue());
			}
			return result;
		}

		// Token: 0x060095F8 RID: 38392 RVA: 0x0015D53C File Offset: 0x0015B73C
		public static IEnterOrbitalCameraControlByMove Create([Nullable(2)] IEnterOrbitalCameraControlByMove instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnterOrbitalCameraControlByMove
			{
				FbInstance = instance
			};
		}

		// Token: 0x060095F9 RID: 38393 RVA: 0x0015D54F File Offset: 0x0015B74F
		public static IEnterOrbitalCameraControlByMove CreateFromSetValue([Nullable(2)] IEnterOrbitalCameraControlByMove_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEnterOrbitalCameraControlByMove
			{
				PocoInterface = value
			};
		}

		// Token: 0x060095FA RID: 38394 RVA: 0x0015D564 File Offset: 0x0015B764
		public new IEnterOrbitalCameraControlByMove_SetValue ToSetValue()
		{
			return new IEnterOrbitalCameraControlByMove_SetValue
			{
				Type = this.Type,
				LevelSequence = this.LevelSequence,
				BlendInTime = this.BlendInTime,
				BlendOutTime = this.BlendOutTime,
				BegEntity = this.BegEntity,
				EndEntity = this.EndEntity
			};
		}

		// Token: 0x17002FAB RID: 12203
		// (get) Token: 0x060095FB RID: 38395 RVA: 0x0015D5BE File Offset: 0x0015B7BE
		// (set) Token: 0x060095FC RID: 38396 RVA: 0x0015D5E9 File Offset: 0x0015B7E9
		public override EEnterOrbitalCameraType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEnterOrbitalCameraType.ControlByMove;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002FAC RID: 12204
		// (get) Token: 0x060095FD RID: 38397 RVA: 0x0015D5F7 File Offset: 0x0015B7F7
		// (set) Token: 0x060095FE RID: 38398 RVA: 0x0015D622 File Offset: 0x0015B822
		public virtual string LevelSequence
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LevelSequence;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.LevelSequence;
			}
			set
			{
				this.GetOrCreatePoco().LevelSequence = value;
			}
		}

		// Token: 0x17002FAD RID: 12205
		// (get) Token: 0x060095FF RID: 38399 RVA: 0x0015D630 File Offset: 0x0015B830
		// (set) Token: 0x06009600 RID: 38400 RVA: 0x0015D65F File Offset: 0x0015B85F
		public virtual float BlendInTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BlendInTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.BlendInTime;
			}
			set
			{
				this.GetOrCreatePoco().BlendInTime = value;
			}
		}

		// Token: 0x17002FAE RID: 12206
		// (get) Token: 0x06009601 RID: 38401 RVA: 0x0015D66D File Offset: 0x0015B86D
		// (set) Token: 0x06009602 RID: 38402 RVA: 0x0015D69C File Offset: 0x0015B89C
		public virtual float BlendOutTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BlendOutTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.BlendOutTime;
			}
			set
			{
				this.GetOrCreatePoco().BlendOutTime = value;
			}
		}

		// Token: 0x17002FAF RID: 12207
		// (get) Token: 0x06009603 RID: 38403 RVA: 0x0015D6AA File Offset: 0x0015B8AA
		// (set) Token: 0x06009604 RID: 38404 RVA: 0x0015D6D5 File Offset: 0x0015B8D5
		public virtual int BegEntity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BegEntity;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.BegEntity;
			}
			set
			{
				this.GetOrCreatePoco().BegEntity = value;
			}
		}

		// Token: 0x17002FB0 RID: 12208
		// (get) Token: 0x06009605 RID: 38405 RVA: 0x0015D6E3 File Offset: 0x0015B8E3
		// (set) Token: 0x06009606 RID: 38406 RVA: 0x0015D70E File Offset: 0x0015B90E
		public virtual int EndEntity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EndEntity;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EndEntity;
			}
			set
			{
				this.GetOrCreatePoco().EndEntity = value;
			}
		}

		// Token: 0x04005CBC RID: 23740
		[Nullable(2)]
		protected new IEnterOrbitalCameraControlByMove FbInstance;

		// Token: 0x04005CBD RID: 23741
		[Nullable(2)]
		protected new IEnterOrbitalCameraControlByMove_SetValue PocoInterface;
	}
}
