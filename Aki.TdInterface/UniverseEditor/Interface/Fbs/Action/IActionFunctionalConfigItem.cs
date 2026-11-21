using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066DC RID: 26332
	public struct IActionFunctionalConfigItem : IFlatbufferObject
	{
		// Token: 0x1700BF6B RID: 49003
		// (get) Token: 0x0602C3EE RID: 181230 RVA: 0x00606468 File Offset: 0x00604668
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C3EF RID: 181231 RVA: 0x00606475 File Offset: 0x00604675
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C3F0 RID: 181232 RVA: 0x0060647C File Offset: 0x0060467C
		public static IActionFunctionalConfigItem GetRootAsIActionFunctionalConfigItem(ByteBuffer _bb)
		{
			return IActionFunctionalConfigItem.GetRootAsIActionFunctionalConfigItem(_bb, default(IActionFunctionalConfigItem));
		}

		// Token: 0x0602C3F1 RID: 181233 RVA: 0x00606498 File Offset: 0x00604698
		public static IActionFunctionalConfigItem GetRootAsIActionFunctionalConfigItem(ByteBuffer _bb, IActionFunctionalConfigItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C3F2 RID: 181234 RVA: 0x006064B5 File Offset: 0x006046B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C3F3 RID: 181235 RVA: 0x006064C4 File Offset: 0x006046C4
		public IActionFunctionalConfigItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF6C RID: 49004
		// (get) Token: 0x0602C3F4 RID: 181236 RVA: 0x006064D4 File Offset: 0x006046D4
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

		// Token: 0x1700BF6D RID: 49005
		// (get) Token: 0x0602C3F5 RID: 181237 RVA: 0x00606510 File Offset: 0x00604710
		public bool IsDetectScreenOccupation
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BF6E RID: 49006
		// (get) Token: 0x0602C3F6 RID: 181238 RVA: 0x00606550 File Offset: 0x00604750
		public bool IsWithResultOnly
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BF6F RID: 49007
		// (get) Token: 0x0602C3F7 RID: 181239 RVA: 0x00606590 File Offset: 0x00604790
		public bool IsOperatePlayer
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BF70 RID: 49008
		// (get) Token: 0x0602C3F8 RID: 181240 RVA: 0x006065D0 File Offset: 0x006047D0
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

		// Token: 0x0602C3F9 RID: 181241 RVA: 0x0060660D File Offset: 0x0060480D
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

		// Token: 0x0602C3FA RID: 181242 RVA: 0x00606641 File Offset: 0x00604841
		public static void StartIActionFunctionalConfigItem(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602C3FB RID: 181243 RVA: 0x0060664A File Offset: 0x0060484A
		public static void AddOnlineParticipateRule(FlatBufferBuilder builder, EOnlineParticipateRule onlineParticipateRule)
		{
			builder.AddByte(0, (byte)onlineParticipateRule, 0);
		}

		// Token: 0x0602C3FC RID: 181244 RVA: 0x00606655 File Offset: 0x00604855
		public static void AddIsDetectScreenOccupation(FlatBufferBuilder builder, bool isDetectScreenOccupation)
		{
			builder.AddBool(1, isDetectScreenOccupation, false);
		}

		// Token: 0x0602C3FD RID: 181245 RVA: 0x00606660 File Offset: 0x00604860
		public static void AddIsWithResultOnly(FlatBufferBuilder builder, bool isWithResultOnly)
		{
			builder.AddBool(2, isWithResultOnly, false);
		}

		// Token: 0x0602C3FE RID: 181246 RVA: 0x0060666B File Offset: 0x0060486B
		public static void AddIsOperatePlayer(FlatBufferBuilder builder, bool isOperatePlayer)
		{
			builder.AddBool(3, isOperatePlayer, false);
		}

		// Token: 0x0602C3FF RID: 181247 RVA: 0x00606676 File Offset: 0x00604876
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602C400 RID: 181248 RVA: 0x00606681 File Offset: 0x00604881
		public static Offset<IActionFunctionalConfigItem> EndIActionFunctionalConfigItem(FlatBufferBuilder builder)
		{
			return new Offset<IActionFunctionalConfigItem>(builder.EndTable());
		}

		// Token: 0x0602C401 RID: 181249 RVA: 0x00606690 File Offset: 0x00604890
		public IActionFunctionalConfigItemT UnPack()
		{
			IActionFunctionalConfigItemT actionFunctionalConfigItemT = new IActionFunctionalConfigItemT();
			this.UnPackTo(actionFunctionalConfigItemT);
			return actionFunctionalConfigItemT;
		}

		// Token: 0x0602C402 RID: 181250 RVA: 0x006066AB File Offset: 0x006048AB
		public void UnPackTo(IActionFunctionalConfigItemT _o)
		{
			_o.OnlineParticipateRule = this.OnlineParticipateRule;
			_o.IsDetectScreenOccupation = this.IsDetectScreenOccupation;
			_o.IsWithResultOnly = this.IsWithResultOnly;
			_o.IsOperatePlayer = this.IsOperatePlayer;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602C403 RID: 181251 RVA: 0x006066EC File Offset: 0x006048EC
		public static Offset<IActionFunctionalConfigItem> Pack(FlatBufferBuilder builder, IActionFunctionalConfigItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActionFunctionalConfigItem>);
			}
			return IActionFunctionalConfigItem.CreateIActionFunctionalConfigItem(builder, _o.OnlineParticipateRule, _o.IsDetectScreenOccupation, _o.IsWithResultOnly, _o.IsOperatePlayer, _o.NullMask);
		}

		// Token: 0x04011040 RID: 69696
		private Table __p;
	}
}
