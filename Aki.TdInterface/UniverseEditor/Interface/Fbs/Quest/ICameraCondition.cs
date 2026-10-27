using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D40 RID: 15680
	public struct ICameraCondition : IFlatbufferObject
	{
		// Token: 0x17006B8F RID: 27535
		// (get) Token: 0x06015AAD RID: 88749 RVA: 0x0032065A File Offset: 0x0031E85A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015AAE RID: 88750 RVA: 0x00320667 File Offset: 0x0031E867
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015AAF RID: 88751 RVA: 0x00320670 File Offset: 0x0031E870
		public static ICameraCondition GetRootAsICameraCondition(ByteBuffer _bb)
		{
			return ICameraCondition.GetRootAsICameraCondition(_bb, default(ICameraCondition));
		}

		// Token: 0x06015AB0 RID: 88752 RVA: 0x0032068C File Offset: 0x0031E88C
		public static ICameraCondition GetRootAsICameraCondition(ByteBuffer _bb, ICameraCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015AB1 RID: 88753 RVA: 0x003206A9 File Offset: 0x0031E8A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015AB2 RID: 88754 RVA: 0x003206B8 File Offset: 0x0031E8B8
		public ICameraCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B90 RID: 27536
		// (get) Token: 0x06015AB3 RID: 88755 RVA: 0x003206C8 File Offset: 0x0031E8C8
		public string TidTip
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

		// Token: 0x06015AB4 RID: 88756 RVA: 0x003206FF File Offset: 0x0031E8FF
		public Span<byte> GetTidTipBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06015AB5 RID: 88757 RVA: 0x0032070E File Offset: 0x0031E90E
		public byte[] GetTidTipArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17006B91 RID: 27537
		// (get) Token: 0x06015AB6 RID: 88758 RVA: 0x0032071C File Offset: 0x0031E91C
		public IConditionGroup? Condition
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

		// Token: 0x06015AB7 RID: 88759 RVA: 0x00320779 File Offset: 0x0031E979
		public static Offset<ICameraCondition> CreateICameraCondition(FlatBufferBuilder builder, StringOffset TidTipOffset = default(StringOffset), Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>))
		{
			builder.StartTable(2);
			ICameraCondition.AddCondition(builder, ConditionOffset);
			ICameraCondition.AddTidTip(builder, TidTipOffset);
			return ICameraCondition.EndICameraCondition(builder);
		}

		// Token: 0x06015AB8 RID: 88760 RVA: 0x00320796 File Offset: 0x0031E996
		public static void StartICameraCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06015AB9 RID: 88761 RVA: 0x0032079F File Offset: 0x0031E99F
		public static void AddTidTip(FlatBufferBuilder builder, StringOffset tidTipOffset)
		{
			builder.AddOffset(0, tidTipOffset.Value, 0);
		}

		// Token: 0x06015ABA RID: 88762 RVA: 0x003207AF File Offset: 0x0031E9AF
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(1, conditionOffset.Value, 0);
		}

		// Token: 0x06015ABB RID: 88763 RVA: 0x003207BF File Offset: 0x0031E9BF
		public static Offset<ICameraCondition> EndICameraCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICameraCondition>(builder.EndTable());
		}

		// Token: 0x06015ABC RID: 88764 RVA: 0x003207CC File Offset: 0x0031E9CC
		public ICameraConditionT UnPack()
		{
			ICameraConditionT cameraConditionT = new ICameraConditionT();
			this.UnPackTo(cameraConditionT);
			return cameraConditionT;
		}

		// Token: 0x06015ABD RID: 88765 RVA: 0x003207E8 File Offset: 0x0031E9E8
		public void UnPackTo(ICameraConditionT _o)
		{
			_o.TidTip = this.TidTip;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
		}

		// Token: 0x06015ABE RID: 88766 RVA: 0x00320830 File Offset: 0x0031EA30
		public static Offset<ICameraCondition> Pack(FlatBufferBuilder builder, ICameraConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICameraCondition>);
			}
			StringOffset tidTipOffset = (_o.TidTip == null) ? default(StringOffset) : builder.CreateString(_o.TidTip);
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			return ICameraCondition.CreateICameraCondition(builder, tidTipOffset, conditionOffset);
		}

		// Token: 0x0400B615 RID: 46613
		private Table __p;
	}
}
