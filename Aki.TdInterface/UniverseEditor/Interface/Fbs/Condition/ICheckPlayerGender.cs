using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FBF RID: 20415
	public struct ICheckPlayerGender : IFlatbufferObject
	{
		// Token: 0x17009207 RID: 37383
		// (get) Token: 0x0601FD3D RID: 130365 RVA: 0x0046BE5C File Offset: 0x0046A05C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FD3E RID: 130366 RVA: 0x0046BE69 File Offset: 0x0046A069
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FD3F RID: 130367 RVA: 0x0046BE70 File Offset: 0x0046A070
		public static ICheckPlayerGender GetRootAsICheckPlayerGender(ByteBuffer _bb)
		{
			return ICheckPlayerGender.GetRootAsICheckPlayerGender(_bb, default(ICheckPlayerGender));
		}

		// Token: 0x0601FD40 RID: 130368 RVA: 0x0046BE8C File Offset: 0x0046A08C
		public static ICheckPlayerGender GetRootAsICheckPlayerGender(ByteBuffer _bb, ICheckPlayerGender obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FD41 RID: 130369 RVA: 0x0046BEA9 File Offset: 0x0046A0A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FD42 RID: 130370 RVA: 0x0046BEB8 File Offset: 0x0046A0B8
		public ICheckPlayerGender __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009208 RID: 37384
		// (get) Token: 0x0601FD43 RID: 130371 RVA: 0x0046BEC8 File Offset: 0x0046A0C8
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

		// Token: 0x17009209 RID: 37385
		// (get) Token: 0x0601FD44 RID: 130372 RVA: 0x0046BF04 File Offset: 0x0046A104
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

		// Token: 0x0601FD45 RID: 130373 RVA: 0x0046BF40 File Offset: 0x0046A140
		public static Offset<ICheckPlayerGender> CreateICheckPlayerGender(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, EGender Gender = EGender.M)
		{
			builder.StartTable(2);
			ICheckPlayerGender.AddGender(builder, Gender);
			ICheckPlayerGender.AddType(builder, Type);
			return ICheckPlayerGender.EndICheckPlayerGender(builder);
		}

		// Token: 0x0601FD46 RID: 130374 RVA: 0x0046BF5D File Offset: 0x0046A15D
		public static void StartICheckPlayerGender(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601FD47 RID: 130375 RVA: 0x0046BF66 File Offset: 0x0046A166
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FD48 RID: 130376 RVA: 0x0046BF71 File Offset: 0x0046A171
		public static void AddGender(FlatBufferBuilder builder, EGender gender)
		{
			builder.AddByte(1, (byte)gender, 0);
		}

		// Token: 0x0601FD49 RID: 130377 RVA: 0x0046BF7C File Offset: 0x0046A17C
		public static Offset<ICheckPlayerGender> EndICheckPlayerGender(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPlayerGender>(builder.EndTable());
		}

		// Token: 0x0601FD4A RID: 130378 RVA: 0x0046BF8C File Offset: 0x0046A18C
		public ICheckPlayerGenderT UnPack()
		{
			ICheckPlayerGenderT checkPlayerGenderT = new ICheckPlayerGenderT();
			this.UnPackTo(checkPlayerGenderT);
			return checkPlayerGenderT;
		}

		// Token: 0x0601FD4B RID: 130379 RVA: 0x0046BFA7 File Offset: 0x0046A1A7
		public void UnPackTo(ICheckPlayerGenderT _o)
		{
			_o.Type = this.Type;
			_o.Gender = this.Gender;
		}

		// Token: 0x0601FD4C RID: 130380 RVA: 0x0046BFC4 File Offset: 0x0046A1C4
		public static Offset<ICheckPlayerGender> Pack(FlatBufferBuilder builder, ICheckPlayerGenderT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckPlayerGender>);
			}
			return ICheckPlayerGender.CreateICheckPlayerGender(builder, _o.Type, _o.Gender);
		}

		// Token: 0x0400DE66 RID: 56934
		private Table __p;
	}
}
