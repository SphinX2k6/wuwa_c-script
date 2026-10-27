using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006095 RID: 24725
	public struct IActiveAntiGravitySafePoint : IFlatbufferObject
	{
		// Token: 0x1700B62F RID: 46639
		// (get) Token: 0x0602A333 RID: 172851 RVA: 0x005D18FE File Offset: 0x005CFAFE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A334 RID: 172852 RVA: 0x005D190B File Offset: 0x005CFB0B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A335 RID: 172853 RVA: 0x005D1914 File Offset: 0x005CFB14
		public static IActiveAntiGravitySafePoint GetRootAsIActiveAntiGravitySafePoint(ByteBuffer _bb)
		{
			return IActiveAntiGravitySafePoint.GetRootAsIActiveAntiGravitySafePoint(_bb, default(IActiveAntiGravitySafePoint));
		}

		// Token: 0x0602A336 RID: 172854 RVA: 0x005D1930 File Offset: 0x005CFB30
		public static IActiveAntiGravitySafePoint GetRootAsIActiveAntiGravitySafePoint(ByteBuffer _bb, IActiveAntiGravitySafePoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A337 RID: 172855 RVA: 0x005D194D File Offset: 0x005CFB4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A338 RID: 172856 RVA: 0x005D195C File Offset: 0x005CFB5C
		public IActiveAntiGravitySafePoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602A339 RID: 172857 RVA: 0x005D196C File Offset: 0x005CFB6C
		public static void StartIActiveAntiGravitySafePoint(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0602A33A RID: 172858 RVA: 0x005D1975 File Offset: 0x005CFB75
		public static Offset<IActiveAntiGravitySafePoint> EndIActiveAntiGravitySafePoint(FlatBufferBuilder builder)
		{
			return new Offset<IActiveAntiGravitySafePoint>(builder.EndTable());
		}

		// Token: 0x0602A33B RID: 172859 RVA: 0x005D1984 File Offset: 0x005CFB84
		public IActiveAntiGravitySafePointT UnPack()
		{
			IActiveAntiGravitySafePointT activeAntiGravitySafePointT = new IActiveAntiGravitySafePointT();
			this.UnPackTo(activeAntiGravitySafePointT);
			return activeAntiGravitySafePointT;
		}

		// Token: 0x0602A33C RID: 172860 RVA: 0x005D199F File Offset: 0x005CFB9F
		public void UnPackTo(IActiveAntiGravitySafePointT _o)
		{
		}

		// Token: 0x0602A33D RID: 172861 RVA: 0x005D19A4 File Offset: 0x005CFBA4
		public static Offset<IActiveAntiGravitySafePoint> Pack(FlatBufferBuilder builder, IActiveAntiGravitySafePointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActiveAntiGravitySafePoint>);
			}
			IActiveAntiGravitySafePoint.StartIActiveAntiGravitySafePoint(builder);
			return IActiveAntiGravitySafePoint.EndIActiveAntiGravitySafePoint(builder);
		}

		// Token: 0x0401042A RID: 66602
		private Table __p;
	}
}
