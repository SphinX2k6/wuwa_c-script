using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200607A RID: 24698
	public struct IActionFunctionalConfigItem : IFlatbufferObject
	{
		// Token: 0x1700B600 RID: 46592
		// (get) Token: 0x06029D3A RID: 171322 RVA: 0x005BCF84 File Offset: 0x005BB184
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029D3B RID: 171323 RVA: 0x005BCF91 File Offset: 0x005BB191
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029D3C RID: 171324 RVA: 0x005BCF98 File Offset: 0x005BB198
		public static IActionFunctionalConfigItem GetRootAsIActionFunctionalConfigItem(ByteBuffer _bb)
		{
			return IActionFunctionalConfigItem.GetRootAsIActionFunctionalConfigItem(_bb, default(IActionFunctionalConfigItem));
		}

		// Token: 0x06029D3D RID: 171325 RVA: 0x005BCFB4 File Offset: 0x005BB1B4
		public static IActionFunctionalConfigItem GetRootAsIActionFunctionalConfigItem(ByteBuffer _bb, IActionFunctionalConfigItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029D3E RID: 171326 RVA: 0x005BCFD1 File Offset: 0x005BB1D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029D3F RID: 171327 RVA: 0x005BCFE0 File Offset: 0x005BB1E0
		public IActionFunctionalConfigItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B601 RID: 46593
		// (get) Token: 0x06029D40 RID: 171328 RVA: 0x005BCFF0 File Offset: 0x005BB1F0
		public EOnlineParticipateRule OnlineParticipateRule
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EOnlineParticipateRule.AnyPlayer;
				}
				return (EOnlineParticipateRule)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B602 RID: 46594
		// (get) Token: 0x06029D41 RID: 171329 RVA: 0x005BD02C File Offset: 0x005BB22C
		public bool IsDetectScreenOccupation
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B603 RID: 46595
		// (get) Token: 0x06029D42 RID: 171330 RVA: 0x005BD06C File Offset: 0x005BB26C
		public bool IsWithResultOnly
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B604 RID: 46596
		// (get) Token: 0x06029D43 RID: 171331 RVA: 0x005BD0AC File Offset: 0x005BB2AC
		public bool IsOperatePlayer
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B605 RID: 46597
		// (get) Token: 0x06029D44 RID: 171332 RVA: 0x005BD0EC File Offset: 0x005BB2EC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029D45 RID: 171333 RVA: 0x005BD129 File Offset: 0x005BB329
		public static Offset<IActionFunctionalConfigItem> CreateIActionFunctionalConfigItem(FlatBufferBuilder builder, EOnlineParticipateRule OnlineParticipateRule = EOnlineParticipateRule.AnyPlayer, bool IsDetectScreenOccupation = false, bool IsWithResultOnly = false, bool IsOperatePlayer = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			IActionFunctionalConfigItem.AddNullMask(builder, NullMask);
			IActionFunctionalConfigItem.AddIsOperatePlayer(builder, IsOperatePlayer);
			IActionFunctionalConfigItem.AddIsWithResultOnly(builder, IsWithResultOnly);
			IActionFunctionalConfigItem.AddIsDetectScreenOccupation(builder, IsDetectScreenOccupation);
			IActionFunctionalConfigItem.AddOnlineParticipateRule(builder, OnlineParticipateRule);
			return IActionFunctionalConfigItem.EndIActionFunctionalConfigItem(builder);
		}

		// Token: 0x06029D46 RID: 171334 RVA: 0x005BD15D File Offset: 0x005BB35D
		public static void StartIActionFunctionalConfigItem(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06029D47 RID: 171335 RVA: 0x005BD166 File Offset: 0x005BB366
		public static void AddOnlineParticipateRule(FlatBufferBuilder builder, EOnlineParticipateRule onlineParticipateRule)
		{
			builder.AddByte(0, (byte)onlineParticipateRule, 0);
		}

		// Token: 0x06029D48 RID: 171336 RVA: 0x005BD171 File Offset: 0x005BB371
		public static void AddIsDetectScreenOccupation(FlatBufferBuilder builder, bool isDetectScreenOccupation)
		{
			builder.AddBool(1, isDetectScreenOccupation, false);
		}

		// Token: 0x06029D49 RID: 171337 RVA: 0x005BD17C File Offset: 0x005BB37C
		public static void AddIsWithResultOnly(FlatBufferBuilder builder, bool isWithResultOnly)
		{
			builder.AddBool(2, isWithResultOnly, false);
		}

		// Token: 0x06029D4A RID: 171338 RVA: 0x005BD187 File Offset: 0x005BB387
		public static void AddIsOperatePlayer(FlatBufferBuilder builder, bool isOperatePlayer)
		{
			builder.AddBool(3, isOperatePlayer, false);
		}

		// Token: 0x06029D4B RID: 171339 RVA: 0x005BD192 File Offset: 0x005BB392
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06029D4C RID: 171340 RVA: 0x005BD19D File Offset: 0x005BB39D
		public static Offset<IActionFunctionalConfigItem> EndIActionFunctionalConfigItem(FlatBufferBuilder builder)
		{
			return new Offset<IActionFunctionalConfigItem>(builder.EndTable());
		}

		// Token: 0x06029D4D RID: 171341 RVA: 0x005BD1AC File Offset: 0x005BB3AC
		public IActionFunctionalConfigItemT UnPack()
		{
			IActionFunctionalConfigItemT actionFunctionalConfigItemT = new IActionFunctionalConfigItemT();
			this.UnPackTo(actionFunctionalConfigItemT);
			return actionFunctionalConfigItemT;
		}

		// Token: 0x06029D4E RID: 171342 RVA: 0x005BD1C7 File Offset: 0x005BB3C7
		public void UnPackTo(IActionFunctionalConfigItemT _o)
		{
			_o.OnlineParticipateRule = this.OnlineParticipateRule;
			_o.IsDetectScreenOccupation = this.IsDetectScreenOccupation;
			_o.IsWithResultOnly = this.IsWithResultOnly;
			_o.IsOperatePlayer = this.IsOperatePlayer;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06029D4F RID: 171343 RVA: 0x005BD208 File Offset: 0x005BB408
		public static Offset<IActionFunctionalConfigItem> Pack(FlatBufferBuilder builder, IActionFunctionalConfigItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActionFunctionalConfigItem>);
			}
			return IActionFunctionalConfigItem.CreateIActionFunctionalConfigItem(builder, _o.OnlineParticipateRule, _o.IsDetectScreenOccupation, _o.IsWithResultOnly, _o.IsOperatePlayer, _o.NullMask);
		}

		// Token: 0x0401024B RID: 66123
		private Table __p;
	}
}
