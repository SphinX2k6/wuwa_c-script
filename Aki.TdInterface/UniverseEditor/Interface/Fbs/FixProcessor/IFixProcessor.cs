using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x02004757 RID: 18263
	public struct IFixProcessor : IFlatbufferObject
	{
		// Token: 0x17008305 RID: 33541
		// (get) Token: 0x0601C1B7 RID: 115127 RVA: 0x003FB7F0 File Offset: 0x003F99F0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C1B8 RID: 115128 RVA: 0x003FB7FD File Offset: 0x003F99FD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C1B9 RID: 115129 RVA: 0x003FB804 File Offset: 0x003F9A04
		public static IFixProcessor GetRootAsIFixProcessor(ByteBuffer _bb)
		{
			return IFixProcessor.GetRootAsIFixProcessor(_bb, default(IFixProcessor));
		}

		// Token: 0x0601C1BA RID: 115130 RVA: 0x003FB820 File Offset: 0x003F9A20
		public static IFixProcessor GetRootAsIFixProcessor(ByteBuffer _bb, IFixProcessor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C1BB RID: 115131 RVA: 0x003FB83D File Offset: 0x003F9A3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C1BC RID: 115132 RVA: 0x003FB84C File Offset: 0x003F9A4C
		public IFixProcessor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601C1BD RID: 115133 RVA: 0x003FB85C File Offset: 0x003F9A5C
		public IFixAction? FixActions(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IFixAction?(default(IFixAction).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008306 RID: 33542
		// (get) Token: 0x0601C1BE RID: 115134 RVA: 0x003FB8BC File Offset: 0x003F9ABC
		public int FixActionsLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601C1BF RID: 115135 RVA: 0x003FB8E7 File Offset: 0x003F9AE7
		public static Offset<IFixProcessor> CreateIFixProcessor(FlatBufferBuilder builder, VectorOffset FixActionsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IFixProcessor.AddFixActions(builder, FixActionsOffset);
			return IFixProcessor.EndIFixProcessor(builder);
		}

		// Token: 0x0601C1C0 RID: 115136 RVA: 0x003FB8FD File Offset: 0x003F9AFD
		public static void StartIFixProcessor(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601C1C1 RID: 115137 RVA: 0x003FB906 File Offset: 0x003F9B06
		public static void AddFixActions(FlatBufferBuilder builder, VectorOffset fixActionsOffset)
		{
			builder.AddOffset(0, fixActionsOffset.Value, 0);
		}

		// Token: 0x0601C1C2 RID: 115138 RVA: 0x003FB918 File Offset: 0x003F9B18
		public static VectorOffset CreateFixActionsVector(FlatBufferBuilder builder, Offset<IFixAction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C1C3 RID: 115139 RVA: 0x003FB958 File Offset: 0x003F9B58
		public static VectorOffset CreateFixActionsVectorBlock(FlatBufferBuilder builder, Offset<IFixAction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IFixAction>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C1C4 RID: 115140 RVA: 0x003FB972 File Offset: 0x003F9B72
		public static VectorOffset CreateFixActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IFixAction>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IFixAction>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C1C5 RID: 115141 RVA: 0x003FB990 File Offset: 0x003F9B90
		public static VectorOffset CreateFixActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IFixAction>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C1C6 RID: 115142 RVA: 0x003FB9A9 File Offset: 0x003F9BA9
		public static void StartFixActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C1C7 RID: 115143 RVA: 0x003FB9B4 File Offset: 0x003F9BB4
		public static Offset<IFixProcessor> EndIFixProcessor(FlatBufferBuilder builder)
		{
			return new Offset<IFixProcessor>(builder.EndTable());
		}

		// Token: 0x0601C1C8 RID: 115144 RVA: 0x003FB9C4 File Offset: 0x003F9BC4
		public IFixProcessorT UnPack()
		{
			IFixProcessorT fixProcessorT = new IFixProcessorT();
			this.UnPackTo(fixProcessorT);
			return fixProcessorT;
		}

		// Token: 0x0601C1C9 RID: 115145 RVA: 0x003FB9E0 File Offset: 0x003F9BE0
		public void UnPackTo(IFixProcessorT _o)
		{
			_o.FixActions = new List<IFixActionT>();
			for (int i = 0; i < this.FixActionsLength; i++)
			{
				_o.FixActions.Add((this.FixActions(i) != null) ? this.FixActions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601C1CA RID: 115146 RVA: 0x003FBA40 File Offset: 0x003F9C40
		public static Offset<IFixProcessor> Pack(FlatBufferBuilder builder, IFixProcessorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFixProcessor>);
			}
			VectorOffset fixActionsOffset = default(VectorOffset);
			if (_o.FixActions != null)
			{
				Offset<IFixAction>[] array = new Offset<IFixAction>[_o.FixActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IFixAction.Pack(builder, _o.FixActions[i]);
				}
				fixActionsOffset = IFixProcessor.CreateFixActionsVector(builder, array);
			}
			return IFixProcessor.CreateIFixProcessor(builder, fixActionsOffset);
		}

		// Token: 0x0400CA55 RID: 51797
		private Table __p;
	}
}
