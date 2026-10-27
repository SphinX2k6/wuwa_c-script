using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070C1 RID: 28865
	public struct ISheriffCriminalArrested : IFlatbufferObject
	{
		// Token: 0x1700D66E RID: 54894
		// (get) Token: 0x060331FE RID: 209406 RVA: 0x006E4EEE File Offset: 0x006E30EE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060331FF RID: 209407 RVA: 0x006E4EFB File Offset: 0x006E30FB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033200 RID: 209408 RVA: 0x006E4F04 File Offset: 0x006E3104
		public static ISheriffCriminalArrested GetRootAsISheriffCriminalArrested(ByteBuffer _bb)
		{
			return ISheriffCriminalArrested.GetRootAsISheriffCriminalArrested(_bb, default(ISheriffCriminalArrested));
		}

		// Token: 0x06033201 RID: 209409 RVA: 0x006E4F20 File Offset: 0x006E3120
		public static ISheriffCriminalArrested GetRootAsISheriffCriminalArrested(ByteBuffer _bb, ISheriffCriminalArrested obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033202 RID: 209410 RVA: 0x006E4F3D File Offset: 0x006E313D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033203 RID: 209411 RVA: 0x006E4F4C File Offset: 0x006E314C
		public ISheriffCriminalArrested __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D66F RID: 54895
		// (get) Token: 0x06033204 RID: 209412 RVA: 0x006E4F5C File Offset: 0x006E315C
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

		// Token: 0x1700D670 RID: 54896
		// (get) Token: 0x06033205 RID: 209413 RVA: 0x006E4F98 File Offset: 0x006E3198
		public int Id
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

		// Token: 0x06033206 RID: 209414 RVA: 0x006E4FD4 File Offset: 0x006E31D4
		public static Offset<ISheriffCriminalArrested> CreateISheriffCriminalArrested(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, int Id = 0)
		{
			builder.StartTable(2);
			ISheriffCriminalArrested.AddId(builder, Id);
			ISheriffCriminalArrested.AddType(builder, Type);
			return ISheriffCriminalArrested.EndISheriffCriminalArrested(builder);
		}

		// Token: 0x06033207 RID: 209415 RVA: 0x006E4FF1 File Offset: 0x006E31F1
		public static void StartISheriffCriminalArrested(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06033208 RID: 209416 RVA: 0x006E4FFA File Offset: 0x006E31FA
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033209 RID: 209417 RVA: 0x006E5005 File Offset: 0x006E3205
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0603320A RID: 209418 RVA: 0x006E5010 File Offset: 0x006E3210
		public static Offset<ISheriffCriminalArrested> EndISheriffCriminalArrested(FlatBufferBuilder builder)
		{
			return new Offset<ISheriffCriminalArrested>(builder.EndTable());
		}

		// Token: 0x0603320B RID: 209419 RVA: 0x006E5020 File Offset: 0x006E3220
		public ISheriffCriminalArrestedT UnPack()
		{
			ISheriffCriminalArrestedT sheriffCriminalArrestedT = new ISheriffCriminalArrestedT();
			this.UnPackTo(sheriffCriminalArrestedT);
			return sheriffCriminalArrestedT;
		}

		// Token: 0x0603320C RID: 209420 RVA: 0x006E503B File Offset: 0x006E323B
		public void UnPackTo(ISheriffCriminalArrestedT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x0603320D RID: 209421 RVA: 0x006E5058 File Offset: 0x006E3258
		public static Offset<ISheriffCriminalArrested> Pack(FlatBufferBuilder builder, ISheriffCriminalArrestedT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISheriffCriminalArrested>);
			}
			return ISheriffCriminalArrested.CreateISheriffCriminalArrested(builder, _o.Type, _o.Id);
		}

		// Token: 0x04011B30 RID: 72496
		private Table __p;
	}
}
