using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005742 RID: 22338
	public struct IPilotThrowTarget : IFlatbufferObject
	{
		// Token: 0x1700A6A2 RID: 42658
		// (get) Token: 0x060256C9 RID: 153289 RVA: 0x0052A2A8 File Offset: 0x005284A8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060256CA RID: 153290 RVA: 0x0052A2B5 File Offset: 0x005284B5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060256CB RID: 153291 RVA: 0x0052A2BC File Offset: 0x005284BC
		public static IPilotThrowTarget GetRootAsIPilotThrowTarget(ByteBuffer _bb)
		{
			return IPilotThrowTarget.GetRootAsIPilotThrowTarget(_bb, default(IPilotThrowTarget));
		}

		// Token: 0x060256CC RID: 153292 RVA: 0x0052A2D8 File Offset: 0x005284D8
		public static IPilotThrowTarget GetRootAsIPilotThrowTarget(ByteBuffer _bb, IPilotThrowTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060256CD RID: 153293 RVA: 0x0052A2F5 File Offset: 0x005284F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060256CE RID: 153294 RVA: 0x0052A304 File Offset: 0x00528504
		public IPilotThrowTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A6A3 RID: 42659
		// (get) Token: 0x060256CF RID: 153295 RVA: 0x0052A314 File Offset: 0x00528514
		public string TidTargetName
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060256D0 RID: 153296 RVA: 0x0052A34B File Offset: 0x0052854B
		public Span<byte> GetTidTargetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060256D1 RID: 153297 RVA: 0x0052A35A File Offset: 0x0052855A
		public byte[] GetTidTargetNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700A6A4 RID: 42660
		// (get) Token: 0x060256D2 RID: 153298 RVA: 0x0052A368 File Offset: 0x00528568
		public IVectorInfo? Position
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A6A5 RID: 42661
		// (get) Token: 0x060256D3 RID: 153299 RVA: 0x0052A3C8 File Offset: 0x005285C8
		public EPilotThrowPointVisualType VisualType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EPilotThrowPointVisualType.Normal;
				}
				return (EPilotThrowPointVisualType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A6A6 RID: 42662
		// (get) Token: 0x060256D4 RID: 153300 RVA: 0x0052A404 File Offset: 0x00528604
		public IConditionGroup? Conditions
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

		// Token: 0x1700A6A7 RID: 42663
		// (get) Token: 0x060256D5 RID: 153301 RVA: 0x0052A464 File Offset: 0x00528664
		public bool IsQuest
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A6A8 RID: 42664
		// (get) Token: 0x060256D6 RID: 153302 RVA: 0x0052A4A4 File Offset: 0x005286A4
		public float UiScale
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A6A9 RID: 42665
		// (get) Token: 0x060256D7 RID: 153303 RVA: 0x0052A4E8 File Offset: 0x005286E8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060256D8 RID: 153304 RVA: 0x0052A528 File Offset: 0x00528728
		public static Offset<IPilotThrowTarget> CreateIPilotThrowTarget(FlatBufferBuilder builder, StringOffset TidTargetNameOffset = default(StringOffset), Offset<IVectorInfo> PositionOffset = default(Offset<IVectorInfo>), EPilotThrowPointVisualType VisualType = EPilotThrowPointVisualType.Normal, Offset<IConditionGroup> ConditionsOffset = default(Offset<IConditionGroup>), bool IsQuest = false, float UiScale = 0f, byte NullMask = 0)
		{
			builder.StartTable(7);
			IPilotThrowTarget.AddUiScale(builder, UiScale);
			IPilotThrowTarget.AddConditions(builder, ConditionsOffset);
			IPilotThrowTarget.AddPosition(builder, PositionOffset);
			IPilotThrowTarget.AddTidTargetName(builder, TidTargetNameOffset);
			IPilotThrowTarget.AddNullMask(builder, NullMask);
			IPilotThrowTarget.AddIsQuest(builder, IsQuest);
			IPilotThrowTarget.AddVisualType(builder, VisualType);
			return IPilotThrowTarget.EndIPilotThrowTarget(builder);
		}

		// Token: 0x060256D9 RID: 153305 RVA: 0x0052A577 File Offset: 0x00528777
		public static void StartIPilotThrowTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x060256DA RID: 153306 RVA: 0x0052A580 File Offset: 0x00528780
		public static void AddTidTargetName(FlatBufferBuilder builder, StringOffset tidTargetNameOffset)
		{
			builder.AddOffset(0, tidTargetNameOffset.Value, 0);
		}

		// Token: 0x060256DB RID: 153307 RVA: 0x0052A590 File Offset: 0x00528790
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(1, positionOffset.Value, 0);
		}

		// Token: 0x060256DC RID: 153308 RVA: 0x0052A5A0 File Offset: 0x005287A0
		public static void AddVisualType(FlatBufferBuilder builder, EPilotThrowPointVisualType visualType)
		{
			builder.AddByte(2, (byte)visualType, 0);
		}

		// Token: 0x060256DD RID: 153309 RVA: 0x0052A5AB File Offset: 0x005287AB
		public static void AddConditions(FlatBufferBuilder builder, Offset<IConditionGroup> conditionsOffset)
		{
			builder.AddOffset(3, conditionsOffset.Value, 0);
		}

		// Token: 0x060256DE RID: 153310 RVA: 0x0052A5BB File Offset: 0x005287BB
		public static void AddIsQuest(FlatBufferBuilder builder, bool isQuest)
		{
			builder.AddBool(4, isQuest, false);
		}

		// Token: 0x060256DF RID: 153311 RVA: 0x0052A5C6 File Offset: 0x005287C6
		public static void AddUiScale(FlatBufferBuilder builder, float uiScale)
		{
			builder.AddFloat(5, uiScale, 0.0);
		}

		// Token: 0x060256E0 RID: 153312 RVA: 0x0052A5D9 File Offset: 0x005287D9
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x060256E1 RID: 153313 RVA: 0x0052A5E4 File Offset: 0x005287E4
		public static Offset<IPilotThrowTarget> EndIPilotThrowTarget(FlatBufferBuilder builder)
		{
			return new Offset<IPilotThrowTarget>(builder.EndTable());
		}

		// Token: 0x060256E2 RID: 153314 RVA: 0x0052A5F4 File Offset: 0x005287F4
		public IPilotThrowTargetT UnPack()
		{
			IPilotThrowTargetT pilotThrowTargetT = new IPilotThrowTargetT();
			this.UnPackTo(pilotThrowTargetT);
			return pilotThrowTargetT;
		}

		// Token: 0x060256E3 RID: 153315 RVA: 0x0052A610 File Offset: 0x00528810
		public void UnPackTo(IPilotThrowTargetT _o)
		{
			_o.TidTargetName = this.TidTargetName;
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
			_o.VisualType = this.VisualType;
			_o.Conditions = ((this.Conditions != null) ? this.Conditions.Value.UnPack() : null);
			_o.IsQuest = this.IsQuest;
			_o.UiScale = this.UiScale;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060256E4 RID: 153316 RVA: 0x0052A6B8 File Offset: 0x005288B8
		public static Offset<IPilotThrowTarget> Pack(FlatBufferBuilder builder, IPilotThrowTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPilotThrowTarget>);
			}
			StringOffset tidTargetNameOffset = (_o.TidTargetName == null) ? default(StringOffset) : builder.CreateString(_o.TidTargetName);
			Offset<IVectorInfo> positionOffset = (_o.Position == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Position);
			Offset<IConditionGroup> conditionsOffset = (_o.Conditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Conditions);
			return IPilotThrowTarget.CreateIPilotThrowTarget(builder, tidTargetNameOffset, positionOffset, _o.VisualType, conditionsOffset, _o.IsQuest, _o.UiScale, _o.NullMask);
		}

		// Token: 0x0400EBDB RID: 60379
		private Table __p;
	}
}
