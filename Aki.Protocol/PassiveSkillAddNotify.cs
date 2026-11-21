using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BBB RID: 3003
	[NetMessage(EMessageId.PassiveSkillAddNotify)]
	public sealed class PassiveSkillAddNotify : IMessage<PassiveSkillAddNotify>, IMessage, IEquatable<PassiveSkillAddNotify>, IDeepCloneable<PassiveSkillAddNotify>, IBufferMessage
	{
		// Token: 0x060104A9 RID: 66729 RVA: 0x00260C61 File Offset: 0x0025EE61
		[NullableContext(1)]
		public static PassiveSkillAddNotify Create()
		{
			return new PassiveSkillAddNotify();
		}

		// Token: 0x1700356A RID: 13674
		// (get) Token: 0x060104AA RID: 66730 RVA: 0x00260C68 File Offset: 0x0025EE68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700356B RID: 13675
		// (get) Token: 0x060104AB RID: 66731 RVA: 0x00260C6B File Offset: 0x0025EE6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PassiveSkillAddNotify.Descriptor;
			}
		}

		// Token: 0x060104AC RID: 66732 RVA: 0x00260C72 File Offset: 0x0025EE72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillAddNotify()
		{
		}

		// Token: 0x060104AD RID: 66733 RVA: 0x00260C85 File Offset: 0x0025EE85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillAddNotify(PassiveSkillAddNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.passiveSkillItemPbList_ = other.passiveSkillItemPbList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060104AE RID: 66734 RVA: 0x00260CBB File Offset: 0x0025EEBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillAddNotify Clone()
		{
			return new PassiveSkillAddNotify(this);
		}

		// Token: 0x1700356C RID: 13676
		// (get) Token: 0x060104AF RID: 66735 RVA: 0x00260CC3 File Offset: 0x0025EEC3
		// (set) Token: 0x060104B0 RID: 66736 RVA: 0x00260CCB File Offset: 0x0025EECB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x1700356D RID: 13677
		// (get) Token: 0x060104B1 RID: 66737 RVA: 0x00260CD4 File Offset: 0x0025EED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PassiveSkillItemPb> PassiveSkillItemPbList
		{
			get
			{
				return this.passiveSkillItemPbList_;
			}
		}

		// Token: 0x060104B2 RID: 66738 RVA: 0x00260CDC File Offset: 0x0025EEDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PassiveSkillAddNotify);
		}

		// Token: 0x060104B3 RID: 66739 RVA: 0x00260CEC File Offset: 0x0025EEEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PassiveSkillAddNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.passiveSkillItemPbList_.Equals(other.passiveSkillItemPbList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060104B4 RID: 66740 RVA: 0x00260D3C File Offset: 0x0025EF3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			num ^= this.passiveSkillItemPbList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060104B5 RID: 66741 RVA: 0x00260D89 File Offset: 0x0025EF89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060104B6 RID: 66742 RVA: 0x00260D96 File Offset: 0x0025EF96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060104B7 RID: 66743 RVA: 0x00260DA0 File Offset: 0x0025EFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.passiveSkillItemPbList_.WriteTo(ref output, PassiveSkillAddNotify._repeated_passiveSkillItemPbList_codec);
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060104B8 RID: 66744 RVA: 0x00260DF0 File Offset: 0x0025EFF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			num += this.passiveSkillItemPbList_.CalculateSize(PassiveSkillAddNotify._repeated_passiveSkillItemPbList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060104B9 RID: 66745 RVA: 0x00260E44 File Offset: 0x0025F044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PassiveSkillAddNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this.passiveSkillItemPbList_.Add(other.passiveSkillItemPbList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060104BA RID: 66746 RVA: 0x00260E91 File Offset: 0x0025F091
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060104BB RID: 66747 RVA: 0x00260E9C File Offset: 0x0025F09C
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
				if (num != 42U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.passiveSkillItemPbList_.AddEntriesFrom(ref input, PassiveSkillAddNotify._repeated_passiveSkillItemPbList_codec);
				}
			}
		}

		// Token: 0x040067EE RID: 26606
		private UnknownFieldSet _unknownFields;

		// Token: 0x040067EF RID: 26607
		public const int EntityIdFieldNumber = 8;

		// Token: 0x040067F0 RID: 26608
		private long entityId_;

		// Token: 0x040067F1 RID: 26609
		public const int PassiveSkillItemPbListFieldNumber = 5;

		// Token: 0x040067F2 RID: 26610
		private static readonly FieldCodec<PassiveSkillItemPb> _repeated_passiveSkillItemPbList_codec = FieldCodec.ForMessage<PassiveSkillItemPb>(42U, PassiveSkillItemPb.Parser);

		// Token: 0x040067F3 RID: 26611
		private readonly RepeatedField<PassiveSkillItemPb> passiveSkillItemPbList_ = new RepeatedField<PassiveSkillItemPb>();
	}
}
