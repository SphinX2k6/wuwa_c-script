using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200765D RID: 30301
	public class TChangeElementalBoxStateTargetUnion
	{
		// Token: 0x1700E5D1 RID: 58833
		// (get) Token: 0x06037298 RID: 225944 RVA: 0x0077A864 File Offset: 0x00778A64
		// (set) Token: 0x06037299 RID: 225945 RVA: 0x0077A86C File Offset: 0x00778A6C
		public TChangeElementalBoxStateTarget Type { get; set; }

		// Token: 0x1700E5D2 RID: 58834
		// (get) Token: 0x0603729A RID: 225946 RVA: 0x0077A875 File Offset: 0x00778A75
		// (set) Token: 0x0603729B RID: 225947 RVA: 0x0077A87D File Offset: 0x00778A7D
		public object Value { get; set; }

		// Token: 0x0603729C RID: 225948 RVA: 0x0077A886 File Offset: 0x00778A86
		public TChangeElementalBoxStateTargetUnion()
		{
			this.Type = TChangeElementalBoxStateTarget.NONE;
			this.Value = null;
		}

		// Token: 0x0603729D RID: 225949 RVA: 0x0077A89C File Offset: 0x00778A9C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603729E RID: 225950 RVA: 0x0077A8AE File Offset: 0x00778AAE
		public IChangeElementalBoxStatePlayerTargetT AsIChangeElementalBoxStatePlayerTarget()
		{
			return this.As<IChangeElementalBoxStatePlayerTargetT>();
		}

		// Token: 0x0603729F RID: 225951 RVA: 0x0077A8B6 File Offset: 0x00778AB6
		public static TChangeElementalBoxStateTargetUnion FromIChangeElementalBoxStatePlayerTarget(IChangeElementalBoxStatePlayerTargetT _ichangeelementalboxstateplayertarget)
		{
			return new TChangeElementalBoxStateTargetUnion
			{
				Type = TChangeElementalBoxStateTarget.IChangeElementalBoxStatePlayerTarget,
				Value = _ichangeelementalboxstateplayertarget
			};
		}

		// Token: 0x060372A0 RID: 225952 RVA: 0x0077A8CB File Offset: 0x00778ACB
		public IChangeElementalBoxStateTargetBoxIdT AsIChangeElementalBoxStateTargetBoxId()
		{
			return this.As<IChangeElementalBoxStateTargetBoxIdT>();
		}

		// Token: 0x060372A1 RID: 225953 RVA: 0x0077A8D3 File Offset: 0x00778AD3
		public static TChangeElementalBoxStateTargetUnion FromIChangeElementalBoxStateTargetBoxId(IChangeElementalBoxStateTargetBoxIdT _ichangeelementalboxstatetargetboxid)
		{
			return new TChangeElementalBoxStateTargetUnion
			{
				Type = TChangeElementalBoxStateTarget.IChangeElementalBoxStateTargetBoxId,
				Value = _ichangeelementalboxstatetargetboxid
			};
		}

		// Token: 0x060372A2 RID: 225954 RVA: 0x0077A8E8 File Offset: 0x00778AE8
		public static int Pack(FlatBufferBuilder builder, TChangeElementalBoxStateTargetUnion _o)
		{
			TChangeElementalBoxStateTarget type = _o.Type;
			if (type == TChangeElementalBoxStateTarget.IChangeElementalBoxStatePlayerTarget)
			{
				return IChangeElementalBoxStatePlayerTarget.Pack(builder, _o.AsIChangeElementalBoxStatePlayerTarget()).Value;
			}
			if (type != TChangeElementalBoxStateTarget.IChangeElementalBoxStateTargetBoxId)
			{
				return 0;
			}
			return IChangeElementalBoxStateTargetBoxId.Pack(builder, _o.AsIChangeElementalBoxStateTargetBoxId()).Value;
		}
	}
}
