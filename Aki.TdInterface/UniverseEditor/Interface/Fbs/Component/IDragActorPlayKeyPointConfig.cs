using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050BA RID: 20666
	public struct IDragActorPlayKeyPointConfig : IFlatbufferObject
	{
		// Token: 0x1700964F RID: 38479
		// (get) Token: 0x06021393 RID: 136083 RVA: 0x0049DA98 File Offset: 0x0049BC98
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021394 RID: 136084 RVA: 0x0049DAA5 File Offset: 0x0049BCA5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021395 RID: 136085 RVA: 0x0049DAAC File Offset: 0x0049BCAC
		public static IDragActorPlayKeyPointConfig GetRootAsIDragActorPlayKeyPointConfig(ByteBuffer _bb)
		{
			return IDragActorPlayKeyPointConfig.GetRootAsIDragActorPlayKeyPointConfig(_bb, default(IDragActorPlayKeyPointConfig));
		}

		// Token: 0x06021396 RID: 136086 RVA: 0x0049DAC8 File Offset: 0x0049BCC8
		public static IDragActorPlayKeyPointConfig GetRootAsIDragActorPlayKeyPointConfig(ByteBuffer _bb, IDragActorPlayKeyPointConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021397 RID: 136087 RVA: 0x0049DAE5 File Offset: 0x0049BCE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021398 RID: 136088 RVA: 0x0049DAF4 File Offset: 0x0049BCF4
		public IDragActorPlayKeyPointConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009650 RID: 38480
		// (get) Token: 0x06021399 RID: 136089 RVA: 0x0049DB04 File Offset: 0x0049BD04
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

		// Token: 0x17009651 RID: 38481
		// (get) Token: 0x0602139A RID: 136090 RVA: 0x0049DB64 File Offset: 0x0049BD64
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

		// Token: 0x17009652 RID: 38482
		// (get) Token: 0x0602139B RID: 136091 RVA: 0x0049DBA4 File Offset: 0x0049BDA4
		public bool IsSnapping
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009653 RID: 38483
		// (get) Token: 0x0602139C RID: 136092 RVA: 0x0049DBE4 File Offset: 0x0049BDE4
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

		// Token: 0x17009654 RID: 38484
		// (get) Token: 0x0602139D RID: 136093 RVA: 0x0049DC28 File Offset: 0x0049BE28
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

		// Token: 0x0602139E RID: 136094 RVA: 0x0049DC60 File Offset: 0x0049BE60
		public Span<byte> GetEnterSendSelfEventBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0602139F RID: 136095 RVA: 0x0049DC70 File Offset: 0x0049BE70
		public byte[] GetEnterSendSelfEventArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x17009655 RID: 38485
		// (get) Token: 0x060213A0 RID: 136096 RVA: 0x0049DC80 File Offset: 0x0049BE80
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

		// Token: 0x060213A1 RID: 136097 RVA: 0x0049DCB8 File Offset: 0x0049BEB8
		public Span<byte> GetExitSendSelfEventBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060213A2 RID: 136098 RVA: 0x0049DCC8 File Offset: 0x0049BEC8
		public byte[] GetExitSendSelfEventArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x17009656 RID: 38486
		// (get) Token: 0x060213A3 RID: 136099 RVA: 0x0049DCD8 File Offset: 0x0049BED8
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

		// Token: 0x060213A4 RID: 136100 RVA: 0x0049DD10 File Offset: 0x0049BF10
		public Span<byte> GetReleaseSendSelfEventBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060213A5 RID: 136101 RVA: 0x0049DD20 File Offset: 0x0049BF20
		public byte[] GetReleaseSendSelfEventArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x060213A6 RID: 136102 RVA: 0x0049DD30 File Offset: 0x0049BF30
		public IActionInfo? ReleaseClientActions(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009657 RID: 38487
		// (get) Token: 0x060213A7 RID: 136103 RVA: 0x0049DD94 File Offset: 0x0049BF94
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

		// Token: 0x17009658 RID: 38488
		// (get) Token: 0x060213A8 RID: 136104 RVA: 0x0049DDC0 File Offset: 0x0049BFC0
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

		// Token: 0x17009659 RID: 38489
		// (get) Token: 0x060213A9 RID: 136105 RVA: 0x0049DE20 File Offset: 0x0049C020
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

		// Token: 0x060213AA RID: 136106 RVA: 0x0049DE60 File Offset: 0x0049C060
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

		// Token: 0x060213AB RID: 136107 RVA: 0x0049DEC8 File Offset: 0x0049C0C8
		public static void StartIDragActorPlayKeyPointConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x060213AC RID: 136108 RVA: 0x0049DED2 File Offset: 0x0049C0D2
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(0, positionOffset.Value, 0);
		}

		// Token: 0x060213AD RID: 136109 RVA: 0x0049DEE2 File Offset: 0x0049C0E2
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
			builder.AddFloat(1, radius, 0.0);
		}

		// Token: 0x060213AE RID: 136110 RVA: 0x0049DEF5 File Offset: 0x0049C0F5
		public static void AddIsSnapping(FlatBufferBuilder builder, bool isSnapping)
		{
			builder.AddBool(2, isSnapping, false);
		}

		// Token: 0x060213AF RID: 136111 RVA: 0x0049DF00 File Offset: 0x0049C100
		public static void AddSnapTime(FlatBufferBuilder builder, float snapTime)
		{
			builder.AddFloat(3, snapTime, 0.0);
		}

		// Token: 0x060213B0 RID: 136112 RVA: 0x0049DF13 File Offset: 0x0049C113
		public static void AddEnterSendSelfEvent(FlatBufferBuilder builder, StringOffset enterSendSelfEventOffset)
		{
			builder.AddOffset(4, enterSendSelfEventOffset.Value, 0);
		}

		// Token: 0x060213B1 RID: 136113 RVA: 0x0049DF23 File Offset: 0x0049C123
		public static void AddExitSendSelfEvent(FlatBufferBuilder builder, StringOffset exitSendSelfEventOffset)
		{
			builder.AddOffset(5, exitSendSelfEventOffset.Value, 0);
		}

		// Token: 0x060213B2 RID: 136114 RVA: 0x0049DF33 File Offset: 0x0049C133
		public static void AddReleaseSendSelfEvent(FlatBufferBuilder builder, StringOffset releaseSendSelfEventOffset)
		{
			builder.AddOffset(6, releaseSendSelfEventOffset.Value, 0);
		}

		// Token: 0x060213B3 RID: 136115 RVA: 0x0049DF43 File Offset: 0x0049C143
		public static void AddReleaseClientActions(FlatBufferBuilder builder, VectorOffset releaseClientActionsOffset)
		{
			builder.AddOffset(7, releaseClientActionsOffset.Value, 0);
		}

		// Token: 0x060213B4 RID: 136116 RVA: 0x0049DF54 File Offset: 0x0049C154
		public static VectorOffset CreateReleaseClientActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060213B5 RID: 136117 RVA: 0x0049DF94 File Offset: 0x0049C194
		public static VectorOffset CreateReleaseClientActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060213B6 RID: 136118 RVA: 0x0049DFAE File Offset: 0x0049C1AE
		public static VectorOffset CreateReleaseClientActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060213B7 RID: 136119 RVA: 0x0049DFCC File Offset: 0x0049C1CC
		public static VectorOffset CreateReleaseClientActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060213B8 RID: 136120 RVA: 0x0049DFE5 File Offset: 0x0049C1E5
		public static void StartReleaseClientActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060213B9 RID: 136121 RVA: 0x0049DFF0 File Offset: 0x0049C1F0
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(8, conditionOffset.Value, 0);
		}

		// Token: 0x060213BA RID: 136122 RVA: 0x0049E000 File Offset: 0x0049C200
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x060213BB RID: 136123 RVA: 0x0049E00C File Offset: 0x0049C20C
		public static Offset<IDragActorPlayKeyPointConfig> EndIDragActorPlayKeyPointConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDragActorPlayKeyPointConfig>(builder.EndTable());
		}

		// Token: 0x060213BC RID: 136124 RVA: 0x0049E01C File Offset: 0x0049C21C
		public IDragActorPlayKeyPointConfigT UnPack()
		{
			IDragActorPlayKeyPointConfigT dragActorPlayKeyPointConfigT = new IDragActorPlayKeyPointConfigT();
			this.UnPackTo(dragActorPlayKeyPointConfigT);
			return dragActorPlayKeyPointConfigT;
		}

		// Token: 0x060213BD RID: 136125 RVA: 0x0049E038 File Offset: 0x0049C238
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

		// Token: 0x060213BE RID: 136126 RVA: 0x0049E150 File Offset: 0x0049C350
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

		// Token: 0x0400E0F3 RID: 57587
		private Table __p;
	}
}
