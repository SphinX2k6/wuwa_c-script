using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A9D RID: 27293
	public struct IMechStuntWater : IFlatbufferObject
	{
		// Token: 0x1700CA92 RID: 51858
		// (get) Token: 0x0602FD3C RID: 195900 RVA: 0x00681C99 File Offset: 0x0067FE99
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FD3D RID: 195901 RVA: 0x00681CA6 File Offset: 0x0067FEA6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FD3E RID: 195902 RVA: 0x00681CB0 File Offset: 0x0067FEB0
		public static IMechStuntWater GetRootAsIMechStuntWater(ByteBuffer _bb)
		{
			return IMechStuntWater.GetRootAsIMechStuntWater(_bb, default(IMechStuntWater));
		}

		// Token: 0x0602FD3F RID: 195903 RVA: 0x00681CCC File Offset: 0x0067FECC
		public static IMechStuntWater GetRootAsIMechStuntWater(ByteBuffer _bb, IMechStuntWater obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FD40 RID: 195904 RVA: 0x00681CE9 File Offset: 0x0067FEE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FD41 RID: 195905 RVA: 0x00681CF8 File Offset: 0x0067FEF8
		public IMechStuntWater __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA93 RID: 51859
		// (get) Token: 0x0602FD42 RID: 195906 RVA: 0x00681D08 File Offset: 0x0067FF08
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

		// Token: 0x0602FD43 RID: 195907 RVA: 0x00681D44 File Offset: 0x0067FF44
		public static Offset<IMechStuntWater> CreateIMechStuntWater(FlatBufferBuilder builder, EMechStuntType Type = EMechStuntType.Dive)
		{
			builder.StartTable(1);
			IMechStuntWater.AddType(builder, Type);
			return IMechStuntWater.EndIMechStuntWater(builder);
		}

		// Token: 0x0602FD44 RID: 195908 RVA: 0x00681D5A File Offset: 0x0067FF5A
		public static void StartIMechStuntWater(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602FD45 RID: 195909 RVA: 0x00681D63 File Offset: 0x0067FF63
		public static void AddType(FlatBufferBuilder builder, EMechStuntType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FD46 RID: 195910 RVA: 0x00681D6E File Offset: 0x0067FF6E
		public static Offset<IMechStuntWater> EndIMechStuntWater(FlatBufferBuilder builder)
		{
			return new Offset<IMechStuntWater>(builder.EndTable());
		}

		// Token: 0x0602FD47 RID: 195911 RVA: 0x00681D7C File Offset: 0x0067FF7C
		public IMechStuntWaterT UnPack()
		{
			IMechStuntWaterT mechStuntWaterT = new IMechStuntWaterT();
			this.UnPackTo(mechStuntWaterT);
			return mechStuntWaterT;
		}

		// Token: 0x0602FD48 RID: 195912 RVA: 0x00681D97 File Offset: 0x0067FF97
		public void UnPackTo(IMechStuntWaterT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602FD49 RID: 195913 RVA: 0x00681DA8 File Offset: 0x0067FFA8
		public static Offset<IMechStuntWater> Pack(FlatBufferBuilder builder, IMechStuntWaterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechStuntWater>);
			}
			return IMechStuntWater.CreateIMechStuntWater(builder, _o.Type);
		}

		// Token: 0x040112DB RID: 70363
		private Table __p;
	}
}
