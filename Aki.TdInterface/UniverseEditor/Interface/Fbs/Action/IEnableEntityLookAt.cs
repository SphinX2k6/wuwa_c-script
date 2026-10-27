using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200665A RID: 26202
	public struct IEnableEntityLookAt : IFlatbufferObject
	{
		// Token: 0x1700C2A4 RID: 49828
		// (get) Token: 0x0602D825 RID: 186405 RVA: 0x0063B57E File Offset: 0x0063977E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D826 RID: 186406 RVA: 0x0063B58B File Offset: 0x0063978B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D827 RID: 186407 RVA: 0x0063B594 File Offset: 0x00639794
		public static IEnableEntityLookAt GetRootAsIEnableEntityLookAt(ByteBuffer _bb)
		{
			return IEnableEntityLookAt.GetRootAsIEnableEntityLookAt(_bb, default(IEnableEntityLookAt));
		}

		// Token: 0x0602D828 RID: 186408 RVA: 0x0063B5B0 File Offset: 0x006397B0
		public static IEnableEntityLookAt GetRootAsIEnableEntityLookAt(ByteBuffer _bb, IEnableEntityLookAt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D829 RID: 186409 RVA: 0x0063B5CD File Offset: 0x006397CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D82A RID: 186410 RVA: 0x0063B5DC File Offset: 0x006397DC
		public IEnableEntityLookAt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C2A5 RID: 49829
		// (get) Token: 0x0602D82B RID: 186411 RVA: 0x0063B5EC File Offset: 0x006397EC
		public string Key
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D82C RID: 186412 RVA: 0x0063B623 File Offset: 0x00639823
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602D82D RID: 186413 RVA: 0x0063B632 File Offset: 0x00639832
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700C2A6 RID: 49830
		// (get) Token: 0x0602D82E RID: 186414 RVA: 0x0063B640 File Offset: 0x00639840
		public TDefaultLookAtType DefaultLookAtTypeType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TDefaultLookAtType.NONE;
				}
				return (TDefaultLookAtType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D82F RID: 186415 RVA: 0x0063B67C File Offset: 0x0063987C
		public TTable? DefaultLookAtType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602D830 RID: 186416 RVA: 0x0063B6C0 File Offset: 0x006398C0
		public ILookAtBubbleEntity DefaultLookAtTypeAsILookAtBubbleEntity()
		{
			return this.DefaultLookAtType<ILookAtBubbleEntity>().Value;
		}

		// Token: 0x0602D831 RID: 186417 RVA: 0x0063B6DC File Offset: 0x006398DC
		public ILookAtTarget DefaultLookAtTypeAsILookAtTarget()
		{
			return this.DefaultLookAtType<ILookAtTarget>().Value;
		}

		// Token: 0x1700C2A7 RID: 49831
		// (get) Token: 0x0602D832 RID: 186418 RVA: 0x0063B6F8 File Offset: 0x006398F8
		public ICheckFlowLookAt? OverrideLookAtType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new ICheckFlowLookAt?(default(ICheckFlowLookAt).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602D833 RID: 186419 RVA: 0x0063B758 File Offset: 0x00639958
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C2A8 RID: 49832
		// (get) Token: 0x0602D834 RID: 186420 RVA: 0x0063B798 File Offset: 0x00639998
		public int EntityIdsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602D835 RID: 186421 RVA: 0x0063B7C4 File Offset: 0x006399C4
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0602D836 RID: 186422 RVA: 0x0063B7D4 File Offset: 0x006399D4
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(12);
		}

		// Token: 0x0602D837 RID: 186423 RVA: 0x0063B7E3 File Offset: 0x006399E3
		public static Offset<IEnableEntityLookAt> CreateIEnableEntityLookAt(FlatBufferBuilder builder, StringOffset KeyOffset = default(StringOffset), TDefaultLookAtType DefaultLookAtType_type = TDefaultLookAtType.NONE, int DefaultLookAtTypeOffset = 0, Offset<ICheckFlowLookAt> OverrideLookAtTypeOffset = default(Offset<ICheckFlowLookAt>), VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(5);
			IEnableEntityLookAt.AddEntityIds(builder, EntityIdsOffset);
			IEnableEntityLookAt.AddOverrideLookAtType(builder, OverrideLookAtTypeOffset);
			IEnableEntityLookAt.AddDefaultLookAtType(builder, DefaultLookAtTypeOffset);
			IEnableEntityLookAt.AddKey(builder, KeyOffset);
			IEnableEntityLookAt.AddDefaultLookAtTypeType(builder, DefaultLookAtType_type);
			return IEnableEntityLookAt.EndIEnableEntityLookAt(builder);
		}

		// Token: 0x0602D838 RID: 186424 RVA: 0x0063B817 File Offset: 0x00639A17
		public static void StartIEnableEntityLookAt(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602D839 RID: 186425 RVA: 0x0063B820 File Offset: 0x00639A20
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(0, keyOffset.Value, 0);
		}

		// Token: 0x0602D83A RID: 186426 RVA: 0x0063B830 File Offset: 0x00639A30
		public static void AddDefaultLookAtTypeType(FlatBufferBuilder builder, TDefaultLookAtType defaultLookAtTypeType)
		{
			builder.AddByte(1, (byte)defaultLookAtTypeType, 0);
		}

		// Token: 0x0602D83B RID: 186427 RVA: 0x0063B83B File Offset: 0x00639A3B
		public static void AddDefaultLookAtType(FlatBufferBuilder builder, int defaultLookAtTypeOffset)
		{
			builder.AddOffset(2, defaultLookAtTypeOffset, 0);
		}

		// Token: 0x0602D83C RID: 186428 RVA: 0x0063B846 File Offset: 0x00639A46
		public static void AddOverrideLookAtType(FlatBufferBuilder builder, Offset<ICheckFlowLookAt> overrideLookAtTypeOffset)
		{
			builder.AddOffset(3, overrideLookAtTypeOffset.Value, 0);
		}

		// Token: 0x0602D83D RID: 186429 RVA: 0x0063B856 File Offset: 0x00639A56
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(4, entityIdsOffset.Value, 0);
		}

		// Token: 0x0602D83E RID: 186430 RVA: 0x0063B868 File Offset: 0x00639A68
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602D83F RID: 186431 RVA: 0x0063B89F File Offset: 0x00639A9F
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602D840 RID: 186432 RVA: 0x0063B8B9 File Offset: 0x00639AB9
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602D841 RID: 186433 RVA: 0x0063B8D7 File Offset: 0x00639AD7
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602D842 RID: 186434 RVA: 0x0063B8F0 File Offset: 0x00639AF0
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602D843 RID: 186435 RVA: 0x0063B8FB File Offset: 0x00639AFB
		public static Offset<IEnableEntityLookAt> EndIEnableEntityLookAt(FlatBufferBuilder builder)
		{
			return new Offset<IEnableEntityLookAt>(builder.EndTable());
		}

		// Token: 0x0602D844 RID: 186436 RVA: 0x0063B908 File Offset: 0x00639B08
		public IEnableEntityLookAtT UnPack()
		{
			IEnableEntityLookAtT enableEntityLookAtT = new IEnableEntityLookAtT();
			this.UnPackTo(enableEntityLookAtT);
			return enableEntityLookAtT;
		}

		// Token: 0x0602D845 RID: 186437 RVA: 0x0063B924 File Offset: 0x00639B24
		public void UnPackTo(IEnableEntityLookAtT _o)
		{
			_o.Key = this.Key;
			_o.DefaultLookAtType = new TDefaultLookAtTypeUnion();
			_o.DefaultLookAtType.Type = this.DefaultLookAtTypeType;
			TDefaultLookAtType defaultLookAtTypeType = this.DefaultLookAtTypeType;
			if (defaultLookAtTypeType != TDefaultLookAtType.ILookAtBubbleEntity)
			{
				if (defaultLookAtTypeType == TDefaultLookAtType.ILookAtTarget)
				{
					_o.DefaultLookAtType.Value = ((this.DefaultLookAtType<ILookAtTarget>() != null) ? this.DefaultLookAtType<ILookAtTarget>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.DefaultLookAtType.Value = ((this.DefaultLookAtType<ILookAtBubbleEntity>() != null) ? this.DefaultLookAtType<ILookAtBubbleEntity>().Value.UnPack() : null);
			}
			_o.OverrideLookAtType = ((this.OverrideLookAtType != null) ? this.OverrideLookAtType.Value.UnPack() : null);
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
		}

		// Token: 0x0602D846 RID: 186438 RVA: 0x0063BA3C File Offset: 0x00639C3C
		public static Offset<IEnableEntityLookAt> Pack(FlatBufferBuilder builder, IEnableEntityLookAtT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableEntityLookAt>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			TDefaultLookAtType defaultLookAtType_type = (_o.DefaultLookAtType == null) ? TDefaultLookAtType.NONE : _o.DefaultLookAtType.Type;
			int defaultLookAtTypeOffset = (_o.DefaultLookAtType == null) ? 0 : TDefaultLookAtTypeUnion.Pack(builder, _o.DefaultLookAtType);
			Offset<ICheckFlowLookAt> overrideLookAtTypeOffset = (_o.OverrideLookAtType == null) ? default(Offset<ICheckFlowLookAt>) : ICheckFlowLookAt.Pack(builder, _o.OverrideLookAtType);
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IEnableEntityLookAt.CreateEntityIdsVector(builder, data);
			}
			return IEnableEntityLookAt.CreateIEnableEntityLookAt(builder, keyOffset, defaultLookAtType_type, defaultLookAtTypeOffset, overrideLookAtTypeOffset, entityIdsOffset);
		}

		// Token: 0x04010CF8 RID: 68856
		private Table __p;
	}
}
