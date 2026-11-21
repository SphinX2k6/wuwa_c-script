using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EF0 RID: 20208
	public struct ICheckFollowShooterActive : IFlatbufferObject
	{
		// Token: 0x17009049 RID: 36937
		// (get) Token: 0x0601F5FC RID: 128508 RVA: 0x0045EDBD File Offset: 0x0045CFBD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F5FD RID: 128509 RVA: 0x0045EDCA File Offset: 0x0045CFCA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F5FE RID: 128510 RVA: 0x0045EDD4 File Offset: 0x0045CFD4
		public static ICheckFollowShooterActive GetRootAsICheckFollowShooterActive(ByteBuffer _bb)
		{
			return ICheckFollowShooterActive.GetRootAsICheckFollowShooterActive(_bb, default(ICheckFollowShooterActive));
		}

		// Token: 0x0601F5FF RID: 128511 RVA: 0x0045EDF0 File Offset: 0x0045CFF0
		public static ICheckFollowShooterActive GetRootAsICheckFollowShooterActive(ByteBuffer _bb, ICheckFollowShooterActive obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F600 RID: 128512 RVA: 0x0045EE0D File Offset: 0x0045D00D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F601 RID: 128513 RVA: 0x0045EE1C File Offset: 0x0045D01C
		public ICheckFollowShooterActive __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700904A RID: 36938
		// (get) Token: 0x0601F602 RID: 128514 RVA: 0x0045EE2C File Offset: 0x0045D02C
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

		// Token: 0x1700904B RID: 36939
		// (get) Token: 0x0601F603 RID: 128515 RVA: 0x0045EE68 File Offset: 0x0045D068
		public bool Active
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700904C RID: 36940
		// (get) Token: 0x0601F604 RID: 128516 RVA: 0x0045EEA8 File Offset: 0x0045D0A8
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

		// Token: 0x0601F605 RID: 128517 RVA: 0x0045EEE4 File Offset: 0x0045D0E4
		public static Offset<ICheckFollowShooterActive> CreateICheckFollowShooterActive(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, bool Active = false, int Id = 0)
		{
			builder.StartTable(3);
			ICheckFollowShooterActive.AddId(builder, Id);
			ICheckFollowShooterActive.AddActive(builder, Active);
			ICheckFollowShooterActive.AddType(builder, Type);
			return ICheckFollowShooterActive.EndICheckFollowShooterActive(builder);
		}

		// Token: 0x0601F606 RID: 128518 RVA: 0x0045EF08 File Offset: 0x0045D108
		public static void StartICheckFollowShooterActive(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601F607 RID: 128519 RVA: 0x0045EF11 File Offset: 0x0045D111
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F608 RID: 128520 RVA: 0x0045EF1C File Offset: 0x0045D11C
		public static void AddActive(FlatBufferBuilder builder, bool active)
		{
			builder.AddBool(1, active, false);
		}

		// Token: 0x0601F609 RID: 128521 RVA: 0x0045EF27 File Offset: 0x0045D127
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(2, id, 0);
		}

		// Token: 0x0601F60A RID: 128522 RVA: 0x0045EF32 File Offset: 0x0045D132
		public static Offset<ICheckFollowShooterActive> EndICheckFollowShooterActive(FlatBufferBuilder builder)
		{
			return new Offset<ICheckFollowShooterActive>(builder.EndTable());
		}

		// Token: 0x0601F60B RID: 128523 RVA: 0x0045EF40 File Offset: 0x0045D140
		public ICheckFollowShooterActiveT UnPack()
		{
			ICheckFollowShooterActiveT checkFollowShooterActiveT = new ICheckFollowShooterActiveT();
			this.UnPackTo(checkFollowShooterActiveT);
			return checkFollowShooterActiveT;
		}

		// Token: 0x0601F60C RID: 128524 RVA: 0x0045EF5B File Offset: 0x0045D15B
		public void UnPackTo(ICheckFollowShooterActiveT _o)
		{
			_o.Type = this.Type;
			_o.Active = this.Active;
			_o.Id = this.Id;
		}

		// Token: 0x0601F60D RID: 128525 RVA: 0x0045EF84 File Offset: 0x0045D184
		public static Offset<ICheckFollowShooterActive> Pack(FlatBufferBuilder builder, ICheckFollowShooterActiveT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckFollowShooterActive>);
			}
			return ICheckFollowShooterActive.CreateICheckFollowShooterActive(builder, _o.Type, _o.Active, _o.Id);
		}

		// Token: 0x0400DD56 RID: 56662
		private Table __p;
	}
}
