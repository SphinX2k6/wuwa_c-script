using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E15 RID: 24085
	public struct IReboundType : IFlatbufferObject
	{
		// Token: 0x1700B18C RID: 45452
		// (get) Token: 0x06028385 RID: 164741 RVA: 0x0058018F File Offset: 0x0057E38F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028386 RID: 164742 RVA: 0x0058019C File Offset: 0x0057E39C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028387 RID: 164743 RVA: 0x005801A4 File Offset: 0x0057E3A4
		public static IReboundType GetRootAsIReboundType(ByteBuffer _bb)
		{
			return IReboundType.GetRootAsIReboundType(_bb, default(IReboundType));
		}

		// Token: 0x06028388 RID: 164744 RVA: 0x005801C0 File Offset: 0x0057E3C0
		public static IReboundType GetRootAsIReboundType(ByteBuffer _bb, IReboundType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028389 RID: 164745 RVA: 0x005801DD File Offset: 0x0057E3DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602838A RID: 164746 RVA: 0x005801EC File Offset: 0x0057E3EC
		public IReboundType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B18D RID: 45453
		// (get) Token: 0x0602838B RID: 164747 RVA: 0x005801FC File Offset: 0x0057E3FC
		public EReboundOptionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EReboundOptionType.ForwardFront;
				}
				return (EReboundOptionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602838C RID: 164748 RVA: 0x00580238 File Offset: 0x0057E438
		public static Offset<IReboundType> CreateIReboundType(FlatBufferBuilder builder, EReboundOptionType Type = EReboundOptionType.ForwardFront)
		{
			builder.StartTable(1);
			IReboundType.AddType(builder, Type);
			return IReboundType.EndIReboundType(builder);
		}

		// Token: 0x0602838D RID: 164749 RVA: 0x0058024E File Offset: 0x0057E44E
		public static void StartIReboundType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602838E RID: 164750 RVA: 0x00580257 File Offset: 0x0057E457
		public static void AddType(FlatBufferBuilder builder, EReboundOptionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602838F RID: 164751 RVA: 0x00580262 File Offset: 0x0057E462
		public static Offset<IReboundType> EndIReboundType(FlatBufferBuilder builder)
		{
			return new Offset<IReboundType>(builder.EndTable());
		}

		// Token: 0x06028390 RID: 164752 RVA: 0x00580270 File Offset: 0x0057E470
		public IReboundTypeT UnPack()
		{
			IReboundTypeT reboundTypeT = new IReboundTypeT();
			this.UnPackTo(reboundTypeT);
			return reboundTypeT;
		}

		// Token: 0x06028391 RID: 164753 RVA: 0x0058028B File Offset: 0x0057E48B
		public void UnPackTo(IReboundTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06028392 RID: 164754 RVA: 0x0058029C File Offset: 0x0057E49C
		public static Offset<IReboundType> Pack(FlatBufferBuilder builder, IReboundTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IReboundType>);
			}
			return IReboundType.CreateIReboundType(builder, _o.Type);
		}

		// Token: 0x0400F9F9 RID: 63993
		private Table __p;
	}
}
