using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DA3 RID: 23971
	public struct IEnterLeaveRadius : IFlatbufferObject
	{
		// Token: 0x1700B388 RID: 45960
		// (get) Token: 0x0602906E RID: 168046 RVA: 0x005A24CC File Offset: 0x005A06CC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602906F RID: 168047 RVA: 0x005A24D9 File Offset: 0x005A06D9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029070 RID: 168048 RVA: 0x005A24E0 File Offset: 0x005A06E0
		public static IEnterLeaveRadius GetRootAsIEnterLeaveRadius(ByteBuffer _bb)
		{
			return IEnterLeaveRadius.GetRootAsIEnterLeaveRadius(_bb, default(IEnterLeaveRadius));
		}

		// Token: 0x06029071 RID: 168049 RVA: 0x005A24FC File Offset: 0x005A06FC
		public static IEnterLeaveRadius GetRootAsIEnterLeaveRadius(ByteBuffer _bb, IEnterLeaveRadius obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029072 RID: 168050 RVA: 0x005A2519 File Offset: 0x005A0719
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029073 RID: 168051 RVA: 0x005A2528 File Offset: 0x005A0728
		public IEnterLeaveRadius __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B389 RID: 45961
		// (get) Token: 0x06029074 RID: 168052 RVA: 0x005A2538 File Offset: 0x005A0738
		public int EnterRadius
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B38A RID: 45962
		// (get) Token: 0x06029075 RID: 168053 RVA: 0x005A2574 File Offset: 0x005A0774
		public int LeaveRadius
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029076 RID: 168054 RVA: 0x005A25B0 File Offset: 0x005A07B0
		public static Offset<IEnterLeaveRadius> CreateIEnterLeaveRadius(FlatBufferBuilder builder, int EnterRadius = 0, int LeaveRadius = 0)
		{
			builder.StartTable(2);
			IEnterLeaveRadius.AddLeaveRadius(builder, LeaveRadius);
			IEnterLeaveRadius.AddEnterRadius(builder, EnterRadius);
			return IEnterLeaveRadius.EndIEnterLeaveRadius(builder);
		}

		// Token: 0x06029077 RID: 168055 RVA: 0x005A25CD File Offset: 0x005A07CD
		public static void StartIEnterLeaveRadius(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06029078 RID: 168056 RVA: 0x005A25D6 File Offset: 0x005A07D6
		public static void AddEnterRadius(FlatBufferBuilder builder, int enterRadius)
		{
			builder.AddInt(0, enterRadius, 0);
		}

		// Token: 0x06029079 RID: 168057 RVA: 0x005A25E1 File Offset: 0x005A07E1
		public static void AddLeaveRadius(FlatBufferBuilder builder, int leaveRadius)
		{
			builder.AddInt(1, leaveRadius, 0);
		}

		// Token: 0x0602907A RID: 168058 RVA: 0x005A25EC File Offset: 0x005A07EC
		public static Offset<IEnterLeaveRadius> EndIEnterLeaveRadius(FlatBufferBuilder builder)
		{
			return new Offset<IEnterLeaveRadius>(builder.EndTable());
		}

		// Token: 0x0602907B RID: 168059 RVA: 0x005A25FC File Offset: 0x005A07FC
		public IEnterLeaveRadiusT UnPack()
		{
			IEnterLeaveRadiusT enterLeaveRadiusT = new IEnterLeaveRadiusT();
			this.UnPackTo(enterLeaveRadiusT);
			return enterLeaveRadiusT;
		}

		// Token: 0x0602907C RID: 168060 RVA: 0x005A2617 File Offset: 0x005A0817
		public void UnPackTo(IEnterLeaveRadiusT _o)
		{
			_o.EnterRadius = this.EnterRadius;
			_o.LeaveRadius = this.LeaveRadius;
		}

		// Token: 0x0602907D RID: 168061 RVA: 0x005A2634 File Offset: 0x005A0834
		public static Offset<IEnterLeaveRadius> Pack(FlatBufferBuilder builder, IEnterLeaveRadiusT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnterLeaveRadius>);
			}
			return IEnterLeaveRadius.CreateIEnterLeaveRadius(builder, _o.EnterRadius, _o.LeaveRadius);
		}

		// Token: 0x0400F77E RID: 63358
		private Table __p;
	}
}
