using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BA9 RID: 27561
	public struct INightmareSpawnPointTip : IFlatbufferObject
	{
		// Token: 0x1700CCD6 RID: 52438
		// (get) Token: 0x06030685 RID: 198277 RVA: 0x00693131 File Offset: 0x00691331
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030686 RID: 198278 RVA: 0x0069313E File Offset: 0x0069133E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030687 RID: 198279 RVA: 0x00693148 File Offset: 0x00691348
		public static INightmareSpawnPointTip GetRootAsINightmareSpawnPointTip(ByteBuffer _bb)
		{
			return INightmareSpawnPointTip.GetRootAsINightmareSpawnPointTip(_bb, default(INightmareSpawnPointTip));
		}

		// Token: 0x06030688 RID: 198280 RVA: 0x00693164 File Offset: 0x00691364
		public static INightmareSpawnPointTip GetRootAsINightmareSpawnPointTip(ByteBuffer _bb, INightmareSpawnPointTip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030689 RID: 198281 RVA: 0x00693181 File Offset: 0x00691381
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603068A RID: 198282 RVA: 0x00693190 File Offset: 0x00691390
		public INightmareSpawnPointTip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CCD7 RID: 52439
		// (get) Token: 0x0603068B RID: 198283 RVA: 0x006931A0 File Offset: 0x006913A0
		public ECommonTipType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return (ECommonTipType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CCD8 RID: 52440
		// (get) Token: 0x0603068C RID: 198284 RVA: 0x006931DC File Offset: 0x006913DC
		public string TidMainText
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

		// Token: 0x0603068D RID: 198285 RVA: 0x00693213 File Offset: 0x00691413
		public Span<byte> GetTidMainTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0603068E RID: 198286 RVA: 0x00693222 File Offset: 0x00691422
		public byte[] GetTidMainTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700CCD9 RID: 52441
		// (get) Token: 0x0603068F RID: 198287 RVA: 0x00693230 File Offset: 0x00691430
		public string TidSubText
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030690 RID: 198288 RVA: 0x00693267 File Offset: 0x00691467
		public Span<byte> GetTidSubTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06030691 RID: 198289 RVA: 0x00693276 File Offset: 0x00691476
		public byte[] GetTidSubTextArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06030692 RID: 198290 RVA: 0x00693284 File Offset: 0x00691484
		public static Offset<INightmareSpawnPointTip> CreateINightmareSpawnPointTip(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, StringOffset TidMainTextOffset = default(StringOffset), StringOffset TidSubTextOffset = default(StringOffset))
		{
			builder.StartTable(3);
			INightmareSpawnPointTip.AddTidSubText(builder, TidSubTextOffset);
			INightmareSpawnPointTip.AddTidMainText(builder, TidMainTextOffset);
			INightmareSpawnPointTip.AddType(builder, Type);
			return INightmareSpawnPointTip.EndINightmareSpawnPointTip(builder);
		}

		// Token: 0x06030693 RID: 198291 RVA: 0x006932A8 File Offset: 0x006914A8
		public static void StartINightmareSpawnPointTip(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06030694 RID: 198292 RVA: 0x006932B1 File Offset: 0x006914B1
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030695 RID: 198293 RVA: 0x006932BC File Offset: 0x006914BC
		public static void AddTidMainText(FlatBufferBuilder builder, StringOffset tidMainTextOffset)
		{
			builder.AddOffset(1, tidMainTextOffset.Value, 0);
		}

		// Token: 0x06030696 RID: 198294 RVA: 0x006932CC File Offset: 0x006914CC
		public static void AddTidSubText(FlatBufferBuilder builder, StringOffset tidSubTextOffset)
		{
			builder.AddOffset(2, tidSubTextOffset.Value, 0);
		}

		// Token: 0x06030697 RID: 198295 RVA: 0x006932DC File Offset: 0x006914DC
		public static Offset<INightmareSpawnPointTip> EndINightmareSpawnPointTip(FlatBufferBuilder builder)
		{
			return new Offset<INightmareSpawnPointTip>(builder.EndTable());
		}

		// Token: 0x06030698 RID: 198296 RVA: 0x006932EC File Offset: 0x006914EC
		public INightmareSpawnPointTipT UnPack()
		{
			INightmareSpawnPointTipT nightmareSpawnPointTipT = new INightmareSpawnPointTipT();
			this.UnPackTo(nightmareSpawnPointTipT);
			return nightmareSpawnPointTipT;
		}

		// Token: 0x06030699 RID: 198297 RVA: 0x00693307 File Offset: 0x00691507
		public void UnPackTo(INightmareSpawnPointTipT _o)
		{
			_o.Type = this.Type;
			_o.TidMainText = this.TidMainText;
			_o.TidSubText = this.TidSubText;
		}

		// Token: 0x0603069A RID: 198298 RVA: 0x00693330 File Offset: 0x00691530
		public static Offset<INightmareSpawnPointTip> Pack(FlatBufferBuilder builder, INightmareSpawnPointTipT _o)
		{
			if (_o == null)
			{
				return default(Offset<INightmareSpawnPointTip>);
			}
			StringOffset tidMainTextOffset = (_o.TidMainText == null) ? default(StringOffset) : builder.CreateString(_o.TidMainText);
			StringOffset tidSubTextOffset = (_o.TidSubText == null) ? default(StringOffset) : builder.CreateString(_o.TidSubText);
			return INightmareSpawnPointTip.CreateINightmareSpawnPointTip(builder, _o.Type, tidMainTextOffset, tidSubTextOffset);
		}

		// Token: 0x0401147A RID: 70778
		private Table __p;
	}
}
