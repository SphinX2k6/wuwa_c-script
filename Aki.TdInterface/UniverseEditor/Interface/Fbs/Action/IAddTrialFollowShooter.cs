using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067A2 RID: 26530
	public struct IAddTrialFollowShooter : IFlatbufferObject
	{
		// Token: 0x1700C119 RID: 49433
		// (get) Token: 0x0602D072 RID: 184434 RVA: 0x00627AF5 File Offset: 0x00625CF5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D073 RID: 184435 RVA: 0x00627B02 File Offset: 0x00625D02
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D074 RID: 184436 RVA: 0x00627B0C File Offset: 0x00625D0C
		public static IAddTrialFollowShooter GetRootAsIAddTrialFollowShooter(ByteBuffer _bb)
		{
			return IAddTrialFollowShooter.GetRootAsIAddTrialFollowShooter(_bb, default(IAddTrialFollowShooter));
		}

		// Token: 0x0602D075 RID: 184437 RVA: 0x00627B28 File Offset: 0x00625D28
		public static IAddTrialFollowShooter GetRootAsIAddTrialFollowShooter(ByteBuffer _bb, IAddTrialFollowShooter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D076 RID: 184438 RVA: 0x00627B45 File Offset: 0x00625D45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D077 RID: 184439 RVA: 0x00627B54 File Offset: 0x00625D54
		public IAddTrialFollowShooter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C11A RID: 49434
		// (get) Token: 0x0602D078 RID: 184440 RVA: 0x00627B64 File Offset: 0x00625D64
		public int Id
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

		// Token: 0x1700C11B RID: 49435
		// (get) Token: 0x0602D079 RID: 184441 RVA: 0x00627BA0 File Offset: 0x00625DA0
		public IActiveRange? ActiveRange
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IActiveRange?(default(IActiveRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602D07A RID: 184442 RVA: 0x00627BFD File Offset: 0x00625DFD
		public static Offset<IAddTrialFollowShooter> CreateIAddTrialFollowShooter(FlatBufferBuilder builder, int Id = 0, Offset<IActiveRange> ActiveRangeOffset = default(Offset<IActiveRange>))
		{
			builder.StartTable(2);
			IAddTrialFollowShooter.AddActiveRange(builder, ActiveRangeOffset);
			IAddTrialFollowShooter.AddId(builder, Id);
			return IAddTrialFollowShooter.EndIAddTrialFollowShooter(builder);
		}

		// Token: 0x0602D07B RID: 184443 RVA: 0x00627C1A File Offset: 0x00625E1A
		public static void StartIAddTrialFollowShooter(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602D07C RID: 184444 RVA: 0x00627C23 File Offset: 0x00625E23
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0602D07D RID: 184445 RVA: 0x00627C2E File Offset: 0x00625E2E
		public static void AddActiveRange(FlatBufferBuilder builder, Offset<IActiveRange> activeRangeOffset)
		{
			builder.AddOffset(1, activeRangeOffset.Value, 0);
		}

		// Token: 0x0602D07E RID: 184446 RVA: 0x00627C3E File Offset: 0x00625E3E
		public static Offset<IAddTrialFollowShooter> EndIAddTrialFollowShooter(FlatBufferBuilder builder)
		{
			return new Offset<IAddTrialFollowShooter>(builder.EndTable());
		}

		// Token: 0x0602D07F RID: 184447 RVA: 0x00627C4C File Offset: 0x00625E4C
		public IAddTrialFollowShooterT UnPack()
		{
			IAddTrialFollowShooterT addTrialFollowShooterT = new IAddTrialFollowShooterT();
			this.UnPackTo(addTrialFollowShooterT);
			return addTrialFollowShooterT;
		}

		// Token: 0x0602D080 RID: 184448 RVA: 0x00627C68 File Offset: 0x00625E68
		public void UnPackTo(IAddTrialFollowShooterT _o)
		{
			_o.Id = this.Id;
			_o.ActiveRange = ((this.ActiveRange != null) ? this.ActiveRange.Value.UnPack() : null);
		}

		// Token: 0x0602D081 RID: 184449 RVA: 0x00627CB0 File Offset: 0x00625EB0
		public static Offset<IAddTrialFollowShooter> Pack(FlatBufferBuilder builder, IAddTrialFollowShooterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAddTrialFollowShooter>);
			}
			Offset<IActiveRange> activeRangeOffset = (_o.ActiveRange == null) ? default(Offset<IActiveRange>) : IActiveRange.Pack(builder, _o.ActiveRange);
			return IAddTrialFollowShooter.CreateIAddTrialFollowShooter(builder, _o.Id, activeRangeOffset);
		}

		// Token: 0x04011333 RID: 70451
		private Table __p;
	}
}
