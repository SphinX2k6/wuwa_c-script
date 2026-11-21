using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Combat
{
	// Token: 0x02006530 RID: 25904
	public struct IBulletsConfig : IFlatbufferObject
	{
		// Token: 0x1700BF1C RID: 48924
		// (get) Token: 0x0602C26E RID: 180846 RVA: 0x00603751 File Offset: 0x00601951
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C26F RID: 180847 RVA: 0x0060375E File Offset: 0x0060195E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C270 RID: 180848 RVA: 0x00603768 File Offset: 0x00601968
		public static IBulletsConfig GetRootAsIBulletsConfig(ByteBuffer _bb)
		{
			return IBulletsConfig.GetRootAsIBulletsConfig(_bb, default(IBulletsConfig));
		}

		// Token: 0x0602C271 RID: 180849 RVA: 0x00603784 File Offset: 0x00601984
		public static IBulletsConfig GetRootAsIBulletsConfig(ByteBuffer _bb, IBulletsConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C272 RID: 180850 RVA: 0x006037A1 File Offset: 0x006019A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C273 RID: 180851 RVA: 0x006037B0 File Offset: 0x006019B0
		public IBulletsConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602C274 RID: 180852 RVA: 0x006037C0 File Offset: 0x006019C0
		public IBulletConfig? Bullets(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IBulletConfig?(default(IBulletConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700BF1D RID: 48925
		// (get) Token: 0x0602C275 RID: 180853 RVA: 0x00603820 File Offset: 0x00601A20
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

		// Token: 0x0602C276 RID: 180854 RVA: 0x0060384B File Offset: 0x00601A4B
		public static Offset<IBulletsConfig> CreateIBulletsConfig(FlatBufferBuilder builder, VectorOffset BulletsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IBulletsConfig.AddBullets(builder, BulletsOffset);
			return IBulletsConfig.EndIBulletsConfig(builder);
		}

		// Token: 0x0602C277 RID: 180855 RVA: 0x00603861 File Offset: 0x00601A61
		public static void StartIBulletsConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602C278 RID: 180856 RVA: 0x0060386A File Offset: 0x00601A6A
		public static void AddBullets(FlatBufferBuilder builder, VectorOffset bulletsOffset)
		{
			builder.AddOffset(0, bulletsOffset.Value, 0);
		}

		// Token: 0x0602C279 RID: 180857 RVA: 0x0060387C File Offset: 0x00601A7C
		public static VectorOffset CreateBulletsVector(FlatBufferBuilder builder, Offset<IBulletConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602C27A RID: 180858 RVA: 0x006038BC File Offset: 0x00601ABC
		public static VectorOffset CreateBulletsVectorBlock(FlatBufferBuilder builder, Offset<IBulletConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IBulletConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C27B RID: 180859 RVA: 0x006038D6 File Offset: 0x00601AD6
		public static VectorOffset CreateBulletsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IBulletConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IBulletConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C27C RID: 180860 RVA: 0x006038F4 File Offset: 0x00601AF4
		public static VectorOffset CreateBulletsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IBulletConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602C27D RID: 180861 RVA: 0x0060390D File Offset: 0x00601B0D
		public static void StartBulletsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602C27E RID: 180862 RVA: 0x00603918 File Offset: 0x00601B18
		public static Offset<IBulletsConfig> EndIBulletsConfig(FlatBufferBuilder builder)
		{
			return new Offset<IBulletsConfig>(builder.EndTable());
		}

		// Token: 0x0602C27F RID: 180863 RVA: 0x00603928 File Offset: 0x00601B28
		public IBulletsConfigT UnPack()
		{
			IBulletsConfigT bulletsConfigT = new IBulletsConfigT();
			this.UnPackTo(bulletsConfigT);
			return bulletsConfigT;
		}

		// Token: 0x0602C280 RID: 180864 RVA: 0x00603944 File Offset: 0x00601B44
		public void UnPackTo(IBulletsConfigT _o)
		{
			_o.Bullets = new List<IBulletConfigT>();
			for (int i = 0; i < this.BulletsLength; i++)
			{
				_o.Bullets.Add((this.Bullets(i) != null) ? this.Bullets(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602C281 RID: 180865 RVA: 0x006039A4 File Offset: 0x00601BA4
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

		// Token: 0x04010755 RID: 67413
		private Table __p;
	}
}
