using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200577B RID: 22395
	public struct IExtraRangeComponent : IFlatbufferObject
	{
		// Token: 0x1700A1E2 RID: 41442
		// (get) Token: 0x060241E0 RID: 147936 RVA: 0x004F772F File Offset: 0x004F592F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060241E1 RID: 147937 RVA: 0x004F773C File Offset: 0x004F593C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060241E2 RID: 147938 RVA: 0x004F7744 File Offset: 0x004F5944
		public static IExtraRangeComponent GetRootAsIExtraRangeComponent(ByteBuffer _bb)
		{
			return IExtraRangeComponent.GetRootAsIExtraRangeComponent(_bb, default(IExtraRangeComponent));
		}

		// Token: 0x060241E3 RID: 147939 RVA: 0x004F7760 File Offset: 0x004F5960
		public static IExtraRangeComponent GetRootAsIExtraRangeComponent(ByteBuffer _bb, IExtraRangeComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060241E4 RID: 147940 RVA: 0x004F777D File Offset: 0x004F597D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060241E5 RID: 147941 RVA: 0x004F778C File Offset: 0x004F598C
		public IExtraRangeComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A1E3 RID: 41443
		// (get) Token: 0x060241E6 RID: 147942 RVA: 0x004F779C File Offset: 0x004F599C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060241E7 RID: 147943 RVA: 0x004F77DC File Offset: 0x004F59DC
		public ISunSpiritBlockExtraRange? ExtraRangeConfigs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISunSpiritBlockExtraRange?(default(ISunSpiritBlockExtraRange).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A1E4 RID: 41444
		// (get) Token: 0x060241E8 RID: 147944 RVA: 0x004F783C File Offset: 0x004F5A3C
		public int ExtraRangeConfigsLength
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

		// Token: 0x1700A1E5 RID: 41445
		// (get) Token: 0x060241E9 RID: 147945 RVA: 0x004F7868 File Offset: 0x004F5A68
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

		// Token: 0x060241EA RID: 147946 RVA: 0x004F78A4 File Offset: 0x004F5AA4
		public static Offset<IExtraRangeComponent> CreateIExtraRangeComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset ExtraRangeConfigsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IExtraRangeComponent.AddExtraRangeConfigs(builder, ExtraRangeConfigsOffset);
			IExtraRangeComponent.AddNullMask(builder, NullMask);
			IExtraRangeComponent.AddDisabled(builder, Disabled);
			return IExtraRangeComponent.EndIExtraRangeComponent(builder);
		}

		// Token: 0x060241EB RID: 147947 RVA: 0x004F78C8 File Offset: 0x004F5AC8
		public static void StartIExtraRangeComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060241EC RID: 147948 RVA: 0x004F78D1 File Offset: 0x004F5AD1
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060241ED RID: 147949 RVA: 0x004F78DC File Offset: 0x004F5ADC
		public static void AddExtraRangeConfigs(FlatBufferBuilder builder, VectorOffset extraRangeConfigsOffset)
		{
			builder.AddOffset(1, extraRangeConfigsOffset.Value, 0);
		}

		// Token: 0x060241EE RID: 147950 RVA: 0x004F78EC File Offset: 0x004F5AEC
		public static VectorOffset CreateExtraRangeConfigsVector(FlatBufferBuilder builder, Offset<ISunSpiritBlockExtraRange>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060241EF RID: 147951 RVA: 0x004F792C File Offset: 0x004F5B2C
		public static VectorOffset CreateExtraRangeConfigsVectorBlock(FlatBufferBuilder builder, Offset<ISunSpiritBlockExtraRange>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISunSpiritBlockExtraRange>>(data);
			return builder.EndVector();
		}

		// Token: 0x060241F0 RID: 147952 RVA: 0x004F7946 File Offset: 0x004F5B46
		public static VectorOffset CreateExtraRangeConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISunSpiritBlockExtraRange>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISunSpiritBlockExtraRange>>(data);
			return builder.EndVector();
		}

		// Token: 0x060241F1 RID: 147953 RVA: 0x004F7964 File Offset: 0x004F5B64
		public static VectorOffset CreateExtraRangeConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISunSpiritBlockExtraRange>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060241F2 RID: 147954 RVA: 0x004F797D File Offset: 0x004F5B7D
		public static void StartExtraRangeConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060241F3 RID: 147955 RVA: 0x004F7988 File Offset: 0x004F5B88
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060241F4 RID: 147956 RVA: 0x004F7993 File Offset: 0x004F5B93
		public static Offset<IExtraRangeComponent> EndIExtraRangeComponent(FlatBufferBuilder builder)
		{
			return new Offset<IExtraRangeComponent>(builder.EndTable());
		}

		// Token: 0x060241F5 RID: 147957 RVA: 0x004F79A0 File Offset: 0x004F5BA0
		public IExtraRangeComponentT UnPack()
		{
			IExtraRangeComponentT extraRangeComponentT = new IExtraRangeComponentT();
			this.UnPackTo(extraRangeComponentT);
			return extraRangeComponentT;
		}

		// Token: 0x060241F6 RID: 147958 RVA: 0x004F79BC File Offset: 0x004F5BBC
		public void UnPackTo(IExtraRangeComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.ExtraRangeConfigs = new List<ISunSpiritBlockExtraRangeT>();
			for (int i = 0; i < this.ExtraRangeConfigsLength; i++)
			{
				_o.ExtraRangeConfigs.Add((this.ExtraRangeConfigs(i) != null) ? this.ExtraRangeConfigs(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060241F7 RID: 147959 RVA: 0x004F7A34 File Offset: 0x004F5C34
		public static Offset<IExtraRangeComponent> Pack(FlatBufferBuilder builder, IExtraRangeComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExtraRangeComponent>);
			}
			VectorOffset extraRangeConfigsOffset = default(VectorOffset);
			if (_o.ExtraRangeConfigs != null)
			{
				Offset<ISunSpiritBlockExtraRange>[] array = new Offset<ISunSpiritBlockExtraRange>[_o.ExtraRangeConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ISunSpiritBlockExtraRange.Pack(builder, _o.ExtraRangeConfigs[i]);
				}
				extraRangeConfigsOffset = IExtraRangeComponent.CreateExtraRangeConfigsVector(builder, array);
			}
			return IExtraRangeComponent.CreateIExtraRangeComponent(builder, _o.Disabled, extraRangeConfigsOffset, _o.NullMask);
		}

		// Token: 0x0400EF50 RID: 61264
		private Table __p;
	}
}
