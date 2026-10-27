using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005605 RID: 22021
	public struct INoiseRemovalComponent : IFlatbufferObject
	{
		// Token: 0x1700A2EE RID: 41710
		// (get) Token: 0x06024899 RID: 149657 RVA: 0x0050AC7A File Offset: 0x00508E7A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602489A RID: 149658 RVA: 0x0050AC87 File Offset: 0x00508E87
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602489B RID: 149659 RVA: 0x0050AC90 File Offset: 0x00508E90
		public static INoiseRemovalComponent GetRootAsINoiseRemovalComponent(ByteBuffer _bb)
		{
			return INoiseRemovalComponent.GetRootAsINoiseRemovalComponent(_bb, default(INoiseRemovalComponent));
		}

		// Token: 0x0602489C RID: 149660 RVA: 0x0050ACAC File Offset: 0x00508EAC
		public static INoiseRemovalComponent GetRootAsINoiseRemovalComponent(ByteBuffer _bb, INoiseRemovalComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602489D RID: 149661 RVA: 0x0050ACC9 File Offset: 0x00508EC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602489E RID: 149662 RVA: 0x0050ACD8 File Offset: 0x00508ED8
		public INoiseRemovalComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A2EF RID: 41711
		// (get) Token: 0x0602489F RID: 149663 RVA: 0x0050ACE8 File Offset: 0x00508EE8
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060248A0 RID: 149664 RVA: 0x0050AD28 File Offset: 0x00508F28
		public INoiseRemovalNode? Nodes(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new INoiseRemovalNode?(default(INoiseRemovalNode).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A2F0 RID: 41712
		// (get) Token: 0x060248A1 RID: 149665 RVA: 0x0050AD88 File Offset: 0x00508F88
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

		// Token: 0x1700A2F1 RID: 41713
		// (get) Token: 0x060248A2 RID: 149666 RVA: 0x0050ADB4 File Offset: 0x00508FB4
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

		// Token: 0x060248A3 RID: 149667 RVA: 0x0050ADEB File Offset: 0x00508FEB
		public Span<byte> GetCompleteStateBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060248A4 RID: 149668 RVA: 0x0050ADFA File Offset: 0x00508FFA
		public byte[] GetCompleteStateArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700A2F2 RID: 41714
		// (get) Token: 0x060248A5 RID: 149669 RVA: 0x0050AE08 File Offset: 0x00509008
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

		// Token: 0x060248A6 RID: 149670 RVA: 0x0050AE48 File Offset: 0x00509048
		public TTable? NoiseRemovalBoarder<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060248A7 RID: 149671 RVA: 0x0050AE90 File Offset: 0x00509090
		public INoiseRemovalBoxBoarder NoiseRemovalBoarderAsINoiseRemovalBoxBoarder()
		{
			return this.NoiseRemovalBoarder<INoiseRemovalBoxBoarder>().Value;
		}

		// Token: 0x060248A8 RID: 149672 RVA: 0x0050AEAC File Offset: 0x005090AC
		public INoiseRemovalSphereBoarder NoiseRemovalBoarderAsINoiseRemovalSphereBoarder()
		{
			return this.NoiseRemovalBoarder<INoiseRemovalSphereBoarder>().Value;
		}

		// Token: 0x1700A2F3 RID: 41715
		// (get) Token: 0x060248A9 RID: 149673 RVA: 0x0050AEC8 File Offset: 0x005090C8
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

		// Token: 0x1700A2F4 RID: 41716
		// (get) Token: 0x060248AA RID: 149674 RVA: 0x0050AF08 File Offset: 0x00509108
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

		// Token: 0x060248AB RID: 149675 RVA: 0x0050AF48 File Offset: 0x00509148
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

		// Token: 0x060248AC RID: 149676 RVA: 0x0050AF97 File Offset: 0x00509197
		public static void StartINoiseRemovalComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x060248AD RID: 149677 RVA: 0x0050AFA0 File Offset: 0x005091A0
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060248AE RID: 149678 RVA: 0x0050AFAB File Offset: 0x005091AB
		public static void AddNodes(FlatBufferBuilder builder, VectorOffset nodesOffset)
		{
			builder.AddOffset(1, nodesOffset.Value, 0);
		}

		// Token: 0x060248AF RID: 149679 RVA: 0x0050AFBC File Offset: 0x005091BC
		public static VectorOffset CreateNodesVector(FlatBufferBuilder builder, Offset<INoiseRemovalNode>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060248B0 RID: 149680 RVA: 0x0050AFFC File Offset: 0x005091FC
		public static VectorOffset CreateNodesVectorBlock(FlatBufferBuilder builder, Offset<INoiseRemovalNode>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<INoiseRemovalNode>>(data);
			return builder.EndVector();
		}

		// Token: 0x060248B1 RID: 149681 RVA: 0x0050B016 File Offset: 0x00509216
		public static VectorOffset CreateNodesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<INoiseRemovalNode>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<INoiseRemovalNode>>(data);
			return builder.EndVector();
		}

		// Token: 0x060248B2 RID: 149682 RVA: 0x0050B034 File Offset: 0x00509234
		public static VectorOffset CreateNodesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<INoiseRemovalNode>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060248B3 RID: 149683 RVA: 0x0050B04D File Offset: 0x0050924D
		public static void StartNodesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060248B4 RID: 149684 RVA: 0x0050B058 File Offset: 0x00509258
		public static void AddCompleteState(FlatBufferBuilder builder, StringOffset completeStateOffset)
		{
			builder.AddOffset(2, completeStateOffset.Value, 0);
		}

		// Token: 0x060248B5 RID: 149685 RVA: 0x0050B068 File Offset: 0x00509268
		public static void AddNoiseRemovalBoarderType(FlatBufferBuilder builder, TNoiseRemovalBoarder noiseRemovalBoarderType)
		{
			builder.AddByte(3, (byte)noiseRemovalBoarderType, 0);
		}

		// Token: 0x060248B6 RID: 149686 RVA: 0x0050B073 File Offset: 0x00509273
		public static void AddNoiseRemovalBoarder(FlatBufferBuilder builder, int noiseRemovalBoarderOffset)
		{
			builder.AddOffset(4, noiseRemovalBoarderOffset, 0);
		}

		// Token: 0x060248B7 RID: 149687 RVA: 0x0050B07E File Offset: 0x0050927E
		public static void AddRotationAngle(FlatBufferBuilder builder, int rotationAngle)
		{
			builder.AddInt(5, rotationAngle, 0);
		}

		// Token: 0x060248B8 RID: 149688 RVA: 0x0050B089 File Offset: 0x00509289
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x060248B9 RID: 149689 RVA: 0x0050B094 File Offset: 0x00509294
		public static Offset<INoiseRemovalComponent> EndINoiseRemovalComponent(FlatBufferBuilder builder)
		{
			return new Offset<INoiseRemovalComponent>(builder.EndTable());
		}

		// Token: 0x060248BA RID: 149690 RVA: 0x0050B0A4 File Offset: 0x005092A4
		public INoiseRemovalComponentT UnPack()
		{
			INoiseRemovalComponentT noiseRemovalComponentT = new INoiseRemovalComponentT();
			this.UnPackTo(noiseRemovalComponentT);
			return noiseRemovalComponentT;
		}

		// Token: 0x060248BB RID: 149691 RVA: 0x0050B0C0 File Offset: 0x005092C0
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

		// Token: 0x060248BC RID: 149692 RVA: 0x0050B1EC File Offset: 0x005093EC
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

		// Token: 0x0400E981 RID: 59777
		private Table __p;
	}
}
