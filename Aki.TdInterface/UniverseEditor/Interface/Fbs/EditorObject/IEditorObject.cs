using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.EditorObject
{
	// Token: 0x02004D5E RID: 19806
	public struct IEditorObject : IFlatbufferObject
	{
		// Token: 0x17008DC2 RID: 36290
		// (get) Token: 0x0601EB1F RID: 125727 RVA: 0x0044B392 File Offset: 0x00449592
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EB20 RID: 125728 RVA: 0x0044B39F File Offset: 0x0044959F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EB21 RID: 125729 RVA: 0x0044B3A8 File Offset: 0x004495A8
		public static IEditorObject GetRootAsIEditorObject(ByteBuffer _bb)
		{
			return IEditorObject.GetRootAsIEditorObject(_bb, default(IEditorObject));
		}

		// Token: 0x0601EB22 RID: 125730 RVA: 0x0044B3C4 File Offset: 0x004495C4
		public static IEditorObject GetRootAsIEditorObject(ByteBuffer _bb, IEditorObject obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EB23 RID: 125731 RVA: 0x0044B3E1 File Offset: 0x004495E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EB24 RID: 125732 RVA: 0x0044B3F0 File Offset: 0x004495F0
		public IEditorObject __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008DC3 RID: 36291
		// (get) Token: 0x0601EB25 RID: 125733 RVA: 0x0044B400 File Offset: 0x00449600
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

		// Token: 0x0601EB26 RID: 125734 RVA: 0x0044B43C File Offset: 0x0044963C
		public string Children(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008DC4 RID: 36292
		// (get) Token: 0x0601EB27 RID: 125735 RVA: 0x0044B478 File Offset: 0x00449678
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

		// Token: 0x0601EB28 RID: 125736 RVA: 0x0044B4A4 File Offset: 0x004496A4
		public string Reference(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008DC5 RID: 36293
		// (get) Token: 0x0601EB29 RID: 125737 RVA: 0x0044B4E0 File Offset: 0x004496E0
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

		// Token: 0x0601EB2A RID: 125738 RVA: 0x0044B50C File Offset: 0x0044970C
		public string WeakReference(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008DC6 RID: 36294
		// (get) Token: 0x0601EB2B RID: 125739 RVA: 0x0044B548 File Offset: 0x00449748
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

		// Token: 0x17008DC7 RID: 36295
		// (get) Token: 0x0601EB2C RID: 125740 RVA: 0x0044B574 File Offset: 0x00449774
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

		// Token: 0x0601EB2D RID: 125741 RVA: 0x0044B5B1 File Offset: 0x004497B1
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

		// Token: 0x0601EB2E RID: 125742 RVA: 0x0044B5E5 File Offset: 0x004497E5
		public static void StartIEditorObject(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601EB2F RID: 125743 RVA: 0x0044B5EE File Offset: 0x004497EE
		public static void AddObjType(FlatBufferBuilder builder, TEditorObjectType objType)
		{
			builder.AddByte(0, (byte)objType, 0);
		}

		// Token: 0x0601EB30 RID: 125744 RVA: 0x0044B5F9 File Offset: 0x004497F9
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(1, childrenOffset.Value, 0);
		}

		// Token: 0x0601EB31 RID: 125745 RVA: 0x0044B60C File Offset: 0x0044980C
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601EB32 RID: 125746 RVA: 0x0044B64C File Offset: 0x0044984C
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601EB33 RID: 125747 RVA: 0x0044B666 File Offset: 0x00449866
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601EB34 RID: 125748 RVA: 0x0044B684 File Offset: 0x00449884
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601EB35 RID: 125749 RVA: 0x0044B69D File Offset: 0x0044989D
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601EB36 RID: 125750 RVA: 0x0044B6A8 File Offset: 0x004498A8
		public static void AddReference(FlatBufferBuilder builder, VectorOffset referenceOffset)
		{
			builder.AddOffset(2, referenceOffset.Value, 0);
		}

		// Token: 0x0601EB37 RID: 125751 RVA: 0x0044B6B8 File Offset: 0x004498B8
		public static VectorOffset CreateReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601EB38 RID: 125752 RVA: 0x0044B6F8 File Offset: 0x004498F8
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601EB39 RID: 125753 RVA: 0x0044B712 File Offset: 0x00449912
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601EB3A RID: 125754 RVA: 0x0044B730 File Offset: 0x00449930
		public static VectorOffset CreateReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601EB3B RID: 125755 RVA: 0x0044B749 File Offset: 0x00449949
		public static void StartReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601EB3C RID: 125756 RVA: 0x0044B754 File Offset: 0x00449954
		public static void AddWeakReference(FlatBufferBuilder builder, VectorOffset weakReferenceOffset)
		{
			builder.AddOffset(3, weakReferenceOffset.Value, 0);
		}

		// Token: 0x0601EB3D RID: 125757 RVA: 0x0044B764 File Offset: 0x00449964
		public static VectorOffset CreateWeakReferenceVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601EB3E RID: 125758 RVA: 0x0044B7A4 File Offset: 0x004499A4
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601EB3F RID: 125759 RVA: 0x0044B7BE File Offset: 0x004499BE
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601EB40 RID: 125760 RVA: 0x0044B7DC File Offset: 0x004499DC
		public static VectorOffset CreateWeakReferenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601EB41 RID: 125761 RVA: 0x0044B7F5 File Offset: 0x004499F5
		public static void StartWeakReferenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601EB42 RID: 125762 RVA: 0x0044B800 File Offset: 0x00449A00
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601EB43 RID: 125763 RVA: 0x0044B80B File Offset: 0x00449A0B
		public static Offset<IEditorObject> EndIEditorObject(FlatBufferBuilder builder)
		{
			return new Offset<IEditorObject>(builder.EndTable());
		}

		// Token: 0x0601EB44 RID: 125764 RVA: 0x0044B818 File Offset: 0x00449A18
		public IEditorObjectT UnPack()
		{
			IEditorObjectT editorObjectT = new IEditorObjectT();
			this.UnPackTo(editorObjectT);
			return editorObjectT;
		}

		// Token: 0x0601EB45 RID: 125765 RVA: 0x0044B834 File Offset: 0x00449A34
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

		// Token: 0x0601EB46 RID: 125766 RVA: 0x0044B8E4 File Offset: 0x00449AE4
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

		// Token: 0x0400D991 RID: 55697
		private Table __p;
	}
}
