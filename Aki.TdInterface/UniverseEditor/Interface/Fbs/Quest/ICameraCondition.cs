using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004157 RID: 16727
	public struct ICameraCondition : IFlatbufferObject
	{
		// Token: 0x17007149 RID: 29001
		// (get) Token: 0x06016FE5 RID: 94181 RVA: 0x003478D2 File Offset: 0x00345AD2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016FE6 RID: 94182 RVA: 0x003478DF File Offset: 0x00345ADF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016FE7 RID: 94183 RVA: 0x003478E8 File Offset: 0x00345AE8
		public static ICameraCondition GetRootAsICameraCondition(ByteBuffer _bb)
		{
			return ICameraCondition.GetRootAsICameraCondition(_bb, default(ICameraCondition));
		}

		// Token: 0x06016FE8 RID: 94184 RVA: 0x00347904 File Offset: 0x00345B04
		public static ICameraCondition GetRootAsICameraCondition(ByteBuffer _bb, ICameraCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016FE9 RID: 94185 RVA: 0x00347921 File Offset: 0x00345B21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016FEA RID: 94186 RVA: 0x00347930 File Offset: 0x00345B30
		public ICameraCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700714A RID: 29002
		// (get) Token: 0x06016FEB RID: 94187 RVA: 0x00347940 File Offset: 0x00345B40
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

		// Token: 0x06016FEC RID: 94188 RVA: 0x00347977 File Offset: 0x00345B77
		public Span<byte> GetTidTipBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06016FED RID: 94189 RVA: 0x00347986 File Offset: 0x00345B86
		public byte[] GetTidTipArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700714B RID: 29003
		// (get) Token: 0x06016FEE RID: 94190 RVA: 0x00347994 File Offset: 0x00345B94
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

		// Token: 0x06016FEF RID: 94191 RVA: 0x003479F1 File Offset: 0x00345BF1
		public static Offset<ICameraCondition> CreateICameraCondition(FlatBufferBuilder builder, StringOffset TidTipOffset = default(StringOffset), Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>))
		{
			builder.StartTable(2);
			ICameraCondition.AddCondition(builder, ConditionOffset);
			ICameraCondition.AddTidTip(builder, TidTipOffset);
			return ICameraCondition.EndICameraCondition(builder);
		}

		// Token: 0x06016FF0 RID: 94192 RVA: 0x00347A0E File Offset: 0x00345C0E
		public static void StartICameraCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06016FF1 RID: 94193 RVA: 0x00347A17 File Offset: 0x00345C17
		public static void AddTidTip(FlatBufferBuilder builder, StringOffset tidTipOffset)
		{
			builder.AddOffset(0, tidTipOffset.Value, 0);
		}

		// Token: 0x06016FF2 RID: 94194 RVA: 0x00347A27 File Offset: 0x00345C27
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(1, conditionOffset.Value, 0);
		}

		// Token: 0x06016FF3 RID: 94195 RVA: 0x00347A37 File Offset: 0x00345C37
		public static Offset<ICameraCondition> EndICameraCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICameraCondition>(builder.EndTable());
		}

		// Token: 0x06016FF4 RID: 94196 RVA: 0x00347A44 File Offset: 0x00345C44
		public ICameraConditionT UnPack()
		{
			ICameraConditionT cameraConditionT = new ICameraConditionT();
			this.UnPackTo(cameraConditionT);
			return cameraConditionT;
		}

		// Token: 0x06016FF5 RID: 94197 RVA: 0x00347A60 File Offset: 0x00345C60
		public void UnPackTo(ICameraConditionT _o)
		{
			_o.TidTip = this.TidTip;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
		}

		// Token: 0x06016FF6 RID: 94198 RVA: 0x00347AA8 File Offset: 0x00345CA8
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

		// Token: 0x0400BFC2 RID: 49090
		private Table __p;
	}
}
