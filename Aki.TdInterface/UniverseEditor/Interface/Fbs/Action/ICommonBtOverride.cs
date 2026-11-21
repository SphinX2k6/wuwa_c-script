using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ACD RID: 27341
	public struct ICommonBtOverride : IFlatbufferObject
	{
		// Token: 0x1700C8C4 RID: 51396
		// (get) Token: 0x0602EEDF RID: 192223 RVA: 0x00664646 File Offset: 0x00662846
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EEE0 RID: 192224 RVA: 0x00664653 File Offset: 0x00662853
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EEE1 RID: 192225 RVA: 0x0066465C File Offset: 0x0066285C
		public static ICommonBtOverride GetRootAsICommonBtOverride(ByteBuffer _bb)
		{
			return ICommonBtOverride.GetRootAsICommonBtOverride(_bb, default(ICommonBtOverride));
		}

		// Token: 0x0602EEE2 RID: 192226 RVA: 0x00664678 File Offset: 0x00662878
		public static ICommonBtOverride GetRootAsICommonBtOverride(ByteBuffer _bb, ICommonBtOverride obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EEE3 RID: 192227 RVA: 0x00664695 File Offset: 0x00662895
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EEE4 RID: 192228 RVA: 0x006646A4 File Offset: 0x006628A4
		public ICommonBtOverride __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C8C5 RID: 51397
		// (get) Token: 0x0602EEE5 RID: 192229 RVA: 0x006646B4 File Offset: 0x006628B4
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

		// Token: 0x0602EEE6 RID: 192230 RVA: 0x006646F0 File Offset: 0x006628F0
		public ICommonBtPlaceholder? OverridePlaceholders(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ICommonBtPlaceholder?(default(ICommonBtPlaceholder).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700C8C6 RID: 51398
		// (get) Token: 0x0602EEE7 RID: 192231 RVA: 0x00664750 File Offset: 0x00662950
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

		// Token: 0x0602EEE8 RID: 192232 RVA: 0x0066477C File Offset: 0x0066297C
		public ICommonBtClientOverrideData? ClientOverrideData(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new ICommonBtClientOverrideData?(default(ICommonBtClientOverrideData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700C8C7 RID: 51399
		// (get) Token: 0x0602EEE9 RID: 192233 RVA: 0x006647DC File Offset: 0x006629DC
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

		// Token: 0x0602EEEA RID: 192234 RVA: 0x00664807 File Offset: 0x00662A07
		public static Offset<ICommonBtOverride> CreateICommonBtOverride(FlatBufferBuilder builder, int CommonBtId = 0, VectorOffset OverridePlaceholdersOffset = default(VectorOffset), VectorOffset ClientOverrideDataOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ICommonBtOverride.AddClientOverrideData(builder, ClientOverrideDataOffset);
			ICommonBtOverride.AddOverridePlaceholders(builder, OverridePlaceholdersOffset);
			ICommonBtOverride.AddCommonBtId(builder, CommonBtId);
			return ICommonBtOverride.EndICommonBtOverride(builder);
		}

		// Token: 0x0602EEEB RID: 192235 RVA: 0x0066482B File Offset: 0x00662A2B
		public static void StartICommonBtOverride(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602EEEC RID: 192236 RVA: 0x00664834 File Offset: 0x00662A34
		public static void AddCommonBtId(FlatBufferBuilder builder, int commonBtId)
		{
			builder.AddInt(0, commonBtId, 0);
		}

		// Token: 0x0602EEED RID: 192237 RVA: 0x0066483F File Offset: 0x00662A3F
		public static void AddOverridePlaceholders(FlatBufferBuilder builder, VectorOffset overridePlaceholdersOffset)
		{
			builder.AddOffset(1, overridePlaceholdersOffset.Value, 0);
		}

		// Token: 0x0602EEEE RID: 192238 RVA: 0x00664850 File Offset: 0x00662A50
		public static VectorOffset CreateOverridePlaceholdersVector(FlatBufferBuilder builder, Offset<ICommonBtPlaceholder>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602EEEF RID: 192239 RVA: 0x00664890 File Offset: 0x00662A90
		public static VectorOffset CreateOverridePlaceholdersVectorBlock(FlatBufferBuilder builder, Offset<ICommonBtPlaceholder>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICommonBtPlaceholder>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EEF0 RID: 192240 RVA: 0x006648AA File Offset: 0x00662AAA
		public static VectorOffset CreateOverridePlaceholdersVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICommonBtPlaceholder>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICommonBtPlaceholder>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EEF1 RID: 192241 RVA: 0x006648C8 File Offset: 0x00662AC8
		public static VectorOffset CreateOverridePlaceholdersVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICommonBtPlaceholder>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602EEF2 RID: 192242 RVA: 0x006648E1 File Offset: 0x00662AE1
		public static void StartOverridePlaceholdersVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602EEF3 RID: 192243 RVA: 0x006648EC File Offset: 0x00662AEC
		public static void AddClientOverrideData(FlatBufferBuilder builder, VectorOffset clientOverrideDataOffset)
		{
			builder.AddOffset(2, clientOverrideDataOffset.Value, 0);
		}

		// Token: 0x0602EEF4 RID: 192244 RVA: 0x006648FC File Offset: 0x00662AFC
		public static VectorOffset CreateClientOverrideDataVector(FlatBufferBuilder builder, Offset<ICommonBtClientOverrideData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602EEF5 RID: 192245 RVA: 0x0066493C File Offset: 0x00662B3C
		public static VectorOffset CreateClientOverrideDataVectorBlock(FlatBufferBuilder builder, Offset<ICommonBtClientOverrideData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICommonBtClientOverrideData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EEF6 RID: 192246 RVA: 0x00664956 File Offset: 0x00662B56
		public static VectorOffset CreateClientOverrideDataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICommonBtClientOverrideData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICommonBtClientOverrideData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EEF7 RID: 192247 RVA: 0x00664974 File Offset: 0x00662B74
		public static VectorOffset CreateClientOverrideDataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICommonBtClientOverrideData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602EEF8 RID: 192248 RVA: 0x0066498D File Offset: 0x00662B8D
		public static void StartClientOverrideDataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602EEF9 RID: 192249 RVA: 0x00664998 File Offset: 0x00662B98
		public static Offset<ICommonBtOverride> EndICommonBtOverride(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtOverride>(builder.EndTable());
		}

		// Token: 0x0602EEFA RID: 192250 RVA: 0x006649A8 File Offset: 0x00662BA8
		public ICommonBtOverrideT UnPack()
		{
			ICommonBtOverrideT commonBtOverrideT = new ICommonBtOverrideT();
			this.UnPackTo(commonBtOverrideT);
			return commonBtOverrideT;
		}

		// Token: 0x0602EEFB RID: 192251 RVA: 0x006649C4 File Offset: 0x00662BC4
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

		// Token: 0x0602EEFC RID: 192252 RVA: 0x00664A84 File Offset: 0x00662C84
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

		// Token: 0x0401186D RID: 71789
		private Table __p;
	}
}
