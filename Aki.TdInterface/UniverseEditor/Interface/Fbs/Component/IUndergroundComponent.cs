using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006112 RID: 24850
	public struct IUndergroundComponent : IFlatbufferObject
	{
		// Token: 0x1700B8FB RID: 47355
		// (get) Token: 0x0602A1F2 RID: 172530 RVA: 0x005BFB38 File Offset: 0x005BDD38
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A1F3 RID: 172531 RVA: 0x005BFB45 File Offset: 0x005BDD45
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A1F4 RID: 172532 RVA: 0x005BFB4C File Offset: 0x005BDD4C
		public static IUndergroundComponent GetRootAsIUndergroundComponent(ByteBuffer _bb)
		{
			return IUndergroundComponent.GetRootAsIUndergroundComponent(_bb, default(IUndergroundComponent));
		}

		// Token: 0x0602A1F5 RID: 172533 RVA: 0x005BFB68 File Offset: 0x005BDD68
		public static IUndergroundComponent GetRootAsIUndergroundComponent(ByteBuffer _bb, IUndergroundComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A1F6 RID: 172534 RVA: 0x005BFB85 File Offset: 0x005BDD85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A1F7 RID: 172535 RVA: 0x005BFB94 File Offset: 0x005BDD94
		public IUndergroundComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B8FC RID: 47356
		// (get) Token: 0x0602A1F8 RID: 172536 RVA: 0x005BFBA4 File Offset: 0x005BDDA4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B8FD RID: 47357
		// (get) Token: 0x0602A1F9 RID: 172537 RVA: 0x005BFBE4 File Offset: 0x005BDDE4
		public int TestState
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B8FE RID: 47358
		// (get) Token: 0x0602A1FA RID: 172538 RVA: 0x005BFC20 File Offset: 0x005BDE20
		public bool IsRestartPlayer
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602A1FB RID: 172539 RVA: 0x005BFC60 File Offset: 0x005BDE60
		public string DestroyTag(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B8FF RID: 47359
		// (get) Token: 0x0602A1FC RID: 172540 RVA: 0x005BFC9C File Offset: 0x005BDE9C
		public int DestroyTagLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602A1FD RID: 172541 RVA: 0x005BFCC8 File Offset: 0x005BDEC8
		public IUndergroundStateInfo? StateInfo(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IUndergroundStateInfo?(default(IUndergroundStateInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B900 RID: 47360
		// (get) Token: 0x0602A1FE RID: 172542 RVA: 0x005BFD2C File Offset: 0x005BDF2C
		public int StateInfoLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700B901 RID: 47361
		// (get) Token: 0x0602A1FF RID: 172543 RVA: 0x005BFD58 File Offset: 0x005BDF58
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A200 RID: 172544 RVA: 0x005BFD95 File Offset: 0x005BDF95
		public static Offset<IUndergroundComponent> CreateIUndergroundComponent(FlatBufferBuilder builder, bool Disabled = false, int TestState = 0, bool IsRestartPlayer = false, VectorOffset DestroyTagOffset = default(VectorOffset), VectorOffset StateInfoOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			IUndergroundComponent.AddStateInfo(builder, StateInfoOffset);
			IUndergroundComponent.AddDestroyTag(builder, DestroyTagOffset);
			IUndergroundComponent.AddTestState(builder, TestState);
			IUndergroundComponent.AddNullMask(builder, NullMask);
			IUndergroundComponent.AddIsRestartPlayer(builder, IsRestartPlayer);
			IUndergroundComponent.AddDisabled(builder, Disabled);
			return IUndergroundComponent.EndIUndergroundComponent(builder);
		}

		// Token: 0x0602A201 RID: 172545 RVA: 0x005BFDD1 File Offset: 0x005BDFD1
		public static void StartIUndergroundComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602A202 RID: 172546 RVA: 0x005BFDDA File Offset: 0x005BDFDA
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602A203 RID: 172547 RVA: 0x005BFDE5 File Offset: 0x005BDFE5
		public static void AddTestState(FlatBufferBuilder builder, int testState)
		{
			builder.AddInt(1, testState, 0);
		}

		// Token: 0x0602A204 RID: 172548 RVA: 0x005BFDF0 File Offset: 0x005BDFF0
		public static void AddIsRestartPlayer(FlatBufferBuilder builder, bool isRestartPlayer)
		{
			builder.AddBool(2, isRestartPlayer, false);
		}

		// Token: 0x0602A205 RID: 172549 RVA: 0x005BFDFB File Offset: 0x005BDFFB
		public static void AddDestroyTag(FlatBufferBuilder builder, VectorOffset destroyTagOffset)
		{
			builder.AddOffset(3, destroyTagOffset.Value, 0);
		}

		// Token: 0x0602A206 RID: 172550 RVA: 0x005BFE0C File Offset: 0x005BE00C
		public static VectorOffset CreateDestroyTagVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A207 RID: 172551 RVA: 0x005BFE4C File Offset: 0x005BE04C
		public static VectorOffset CreateDestroyTagVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A208 RID: 172552 RVA: 0x005BFE66 File Offset: 0x005BE066
		public static VectorOffset CreateDestroyTagVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A209 RID: 172553 RVA: 0x005BFE84 File Offset: 0x005BE084
		public static VectorOffset CreateDestroyTagVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A20A RID: 172554 RVA: 0x005BFE9D File Offset: 0x005BE09D
		public static void StartDestroyTagVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602A20B RID: 172555 RVA: 0x005BFEA8 File Offset: 0x005BE0A8
		public static void AddStateInfo(FlatBufferBuilder builder, VectorOffset stateInfoOffset)
		{
			builder.AddOffset(4, stateInfoOffset.Value, 0);
		}

		// Token: 0x0602A20C RID: 172556 RVA: 0x005BFEB8 File Offset: 0x005BE0B8
		public static VectorOffset CreateStateInfoVector(FlatBufferBuilder builder, Offset<IUndergroundStateInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A20D RID: 172557 RVA: 0x005BFEF8 File Offset: 0x005BE0F8
		public static VectorOffset CreateStateInfoVectorBlock(FlatBufferBuilder builder, Offset<IUndergroundStateInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IUndergroundStateInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A20E RID: 172558 RVA: 0x005BFF12 File Offset: 0x005BE112
		public static VectorOffset CreateStateInfoVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IUndergroundStateInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IUndergroundStateInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A20F RID: 172559 RVA: 0x005BFF30 File Offset: 0x005BE130
		public static VectorOffset CreateStateInfoVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IUndergroundStateInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A210 RID: 172560 RVA: 0x005BFF49 File Offset: 0x005BE149
		public static void StartStateInfoVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602A211 RID: 172561 RVA: 0x005BFF54 File Offset: 0x005BE154
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602A212 RID: 172562 RVA: 0x005BFF5F File Offset: 0x005BE15F
		public static Offset<IUndergroundComponent> EndIUndergroundComponent(FlatBufferBuilder builder)
		{
			return new Offset<IUndergroundComponent>(builder.EndTable());
		}

		// Token: 0x0602A213 RID: 172563 RVA: 0x005BFF6C File Offset: 0x005BE16C
		public IUndergroundComponentT UnPack()
		{
			IUndergroundComponentT undergroundComponentT = new IUndergroundComponentT();
			this.UnPackTo(undergroundComponentT);
			return undergroundComponentT;
		}

		// Token: 0x0602A214 RID: 172564 RVA: 0x005BFF88 File Offset: 0x005BE188
		public void UnPackTo(IUndergroundComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.TestState = this.TestState;
			_o.IsRestartPlayer = this.IsRestartPlayer;
			_o.DestroyTag = new List<string>();
			for (int i = 0; i < this.DestroyTagLength; i++)
			{
				_o.DestroyTag.Add(this.DestroyTag(i));
			}
			_o.StateInfo = new List<IUndergroundStateInfoT>();
			for (int j = 0; j < this.StateInfoLength; j++)
			{
				_o.StateInfo.Add((this.StateInfo(j) != null) ? this.StateInfo(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602A215 RID: 172565 RVA: 0x005C0048 File Offset: 0x005BE248
		public static Offset<IUndergroundComponent> Pack(FlatBufferBuilder builder, IUndergroundComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUndergroundComponent>);
			}
			VectorOffset destroyTagOffset = default(VectorOffset);
			if (_o.DestroyTag != null)
			{
				StringOffset[] array = new StringOffset[_o.DestroyTag.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.DestroyTag[i]);
				}
				destroyTagOffset = IUndergroundComponent.CreateDestroyTagVector(builder, array);
			}
			VectorOffset stateInfoOffset = default(VectorOffset);
			if (_o.StateInfo != null)
			{
				Offset<IUndergroundStateInfo>[] array2 = new Offset<IUndergroundStateInfo>[_o.StateInfo.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IUndergroundStateInfo.Pack(builder, _o.StateInfo[j]);
				}
				stateInfoOffset = IUndergroundComponent.CreateStateInfoVector(builder, array2);
			}
			return IUndergroundComponent.CreateIUndergroundComponent(builder, _o.Disabled, _o.TestState, _o.IsRestartPlayer, destroyTagOffset, stateInfoOffset, _o.NullMask);
		}

		// Token: 0x0400FF01 RID: 65281
		private Table __p;
	}
}
