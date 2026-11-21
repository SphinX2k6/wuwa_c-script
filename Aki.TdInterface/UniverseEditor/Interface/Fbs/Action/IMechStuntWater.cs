using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071C2 RID: 29122
	public struct IMechStuntWater : IFlatbufferObject
	{
		// Token: 0x1700D542 RID: 54594
		// (get) Token: 0x06032A78 RID: 207480 RVA: 0x006D7F59 File Offset: 0x006D6159
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032A79 RID: 207481 RVA: 0x006D7F66 File Offset: 0x006D6166
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032A7A RID: 207482 RVA: 0x006D7F70 File Offset: 0x006D6170
		public static IMechStuntWater GetRootAsIMechStuntWater(ByteBuffer _bb)
		{
			return IMechStuntWater.GetRootAsIMechStuntWater(_bb, default(IMechStuntWater));
		}

		// Token: 0x06032A7B RID: 207483 RVA: 0x006D7F8C File Offset: 0x006D618C
		public static IMechStuntWater GetRootAsIMechStuntWater(ByteBuffer _bb, IMechStuntWater obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032A7C RID: 207484 RVA: 0x006D7FA9 File Offset: 0x006D61A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032A7D RID: 207485 RVA: 0x006D7FB8 File Offset: 0x006D61B8
		public IMechStuntWater __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D543 RID: 54595
		// (get) Token: 0x06032A7E RID: 207486 RVA: 0x006D7FC8 File Offset: 0x006D61C8
		public EMechStuntType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMechStuntType.Dive;
				}
				return (EMechStuntType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032A7F RID: 207487 RVA: 0x006D8004 File Offset: 0x006D6204
		public static Offset<IMechStuntWater> CreateIMechStuntWater(FlatBufferBuilder builder, EMechStuntType Type = EMechStuntType.Dive)
		{
			builder.StartTable(1);
			IMechStuntWater.AddType(builder, Type);
			return IMechStuntWater.EndIMechStuntWater(builder);
		}

		// Token: 0x06032A80 RID: 207488 RVA: 0x006D801A File Offset: 0x006D621A
		public static void StartIMechStuntWater(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032A81 RID: 207489 RVA: 0x006D8023 File Offset: 0x006D6223
		public static void AddType(FlatBufferBuilder builder, EMechStuntType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032A82 RID: 207490 RVA: 0x006D802E File Offset: 0x006D622E
		public static Offset<IMechStuntWater> EndIMechStuntWater(FlatBufferBuilder builder)
		{
			return new Offset<IMechStuntWater>(builder.EndTable());
		}

		// Token: 0x06032A83 RID: 207491 RVA: 0x006D803C File Offset: 0x006D623C
		public IMechStuntWaterT UnPack()
		{
			IMechStuntWaterT mechStuntWaterT = new IMechStuntWaterT();
			this.UnPackTo(mechStuntWaterT);
			return mechStuntWaterT;
		}

		// Token: 0x06032A84 RID: 207492 RVA: 0x006D8057 File Offset: 0x006D6257
		public void UnPackTo(IMechStuntWaterT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06032A85 RID: 207493 RVA: 0x006D8068 File Offset: 0x006D6268
		public static Offset<IMechStuntWater> Pack(FlatBufferBuilder builder, IMechStuntWaterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechStuntWater>);
			}
			return IMechStuntWater.CreateIMechStuntWater(builder, _o.Type);
		}

		// Token: 0x040121D6 RID: 74198
		private Table __p;
	}
}
