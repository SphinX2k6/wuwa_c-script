using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200500C RID: 20492
	public struct IConnectorPathAdvanceInitiator : IFlatbufferObject
	{
		// Token: 0x1700947F RID: 38015
		// (get) Token: 0x06020C5F RID: 134239 RVA: 0x0048E8B0 File Offset: 0x0048CAB0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020C60 RID: 134240 RVA: 0x0048E8BD File Offset: 0x0048CABD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020C61 RID: 134241 RVA: 0x0048E8C4 File Offset: 0x0048CAC4
		public static IConnectorPathAdvanceInitiator GetRootAsIConnectorPathAdvanceInitiator(ByteBuffer _bb)
		{
			return IConnectorPathAdvanceInitiator.GetRootAsIConnectorPathAdvanceInitiator(_bb, default(IConnectorPathAdvanceInitiator));
		}

		// Token: 0x06020C62 RID: 134242 RVA: 0x0048E8E0 File Offset: 0x0048CAE0
		public static IConnectorPathAdvanceInitiator GetRootAsIConnectorPathAdvanceInitiator(ByteBuffer _bb, IConnectorPathAdvanceInitiator obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020C63 RID: 134243 RVA: 0x0048E8FD File Offset: 0x0048CAFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020C64 RID: 134244 RVA: 0x0048E90C File Offset: 0x0048CB0C
		public IConnectorPathAdvanceInitiator __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009480 RID: 38016
		// (get) Token: 0x06020C65 RID: 134245 RVA: 0x0048E91C File Offset: 0x0048CB1C
		public string ActiveState
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

		// Token: 0x06020C66 RID: 134246 RVA: 0x0048E953 File Offset: 0x0048CB53
		public Span<byte> GetActiveStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06020C67 RID: 134247 RVA: 0x0048E962 File Offset: 0x0048CB62
		public byte[] GetActiveStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06020C68 RID: 134248 RVA: 0x0048E970 File Offset: 0x0048CB70
		public int Paths(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009481 RID: 38017
		// (get) Token: 0x06020C69 RID: 134249 RVA: 0x0048E9B0 File Offset: 0x0048CBB0
		public int PathsLength
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

		// Token: 0x06020C6A RID: 134250 RVA: 0x0048E9DB File Offset: 0x0048CBDB
		public Span<int> GetPathsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06020C6B RID: 134251 RVA: 0x0048E9EA File Offset: 0x0048CBEA
		public int[] GetPathsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x17009482 RID: 38018
		// (get) Token: 0x06020C6C RID: 134252 RVA: 0x0048E9F8 File Offset: 0x0048CBF8
		public int TargetEntity
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

		// Token: 0x17009483 RID: 38019
		// (get) Token: 0x06020C6D RID: 134253 RVA: 0x0048EA34 File Offset: 0x0048CC34
		public float AdvanceSpeed
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009484 RID: 38020
		// (get) Token: 0x06020C6E RID: 134254 RVA: 0x0048EA78 File Offset: 0x0048CC78
		public EConnectorPathAdvanceVisualType VisualType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return EConnectorPathAdvanceVisualType.VasePlant;
				}
				return (EConnectorPathAdvanceVisualType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009485 RID: 38021
		// (get) Token: 0x06020C6F RID: 134255 RVA: 0x0048EAB8 File Offset: 0x0048CCB8
		public IConnectorPathAdvanceVasePlantVisual? VisualConfig
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IConnectorPathAdvanceVasePlantVisual?(default(IConnectorPathAdvanceVasePlantVisual).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06020C70 RID: 134256 RVA: 0x0048EB18 File Offset: 0x0048CD18
		public IDynamicEntityMatch? KeepConditions(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IDynamicEntityMatch?(default(IDynamicEntityMatch).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009486 RID: 38022
		// (get) Token: 0x06020C71 RID: 134257 RVA: 0x0048EB7C File Offset: 0x0048CD7C
		public int KeepConditionsLength
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

		// Token: 0x17009487 RID: 38023
		// (get) Token: 0x06020C72 RID: 134258 RVA: 0x0048EBA8 File Offset: 0x0048CDA8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020C73 RID: 134259 RVA: 0x0048EBE8 File Offset: 0x0048CDE8
		public static Offset<IConnectorPathAdvanceInitiator> CreateIConnectorPathAdvanceInitiator(FlatBufferBuilder builder, StringOffset ActiveStateOffset = default(StringOffset), VectorOffset PathsOffset = default(VectorOffset), int TargetEntity = 0, float AdvanceSpeed = 0f, EConnectorPathAdvanceVisualType VisualType = EConnectorPathAdvanceVisualType.VasePlant, Offset<IConnectorPathAdvanceVasePlantVisual> VisualConfigOffset = default(Offset<IConnectorPathAdvanceVasePlantVisual>), VectorOffset KeepConditionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(8);
			IConnectorPathAdvanceInitiator.AddKeepConditions(builder, KeepConditionsOffset);
			IConnectorPathAdvanceInitiator.AddVisualConfig(builder, VisualConfigOffset);
			IConnectorPathAdvanceInitiator.AddAdvanceSpeed(builder, AdvanceSpeed);
			IConnectorPathAdvanceInitiator.AddTargetEntity(builder, TargetEntity);
			IConnectorPathAdvanceInitiator.AddPaths(builder, PathsOffset);
			IConnectorPathAdvanceInitiator.AddActiveState(builder, ActiveStateOffset);
			IConnectorPathAdvanceInitiator.AddNullMask(builder, NullMask);
			IConnectorPathAdvanceInitiator.AddVisualType(builder, VisualType);
			return IConnectorPathAdvanceInitiator.EndIConnectorPathAdvanceInitiator(builder);
		}

		// Token: 0x06020C74 RID: 134260 RVA: 0x0048EC3F File Offset: 0x0048CE3F
		public static void StartIConnectorPathAdvanceInitiator(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06020C75 RID: 134261 RVA: 0x0048EC48 File Offset: 0x0048CE48
		public static void AddActiveState(FlatBufferBuilder builder, StringOffset activeStateOffset)
		{
			builder.AddOffset(0, activeStateOffset.Value, 0);
		}

		// Token: 0x06020C76 RID: 134262 RVA: 0x0048EC58 File Offset: 0x0048CE58
		public static void AddPaths(FlatBufferBuilder builder, VectorOffset pathsOffset)
		{
			builder.AddOffset(1, pathsOffset.Value, 0);
		}

		// Token: 0x06020C77 RID: 134263 RVA: 0x0048EC68 File Offset: 0x0048CE68
		public static VectorOffset CreatePathsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06020C78 RID: 134264 RVA: 0x0048EC9F File Offset: 0x0048CE9F
		public static VectorOffset CreatePathsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06020C79 RID: 134265 RVA: 0x0048ECB9 File Offset: 0x0048CEB9
		public static VectorOffset CreatePathsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06020C7A RID: 134266 RVA: 0x0048ECD7 File Offset: 0x0048CED7
		public static VectorOffset CreatePathsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020C7B RID: 134267 RVA: 0x0048ECF0 File Offset: 0x0048CEF0
		public static void StartPathsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020C7C RID: 134268 RVA: 0x0048ECFB File Offset: 0x0048CEFB
		public static void AddTargetEntity(FlatBufferBuilder builder, int targetEntity)
		{
			builder.AddInt(2, targetEntity, 0);
		}

		// Token: 0x06020C7D RID: 134269 RVA: 0x0048ED06 File Offset: 0x0048CF06
		public static void AddAdvanceSpeed(FlatBufferBuilder builder, float advanceSpeed)
		{
			builder.AddFloat(3, advanceSpeed, 0.0);
		}

		// Token: 0x06020C7E RID: 134270 RVA: 0x0048ED19 File Offset: 0x0048CF19
		public static void AddVisualType(FlatBufferBuilder builder, EConnectorPathAdvanceVisualType visualType)
		{
			builder.AddByte(4, (byte)visualType, 0);
		}

		// Token: 0x06020C7F RID: 134271 RVA: 0x0048ED24 File Offset: 0x0048CF24
		public static void AddVisualConfig(FlatBufferBuilder builder, Offset<IConnectorPathAdvanceVasePlantVisual> visualConfigOffset)
		{
			builder.AddOffset(5, visualConfigOffset.Value, 0);
		}

		// Token: 0x06020C80 RID: 134272 RVA: 0x0048ED34 File Offset: 0x0048CF34
		public static void AddKeepConditions(FlatBufferBuilder builder, VectorOffset keepConditionsOffset)
		{
			builder.AddOffset(6, keepConditionsOffset.Value, 0);
		}

		// Token: 0x06020C81 RID: 134273 RVA: 0x0048ED44 File Offset: 0x0048CF44
		public static VectorOffset CreateKeepConditionsVector(FlatBufferBuilder builder, Offset<IDynamicEntityMatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06020C82 RID: 134274 RVA: 0x0048ED84 File Offset: 0x0048CF84
		public static VectorOffset CreateKeepConditionsVectorBlock(FlatBufferBuilder builder, Offset<IDynamicEntityMatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDynamicEntityMatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020C83 RID: 134275 RVA: 0x0048ED9E File Offset: 0x0048CF9E
		public static VectorOffset CreateKeepConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDynamicEntityMatch>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDynamicEntityMatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020C84 RID: 134276 RVA: 0x0048EDBC File Offset: 0x0048CFBC
		public static VectorOffset CreateKeepConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDynamicEntityMatch>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020C85 RID: 134277 RVA: 0x0048EDD5 File Offset: 0x0048CFD5
		public static void StartKeepConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020C86 RID: 134278 RVA: 0x0048EDE0 File Offset: 0x0048CFE0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06020C87 RID: 134279 RVA: 0x0048EDEB File Offset: 0x0048CFEB
		public static Offset<IConnectorPathAdvanceInitiator> EndIConnectorPathAdvanceInitiator(FlatBufferBuilder builder)
		{
			return new Offset<IConnectorPathAdvanceInitiator>(builder.EndTable());
		}

		// Token: 0x06020C88 RID: 134280 RVA: 0x0048EDF8 File Offset: 0x0048CFF8
		public IConnectorPathAdvanceInitiatorT UnPack()
		{
			IConnectorPathAdvanceInitiatorT connectorPathAdvanceInitiatorT = new IConnectorPathAdvanceInitiatorT();
			this.UnPackTo(connectorPathAdvanceInitiatorT);
			return connectorPathAdvanceInitiatorT;
		}

		// Token: 0x06020C89 RID: 134281 RVA: 0x0048EE14 File Offset: 0x0048D014
		public void UnPackTo(IConnectorPathAdvanceInitiatorT _o)
		{
			_o.ActiveState = this.ActiveState;
			_o.Paths = new List<int>();
			for (int i = 0; i < this.PathsLength; i++)
			{
				_o.Paths.Add(this.Paths(i));
			}
			_o.TargetEntity = this.TargetEntity;
			_o.AdvanceSpeed = this.AdvanceSpeed;
			_o.VisualType = this.VisualType;
			_o.VisualConfig = ((this.VisualConfig != null) ? this.VisualConfig.Value.UnPack() : null);
			_o.KeepConditions = new List<IDynamicEntityMatchT>();
			for (int j = 0; j < this.KeepConditionsLength; j++)
			{
				_o.KeepConditions.Add((this.KeepConditions(j) != null) ? this.KeepConditions(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06020C8A RID: 134282 RVA: 0x0048EF10 File Offset: 0x0048D110
		public static Offset<IConnectorPathAdvanceInitiator> Pack(FlatBufferBuilder builder, IConnectorPathAdvanceInitiatorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConnectorPathAdvanceInitiator>);
			}
			StringOffset activeStateOffset = (_o.ActiveState == null) ? default(StringOffset) : builder.CreateString(_o.ActiveState);
			VectorOffset pathsOffset = default(VectorOffset);
			if (_o.Paths != null)
			{
				int[] data = _o.Paths.ToArray();
				pathsOffset = IConnectorPathAdvanceInitiator.CreatePathsVector(builder, data);
			}
			Offset<IConnectorPathAdvanceVasePlantVisual> visualConfigOffset = (_o.VisualConfig == null) ? default(Offset<IConnectorPathAdvanceVasePlantVisual>) : IConnectorPathAdvanceVasePlantVisual.Pack(builder, _o.VisualConfig);
			VectorOffset keepConditionsOffset = default(VectorOffset);
			if (_o.KeepConditions != null)
			{
				Offset<IDynamicEntityMatch>[] array = new Offset<IDynamicEntityMatch>[_o.KeepConditions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IDynamicEntityMatch.Pack(builder, _o.KeepConditions[i]);
				}
				keepConditionsOffset = IConnectorPathAdvanceInitiator.CreateKeepConditionsVector(builder, array);
			}
			return IConnectorPathAdvanceInitiator.CreateIConnectorPathAdvanceInitiator(builder, activeStateOffset, pathsOffset, _o.TargetEntity, _o.AdvanceSpeed, _o.VisualType, visualConfigOffset, keepConditionsOffset, _o.NullMask);
		}

		// Token: 0x0400DFD2 RID: 57298
		private Table __p;
	}
}
