using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066D3 RID: 26323
	public struct IActionConfigItem : IFlatbufferObject
	{
		// Token: 0x1700BF59 RID: 48985
		// (get) Token: 0x0602C39A RID: 181146 RVA: 0x00605BA4 File Offset: 0x00603DA4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C39B RID: 181147 RVA: 0x00605BB1 File Offset: 0x00603DB1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C39C RID: 181148 RVA: 0x00605BB8 File Offset: 0x00603DB8
		public static IActionConfigItem GetRootAsIActionConfigItem(ByteBuffer _bb)
		{
			return IActionConfigItem.GetRootAsIActionConfigItem(_bb, default(IActionConfigItem));
		}

		// Token: 0x0602C39D RID: 181149 RVA: 0x00605BD4 File Offset: 0x00603DD4
		public static IActionConfigItem GetRootAsIActionConfigItem(ByteBuffer _bb, IActionConfigItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C39E RID: 181150 RVA: 0x00605BF1 File Offset: 0x00603DF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C39F RID: 181151 RVA: 0x00605C00 File Offset: 0x00603E00
		public IActionConfigItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF5A RID: 48986
		// (get) Token: 0x0602C3A0 RID: 181152 RVA: 0x00605C10 File Offset: 0x00603E10
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

		// Token: 0x1700BF5B RID: 48987
		// (get) Token: 0x0602C3A1 RID: 181153 RVA: 0x00605C4C File Offset: 0x00603E4C
		public bool IsDetectScreenOccupation
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BF5C RID: 48988
		// (get) Token: 0x0602C3A2 RID: 181154 RVA: 0x00605C8C File Offset: 0x00603E8C
		public bool IsWithResultOnly
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BF5D RID: 48989
		// (get) Token: 0x0602C3A3 RID: 181155 RVA: 0x00605CCC File Offset: 0x00603ECC
		public bool IsOperatePlayer
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BF5E RID: 48990
		// (get) Token: 0x0602C3A4 RID: 181156 RVA: 0x00605D0C File Offset: 0x00603F0C
		public string CnName
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

		// Token: 0x0602C3A5 RID: 181157 RVA: 0x00605D44 File Offset: 0x00603F44
		public Span<byte> GetCnNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0602C3A6 RID: 181158 RVA: 0x00605D54 File Offset: 0x00603F54
		public byte[] GetCnNameArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700BF5F RID: 48991
		// (get) Token: 0x0602C3A7 RID: 181159 RVA: 0x00605D64 File Offset: 0x00603F64
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

		// Token: 0x0602C3A8 RID: 181160 RVA: 0x00605DA1 File Offset: 0x00603FA1
		public static Offset<IActionConfigItem> CreateIActionConfigItem(FlatBufferBuilder builder, EOnlineParticipateRule OnlineParticipateRule = EOnlineParticipateRule.AnyPlayer, bool IsDetectScreenOccupation = false, bool IsWithResultOnly = false, bool IsOperatePlayer = false, StringOffset CnNameOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			IActionConfigItem.AddCnName(builder, CnNameOffset);
			IActionConfigItem.AddNullMask(builder, NullMask);
			IActionConfigItem.AddIsOperatePlayer(builder, IsOperatePlayer);
			IActionConfigItem.AddIsWithResultOnly(builder, IsWithResultOnly);
			IActionConfigItem.AddIsDetectScreenOccupation(builder, IsDetectScreenOccupation);
			IActionConfigItem.AddOnlineParticipateRule(builder, OnlineParticipateRule);
			return IActionConfigItem.EndIActionConfigItem(builder);
		}

		// Token: 0x0602C3A9 RID: 181161 RVA: 0x00605DDD File Offset: 0x00603FDD
		public static void StartIActionConfigItem(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602C3AA RID: 181162 RVA: 0x00605DE6 File Offset: 0x00603FE6
		public static void AddOnlineParticipateRule(FlatBufferBuilder builder, EOnlineParticipateRule onlineParticipateRule)
		{
			builder.AddByte(0, (byte)onlineParticipateRule, 0);
		}

		// Token: 0x0602C3AB RID: 181163 RVA: 0x00605DF1 File Offset: 0x00603FF1
		public static void AddIsDetectScreenOccupation(FlatBufferBuilder builder, bool isDetectScreenOccupation)
		{
			builder.AddBool(1, isDetectScreenOccupation, false);
		}

		// Token: 0x0602C3AC RID: 181164 RVA: 0x00605DFC File Offset: 0x00603FFC
		public static void AddIsWithResultOnly(FlatBufferBuilder builder, bool isWithResultOnly)
		{
			builder.AddBool(2, isWithResultOnly, false);
		}

		// Token: 0x0602C3AD RID: 181165 RVA: 0x00605E07 File Offset: 0x00604007
		public static void AddIsOperatePlayer(FlatBufferBuilder builder, bool isOperatePlayer)
		{
			builder.AddBool(3, isOperatePlayer, false);
		}

		// Token: 0x0602C3AE RID: 181166 RVA: 0x00605E12 File Offset: 0x00604012
		public static void AddCnName(FlatBufferBuilder builder, StringOffset cnNameOffset)
		{
			builder.AddOffset(4, cnNameOffset.Value, 0);
		}

		// Token: 0x0602C3AF RID: 181167 RVA: 0x00605E22 File Offset: 0x00604022
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602C3B0 RID: 181168 RVA: 0x00605E2D File Offset: 0x0060402D
		public static Offset<IActionConfigItem> EndIActionConfigItem(FlatBufferBuilder builder)
		{
			return new Offset<IActionConfigItem>(builder.EndTable());
		}

		// Token: 0x0602C3B1 RID: 181169 RVA: 0x00605E3C File Offset: 0x0060403C
		public IActionConfigItemT UnPack()
		{
			IActionConfigItemT actionConfigItemT = new IActionConfigItemT();
			this.UnPackTo(actionConfigItemT);
			return actionConfigItemT;
		}

		// Token: 0x0602C3B2 RID: 181170 RVA: 0x00605E58 File Offset: 0x00604058
		public void UnPackTo(IActionConfigItemT _o)
		{
			_o.OnlineParticipateRule = this.OnlineParticipateRule;
			_o.IsDetectScreenOccupation = this.IsDetectScreenOccupation;
			_o.IsWithResultOnly = this.IsWithResultOnly;
			_o.IsOperatePlayer = this.IsOperatePlayer;
			_o.CnName = this.CnName;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602C3B3 RID: 181171 RVA: 0x00605EB0 File Offset: 0x006040B0
		public static Offset<IActionConfigItem> Pack(FlatBufferBuilder builder, IActionConfigItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActionConfigItem>);
			}
			StringOffset cnNameOffset = (_o.CnName == null) ? default(StringOffset) : builder.CreateString(_o.CnName);
			return IActionConfigItem.CreateIActionConfigItem(builder, _o.OnlineParticipateRule, _o.IsDetectScreenOccupation, _o.IsWithResultOnly, _o.IsOperatePlayer, cnNameOffset, _o.NullMask);
		}

		// Token: 0x0401102A RID: 69674
		private Table __p;
	}
}
