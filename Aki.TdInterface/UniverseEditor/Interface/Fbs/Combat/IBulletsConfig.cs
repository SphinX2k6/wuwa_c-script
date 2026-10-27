using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Combat
{
	// Token: 0x02005EED RID: 24301
	public struct IBulletsConfig : IFlatbufferObject
	{
		// Token: 0x1700B5B1 RID: 46513
		// (get) Token: 0x06029BBA RID: 170938 RVA: 0x005BA26D File Offset: 0x005B846D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029BBB RID: 170939 RVA: 0x005BA27A File Offset: 0x005B847A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029BBC RID: 170940 RVA: 0x005BA284 File Offset: 0x005B8484
		public static IBulletsConfig GetRootAsIBulletsConfig(ByteBuffer _bb)
		{
			return IBulletsConfig.GetRootAsIBulletsConfig(_bb, default(IBulletsConfig));
		}

		// Token: 0x06029BBD RID: 170941 RVA: 0x005BA2A0 File Offset: 0x005B84A0
		public static IBulletsConfig GetRootAsIBulletsConfig(ByteBuffer _bb, IBulletsConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029BBE RID: 170942 RVA: 0x005BA2BD File Offset: 0x005B84BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029BBF RID: 170943 RVA: 0x005BA2CC File Offset: 0x005B84CC
		public IBulletsConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06029BC0 RID: 170944 RVA: 0x005BA2DC File Offset: 0x005B84DC
		public IBulletConfig? Bullets(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IBulletConfig?(default(IBulletConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B5B2 RID: 46514
		// (get) Token: 0x06029BC1 RID: 170945 RVA: 0x005BA33C File Offset: 0x005B853C
		public int BulletsLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06029BC2 RID: 170946 RVA: 0x005BA367 File Offset: 0x005B8567
		public static Offset<IBulletsConfig> CreateIBulletsConfig(FlatBufferBuilder builder, VectorOffset BulletsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IBulletsConfig.AddBullets(builder, BulletsOffset);
			return IBulletsConfig.EndIBulletsConfig(builder);
		}

		// Token: 0x06029BC3 RID: 170947 RVA: 0x005BA37D File Offset: 0x005B857D
		public static void StartIBulletsConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06029BC4 RID: 170948 RVA: 0x005BA386 File Offset: 0x005B8586
		public static void AddBullets(FlatBufferBuilder builder, VectorOffset bulletsOffset)
		{
			builder.AddOffset(0, bulletsOffset.Value, 0);
		}

		// Token: 0x06029BC5 RID: 170949 RVA: 0x005BA398 File Offset: 0x005B8598
		public static VectorOffset CreateBulletsVector(FlatBufferBuilder builder, Offset<IBulletConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06029BC6 RID: 170950 RVA: 0x005BA3D8 File Offset: 0x005B85D8
		public static VectorOffset CreateBulletsVectorBlock(FlatBufferBuilder builder, Offset<IBulletConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IBulletConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029BC7 RID: 170951 RVA: 0x005BA3F2 File Offset: 0x005B85F2
		public static VectorOffset CreateBulletsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IBulletConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IBulletConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029BC8 RID: 170952 RVA: 0x005BA410 File Offset: 0x005B8610
		public static VectorOffset CreateBulletsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IBulletConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029BC9 RID: 170953 RVA: 0x005BA429 File Offset: 0x005B8629
		public static void StartBulletsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029BCA RID: 170954 RVA: 0x005BA434 File Offset: 0x005B8634
		public static Offset<IBulletsConfig> EndIBulletsConfig(FlatBufferBuilder builder)
		{
			return new Offset<IBulletsConfig>(builder.EndTable());
		}

		// Token: 0x06029BCB RID: 170955 RVA: 0x005BA444 File Offset: 0x005B8644
		public IBulletsConfigT UnPack()
		{
			IBulletsConfigT bulletsConfigT = new IBulletsConfigT();
			this.UnPackTo(bulletsConfigT);
			return bulletsConfigT;
		}

		// Token: 0x06029BCC RID: 170956 RVA: 0x005BA460 File Offset: 0x005B8660
		public void UnPackTo(IBulletsConfigT _o)
		{
			_o.Bullets = new List<IBulletConfigT>();
			for (int i = 0; i < this.BulletsLength; i++)
			{
				_o.Bullets.Add((this.Bullets(i) != null) ? this.Bullets(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06029BCD RID: 170957 RVA: 0x005BA4C0 File Offset: 0x005B86C0
		public static Offset<IBulletsConfig> Pack(FlatBufferBuilder builder, IBulletsConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBulletsConfig>);
			}
			VectorOffset bulletsOffset = default(VectorOffset);
			if (_o.Bullets != null)
			{
				Offset<IBulletConfig>[] array = new Offset<IBulletConfig>[_o.Bullets.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IBulletConfig.Pack(builder, _o.Bullets[i]);
				}
				bulletsOffset = IBulletsConfig.CreateBulletsVector(builder, array);
			}
			return IBulletsConfig.CreateIBulletsConfig(builder, bulletsOffset);
		}

		// Token: 0x0400F9F1 RID: 63985
		private Table __p;
	}
}
