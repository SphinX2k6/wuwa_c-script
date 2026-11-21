using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BA3 RID: 23459
	public struct INoiseRemovalComponent : IFlatbufferObject
	{
		// Token: 0x1700AB76 RID: 43894
		// (get) Token: 0x06026AA9 RID: 158377 RVA: 0x0054B292 File Offset: 0x00549492
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026AAA RID: 158378 RVA: 0x0054B29F File Offset: 0x0054949F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026AAB RID: 158379 RVA: 0x0054B2A8 File Offset: 0x005494A8
		public static INoiseRemovalComponent GetRootAsINoiseRemovalComponent(ByteBuffer _bb)
		{
			return INoiseRemovalComponent.GetRootAsINoiseRemovalComponent(_bb, default(INoiseRemovalComponent));
		}

		// Token: 0x06026AAC RID: 158380 RVA: 0x0054B2C4 File Offset: 0x005494C4
		public static INoiseRemovalComponent GetRootAsINoiseRemovalComponent(ByteBuffer _bb, INoiseRemovalComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026AAD RID: 158381 RVA: 0x0054B2E1 File Offset: 0x005494E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026AAE RID: 158382 RVA: 0x0054B2F0 File Offset: 0x005494F0
		public INoiseRemovalComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AB77 RID: 43895
		// (get) Token: 0x06026AAF RID: 158383 RVA: 0x0054B300 File Offset: 0x00549500
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06026AB0 RID: 158384 RVA: 0x0054B340 File Offset: 0x00549540
		public INoiseRemovalNode? Nodes(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new INoiseRemovalNode?(default(INoiseRemovalNode).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AB78 RID: 43896
		// (get) Token: 0x06026AB1 RID: 158385 RVA: 0x0054B3A0 File Offset: 0x005495A0
		public int NodesLength
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

		// Token: 0x1700AB79 RID: 43897
		// (get) Token: 0x06026AB2 RID: 158386 RVA: 0x0054B3CC File Offset: 0x005495CC
		public string CompleteState
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026AB3 RID: 158387 RVA: 0x0054B403 File Offset: 0x00549603
		public Span<byte> GetCompleteStateBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06026AB4 RID: 158388 RVA: 0x0054B412 File Offset: 0x00549612
		public byte[] GetCompleteStateArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700AB7A RID: 43898
		// (get) Token: 0x06026AB5 RID: 158389 RVA: 0x0054B420 File Offset: 0x00549620
		public TNoiseRemovalBoarder NoiseRemovalBoarderType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TNoiseRemovalBoarder.NONE;
				}
				return (TNoiseRemovalBoarder)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026AB6 RID: 158390 RVA: 0x0054B460 File Offset: 0x00549660
		public TTable? NoiseRemovalBoarder<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06026AB7 RID: 158391 RVA: 0x0054B4A8 File Offset: 0x005496A8
		public INoiseRemovalBoxBoarder NoiseRemovalBoarderAsINoiseRemovalBoxBoarder()
		{
			return this.NoiseRemovalBoarder<INoiseRemovalBoxBoarder>().Value;
		}

		// Token: 0x06026AB8 RID: 158392 RVA: 0x0054B4C4 File Offset: 0x005496C4
		public INoiseRemovalSphereBoarder NoiseRemovalBoarderAsINoiseRemovalSphereBoarder()
		{
			return this.NoiseRemovalBoarder<INoiseRemovalSphereBoarder>().Value;
		}

		// Token: 0x1700AB7B RID: 43899
		// (get) Token: 0x06026AB9 RID: 158393 RVA: 0x0054B4E0 File Offset: 0x005496E0
		public int RotationAngle
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AB7C RID: 43900
		// (get) Token: 0x06026ABA RID: 158394 RVA: 0x0054B520 File Offset: 0x00549720
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026ABB RID: 158395 RVA: 0x0054B560 File Offset: 0x00549760
		public static Offset<INoiseRemovalComponent> CreateINoiseRemovalComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset NodesOffset = default(VectorOffset), StringOffset CompleteStateOffset = default(StringOffset), TNoiseRemovalBoarder NoiseRemovalBoarder_type = TNoiseRemovalBoarder.NONE, int NoiseRemovalBoarderOffset = 0, int RotationAngle = 0, byte NullMask = 0)
		{
			builder.StartTable(7);
			INoiseRemovalComponent.AddRotationAngle(builder, RotationAngle);
			INoiseRemovalComponent.AddNoiseRemovalBoarder(builder, NoiseRemovalBoarderOffset);
			INoiseRemovalComponent.AddCompleteState(builder, CompleteStateOffset);
			INoiseRemovalComponent.AddNodes(builder, NodesOffset);
			INoiseRemovalComponent.AddNullMask(builder, NullMask);
			INoiseRemovalComponent.AddNoiseRemovalBoarderType(builder, NoiseRemovalBoarder_type);
			INoiseRemovalComponent.AddDisabled(builder, Disabled);
			return INoiseRemovalComponent.EndINoiseRemovalComponent(builder);
		}

		// Token: 0x06026ABC RID: 158396 RVA: 0x0054B5AF File Offset: 0x005497AF
		public static void StartINoiseRemovalComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06026ABD RID: 158397 RVA: 0x0054B5B8 File Offset: 0x005497B8
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06026ABE RID: 158398 RVA: 0x0054B5C3 File Offset: 0x005497C3
		public static void AddNodes(FlatBufferBuilder builder, VectorOffset nodesOffset)
		{
			builder.AddOffset(1, nodesOffset.Value, 0);
		}

		// Token: 0x06026ABF RID: 158399 RVA: 0x0054B5D4 File Offset: 0x005497D4
		public static VectorOffset CreateNodesVector(FlatBufferBuilder builder, Offset<INoiseRemovalNode>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026AC0 RID: 158400 RVA: 0x0054B614 File Offset: 0x00549814
		public static VectorOffset CreateNodesVectorBlock(FlatBufferBuilder builder, Offset<INoiseRemovalNode>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<INoiseRemovalNode>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026AC1 RID: 158401 RVA: 0x0054B62E File Offset: 0x0054982E
		public static VectorOffset CreateNodesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<INoiseRemovalNode>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<INoiseRemovalNode>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026AC2 RID: 158402 RVA: 0x0054B64C File Offset: 0x0054984C
		public static VectorOffset CreateNodesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<INoiseRemovalNode>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026AC3 RID: 158403 RVA: 0x0054B665 File Offset: 0x00549865
		public static void StartNodesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026AC4 RID: 158404 RVA: 0x0054B670 File Offset: 0x00549870
		public static void AddCompleteState(FlatBufferBuilder builder, StringOffset completeStateOffset)
		{
			builder.AddOffset(2, completeStateOffset.Value, 0);
		}

		// Token: 0x06026AC5 RID: 158405 RVA: 0x0054B680 File Offset: 0x00549880
		public static void AddNoiseRemovalBoarderType(FlatBufferBuilder builder, TNoiseRemovalBoarder noiseRemovalBoarderType)
		{
			builder.AddByte(3, (byte)noiseRemovalBoarderType, 0);
		}

		// Token: 0x06026AC6 RID: 158406 RVA: 0x0054B68B File Offset: 0x0054988B
		public static void AddNoiseRemovalBoarder(FlatBufferBuilder builder, int noiseRemovalBoarderOffset)
		{
			builder.AddOffset(4, noiseRemovalBoarderOffset, 0);
		}

		// Token: 0x06026AC7 RID: 158407 RVA: 0x0054B696 File Offset: 0x00549896
		public static void AddRotationAngle(FlatBufferBuilder builder, int rotationAngle)
		{
			builder.AddInt(5, rotationAngle, 0);
		}

		// Token: 0x06026AC8 RID: 158408 RVA: 0x0054B6A1 File Offset: 0x005498A1
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06026AC9 RID: 158409 RVA: 0x0054B6AC File Offset: 0x005498AC
		public static Offset<INoiseRemovalComponent> EndINoiseRemovalComponent(FlatBufferBuilder builder)
		{
			return new Offset<INoiseRemovalComponent>(builder.EndTable());
		}

		// Token: 0x06026ACA RID: 158410 RVA: 0x0054B6BC File Offset: 0x005498BC
		public INoiseRemovalComponentT UnPack()
		{
			INoiseRemovalComponentT noiseRemovalComponentT = new INoiseRemovalComponentT();
			this.UnPackTo(noiseRemovalComponentT);
			return noiseRemovalComponentT;
		}

		// Token: 0x06026ACB RID: 158411 RVA: 0x0054B6D8 File Offset: 0x005498D8
		public void UnPackTo(INoiseRemovalComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Nodes = new List<INoiseRemovalNodeT>();
			for (int i = 0; i < this.NodesLength; i++)
			{
				_o.Nodes.Add((this.Nodes(i) != null) ? this.Nodes(i).Value.UnPack() : null);
			}
			_o.CompleteState = this.CompleteState;
			_o.NoiseRemovalBoarder = new TNoiseRemovalBoarderUnion();
			_o.NoiseRemovalBoarder.Type = this.NoiseRemovalBoarderType;
			TNoiseRemovalBoarder noiseRemovalBoarderType = this.NoiseRemovalBoarderType;
			if (noiseRemovalBoarderType != TNoiseRemovalBoarder.INoiseRemovalBoxBoarder)
			{
				if (noiseRemovalBoarderType == TNoiseRemovalBoarder.INoiseRemovalSphereBoarder)
				{
					_o.NoiseRemovalBoarder.Value = ((this.NoiseRemovalBoarder<INoiseRemovalSphereBoarder>() != null) ? this.NoiseRemovalBoarder<INoiseRemovalSphereBoarder>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.NoiseRemovalBoarder.Value = ((this.NoiseRemovalBoarder<INoiseRemovalBoxBoarder>() != null) ? this.NoiseRemovalBoarder<INoiseRemovalBoxBoarder>().Value.UnPack() : null);
			}
			_o.RotationAngle = this.RotationAngle;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06026ACC RID: 158412 RVA: 0x0054B804 File Offset: 0x00549A04
		public static Offset<INoiseRemovalComponent> Pack(FlatBufferBuilder builder, INoiseRemovalComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<INoiseRemovalComponent>);
			}
			VectorOffset nodesOffset = default(VectorOffset);
			if (_o.Nodes != null)
			{
				Offset<INoiseRemovalNode>[] array = new Offset<INoiseRemovalNode>[_o.Nodes.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = INoiseRemovalNode.Pack(builder, _o.Nodes[i]);
				}
				nodesOffset = INoiseRemovalComponent.CreateNodesVector(builder, array);
			}
			StringOffset completeStateOffset = (_o.CompleteState == null) ? default(StringOffset) : builder.CreateString(_o.CompleteState);
			TNoiseRemovalBoarder noiseRemovalBoarder_type = (_o.NoiseRemovalBoarder == null) ? TNoiseRemovalBoarder.NONE : _o.NoiseRemovalBoarder.Type;
			int noiseRemovalBoarderOffset = (_o.NoiseRemovalBoarder == null) ? 0 : TNoiseRemovalBoarderUnion.Pack(builder, _o.NoiseRemovalBoarder);
			return INoiseRemovalComponent.CreateINoiseRemovalComponent(builder, _o.Disabled, nodesOffset, completeStateOffset, noiseRemovalBoarder_type, noiseRemovalBoarderOffset, _o.RotationAngle, _o.NullMask);
		}

		// Token: 0x0400F5E4 RID: 62948
		private Table __p;
	}
}
