using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200556B RID: 21867
	public struct IConnectorPathAdvanceInitiator : IFlatbufferObject
	{
		// Token: 0x17009C60 RID: 40032
		// (get) Token: 0x06022B7F RID: 142207 RVA: 0x004C8300 File Offset: 0x004C6500
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022B80 RID: 142208 RVA: 0x004C830D File Offset: 0x004C650D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022B81 RID: 142209 RVA: 0x004C8314 File Offset: 0x004C6514
		public static IConnectorPathAdvanceInitiator GetRootAsIConnectorPathAdvanceInitiator(ByteBuffer _bb)
		{
			return IConnectorPathAdvanceInitiator.GetRootAsIConnectorPathAdvanceInitiator(_bb, default(IConnectorPathAdvanceInitiator));
		}

		// Token: 0x06022B82 RID: 142210 RVA: 0x004C8330 File Offset: 0x004C6530
		public static IConnectorPathAdvanceInitiator GetRootAsIConnectorPathAdvanceInitiator(ByteBuffer _bb, IConnectorPathAdvanceInitiator obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022B83 RID: 142211 RVA: 0x004C834D File Offset: 0x004C654D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022B84 RID: 142212 RVA: 0x004C835C File Offset: 0x004C655C
		public IConnectorPathAdvanceInitiator __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009C61 RID: 40033
		// (get) Token: 0x06022B85 RID: 142213 RVA: 0x004C836C File Offset: 0x004C656C
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

		// Token: 0x06022B86 RID: 142214 RVA: 0x004C83A3 File Offset: 0x004C65A3
		public Span<byte> GetActiveStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06022B87 RID: 142215 RVA: 0x004C83B2 File Offset: 0x004C65B2
		public byte[] GetActiveStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06022B88 RID: 142216 RVA: 0x004C83C0 File Offset: 0x004C65C0
		public int Paths(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009C62 RID: 40034
		// (get) Token: 0x06022B89 RID: 142217 RVA: 0x004C8400 File Offset: 0x004C6600
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

		// Token: 0x06022B8A RID: 142218 RVA: 0x004C842B File Offset: 0x004C662B
		public Span<int> GetPathsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06022B8B RID: 142219 RVA: 0x004C843A File Offset: 0x004C663A
		public int[] GetPathsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x17009C63 RID: 40035
		// (get) Token: 0x06022B8C RID: 142220 RVA: 0x004C8448 File Offset: 0x004C6648
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

		// Token: 0x17009C64 RID: 40036
		// (get) Token: 0x06022B8D RID: 142221 RVA: 0x004C8484 File Offset: 0x004C6684
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

		// Token: 0x17009C65 RID: 40037
		// (get) Token: 0x06022B8E RID: 142222 RVA: 0x004C84C8 File Offset: 0x004C66C8
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

		// Token: 0x17009C66 RID: 40038
		// (get) Token: 0x06022B8F RID: 142223 RVA: 0x004C8508 File Offset: 0x004C6708
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

		// Token: 0x06022B90 RID: 142224 RVA: 0x004C8568 File Offset: 0x004C6768
		public IDynamicEntityMatch? KeepConditions(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IDynamicEntityMatch?(default(IDynamicEntityMatch).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009C67 RID: 40039
		// (get) Token: 0x06022B91 RID: 142225 RVA: 0x004C85CC File Offset: 0x004C67CC
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

		// Token: 0x17009C68 RID: 40040
		// (get) Token: 0x06022B92 RID: 142226 RVA: 0x004C85F8 File Offset: 0x004C67F8
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

		// Token: 0x06022B93 RID: 142227 RVA: 0x004C8638 File Offset: 0x004C6838
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

		// Token: 0x06022B94 RID: 142228 RVA: 0x004C868F File Offset: 0x004C688F
		public static void StartIConnectorPathAdvanceInitiator(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06022B95 RID: 142229 RVA: 0x004C8698 File Offset: 0x004C6898
		public static void AddActiveState(FlatBufferBuilder builder, StringOffset activeStateOffset)
		{
			builder.AddOffset(0, activeStateOffset.Value, 0);
		}

		// Token: 0x06022B96 RID: 142230 RVA: 0x004C86A8 File Offset: 0x004C68A8
		public static void AddPaths(FlatBufferBuilder builder, VectorOffset pathsOffset)
		{
			builder.AddOffset(1, pathsOffset.Value, 0);
		}

		// Token: 0x06022B97 RID: 142231 RVA: 0x004C86B8 File Offset: 0x004C68B8
		public static VectorOffset CreatePathsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06022B98 RID: 142232 RVA: 0x004C86EF File Offset: 0x004C68EF
		public static VectorOffset CreatePathsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06022B99 RID: 142233 RVA: 0x004C8709 File Offset: 0x004C6909
		public static VectorOffset CreatePathsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06022B9A RID: 142234 RVA: 0x004C8727 File Offset: 0x004C6927
		public static VectorOffset CreatePathsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022B9B RID: 142235 RVA: 0x004C8740 File Offset: 0x004C6940
		public static void StartPathsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022B9C RID: 142236 RVA: 0x004C874B File Offset: 0x004C694B
		public static void AddTargetEntity(FlatBufferBuilder builder, int targetEntity)
		{
			builder.AddInt(2, targetEntity, 0);
		}

		// Token: 0x06022B9D RID: 142237 RVA: 0x004C8756 File Offset: 0x004C6956
		public static void AddAdvanceSpeed(FlatBufferBuilder builder, float advanceSpeed)
		{
			builder.AddFloat(3, advanceSpeed, 0.0);
		}

		// Token: 0x06022B9E RID: 142238 RVA: 0x004C8769 File Offset: 0x004C6969
		public static void AddVisualType(FlatBufferBuilder builder, EConnectorPathAdvanceVisualType visualType)
		{
			builder.AddByte(4, (byte)visualType, 0);
		}

		// Token: 0x06022B9F RID: 142239 RVA: 0x004C8774 File Offset: 0x004C6974
		public static void AddVisualConfig(FlatBufferBuilder builder, Offset<IConnectorPathAdvanceVasePlantVisual> visualConfigOffset)
		{
			builder.AddOffset(5, visualConfigOffset.Value, 0);
		}

		// Token: 0x06022BA0 RID: 142240 RVA: 0x004C8784 File Offset: 0x004C6984
		public static void AddKeepConditions(FlatBufferBuilder builder, VectorOffset keepConditionsOffset)
		{
			builder.AddOffset(6, keepConditionsOffset.Value, 0);
		}

		// Token: 0x06022BA1 RID: 142241 RVA: 0x004C8794 File Offset: 0x004C6994
		public static VectorOffset CreateKeepConditionsVector(FlatBufferBuilder builder, Offset<IDynamicEntityMatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022BA2 RID: 142242 RVA: 0x004C87D4 File Offset: 0x004C69D4
		public static VectorOffset CreateKeepConditionsVectorBlock(FlatBufferBuilder builder, Offset<IDynamicEntityMatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDynamicEntityMatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022BA3 RID: 142243 RVA: 0x004C87EE File Offset: 0x004C69EE
		public static VectorOffset CreateKeepConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDynamicEntityMatch>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDynamicEntityMatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022BA4 RID: 142244 RVA: 0x004C880C File Offset: 0x004C6A0C
		public static VectorOffset CreateKeepConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDynamicEntityMatch>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022BA5 RID: 142245 RVA: 0x004C8825 File Offset: 0x004C6A25
		public static void StartKeepConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022BA6 RID: 142246 RVA: 0x004C8830 File Offset: 0x004C6A30
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06022BA7 RID: 142247 RVA: 0x004C883B File Offset: 0x004C6A3B
		public static Offset<IConnectorPathAdvanceInitiator> EndIConnectorPathAdvanceInitiator(FlatBufferBuilder builder)
		{
			return new Offset<IConnectorPathAdvanceInitiator>(builder.EndTable());
		}

		// Token: 0x06022BA8 RID: 142248 RVA: 0x004C8848 File Offset: 0x004C6A48
		public IConnectorPathAdvanceInitiatorT UnPack()
		{
			IConnectorPathAdvanceInitiatorT connectorPathAdvanceInitiatorT = new IConnectorPathAdvanceInitiatorT();
			this.UnPackTo(connectorPathAdvanceInitiatorT);
			return connectorPathAdvanceInitiatorT;
		}

		// Token: 0x06022BA9 RID: 142249 RVA: 0x004C8864 File Offset: 0x004C6A64
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

		// Token: 0x06022BAA RID: 142250 RVA: 0x004C8960 File Offset: 0x004C6B60
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

		// Token: 0x0400EBC8 RID: 60360
		private Table __p;
	}
}
