using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200017E RID: 382
	[NetMessage(EMessageId.BattleScoreEnableNotify)]
	public sealed class BattleScoreEnableNotify : IMessage<BattleScoreEnableNotify>, IMessage, IEquatable<BattleScoreEnableNotify>, IDeepCloneable<BattleScoreEnableNotify>, IBufferMessage
	{
		// Token: 0x06002E98 RID: 11928 RVA: 0x00078311 File Offset: 0x00076511
		[NullableContext(1)]
		public static BattleScoreEnableNotify Create()
		{
			return new BattleScoreEnableNotify();
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x06002E99 RID: 11929 RVA: 0x00078318 File Offset: 0x00076518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x06002E9A RID: 11930 RVA: 0x0007831B File Offset: 0x0007651B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattleScoreEnableNotify.Descriptor;
			}
		}

		// Token: 0x06002E9B RID: 11931 RVA: 0x00078322 File Offset: 0x00076522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleScoreEnableNotify()
		{
		}

		// Token: 0x06002E9C RID: 11932 RVA: 0x0007832A File Offset: 0x0007652A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleScoreEnableNotify(BattleScoreEnableNotify other) : this()
		{
			this.battleScoreConfId_ = other.battleScoreConfId_;
			this.enable_ = other.enable_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002E9D RID: 11933 RVA: 0x0007835B File Offset: 0x0007655B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleScoreEnableNotify Clone()
		{
			return new BattleScoreEnableNotify(this);
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x06002E9E RID: 11934 RVA: 0x00078363 File Offset: 0x00076563
		// (set) Token: 0x06002E9F RID: 11935 RVA: 0x0007836B File Offset: 0x0007656B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BattleScoreConfId
		{
			get
			{
				return this.battleScoreConfId_;
			}
			set
			{
				this.battleScoreConfId_ = value;
			}
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x06002EA0 RID: 11936 RVA: 0x00078374 File Offset: 0x00076574
		// (set) Token: 0x06002EA1 RID: 11937 RVA: 0x0007837C File Offset: 0x0007657C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Enable
		{
			get
			{
				return this.enable_;
			}
			set
			{
				this.enable_ = value;
			}
		}

		// Token: 0x06002EA2 RID: 11938 RVA: 0x00078385 File Offset: 0x00076585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattleScoreEnableNotify);
		}

		// Token: 0x06002EA3 RID: 11939 RVA: 0x00078393 File Offset: 0x00076593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattleScoreEnableNotify other)
		{
			return other != null && (other == this || (this.BattleScoreConfId == other.BattleScoreConfId && this.Enable == other.Enable && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002EA4 RID: 11940 RVA: 0x000783D4 File Offset: 0x000765D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BattleScoreConfId != 0)
			{
				num ^= this.BattleScoreConfId.GetHashCode();
			}
			if (this.Enable)
			{
				num ^= this.Enable.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002EA5 RID: 11941 RVA: 0x0007842C File Offset: 0x0007662C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002EA6 RID: 11942 RVA: 0x00078439 File Offset: 0x00076639
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002EA7 RID: 11943 RVA: 0x00078444 File Offset: 0x00076644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BattleScoreConfId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.BattleScoreConfId);
			}
			if (this.Enable)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.Enable);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002EA8 RID: 11944 RVA: 0x000784A0 File Offset: 0x000766A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BattleScoreConfId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BattleScoreConfId);
			}
			if (this.Enable)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002EA9 RID: 11945 RVA: 0x000784EC File Offset: 0x000766EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattleScoreEnableNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BattleScoreConfId != 0)
			{
				this.BattleScoreConfId = other.BattleScoreConfId;
			}
			if (other.Enable)
			{
				this.Enable = other.Enable;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002EAA RID: 11946 RVA: 0x0007853C File Offset: 0x0007673C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002EAB RID: 11947 RVA: 0x00078548 File Offset: 0x00076748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 48U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Enable = input.ReadBool();
					}
				}
				else
				{
					this.BattleScoreConfId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040028D5 RID: 10453
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028D6 RID: 10454
		public const int BattleScoreConfIdFieldNumber = 6;

		// Token: 0x040028D7 RID: 10455
		private int battleScoreConfId_;

		// Token: 0x040028D8 RID: 10456
		public const int EnableFieldNumber = 14;

		// Token: 0x040028D9 RID: 10457
		private bool enable_;
	}
}
