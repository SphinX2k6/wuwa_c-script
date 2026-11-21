using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079EF RID: 31215
	public struct ISubScreenModeInit : IFlatbufferObject
	{
		// Token: 0x1700E4CE RID: 58574
		// (get) Token: 0x06036FF8 RID: 225272 RVA: 0x0075A2D0 File Offset: 0x007584D0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036FF9 RID: 225273 RVA: 0x0075A2DD File Offset: 0x007584DD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036FFA RID: 225274 RVA: 0x0075A2E4 File Offset: 0x007584E4
		public static ISubScreenModeInit GetRootAsISubScreenModeInit(ByteBuffer _bb)
		{
			return ISubScreenModeInit.GetRootAsISubScreenModeInit(_bb, default(ISubScreenModeInit));
		}

		// Token: 0x06036FFB RID: 225275 RVA: 0x0075A300 File Offset: 0x00758500
		public static ISubScreenModeInit GetRootAsISubScreenModeInit(ByteBuffer _bb, ISubScreenModeInit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036FFC RID: 225276 RVA: 0x0075A31D File Offset: 0x0075851D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036FFD RID: 225277 RVA: 0x0075A32C File Offset: 0x0075852C
		public ISubScreenModeInit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E4CF RID: 58575
		// (get) Token: 0x06036FFE RID: 225278 RVA: 0x0075A33C File Offset: 0x0075853C
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

		// Token: 0x06036FFF RID: 225279 RVA: 0x0075A378 File Offset: 0x00758578
		public TSubScreenInitData InitConfigsType(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return TSubScreenInitData.NONE;
			}
			return (TSubScreenInitData)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700E4D0 RID: 58576
		// (get) Token: 0x06037000 RID: 225280 RVA: 0x0075A3B8 File Offset: 0x007585B8
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

		// Token: 0x06037001 RID: 225281 RVA: 0x0075A3E3 File Offset: 0x007585E3
		public Span<TSubScreenInitData> GetInitConfigsTypeBytes()
		{
			return this.__p.__vector_as_span<TSubScreenInitData>(6, 1);
		}

		// Token: 0x06037002 RID: 225282 RVA: 0x0075A3F4 File Offset: 0x007585F4
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

		// Token: 0x06037003 RID: 225283 RVA: 0x0075A460 File Offset: 0x00758660
		public TTable? InitConfigs<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700E4D1 RID: 58577
		// (get) Token: 0x06037004 RID: 225284 RVA: 0x0075A4A8 File Offset: 0x007586A8
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

		// Token: 0x06037005 RID: 225285 RVA: 0x0075A4D3 File Offset: 0x007586D3
		public static Offset<ISubScreenModeInit> CreateISubScreenModeInit(FlatBufferBuilder builder, ESubScreenOperationType Type = ESubScreenOperationType.Init, VectorOffset InitConfigs_typeOffset = default(VectorOffset), VectorOffset InitConfigsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ISubScreenModeInit.AddInitConfigs(builder, InitConfigsOffset);
			ISubScreenModeInit.AddInitConfigsType(builder, InitConfigs_typeOffset);
			ISubScreenModeInit.AddType(builder, Type);
			return ISubScreenModeInit.EndISubScreenModeInit(builder);
		}

		// Token: 0x06037006 RID: 225286 RVA: 0x0075A4F7 File Offset: 0x007586F7
		public static void StartISubScreenModeInit(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06037007 RID: 225287 RVA: 0x0075A500 File Offset: 0x00758700
		public static void AddType(FlatBufferBuilder builder, ESubScreenOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06037008 RID: 225288 RVA: 0x0075A50B File Offset: 0x0075870B
		public static void AddInitConfigsType(FlatBufferBuilder builder, VectorOffset initConfigsTypeOffset)
		{
			builder.AddOffset(1, initConfigsTypeOffset.Value, 0);
		}

		// Token: 0x06037009 RID: 225289 RVA: 0x0075A51C File Offset: 0x0075871C
		public static VectorOffset CreateInitConfigsTypeVector(FlatBufferBuilder builder, TSubScreenInitData[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0603700A RID: 225290 RVA: 0x0075A553 File Offset: 0x00758753
		public static VectorOffset CreateInitConfigsTypeVectorBlock(FlatBufferBuilder builder, TSubScreenInitData[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TSubScreenInitData>(data);
			return builder.EndVector();
		}

		// Token: 0x0603700B RID: 225291 RVA: 0x0075A56D File Offset: 0x0075876D
		public static VectorOffset CreateInitConfigsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TSubScreenInitData> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TSubScreenInitData>(data);
			return builder.EndVector();
		}

		// Token: 0x0603700C RID: 225292 RVA: 0x0075A58B File Offset: 0x0075878B
		public static VectorOffset CreateInitConfigsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TSubScreenInitData>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603700D RID: 225293 RVA: 0x0075A5A4 File Offset: 0x007587A4
		public static void StartInitConfigsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0603700E RID: 225294 RVA: 0x0075A5AF File Offset: 0x007587AF
		public static void AddInitConfigs(FlatBufferBuilder builder, VectorOffset initConfigsOffset)
		{
			builder.AddOffset(2, initConfigsOffset.Value, 0);
		}

		// Token: 0x0603700F RID: 225295 RVA: 0x0075A5C0 File Offset: 0x007587C0
		public static VectorOffset CreateInitConfigsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06037010 RID: 225296 RVA: 0x0075A5F7 File Offset: 0x007587F7
		public static VectorOffset CreateInitConfigsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06037011 RID: 225297 RVA: 0x0075A611 File Offset: 0x00758811
		public static VectorOffset CreateInitConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06037012 RID: 225298 RVA: 0x0075A62F File Offset: 0x0075882F
		public static VectorOffset CreateInitConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06037013 RID: 225299 RVA: 0x0075A648 File Offset: 0x00758848
		public static void StartInitConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06037014 RID: 225300 RVA: 0x0075A653 File Offset: 0x00758853
		public static Offset<ISubScreenModeInit> EndISubScreenModeInit(FlatBufferBuilder builder)
		{
			return new Offset<ISubScreenModeInit>(builder.EndTable());
		}

		// Token: 0x06037015 RID: 225301 RVA: 0x0075A660 File Offset: 0x00758860
		public ISubScreenModeInitT UnPack()
		{
			ISubScreenModeInitT subScreenModeInitT = new ISubScreenModeInitT();
			this.UnPackTo(subScreenModeInitT);
			return subScreenModeInitT;
		}

		// Token: 0x06037016 RID: 225302 RVA: 0x0075A67C File Offset: 0x0075887C
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

		// Token: 0x06037017 RID: 225303 RVA: 0x0075A750 File Offset: 0x00758950
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

		// Token: 0x04012D0B RID: 77067
		private Table __p;
	}
}
