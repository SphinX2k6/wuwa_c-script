using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053E6 RID: 21478
	public struct IIgnoresCollisionCfg : IFlatbufferObject
	{
		// Token: 0x17009E17 RID: 40471
		// (get) Token: 0x06023447 RID: 144455 RVA: 0x004E230E File Offset: 0x004E050E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023448 RID: 144456 RVA: 0x004E231B File Offset: 0x004E051B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023449 RID: 144457 RVA: 0x004E2324 File Offset: 0x004E0524
		public static IIgnoresCollisionCfg GetRootAsIIgnoresCollisionCfg(ByteBuffer _bb)
		{
			return IIgnoresCollisionCfg.GetRootAsIIgnoresCollisionCfg(_bb, default(IIgnoresCollisionCfg));
		}

		// Token: 0x0602344A RID: 144458 RVA: 0x004E2340 File Offset: 0x004E0540
		public static IIgnoresCollisionCfg GetRootAsIIgnoresCollisionCfg(ByteBuffer _bb, IIgnoresCollisionCfg obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602344B RID: 144459 RVA: 0x004E235D File Offset: 0x004E055D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602344C RID: 144460 RVA: 0x004E236C File Offset: 0x004E056C
		public IIgnoresCollisionCfg __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602344D RID: 144461 RVA: 0x004E237C File Offset: 0x004E057C
		public int IgnoreEntitys(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009E18 RID: 40472
		// (get) Token: 0x0602344E RID: 144462 RVA: 0x004E23BC File Offset: 0x004E05BC
		public int IgnoreEntitysLength
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

		// Token: 0x0602344F RID: 144463 RVA: 0x004E23E7 File Offset: 0x004E05E7
		public Span<int> GetIgnoreEntitysBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x06023450 RID: 144464 RVA: 0x004E23F6 File Offset: 0x004E05F6
		public int[] GetIgnoreEntitysArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x06023451 RID: 144465 RVA: 0x004E2404 File Offset: 0x004E0604
		public IActorRef? IgnoreActors(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActorRef?(default(IActorRef).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009E19 RID: 40473
		// (get) Token: 0x06023452 RID: 144466 RVA: 0x004E2464 File Offset: 0x004E0664
		public int IgnoreActorsLength
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

		// Token: 0x06023453 RID: 144467 RVA: 0x004E248F File Offset: 0x004E068F
		public static Offset<IIgnoresCollisionCfg> CreateIIgnoresCollisionCfg(FlatBufferBuilder builder, VectorOffset IgnoreEntitysOffset = default(VectorOffset), VectorOffset IgnoreActorsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IIgnoresCollisionCfg.AddIgnoreActors(builder, IgnoreActorsOffset);
			IIgnoresCollisionCfg.AddIgnoreEntitys(builder, IgnoreEntitysOffset);
			return IIgnoresCollisionCfg.EndIIgnoresCollisionCfg(builder);
		}

		// Token: 0x06023454 RID: 144468 RVA: 0x004E24AC File Offset: 0x004E06AC
		public static void StartIIgnoresCollisionCfg(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06023455 RID: 144469 RVA: 0x004E24B5 File Offset: 0x004E06B5
		public static void AddIgnoreEntitys(FlatBufferBuilder builder, VectorOffset ignoreEntitysOffset)
		{
			builder.AddOffset(0, ignoreEntitysOffset.Value, 0);
		}

		// Token: 0x06023456 RID: 144470 RVA: 0x004E24C8 File Offset: 0x004E06C8
		public static VectorOffset CreateIgnoreEntitysVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06023457 RID: 144471 RVA: 0x004E24FF File Offset: 0x004E06FF
		public static VectorOffset CreateIgnoreEntitysVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06023458 RID: 144472 RVA: 0x004E2519 File Offset: 0x004E0719
		public static VectorOffset CreateIgnoreEntitysVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06023459 RID: 144473 RVA: 0x004E2537 File Offset: 0x004E0737
		public static VectorOffset CreateIgnoreEntitysVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602345A RID: 144474 RVA: 0x004E2550 File Offset: 0x004E0750
		public static void StartIgnoreEntitysVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602345B RID: 144475 RVA: 0x004E255B File Offset: 0x004E075B
		public static void AddIgnoreActors(FlatBufferBuilder builder, VectorOffset ignoreActorsOffset)
		{
			builder.AddOffset(1, ignoreActorsOffset.Value, 0);
		}

		// Token: 0x0602345C RID: 144476 RVA: 0x004E256C File Offset: 0x004E076C
		public static VectorOffset CreateIgnoreActorsVector(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602345D RID: 144477 RVA: 0x004E25AC File Offset: 0x004E07AC
		public static VectorOffset CreateIgnoreActorsVectorBlock(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602345E RID: 144478 RVA: 0x004E25C6 File Offset: 0x004E07C6
		public static VectorOffset CreateIgnoreActorsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorRef>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602345F RID: 144479 RVA: 0x004E25E4 File Offset: 0x004E07E4
		public static VectorOffset CreateIgnoreActorsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorRef>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023460 RID: 144480 RVA: 0x004E25FD File Offset: 0x004E07FD
		public static void StartIgnoreActorsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023461 RID: 144481 RVA: 0x004E2608 File Offset: 0x004E0808
		public static Offset<IIgnoresCollisionCfg> EndIIgnoresCollisionCfg(FlatBufferBuilder builder)
		{
			return new Offset<IIgnoresCollisionCfg>(builder.EndTable());
		}

		// Token: 0x06023462 RID: 144482 RVA: 0x004E2618 File Offset: 0x004E0818
		public IIgnoresCollisionCfgT UnPack()
		{
			IIgnoresCollisionCfgT ignoresCollisionCfgT = new IIgnoresCollisionCfgT();
			this.UnPackTo(ignoresCollisionCfgT);
			return ignoresCollisionCfgT;
		}

		// Token: 0x06023463 RID: 144483 RVA: 0x004E2634 File Offset: 0x004E0834
		public void UnPackTo(IIgnoresCollisionCfgT _o)
		{
			_o.IgnoreEntitys = new List<int>();
			for (int i = 0; i < this.IgnoreEntitysLength; i++)
			{
				_o.IgnoreEntitys.Add(this.IgnoreEntitys(i));
			}
			_o.IgnoreActors = new List<IActorRefT>();
			for (int j = 0; j < this.IgnoreActorsLength; j++)
			{
				_o.IgnoreActors.Add((this.IgnoreActors(j) != null) ? this.IgnoreActors(j).Value.UnPack() : null);
			}
		}

		// Token: 0x06023464 RID: 144484 RVA: 0x004E26C4 File Offset: 0x004E08C4
		public static Offset<IIgnoresCollisionCfg> Pack(FlatBufferBuilder builder, IIgnoresCollisionCfgT _o)
		{
			if (_o == null)
			{
				return default(Offset<IIgnoresCollisionCfg>);
			}
			VectorOffset ignoreEntitysOffset = default(VectorOffset);
			if (_o.IgnoreEntitys != null)
			{
				int[] data = _o.IgnoreEntitys.ToArray();
				ignoreEntitysOffset = IIgnoresCollisionCfg.CreateIgnoreEntitysVector(builder, data);
			}
			VectorOffset ignoreActorsOffset = default(VectorOffset);
			if (_o.IgnoreActors != null)
			{
				Offset<IActorRef>[] array = new Offset<IActorRef>[_o.IgnoreActors.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActorRef.Pack(builder, _o.IgnoreActors[i]);
				}
				ignoreActorsOffset = IIgnoresCollisionCfg.CreateIgnoreActorsVector(builder, array);
			}
			return IIgnoresCollisionCfg.CreateIIgnoresCollisionCfg(builder, ignoreEntitysOffset, ignoreActorsOffset);
		}

		// Token: 0x0400E628 RID: 58920
		private Table __p;
	}
}
