using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A2D RID: 18989
	public struct ICheckFollowShooterActive : IFlatbufferObject
	{
		// Token: 0x17008974 RID: 35188
		// (get) Token: 0x0601DB73 RID: 121715 RVA: 0x0042DEC5 File Offset: 0x0042C0C5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DB74 RID: 121716 RVA: 0x0042DED2 File Offset: 0x0042C0D2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DB75 RID: 121717 RVA: 0x0042DEDC File Offset: 0x0042C0DC
		public static ICheckFollowShooterActive GetRootAsICheckFollowShooterActive(ByteBuffer _bb)
		{
			return ICheckFollowShooterActive.GetRootAsICheckFollowShooterActive(_bb, default(ICheckFollowShooterActive));
		}

		// Token: 0x0601DB76 RID: 121718 RVA: 0x0042DEF8 File Offset: 0x0042C0F8
		public static ICheckFollowShooterActive GetRootAsICheckFollowShooterActive(ByteBuffer _bb, ICheckFollowShooterActive obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DB77 RID: 121719 RVA: 0x0042DF15 File Offset: 0x0042C115
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DB78 RID: 121720 RVA: 0x0042DF24 File Offset: 0x0042C124
		public ICheckFollowShooterActive __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008975 RID: 35189
		// (get) Token: 0x0601DB79 RID: 121721 RVA: 0x0042DF34 File Offset: 0x0042C134
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008976 RID: 35190
		// (get) Token: 0x0601DB7A RID: 121722 RVA: 0x0042DF70 File Offset: 0x0042C170
		public bool Active
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008977 RID: 35191
		// (get) Token: 0x0601DB7B RID: 121723 RVA: 0x0042DFB0 File Offset: 0x0042C1B0
		public int Id
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601DB7C RID: 121724 RVA: 0x0042DFEC File Offset: 0x0042C1EC
		public static Offset<ICheckFollowShooterActive> CreateICheckFollowShooterActive(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, bool Active = false, int Id = 0)
		{
			builder.StartTable(3);
			ICheckFollowShooterActive.AddId(builder, Id);
			ICheckFollowShooterActive.AddActive(builder, Active);
			ICheckFollowShooterActive.AddType(builder, Type);
			return ICheckFollowShooterActive.EndICheckFollowShooterActive(builder);
		}

		// Token: 0x0601DB7D RID: 121725 RVA: 0x0042E010 File Offset: 0x0042C210
		public static void StartICheckFollowShooterActive(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601DB7E RID: 121726 RVA: 0x0042E019 File Offset: 0x0042C219
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DB7F RID: 121727 RVA: 0x0042E024 File Offset: 0x0042C224
		public static void AddActive(FlatBufferBuilder builder, bool active)
		{
			builder.AddBool(1, active, false);
		}

		// Token: 0x0601DB80 RID: 121728 RVA: 0x0042E02F File Offset: 0x0042C22F
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(2, id, 0);
		}

		// Token: 0x0601DB81 RID: 121729 RVA: 0x0042E03A File Offset: 0x0042C23A
		public static Offset<ICheckFollowShooterActive> EndICheckFollowShooterActive(FlatBufferBuilder builder)
		{
			return new Offset<ICheckFollowShooterActive>(builder.EndTable());
		}

		// Token: 0x0601DB82 RID: 121730 RVA: 0x0042E048 File Offset: 0x0042C248
		public ICheckFollowShooterActiveT UnPack()
		{
			ICheckFollowShooterActiveT checkFollowShooterActiveT = new ICheckFollowShooterActiveT();
			this.UnPackTo(checkFollowShooterActiveT);
			return checkFollowShooterActiveT;
		}

		// Token: 0x0601DB83 RID: 121731 RVA: 0x0042E063 File Offset: 0x0042C263
		public void UnPackTo(ICheckFollowShooterActiveT _o)
		{
			_o.Type = this.Type;
			_o.Active = this.Active;
			_o.Id = this.Id;
		}

		// Token: 0x0601DB84 RID: 121732 RVA: 0x0042E08C File Offset: 0x0042C28C
		public static Offset<ICheckFollowShooterActive> Pack(FlatBufferBuilder builder, ICheckFollowShooterActiveT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckFollowShooterActive>);
			}
			return ICheckFollowShooterActive.CreateICheckFollowShooterActive(builder, _o.Type, _o.Active, _o.Id);
		}

		// Token: 0x0400D27F RID: 53887
		private Table __p;
	}
}
