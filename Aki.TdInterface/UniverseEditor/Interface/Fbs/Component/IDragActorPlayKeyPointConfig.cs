using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200561F RID: 22047
	public struct IDragActorPlayKeyPointConfig : IFlatbufferObject
	{
		// Token: 0x17009E3C RID: 40508
		// (get) Token: 0x060232E7 RID: 144103 RVA: 0x004D7A24 File Offset: 0x004D5C24
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060232E8 RID: 144104 RVA: 0x004D7A31 File Offset: 0x004D5C31
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060232E9 RID: 144105 RVA: 0x004D7A38 File Offset: 0x004D5C38
		public static IDragActorPlayKeyPointConfig GetRootAsIDragActorPlayKeyPointConfig(ByteBuffer _bb)
		{
			return IDragActorPlayKeyPointConfig.GetRootAsIDragActorPlayKeyPointConfig(_bb, default(IDragActorPlayKeyPointConfig));
		}

		// Token: 0x060232EA RID: 144106 RVA: 0x004D7A54 File Offset: 0x004D5C54
		public static IDragActorPlayKeyPointConfig GetRootAsIDragActorPlayKeyPointConfig(ByteBuffer _bb, IDragActorPlayKeyPointConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060232EB RID: 144107 RVA: 0x004D7A71 File Offset: 0x004D5C71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060232EC RID: 144108 RVA: 0x004D7A80 File Offset: 0x004D5C80
		public IDragActorPlayKeyPointConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009E3D RID: 40509
		// (get) Token: 0x060232ED RID: 144109 RVA: 0x004D7A90 File Offset: 0x004D5C90
		public IVectorInfo? Position
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009E3E RID: 40510
		// (get) Token: 0x060232EE RID: 144110 RVA: 0x004D7AF0 File Offset: 0x004D5CF0
		public float Radius
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009E3F RID: 40511
		// (get) Token: 0x060232EF RID: 144111 RVA: 0x004D7B30 File Offset: 0x004D5D30
		public bool IsSnapping
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009E40 RID: 40512
		// (get) Token: 0x060232F0 RID: 144112 RVA: 0x004D7B70 File Offset: 0x004D5D70
		public float SnapTime
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009E41 RID: 40513
		// (get) Token: 0x060232F1 RID: 144113 RVA: 0x004D7BB4 File Offset: 0x004D5DB4
		public string EnterSendSelfEvent
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060232F2 RID: 144114 RVA: 0x004D7BEC File Offset: 0x004D5DEC
		public Span<byte> GetEnterSendSelfEventBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060232F3 RID: 144115 RVA: 0x004D7BFC File Offset: 0x004D5DFC
		public byte[] GetEnterSendSelfEventArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x17009E42 RID: 40514
		// (get) Token: 0x060232F4 RID: 144116 RVA: 0x004D7C0C File Offset: 0x004D5E0C
		public string ExitSendSelfEvent
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060232F5 RID: 144117 RVA: 0x004D7C44 File Offset: 0x004D5E44
		public Span<byte> GetExitSendSelfEventBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060232F6 RID: 144118 RVA: 0x004D7C54 File Offset: 0x004D5E54
		public byte[] GetExitSendSelfEventArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x17009E43 RID: 40515
		// (get) Token: 0x060232F7 RID: 144119 RVA: 0x004D7C64 File Offset: 0x004D5E64
		public string ReleaseSendSelfEvent
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060232F8 RID: 144120 RVA: 0x004D7C9C File Offset: 0x004D5E9C
		public Span<byte> GetReleaseSendSelfEventBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060232F9 RID: 144121 RVA: 0x004D7CAC File Offset: 0x004D5EAC
		public byte[] GetReleaseSendSelfEventArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x060232FA RID: 144122 RVA: 0x004D7CBC File Offset: 0x004D5EBC
		public IActionInfo? ReleaseClientActions(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009E44 RID: 40516
		// (get) Token: 0x060232FB RID: 144123 RVA: 0x004D7D20 File Offset: 0x004D5F20
		public int ReleaseClientActionsLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17009E45 RID: 40517
		// (get) Token: 0x060232FC RID: 144124 RVA: 0x004D7D4C File Offset: 0x004D5F4C
		public IConditionGroup? Condition
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009E46 RID: 40518
		// (get) Token: 0x060232FD RID: 144125 RVA: 0x004D7DAC File Offset: 0x004D5FAC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060232FE RID: 144126 RVA: 0x004D7DEC File Offset: 0x004D5FEC
		public static Offset<IDragActorPlayKeyPointConfig> CreateIDragActorPlayKeyPointConfig(FlatBufferBuilder builder, Offset<IVectorInfo> PositionOffset = default(Offset<IVectorInfo>), float Radius = 0f, bool IsSnapping = false, float SnapTime = 0f, StringOffset EnterSendSelfEventOffset = default(StringOffset), StringOffset ExitSendSelfEventOffset = default(StringOffset), StringOffset ReleaseSendSelfEventOffset = default(StringOffset), VectorOffset ReleaseClientActionsOffset = default(VectorOffset), Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), byte NullMask = 0)
		{
			builder.StartTable(10);
			IDragActorPlayKeyPointConfig.AddCondition(builder, ConditionOffset);
			IDragActorPlayKeyPointConfig.AddReleaseClientActions(builder, ReleaseClientActionsOffset);
			IDragActorPlayKeyPointConfig.AddReleaseSendSelfEvent(builder, ReleaseSendSelfEventOffset);
			IDragActorPlayKeyPointConfig.AddExitSendSelfEvent(builder, ExitSendSelfEventOffset);
			IDragActorPlayKeyPointConfig.AddEnterSendSelfEvent(builder, EnterSendSelfEventOffset);
			IDragActorPlayKeyPointConfig.AddSnapTime(builder, SnapTime);
			IDragActorPlayKeyPointConfig.AddRadius(builder, Radius);
			IDragActorPlayKeyPointConfig.AddPosition(builder, PositionOffset);
			IDragActorPlayKeyPointConfig.AddNullMask(builder, NullMask);
			IDragActorPlayKeyPointConfig.AddIsSnapping(builder, IsSnapping);
			return IDragActorPlayKeyPointConfig.EndIDragActorPlayKeyPointConfig(builder);
		}

		// Token: 0x060232FF RID: 144127 RVA: 0x004D7E54 File Offset: 0x004D6054
		public static void StartIDragActorPlayKeyPointConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x06023300 RID: 144128 RVA: 0x004D7E5E File Offset: 0x004D605E
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(0, positionOffset.Value, 0);
		}

		// Token: 0x06023301 RID: 144129 RVA: 0x004D7E6E File Offset: 0x004D606E
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
			builder.AddFloat(1, radius, 0.0);
		}

		// Token: 0x06023302 RID: 144130 RVA: 0x004D7E81 File Offset: 0x004D6081
		public static void AddIsSnapping(FlatBufferBuilder builder, bool isSnapping)
		{
			builder.AddBool(2, isSnapping, false);
		}

		// Token: 0x06023303 RID: 144131 RVA: 0x004D7E8C File Offset: 0x004D608C
		public static void AddSnapTime(FlatBufferBuilder builder, float snapTime)
		{
			builder.AddFloat(3, snapTime, 0.0);
		}

		// Token: 0x06023304 RID: 144132 RVA: 0x004D7E9F File Offset: 0x004D609F
		public static void AddEnterSendSelfEvent(FlatBufferBuilder builder, StringOffset enterSendSelfEventOffset)
		{
			builder.AddOffset(4, enterSendSelfEventOffset.Value, 0);
		}

		// Token: 0x06023305 RID: 144133 RVA: 0x004D7EAF File Offset: 0x004D60AF
		public static void AddExitSendSelfEvent(FlatBufferBuilder builder, StringOffset exitSendSelfEventOffset)
		{
			builder.AddOffset(5, exitSendSelfEventOffset.Value, 0);
		}

		// Token: 0x06023306 RID: 144134 RVA: 0x004D7EBF File Offset: 0x004D60BF
		public static void AddReleaseSendSelfEvent(FlatBufferBuilder builder, StringOffset releaseSendSelfEventOffset)
		{
			builder.AddOffset(6, releaseSendSelfEventOffset.Value, 0);
		}

		// Token: 0x06023307 RID: 144135 RVA: 0x004D7ECF File Offset: 0x004D60CF
		public static void AddReleaseClientActions(FlatBufferBuilder builder, VectorOffset releaseClientActionsOffset)
		{
			builder.AddOffset(7, releaseClientActionsOffset.Value, 0);
		}

		// Token: 0x06023308 RID: 144136 RVA: 0x004D7EE0 File Offset: 0x004D60E0
		public static VectorOffset CreateReleaseClientActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023309 RID: 144137 RVA: 0x004D7F20 File Offset: 0x004D6120
		public static VectorOffset CreateReleaseClientActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602330A RID: 144138 RVA: 0x004D7F3A File Offset: 0x004D613A
		public static VectorOffset CreateReleaseClientActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602330B RID: 144139 RVA: 0x004D7F58 File Offset: 0x004D6158
		public static VectorOffset CreateReleaseClientActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602330C RID: 144140 RVA: 0x004D7F71 File Offset: 0x004D6171
		public static void StartReleaseClientActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602330D RID: 144141 RVA: 0x004D7F7C File Offset: 0x004D617C
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(8, conditionOffset.Value, 0);
		}

		// Token: 0x0602330E RID: 144142 RVA: 0x004D7F8C File Offset: 0x004D618C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x0602330F RID: 144143 RVA: 0x004D7F98 File Offset: 0x004D6198
		public static Offset<IDragActorPlayKeyPointConfig> EndIDragActorPlayKeyPointConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDragActorPlayKeyPointConfig>(builder.EndTable());
		}

		// Token: 0x06023310 RID: 144144 RVA: 0x004D7FA8 File Offset: 0x004D61A8
		public IDragActorPlayKeyPointConfigT UnPack()
		{
			IDragActorPlayKeyPointConfigT dragActorPlayKeyPointConfigT = new IDragActorPlayKeyPointConfigT();
			this.UnPackTo(dragActorPlayKeyPointConfigT);
			return dragActorPlayKeyPointConfigT;
		}

		// Token: 0x06023311 RID: 144145 RVA: 0x004D7FC4 File Offset: 0x004D61C4
		public void UnPackTo(IDragActorPlayKeyPointConfigT _o)
		{
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
			_o.Radius = this.Radius;
			_o.IsSnapping = this.IsSnapping;
			_o.SnapTime = this.SnapTime;
			_o.EnterSendSelfEvent = this.EnterSendSelfEvent;
			_o.ExitSendSelfEvent = this.ExitSendSelfEvent;
			_o.ReleaseSendSelfEvent = this.ReleaseSendSelfEvent;
			_o.ReleaseClientActions = new List<IActionInfoT>();
			for (int i = 0; i < this.ReleaseClientActionsLength; i++)
			{
				_o.ReleaseClientActions.Add((this.ReleaseClientActions(i) != null) ? this.ReleaseClientActions(i).Value.UnPack() : null);
			}
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023312 RID: 144146 RVA: 0x004D80DC File Offset: 0x004D62DC
		public static Offset<IDragActorPlayKeyPointConfig> Pack(FlatBufferBuilder builder, IDragActorPlayKeyPointConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDragActorPlayKeyPointConfig>);
			}
			Offset<IVectorInfo> positionOffset = (_o.Position == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Position);
			StringOffset enterSendSelfEventOffset = (_o.EnterSendSelfEvent == null) ? default(StringOffset) : builder.CreateString(_o.EnterSendSelfEvent);
			StringOffset exitSendSelfEventOffset = (_o.ExitSendSelfEvent == null) ? default(StringOffset) : builder.CreateString(_o.ExitSendSelfEvent);
			StringOffset releaseSendSelfEventOffset = (_o.ReleaseSendSelfEvent == null) ? default(StringOffset) : builder.CreateString(_o.ReleaseSendSelfEvent);
			VectorOffset releaseClientActionsOffset = default(VectorOffset);
			if (_o.ReleaseClientActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.ReleaseClientActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.ReleaseClientActions[i]);
				}
				releaseClientActionsOffset = IDragActorPlayKeyPointConfig.CreateReleaseClientActionsVector(builder, array);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			return IDragActorPlayKeyPointConfig.CreateIDragActorPlayKeyPointConfig(builder, positionOffset, _o.Radius, _o.IsSnapping, _o.SnapTime, enterSendSelfEventOffset, exitSendSelfEventOffset, releaseSendSelfEventOffset, releaseClientActionsOffset, conditionOffset, _o.NullMask);
		}

		// Token: 0x0400ECF0 RID: 60656
		private Table __p;
	}
}
