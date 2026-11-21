using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006062 RID: 24674
	public struct ITemplateMatrix : IFlatbufferObject
	{
		// Token: 0x1700B731 RID: 46897
		// (get) Token: 0x06029ABA RID: 170682 RVA: 0x005B04BF File Offset: 0x005AE6BF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029ABB RID: 170683 RVA: 0x005B04CC File Offset: 0x005AE6CC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029ABC RID: 170684 RVA: 0x005B04D4 File Offset: 0x005AE6D4
		public static ITemplateMatrix GetRootAsITemplateMatrix(ByteBuffer _bb)
		{
			return ITemplateMatrix.GetRootAsITemplateMatrix(_bb, default(ITemplateMatrix));
		}

		// Token: 0x06029ABD RID: 170685 RVA: 0x005B04F0 File Offset: 0x005AE6F0
		public static ITemplateMatrix GetRootAsITemplateMatrix(ByteBuffer _bb, ITemplateMatrix obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029ABE RID: 170686 RVA: 0x005B050D File Offset: 0x005AE70D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029ABF RID: 170687 RVA: 0x005B051C File Offset: 0x005AE71C
		public ITemplateMatrix __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B732 RID: 46898
		// (get) Token: 0x06029AC0 RID: 170688 RVA: 0x005B052C File Offset: 0x005AE72C
		public ESpawnConfigType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpawnConfigType.TemplateMatrix;
				}
				return (ESpawnConfigType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B733 RID: 46899
		// (get) Token: 0x06029AC1 RID: 170689 RVA: 0x005B0568 File Offset: 0x005AE768
		public IVector2? MatrixSize
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVector2?(default(IVector2).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06029AC2 RID: 170690 RVA: 0x005B05C8 File Offset: 0x005AE7C8
		public ITemplateMatrixRow? TemplateMatrix(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new ITemplateMatrixRow?(default(ITemplateMatrixRow).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B734 RID: 46900
		// (get) Token: 0x06029AC3 RID: 170691 RVA: 0x005B0628 File Offset: 0x005AE828
		public int TemplateMatrixLength
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

		// Token: 0x1700B735 RID: 46901
		// (get) Token: 0x06029AC4 RID: 170692 RVA: 0x005B0654 File Offset: 0x005AE854
		public IVectorInfo? EntityInterval
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B736 RID: 46902
		// (get) Token: 0x06029AC5 RID: 170693 RVA: 0x005B06B4 File Offset: 0x005AE8B4
		public bool IsInitHide
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06029AC6 RID: 170694 RVA: 0x005B06F4 File Offset: 0x005AE8F4
		public IGroupDestroyListenConfig? GroupDestroyListenConfigs(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IGroupDestroyListenConfig?(default(IGroupDestroyListenConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B737 RID: 46903
		// (get) Token: 0x06029AC7 RID: 170695 RVA: 0x005B0758 File Offset: 0x005AE958
		public int GroupDestroyListenConfigsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06029AC8 RID: 170696 RVA: 0x005B0784 File Offset: 0x005AE984
		public IChildEntityStateControl? ChildEntityStateControls(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IChildEntityStateControl?(default(IChildEntityStateControl).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B738 RID: 46904
		// (get) Token: 0x06029AC9 RID: 170697 RVA: 0x005B07E8 File Offset: 0x005AE9E8
		public int ChildEntityStateControlsLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06029ACA RID: 170698 RVA: 0x005B0814 File Offset: 0x005AEA14
		public IActionInfo? OnNonGroupEntityDestroy(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B739 RID: 46905
		// (get) Token: 0x06029ACB RID: 170699 RVA: 0x005B0878 File Offset: 0x005AEA78
		public int OnNonGroupEntityDestroyLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700B73A RID: 46906
		// (get) Token: 0x06029ACC RID: 170700 RVA: 0x005B08A4 File Offset: 0x005AEAA4
		public IChangeTemplateInstanceStateConfig? NonGroupDestroyChangeInstanceStateConfig
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return new IChangeTemplateInstanceStateConfig?(default(IChangeTemplateInstanceStateConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B73B RID: 46907
		// (get) Token: 0x06029ACD RID: 170701 RVA: 0x005B0904 File Offset: 0x005AEB04
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029ACE RID: 170702 RVA: 0x005B0944 File Offset: 0x005AEB44
		public static Offset<ITemplateMatrix> CreateITemplateMatrix(FlatBufferBuilder builder, ESpawnConfigType Type = ESpawnConfigType.TemplateMatrix, Offset<IVector2> MatrixSizeOffset = default(Offset<IVector2>), VectorOffset TemplateMatrixOffset = default(VectorOffset), Offset<IVectorInfo> EntityIntervalOffset = default(Offset<IVectorInfo>), bool IsInitHide = false, VectorOffset GroupDestroyListenConfigsOffset = default(VectorOffset), VectorOffset ChildEntityStateControlsOffset = default(VectorOffset), VectorOffset OnNonGroupEntityDestroyOffset = default(VectorOffset), Offset<IChangeTemplateInstanceStateConfig> NonGroupDestroyChangeInstanceStateConfigOffset = default(Offset<IChangeTemplateInstanceStateConfig>), byte NullMask = 0)
		{
			builder.StartTable(10);
			ITemplateMatrix.AddNonGroupDestroyChangeInstanceStateConfig(builder, NonGroupDestroyChangeInstanceStateConfigOffset);
			ITemplateMatrix.AddOnNonGroupEntityDestroy(builder, OnNonGroupEntityDestroyOffset);
			ITemplateMatrix.AddChildEntityStateControls(builder, ChildEntityStateControlsOffset);
			ITemplateMatrix.AddGroupDestroyListenConfigs(builder, GroupDestroyListenConfigsOffset);
			ITemplateMatrix.AddEntityInterval(builder, EntityIntervalOffset);
			ITemplateMatrix.AddTemplateMatrix(builder, TemplateMatrixOffset);
			ITemplateMatrix.AddMatrixSize(builder, MatrixSizeOffset);
			ITemplateMatrix.AddNullMask(builder, NullMask);
			ITemplateMatrix.AddIsInitHide(builder, IsInitHide);
			ITemplateMatrix.AddType(builder, Type);
			return ITemplateMatrix.EndITemplateMatrix(builder);
		}

		// Token: 0x06029ACF RID: 170703 RVA: 0x005B09AC File Offset: 0x005AEBAC
		public static void StartITemplateMatrix(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x06029AD0 RID: 170704 RVA: 0x005B09B6 File Offset: 0x005AEBB6
		public static void AddType(FlatBufferBuilder builder, ESpawnConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029AD1 RID: 170705 RVA: 0x005B09C1 File Offset: 0x005AEBC1
		public static void AddMatrixSize(FlatBufferBuilder builder, Offset<IVector2> matrixSizeOffset)
		{
			builder.AddOffset(1, matrixSizeOffset.Value, 0);
		}

		// Token: 0x06029AD2 RID: 170706 RVA: 0x005B09D1 File Offset: 0x005AEBD1
		public static void AddTemplateMatrix(FlatBufferBuilder builder, VectorOffset templateMatrixOffset)
		{
			builder.AddOffset(2, templateMatrixOffset.Value, 0);
		}

		// Token: 0x06029AD3 RID: 170707 RVA: 0x005B09E4 File Offset: 0x005AEBE4
		public static VectorOffset CreateTemplateMatrixVector(FlatBufferBuilder builder, Offset<ITemplateMatrixRow>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06029AD4 RID: 170708 RVA: 0x005B0A24 File Offset: 0x005AEC24
		public static VectorOffset CreateTemplateMatrixVectorBlock(FlatBufferBuilder builder, Offset<ITemplateMatrixRow>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITemplateMatrixRow>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029AD5 RID: 170709 RVA: 0x005B0A3E File Offset: 0x005AEC3E
		public static VectorOffset CreateTemplateMatrixVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITemplateMatrixRow>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITemplateMatrixRow>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029AD6 RID: 170710 RVA: 0x005B0A5C File Offset: 0x005AEC5C
		public static VectorOffset CreateTemplateMatrixVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITemplateMatrixRow>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029AD7 RID: 170711 RVA: 0x005B0A75 File Offset: 0x005AEC75
		public static void StartTemplateMatrixVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029AD8 RID: 170712 RVA: 0x005B0A80 File Offset: 0x005AEC80
		public static void AddEntityInterval(FlatBufferBuilder builder, Offset<IVectorInfo> entityIntervalOffset)
		{
			builder.AddOffset(3, entityIntervalOffset.Value, 0);
		}

		// Token: 0x06029AD9 RID: 170713 RVA: 0x005B0A90 File Offset: 0x005AEC90
		public static void AddIsInitHide(FlatBufferBuilder builder, bool isInitHide)
		{
			builder.AddBool(4, isInitHide, false);
		}

		// Token: 0x06029ADA RID: 170714 RVA: 0x005B0A9B File Offset: 0x005AEC9B
		public static void AddGroupDestroyListenConfigs(FlatBufferBuilder builder, VectorOffset groupDestroyListenConfigsOffset)
		{
			builder.AddOffset(5, groupDestroyListenConfigsOffset.Value, 0);
		}

		// Token: 0x06029ADB RID: 170715 RVA: 0x005B0AAC File Offset: 0x005AECAC
		public static VectorOffset CreateGroupDestroyListenConfigsVector(FlatBufferBuilder builder, Offset<IGroupDestroyListenConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06029ADC RID: 170716 RVA: 0x005B0AEC File Offset: 0x005AECEC
		public static VectorOffset CreateGroupDestroyListenConfigsVectorBlock(FlatBufferBuilder builder, Offset<IGroupDestroyListenConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IGroupDestroyListenConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029ADD RID: 170717 RVA: 0x005B0B06 File Offset: 0x005AED06
		public static VectorOffset CreateGroupDestroyListenConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IGroupDestroyListenConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IGroupDestroyListenConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029ADE RID: 170718 RVA: 0x005B0B24 File Offset: 0x005AED24
		public static VectorOffset CreateGroupDestroyListenConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IGroupDestroyListenConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029ADF RID: 170719 RVA: 0x005B0B3D File Offset: 0x005AED3D
		public static void StartGroupDestroyListenConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029AE0 RID: 170720 RVA: 0x005B0B48 File Offset: 0x005AED48
		public static void AddChildEntityStateControls(FlatBufferBuilder builder, VectorOffset childEntityStateControlsOffset)
		{
			builder.AddOffset(6, childEntityStateControlsOffset.Value, 0);
		}

		// Token: 0x06029AE1 RID: 170721 RVA: 0x005B0B58 File Offset: 0x005AED58
		public static VectorOffset CreateChildEntityStateControlsVector(FlatBufferBuilder builder, Offset<IChildEntityStateControl>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06029AE2 RID: 170722 RVA: 0x005B0B98 File Offset: 0x005AED98
		public static VectorOffset CreateChildEntityStateControlsVectorBlock(FlatBufferBuilder builder, Offset<IChildEntityStateControl>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IChildEntityStateControl>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029AE3 RID: 170723 RVA: 0x005B0BB2 File Offset: 0x005AEDB2
		public static VectorOffset CreateChildEntityStateControlsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IChildEntityStateControl>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IChildEntityStateControl>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029AE4 RID: 170724 RVA: 0x005B0BD0 File Offset: 0x005AEDD0
		public static VectorOffset CreateChildEntityStateControlsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IChildEntityStateControl>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029AE5 RID: 170725 RVA: 0x005B0BE9 File Offset: 0x005AEDE9
		public static void StartChildEntityStateControlsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029AE6 RID: 170726 RVA: 0x005B0BF4 File Offset: 0x005AEDF4
		public static void AddOnNonGroupEntityDestroy(FlatBufferBuilder builder, VectorOffset onNonGroupEntityDestroyOffset)
		{
			builder.AddOffset(7, onNonGroupEntityDestroyOffset.Value, 0);
		}

		// Token: 0x06029AE7 RID: 170727 RVA: 0x005B0C04 File Offset: 0x005AEE04
		public static VectorOffset CreateOnNonGroupEntityDestroyVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06029AE8 RID: 170728 RVA: 0x005B0C44 File Offset: 0x005AEE44
		public static VectorOffset CreateOnNonGroupEntityDestroyVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029AE9 RID: 170729 RVA: 0x005B0C5E File Offset: 0x005AEE5E
		public static VectorOffset CreateOnNonGroupEntityDestroyVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029AEA RID: 170730 RVA: 0x005B0C7C File Offset: 0x005AEE7C
		public static VectorOffset CreateOnNonGroupEntityDestroyVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029AEB RID: 170731 RVA: 0x005B0C95 File Offset: 0x005AEE95
		public static void StartOnNonGroupEntityDestroyVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029AEC RID: 170732 RVA: 0x005B0CA0 File Offset: 0x005AEEA0
		public static void AddNonGroupDestroyChangeInstanceStateConfig(FlatBufferBuilder builder, Offset<IChangeTemplateInstanceStateConfig> nonGroupDestroyChangeInstanceStateConfigOffset)
		{
			builder.AddOffset(8, nonGroupDestroyChangeInstanceStateConfigOffset.Value, 0);
		}

		// Token: 0x06029AED RID: 170733 RVA: 0x005B0CB0 File Offset: 0x005AEEB0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x06029AEE RID: 170734 RVA: 0x005B0CBC File Offset: 0x005AEEBC
		public static Offset<ITemplateMatrix> EndITemplateMatrix(FlatBufferBuilder builder)
		{
			return new Offset<ITemplateMatrix>(builder.EndTable());
		}

		// Token: 0x06029AEF RID: 170735 RVA: 0x005B0CCC File Offset: 0x005AEECC
		public ITemplateMatrixT UnPack()
		{
			ITemplateMatrixT templateMatrixT = new ITemplateMatrixT();
			this.UnPackTo(templateMatrixT);
			return templateMatrixT;
		}

		// Token: 0x06029AF0 RID: 170736 RVA: 0x005B0CE8 File Offset: 0x005AEEE8
		public void UnPackTo(ITemplateMatrixT _o)
		{
			_o.Type = this.Type;
			_o.MatrixSize = ((this.MatrixSize != null) ? this.MatrixSize.Value.UnPack() : null);
			_o.TemplateMatrix = new List<ITemplateMatrixRowT>();
			for (int i = 0; i < this.TemplateMatrixLength; i++)
			{
				_o.TemplateMatrix.Add((this.TemplateMatrix(i) != null) ? this.TemplateMatrix(i).Value.UnPack() : null);
			}
			_o.EntityInterval = ((this.EntityInterval != null) ? this.EntityInterval.Value.UnPack() : null);
			_o.IsInitHide = this.IsInitHide;
			_o.GroupDestroyListenConfigs = new List<IGroupDestroyListenConfigT>();
			for (int j = 0; j < this.GroupDestroyListenConfigsLength; j++)
			{
				_o.GroupDestroyListenConfigs.Add((this.GroupDestroyListenConfigs(j) != null) ? this.GroupDestroyListenConfigs(j).Value.UnPack() : null);
			}
			_o.ChildEntityStateControls = new List<IChildEntityStateControlT>();
			for (int k = 0; k < this.ChildEntityStateControlsLength; k++)
			{
				_o.ChildEntityStateControls.Add((this.ChildEntityStateControls(k) != null) ? this.ChildEntityStateControls(k).Value.UnPack() : null);
			}
			_o.OnNonGroupEntityDestroy = new List<IActionInfoT>();
			for (int l = 0; l < this.OnNonGroupEntityDestroyLength; l++)
			{
				_o.OnNonGroupEntityDestroy.Add((this.OnNonGroupEntityDestroy(l) != null) ? this.OnNonGroupEntityDestroy(l).Value.UnPack() : null);
			}
			_o.NonGroupDestroyChangeInstanceStateConfig = ((this.NonGroupDestroyChangeInstanceStateConfig != null) ? this.NonGroupDestroyChangeInstanceStateConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06029AF1 RID: 170737 RVA: 0x005B0F10 File Offset: 0x005AF110
		public static Offset<ITemplateMatrix> Pack(FlatBufferBuilder builder, ITemplateMatrixT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITemplateMatrix>);
			}
			Offset<IVector2> matrixSizeOffset = (_o.MatrixSize == null) ? default(Offset<IVector2>) : IVector2.Pack(builder, _o.MatrixSize);
			VectorOffset templateMatrixOffset = default(VectorOffset);
			if (_o.TemplateMatrix != null)
			{
				Offset<ITemplateMatrixRow>[] array = new Offset<ITemplateMatrixRow>[_o.TemplateMatrix.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ITemplateMatrixRow.Pack(builder, _o.TemplateMatrix[i]);
				}
				templateMatrixOffset = ITemplateMatrix.CreateTemplateMatrixVector(builder, array);
			}
			Offset<IVectorInfo> entityIntervalOffset = (_o.EntityInterval == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.EntityInterval);
			VectorOffset groupDestroyListenConfigsOffset = default(VectorOffset);
			if (_o.GroupDestroyListenConfigs != null)
			{
				Offset<IGroupDestroyListenConfig>[] array2 = new Offset<IGroupDestroyListenConfig>[_o.GroupDestroyListenConfigs.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IGroupDestroyListenConfig.Pack(builder, _o.GroupDestroyListenConfigs[j]);
				}
				groupDestroyListenConfigsOffset = ITemplateMatrix.CreateGroupDestroyListenConfigsVector(builder, array2);
			}
			VectorOffset childEntityStateControlsOffset = default(VectorOffset);
			if (_o.ChildEntityStateControls != null)
			{
				Offset<IChildEntityStateControl>[] array3 = new Offset<IChildEntityStateControl>[_o.ChildEntityStateControls.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IChildEntityStateControl.Pack(builder, _o.ChildEntityStateControls[k]);
				}
				childEntityStateControlsOffset = ITemplateMatrix.CreateChildEntityStateControlsVector(builder, array3);
			}
			VectorOffset onNonGroupEntityDestroyOffset = default(VectorOffset);
			if (_o.OnNonGroupEntityDestroy != null)
			{
				Offset<IActionInfo>[] array4 = new Offset<IActionInfo>[_o.OnNonGroupEntityDestroy.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = IActionInfo.Pack(builder, _o.OnNonGroupEntityDestroy[l]);
				}
				onNonGroupEntityDestroyOffset = ITemplateMatrix.CreateOnNonGroupEntityDestroyVector(builder, array4);
			}
			Offset<IChangeTemplateInstanceStateConfig> nonGroupDestroyChangeInstanceStateConfigOffset = (_o.NonGroupDestroyChangeInstanceStateConfig == null) ? default(Offset<IChangeTemplateInstanceStateConfig>) : IChangeTemplateInstanceStateConfig.Pack(builder, _o.NonGroupDestroyChangeInstanceStateConfig);
			return ITemplateMatrix.CreateITemplateMatrix(builder, _o.Type, matrixSizeOffset, templateMatrixOffset, entityIntervalOffset, _o.IsInitHide, groupDestroyListenConfigsOffset, childEntityStateControlsOffset, onNonGroupEntityDestroyOffset, nonGroupDestroyChangeInstanceStateConfigOffset, _o.NullMask);
		}

		// Token: 0x0400FDD5 RID: 64981
		private Table __p;
	}
}
