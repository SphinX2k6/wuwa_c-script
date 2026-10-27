using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AFC RID: 23292
	public struct IUndergroundComponent : IFlatbufferObject
	{
		// Token: 0x1700AFB3 RID: 44979
		// (get) Token: 0x06027C2E RID: 162862 RVA: 0x005780E4 File Offset: 0x005762E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027C2F RID: 162863 RVA: 0x005780F1 File Offset: 0x005762F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027C30 RID: 162864 RVA: 0x005780F8 File Offset: 0x005762F8
		public static IUndergroundComponent GetRootAsIUndergroundComponent(ByteBuffer _bb)
		{
			return IUndergroundComponent.GetRootAsIUndergroundComponent(_bb, default(IUndergroundComponent));
		}

		// Token: 0x06027C31 RID: 162865 RVA: 0x00578114 File Offset: 0x00576314
		public static IUndergroundComponent GetRootAsIUndergroundComponent(ByteBuffer _bb, IUndergroundComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027C32 RID: 162866 RVA: 0x00578131 File Offset: 0x00576331
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027C33 RID: 162867 RVA: 0x00578140 File Offset: 0x00576340
		public IUndergroundComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AFB4 RID: 44980
		// (get) Token: 0x06027C34 RID: 162868 RVA: 0x00578150 File Offset: 0x00576350
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AFB5 RID: 44981
		// (get) Token: 0x06027C35 RID: 162869 RVA: 0x00578190 File Offset: 0x00576390
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

		// Token: 0x1700AFB6 RID: 44982
		// (get) Token: 0x06027C36 RID: 162870 RVA: 0x005781CC File Offset: 0x005763CC
		public bool IsRestartPlayer
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06027C37 RID: 162871 RVA: 0x0057820C File Offset: 0x0057640C
		public string DestroyTag(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700AFB7 RID: 44983
		// (get) Token: 0x06027C38 RID: 162872 RVA: 0x00578248 File Offset: 0x00576448
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

		// Token: 0x06027C39 RID: 162873 RVA: 0x00578274 File Offset: 0x00576474
		public IUndergroundStateInfo? StateInfo(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IUndergroundStateInfo?(default(IUndergroundStateInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AFB8 RID: 44984
		// (get) Token: 0x06027C3A RID: 162874 RVA: 0x005782D8 File Offset: 0x005764D8
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

		// Token: 0x1700AFB9 RID: 44985
		// (get) Token: 0x06027C3B RID: 162875 RVA: 0x00578304 File Offset: 0x00576504
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

		// Token: 0x06027C3C RID: 162876 RVA: 0x00578341 File Offset: 0x00576541
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

		// Token: 0x06027C3D RID: 162877 RVA: 0x0057837D File Offset: 0x0057657D
		public static void StartIUndergroundComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06027C3E RID: 162878 RVA: 0x00578386 File Offset: 0x00576586
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06027C3F RID: 162879 RVA: 0x00578391 File Offset: 0x00576591
		public static void AddTestState(FlatBufferBuilder builder, int testState)
		{
			builder.AddInt(1, testState, 0);
		}

		// Token: 0x06027C40 RID: 162880 RVA: 0x0057839C File Offset: 0x0057659C
		public static void AddIsRestartPlayer(FlatBufferBuilder builder, bool isRestartPlayer)
		{
			builder.AddBool(2, isRestartPlayer, false);
		}

		// Token: 0x06027C41 RID: 162881 RVA: 0x005783A7 File Offset: 0x005765A7
		public static void AddDestroyTag(FlatBufferBuilder builder, VectorOffset destroyTagOffset)
		{
			builder.AddOffset(3, destroyTagOffset.Value, 0);
		}

		// Token: 0x06027C42 RID: 162882 RVA: 0x005783B8 File Offset: 0x005765B8
		public static VectorOffset CreateDestroyTagVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027C43 RID: 162883 RVA: 0x005783F8 File Offset: 0x005765F8
		public static VectorOffset CreateDestroyTagVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06027C44 RID: 162884 RVA: 0x00578412 File Offset: 0x00576612
		public static VectorOffset CreateDestroyTagVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06027C45 RID: 162885 RVA: 0x00578430 File Offset: 0x00576630
		public static VectorOffset CreateDestroyTagVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027C46 RID: 162886 RVA: 0x00578449 File Offset: 0x00576649
		public static void StartDestroyTagVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027C47 RID: 162887 RVA: 0x00578454 File Offset: 0x00576654
		public static void AddStateInfo(FlatBufferBuilder builder, VectorOffset stateInfoOffset)
		{
			builder.AddOffset(4, stateInfoOffset.Value, 0);
		}

		// Token: 0x06027C48 RID: 162888 RVA: 0x00578464 File Offset: 0x00576664
		public static VectorOffset CreateStateInfoVector(FlatBufferBuilder builder, Offset<IUndergroundStateInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027C49 RID: 162889 RVA: 0x005784A4 File Offset: 0x005766A4
		public static VectorOffset CreateStateInfoVectorBlock(FlatBufferBuilder builder, Offset<IUndergroundStateInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IUndergroundStateInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027C4A RID: 162890 RVA: 0x005784BE File Offset: 0x005766BE
		public static VectorOffset CreateStateInfoVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IUndergroundStateInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IUndergroundStateInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027C4B RID: 162891 RVA: 0x005784DC File Offset: 0x005766DC
		public static VectorOffset CreateStateInfoVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IUndergroundStateInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027C4C RID: 162892 RVA: 0x005784F5 File Offset: 0x005766F5
		public static void StartStateInfoVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027C4D RID: 162893 RVA: 0x00578500 File Offset: 0x00576700
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06027C4E RID: 162894 RVA: 0x0057850B File Offset: 0x0057670B
		public static Offset<IUndergroundComponent> EndIUndergroundComponent(FlatBufferBuilder builder)
		{
			return new Offset<IUndergroundComponent>(builder.EndTable());
		}

		// Token: 0x06027C4F RID: 162895 RVA: 0x00578518 File Offset: 0x00576718
		public IUndergroundComponentT UnPack()
		{
			IUndergroundComponentT undergroundComponentT = new IUndergroundComponentT();
			this.UnPackTo(undergroundComponentT);
			return undergroundComponentT;
		}

		// Token: 0x06027C50 RID: 162896 RVA: 0x00578534 File Offset: 0x00576734
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

		// Token: 0x06027C51 RID: 162897 RVA: 0x005785F4 File Offset: 0x005767F4
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

		// Token: 0x0400F1FB RID: 61947
		private Table __p;
	}
}
