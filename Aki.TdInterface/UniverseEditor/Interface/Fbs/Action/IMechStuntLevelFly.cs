using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071BF RID: 29119
	public struct IMechStuntLevelFly : IFlatbufferObject
	{
		// Token: 0x1700D53F RID: 54591
		// (get) Token: 0x06032A66 RID: 207462 RVA: 0x006D7DE1 File Offset: 0x006D5FE1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032A67 RID: 207463 RVA: 0x006D7DEE File Offset: 0x006D5FEE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032A68 RID: 207464 RVA: 0x006D7DF8 File Offset: 0x006D5FF8
		public static IMechStuntLevelFly GetRootAsIMechStuntLevelFly(ByteBuffer _bb)
		{
			return IMechStuntLevelFly.GetRootAsIMechStuntLevelFly(_bb, default(IMechStuntLevelFly));
		}

		// Token: 0x06032A69 RID: 207465 RVA: 0x006D7E14 File Offset: 0x006D6014
		public static IMechStuntLevelFly GetRootAsIMechStuntLevelFly(ByteBuffer _bb, IMechStuntLevelFly obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032A6A RID: 207466 RVA: 0x006D7E31 File Offset: 0x006D6031
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032A6B RID: 207467 RVA: 0x006D7E40 File Offset: 0x006D6040
		public IMechStuntLevelFly __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D540 RID: 54592
		// (get) Token: 0x06032A6C RID: 207468 RVA: 0x006D7E50 File Offset: 0x006D6050
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

		// Token: 0x06032A6D RID: 207469 RVA: 0x006D7E8C File Offset: 0x006D608C
		public static Offset<IMechStuntLevelFly> CreateIMechStuntLevelFly(FlatBufferBuilder builder, EMechStuntType Type = EMechStuntType.Dive)
		{
			builder.StartTable(1);
			IMechStuntLevelFly.AddType(builder, Type);
			return IMechStuntLevelFly.EndIMechStuntLevelFly(builder);
		}

		// Token: 0x06032A6E RID: 207470 RVA: 0x006D7EA2 File Offset: 0x006D60A2
		public static void StartIMechStuntLevelFly(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032A6F RID: 207471 RVA: 0x006D7EAB File Offset: 0x006D60AB
		public static void AddType(FlatBufferBuilder builder, EMechStuntType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032A70 RID: 207472 RVA: 0x006D7EB6 File Offset: 0x006D60B6
		public static Offset<IMechStuntLevelFly> EndIMechStuntLevelFly(FlatBufferBuilder builder)
		{
			return new Offset<IMechStuntLevelFly>(builder.EndTable());
		}

		// Token: 0x06032A71 RID: 207473 RVA: 0x006D7EC4 File Offset: 0x006D60C4
		public IMechStuntLevelFlyT UnPack()
		{
			IMechStuntLevelFlyT mechStuntLevelFlyT = new IMechStuntLevelFlyT();
			this.UnPackTo(mechStuntLevelFlyT);
			return mechStuntLevelFlyT;
		}

		// Token: 0x06032A72 RID: 207474 RVA: 0x006D7EDF File Offset: 0x006D60DF
		public void UnPackTo(IMechStuntLevelFlyT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06032A73 RID: 207475 RVA: 0x006D7EF0 File Offset: 0x006D60F0
		public static Offset<IMechStuntLevelFly> Pack(FlatBufferBuilder builder, IMechStuntLevelFlyT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechStuntLevelFly>);
			}
			return IMechStuntLevelFly.CreateIMechStuntLevelFly(builder, _o.Type);
		}

		// Token: 0x040121D4 RID: 74196
		private Table __p;
	}
}
