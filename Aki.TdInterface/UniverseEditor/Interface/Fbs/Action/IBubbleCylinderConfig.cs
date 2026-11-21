using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200689B RID: 26779
	public struct IBubbleCylinderConfig : IFlatbufferObject
	{
		// Token: 0x1700C4C7 RID: 50375
		// (get) Token: 0x0602DC6F RID: 187503 RVA: 0x00641DCE File Offset: 0x0063FFCE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DC70 RID: 187504 RVA: 0x00641DDB File Offset: 0x0063FFDB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DC71 RID: 187505 RVA: 0x00641DE4 File Offset: 0x0063FFE4
		public static IBubbleCylinderConfig GetRootAsIBubbleCylinderConfig(ByteBuffer _bb)
		{
			return IBubbleCylinderConfig.GetRootAsIBubbleCylinderConfig(_bb, default(IBubbleCylinderConfig));
		}

		// Token: 0x0602DC72 RID: 187506 RVA: 0x00641E00 File Offset: 0x00640000
		public static IBubbleCylinderConfig GetRootAsIBubbleCylinderConfig(ByteBuffer _bb, IBubbleCylinderConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DC73 RID: 187507 RVA: 0x00641E1D File Offset: 0x0064001D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DC74 RID: 187508 RVA: 0x00641E2C File Offset: 0x0064002C
		public IBubbleCylinderConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C4C8 RID: 50376
		// (get) Token: 0x0602DC75 RID: 187509 RVA: 0x00641E3C File Offset: 0x0064003C
		public float Radius
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C4C9 RID: 50377
		// (get) Token: 0x0602DC76 RID: 187510 RVA: 0x00641E7C File Offset: 0x0064007C
		public float Height
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602DC77 RID: 187511 RVA: 0x00641EBC File Offset: 0x006400BC
		public static Offset<IBubbleCylinderConfig> CreateIBubbleCylinderConfig(FlatBufferBuilder builder, float Radius = 0f, float Height = 0f)
		{
			builder.StartTable(2);
			IBubbleCylinderConfig.AddHeight(builder, Height);
			IBubbleCylinderConfig.AddRadius(builder, Radius);
			return IBubbleCylinderConfig.EndIBubbleCylinderConfig(builder);
		}

		// Token: 0x0602DC78 RID: 187512 RVA: 0x00641ED9 File Offset: 0x006400D9
		public static void StartIBubbleCylinderConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602DC79 RID: 187513 RVA: 0x00641EE2 File Offset: 0x006400E2
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
			builder.AddFloat(0, radius, 0.0);
		}

		// Token: 0x0602DC7A RID: 187514 RVA: 0x00641EF5 File Offset: 0x006400F5
		public static void AddHeight(FlatBufferBuilder builder, float height)
		{
			builder.AddFloat(1, height, 0.0);
		}

		// Token: 0x0602DC7B RID: 187515 RVA: 0x00641F08 File Offset: 0x00640108
		public static Offset<IBubbleCylinderConfig> EndIBubbleCylinderConfig(FlatBufferBuilder builder)
		{
			return new Offset<IBubbleCylinderConfig>(builder.EndTable());
		}

		// Token: 0x0602DC7C RID: 187516 RVA: 0x00641F18 File Offset: 0x00640118
		public IBubbleCylinderConfigT UnPack()
		{
			IBubbleCylinderConfigT bubbleCylinderConfigT = new IBubbleCylinderConfigT();
			this.UnPackTo(bubbleCylinderConfigT);
			return bubbleCylinderConfigT;
		}

		// Token: 0x0602DC7D RID: 187517 RVA: 0x00641F33 File Offset: 0x00640133
		public void UnPackTo(IBubbleCylinderConfigT _o)
		{
			_o.Radius = this.Radius;
			_o.Height = this.Height;
		}

		// Token: 0x0602DC7E RID: 187518 RVA: 0x00641F50 File Offset: 0x00640150
		public static Offset<IBubbleCylinderConfig> Pack(FlatBufferBuilder builder, IBubbleCylinderConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBubbleCylinderConfig>);
			}
			return IBubbleCylinderConfig.CreateIBubbleCylinderConfig(builder, _o.Radius, _o.Height);
		}

		// Token: 0x04011582 RID: 71042
		private Table __p;
	}
}
