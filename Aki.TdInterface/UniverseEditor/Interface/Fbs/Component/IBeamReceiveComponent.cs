using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F10 RID: 20240
	public struct IBeamReceiveComponent : IFlatbufferObject
	{
		// Token: 0x170091B3 RID: 37299
		// (get) Token: 0x0601FFD4 RID: 131028 RVA: 0x00473993 File Offset: 0x00471B93
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FFD5 RID: 131029 RVA: 0x004739A0 File Offset: 0x00471BA0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FFD6 RID: 131030 RVA: 0x004739A8 File Offset: 0x00471BA8
		public static IBeamReceiveComponent GetRootAsIBeamReceiveComponent(ByteBuffer _bb)
		{
			return IBeamReceiveComponent.GetRootAsIBeamReceiveComponent(_bb, default(IBeamReceiveComponent));
		}

		// Token: 0x0601FFD7 RID: 131031 RVA: 0x004739C4 File Offset: 0x00471BC4
		public static IBeamReceiveComponent GetRootAsIBeamReceiveComponent(ByteBuffer _bb, IBeamReceiveComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FFD8 RID: 131032 RVA: 0x004739E1 File Offset: 0x00471BE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FFD9 RID: 131033 RVA: 0x004739F0 File Offset: 0x00471BF0
		public IBeamReceiveComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170091B4 RID: 37300
		// (get) Token: 0x0601FFDA RID: 131034 RVA: 0x00473A00 File Offset: 0x00471C00
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170091B5 RID: 37301
		// (get) Token: 0x0601FFDB RID: 131035 RVA: 0x00473A40 File Offset: 0x00471C40
		public string ReceiveTarget
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

		// Token: 0x0601FFDC RID: 131036 RVA: 0x00473A77 File Offset: 0x00471C77
		public Span<byte> GetReceiveTargetBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601FFDD RID: 131037 RVA: 0x00473A86 File Offset: 0x00471C86
		public byte[] GetReceiveTargetArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x170091B6 RID: 37302
		// (get) Token: 0x0601FFDE RID: 131038 RVA: 0x00473A94 File Offset: 0x00471C94
		public float Duration
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170091B7 RID: 37303
		// (get) Token: 0x0601FFDF RID: 131039 RVA: 0x00473AD4 File Offset: 0x00471CD4
		public IConditionGroup? ReceiveCondition
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601FFE0 RID: 131040 RVA: 0x00473B34 File Offset: 0x00471D34
		public IActionInfo? BeginActions(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170091B8 RID: 37304
		// (get) Token: 0x0601FFE1 RID: 131041 RVA: 0x00473B98 File Offset: 0x00471D98
		public int BeginActionsLength
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

		// Token: 0x0601FFE2 RID: 131042 RVA: 0x00473BC4 File Offset: 0x00471DC4
		public IActionInfo? CompleteActions(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170091B9 RID: 37305
		// (get) Token: 0x0601FFE3 RID: 131043 RVA: 0x00473C28 File Offset: 0x00471E28
		public int CompleteActionsLength
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

		// Token: 0x0601FFE4 RID: 131044 RVA: 0x00473C54 File Offset: 0x00471E54
		public IActionInfo? StopActions(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170091BA RID: 37306
		// (get) Token: 0x0601FFE5 RID: 131045 RVA: 0x00473CB8 File Offset: 0x00471EB8
		public int StopActionsLength
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

		// Token: 0x170091BB RID: 37307
		// (get) Token: 0x0601FFE6 RID: 131046 RVA: 0x00473CE4 File Offset: 0x00471EE4
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

		// Token: 0x0601FFE7 RID: 131047 RVA: 0x00473D24 File Offset: 0x00471F24
		public static Offset<IBeamReceiveComponent> CreateIBeamReceiveComponent(FlatBufferBuilder builder, bool Disabled = false, StringOffset ReceiveTargetOffset = default(StringOffset), float Duration = 0f, Offset<IConditionGroup> ReceiveConditionOffset = default(Offset<IConditionGroup>), VectorOffset BeginActionsOffset = default(VectorOffset), VectorOffset CompleteActionsOffset = default(VectorOffset), VectorOffset StopActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(8);
			IBeamReceiveComponent.AddStopActions(builder, StopActionsOffset);
			IBeamReceiveComponent.AddCompleteActions(builder, CompleteActionsOffset);
			IBeamReceiveComponent.AddBeginActions(builder, BeginActionsOffset);
			IBeamReceiveComponent.AddReceiveCondition(builder, ReceiveConditionOffset);
			IBeamReceiveComponent.AddDuration(builder, Duration);
			IBeamReceiveComponent.AddReceiveTarget(builder, ReceiveTargetOffset);
			IBeamReceiveComponent.AddNullMask(builder, NullMask);
			IBeamReceiveComponent.AddDisabled(builder, Disabled);
			return IBeamReceiveComponent.EndIBeamReceiveComponent(builder);
		}

		// Token: 0x0601FFE8 RID: 131048 RVA: 0x00473D7B File Offset: 0x00471F7B
		public static void StartIBeamReceiveComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0601FFE9 RID: 131049 RVA: 0x00473D84 File Offset: 0x00471F84
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0601FFEA RID: 131050 RVA: 0x00473D8F File Offset: 0x00471F8F
		public static void AddReceiveTarget(FlatBufferBuilder builder, StringOffset receiveTargetOffset)
		{
			builder.AddOffset(1, receiveTargetOffset.Value, 0);
		}

		// Token: 0x0601FFEB RID: 131051 RVA: 0x00473D9F File Offset: 0x00471F9F
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(2, duration, 0.0);
		}

		// Token: 0x0601FFEC RID: 131052 RVA: 0x00473DB2 File Offset: 0x00471FB2
		public static void AddReceiveCondition(FlatBufferBuilder builder, Offset<IConditionGroup> receiveConditionOffset)
		{
			builder.AddOffset(3, receiveConditionOffset.Value, 0);
		}

		// Token: 0x0601FFED RID: 131053 RVA: 0x00473DC2 File Offset: 0x00471FC2
		public static void AddBeginActions(FlatBufferBuilder builder, VectorOffset beginActionsOffset)
		{
			builder.AddOffset(4, beginActionsOffset.Value, 0);
		}

		// Token: 0x0601FFEE RID: 131054 RVA: 0x00473DD4 File Offset: 0x00471FD4
		public static VectorOffset CreateBeginActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601FFEF RID: 131055 RVA: 0x00473E14 File Offset: 0x00472014
		public static VectorOffset CreateBeginActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FFF0 RID: 131056 RVA: 0x00473E2E File Offset: 0x0047202E
		public static VectorOffset CreateBeginActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FFF1 RID: 131057 RVA: 0x00473E4C File Offset: 0x0047204C
		public static VectorOffset CreateBeginActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601FFF2 RID: 131058 RVA: 0x00473E65 File Offset: 0x00472065
		public static void StartBeginActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601FFF3 RID: 131059 RVA: 0x00473E70 File Offset: 0x00472070
		public static void AddCompleteActions(FlatBufferBuilder builder, VectorOffset completeActionsOffset)
		{
			builder.AddOffset(5, completeActionsOffset.Value, 0);
		}

		// Token: 0x0601FFF4 RID: 131060 RVA: 0x00473E80 File Offset: 0x00472080
		public static VectorOffset CreateCompleteActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601FFF5 RID: 131061 RVA: 0x00473EC0 File Offset: 0x004720C0
		public static VectorOffset CreateCompleteActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FFF6 RID: 131062 RVA: 0x00473EDA File Offset: 0x004720DA
		public static VectorOffset CreateCompleteActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FFF7 RID: 131063 RVA: 0x00473EF8 File Offset: 0x004720F8
		public static VectorOffset CreateCompleteActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601FFF8 RID: 131064 RVA: 0x00473F11 File Offset: 0x00472111
		public static void StartCompleteActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601FFF9 RID: 131065 RVA: 0x00473F1C File Offset: 0x0047211C
		public static void AddStopActions(FlatBufferBuilder builder, VectorOffset stopActionsOffset)
		{
			builder.AddOffset(6, stopActionsOffset.Value, 0);
		}

		// Token: 0x0601FFFA RID: 131066 RVA: 0x00473F2C File Offset: 0x0047212C
		public static VectorOffset CreateStopActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601FFFB RID: 131067 RVA: 0x00473F6C File Offset: 0x0047216C
		public static VectorOffset CreateStopActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FFFC RID: 131068 RVA: 0x00473F86 File Offset: 0x00472186
		public static VectorOffset CreateStopActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FFFD RID: 131069 RVA: 0x00473FA4 File Offset: 0x004721A4
		public static VectorOffset CreateStopActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601FFFE RID: 131070 RVA: 0x00473FBD File Offset: 0x004721BD
		public static void StartStopActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601FFFF RID: 131071 RVA: 0x00473FC8 File Offset: 0x004721C8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06020000 RID: 131072 RVA: 0x00473FD3 File Offset: 0x004721D3
		public static Offset<IBeamReceiveComponent> EndIBeamReceiveComponent(FlatBufferBuilder builder)
		{
			return new Offset<IBeamReceiveComponent>(builder.EndTable());
		}

		// Token: 0x06020001 RID: 131073 RVA: 0x00473FE0 File Offset: 0x004721E0
		public IBeamReceiveComponentT UnPack()
		{
			IBeamReceiveComponentT beamReceiveComponentT = new IBeamReceiveComponentT();
			this.UnPackTo(beamReceiveComponentT);
			return beamReceiveComponentT;
		}

		// Token: 0x06020002 RID: 131074 RVA: 0x00473FFC File Offset: 0x004721FC
		public void UnPackTo(IBeamReceiveComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.ReceiveTarget = this.ReceiveTarget;
			_o.Duration = this.Duration;
			_o.ReceiveCondition = ((this.ReceiveCondition != null) ? this.ReceiveCondition.Value.UnPack() : null);
			_o.BeginActions = new List<IActionInfoT>();
			for (int i = 0; i < this.BeginActionsLength; i++)
			{
				_o.BeginActions.Add((this.BeginActions(i) != null) ? this.BeginActions(i).Value.UnPack() : null);
			}
			_o.CompleteActions = new List<IActionInfoT>();
			for (int j = 0; j < this.CompleteActionsLength; j++)
			{
				_o.CompleteActions.Add((this.CompleteActions(j) != null) ? this.CompleteActions(j).Value.UnPack() : null);
			}
			_o.StopActions = new List<IActionInfoT>();
			for (int k = 0; k < this.StopActionsLength; k++)
			{
				_o.StopActions.Add((this.StopActions(k) != null) ? this.StopActions(k).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06020003 RID: 131075 RVA: 0x00474170 File Offset: 0x00472370
		public static Offset<IBeamReceiveComponent> Pack(FlatBufferBuilder builder, IBeamReceiveComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBeamReceiveComponent>);
			}
			StringOffset receiveTargetOffset = (_o.ReceiveTarget == null) ? default(StringOffset) : builder.CreateString(_o.ReceiveTarget);
			Offset<IConditionGroup> receiveConditionOffset = (_o.ReceiveCondition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.ReceiveCondition);
			VectorOffset beginActionsOffset = default(VectorOffset);
			if (_o.BeginActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.BeginActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.BeginActions[i]);
				}
				beginActionsOffset = IBeamReceiveComponent.CreateBeginActionsVector(builder, array);
			}
			VectorOffset completeActionsOffset = default(VectorOffset);
			if (_o.CompleteActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.CompleteActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.CompleteActions[j]);
				}
				completeActionsOffset = IBeamReceiveComponent.CreateCompleteActionsVector(builder, array2);
			}
			VectorOffset stopActionsOffset = default(VectorOffset);
			if (_o.StopActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.StopActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.StopActions[k]);
				}
				stopActionsOffset = IBeamReceiveComponent.CreateStopActionsVector(builder, array3);
			}
			return IBeamReceiveComponent.CreateIBeamReceiveComponent(builder, _o.Disabled, receiveTargetOffset, _o.Duration, receiveConditionOffset, beginActionsOffset, completeActionsOffset, stopActionsOffset, _o.NullMask);
		}

		// Token: 0x0400DD57 RID: 56663
		private Table __p;
	}
}
