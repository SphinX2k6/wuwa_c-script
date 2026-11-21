using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007594 RID: 30100
	public struct IRedNameMonsterTip : IFlatbufferObject
	{
		// Token: 0x1700DD5A RID: 56666
		// (get) Token: 0x06034CBC RID: 216252 RVA: 0x00719469 File Offset: 0x00717669
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034CBD RID: 216253 RVA: 0x00719476 File Offset: 0x00717676
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034CBE RID: 216254 RVA: 0x00719480 File Offset: 0x00717680
		public static IRedNameMonsterTip GetRootAsIRedNameMonsterTip(ByteBuffer _bb)
		{
			return IRedNameMonsterTip.GetRootAsIRedNameMonsterTip(_bb, default(IRedNameMonsterTip));
		}

		// Token: 0x06034CBF RID: 216255 RVA: 0x0071949C File Offset: 0x0071769C
		public static IRedNameMonsterTip GetRootAsIRedNameMonsterTip(ByteBuffer _bb, IRedNameMonsterTip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034CC0 RID: 216256 RVA: 0x007194B9 File Offset: 0x007176B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034CC1 RID: 216257 RVA: 0x007194C8 File Offset: 0x007176C8
		public IRedNameMonsterTip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DD5B RID: 56667
		// (get) Token: 0x06034CC2 RID: 216258 RVA: 0x007194D8 File Offset: 0x007176D8
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

		// Token: 0x1700DD5C RID: 56668
		// (get) Token: 0x06034CC3 RID: 216259 RVA: 0x00719514 File Offset: 0x00717714
		public int MonsterId
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

		// Token: 0x1700DD5D RID: 56669
		// (get) Token: 0x06034CC4 RID: 216260 RVA: 0x00719550 File Offset: 0x00717750
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

		// Token: 0x06034CC5 RID: 216261 RVA: 0x00719590 File Offset: 0x00717790
		public static Offset<IRedNameMonsterTip> CreateIRedNameMonsterTip(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, int MonsterId = 0, float Duration = 0f)
		{
			builder.StartTable(3);
			IRedNameMonsterTip.AddDuration(builder, Duration);
			IRedNameMonsterTip.AddMonsterId(builder, MonsterId);
			IRedNameMonsterTip.AddType(builder, Type);
			return IRedNameMonsterTip.EndIRedNameMonsterTip(builder);
		}

		// Token: 0x06034CC6 RID: 216262 RVA: 0x007195B4 File Offset: 0x007177B4
		public static void StartIRedNameMonsterTip(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06034CC7 RID: 216263 RVA: 0x007195BD File Offset: 0x007177BD
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034CC8 RID: 216264 RVA: 0x007195C8 File Offset: 0x007177C8
		public static void AddMonsterId(FlatBufferBuilder builder, int monsterId)
		{
			builder.AddInt(1, monsterId, 0);
		}

		// Token: 0x06034CC9 RID: 216265 RVA: 0x007195D3 File Offset: 0x007177D3
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(2, duration, 0.0);
		}

		// Token: 0x06034CCA RID: 216266 RVA: 0x007195E6 File Offset: 0x007177E6
		public static Offset<IRedNameMonsterTip> EndIRedNameMonsterTip(FlatBufferBuilder builder)
		{
			return new Offset<IRedNameMonsterTip>(builder.EndTable());
		}

		// Token: 0x06034CCB RID: 216267 RVA: 0x007195F4 File Offset: 0x007177F4
		public IRedNameMonsterTipT UnPack()
		{
			IRedNameMonsterTipT redNameMonsterTipT = new IRedNameMonsterTipT();
			this.UnPackTo(redNameMonsterTipT);
			return redNameMonsterTipT;
		}

		// Token: 0x06034CCC RID: 216268 RVA: 0x0071960F File Offset: 0x0071780F
		public void UnPackTo(IRedNameMonsterTipT _o)
		{
			_o.Type = this.Type;
			_o.MonsterId = this.MonsterId;
			_o.Duration = this.Duration;
		}

		// Token: 0x06034CCD RID: 216269 RVA: 0x00719638 File Offset: 0x00717838
		public static Offset<IRedNameMonsterTip> Pack(FlatBufferBuilder builder, IRedNameMonsterTipT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRedNameMonsterTip>);
			}
			return IRedNameMonsterTip.CreateIRedNameMonsterTip(builder, _o.Type, _o.MonsterId, _o.Duration);
		}

		// Token: 0x0401277C RID: 75644
		private Table __p;
	}
}
