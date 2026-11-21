using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057E1 RID: 22497
	public struct IFixSpeed : IFlatbufferObject
	{
		// Token: 0x1700A2B7 RID: 41655
		// (get) Token: 0x0602457D RID: 148861 RVA: 0x004FE614 File Offset: 0x004FC814
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602457E RID: 148862 RVA: 0x004FE621 File Offset: 0x004FC821
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602457F RID: 148863 RVA: 0x004FE628 File Offset: 0x004FC828
		public static IFixSpeed GetRootAsIFixSpeed(ByteBuffer _bb)
		{
			return IFixSpeed.GetRootAsIFixSpeed(_bb, default(IFixSpeed));
		}

		// Token: 0x06024580 RID: 148864 RVA: 0x004FE644 File Offset: 0x004FC844
		public static IFixSpeed GetRootAsIFixSpeed(ByteBuffer _bb, IFixSpeed obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024581 RID: 148865 RVA: 0x004FE661 File Offset: 0x004FC861
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024582 RID: 148866 RVA: 0x004FE670 File Offset: 0x004FC870
		public IFixSpeed __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A2B8 RID: 41656
		// (get) Token: 0x06024583 RID: 148867 RVA: 0x004FE680 File Offset: 0x004FC880
		public EConveyorBeltMoveType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EConveyorBeltMoveType.FixSpeed;
				}
				return (EConveyorBeltMoveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A2B9 RID: 41657
		// (get) Token: 0x06024584 RID: 148868 RVA: 0x004FE6BC File Offset: 0x004FC8BC
		public int Speed
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

		// Token: 0x06024585 RID: 148869 RVA: 0x004FE6F8 File Offset: 0x004FC8F8
		public static Offset<IFixSpeed> CreateIFixSpeed(FlatBufferBuilder builder, EConveyorBeltMoveType Type = EConveyorBeltMoveType.FixSpeed, int Speed = 0)
		{
			builder.StartTable(2);
			IFixSpeed.AddSpeed(builder, Speed);
			IFixSpeed.AddType(builder, Type);
			return IFixSpeed.EndIFixSpeed(builder);
		}

		// Token: 0x06024586 RID: 148870 RVA: 0x004FE715 File Offset: 0x004FC915
		public static void StartIFixSpeed(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06024587 RID: 148871 RVA: 0x004FE71E File Offset: 0x004FC91E
		public static void AddType(FlatBufferBuilder builder, EConveyorBeltMoveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024588 RID: 148872 RVA: 0x004FE729 File Offset: 0x004FC929
		public static void AddSpeed(FlatBufferBuilder builder, int speed)
		{
			builder.AddInt(1, speed, 0);
		}

		// Token: 0x06024589 RID: 148873 RVA: 0x004FE734 File Offset: 0x004FC934
		public static Offset<IFixSpeed> EndIFixSpeed(FlatBufferBuilder builder)
		{
			return new Offset<IFixSpeed>(builder.EndTable());
		}

		// Token: 0x0602458A RID: 148874 RVA: 0x004FE744 File Offset: 0x004FC944
		public IFixSpeedT UnPack()
		{
			IFixSpeedT fixSpeedT = new IFixSpeedT();
			this.UnPackTo(fixSpeedT);
			return fixSpeedT;
		}

		// Token: 0x0602458B RID: 148875 RVA: 0x004FE75F File Offset: 0x004FC95F
		public void UnPackTo(IFixSpeedT _o)
		{
			_o.Type = this.Type;
			_o.Speed = this.Speed;
		}

		// Token: 0x0602458C RID: 148876 RVA: 0x004FE77C File Offset: 0x004FC97C
		public static Offset<IFixSpeed> Pack(FlatBufferBuilder builder, IFixSpeedT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFixSpeed>);
			}
			return IFixSpeed.CreateIFixSpeed(builder, _o.Type, _o.Speed);
		}

		// Token: 0x0400EFDF RID: 61407
		private Table __p;
	}
}
