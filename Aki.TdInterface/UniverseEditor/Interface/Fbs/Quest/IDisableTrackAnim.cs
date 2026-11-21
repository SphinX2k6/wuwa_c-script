using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004211 RID: 16913
	public struct IDisableTrackAnim : IFlatbufferObject
	{
		// Token: 0x17007332 RID: 29490
		// (get) Token: 0x060177CC RID: 96204 RVA: 0x0035A94E File Offset: 0x00358B4E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060177CD RID: 96205 RVA: 0x0035A95B File Offset: 0x00358B5B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060177CE RID: 96206 RVA: 0x0035A964 File Offset: 0x00358B64
		public static IDisableTrackAnim GetRootAsIDisableTrackAnim(ByteBuffer _bb)
		{
			return IDisableTrackAnim.GetRootAsIDisableTrackAnim(_bb, default(IDisableTrackAnim));
		}

		// Token: 0x060177CF RID: 96207 RVA: 0x0035A980 File Offset: 0x00358B80
		public static IDisableTrackAnim GetRootAsIDisableTrackAnim(ByteBuffer _bb, IDisableTrackAnim obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060177D0 RID: 96208 RVA: 0x0035A99D File Offset: 0x00358B9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060177D1 RID: 96209 RVA: 0x0035A9AC File Offset: 0x00358BAC
		public IDisableTrackAnim __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007333 RID: 29491
		// (get) Token: 0x060177D2 RID: 96210 RVA: 0x0035A9BC File Offset: 0x00358BBC
		public IConditionGroup? Condition
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060177D3 RID: 96211 RVA: 0x0035AA19 File Offset: 0x00358C19
		public static Offset<IDisableTrackAnim> CreateIDisableTrackAnim(FlatBufferBuilder builder, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>))
		{
			builder.StartTable(1);
			IDisableTrackAnim.AddCondition(builder, ConditionOffset);
			return IDisableTrackAnim.EndIDisableTrackAnim(builder);
		}

		// Token: 0x060177D4 RID: 96212 RVA: 0x0035AA2F File Offset: 0x00358C2F
		public static void StartIDisableTrackAnim(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060177D5 RID: 96213 RVA: 0x0035AA38 File Offset: 0x00358C38
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(0, conditionOffset.Value, 0);
		}

		// Token: 0x060177D6 RID: 96214 RVA: 0x0035AA48 File Offset: 0x00358C48
		public static Offset<IDisableTrackAnim> EndIDisableTrackAnim(FlatBufferBuilder builder)
		{
			return new Offset<IDisableTrackAnim>(builder.EndTable());
		}

		// Token: 0x060177D7 RID: 96215 RVA: 0x0035AA58 File Offset: 0x00358C58
		public IDisableTrackAnimT UnPack()
		{
			IDisableTrackAnimT disableTrackAnimT = new IDisableTrackAnimT();
			this.UnPackTo(disableTrackAnimT);
			return disableTrackAnimT;
		}

		// Token: 0x060177D8 RID: 96216 RVA: 0x0035AA74 File Offset: 0x00358C74
		public void UnPackTo(IDisableTrackAnimT _o)
		{
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
		}

		// Token: 0x060177D9 RID: 96217 RVA: 0x0035AAB0 File Offset: 0x00358CB0
		public static Offset<IDisableTrackAnim> Pack(FlatBufferBuilder builder, IDisableTrackAnimT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDisableTrackAnim>);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			return IDisableTrackAnim.CreateIDisableTrackAnim(builder, conditionOffset);
		}

		// Token: 0x0400C0F2 RID: 49394
		private Table __p;
	}
}
