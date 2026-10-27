using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006465 RID: 25701
	public struct ICommonBtOverride : IFlatbufferObject
	{
		// Token: 0x1700BF42 RID: 48962
		// (get) Token: 0x0602C79A RID: 182170 RVA: 0x0061957A File Offset: 0x0061777A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C79B RID: 182171 RVA: 0x00619587 File Offset: 0x00617787
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C79C RID: 182172 RVA: 0x00619590 File Offset: 0x00617790
		public static ICommonBtOverride GetRootAsICommonBtOverride(ByteBuffer _bb)
		{
			return ICommonBtOverride.GetRootAsICommonBtOverride(_bb, default(ICommonBtOverride));
		}

		// Token: 0x0602C79D RID: 182173 RVA: 0x006195AC File Offset: 0x006177AC
		public static ICommonBtOverride GetRootAsICommonBtOverride(ByteBuffer _bb, ICommonBtOverride obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C79E RID: 182174 RVA: 0x006195C9 File Offset: 0x006177C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C79F RID: 182175 RVA: 0x006195D8 File Offset: 0x006177D8
		public ICommonBtOverride __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF43 RID: 48963
		// (get) Token: 0x0602C7A0 RID: 182176 RVA: 0x006195E8 File Offset: 0x006177E8
		public int CommonBtId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C7A1 RID: 182177 RVA: 0x00619624 File Offset: 0x00617824
		public ICommonBtPlaceholder? OverridePlaceholders(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ICommonBtPlaceholder?(default(ICommonBtPlaceholder).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700BF44 RID: 48964
		// (get) Token: 0x0602C7A2 RID: 182178 RVA: 0x00619684 File Offset: 0x00617884
		public int OverridePlaceholdersLength
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

		// Token: 0x0602C7A3 RID: 182179 RVA: 0x006196B0 File Offset: 0x006178B0
		public ICommonBtClientOverrideData? ClientOverrideData(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new ICommonBtClientOverrideData?(default(ICommonBtClientOverrideData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700BF45 RID: 48965
		// (get) Token: 0x0602C7A4 RID: 182180 RVA: 0x00619710 File Offset: 0x00617910
		public int ClientOverrideDataLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602C7A5 RID: 182181 RVA: 0x0061973B File Offset: 0x0061793B
		public static Offset<ICommonBtOverride> CreateICommonBtOverride(FlatBufferBuilder builder, int CommonBtId = 0, VectorOffset OverridePlaceholdersOffset = default(VectorOffset), VectorOffset ClientOverrideDataOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ICommonBtOverride.AddClientOverrideData(builder, ClientOverrideDataOffset);
			ICommonBtOverride.AddOverridePlaceholders(builder, OverridePlaceholdersOffset);
			ICommonBtOverride.AddCommonBtId(builder, CommonBtId);
			return ICommonBtOverride.EndICommonBtOverride(builder);
		}

		// Token: 0x0602C7A6 RID: 182182 RVA: 0x0061975F File Offset: 0x0061795F
		public static void StartICommonBtOverride(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602C7A7 RID: 182183 RVA: 0x00619768 File Offset: 0x00617968
		public static void AddCommonBtId(FlatBufferBuilder builder, int commonBtId)
		{
			builder.AddInt(0, commonBtId, 0);
		}

		// Token: 0x0602C7A8 RID: 182184 RVA: 0x00619773 File Offset: 0x00617973
		public static void AddOverridePlaceholders(FlatBufferBuilder builder, VectorOffset overridePlaceholdersOffset)
		{
			builder.AddOffset(1, overridePlaceholdersOffset.Value, 0);
		}

		// Token: 0x0602C7A9 RID: 182185 RVA: 0x00619784 File Offset: 0x00617984
		public static VectorOffset CreateOverridePlaceholdersVector(FlatBufferBuilder builder, Offset<ICommonBtPlaceholder>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602C7AA RID: 182186 RVA: 0x006197C4 File Offset: 0x006179C4
		public static VectorOffset CreateOverridePlaceholdersVectorBlock(FlatBufferBuilder builder, Offset<ICommonBtPlaceholder>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICommonBtPlaceholder>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C7AB RID: 182187 RVA: 0x006197DE File Offset: 0x006179DE
		public static VectorOffset CreateOverridePlaceholdersVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICommonBtPlaceholder>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICommonBtPlaceholder>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C7AC RID: 182188 RVA: 0x006197FC File Offset: 0x006179FC
		public static VectorOffset CreateOverridePlaceholdersVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICommonBtPlaceholder>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602C7AD RID: 182189 RVA: 0x00619815 File Offset: 0x00617A15
		public static void StartOverridePlaceholdersVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602C7AE RID: 182190 RVA: 0x00619820 File Offset: 0x00617A20
		public static void AddClientOverrideData(FlatBufferBuilder builder, VectorOffset clientOverrideDataOffset)
		{
			builder.AddOffset(2, clientOverrideDataOffset.Value, 0);
		}

		// Token: 0x0602C7AF RID: 182191 RVA: 0x00619830 File Offset: 0x00617A30
		public static VectorOffset CreateClientOverrideDataVector(FlatBufferBuilder builder, Offset<ICommonBtClientOverrideData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602C7B0 RID: 182192 RVA: 0x00619870 File Offset: 0x00617A70
		public static VectorOffset CreateClientOverrideDataVectorBlock(FlatBufferBuilder builder, Offset<ICommonBtClientOverrideData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICommonBtClientOverrideData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C7B1 RID: 182193 RVA: 0x0061988A File Offset: 0x00617A8A
		public static VectorOffset CreateClientOverrideDataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICommonBtClientOverrideData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICommonBtClientOverrideData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C7B2 RID: 182194 RVA: 0x006198A8 File Offset: 0x00617AA8
		public static VectorOffset CreateClientOverrideDataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICommonBtClientOverrideData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602C7B3 RID: 182195 RVA: 0x006198C1 File Offset: 0x00617AC1
		public static void StartClientOverrideDataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602C7B4 RID: 182196 RVA: 0x006198CC File Offset: 0x00617ACC
		public static Offset<ICommonBtOverride> EndICommonBtOverride(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtOverride>(builder.EndTable());
		}

		// Token: 0x0602C7B5 RID: 182197 RVA: 0x006198DC File Offset: 0x00617ADC
		public ICommonBtOverrideT UnPack()
		{
			ICommonBtOverrideT commonBtOverrideT = new ICommonBtOverrideT();
			this.UnPackTo(commonBtOverrideT);
			return commonBtOverrideT;
		}

		// Token: 0x0602C7B6 RID: 182198 RVA: 0x006198F8 File Offset: 0x00617AF8
		public void UnPackTo(ICommonBtOverrideT _o)
		{
			_o.CommonBtId = this.CommonBtId;
			_o.OverridePlaceholders = new List<ICommonBtPlaceholderT>();
			for (int i = 0; i < this.OverridePlaceholdersLength; i++)
			{
				_o.OverridePlaceholders.Add((this.OverridePlaceholders(i) != null) ? this.OverridePlaceholders(i).Value.UnPack() : null);
			}
			_o.ClientOverrideData = new List<ICommonBtClientOverrideDataT>();
			for (int j = 0; j < this.ClientOverrideDataLength; j++)
			{
				_o.ClientOverrideData.Add((this.ClientOverrideData(j) != null) ? this.ClientOverrideData(j).Value.UnPack() : null);
			}
		}

		// Token: 0x0602C7B7 RID: 182199 RVA: 0x006199B8 File Offset: 0x00617BB8
		public static Offset<ICommonBtOverride> Pack(FlatBufferBuilder builder, ICommonBtOverrideT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonBtOverride>);
			}
			VectorOffset overridePlaceholdersOffset = default(VectorOffset);
			if (_o.OverridePlaceholders != null)
			{
				Offset<ICommonBtPlaceholder>[] array = new Offset<ICommonBtPlaceholder>[_o.OverridePlaceholders.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ICommonBtPlaceholder.Pack(builder, _o.OverridePlaceholders[i]);
				}
				overridePlaceholdersOffset = ICommonBtOverride.CreateOverridePlaceholdersVector(builder, array);
			}
			VectorOffset clientOverrideDataOffset = default(VectorOffset);
			if (_o.ClientOverrideData != null)
			{
				Offset<ICommonBtClientOverrideData>[] array2 = new Offset<ICommonBtClientOverrideData>[_o.ClientOverrideData.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = ICommonBtClientOverrideData.Pack(builder, _o.ClientOverrideData[j]);
				}
				clientOverrideDataOffset = ICommonBtOverride.CreateClientOverrideDataVector(builder, array2);
			}
			return ICommonBtOverride.CreateICommonBtOverride(builder, _o.CommonBtId, overridePlaceholdersOffset, clientOverrideDataOffset);
		}

		// Token: 0x04010A62 RID: 68194
		private Table __p;
	}
}
