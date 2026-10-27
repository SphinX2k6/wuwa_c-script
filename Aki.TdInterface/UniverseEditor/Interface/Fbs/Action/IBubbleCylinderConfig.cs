using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200622A RID: 25130
	public struct IBubbleCylinderConfig : IFlatbufferObject
	{
		// Token: 0x1700BB3F RID: 47935
		// (get) Token: 0x0602B50E RID: 177422 RVA: 0x005F6FC6 File Offset: 0x005F51C6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B50F RID: 177423 RVA: 0x005F6FD3 File Offset: 0x005F51D3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B510 RID: 177424 RVA: 0x005F6FDC File Offset: 0x005F51DC
		public static IBubbleCylinderConfig GetRootAsIBubbleCylinderConfig(ByteBuffer _bb)
		{
			return IBubbleCylinderConfig.GetRootAsIBubbleCylinderConfig(_bb, default(IBubbleCylinderConfig));
		}

		// Token: 0x0602B511 RID: 177425 RVA: 0x005F6FF8 File Offset: 0x005F51F8
		public static IBubbleCylinderConfig GetRootAsIBubbleCylinderConfig(ByteBuffer _bb, IBubbleCylinderConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B512 RID: 177426 RVA: 0x005F7015 File Offset: 0x005F5215
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B513 RID: 177427 RVA: 0x005F7024 File Offset: 0x005F5224
		public IBubbleCylinderConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BB40 RID: 47936
		// (get) Token: 0x0602B514 RID: 177428 RVA: 0x005F7034 File Offset: 0x005F5234
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

		// Token: 0x1700BB41 RID: 47937
		// (get) Token: 0x0602B515 RID: 177429 RVA: 0x005F7074 File Offset: 0x005F5274
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

		// Token: 0x0602B516 RID: 177430 RVA: 0x005F70B4 File Offset: 0x005F52B4
		public static Offset<IBubbleCylinderConfig> CreateIBubbleCylinderConfig(FlatBufferBuilder builder, float Radius = 0f, float Height = 0f)
		{
			builder.StartTable(2);
			IBubbleCylinderConfig.AddHeight(builder, Height);
			IBubbleCylinderConfig.AddRadius(builder, Radius);
			return IBubbleCylinderConfig.EndIBubbleCylinderConfig(builder);
		}

		// Token: 0x0602B517 RID: 177431 RVA: 0x005F70D1 File Offset: 0x005F52D1
		public static void StartIBubbleCylinderConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B518 RID: 177432 RVA: 0x005F70DA File Offset: 0x005F52DA
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
			builder.AddFloat(0, radius, 0.0);
		}

		// Token: 0x0602B519 RID: 177433 RVA: 0x005F70ED File Offset: 0x005F52ED
		public static void AddHeight(FlatBufferBuilder builder, float height)
		{
			builder.AddFloat(1, height, 0.0);
		}

		// Token: 0x0602B51A RID: 177434 RVA: 0x005F7100 File Offset: 0x005F5300
		public static Offset<IBubbleCylinderConfig> EndIBubbleCylinderConfig(FlatBufferBuilder builder)
		{
			return new Offset<IBubbleCylinderConfig>(builder.EndTable());
		}

		// Token: 0x0602B51B RID: 177435 RVA: 0x005F7110 File Offset: 0x005F5310
		public IBubbleCylinderConfigT UnPack()
		{
			IBubbleCylinderConfigT bubbleCylinderConfigT = new IBubbleCylinderConfigT();
			this.UnPackTo(bubbleCylinderConfigT);
			return bubbleCylinderConfigT;
		}

		// Token: 0x0602B51C RID: 177436 RVA: 0x005F712B File Offset: 0x005F532B
		public void UnPackTo(IBubbleCylinderConfigT _o)
		{
			_o.Radius = this.Radius;
			_o.Height = this.Height;
		}

		// Token: 0x0602B51D RID: 177437 RVA: 0x005F7148 File Offset: 0x005F5348
		public static Offset<IBubbleCylinderConfig> Pack(FlatBufferBuilder builder, IBubbleCylinderConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBubbleCylinderConfig>);
			}
			return IBubbleCylinderConfig.CreateIBubbleCylinderConfig(builder, _o.Radius, _o.Height);
		}

		// Token: 0x0401076D RID: 67437
		private Table __p;
	}
}
