using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A55 RID: 23125
	public struct ITemplateMatrix : IFlatbufferObject
	{
		// Token: 0x1700ADF9 RID: 44537
		// (get) Token: 0x06027542 RID: 161090 RVA: 0x005694B3 File Offset: 0x005676B3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027543 RID: 161091 RVA: 0x005694C0 File Offset: 0x005676C0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027544 RID: 161092 RVA: 0x005694C8 File Offset: 0x005676C8
		public static ITemplateMatrix GetRootAsITemplateMatrix(ByteBuffer _bb)
		{
			return ITemplateMatrix.GetRootAsITemplateMatrix(_bb, default(ITemplateMatrix));
		}

		// Token: 0x06027545 RID: 161093 RVA: 0x005694E4 File Offset: 0x005676E4
		public static ITemplateMatrix GetRootAsITemplateMatrix(ByteBuffer _bb, ITemplateMatrix obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027546 RID: 161094 RVA: 0x00569501 File Offset: 0x00567701
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027547 RID: 161095 RVA: 0x00569510 File Offset: 0x00567710
		public ITemplateMatrix __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ADFA RID: 44538
		// (get) Token: 0x06027548 RID: 161096 RVA: 0x00569520 File Offset: 0x00567720
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

		// Token: 0x1700ADFB RID: 44539
		// (get) Token: 0x06027549 RID: 161097 RVA: 0x0056955C File Offset: 0x0056775C
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

		// Token: 0x0602754A RID: 161098 RVA: 0x005695BC File Offset: 0x005677BC
		public ITemplateMatrixRow? TemplateMatrix(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new ITemplateMatrixRow?(default(ITemplateMatrixRow).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700ADFC RID: 44540
		// (get) Token: 0x0602754B RID: 161099 RVA: 0x0056961C File Offset: 0x0056781C
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

		// Token: 0x1700ADFD RID: 44541
		// (get) Token: 0x0602754C RID: 161100 RVA: 0x00569648 File Offset: 0x00567848
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

		// Token: 0x1700ADFE RID: 44542
		// (get) Token: 0x0602754D RID: 161101 RVA: 0x005696A8 File Offset: 0x005678A8
		public bool IsInitHide
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602754E RID: 161102 RVA: 0x005696E8 File Offset: 0x005678E8
		public IGroupDestroyListenConfig? GroupDestroyListenConfigs(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IGroupDestroyListenConfig?(default(IGroupDestroyListenConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700ADFF RID: 44543
		// (get) Token: 0x0602754F RID: 161103 RVA: 0x0056974C File Offset: 0x0056794C
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

		// Token: 0x06027550 RID: 161104 RVA: 0x00569778 File Offset: 0x00567978
		public IChildEntityStateControl? ChildEntityStateControls(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IChildEntityStateControl?(default(IChildEntityStateControl).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AE00 RID: 44544
		// (get) Token: 0x06027551 RID: 161105 RVA: 0x005697DC File Offset: 0x005679DC
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

		// Token: 0x06027552 RID: 161106 RVA: 0x00569808 File Offset: 0x00567A08
		public IActionInfo? OnNonGroupEntityDestroy(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AE01 RID: 44545
		// (get) Token: 0x06027553 RID: 161107 RVA: 0x0056986C File Offset: 0x00567A6C
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

		// Token: 0x1700AE02 RID: 44546
		// (get) Token: 0x06027554 RID: 161108 RVA: 0x00569898 File Offset: 0x00567A98
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

		// Token: 0x1700AE03 RID: 44547
		// (get) Token: 0x06027555 RID: 161109 RVA: 0x005698F8 File Offset: 0x00567AF8
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

		// Token: 0x06027556 RID: 161110 RVA: 0x00569938 File Offset: 0x00567B38
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

		// Token: 0x06027557 RID: 161111 RVA: 0x005699A0 File Offset: 0x00567BA0
		public static void StartITemplateMatrix(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x06027558 RID: 161112 RVA: 0x005699AA File Offset: 0x00567BAA
		public static void AddType(FlatBufferBuilder builder, ESpawnConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027559 RID: 161113 RVA: 0x005699B5 File Offset: 0x00567BB5
		public static void AddMatrixSize(FlatBufferBuilder builder, Offset<IVector2> matrixSizeOffset)
		{
			builder.AddOffset(1, matrixSizeOffset.Value, 0);
		}

		// Token: 0x0602755A RID: 161114 RVA: 0x005699C5 File Offset: 0x00567BC5
		public static void AddTemplateMatrix(FlatBufferBuilder builder, VectorOffset templateMatrixOffset)
		{
			builder.AddOffset(2, templateMatrixOffset.Value, 0);
		}

		// Token: 0x0602755B RID: 161115 RVA: 0x005699D8 File Offset: 0x00567BD8
		public static VectorOffset CreateTemplateMatrixVector(FlatBufferBuilder builder, Offset<ITemplateMatrixRow>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602755C RID: 161116 RVA: 0x00569A18 File Offset: 0x00567C18
		public static VectorOffset CreateTemplateMatrixVectorBlock(FlatBufferBuilder builder, Offset<ITemplateMatrixRow>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITemplateMatrixRow>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602755D RID: 161117 RVA: 0x00569A32 File Offset: 0x00567C32
		public static VectorOffset CreateTemplateMatrixVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITemplateMatrixRow>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITemplateMatrixRow>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602755E RID: 161118 RVA: 0x00569A50 File Offset: 0x00567C50
		public static VectorOffset CreateTemplateMatrixVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITemplateMatrixRow>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602755F RID: 161119 RVA: 0x00569A69 File Offset: 0x00567C69
		public static void StartTemplateMatrixVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027560 RID: 161120 RVA: 0x00569A74 File Offset: 0x00567C74
		public static void AddEntityInterval(FlatBufferBuilder builder, Offset<IVectorInfo> entityIntervalOffset)
		{
			builder.AddOffset(3, entityIntervalOffset.Value, 0);
		}

		// Token: 0x06027561 RID: 161121 RVA: 0x00569A84 File Offset: 0x00567C84
		public static void AddIsInitHide(FlatBufferBuilder builder, bool isInitHide)
		{
			builder.AddBool(4, isInitHide, false);
		}

		// Token: 0x06027562 RID: 161122 RVA: 0x00569A8F File Offset: 0x00567C8F
		public static void AddGroupDestroyListenConfigs(FlatBufferBuilder builder, VectorOffset groupDestroyListenConfigsOffset)
		{
			builder.AddOffset(5, groupDestroyListenConfigsOffset.Value, 0);
		}

		// Token: 0x06027563 RID: 161123 RVA: 0x00569AA0 File Offset: 0x00567CA0
		public static VectorOffset CreateGroupDestroyListenConfigsVector(FlatBufferBuilder builder, Offset<IGroupDestroyListenConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027564 RID: 161124 RVA: 0x00569AE0 File Offset: 0x00567CE0
		public static VectorOffset CreateGroupDestroyListenConfigsVectorBlock(FlatBufferBuilder builder, Offset<IGroupDestroyListenConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IGroupDestroyListenConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027565 RID: 161125 RVA: 0x00569AFA File Offset: 0x00567CFA
		public static VectorOffset CreateGroupDestroyListenConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IGroupDestroyListenConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IGroupDestroyListenConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027566 RID: 161126 RVA: 0x00569B18 File Offset: 0x00567D18
		public static VectorOffset CreateGroupDestroyListenConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IGroupDestroyListenConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027567 RID: 161127 RVA: 0x00569B31 File Offset: 0x00567D31
		public static void StartGroupDestroyListenConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027568 RID: 161128 RVA: 0x00569B3C File Offset: 0x00567D3C
		public static void AddChildEntityStateControls(FlatBufferBuilder builder, VectorOffset childEntityStateControlsOffset)
		{
			builder.AddOffset(6, childEntityStateControlsOffset.Value, 0);
		}

		// Token: 0x06027569 RID: 161129 RVA: 0x00569B4C File Offset: 0x00567D4C
		public static VectorOffset CreateChildEntityStateControlsVector(FlatBufferBuilder builder, Offset<IChildEntityStateControl>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602756A RID: 161130 RVA: 0x00569B8C File Offset: 0x00567D8C
		public static VectorOffset CreateChildEntityStateControlsVectorBlock(FlatBufferBuilder builder, Offset<IChildEntityStateControl>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IChildEntityStateControl>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602756B RID: 161131 RVA: 0x00569BA6 File Offset: 0x00567DA6
		public static VectorOffset CreateChildEntityStateControlsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IChildEntityStateControl>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IChildEntityStateControl>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602756C RID: 161132 RVA: 0x00569BC4 File Offset: 0x00567DC4
		public static VectorOffset CreateChildEntityStateControlsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IChildEntityStateControl>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602756D RID: 161133 RVA: 0x00569BDD File Offset: 0x00567DDD
		public static void StartChildEntityStateControlsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602756E RID: 161134 RVA: 0x00569BE8 File Offset: 0x00567DE8
		public static void AddOnNonGroupEntityDestroy(FlatBufferBuilder builder, VectorOffset onNonGroupEntityDestroyOffset)
		{
			builder.AddOffset(7, onNonGroupEntityDestroyOffset.Value, 0);
		}

		// Token: 0x0602756F RID: 161135 RVA: 0x00569BF8 File Offset: 0x00567DF8
		public static VectorOffset CreateOnNonGroupEntityDestroyVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027570 RID: 161136 RVA: 0x00569C38 File Offset: 0x00567E38
		public static VectorOffset CreateOnNonGroupEntityDestroyVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027571 RID: 161137 RVA: 0x00569C52 File Offset: 0x00567E52
		public static VectorOffset CreateOnNonGroupEntityDestroyVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027572 RID: 161138 RVA: 0x00569C70 File Offset: 0x00567E70
		public static VectorOffset CreateOnNonGroupEntityDestroyVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027573 RID: 161139 RVA: 0x00569C89 File Offset: 0x00567E89
		public static void StartOnNonGroupEntityDestroyVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027574 RID: 161140 RVA: 0x00569C94 File Offset: 0x00567E94
		public static void AddNonGroupDestroyChangeInstanceStateConfig(FlatBufferBuilder builder, Offset<IChangeTemplateInstanceStateConfig> nonGroupDestroyChangeInstanceStateConfigOffset)
		{
			builder.AddOffset(8, nonGroupDestroyChangeInstanceStateConfigOffset.Value, 0);
		}

		// Token: 0x06027575 RID: 161141 RVA: 0x00569CA4 File Offset: 0x00567EA4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x06027576 RID: 161142 RVA: 0x00569CB0 File Offset: 0x00567EB0
		public static Offset<ITemplateMatrix> EndITemplateMatrix(FlatBufferBuilder builder)
		{
			return new Offset<ITemplateMatrix>(builder.EndTable());
		}

		// Token: 0x06027577 RID: 161143 RVA: 0x00569CC0 File Offset: 0x00567EC0
		public ITemplateMatrixT UnPack()
		{
			ITemplateMatrixT templateMatrixT = new ITemplateMatrixT();
			this.UnPackTo(templateMatrixT);
			return templateMatrixT;
		}

		// Token: 0x06027578 RID: 161144 RVA: 0x00569CDC File Offset: 0x00567EDC
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

		// Token: 0x06027579 RID: 161145 RVA: 0x00569F04 File Offset: 0x00568104
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

		// Token: 0x0400F0DE RID: 61662
		private Table __p;
	}
}
