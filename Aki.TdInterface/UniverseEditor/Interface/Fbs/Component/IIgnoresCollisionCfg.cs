using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200596C RID: 22892
	public struct IIgnoresCollisionCfg : IFlatbufferObject
	{
		// Token: 0x1700A651 RID: 42577
		// (get) Token: 0x060254FF RID: 152831 RVA: 0x0051F33A File Offset: 0x0051D53A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025500 RID: 152832 RVA: 0x0051F347 File Offset: 0x0051D547
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025501 RID: 152833 RVA: 0x0051F350 File Offset: 0x0051D550
		public static IIgnoresCollisionCfg GetRootAsIIgnoresCollisionCfg(ByteBuffer _bb)
		{
			return IIgnoresCollisionCfg.GetRootAsIIgnoresCollisionCfg(_bb, default(IIgnoresCollisionCfg));
		}

		// Token: 0x06025502 RID: 152834 RVA: 0x0051F36C File Offset: 0x0051D56C
		public static IIgnoresCollisionCfg GetRootAsIIgnoresCollisionCfg(ByteBuffer _bb, IIgnoresCollisionCfg obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025503 RID: 152835 RVA: 0x0051F389 File Offset: 0x0051D589
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025504 RID: 152836 RVA: 0x0051F398 File Offset: 0x0051D598
		public IIgnoresCollisionCfg __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06025505 RID: 152837 RVA: 0x0051F3A8 File Offset: 0x0051D5A8
		public int IgnoreEntitys(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A652 RID: 42578
		// (get) Token: 0x06025506 RID: 152838 RVA: 0x0051F3E8 File Offset: 0x0051D5E8
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

		// Token: 0x06025507 RID: 152839 RVA: 0x0051F413 File Offset: 0x0051D613
		public Span<int> GetIgnoreEntitysBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x06025508 RID: 152840 RVA: 0x0051F422 File Offset: 0x0051D622
		public int[] GetIgnoreEntitysArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x06025509 RID: 152841 RVA: 0x0051F430 File Offset: 0x0051D630
		public IActorRef? IgnoreActors(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActorRef?(default(IActorRef).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A653 RID: 42579
		// (get) Token: 0x0602550A RID: 152842 RVA: 0x0051F490 File Offset: 0x0051D690
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

		// Token: 0x0602550B RID: 152843 RVA: 0x0051F4BB File Offset: 0x0051D6BB
		public static Offset<IIgnoresCollisionCfg> CreateIIgnoresCollisionCfg(FlatBufferBuilder builder, VectorOffset IgnoreEntitysOffset = default(VectorOffset), VectorOffset IgnoreActorsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IIgnoresCollisionCfg.AddIgnoreActors(builder, IgnoreActorsOffset);
			IIgnoresCollisionCfg.AddIgnoreEntitys(builder, IgnoreEntitysOffset);
			return IIgnoresCollisionCfg.EndIIgnoresCollisionCfg(builder);
		}

		// Token: 0x0602550C RID: 152844 RVA: 0x0051F4D8 File Offset: 0x0051D6D8
		public static void StartIIgnoresCollisionCfg(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602550D RID: 152845 RVA: 0x0051F4E1 File Offset: 0x0051D6E1
		public static void AddIgnoreEntitys(FlatBufferBuilder builder, VectorOffset ignoreEntitysOffset)
		{
			builder.AddOffset(0, ignoreEntitysOffset.Value, 0);
		}

		// Token: 0x0602550E RID: 152846 RVA: 0x0051F4F4 File Offset: 0x0051D6F4
		public static VectorOffset CreateIgnoreEntitysVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602550F RID: 152847 RVA: 0x0051F52B File Offset: 0x0051D72B
		public static VectorOffset CreateIgnoreEntitysVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06025510 RID: 152848 RVA: 0x0051F545 File Offset: 0x0051D745
		public static VectorOffset CreateIgnoreEntitysVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06025511 RID: 152849 RVA: 0x0051F563 File Offset: 0x0051D763
		public static VectorOffset CreateIgnoreEntitysVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025512 RID: 152850 RVA: 0x0051F57C File Offset: 0x0051D77C
		public static void StartIgnoreEntitysVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025513 RID: 152851 RVA: 0x0051F587 File Offset: 0x0051D787
		public static void AddIgnoreActors(FlatBufferBuilder builder, VectorOffset ignoreActorsOffset)
		{
			builder.AddOffset(1, ignoreActorsOffset.Value, 0);
		}

		// Token: 0x06025514 RID: 152852 RVA: 0x0051F598 File Offset: 0x0051D798
		public static VectorOffset CreateIgnoreActorsVector(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025515 RID: 152853 RVA: 0x0051F5D8 File Offset: 0x0051D7D8
		public static VectorOffset CreateIgnoreActorsVectorBlock(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025516 RID: 152854 RVA: 0x0051F5F2 File Offset: 0x0051D7F2
		public static VectorOffset CreateIgnoreActorsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorRef>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025517 RID: 152855 RVA: 0x0051F610 File Offset: 0x0051D810
		public static VectorOffset CreateIgnoreActorsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorRef>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025518 RID: 152856 RVA: 0x0051F629 File Offset: 0x0051D829
		public static void StartIgnoreActorsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025519 RID: 152857 RVA: 0x0051F634 File Offset: 0x0051D834
		public static Offset<IIgnoresCollisionCfg> EndIIgnoresCollisionCfg(FlatBufferBuilder builder)
		{
			return new Offset<IIgnoresCollisionCfg>(builder.EndTable());
		}

		// Token: 0x0602551A RID: 152858 RVA: 0x0051F644 File Offset: 0x0051D844
		public IIgnoresCollisionCfgT UnPack()
		{
			IIgnoresCollisionCfgT ignoresCollisionCfgT = new IIgnoresCollisionCfgT();
			this.UnPackTo(ignoresCollisionCfgT);
			return ignoresCollisionCfgT;
		}

		// Token: 0x0602551B RID: 152859 RVA: 0x0051F660 File Offset: 0x0051D860
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

		// Token: 0x0602551C RID: 152860 RVA: 0x0051F6F0 File Offset: 0x0051D8F0
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

		// Token: 0x0400F259 RID: 62041
		private Table __p;
	}
}
