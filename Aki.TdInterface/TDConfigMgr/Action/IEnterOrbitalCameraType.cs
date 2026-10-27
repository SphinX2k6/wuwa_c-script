using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A02 RID: 6658
	[NullableContext(1)]
	[Nullable(0)]
	public class IEnterOrbitalCameraType
	{
		// Token: 0x06008EA7 RID: 36519 RVA: 0x0014D8BC File Offset: 0x0014BABC
		private IEnterOrbitalCameraType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEnterOrbitalCameraType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEnterOrbitalCameraType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEnterOrbitalCameraType_SetValue());
			}
			return result;
		}

		// Token: 0x06008EA8 RID: 36520 RVA: 0x0014D8F4 File Offset: 0x0014BAF4
		public static IEnterOrbitalCameraType Create([Nullable(2)] IEnterOrbitalCameraType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnterOrbitalCameraType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008EA9 RID: 36521 RVA: 0x0014D907 File Offset: 0x0014BB07
		public static IEnterOrbitalCameraType CreateFromSetValue([Nullable(2)] IEnterOrbitalCameraType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEnterOrbitalCameraType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008EAA RID: 36522 RVA: 0x0014D91A File Offset: 0x0014BB1A
		public IEnterOrbitalCameraType_SetValue ToSetValue()
		{
			return new IEnterOrbitalCameraType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002DA5 RID: 11685
		// (get) Token: 0x06008EAB RID: 36523 RVA: 0x0014D92D File Offset: 0x0014BB2D
		// (set) Token: 0x06008EAC RID: 36524 RVA: 0x0014D958 File Offset: 0x0014BB58
		public virtual EEnterOrbitalCameraType Type
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

		// Token: 0x04005862 RID: 22626
		[Nullable(2)]
		protected IEnterOrbitalCameraType FbInstance;

		// Token: 0x04005863 RID: 22627
		[Nullable(2)]
		protected IEnterOrbitalCameraType_SetValue PocoInterface;
	}
}
