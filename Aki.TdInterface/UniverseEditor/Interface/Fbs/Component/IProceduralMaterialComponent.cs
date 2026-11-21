using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D8E RID: 23950
	public struct IProceduralMaterialComponent : IFlatbufferObject
	{
		// Token: 0x1700B046 RID: 45126
		// (get) Token: 0x06027E27 RID: 163367 RVA: 0x0057499F File Offset: 0x00572B9F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027E28 RID: 163368 RVA: 0x005749AC File Offset: 0x00572BAC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027E29 RID: 163369 RVA: 0x005749B4 File Offset: 0x00572BB4
		public static IProceduralMaterialComponent GetRootAsIProceduralMaterialComponent(ByteBuffer _bb)
		{
			return IProceduralMaterialComponent.GetRootAsIProceduralMaterialComponent(_bb, default(IProceduralMaterialComponent));
		}

		// Token: 0x06027E2A RID: 163370 RVA: 0x005749D0 File Offset: 0x00572BD0
		public static IProceduralMaterialComponent GetRootAsIProceduralMaterialComponent(ByteBuffer _bb, IProceduralMaterialComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027E2B RID: 163371 RVA: 0x005749ED File Offset: 0x00572BED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027E2C RID: 163372 RVA: 0x005749FC File Offset: 0x00572BFC
		public IProceduralMaterialComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B047 RID: 45127
		// (get) Token: 0x06027E2D RID: 163373 RVA: 0x00574A0C File Offset: 0x00572C0C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06027E2E RID: 163374 RVA: 0x00574A4C File Offset: 0x00572C4C
		public ICustomPrimitiveDataConfig? ProceduralMaterialConfigs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ICustomPrimitiveDataConfig?(default(ICustomPrimitiveDataConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B048 RID: 45128
		// (get) Token: 0x06027E2F RID: 163375 RVA: 0x00574AAC File Offset: 0x00572CAC
		public int ProceduralMaterialConfigsLength
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

		// Token: 0x1700B049 RID: 45129
		// (get) Token: 0x06027E30 RID: 163376 RVA: 0x00574AD8 File Offset: 0x00572CD8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027E31 RID: 163377 RVA: 0x00574B14 File Offset: 0x00572D14
		public static Offset<IProceduralMaterialComponent> CreateIProceduralMaterialComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset ProceduralMaterialConfigsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IProceduralMaterialComponent.AddProceduralMaterialConfigs(builder, ProceduralMaterialConfigsOffset);
			IProceduralMaterialComponent.AddNullMask(builder, NullMask);
			IProceduralMaterialComponent.AddDisabled(builder, Disabled);
			return IProceduralMaterialComponent.EndIProceduralMaterialComponent(builder);
		}

		// Token: 0x06027E32 RID: 163378 RVA: 0x00574B38 File Offset: 0x00572D38
		public static void StartIProceduralMaterialComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06027E33 RID: 163379 RVA: 0x00574B41 File Offset: 0x00572D41
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06027E34 RID: 163380 RVA: 0x00574B4C File Offset: 0x00572D4C
		public static void AddProceduralMaterialConfigs(FlatBufferBuilder builder, VectorOffset proceduralMaterialConfigsOffset)
		{
			builder.AddOffset(1, proceduralMaterialConfigsOffset.Value, 0);
		}

		// Token: 0x06027E35 RID: 163381 RVA: 0x00574B5C File Offset: 0x00572D5C
		public static VectorOffset CreateProceduralMaterialConfigsVector(FlatBufferBuilder builder, Offset<ICustomPrimitiveDataConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027E36 RID: 163382 RVA: 0x00574B9C File Offset: 0x00572D9C
		public static VectorOffset CreateProceduralMaterialConfigsVectorBlock(FlatBufferBuilder builder, Offset<ICustomPrimitiveDataConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICustomPrimitiveDataConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027E37 RID: 163383 RVA: 0x00574BB6 File Offset: 0x00572DB6
		public static VectorOffset CreateProceduralMaterialConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICustomPrimitiveDataConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICustomPrimitiveDataConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027E38 RID: 163384 RVA: 0x00574BD4 File Offset: 0x00572DD4
		public static VectorOffset CreateProceduralMaterialConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICustomPrimitiveDataConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027E39 RID: 163385 RVA: 0x00574BED File Offset: 0x00572DED
		public static void StartProceduralMaterialConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027E3A RID: 163386 RVA: 0x00574BF8 File Offset: 0x00572DF8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06027E3B RID: 163387 RVA: 0x00574C03 File Offset: 0x00572E03
		public static Offset<IProceduralMaterialComponent> EndIProceduralMaterialComponent(FlatBufferBuilder builder)
		{
			return new Offset<IProceduralMaterialComponent>(builder.EndTable());
		}

		// Token: 0x06027E3C RID: 163388 RVA: 0x00574C10 File Offset: 0x00572E10
		public IProceduralMaterialComponentT UnPack()
		{
			IProceduralMaterialComponentT proceduralMaterialComponentT = new IProceduralMaterialComponentT();
			this.UnPackTo(proceduralMaterialComponentT);
			return proceduralMaterialComponentT;
		}

		// Token: 0x06027E3D RID: 163389 RVA: 0x00574C2C File Offset: 0x00572E2C
		public void UnPackTo(IProceduralMaterialComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.ProceduralMaterialConfigs = new List<ICustomPrimitiveDataConfigT>();
			for (int i = 0; i < this.ProceduralMaterialConfigsLength; i++)
			{
				_o.ProceduralMaterialConfigs.Add((this.ProceduralMaterialConfigs(i) != null) ? this.ProceduralMaterialConfigs(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06027E3E RID: 163390 RVA: 0x00574CA4 File Offset: 0x00572EA4
		public static Offset<IProceduralMaterialComponent> Pack(FlatBufferBuilder builder, IProceduralMaterialComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IProceduralMaterialComponent>);
			}
			VectorOffset proceduralMaterialConfigsOffset = default(VectorOffset);
			if (_o.ProceduralMaterialConfigs != null)
			{
				Offset<ICustomPrimitiveDataConfig>[] array = new Offset<ICustomPrimitiveDataConfig>[_o.ProceduralMaterialConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ICustomPrimitiveDataConfig.Pack(builder, _o.ProceduralMaterialConfigs[i]);
				}
				proceduralMaterialConfigsOffset = IProceduralMaterialComponent.CreateProceduralMaterialConfigsVector(builder, array);
			}
			return IProceduralMaterialComponent.CreateIProceduralMaterialComponent(builder, _o.Disabled, proceduralMaterialConfigsOffset, _o.NullMask);
		}

		// Token: 0x0400F920 RID: 63776
		private Table __p;
	}
}
