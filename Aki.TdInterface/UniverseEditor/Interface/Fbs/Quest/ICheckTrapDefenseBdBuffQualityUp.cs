using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D76 RID: 15734
	public struct ICheckTrapDefenseBdBuffQualityUp : IFlatbufferObject
	{
		// Token: 0x17006BFE RID: 27646
		// (get) Token: 0x06015C87 RID: 89223 RVA: 0x003240A5 File Offset: 0x003222A5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015C88 RID: 89224 RVA: 0x003240B2 File Offset: 0x003222B2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015C89 RID: 89225 RVA: 0x003240BC File Offset: 0x003222BC
		public static ICheckTrapDefenseBdBuffQualityUp GetRootAsICheckTrapDefenseBdBuffQualityUp(ByteBuffer _bb)
		{
			return ICheckTrapDefenseBdBuffQualityUp.GetRootAsICheckTrapDefenseBdBuffQualityUp(_bb, default(ICheckTrapDefenseBdBuffQualityUp));
		}

		// Token: 0x06015C8A RID: 89226 RVA: 0x003240D8 File Offset: 0x003222D8
		public static ICheckTrapDefenseBdBuffQualityUp GetRootAsICheckTrapDefenseBdBuffQualityUp(ByteBuffer _bb, ICheckTrapDefenseBdBuffQualityUp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015C8B RID: 89227 RVA: 0x003240F5 File Offset: 0x003222F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015C8C RID: 89228 RVA: 0x00324104 File Offset: 0x00322304
		public ICheckTrapDefenseBdBuffQualityUp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006BFF RID: 27647
		// (get) Token: 0x06015C8D RID: 89229 RVA: 0x00324114 File Offset: 0x00322314
		public ECheckTrapDefenseEvent Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckTrapDefenseEvent.MonsterKilled;
				}
				return (ECheckTrapDefenseEvent)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015C8E RID: 89230 RVA: 0x00324150 File Offset: 0x00322350
		public static Offset<ICheckTrapDefenseBdBuffQualityUp> CreateICheckTrapDefenseBdBuffQualityUp(FlatBufferBuilder builder, ECheckTrapDefenseEvent Type = ECheckTrapDefenseEvent.MonsterKilled)
		{
			builder.StartTable(1);
			ICheckTrapDefenseBdBuffQualityUp.AddType(builder, Type);
			return ICheckTrapDefenseBdBuffQualityUp.EndICheckTrapDefenseBdBuffQualityUp(builder);
		}

		// Token: 0x06015C8F RID: 89231 RVA: 0x00324166 File Offset: 0x00322366
		public static void StartICheckTrapDefenseBdBuffQualityUp(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06015C90 RID: 89232 RVA: 0x0032416F File Offset: 0x0032236F
		public static void AddType(FlatBufferBuilder builder, ECheckTrapDefenseEvent type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015C91 RID: 89233 RVA: 0x0032417A File Offset: 0x0032237A
		public static Offset<ICheckTrapDefenseBdBuffQualityUp> EndICheckTrapDefenseBdBuffQualityUp(FlatBufferBuilder builder)
		{
			return new Offset<ICheckTrapDefenseBdBuffQualityUp>(builder.EndTable());
		}

		// Token: 0x06015C92 RID: 89234 RVA: 0x00324188 File Offset: 0x00322388
		public ICheckTrapDefenseBdBuffQualityUpT UnPack()
		{
			ICheckTrapDefenseBdBuffQualityUpT checkTrapDefenseBdBuffQualityUpT = new ICheckTrapDefenseBdBuffQualityUpT();
			this.UnPackTo(checkTrapDefenseBdBuffQualityUpT);
			return checkTrapDefenseBdBuffQualityUpT;
		}

		// Token: 0x06015C93 RID: 89235 RVA: 0x003241A3 File Offset: 0x003223A3
		public void UnPackTo(ICheckTrapDefenseBdBuffQualityUpT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06015C94 RID: 89236 RVA: 0x003241B4 File Offset: 0x003223B4
		public static Offset<ICheckTrapDefenseBdBuffQualityUp> Pack(FlatBufferBuilder builder, ICheckTrapDefenseBdBuffQualityUpT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckTrapDefenseBdBuffQualityUp>);
			}
			return ICheckTrapDefenseBdBuffQualityUp.CreateICheckTrapDefenseBdBuffQualityUp(builder, _o.Type);
		}

		// Token: 0x0400B65F RID: 46687
		private Table __p;
	}
}
