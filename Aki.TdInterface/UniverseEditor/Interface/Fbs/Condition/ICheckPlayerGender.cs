using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AEA RID: 19178
	public struct ICheckPlayerGender : IFlatbufferObject
	{
		// Token: 0x17008B10 RID: 35600
		// (get) Token: 0x0601E228 RID: 123432 RVA: 0x0043A1B0 File Offset: 0x004383B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E229 RID: 123433 RVA: 0x0043A1BD File Offset: 0x004383BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E22A RID: 123434 RVA: 0x0043A1C4 File Offset: 0x004383C4
		public static ICheckPlayerGender GetRootAsICheckPlayerGender(ByteBuffer _bb)
		{
			return ICheckPlayerGender.GetRootAsICheckPlayerGender(_bb, default(ICheckPlayerGender));
		}

		// Token: 0x0601E22B RID: 123435 RVA: 0x0043A1E0 File Offset: 0x004383E0
		public static ICheckPlayerGender GetRootAsICheckPlayerGender(ByteBuffer _bb, ICheckPlayerGender obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E22C RID: 123436 RVA: 0x0043A1FD File Offset: 0x004383FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E22D RID: 123437 RVA: 0x0043A20C File Offset: 0x0043840C
		public ICheckPlayerGender __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008B11 RID: 35601
		// (get) Token: 0x0601E22E RID: 123438 RVA: 0x0043A21C File Offset: 0x0043841C
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

		// Token: 0x17008B12 RID: 35602
		// (get) Token: 0x0601E22F RID: 123439 RVA: 0x0043A258 File Offset: 0x00438458
		public EGender Gender
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EGender.M;
				}
				return (EGender)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E230 RID: 123440 RVA: 0x0043A294 File Offset: 0x00438494
		public static Offset<ICheckPlayerGender> CreateICheckPlayerGender(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, EGender Gender = EGender.M)
		{
			builder.StartTable(2);
			ICheckPlayerGender.AddGender(builder, Gender);
			ICheckPlayerGender.AddType(builder, Type);
			return ICheckPlayerGender.EndICheckPlayerGender(builder);
		}

		// Token: 0x0601E231 RID: 123441 RVA: 0x0043A2B1 File Offset: 0x004384B1
		public static void StartICheckPlayerGender(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601E232 RID: 123442 RVA: 0x0043A2BA File Offset: 0x004384BA
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E233 RID: 123443 RVA: 0x0043A2C5 File Offset: 0x004384C5
		public static void AddGender(FlatBufferBuilder builder, EGender gender)
		{
			builder.AddByte(1, (byte)gender, 0);
		}

		// Token: 0x0601E234 RID: 123444 RVA: 0x0043A2D0 File Offset: 0x004384D0
		public static Offset<ICheckPlayerGender> EndICheckPlayerGender(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPlayerGender>(builder.EndTable());
		}

		// Token: 0x0601E235 RID: 123445 RVA: 0x0043A2E0 File Offset: 0x004384E0
		public ICheckPlayerGenderT UnPack()
		{
			ICheckPlayerGenderT checkPlayerGenderT = new ICheckPlayerGenderT();
			this.UnPackTo(checkPlayerGenderT);
			return checkPlayerGenderT;
		}

		// Token: 0x0601E236 RID: 123446 RVA: 0x0043A2FB File Offset: 0x004384FB
		public void UnPackTo(ICheckPlayerGenderT _o)
		{
			_o.Type = this.Type;
			_o.Gender = this.Gender;
		}

		// Token: 0x0601E237 RID: 123447 RVA: 0x0043A318 File Offset: 0x00438518
		public static Offset<ICheckPlayerGender> Pack(FlatBufferBuilder builder, ICheckPlayerGenderT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckPlayerGender>);
			}
			return ICheckPlayerGender.CreateICheckPlayerGender(builder, _o.Type, _o.Gender);
		}

		// Token: 0x0400D37B RID: 54139
		private Table __p;
	}
}
