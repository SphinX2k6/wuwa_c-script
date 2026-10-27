using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.EditorObject
{
	// Token: 0x020048F9 RID: 18681
	public struct IEditorObject : IFlatbufferObject
	{
		// Token: 0x1700877A RID: 34682
		// (get) Token: 0x0601D332 RID: 119602 RVA: 0x0041EBF6 File Offset: 0x0041CDF6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D333 RID: 119603 RVA: 0x0041EC03 File Offset: 0x0041CE03
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D334 RID: 119604 RVA: 0x0041EC0C File Offset: 0x0041CE0C
		public static IEditorObject GetRootAsIEditorObject(ByteBuffer _bb)
		{
			return IEditorObject.GetRootAsIEditorObject(_bb, default(IEditorObject));
		}

		// Token: 0x0601D335 RID: 119605 RVA: 0x0041EC28 File Offset: 0x0041CE28
		public static IEditorObject GetRootAsIEditorObject(ByteBuffer _bb, IEditorObject obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D336 RID: 119606 RVA: 0x0041EC45 File Offset: 0x0041CE45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D337 RID: 119607 RVA: 0x0041EC54 File Offset: 0x0041CE54
		public IEditorObject __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700877B RID: 34683
		// (get) Token: 0x0601D338 RID: 119608 RVA: 0x0041EC64 File Offset: 0x0041CE64
		public TEditorObjectType ObjType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TEditorObjectType.BehaviorTreeFragment;
				}
				return (TEditorObjectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D339 RID: 119609 RVA: 0x0041ECA0 File Offset: 0x0041CEA0
		public string Children(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700877C RID: 34684
		// (get) Token: 0x0601D33A RID: 119610 RVA: 0x0041ECDC File Offset: 0x0041CEDC
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

		// Token: 0x0601D33B RID: 119611 RVA: 0x0041ED08 File Offset: 0x0041CF08
		public string Reference(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700877D RID: 34685
		// (get) Token: 0x0601D33C RID: 119612 RVA: 0x0041ED44 File Offset: 0x0041CF44
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

		// Token: 0x0601D33D RID: 119613 RVA: 0x0041ED70 File Offset: 0x0041CF70
		public string WeakReference(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700877E RID: 34686
		// (get) Token: 0x0601D33E RID: 119614 RVA: 0x0041EDAC File Offset: 0x0041CFAC
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

		// Token: 0x1700877F RID: 34687
		// (get) Token: 0x0601D33F RID: 119615 RVA: 0x0041EDD8 File Offset: 0x0041CFD8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D340 RID: 119616 RVA: 0x0041EE15 File Offset: 0x0041D015
		public static Offset<IEditorObject> CreateIEditorObject(FlatBufferBuilder builder, TEditorObjectType ObjType = TEditorObjectType.BehaviorTreeFragment, VectorOffset ChildrenOffset = default(VectorOffset), VectorOffset ReferenceOffset = default(VectorOffset), VectorOffset WeakReferenceOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			IEditorObject.AddWeakReference(builder, WeakReferenceOffset);
			IEditorObject.AddReference(builder, ReferenceOffset);
			IEditorObject.AddChildren(builder, ChildrenOffset);
			IEditorObject.AddNullMask(builder, NullMask);
			IEditorObject.AddObjType(builder, ObjType);
			return IEditorObject.EndIEditorObject(builder);
		}

		// Token: 0x0601D341 RID: 119617 RVA: 0x0041EE49 File Offset: 0x0041D049
		public static void StartIEditorObject(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601D342 RID: 119618 RVA: 0x0041EE52 File Offset: 0x0041D052
		public static void AddObjType(FlatBufferBuilder builder, TEditorObjectType objType)
		{
			builder.AddByte(0, (byte)objType, 0);
		}

		// Token: 0x0601D343 RID: 119619 RVA: 0x0041EE5D File Offset: 0x0041D05D
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(1, childrenOffset.Value, 0);
		}

		// Token: 0x0601D344 RID: 119620 RVA: 0x0041EE70 File Offset: 0x0041D070
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D345 RID: 119621 RVA: 0x0041EEB0 File Offset: 0x0041D0B0
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D346 RID: 119622 RVA: 0x0041EECA File Offset: 0x0041D0CA
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D347 RID: 119623 RVA: 0x0041EEE8 File Offset: 0x0041D0E8
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D348 RID: 119624 RVA: 0x0041EF01 File Offset: 0x0041D101
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D349 RID: 119625 RVA: 0x0041EF0C File Offset: 0x0041D10C
		public static void AddReference(FlatBufferBuilder builder, VectorOffset referenceOffset)
		{
			builder.AddOffset(2, referenceOffset.Value, 0);
		}

		// Token: 0x0601D34A RID: 119626 RVA: 0x0041EF1C File Offset: 0x0041D11C
		public static VectorOffset CreateReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D34B RID: 119627 RVA: 0x0041EF5C File Offset: 0x0041D15C
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D34C RID: 119628 RVA: 0x0041EF76 File Offset: 0x0041D176
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D34D RID: 119629 RVA: 0x0041EF94 File Offset: 0x0041D194
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D34E RID: 119630 RVA: 0x0041EFAD File Offset: 0x0041D1AD
		public static void StartReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D34F RID: 119631 RVA: 0x0041EFB8 File Offset: 0x0041D1B8
		public static void AddWeakReference(FlatBufferBuilder builder, VectorOffset weakReferenceOffset)
		{
			builder.AddOffset(3, weakReferenceOffset.Value, 0);
		}

		// Token: 0x0601D350 RID: 119632 RVA: 0x0041EFC8 File Offset: 0x0041D1C8
		public static VectorOffset CreateWeakReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D351 RID: 119633 RVA: 0x0041F008 File Offset: 0x0041D208
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D352 RID: 119634 RVA: 0x0041F022 File Offset: 0x0041D222
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D353 RID: 119635 RVA: 0x0041F040 File Offset: 0x0041D240
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D354 RID: 119636 RVA: 0x0041F059 File Offset: 0x0041D259
		public static void StartWeakReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D355 RID: 119637 RVA: 0x0041F064 File Offset: 0x0041D264
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601D356 RID: 119638 RVA: 0x0041F06F File Offset: 0x0041D26F
		public static Offset<IEditorObject> EndIEditorObject(FlatBufferBuilder builder)
		{
			return new Offset<IEditorObject>(builder.EndTable());
		}

		// Token: 0x0601D357 RID: 119639 RVA: 0x0041F07C File Offset: 0x0041D27C
		public IEditorObjectT UnPack()
		{
			IEditorObjectT editorObjectT = new IEditorObjectT();
			this.UnPackTo(editorObjectT);
			return editorObjectT;
		}

		// Token: 0x0601D358 RID: 119640 RVA: 0x0041F098 File Offset: 0x0041D298
		public void UnPackTo(IEditorObjectT _o)
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
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601D359 RID: 119641 RVA: 0x0041F148 File Offset: 0x0041D348
		public static Offset<IEditorObject> Pack(FlatBufferBuilder builder, IEditorObjectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEditorObject>);
			}
			VectorOffset childrenOffset = default(VectorOffset);
			if (_o.Children != null)
			{
				StringOffset[] array = new StringOffset[_o.Children.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.Children[i]);
				}
				childrenOffset = IEditorObject.CreateChildrenVector(builder, array);
			}
			VectorOffset referenceOffset = default(VectorOffset);
			if (_o.Reference != null)
			{
				StringOffset[] array2 = new StringOffset[_o.Reference.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = builder.CreateString(_o.Reference[j]);
				}
				referenceOffset = IEditorObject.CreateReferenceVector(builder, array2);
			}
			VectorOffset weakReferenceOffset = default(VectorOffset);
			if (_o.WeakReference != null)
			{
				StringOffset[] array3 = new StringOffset[_o.WeakReference.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = builder.CreateString(_o.WeakReference[k]);
				}
				weakReferenceOffset = IEditorObject.CreateWeakReferenceVector(builder, array3);
			}
			return IEditorObject.CreateIEditorObject(builder, _o.ObjType, childrenOffset, referenceOffset, weakReferenceOffset, _o.NullMask);
		}

		// Token: 0x0400CF58 RID: 53080
		private Table __p;
	}
}
