using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A00 RID: 6656
	[NullableContext(1)]
	[Nullable(0)]
	public class IEnterOrbitalCameraControlByMove : IEnterOrbitalCameraType
	{
		// Token: 0x06008E95 RID: 36501 RVA: 0x0014D694 File Offset: 0x0014B894
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

		// Token: 0x06008E96 RID: 36502 RVA: 0x0014D6CC File Offset: 0x0014B8CC
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

		// Token: 0x06008E97 RID: 36503 RVA: 0x0014D6DF File Offset: 0x0014B8DF
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

		// Token: 0x06008E98 RID: 36504 RVA: 0x0014D6F4 File Offset: 0x0014B8F4
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

		// Token: 0x17002D9F RID: 11679
		// (get) Token: 0x06008E99 RID: 36505 RVA: 0x0014D74E File Offset: 0x0014B94E
		// (set) Token: 0x06008E9A RID: 36506 RVA: 0x0014D779 File Offset: 0x0014B979
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

		// Token: 0x17002DA0 RID: 11680
		// (get) Token: 0x06008E9B RID: 36507 RVA: 0x0014D787 File Offset: 0x0014B987
		// (set) Token: 0x06008E9C RID: 36508 RVA: 0x0014D7B2 File Offset: 0x0014B9B2
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

		// Token: 0x17002DA1 RID: 11681
		// (get) Token: 0x06008E9D RID: 36509 RVA: 0x0014D7C0 File Offset: 0x0014B9C0
		// (set) Token: 0x06008E9E RID: 36510 RVA: 0x0014D7EF File Offset: 0x0014B9EF
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

		// Token: 0x17002DA2 RID: 11682
		// (get) Token: 0x06008E9F RID: 36511 RVA: 0x0014D7FD File Offset: 0x0014B9FD
		// (set) Token: 0x06008EA0 RID: 36512 RVA: 0x0014D82C File Offset: 0x0014BA2C
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

		// Token: 0x17002DA3 RID: 11683
		// (get) Token: 0x06008EA1 RID: 36513 RVA: 0x0014D83A File Offset: 0x0014BA3A
		// (set) Token: 0x06008EA2 RID: 36514 RVA: 0x0014D865 File Offset: 0x0014BA65
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

		// Token: 0x17002DA4 RID: 11684
		// (get) Token: 0x06008EA3 RID: 36515 RVA: 0x0014D873 File Offset: 0x0014BA73
		// (set) Token: 0x06008EA4 RID: 36516 RVA: 0x0014D89E File Offset: 0x0014BA9E
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

		// Token: 0x0400585A RID: 22618
		[Nullable(2)]
		protected new IEnterOrbitalCameraControlByMove FbInstance;

		// Token: 0x0400585B RID: 22619
		[Nullable(2)]
		protected new IEnterOrbitalCameraControlByMove_SetValue PocoInterface;
	}
}
