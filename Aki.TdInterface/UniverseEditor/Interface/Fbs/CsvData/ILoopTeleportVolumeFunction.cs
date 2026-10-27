using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004914 RID: 18708
	public struct ILoopTeleportVolumeFunction : IFlatbufferObject
	{
		// Token: 0x170087A0 RID: 34720
		// (get) Token: 0x0601D3F4 RID: 119796 RVA: 0x00420139 File Offset: 0x0041E339
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D3F5 RID: 119797 RVA: 0x00420146 File Offset: 0x0041E346
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D3F6 RID: 119798 RVA: 0x00420150 File Offset: 0x0041E350
		public static ILoopTeleportVolumeFunction GetRootAsILoopTeleportVolumeFunction(ByteBuffer _bb)
		{
			return ILoopTeleportVolumeFunction.GetRootAsILoopTeleportVolumeFunction(_bb, default(ILoopTeleportVolumeFunction));
		}

		// Token: 0x0601D3F7 RID: 119799 RVA: 0x0042016C File Offset: 0x0041E36C
		public static ILoopTeleportVolumeFunction GetRootAsILoopTeleportVolumeFunction(ByteBuffer _bb, ILoopTeleportVolumeFunction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D3F8 RID: 119800 RVA: 0x00420189 File Offset: 0x0041E389
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D3F9 RID: 119801 RVA: 0x00420198 File Offset: 0x0041E398
		public ILoopTeleportVolumeFunction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170087A1 RID: 34721
		// (get) Token: 0x0601D3FA RID: 119802 RVA: 0x004201A8 File Offset: 0x0041E3A8
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

		// Token: 0x170087A2 RID: 34722
		// (get) Token: 0x0601D3FB RID: 119803 RVA: 0x004201E4 File Offset: 0x0041E3E4
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

		// Token: 0x0601D3FC RID: 119804 RVA: 0x0042021B File Offset: 0x0041E41B
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601D3FD RID: 119805 RVA: 0x0042022A File Offset: 0x0041E42A
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x170087A3 RID: 34723
		// (get) Token: 0x0601D3FE RID: 119806 RVA: 0x00420238 File Offset: 0x0041E438
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

		// Token: 0x170087A4 RID: 34724
		// (get) Token: 0x0601D3FF RID: 119807 RVA: 0x00420274 File Offset: 0x0041E474
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

		// Token: 0x170087A5 RID: 34725
		// (get) Token: 0x0601D400 RID: 119808 RVA: 0x004202B4 File Offset: 0x0041E4B4
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

		// Token: 0x0601D401 RID: 119809 RVA: 0x00420314 File Offset: 0x0041E514
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170087A6 RID: 34726
		// (get) Token: 0x0601D402 RID: 119810 RVA: 0x00420378 File Offset: 0x0041E578
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

		// Token: 0x0601D403 RID: 119811 RVA: 0x004203A4 File Offset: 0x0041E5A4
		public ILoopTeleportClientPlayEffectLogic? ClientLogic(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new ILoopTeleportClientPlayEffectLogic?(default(ILoopTeleportClientPlayEffectLogic).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170087A7 RID: 34727
		// (get) Token: 0x0601D404 RID: 119812 RVA: 0x00420408 File Offset: 0x0041E608
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

		// Token: 0x170087A8 RID: 34728
		// (get) Token: 0x0601D405 RID: 119813 RVA: 0x00420434 File Offset: 0x0041E634
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

		// Token: 0x0601D406 RID: 119814 RVA: 0x00420474 File Offset: 0x0041E674
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

		// Token: 0x0601D407 RID: 119815 RVA: 0x004204CB File Offset: 0x0041E6CB
		public static void StartILoopTeleportVolumeFunction(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0601D408 RID: 119816 RVA: 0x004204D4 File Offset: 0x0041E6D4
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601D409 RID: 119817 RVA: 0x004204DF File Offset: 0x0041E6DF
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(1, descOffset.Value, 0);
		}

		// Token: 0x0601D40A RID: 119818 RVA: 0x004204EF File Offset: 0x0041E6EF
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(2, dungeonId, 0);
		}

		// Token: 0x0601D40B RID: 119819 RVA: 0x004204FA File Offset: 0x0041E6FA
		public static void AddVolumeId(FlatBufferBuilder builder, int volumeId)
		{
			builder.AddInt(3, volumeId, 0);
		}

		// Token: 0x0601D40C RID: 119820 RVA: 0x00420505 File Offset: 0x0041E705
		public static void AddConditions(FlatBufferBuilder builder, Offset<IConditionGroup> conditionsOffset)
		{
			builder.AddOffset(4, conditionsOffset.Value, 0);
		}

		// Token: 0x0601D40D RID: 119821 RVA: 0x00420515 File Offset: 0x0041E715
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(5, actionsOffset.Value, 0);
		}

		// Token: 0x0601D40E RID: 119822 RVA: 0x00420528 File Offset: 0x0041E728
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D40F RID: 119823 RVA: 0x00420568 File Offset: 0x0041E768
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D410 RID: 119824 RVA: 0x00420582 File Offset: 0x0041E782
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D411 RID: 119825 RVA: 0x004205A0 File Offset: 0x0041E7A0
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D412 RID: 119826 RVA: 0x004205B9 File Offset: 0x0041E7B9
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D413 RID: 119827 RVA: 0x004205C4 File Offset: 0x0041E7C4
		public static void AddClientLogic(FlatBufferBuilder builder, VectorOffset clientLogicOffset)
		{
			builder.AddOffset(6, clientLogicOffset.Value, 0);
		}

		// Token: 0x0601D414 RID: 119828 RVA: 0x004205D4 File Offset: 0x0041E7D4
		public static VectorOffset CreateClientLogicVector(FlatBufferBuilder builder, Offset<ILoopTeleportClientPlayEffectLogic>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D415 RID: 119829 RVA: 0x00420614 File Offset: 0x0041E814
		public static VectorOffset CreateClientLogicVectorBlock(FlatBufferBuilder builder, Offset<ILoopTeleportClientPlayEffectLogic>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ILoopTeleportClientPlayEffectLogic>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D416 RID: 119830 RVA: 0x0042062E File Offset: 0x0041E82E
		public static VectorOffset CreateClientLogicVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ILoopTeleportClientPlayEffectLogic>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ILoopTeleportClientPlayEffectLogic>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D417 RID: 119831 RVA: 0x0042064C File Offset: 0x0041E84C
		public static VectorOffset CreateClientLogicVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ILoopTeleportClientPlayEffectLogic>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D418 RID: 119832 RVA: 0x00420665 File Offset: 0x0041E865
		public static void StartClientLogicVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D419 RID: 119833 RVA: 0x00420670 File Offset: 0x0041E870
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x0601D41A RID: 119834 RVA: 0x0042067B File Offset: 0x0041E87B
		public static Offset<ILoopTeleportVolumeFunction> EndILoopTeleportVolumeFunction(FlatBufferBuilder builder)
		{
			return new Offset<ILoopTeleportVolumeFunction>(builder.EndTable());
		}

		// Token: 0x0601D41B RID: 119835 RVA: 0x00420688 File Offset: 0x0041E888
		public ILoopTeleportVolumeFunctionT UnPack()
		{
			ILoopTeleportVolumeFunctionT loopTeleportVolumeFunctionT = new ILoopTeleportVolumeFunctionT();
			this.UnPackTo(loopTeleportVolumeFunctionT);
			return loopTeleportVolumeFunctionT;
		}

		// Token: 0x0601D41C RID: 119836 RVA: 0x004206A4 File Offset: 0x0041E8A4
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

		// Token: 0x0601D41D RID: 119837 RVA: 0x004207CC File Offset: 0x0041E9CC
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

		// Token: 0x0400CF88 RID: 53128
		private Table __p;
	}
}
