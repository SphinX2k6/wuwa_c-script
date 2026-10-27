using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005213 RID: 21011
	public struct IExtraRangeComponent : IFlatbufferObject
	{
		// Token: 0x170099E6 RID: 39398
		// (get) Token: 0x0602224A RID: 139850 RVA: 0x004BCC6B File Offset: 0x004BAE6B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602224B RID: 139851 RVA: 0x004BCC78 File Offset: 0x004BAE78
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602224C RID: 139852 RVA: 0x004BCC80 File Offset: 0x004BAE80
		public static IExtraRangeComponent GetRootAsIExtraRangeComponent(ByteBuffer _bb)
		{
			return IExtraRangeComponent.GetRootAsIExtraRangeComponent(_bb, default(IExtraRangeComponent));
		}

		// Token: 0x0602224D RID: 139853 RVA: 0x004BCC9C File Offset: 0x004BAE9C
		public static IExtraRangeComponent GetRootAsIExtraRangeComponent(ByteBuffer _bb, IExtraRangeComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602224E RID: 139854 RVA: 0x004BCCB9 File Offset: 0x004BAEB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602224F RID: 139855 RVA: 0x004BCCC8 File Offset: 0x004BAEC8
		public IExtraRangeComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170099E7 RID: 39399
		// (get) Token: 0x06022250 RID: 139856 RVA: 0x004BCCD8 File Offset: 0x004BAED8
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06022251 RID: 139857 RVA: 0x004BCD18 File Offset: 0x004BAF18
		public ISunSpiritBlockExtraRange? ExtraRangeConfigs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISunSpiritBlockExtraRange?(default(ISunSpiritBlockExtraRange).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170099E8 RID: 39400
		// (get) Token: 0x06022252 RID: 139858 RVA: 0x004BCD78 File Offset: 0x004BAF78
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

		// Token: 0x170099E9 RID: 39401
		// (get) Token: 0x06022253 RID: 139859 RVA: 0x004BCDA4 File Offset: 0x004BAFA4
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

		// Token: 0x06022254 RID: 139860 RVA: 0x004BCDE0 File Offset: 0x004BAFE0
		public static Offset<IExtraRangeComponent> CreateIExtraRangeComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset ExtraRangeConfigsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IExtraRangeComponent.AddExtraRangeConfigs(builder, ExtraRangeConfigsOffset);
			IExtraRangeComponent.AddNullMask(builder, NullMask);
			IExtraRangeComponent.AddDisabled(builder, Disabled);
			return IExtraRangeComponent.EndIExtraRangeComponent(builder);
		}

		// Token: 0x06022255 RID: 139861 RVA: 0x004BCE04 File Offset: 0x004BB004
		public static void StartIExtraRangeComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06022256 RID: 139862 RVA: 0x004BCE0D File Offset: 0x004BB00D
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06022257 RID: 139863 RVA: 0x004BCE18 File Offset: 0x004BB018
		public static void AddExtraRangeConfigs(FlatBufferBuilder builder, VectorOffset extraRangeConfigsOffset)
		{
			builder.AddOffset(1, extraRangeConfigsOffset.Value, 0);
		}

		// Token: 0x06022258 RID: 139864 RVA: 0x004BCE28 File Offset: 0x004BB028
		public static VectorOffset CreateExtraRangeConfigsVector(FlatBufferBuilder builder, Offset<ISunSpiritBlockExtraRange>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022259 RID: 139865 RVA: 0x004BCE68 File Offset: 0x004BB068
		public static VectorOffset CreateExtraRangeConfigsVectorBlock(FlatBufferBuilder builder, Offset<ISunSpiritBlockExtraRange>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISunSpiritBlockExtraRange>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602225A RID: 139866 RVA: 0x004BCE82 File Offset: 0x004BB082
		public static VectorOffset CreateExtraRangeConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISunSpiritBlockExtraRange>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISunSpiritBlockExtraRange>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602225B RID: 139867 RVA: 0x004BCEA0 File Offset: 0x004BB0A0
		public static VectorOffset CreateExtraRangeConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISunSpiritBlockExtraRange>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602225C RID: 139868 RVA: 0x004BCEB9 File Offset: 0x004BB0B9
		public static void StartExtraRangeConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602225D RID: 139869 RVA: 0x004BCEC4 File Offset: 0x004BB0C4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602225E RID: 139870 RVA: 0x004BCECF File Offset: 0x004BB0CF
		public static Offset<IExtraRangeComponent> EndIExtraRangeComponent(FlatBufferBuilder builder)
		{
			return new Offset<IExtraRangeComponent>(builder.EndTable());
		}

		// Token: 0x0602225F RID: 139871 RVA: 0x004BCEDC File Offset: 0x004BB0DC
		public IExtraRangeComponentT UnPack()
		{
			IExtraRangeComponentT extraRangeComponentT = new IExtraRangeComponentT();
			this.UnPackTo(extraRangeComponentT);
			return extraRangeComponentT;
		}

		// Token: 0x06022260 RID: 139872 RVA: 0x004BCEF8 File Offset: 0x004BB0F8
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

		// Token: 0x06022261 RID: 139873 RVA: 0x004BCF70 File Offset: 0x004BB170
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

		// Token: 0x0400E34A RID: 58186
		private Table __p;
	}
}
