using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B70 RID: 23408
	public struct IMovablePlatformVehicleFeature : IFlatbufferObject
	{
		// Token: 0x1700AB0C RID: 43788
		// (get) Token: 0x060268D6 RID: 157910 RVA: 0x005479DF File Offset: 0x00545BDF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060268D7 RID: 157911 RVA: 0x005479EC File Offset: 0x00545BEC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060268D8 RID: 157912 RVA: 0x005479F4 File Offset: 0x00545BF4
		public static IMovablePlatformVehicleFeature GetRootAsIMovablePlatformVehicleFeature(ByteBuffer _bb)
		{
			return IMovablePlatformVehicleFeature.GetRootAsIMovablePlatformVehicleFeature(_bb, default(IMovablePlatformVehicleFeature));
		}

		// Token: 0x060268D9 RID: 157913 RVA: 0x00547A10 File Offset: 0x00545C10
		public static IMovablePlatformVehicleFeature GetRootAsIMovablePlatformVehicleFeature(ByteBuffer _bb, IMovablePlatformVehicleFeature obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060268DA RID: 157914 RVA: 0x00547A2D File Offset: 0x00545C2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060268DB RID: 157915 RVA: 0x00547A3C File Offset: 0x00545C3C
		public IMovablePlatformVehicleFeature __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AB0D RID: 43789
		// (get) Token: 0x060268DC RID: 157916 RVA: 0x00547A4C File Offset: 0x00545C4C
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

		// Token: 0x060268DD RID: 157917 RVA: 0x00547A88 File Offset: 0x00545C88
		public int PlayerAttachTags(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700AB0E RID: 43790
		// (get) Token: 0x060268DE RID: 157918 RVA: 0x00547AC8 File Offset: 0x00545CC8
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

		// Token: 0x060268DF RID: 157919 RVA: 0x00547AF3 File Offset: 0x00545CF3
		public Span<int> GetPlayerAttachTagsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060268E0 RID: 157920 RVA: 0x00547B02 File Offset: 0x00545D02
		public int[] GetPlayerAttachTagsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700AB0F RID: 43791
		// (get) Token: 0x060268E1 RID: 157921 RVA: 0x00547B10 File Offset: 0x00545D10
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

		// Token: 0x060268E2 RID: 157922 RVA: 0x00547B4C File Offset: 0x00545D4C
		public static Offset<IMovablePlatformVehicleFeature> CreateIMovablePlatformVehicleFeature(FlatBufferBuilder builder, EVehicleFeatureFlag Type = EVehicleFeatureFlag.None, VectorOffset PlayerAttachTagsOffset = default(VectorOffset), int SafePointId = 0)
		{
			builder.StartTable(3);
			IMovablePlatformVehicleFeature.AddSafePointId(builder, SafePointId);
			IMovablePlatformVehicleFeature.AddPlayerAttachTags(builder, PlayerAttachTagsOffset);
			IMovablePlatformVehicleFeature.AddType(builder, Type);
			return IMovablePlatformVehicleFeature.EndIMovablePlatformVehicleFeature(builder);
		}

		// Token: 0x060268E3 RID: 157923 RVA: 0x00547B70 File Offset: 0x00545D70
		public static void StartIMovablePlatformVehicleFeature(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060268E4 RID: 157924 RVA: 0x00547B79 File Offset: 0x00545D79
		public static void AddType(FlatBufferBuilder builder, EVehicleFeatureFlag type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060268E5 RID: 157925 RVA: 0x00547B84 File Offset: 0x00545D84
		public static void AddPlayerAttachTags(FlatBufferBuilder builder, VectorOffset playerAttachTagsOffset)
		{
			builder.AddOffset(1, playerAttachTagsOffset.Value, 0);
		}

		// Token: 0x060268E6 RID: 157926 RVA: 0x00547B94 File Offset: 0x00545D94
		public static VectorOffset CreatePlayerAttachTagsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060268E7 RID: 157927 RVA: 0x00547BCB File Offset: 0x00545DCB
		public static VectorOffset CreatePlayerAttachTagsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060268E8 RID: 157928 RVA: 0x00547BE5 File Offset: 0x00545DE5
		public static VectorOffset CreatePlayerAttachTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060268E9 RID: 157929 RVA: 0x00547C03 File Offset: 0x00545E03
		public static VectorOffset CreatePlayerAttachTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060268EA RID: 157930 RVA: 0x00547C1C File Offset: 0x00545E1C
		public static void StartPlayerAttachTagsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060268EB RID: 157931 RVA: 0x00547C27 File Offset: 0x00545E27
		public static void AddSafePointId(FlatBufferBuilder builder, int safePointId)
		{
			builder.AddInt(2, safePointId, 0);
		}

		// Token: 0x060268EC RID: 157932 RVA: 0x00547C32 File Offset: 0x00545E32
		public static Offset<IMovablePlatformVehicleFeature> EndIMovablePlatformVehicleFeature(FlatBufferBuilder builder)
		{
			return new Offset<IMovablePlatformVehicleFeature>(builder.EndTable());
		}

		// Token: 0x060268ED RID: 157933 RVA: 0x00547C40 File Offset: 0x00545E40
		public IMovablePlatformVehicleFeatureT UnPack()
		{
			IMovablePlatformVehicleFeatureT movablePlatformVehicleFeatureT = new IMovablePlatformVehicleFeatureT();
			this.UnPackTo(movablePlatformVehicleFeatureT);
			return movablePlatformVehicleFeatureT;
		}

		// Token: 0x060268EE RID: 157934 RVA: 0x00547C5C File Offset: 0x00545E5C
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

		// Token: 0x060268EF RID: 157935 RVA: 0x00547CB0 File Offset: 0x00545EB0
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

		// Token: 0x0400F594 RID: 62868
		private Table __p;
	}
}
