using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E70 RID: 28272
	public struct IRemoveTrialFollowShooter : IFlatbufferObject
	{
		// Token: 0x1700D299 RID: 53913
		// (get) Token: 0x06031F74 RID: 204660 RVA: 0x006C2562 File Offset: 0x006C0762
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031F75 RID: 204661 RVA: 0x006C256F File Offset: 0x006C076F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031F76 RID: 204662 RVA: 0x006C2578 File Offset: 0x006C0778
		public static IRemoveTrialFollowShooter GetRootAsIRemoveTrialFollowShooter(ByteBuffer _bb)
		{
			return IRemoveTrialFollowShooter.GetRootAsIRemoveTrialFollowShooter(_bb, default(IRemoveTrialFollowShooter));
		}

		// Token: 0x06031F77 RID: 204663 RVA: 0x006C2594 File Offset: 0x006C0794
		public static IRemoveTrialFollowShooter GetRootAsIRemoveTrialFollowShooter(ByteBuffer _bb, IRemoveTrialFollowShooter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031F78 RID: 204664 RVA: 0x006C25B1 File Offset: 0x006C07B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031F79 RID: 204665 RVA: 0x006C25C0 File Offset: 0x006C07C0
		public IRemoveTrialFollowShooter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D29A RID: 53914
		// (get) Token: 0x06031F7A RID: 204666 RVA: 0x006C25D0 File Offset: 0x006C07D0
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

		// Token: 0x06031F7B RID: 204667 RVA: 0x006C260C File Offset: 0x006C080C
		public static Offset<IRemoveTrialFollowShooter> CreateIRemoveTrialFollowShooter(FlatBufferBuilder builder, int Id = 0)
		{
			builder.StartTable(1);
			IRemoveTrialFollowShooter.AddId(builder, Id);
			return IRemoveTrialFollowShooter.EndIRemoveTrialFollowShooter(builder);
		}

		// Token: 0x06031F7C RID: 204668 RVA: 0x006C2622 File Offset: 0x006C0822
		public static void StartIRemoveTrialFollowShooter(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031F7D RID: 204669 RVA: 0x006C262B File Offset: 0x006C082B
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x06031F7E RID: 204670 RVA: 0x006C2636 File Offset: 0x006C0836
		public static Offset<IRemoveTrialFollowShooter> EndIRemoveTrialFollowShooter(FlatBufferBuilder builder)
		{
			return new Offset<IRemoveTrialFollowShooter>(builder.EndTable());
		}

		// Token: 0x06031F7F RID: 204671 RVA: 0x006C2644 File Offset: 0x006C0844
		public IRemoveTrialFollowShooterT UnPack()
		{
			IRemoveTrialFollowShooterT removeTrialFollowShooterT = new IRemoveTrialFollowShooterT();
			this.UnPackTo(removeTrialFollowShooterT);
			return removeTrialFollowShooterT;
		}

		// Token: 0x06031F80 RID: 204672 RVA: 0x006C265F File Offset: 0x006C085F
		public void UnPackTo(IRemoveTrialFollowShooterT _o)
		{
			_o.Id = this.Id;
		}

		// Token: 0x06031F81 RID: 204673 RVA: 0x006C2670 File Offset: 0x006C0870
		public static Offset<IRemoveTrialFollowShooter> Pack(FlatBufferBuilder builder, IRemoveTrialFollowShooterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRemoveTrialFollowShooter>);
			}
			return IRemoveTrialFollowShooter.CreateIRemoveTrialFollowShooter(builder, _o.Id);
		}

		// Token: 0x0401185E RID: 71774
		private Table __p;
	}
}
