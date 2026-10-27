using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072D1 RID: 29393
	public struct ITalkItemAvgRoleConfig : IFlatbufferObject
	{
		// Token: 0x1700DB89 RID: 56201
		// (get) Token: 0x060347E9 RID: 215017 RVA: 0x00715183 File Offset: 0x00713383
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060347EA RID: 215018 RVA: 0x00715190 File Offset: 0x00713390
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060347EB RID: 215019 RVA: 0x00715198 File Offset: 0x00713398
		public static ITalkItemAvgRoleConfig GetRootAsITalkItemAvgRoleConfig(ByteBuffer _bb)
		{
			return ITalkItemAvgRoleConfig.GetRootAsITalkItemAvgRoleConfig(_bb, default(ITalkItemAvgRoleConfig));
		}

		// Token: 0x060347EC RID: 215020 RVA: 0x007151B4 File Offset: 0x007133B4
		public static ITalkItemAvgRoleConfig GetRootAsITalkItemAvgRoleConfig(ByteBuffer _bb, ITalkItemAvgRoleConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060347ED RID: 215021 RVA: 0x007151D1 File Offset: 0x007133D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060347EE RID: 215022 RVA: 0x007151E0 File Offset: 0x007133E0
		public ITalkItemAvgRoleConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DB8A RID: 56202
		// (get) Token: 0x060347EF RID: 215023 RVA: 0x007151F0 File Offset: 0x007133F0
		public EAvgVisualEffect VisualEffect
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAvgVisualEffect.Default;
				}
				return (EAvgVisualEffect)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DB8B RID: 56203
		// (get) Token: 0x060347F0 RID: 215024 RVA: 0x0071522C File Offset: 0x0071342C
		public EAvgRoleAnimationType AnimationType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EAvgRoleAnimationType.Idle;
				}
				return (EAvgRoleAnimationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DB8C RID: 56204
		// (get) Token: 0x060347F1 RID: 215025 RVA: 0x00715268 File Offset: 0x00713468
		public bool IsAnimationLoop
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DB8D RID: 56205
		// (get) Token: 0x060347F2 RID: 215026 RVA: 0x007152A8 File Offset: 0x007134A8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060347F3 RID: 215027 RVA: 0x007152E5 File Offset: 0x007134E5
		public static Offset<ITalkItemAvgRoleConfig> CreateITalkItemAvgRoleConfig(FlatBufferBuilder builder, EAvgVisualEffect VisualEffect = EAvgVisualEffect.Default, EAvgRoleAnimationType AnimationType = EAvgRoleAnimationType.Idle, bool IsAnimationLoop = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			ITalkItemAvgRoleConfig.AddNullMask(builder, NullMask);
			ITalkItemAvgRoleConfig.AddIsAnimationLoop(builder, IsAnimationLoop);
			ITalkItemAvgRoleConfig.AddAnimationType(builder, AnimationType);
			ITalkItemAvgRoleConfig.AddVisualEffect(builder, VisualEffect);
			return ITalkItemAvgRoleConfig.EndITalkItemAvgRoleConfig(builder);
		}

		// Token: 0x060347F4 RID: 215028 RVA: 0x00715311 File Offset: 0x00713511
		public static void StartITalkItemAvgRoleConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060347F5 RID: 215029 RVA: 0x0071531A File Offset: 0x0071351A
		public static void AddVisualEffect(FlatBufferBuilder builder, EAvgVisualEffect visualEffect)
		{
			builder.AddByte(0, (byte)visualEffect, 0);
		}

		// Token: 0x060347F6 RID: 215030 RVA: 0x00715325 File Offset: 0x00713525
		public static void AddAnimationType(FlatBufferBuilder builder, EAvgRoleAnimationType animationType)
		{
			builder.AddByte(1, (byte)animationType, 0);
		}

		// Token: 0x060347F7 RID: 215031 RVA: 0x00715330 File Offset: 0x00713530
		public static void AddIsAnimationLoop(FlatBufferBuilder builder, bool isAnimationLoop)
		{
			builder.AddBool(2, isAnimationLoop, false);
		}

		// Token: 0x060347F8 RID: 215032 RVA: 0x0071533B File Offset: 0x0071353B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060347F9 RID: 215033 RVA: 0x00715346 File Offset: 0x00713546
		public static Offset<ITalkItemAvgRoleConfig> EndITalkItemAvgRoleConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITalkItemAvgRoleConfig>(builder.EndTable());
		}

		// Token: 0x060347FA RID: 215034 RVA: 0x00715354 File Offset: 0x00713554
		public ITalkItemAvgRoleConfigT UnPack()
		{
			ITalkItemAvgRoleConfigT talkItemAvgRoleConfigT = new ITalkItemAvgRoleConfigT();
			this.UnPackTo(talkItemAvgRoleConfigT);
			return talkItemAvgRoleConfigT;
		}

		// Token: 0x060347FB RID: 215035 RVA: 0x0071536F File Offset: 0x0071356F
		public void UnPackTo(ITalkItemAvgRoleConfigT _o)
		{
			_o.VisualEffect = this.VisualEffect;
			_o.AnimationType = this.AnimationType;
			_o.IsAnimationLoop = this.IsAnimationLoop;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060347FC RID: 215036 RVA: 0x007153A4 File Offset: 0x007135A4
		public static Offset<ITalkItemAvgRoleConfig> Pack(FlatBufferBuilder builder, ITalkItemAvgRoleConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkItemAvgRoleConfig>);
			}
			return ITalkItemAvgRoleConfig.CreateITalkItemAvgRoleConfig(builder, _o.VisualEffect, _o.AnimationType, _o.IsAnimationLoop, _o.NullMask);
		}

		// Token: 0x04011EB6 RID: 73398
		private Table __p;
	}
}
