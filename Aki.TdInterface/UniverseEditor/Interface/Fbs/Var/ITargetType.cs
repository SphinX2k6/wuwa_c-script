using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EE9 RID: 16105
	public struct ITargetType : IFlatbufferObject
	{
		// Token: 0x17006D0B RID: 27915
		// (get) Token: 0x06015D5E RID: 89438 RVA: 0x003241B5 File Offset: 0x003223B5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015D5F RID: 89439 RVA: 0x003241C2 File Offset: 0x003223C2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015D60 RID: 89440 RVA: 0x003241CC File Offset: 0x003223CC
		public static ITargetType GetRootAsITargetType(ByteBuffer _bb)
		{
			return ITargetType.GetRootAsITargetType(_bb, default(ITargetType));
		}

		// Token: 0x06015D61 RID: 89441 RVA: 0x003241E8 File Offset: 0x003223E8
		public static ITargetType GetRootAsITargetType(ByteBuffer _bb, ITargetType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015D62 RID: 89442 RVA: 0x00324205 File Offset: 0x00322405
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015D63 RID: 89443 RVA: 0x00324214 File Offset: 0x00322414
		public ITargetType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D0C RID: 27916
		// (get) Token: 0x06015D64 RID: 89444 RVA: 0x00324224 File Offset: 0x00322424
		public ETargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetType.Player;
				}
				return (ETargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015D65 RID: 89445 RVA: 0x00324260 File Offset: 0x00322460
		public static Offset<ITargetType> CreateITargetType(FlatBufferBuilder builder, ETargetType Type = ETargetType.Player)
		{
			builder.StartTable(1);
			ITargetType.AddType(builder, Type);
			return ITargetType.EndITargetType(builder);
		}

		// Token: 0x06015D66 RID: 89446 RVA: 0x00324276 File Offset: 0x00322476
		public static void StartITargetType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06015D67 RID: 89447 RVA: 0x0032427F File Offset: 0x0032247F
		public static void AddType(FlatBufferBuilder builder, ETargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015D68 RID: 89448 RVA: 0x0032428A File Offset: 0x0032248A
		public static Offset<ITargetType> EndITargetType(FlatBufferBuilder builder)
		{
			return new Offset<ITargetType>(builder.EndTable());
		}

		// Token: 0x06015D69 RID: 89449 RVA: 0x00324298 File Offset: 0x00322498
		public ITargetTypeT UnPack()
		{
			ITargetTypeT targetTypeT = new ITargetTypeT();
			this.UnPackTo(targetTypeT);
			return targetTypeT;
		}

		// Token: 0x06015D6A RID: 89450 RVA: 0x003242B3 File Offset: 0x003224B3
		public void UnPackTo(ITargetTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06015D6B RID: 89451 RVA: 0x003242C4 File Offset: 0x003224C4
		public static Offset<ITargetType> Pack(FlatBufferBuilder builder, ITargetTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITargetType>);
			}
			return ITargetType.CreateITargetType(builder, _o.Type);
		}

		// Token: 0x0400B914 RID: 47380
		private Table __p;
	}
}
