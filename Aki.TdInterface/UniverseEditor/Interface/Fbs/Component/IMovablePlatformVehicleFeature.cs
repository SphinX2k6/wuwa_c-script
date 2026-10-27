using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055D2 RID: 21970
	public struct IMovablePlatformVehicleFeature : IFlatbufferObject
	{
		// Token: 0x1700A284 RID: 41604
		// (get) Token: 0x060246C9 RID: 149193 RVA: 0x00507467 File Offset: 0x00505667
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060246CA RID: 149194 RVA: 0x00507474 File Offset: 0x00505674
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060246CB RID: 149195 RVA: 0x0050747C File Offset: 0x0050567C
		public static IMovablePlatformVehicleFeature GetRootAsIMovablePlatformVehicleFeature(ByteBuffer _bb)
		{
			return IMovablePlatformVehicleFeature.GetRootAsIMovablePlatformVehicleFeature(_bb, default(IMovablePlatformVehicleFeature));
		}

		// Token: 0x060246CC RID: 149196 RVA: 0x00507498 File Offset: 0x00505698
		public static IMovablePlatformVehicleFeature GetRootAsIMovablePlatformVehicleFeature(ByteBuffer _bb, IMovablePlatformVehicleFeature obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060246CD RID: 149197 RVA: 0x005074B5 File Offset: 0x005056B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060246CE RID: 149198 RVA: 0x005074C4 File Offset: 0x005056C4
		public IMovablePlatformVehicleFeature __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A285 RID: 41605
		// (get) Token: 0x060246CF RID: 149199 RVA: 0x005074D4 File Offset: 0x005056D4
		public EVehicleFeatureFlag Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVehicleFeatureFlag.None;
				}
				return (EVehicleFeatureFlag)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060246D0 RID: 149200 RVA: 0x00507510 File Offset: 0x00505710
		public int PlayerAttachTags(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A286 RID: 41606
		// (get) Token: 0x060246D1 RID: 149201 RVA: 0x00507550 File Offset: 0x00505750
		public int PlayerAttachTagsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060246D2 RID: 149202 RVA: 0x0050757B File Offset: 0x0050577B
		public Span<int> GetPlayerAttachTagsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060246D3 RID: 149203 RVA: 0x0050758A File Offset: 0x0050578A
		public int[] GetPlayerAttachTagsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700A287 RID: 41607
		// (get) Token: 0x060246D4 RID: 149204 RVA: 0x00507598 File Offset: 0x00505798
		public int SafePointId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060246D5 RID: 149205 RVA: 0x005075D4 File Offset: 0x005057D4
		public static Offset<IMovablePlatformVehicleFeature> CreateIMovablePlatformVehicleFeature(FlatBufferBuilder builder, EVehicleFeatureFlag Type = EVehicleFeatureFlag.None, VectorOffset PlayerAttachTagsOffset = default(VectorOffset), int SafePointId = 0)
		{
			builder.StartTable(3);
			IMovablePlatformVehicleFeature.AddSafePointId(builder, SafePointId);
			IMovablePlatformVehicleFeature.AddPlayerAttachTags(builder, PlayerAttachTagsOffset);
			IMovablePlatformVehicleFeature.AddType(builder, Type);
			return IMovablePlatformVehicleFeature.EndIMovablePlatformVehicleFeature(builder);
		}

		// Token: 0x060246D6 RID: 149206 RVA: 0x005075F8 File Offset: 0x005057F8
		public static void StartIMovablePlatformVehicleFeature(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060246D7 RID: 149207 RVA: 0x00507601 File Offset: 0x00505801
		public static void AddType(FlatBufferBuilder builder, EVehicleFeatureFlag type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060246D8 RID: 149208 RVA: 0x0050760C File Offset: 0x0050580C
		public static void AddPlayerAttachTags(FlatBufferBuilder builder, VectorOffset playerAttachTagsOffset)
		{
			builder.AddOffset(1, playerAttachTagsOffset.Value, 0);
		}

		// Token: 0x060246D9 RID: 149209 RVA: 0x0050761C File Offset: 0x0050581C
		public static VectorOffset CreatePlayerAttachTagsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060246DA RID: 149210 RVA: 0x00507653 File Offset: 0x00505853
		public static VectorOffset CreatePlayerAttachTagsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060246DB RID: 149211 RVA: 0x0050766D File Offset: 0x0050586D
		public static VectorOffset CreatePlayerAttachTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060246DC RID: 149212 RVA: 0x0050768B File Offset: 0x0050588B
		public static VectorOffset CreatePlayerAttachTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060246DD RID: 149213 RVA: 0x005076A4 File Offset: 0x005058A4
		public static void StartPlayerAttachTagsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060246DE RID: 149214 RVA: 0x005076AF File Offset: 0x005058AF
		public static void AddSafePointId(FlatBufferBuilder builder, int safePointId)
		{
			builder.AddInt(2, safePointId, 0);
		}

		// Token: 0x060246DF RID: 149215 RVA: 0x005076BA File Offset: 0x005058BA
		public static Offset<IMovablePlatformVehicleFeature> EndIMovablePlatformVehicleFeature(FlatBufferBuilder builder)
		{
			return new Offset<IMovablePlatformVehicleFeature>(builder.EndTable());
		}

		// Token: 0x060246E0 RID: 149216 RVA: 0x005076C8 File Offset: 0x005058C8
		public IMovablePlatformVehicleFeatureT UnPack()
		{
			IMovablePlatformVehicleFeatureT movablePlatformVehicleFeatureT = new IMovablePlatformVehicleFeatureT();
			this.UnPackTo(movablePlatformVehicleFeatureT);
			return movablePlatformVehicleFeatureT;
		}

		// Token: 0x060246E1 RID: 149217 RVA: 0x005076E4 File Offset: 0x005058E4
		public void UnPackTo(IMovablePlatformVehicleFeatureT _o)
		{
			_o.Type = this.Type;
			_o.PlayerAttachTags = new List<int>();
			for (int i = 0; i < this.PlayerAttachTagsLength; i++)
			{
				_o.PlayerAttachTags.Add(this.PlayerAttachTags(i));
			}
			_o.SafePointId = this.SafePointId;
		}

		// Token: 0x060246E2 RID: 149218 RVA: 0x00507738 File Offset: 0x00505938
		public static Offset<IMovablePlatformVehicleFeature> Pack(FlatBufferBuilder builder, IMovablePlatformVehicleFeatureT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMovablePlatformVehicleFeature>);
			}
			VectorOffset playerAttachTagsOffset = default(VectorOffset);
			if (_o.PlayerAttachTags != null)
			{
				int[] data = _o.PlayerAttachTags.ToArray();
				playerAttachTagsOffset = IMovablePlatformVehicleFeature.CreatePlayerAttachTagsVector(builder, data);
			}
			return IMovablePlatformVehicleFeature.CreateIMovablePlatformVehicleFeature(builder, _o.Type, playerAttachTagsOffset, _o.SafePointId);
		}

		// Token: 0x0400E932 RID: 59698
		private Table __p;
	}
}
