using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FB0 RID: 20400
	public struct ICheckPlayerCanJoinActivityType : IFlatbufferObject
	{
		// Token: 0x170091E8 RID: 37352
		// (get) Token: 0x0601FCB3 RID: 130227 RVA: 0x0046AD18 File Offset: 0x00468F18
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FCB4 RID: 130228 RVA: 0x0046AD25 File Offset: 0x00468F25
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FCB5 RID: 130229 RVA: 0x0046AD2C File Offset: 0x00468F2C
		public static ICheckPlayerCanJoinActivityType GetRootAsICheckPlayerCanJoinActivityType(ByteBuffer _bb)
		{
			return ICheckPlayerCanJoinActivityType.GetRootAsICheckPlayerCanJoinActivityType(_bb, default(ICheckPlayerCanJoinActivityType));
		}

		// Token: 0x0601FCB6 RID: 130230 RVA: 0x0046AD48 File Offset: 0x00468F48
		public static ICheckPlayerCanJoinActivityType GetRootAsICheckPlayerCanJoinActivityType(ByteBuffer _bb, ICheckPlayerCanJoinActivityType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FCB7 RID: 130231 RVA: 0x0046AD65 File Offset: 0x00468F65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FCB8 RID: 130232 RVA: 0x0046AD74 File Offset: 0x00468F74
		public ICheckPlayerCanJoinActivityType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170091E9 RID: 37353
		// (get) Token: 0x0601FCB9 RID: 130233 RVA: 0x0046AD84 File Offset: 0x00468F84
		public ECheckPlayerCanJoinActivityType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckPlayerCanJoinActivityType.Rogue;
				}
				return (ECheckPlayerCanJoinActivityType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170091EA RID: 37354
		// (get) Token: 0x0601FCBA RID: 130234 RVA: 0x0046ADC0 File Offset: 0x00468FC0
		public bool CanJoin
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601FCBB RID: 130235 RVA: 0x0046ADFF File Offset: 0x00468FFF
		public static Offset<ICheckPlayerCanJoinActivityType> CreateICheckPlayerCanJoinActivityType(FlatBufferBuilder builder, ECheckPlayerCanJoinActivityType Type = ECheckPlayerCanJoinActivityType.Rogue, bool CanJoin = false)
		{
			builder.StartTable(2);
			ICheckPlayerCanJoinActivityType.AddCanJoin(builder, CanJoin);
			ICheckPlayerCanJoinActivityType.AddType(builder, Type);
			return ICheckPlayerCanJoinActivityType.EndICheckPlayerCanJoinActivityType(builder);
		}

		// Token: 0x0601FCBC RID: 130236 RVA: 0x0046AE1C File Offset: 0x0046901C
		public static void StartICheckPlayerCanJoinActivityType(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601FCBD RID: 130237 RVA: 0x0046AE25 File Offset: 0x00469025
		public static void AddType(FlatBufferBuilder builder, ECheckPlayerCanJoinActivityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FCBE RID: 130238 RVA: 0x0046AE30 File Offset: 0x00469030
		public static void AddCanJoin(FlatBufferBuilder builder, bool canJoin)
		{
			builder.AddBool(1, canJoin, false);
		}

		// Token: 0x0601FCBF RID: 130239 RVA: 0x0046AE3B File Offset: 0x0046903B
		public static Offset<ICheckPlayerCanJoinActivityType> EndICheckPlayerCanJoinActivityType(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPlayerCanJoinActivityType>(builder.EndTable());
		}

		// Token: 0x0601FCC0 RID: 130240 RVA: 0x0046AE48 File Offset: 0x00469048
		public ICheckPlayerCanJoinActivityTypeT UnPack()
		{
			ICheckPlayerCanJoinActivityTypeT checkPlayerCanJoinActivityTypeT = new ICheckPlayerCanJoinActivityTypeT();
			this.UnPackTo(checkPlayerCanJoinActivityTypeT);
			return checkPlayerCanJoinActivityTypeT;
		}

		// Token: 0x0601FCC1 RID: 130241 RVA: 0x0046AE63 File Offset: 0x00469063
		public void UnPackTo(ICheckPlayerCanJoinActivityTypeT _o)
		{
			_o.Type = this.Type;
			_o.CanJoin = this.CanJoin;
		}

		// Token: 0x0601FCC2 RID: 130242 RVA: 0x0046AE80 File Offset: 0x00469080
		public static Offset<ICheckPlayerCanJoinActivityType> Pack(FlatBufferBuilder builder, ICheckPlayerCanJoinActivityTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckPlayerCanJoinActivityType>);
			}
			return ICheckPlayerCanJoinActivityType.CreateICheckPlayerCanJoinActivityType(builder, _o.Type, _o.CanJoin);
		}

		// Token: 0x0400DE50 RID: 56912
		private Table __p;
	}
}
