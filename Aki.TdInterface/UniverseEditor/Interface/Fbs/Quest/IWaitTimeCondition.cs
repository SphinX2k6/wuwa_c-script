using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004283 RID: 17027
	public struct IWaitTimeCondition : IFlatbufferObject
	{
		// Token: 0x170078DC RID: 30940
		// (get) Token: 0x06019360 RID: 103264 RVA: 0x0039F469 File Offset: 0x0039D669
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019361 RID: 103265 RVA: 0x0039F476 File Offset: 0x0039D676
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019362 RID: 103266 RVA: 0x0039F480 File Offset: 0x0039D680
		public static IWaitTimeCondition GetRootAsIWaitTimeCondition(ByteBuffer _bb)
		{
			return IWaitTimeCondition.GetRootAsIWaitTimeCondition(_bb, default(IWaitTimeCondition));
		}

		// Token: 0x06019363 RID: 103267 RVA: 0x0039F49C File Offset: 0x0039D69C
		public static IWaitTimeCondition GetRootAsIWaitTimeCondition(ByteBuffer _bb, IWaitTimeCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019364 RID: 103268 RVA: 0x0039F4B9 File Offset: 0x0039D6B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019365 RID: 103269 RVA: 0x0039F4C8 File Offset: 0x0039D6C8
		public IWaitTimeCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170078DD RID: 30941
		// (get) Token: 0x06019366 RID: 103270 RVA: 0x0039F4D8 File Offset: 0x0039D6D8
		public EChildQuest Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChildQuest.DoInteract;
				}
				return (EChildQuest)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170078DE RID: 30942
		// (get) Token: 0x06019367 RID: 103271 RVA: 0x0039F514 File Offset: 0x0039D714
		public IConditionGroup? PreConditions
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170078DF RID: 30943
		// (get) Token: 0x06019368 RID: 103272 RVA: 0x0039F574 File Offset: 0x0039D774
		public int Days
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170078E0 RID: 30944
		// (get) Token: 0x06019369 RID: 103273 RVA: 0x0039F5B0 File Offset: 0x0039D7B0
		public int Hours
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170078E1 RID: 30945
		// (get) Token: 0x0601936A RID: 103274 RVA: 0x0039F5F0 File Offset: 0x0039D7F0
		public int Minutes
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170078E2 RID: 30946
		// (get) Token: 0x0601936B RID: 103275 RVA: 0x0039F630 File Offset: 0x0039D830
		public int Seconds
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601936C RID: 103276 RVA: 0x0039F66D File Offset: 0x0039D86D
		public static Offset<IWaitTimeCondition> CreateIWaitTimeCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), int Days = 0, int Hours = 0, int Minutes = 0, int Seconds = 0)
		{
			builder.StartTable(6);
			IWaitTimeCondition.AddSeconds(builder, Seconds);
			IWaitTimeCondition.AddMinutes(builder, Minutes);
			IWaitTimeCondition.AddHours(builder, Hours);
			IWaitTimeCondition.AddDays(builder, Days);
			IWaitTimeCondition.AddPreConditions(builder, PreConditionsOffset);
			IWaitTimeCondition.AddType(builder, Type);
			return IWaitTimeCondition.EndIWaitTimeCondition(builder);
		}

		// Token: 0x0601936D RID: 103277 RVA: 0x0039F6A9 File Offset: 0x0039D8A9
		public static void StartIWaitTimeCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601936E RID: 103278 RVA: 0x0039F6B2 File Offset: 0x0039D8B2
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601936F RID: 103279 RVA: 0x0039F6BD File Offset: 0x0039D8BD
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06019370 RID: 103280 RVA: 0x0039F6CD File Offset: 0x0039D8CD
		public static void AddDays(FlatBufferBuilder builder, int days)
		{
			builder.AddInt(2, days, 0);
		}

		// Token: 0x06019371 RID: 103281 RVA: 0x0039F6D8 File Offset: 0x0039D8D8
		public static void AddHours(FlatBufferBuilder builder, int hours)
		{
			builder.AddInt(3, hours, 0);
		}

		// Token: 0x06019372 RID: 103282 RVA: 0x0039F6E3 File Offset: 0x0039D8E3
		public static void AddMinutes(FlatBufferBuilder builder, int minutes)
		{
			builder.AddInt(4, minutes, 0);
		}

		// Token: 0x06019373 RID: 103283 RVA: 0x0039F6EE File Offset: 0x0039D8EE
		public static void AddSeconds(FlatBufferBuilder builder, int seconds)
		{
			builder.AddInt(5, seconds, 0);
		}

		// Token: 0x06019374 RID: 103284 RVA: 0x0039F6F9 File Offset: 0x0039D8F9
		public static Offset<IWaitTimeCondition> EndIWaitTimeCondition(FlatBufferBuilder builder)
		{
			return new Offset<IWaitTimeCondition>(builder.EndTable());
		}

		// Token: 0x06019375 RID: 103285 RVA: 0x0039F708 File Offset: 0x0039D908
		public IWaitTimeConditionT UnPack()
		{
			IWaitTimeConditionT waitTimeConditionT = new IWaitTimeConditionT();
			this.UnPackTo(waitTimeConditionT);
			return waitTimeConditionT;
		}

		// Token: 0x06019376 RID: 103286 RVA: 0x0039F724 File Offset: 0x0039D924
		public void UnPackTo(IWaitTimeConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.Days = this.Days;
			_o.Hours = this.Hours;
			_o.Minutes = this.Minutes;
			_o.Seconds = this.Seconds;
		}

		// Token: 0x06019377 RID: 103287 RVA: 0x0039F79C File Offset: 0x0039D99C
		public static Offset<IWaitTimeCondition> Pack(FlatBufferBuilder builder, IWaitTimeConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWaitTimeCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			return IWaitTimeCondition.CreateIWaitTimeCondition(builder, _o.Type, preConditionsOffset, _o.Days, _o.Hours, _o.Minutes, _o.Seconds);
		}

		// Token: 0x0400BF1B RID: 48923
		private Table __p;
	}
}
