using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F28 RID: 20264
	public struct IBuffArea : IFlatbufferObject
	{
		// Token: 0x17009208 RID: 37384
		// (get) Token: 0x06020100 RID: 131328 RVA: 0x0047619A File Offset: 0x0047439A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020101 RID: 131329 RVA: 0x004761A7 File Offset: 0x004743A7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020102 RID: 131330 RVA: 0x004761B0 File Offset: 0x004743B0
		public static IBuffArea GetRootAsIBuffArea(ByteBuffer _bb)
		{
			return IBuffArea.GetRootAsIBuffArea(_bb, default(IBuffArea));
		}

		// Token: 0x06020103 RID: 131331 RVA: 0x004761CC File Offset: 0x004743CC
		public static IBuffArea GetRootAsIBuffArea(ByteBuffer _bb, IBuffArea obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020104 RID: 131332 RVA: 0x004761E9 File Offset: 0x004743E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020105 RID: 131333 RVA: 0x004761F8 File Offset: 0x004743F8
		public IBuffArea __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009209 RID: 37385
		// (get) Token: 0x06020106 RID: 131334 RVA: 0x00476208 File Offset: 0x00474408
		public EEffectAreaType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEffectAreaType.BuffArea;
				}
				return (EEffectAreaType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020107 RID: 131335 RVA: 0x00476244 File Offset: 0x00474444
		public IBuffAreaStateConfig? BuffConfigs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IBuffAreaStateConfig?(default(IBuffAreaStateConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700920A RID: 37386
		// (get) Token: 0x06020108 RID: 131336 RVA: 0x004762A4 File Offset: 0x004744A4
		public int BuffConfigsLength
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

		// Token: 0x06020109 RID: 131337 RVA: 0x004762CF File Offset: 0x004744CF
		public static Offset<IBuffArea> CreateIBuffArea(FlatBufferBuilder builder, EEffectAreaType Type = EEffectAreaType.BuffArea, VectorOffset BuffConfigsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IBuffArea.AddBuffConfigs(builder, BuffConfigsOffset);
			IBuffArea.AddType(builder, Type);
			return IBuffArea.EndIBuffArea(builder);
		}

		// Token: 0x0602010A RID: 131338 RVA: 0x004762EC File Offset: 0x004744EC
		public static void StartIBuffArea(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602010B RID: 131339 RVA: 0x004762F5 File Offset: 0x004744F5
		public static void AddType(FlatBufferBuilder builder, EEffectAreaType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602010C RID: 131340 RVA: 0x00476300 File Offset: 0x00474500
		public static void AddBuffConfigs(FlatBufferBuilder builder, VectorOffset buffConfigsOffset)
		{
			builder.AddOffset(1, buffConfigsOffset.Value, 0);
		}

		// Token: 0x0602010D RID: 131341 RVA: 0x00476310 File Offset: 0x00474510
		public static VectorOffset CreateBuffConfigsVector(FlatBufferBuilder builder, Offset<IBuffAreaStateConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602010E RID: 131342 RVA: 0x00476350 File Offset: 0x00474550
		public static VectorOffset CreateBuffConfigsVectorBlock(FlatBufferBuilder builder, Offset<IBuffAreaStateConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IBuffAreaStateConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602010F RID: 131343 RVA: 0x0047636A File Offset: 0x0047456A
		public static VectorOffset CreateBuffConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IBuffAreaStateConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IBuffAreaStateConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020110 RID: 131344 RVA: 0x00476388 File Offset: 0x00474588
		public static VectorOffset CreateBuffConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IBuffAreaStateConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020111 RID: 131345 RVA: 0x004763A1 File Offset: 0x004745A1
		public static void StartBuffConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020112 RID: 131346 RVA: 0x004763AC File Offset: 0x004745AC
		public static Offset<IBuffArea> EndIBuffArea(FlatBufferBuilder builder)
		{
			return new Offset<IBuffArea>(builder.EndTable());
		}

		// Token: 0x06020113 RID: 131347 RVA: 0x004763BC File Offset: 0x004745BC
		public IBuffAreaT UnPack()
		{
			IBuffAreaT buffAreaT = new IBuffAreaT();
			this.UnPackTo(buffAreaT);
			return buffAreaT;
		}

		// Token: 0x06020114 RID: 131348 RVA: 0x004763D8 File Offset: 0x004745D8
		public void UnPackTo(IBuffAreaT _o)
		{
			_o.Type = this.Type;
			_o.BuffConfigs = new List<IBuffAreaStateConfigT>();
			for (int i = 0; i < this.BuffConfigsLength; i++)
			{
				_o.BuffConfigs.Add((this.BuffConfigs(i) != null) ? this.BuffConfigs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06020115 RID: 131349 RVA: 0x00476444 File Offset: 0x00474644
		public static Offset<IBuffArea> Pack(FlatBufferBuilder builder, IBuffAreaT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBuffArea>);
			}
			VectorOffset buffConfigsOffset = default(VectorOffset);
			if (_o.BuffConfigs != null)
			{
				Offset<IBuffAreaStateConfig>[] array = new Offset<IBuffAreaStateConfig>[_o.BuffConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IBuffAreaStateConfig.Pack(builder, _o.BuffConfigs[i]);
				}
				buffConfigsOffset = IBuffArea.CreateBuffConfigsVector(builder, array);
			}
			return IBuffArea.CreateIBuffArea(builder, _o.Type, buffConfigsOffset);
		}

		// Token: 0x0400DD8A RID: 56714
		private Table __p;
	}
}
