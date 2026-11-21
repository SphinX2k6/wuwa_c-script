using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C37 RID: 19511
	public struct IEntityPrefabElement : IFlatbufferObject
	{
		// Token: 0x17008A55 RID: 35413
		// (get) Token: 0x0601DE44 RID: 122436 RVA: 0x0043105F File Offset: 0x0042F25F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DE45 RID: 122437 RVA: 0x0043106C File Offset: 0x0042F26C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DE46 RID: 122438 RVA: 0x00431074 File Offset: 0x0042F274
		public static IEntityPrefabElement GetRootAsIEntityPrefabElement(ByteBuffer _bb)
		{
			return IEntityPrefabElement.GetRootAsIEntityPrefabElement(_bb, default(IEntityPrefabElement));
		}

		// Token: 0x0601DE47 RID: 122439 RVA: 0x00431090 File Offset: 0x0042F290
		public static IEntityPrefabElement GetRootAsIEntityPrefabElement(ByteBuffer _bb, IEntityPrefabElement obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DE48 RID: 122440 RVA: 0x004310AD File Offset: 0x0042F2AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DE49 RID: 122441 RVA: 0x004310BC File Offset: 0x0042F2BC
		public IEntityPrefabElement __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008A56 RID: 35414
		// (get) Token: 0x0601DE4A RID: 122442 RVA: 0x004310CC File Offset: 0x0042F2CC
		public string ObjType
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

		// Token: 0x0601DE4B RID: 122443 RVA: 0x00431103 File Offset: 0x0042F303
		public Span<byte> GetObjTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601DE4C RID: 122444 RVA: 0x00431112 File Offset: 0x0042F312
		public byte[] GetObjTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0601DE4D RID: 122445 RVA: 0x00431120 File Offset: 0x0042F320
		public string Children(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008A57 RID: 35415
		// (get) Token: 0x0601DE4E RID: 122446 RVA: 0x0043115C File Offset: 0x0042F35C
		public int ChildrenLength
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

		// Token: 0x0601DE4F RID: 122447 RVA: 0x00431188 File Offset: 0x0042F388
		public string Reference(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008A58 RID: 35416
		// (get) Token: 0x0601DE50 RID: 122448 RVA: 0x004311C4 File Offset: 0x0042F3C4
		public int ReferenceLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601DE51 RID: 122449 RVA: 0x004311F0 File Offset: 0x0042F3F0
		public string WeakReference(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008A59 RID: 35417
		// (get) Token: 0x0601DE52 RID: 122450 RVA: 0x0043122C File Offset: 0x0042F42C
		public int WeakReferenceLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17008A5A RID: 35418
		// (get) Token: 0x0601DE53 RID: 122451 RVA: 0x00431258 File Offset: 0x0042F458
		public IEntityData? EntityData
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IEntityData?(default(IEntityData).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17008A5B RID: 35419
		// (get) Token: 0x0601DE54 RID: 122452 RVA: 0x004312B8 File Offset: 0x0042F4B8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601DE55 RID: 122453 RVA: 0x004312F5 File Offset: 0x0042F4F5
		public static Offset<IEntityPrefabElement> CreateIEntityPrefabElement(FlatBufferBuilder builder, StringOffset ObjTypeOffset = default(StringOffset), VectorOffset ChildrenOffset = default(VectorOffset), VectorOffset ReferenceOffset = default(VectorOffset), VectorOffset WeakReferenceOffset = default(VectorOffset), Offset<IEntityData> EntityDataOffset = default(Offset<IEntityData>), byte NullMask = 0)
		{
			builder.StartTable(6);
			IEntityPrefabElement.AddEntityData(builder, EntityDataOffset);
			IEntityPrefabElement.AddWeakReference(builder, WeakReferenceOffset);
			IEntityPrefabElement.AddReference(builder, ReferenceOffset);
			IEntityPrefabElement.AddChildren(builder, ChildrenOffset);
			IEntityPrefabElement.AddObjType(builder, ObjTypeOffset);
			IEntityPrefabElement.AddNullMask(builder, NullMask);
			return IEntityPrefabElement.EndIEntityPrefabElement(builder);
		}

		// Token: 0x0601DE56 RID: 122454 RVA: 0x00431331 File Offset: 0x0042F531
		public static void StartIEntityPrefabElement(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601DE57 RID: 122455 RVA: 0x0043133A File Offset: 0x0042F53A
		public static void AddObjType(FlatBufferBuilder builder, StringOffset objTypeOffset)
		{
			builder.AddOffset(0, objTypeOffset.Value, 0);
		}

		// Token: 0x0601DE58 RID: 122456 RVA: 0x0043134A File Offset: 0x0042F54A
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(1, childrenOffset.Value, 0);
		}

		// Token: 0x0601DE59 RID: 122457 RVA: 0x0043135C File Offset: 0x0042F55C
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601DE5A RID: 122458 RVA: 0x0043139C File Offset: 0x0042F59C
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DE5B RID: 122459 RVA: 0x004313B6 File Offset: 0x0042F5B6
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DE5C RID: 122460 RVA: 0x004313D4 File Offset: 0x0042F5D4
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601DE5D RID: 122461 RVA: 0x004313ED File Offset: 0x0042F5ED
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601DE5E RID: 122462 RVA: 0x004313F8 File Offset: 0x0042F5F8
		public static void AddReference(FlatBufferBuilder builder, VectorOffset referenceOffset)
		{
			builder.AddOffset(2, referenceOffset.Value, 0);
		}

		// Token: 0x0601DE5F RID: 122463 RVA: 0x00431408 File Offset: 0x0042F608
		public static VectorOffset CreateReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601DE60 RID: 122464 RVA: 0x00431448 File Offset: 0x0042F648
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DE61 RID: 122465 RVA: 0x00431462 File Offset: 0x0042F662
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DE62 RID: 122466 RVA: 0x00431480 File Offset: 0x0042F680
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601DE63 RID: 122467 RVA: 0x00431499 File Offset: 0x0042F699
		public static void StartReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601DE64 RID: 122468 RVA: 0x004314A4 File Offset: 0x0042F6A4
		public static void AddWeakReference(FlatBufferBuilder builder, VectorOffset weakReferenceOffset)
		{
			builder.AddOffset(3, weakReferenceOffset.Value, 0);
		}

		// Token: 0x0601DE65 RID: 122469 RVA: 0x004314B4 File Offset: 0x0042F6B4
		public static VectorOffset CreateWeakReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601DE66 RID: 122470 RVA: 0x004314F4 File Offset: 0x0042F6F4
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DE67 RID: 122471 RVA: 0x0043150E File Offset: 0x0042F70E
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DE68 RID: 122472 RVA: 0x0043152C File Offset: 0x0042F72C
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601DE69 RID: 122473 RVA: 0x00431545 File Offset: 0x0042F745
		public static void StartWeakReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601DE6A RID: 122474 RVA: 0x00431550 File Offset: 0x0042F750
		public static void AddEntityData(FlatBufferBuilder builder, Offset<IEntityData> entityDataOffset)
		{
			builder.AddOffset(4, entityDataOffset.Value, 0);
		}

		// Token: 0x0601DE6B RID: 122475 RVA: 0x00431560 File Offset: 0x0042F760
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0601DE6C RID: 122476 RVA: 0x0043156B File Offset: 0x0042F76B
		public static Offset<IEntityPrefabElement> EndIEntityPrefabElement(FlatBufferBuilder builder)
		{
			return new Offset<IEntityPrefabElement>(builder.EndTable());
		}

		// Token: 0x0601DE6D RID: 122477 RVA: 0x00431578 File Offset: 0x0042F778
		public IEntityPrefabElementT UnPack()
		{
			IEntityPrefabElementT entityPrefabElementT = new IEntityPrefabElementT();
			this.UnPackTo(entityPrefabElementT);
			return entityPrefabElementT;
		}

		// Token: 0x0601DE6E RID: 122478 RVA: 0x00431594 File Offset: 0x0042F794
		public void UnPackTo(IEntityPrefabElementT _o)
		{
			_o.ObjType = this.ObjType;
			_o.Children = new List<string>();
			for (int i = 0; i < this.ChildrenLength; i++)
			{
				_o.Children.Add(this.Children(i));
			}
			_o.Reference = new List<string>();
			for (int j = 0; j < this.ReferenceLength; j++)
			{
				_o.Reference.Add(this.Reference(j));
			}
			_o.WeakReference = new List<string>();
			for (int k = 0; k < this.WeakReferenceLength; k++)
			{
				_o.WeakReference.Add(this.WeakReference(k));
			}
			_o.EntityData = ((this.EntityData != null) ? this.EntityData.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601DE6F RID: 122479 RVA: 0x00431674 File Offset: 0x0042F874
		public static Offset<IEntityPrefabElement> Pack(FlatBufferBuilder builder, IEntityPrefabElementT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityPrefabElement>);
			}
			StringOffset objTypeOffset = (_o.ObjType == null) ? default(StringOffset) : builder.CreateString(_o.ObjType);
			VectorOffset childrenOffset = default(VectorOffset);
			if (_o.Children != null)
			{
				StringOffset[] array = new StringOffset[_o.Children.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.Children[i]);
				}
				childrenOffset = IEntityPrefabElement.CreateChildrenVector(builder, array);
			}
			VectorOffset referenceOffset = default(VectorOffset);
			if (_o.Reference != null)
			{
				StringOffset[] array2 = new StringOffset[_o.Reference.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = builder.CreateString(_o.Reference[j]);
				}
				referenceOffset = IEntityPrefabElement.CreateReferenceVector(builder, array2);
			}
			VectorOffset weakReferenceOffset = default(VectorOffset);
			if (_o.WeakReference != null)
			{
				StringOffset[] array3 = new StringOffset[_o.WeakReference.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = builder.CreateString(_o.WeakReference[k]);
				}
				weakReferenceOffset = IEntityPrefabElement.CreateWeakReferenceVector(builder, array3);
			}
			Offset<IEntityData> entityDataOffset = (_o.EntityData == null) ? default(Offset<IEntityData>) : IEntityData.Pack(builder, _o.EntityData);
			return IEntityPrefabElement.CreateIEntityPrefabElement(builder, objTypeOffset, childrenOffset, referenceOffset, weakReferenceOffset, entityDataOffset, _o.NullMask);
		}

		// Token: 0x0400D695 RID: 54933
		private Table __p;
	}
}
