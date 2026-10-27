using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200721A RID: 29210
	public struct ISubScreenModeInit : IFlatbufferObject
	{
		// Token: 0x1700D8D5 RID: 55509
		// (get) Token: 0x06033CF6 RID: 212214 RVA: 0x006F8F70 File Offset: 0x006F7170
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033CF7 RID: 212215 RVA: 0x006F8F7D File Offset: 0x006F717D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033CF8 RID: 212216 RVA: 0x006F8F84 File Offset: 0x006F7184
		public static ISubScreenModeInit GetRootAsISubScreenModeInit(ByteBuffer _bb)
		{
			return ISubScreenModeInit.GetRootAsISubScreenModeInit(_bb, default(ISubScreenModeInit));
		}

		// Token: 0x06033CF9 RID: 212217 RVA: 0x006F8FA0 File Offset: 0x006F71A0
		public static ISubScreenModeInit GetRootAsISubScreenModeInit(ByteBuffer _bb, ISubScreenModeInit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033CFA RID: 212218 RVA: 0x006F8FBD File Offset: 0x006F71BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033CFB RID: 212219 RVA: 0x006F8FCC File Offset: 0x006F71CC
		public ISubScreenModeInit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D8D6 RID: 55510
		// (get) Token: 0x06033CFC RID: 212220 RVA: 0x006F8FDC File Offset: 0x006F71DC
		public ESubScreenOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESubScreenOperationType.Init;
				}
				return (ESubScreenOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033CFD RID: 212221 RVA: 0x006F9018 File Offset: 0x006F7218
		public TSubScreenInitData InitConfigsType(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return TSubScreenInitData.NONE;
			}
			return (TSubScreenInitData)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700D8D7 RID: 55511
		// (get) Token: 0x06033CFE RID: 212222 RVA: 0x006F9058 File Offset: 0x006F7258
		public int InitConfigsTypeLength
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

		// Token: 0x06033CFF RID: 212223 RVA: 0x006F9083 File Offset: 0x006F7283
		public Span<TSubScreenInitData> GetInitConfigsTypeBytes()
		{
			return this.__p.__vector_as_span<TSubScreenInitData>(6, 1);
		}

		// Token: 0x06033D00 RID: 212224 RVA: 0x006F9094 File Offset: 0x006F7294
		public TSubScreenInitData[] GetInitConfigsTypeArray()
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TSubScreenInitData[] array = new TSubScreenInitData[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TSubScreenInitData)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06033D01 RID: 212225 RVA: 0x006F9100 File Offset: 0x006F7300
		public TTable? InitConfigs<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700D8D8 RID: 55512
		// (get) Token: 0x06033D02 RID: 212226 RVA: 0x006F9148 File Offset: 0x006F7348
		public int InitConfigsLength
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

		// Token: 0x06033D03 RID: 212227 RVA: 0x006F9173 File Offset: 0x006F7373
		public static Offset<ISubScreenModeInit> CreateISubScreenModeInit(FlatBufferBuilder builder, ESubScreenOperationType Type = ESubScreenOperationType.Init, VectorOffset InitConfigs_typeOffset = default(VectorOffset), VectorOffset InitConfigsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ISubScreenModeInit.AddInitConfigs(builder, InitConfigsOffset);
			ISubScreenModeInit.AddInitConfigsType(builder, InitConfigs_typeOffset);
			ISubScreenModeInit.AddType(builder, Type);
			return ISubScreenModeInit.EndISubScreenModeInit(builder);
		}

		// Token: 0x06033D04 RID: 212228 RVA: 0x006F9197 File Offset: 0x006F7397
		public static void StartISubScreenModeInit(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06033D05 RID: 212229 RVA: 0x006F91A0 File Offset: 0x006F73A0
		public static void AddType(FlatBufferBuilder builder, ESubScreenOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033D06 RID: 212230 RVA: 0x006F91AB File Offset: 0x006F73AB
		public static void AddInitConfigsType(FlatBufferBuilder builder, VectorOffset initConfigsTypeOffset)
		{
			builder.AddOffset(1, initConfigsTypeOffset.Value, 0);
		}

		// Token: 0x06033D07 RID: 212231 RVA: 0x006F91BC File Offset: 0x006F73BC
		public static VectorOffset CreateInitConfigsTypeVector(FlatBufferBuilder builder, TSubScreenInitData[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06033D08 RID: 212232 RVA: 0x006F91F3 File Offset: 0x006F73F3
		public static VectorOffset CreateInitConfigsTypeVectorBlock(FlatBufferBuilder builder, TSubScreenInitData[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TSubScreenInitData>(data);
			return builder.EndVector();
		}

		// Token: 0x06033D09 RID: 212233 RVA: 0x006F920D File Offset: 0x006F740D
		public static VectorOffset CreateInitConfigsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TSubScreenInitData> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TSubScreenInitData>(data);
			return builder.EndVector();
		}

		// Token: 0x06033D0A RID: 212234 RVA: 0x006F922B File Offset: 0x006F742B
		public static VectorOffset CreateInitConfigsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TSubScreenInitData>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06033D0B RID: 212235 RVA: 0x006F9244 File Offset: 0x006F7444
		public static void StartInitConfigsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06033D0C RID: 212236 RVA: 0x006F924F File Offset: 0x006F744F
		public static void AddInitConfigs(FlatBufferBuilder builder, VectorOffset initConfigsOffset)
		{
			builder.AddOffset(2, initConfigsOffset.Value, 0);
		}

		// Token: 0x06033D0D RID: 212237 RVA: 0x006F9260 File Offset: 0x006F7460
		public static VectorOffset CreateInitConfigsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06033D0E RID: 212238 RVA: 0x006F9297 File Offset: 0x006F7497
		public static VectorOffset CreateInitConfigsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06033D0F RID: 212239 RVA: 0x006F92B1 File Offset: 0x006F74B1
		public static VectorOffset CreateInitConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06033D10 RID: 212240 RVA: 0x006F92CF File Offset: 0x006F74CF
		public static VectorOffset CreateInitConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06033D11 RID: 212241 RVA: 0x006F92E8 File Offset: 0x006F74E8
		public static void StartInitConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06033D12 RID: 212242 RVA: 0x006F92F3 File Offset: 0x006F74F3
		public static Offset<ISubScreenModeInit> EndISubScreenModeInit(FlatBufferBuilder builder)
		{
			return new Offset<ISubScreenModeInit>(builder.EndTable());
		}

		// Token: 0x06033D13 RID: 212243 RVA: 0x006F9300 File Offset: 0x006F7500
		public ISubScreenModeInitT UnPack()
		{
			ISubScreenModeInitT subScreenModeInitT = new ISubScreenModeInitT();
			this.UnPackTo(subScreenModeInitT);
			return subScreenModeInitT;
		}

		// Token: 0x06033D14 RID: 212244 RVA: 0x006F931C File Offset: 0x006F751C
		public void UnPackTo(ISubScreenModeInitT _o)
		{
			_o.Type = this.Type;
			_o.InitConfigs = new List<TSubScreenInitDataUnion>();
			for (int i = 0; i < this.InitConfigsLength; i++)
			{
				TSubScreenInitDataUnion tsubScreenInitDataUnion = new TSubScreenInitDataUnion();
				tsubScreenInitDataUnion.Type = this.InitConfigsType(i);
				TSubScreenInitData tsubScreenInitData = this.InitConfigsType(i);
				if (tsubScreenInitData != TSubScreenInitData.ISubScreenCustomInitData)
				{
					if (tsubScreenInitData == TSubScreenInitData.ISubScreenPresetInitData)
					{
						tsubScreenInitDataUnion.Value = ((this.InitConfigs<ISubScreenPresetInitData>(i) != null) ? this.InitConfigs<ISubScreenPresetInitData>(i).Value.UnPack() : null);
					}
				}
				else
				{
					tsubScreenInitDataUnion.Value = ((this.InitConfigs<ISubScreenCustomInitData>(i) != null) ? this.InitConfigs<ISubScreenCustomInitData>(i).Value.UnPack() : null);
				}
				_o.InitConfigs.Add(tsubScreenInitDataUnion);
			}
		}

		// Token: 0x06033D15 RID: 212245 RVA: 0x006F93F0 File Offset: 0x006F75F0
		public static Offset<ISubScreenModeInit> Pack(FlatBufferBuilder builder, ISubScreenModeInitT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISubScreenModeInit>);
			}
			VectorOffset initConfigs_typeOffset = default(VectorOffset);
			if (_o.InitConfigs != null)
			{
				TSubScreenInitData[] array = new TSubScreenInitData[_o.InitConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.InitConfigs[i].Type;
				}
				initConfigs_typeOffset = ISubScreenModeInit.CreateInitConfigsTypeVector(builder, array);
			}
			VectorOffset initConfigsOffset = default(VectorOffset);
			if (_o.InitConfigs != null)
			{
				int[] array2 = new int[_o.InitConfigs.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TSubScreenInitDataUnion.Pack(builder, _o.InitConfigs[j]);
				}
				initConfigsOffset = ISubScreenModeInit.CreateInitConfigsVector(builder, array2);
			}
			return ISubScreenModeInit.CreateISubScreenModeInit(builder, _o.Type, initConfigs_typeOffset, initConfigsOffset);
		}

		// Token: 0x04011D09 RID: 72969
		private Table __p;
	}
}
