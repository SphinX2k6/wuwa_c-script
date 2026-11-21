using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075F4 RID: 30196
	public struct IRemoveTrialFollowShooter : IFlatbufferObject
	{
		// Token: 0x1700DDF0 RID: 56816
		// (get) Token: 0x06034FB4 RID: 217012 RVA: 0x0071E296 File Offset: 0x0071C496
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034FB5 RID: 217013 RVA: 0x0071E2A3 File Offset: 0x0071C4A3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034FB6 RID: 217014 RVA: 0x0071E2AC File Offset: 0x0071C4AC
		public static IRemoveTrialFollowShooter GetRootAsIRemoveTrialFollowShooter(ByteBuffer _bb)
		{
			return IRemoveTrialFollowShooter.GetRootAsIRemoveTrialFollowShooter(_bb, default(IRemoveTrialFollowShooter));
		}

		// Token: 0x06034FB7 RID: 217015 RVA: 0x0071E2C8 File Offset: 0x0071C4C8
		public static IRemoveTrialFollowShooter GetRootAsIRemoveTrialFollowShooter(ByteBuffer _bb, IRemoveTrialFollowShooter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034FB8 RID: 217016 RVA: 0x0071E2E5 File Offset: 0x0071C4E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034FB9 RID: 217017 RVA: 0x0071E2F4 File Offset: 0x0071C4F4
		public IRemoveTrialFollowShooter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DDF1 RID: 56817
		// (get) Token: 0x06034FBA RID: 217018 RVA: 0x0071E304 File Offset: 0x0071C504
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

		// Token: 0x06034FBB RID: 217019 RVA: 0x0071E340 File Offset: 0x0071C540
		public static Offset<IRemoveTrialFollowShooter> CreateIRemoveTrialFollowShooter(FlatBufferBuilder builder, int Id = 0)
		{
			builder.StartTable(1);
			IRemoveTrialFollowShooter.AddId(builder, Id);
			return IRemoveTrialFollowShooter.EndIRemoveTrialFollowShooter(builder);
		}

		// Token: 0x06034FBC RID: 217020 RVA: 0x0071E356 File Offset: 0x0071C556
		public static void StartIRemoveTrialFollowShooter(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06034FBD RID: 217021 RVA: 0x0071E35F File Offset: 0x0071C55F
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x06034FBE RID: 217022 RVA: 0x0071E36A File Offset: 0x0071C56A
		public static Offset<IRemoveTrialFollowShooter> EndIRemoveTrialFollowShooter(FlatBufferBuilder builder)
		{
			return new Offset<IRemoveTrialFollowShooter>(builder.EndTable());
		}

		// Token: 0x06034FBF RID: 217023 RVA: 0x0071E378 File Offset: 0x0071C578
		public IRemoveTrialFollowShooterT UnPack()
		{
			IRemoveTrialFollowShooterT removeTrialFollowShooterT = new IRemoveTrialFollowShooterT();
			this.UnPackTo(removeTrialFollowShooterT);
			return removeTrialFollowShooterT;
		}

		// Token: 0x06034FC0 RID: 217024 RVA: 0x0071E393 File Offset: 0x0071C593
		public void UnPackTo(IRemoveTrialFollowShooterT _o)
		{
			_o.Id = this.Id;
		}

		// Token: 0x06034FC1 RID: 217025 RVA: 0x0071E3A4 File Offset: 0x0071C5A4
		public static Offset<IRemoveTrialFollowShooter> Pack(FlatBufferBuilder builder, IRemoveTrialFollowShooterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRemoveTrialFollowShooter>);
			}
			return IRemoveTrialFollowShooter.CreateIRemoveTrialFollowShooter(builder, _o.Id);
		}

		// Token: 0x040127E3 RID: 75747
		private Table __p;
	}
}
