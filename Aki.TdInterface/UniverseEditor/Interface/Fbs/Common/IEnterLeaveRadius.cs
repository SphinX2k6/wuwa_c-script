using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063E0 RID: 25568
	public struct IEnterLeaveRadius : IFlatbufferObject
	{
		// Token: 0x1700BCEE RID: 48366
		// (get) Token: 0x0602B6F8 RID: 177912 RVA: 0x005EB1FC File Offset: 0x005E93FC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B6F9 RID: 177913 RVA: 0x005EB209 File Offset: 0x005E9409
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B6FA RID: 177914 RVA: 0x005EB210 File Offset: 0x005E9410
		public static IEnterLeaveRadius GetRootAsIEnterLeaveRadius(ByteBuffer _bb)
		{
			return IEnterLeaveRadius.GetRootAsIEnterLeaveRadius(_bb, default(IEnterLeaveRadius));
		}

		// Token: 0x0602B6FB RID: 177915 RVA: 0x005EB22C File Offset: 0x005E942C
		public static IEnterLeaveRadius GetRootAsIEnterLeaveRadius(ByteBuffer _bb, IEnterLeaveRadius obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B6FC RID: 177916 RVA: 0x005EB249 File Offset: 0x005E9449
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B6FD RID: 177917 RVA: 0x005EB258 File Offset: 0x005E9458
		public IEnterLeaveRadius __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BCEF RID: 48367
		// (get) Token: 0x0602B6FE RID: 177918 RVA: 0x005EB268 File Offset: 0x005E9468
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

		// Token: 0x1700BCF0 RID: 48368
		// (get) Token: 0x0602B6FF RID: 177919 RVA: 0x005EB2A4 File Offset: 0x005E94A4
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

		// Token: 0x0602B700 RID: 177920 RVA: 0x005EB2E0 File Offset: 0x005E94E0
		public static Offset<IEnterLeaveRadius> CreateIEnterLeaveRadius(FlatBufferBuilder builder, int EnterRadius = 0, int LeaveRadius = 0)
		{
			builder.StartTable(2);
			IEnterLeaveRadius.AddLeaveRadius(builder, LeaveRadius);
			IEnterLeaveRadius.AddEnterRadius(builder, EnterRadius);
			return IEnterLeaveRadius.EndIEnterLeaveRadius(builder);
		}

		// Token: 0x0602B701 RID: 177921 RVA: 0x005EB2FD File Offset: 0x005E94FD
		public static void StartIEnterLeaveRadius(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B702 RID: 177922 RVA: 0x005EB306 File Offset: 0x005E9506
		public static void AddEnterRadius(FlatBufferBuilder builder, int enterRadius)
		{
			builder.AddInt(0, enterRadius, 0);
		}

		// Token: 0x0602B703 RID: 177923 RVA: 0x005EB311 File Offset: 0x005E9511
		public static void AddLeaveRadius(FlatBufferBuilder builder, int leaveRadius)
		{
			builder.AddInt(1, leaveRadius, 0);
		}

		// Token: 0x0602B704 RID: 177924 RVA: 0x005EB31C File Offset: 0x005E951C
		public static Offset<IEnterLeaveRadius> EndIEnterLeaveRadius(FlatBufferBuilder builder)
		{
			return new Offset<IEnterLeaveRadius>(builder.EndTable());
		}

		// Token: 0x0602B705 RID: 177925 RVA: 0x005EB32C File Offset: 0x005E952C
		public IEnterLeaveRadiusT UnPack()
		{
			IEnterLeaveRadiusT enterLeaveRadiusT = new IEnterLeaveRadiusT();
			this.UnPackTo(enterLeaveRadiusT);
			return enterLeaveRadiusT;
		}

		// Token: 0x0602B706 RID: 177926 RVA: 0x005EB347 File Offset: 0x005E9547
		public void UnPackTo(IEnterLeaveRadiusT _o)
		{
			_o.EnterRadius = this.EnterRadius;
			_o.LeaveRadius = this.LeaveRadius;
		}

		// Token: 0x0602B707 RID: 177927 RVA: 0x005EB364 File Offset: 0x005E9564
		public static Offset<IEnterLeaveRadius> Pack(FlatBufferBuilder builder, IEnterLeaveRadiusT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnterLeaveRadius>);
			}
			return IEnterLeaveRadius.CreateIEnterLeaveRadius(builder, _o.EnterRadius, _o.LeaveRadius);
		}

		// Token: 0x040104D9 RID: 66777
		private Table __p;
	}
}
