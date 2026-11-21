using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004DAF RID: 19887
	public struct ILoopTeleportVolumeFunction : IFlatbufferObject
	{
		// Token: 0x17008E43 RID: 36419
		// (get) Token: 0x0601ED8D RID: 126349 RVA: 0x0044F899 File Offset: 0x0044DA99
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601ED8E RID: 126350 RVA: 0x0044F8A6 File Offset: 0x0044DAA6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601ED8F RID: 126351 RVA: 0x0044F8B0 File Offset: 0x0044DAB0
		public static ILoopTeleportVolumeFunction GetRootAsILoopTeleportVolumeFunction(ByteBuffer _bb)
		{
			return ILoopTeleportVolumeFunction.GetRootAsILoopTeleportVolumeFunction(_bb, default(ILoopTeleportVolumeFunction));
		}

		// Token: 0x0601ED90 RID: 126352 RVA: 0x0044F8CC File Offset: 0x0044DACC
		public static ILoopTeleportVolumeFunction GetRootAsILoopTeleportVolumeFunction(ByteBuffer _bb, ILoopTeleportVolumeFunction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601ED91 RID: 126353 RVA: 0x0044F8E9 File Offset: 0x0044DAE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601ED92 RID: 126354 RVA: 0x0044F8F8 File Offset: 0x0044DAF8
		public ILoopTeleportVolumeFunction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E44 RID: 36420
		// (get) Token: 0x0601ED93 RID: 126355 RVA: 0x0044F908 File Offset: 0x0044DB08
		public int Id
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

		// Token: 0x17008E45 RID: 36421
		// (get) Token: 0x0601ED94 RID: 126356 RVA: 0x0044F944 File Offset: 0x0044DB44
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601ED95 RID: 126357 RVA: 0x0044F97B File Offset: 0x0044DB7B
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601ED96 RID: 126358 RVA: 0x0044F98A File Offset: 0x0044DB8A
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17008E46 RID: 36422
		// (get) Token: 0x0601ED97 RID: 126359 RVA: 0x0044F998 File Offset: 0x0044DB98
		public int DungeonId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008E47 RID: 36423
		// (get) Token: 0x0601ED98 RID: 126360 RVA: 0x0044F9D4 File Offset: 0x0044DBD4
		public int VolumeId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008E48 RID: 36424
		// (get) Token: 0x0601ED99 RID: 126361 RVA: 0x0044FA14 File Offset: 0x0044DC14
		public IConditionGroup? Conditions
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601ED9A RID: 126362 RVA: 0x0044FA74 File Offset: 0x0044DC74
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008E49 RID: 36425
		// (get) Token: 0x0601ED9B RID: 126363 RVA: 0x0044FAD8 File Offset: 0x0044DCD8
		public int ActionsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601ED9C RID: 126364 RVA: 0x0044FB04 File Offset: 0x0044DD04
		public ILoopTeleportClientPlayEffectLogic? ClientLogic(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new ILoopTeleportClientPlayEffectLogic?(default(ILoopTeleportClientPlayEffectLogic).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008E4A RID: 36426
		// (get) Token: 0x0601ED9D RID: 126365 RVA: 0x0044FB68 File Offset: 0x0044DD68
		public int ClientLogicLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17008E4B RID: 36427
		// (get) Token: 0x0601ED9E RID: 126366 RVA: 0x0044FB94 File Offset: 0x0044DD94
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601ED9F RID: 126367 RVA: 0x0044FBD4 File Offset: 0x0044DDD4
		public static Offset<ILoopTeleportVolumeFunction> CreateILoopTeleportVolumeFunction(FlatBufferBuilder builder, int Id = 0, StringOffset DescOffset = default(StringOffset), int DungeonId = 0, int VolumeId = 0, Offset<IConditionGroup> ConditionsOffset = default(Offset<IConditionGroup>), VectorOffset ActionsOffset = default(VectorOffset), VectorOffset ClientLogicOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(8);
			ILoopTeleportVolumeFunction.AddClientLogic(builder, ClientLogicOffset);
			ILoopTeleportVolumeFunction.AddActions(builder, ActionsOffset);
			ILoopTeleportVolumeFunction.AddConditions(builder, ConditionsOffset);
			ILoopTeleportVolumeFunction.AddVolumeId(builder, VolumeId);
			ILoopTeleportVolumeFunction.AddDungeonId(builder, DungeonId);
			ILoopTeleportVolumeFunction.AddDesc(builder, DescOffset);
			ILoopTeleportVolumeFunction.AddId(builder, Id);
			ILoopTeleportVolumeFunction.AddNullMask(builder, NullMask);
			return ILoopTeleportVolumeFunction.EndILoopTeleportVolumeFunction(builder);
		}

		// Token: 0x0601EDA0 RID: 126368 RVA: 0x0044FC2B File Offset: 0x0044DE2B
		public static void StartILoopTeleportVolumeFunction(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0601EDA1 RID: 126369 RVA: 0x0044FC34 File Offset: 0x0044DE34
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601EDA2 RID: 126370 RVA: 0x0044FC3F File Offset: 0x0044DE3F
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(1, descOffset.Value, 0);
		}

		// Token: 0x0601EDA3 RID: 126371 RVA: 0x0044FC4F File Offset: 0x0044DE4F
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(2, dungeonId, 0);
		}

		// Token: 0x0601EDA4 RID: 126372 RVA: 0x0044FC5A File Offset: 0x0044DE5A
		public static void AddVolumeId(FlatBufferBuilder builder, int volumeId)
		{
			builder.AddInt(3, volumeId, 0);
		}

		// Token: 0x0601EDA5 RID: 126373 RVA: 0x0044FC65 File Offset: 0x0044DE65
		public static void AddConditions(FlatBufferBuilder builder, Offset<IConditionGroup> conditionsOffset)
		{
			builder.AddOffset(4, conditionsOffset.Value, 0);
		}

		// Token: 0x0601EDA6 RID: 126374 RVA: 0x0044FC75 File Offset: 0x0044DE75
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(5, actionsOffset.Value, 0);
		}

		// Token: 0x0601EDA7 RID: 126375 RVA: 0x0044FC88 File Offset: 0x0044DE88
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601EDA8 RID: 126376 RVA: 0x0044FCC8 File Offset: 0x0044DEC8
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601EDA9 RID: 126377 RVA: 0x0044FCE2 File Offset: 0x0044DEE2
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601EDAA RID: 126378 RVA: 0x0044FD00 File Offset: 0x0044DF00
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601EDAB RID: 126379 RVA: 0x0044FD19 File Offset: 0x0044DF19
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601EDAC RID: 126380 RVA: 0x0044FD24 File Offset: 0x0044DF24
		public static void AddClientLogic(FlatBufferBuilder builder, VectorOffset clientLogicOffset)
		{
			builder.AddOffset(6, clientLogicOffset.Value, 0);
		}

		// Token: 0x0601EDAD RID: 126381 RVA: 0x0044FD34 File Offset: 0x0044DF34
		public static VectorOffset CreateClientLogicVector(FlatBufferBuilder builder, Offset<ILoopTeleportClientPlayEffectLogic>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601EDAE RID: 126382 RVA: 0x0044FD74 File Offset: 0x0044DF74
		public static VectorOffset CreateClientLogicVectorBlock(FlatBufferBuilder builder, Offset<ILoopTeleportClientPlayEffectLogic>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ILoopTeleportClientPlayEffectLogic>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601EDAF RID: 126383 RVA: 0x0044FD8E File Offset: 0x0044DF8E
		public static VectorOffset CreateClientLogicVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ILoopTeleportClientPlayEffectLogic>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ILoopTeleportClientPlayEffectLogic>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601EDB0 RID: 126384 RVA: 0x0044FDAC File Offset: 0x0044DFAC
		public static VectorOffset CreateClientLogicVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ILoopTeleportClientPlayEffectLogic>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601EDB1 RID: 126385 RVA: 0x0044FDC5 File Offset: 0x0044DFC5
		public static void StartClientLogicVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601EDB2 RID: 126386 RVA: 0x0044FDD0 File Offset: 0x0044DFD0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x0601EDB3 RID: 126387 RVA: 0x0044FDDB File Offset: 0x0044DFDB
		public static Offset<ILoopTeleportVolumeFunction> EndILoopTeleportVolumeFunction(FlatBufferBuilder builder)
		{
			return new Offset<ILoopTeleportVolumeFunction>(builder.EndTable());
		}

		// Token: 0x0601EDB4 RID: 126388 RVA: 0x0044FDE8 File Offset: 0x0044DFE8
		public ILoopTeleportVolumeFunctionT UnPack()
		{
			ILoopTeleportVolumeFunctionT loopTeleportVolumeFunctionT = new ILoopTeleportVolumeFunctionT();
			this.UnPackTo(loopTeleportVolumeFunctionT);
			return loopTeleportVolumeFunctionT;
		}

		// Token: 0x0601EDB5 RID: 126389 RVA: 0x0044FE04 File Offset: 0x0044E004
		public void UnPackTo(ILoopTeleportVolumeFunctionT _o)
		{
			_o.Id = this.Id;
			_o.Desc = this.Desc;
			_o.DungeonId = this.DungeonId;
			_o.VolumeId = this.VolumeId;
			_o.Conditions = ((this.Conditions != null) ? this.Conditions.Value.UnPack() : null);
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
			_o.ClientLogic = new List<ILoopTeleportClientPlayEffectLogicT>();
			for (int j = 0; j < this.ClientLogicLength; j++)
			{
				_o.ClientLogic.Add((this.ClientLogic(j) != null) ? this.ClientLogic(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601EDB6 RID: 126390 RVA: 0x0044FF2C File Offset: 0x0044E12C
		public static Offset<ILoopTeleportVolumeFunction> Pack(FlatBufferBuilder builder, ILoopTeleportVolumeFunctionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILoopTeleportVolumeFunction>);
			}
			StringOffset descOffset = (_o.Desc == null) ? default(StringOffset) : builder.CreateString(_o.Desc);
			Offset<IConditionGroup> conditionsOffset = (_o.Conditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Conditions);
			VectorOffset actionsOffset = default(VectorOffset);
			if (_o.Actions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.Actions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.Actions[i]);
				}
				actionsOffset = ILoopTeleportVolumeFunction.CreateActionsVector(builder, array);
			}
			VectorOffset clientLogicOffset = default(VectorOffset);
			if (_o.ClientLogic != null)
			{
				Offset<ILoopTeleportClientPlayEffectLogic>[] array2 = new Offset<ILoopTeleportClientPlayEffectLogic>[_o.ClientLogic.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = ILoopTeleportClientPlayEffectLogic.Pack(builder, _o.ClientLogic[j]);
				}
				clientLogicOffset = ILoopTeleportVolumeFunction.CreateClientLogicVector(builder, array2);
			}
			return ILoopTeleportVolumeFunction.CreateILoopTeleportVolumeFunction(builder, _o.Id, descOffset, _o.DungeonId, _o.VolumeId, conditionsOffset, actionsOffset, clientLogicOffset, _o.NullMask);
		}

		// Token: 0x0400DA13 RID: 55827
		private Table __p;
	}
}
