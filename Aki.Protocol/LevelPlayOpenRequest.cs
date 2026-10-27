using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000900 RID: 2304
	[NetMessage(EMessageId.LevelPlayOpenRequest)]
	public sealed class LevelPlayOpenRequest : IMessage<LevelPlayOpenRequest>, IMessage, IEquatable<LevelPlayOpenRequest>, IDeepCloneable<LevelPlayOpenRequest>, IBufferMessage
	{
		// Token: 0x0600CB88 RID: 52104 RVA: 0x001E053C File Offset: 0x001DE73C
		[NullableContext(1)]
		public static LevelPlayOpenRequest Create()
		{
			return new LevelPlayOpenRequest();
		}

		// Token: 0x17002919 RID: 10521
		// (get) Token: 0x0600CB89 RID: 52105 RVA: 0x001E0543 File Offset: 0x001DE743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700291A RID: 10522
		// (get) Token: 0x0600CB8A RID: 52106 RVA: 0x001E0546 File Offset: 0x001DE746
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayOpenRequest.Descriptor;
			}
		}

		// Token: 0x0600CB8B RID: 52107 RVA: 0x001E054D File Offset: 0x001DE74D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayOpenRequest()
		{
		}

		// Token: 0x0600CB8C RID: 52108 RVA: 0x001E0555 File Offset: 0x001DE755
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayOpenRequest(LevelPlayOpenRequest other) : this()
		{
			this.instId_ = other.instId_;
			this.levelPlayId_ = other.levelPlayId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CB8D RID: 52109 RVA: 0x001E0586 File Offset: 0x001DE786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayOpenRequest Clone()
		{
			return new LevelPlayOpenRequest(this);
		}

		// Token: 0x1700291B RID: 10523
		// (get) Token: 0x0600CB8E RID: 52110 RVA: 0x001E058E File Offset: 0x001DE78E
		// (set) Token: 0x0600CB8F RID: 52111 RVA: 0x001E0596 File Offset: 0x001DE796
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x1700291C RID: 10524
		// (get) Token: 0x0600CB90 RID: 52112 RVA: 0x001E059F File Offset: 0x001DE79F
		// (set) Token: 0x0600CB91 RID: 52113 RVA: 0x001E05A7 File Offset: 0x001DE7A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelPlayId
		{
			get
			{
				return this.levelPlayId_;
			}
			set
			{
				this.levelPlayId_ = value;
			}
		}

		// Token: 0x0600CB92 RID: 52114 RVA: 0x001E05B0 File Offset: 0x001DE7B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayOpenRequest);
		}

		// Token: 0x0600CB93 RID: 52115 RVA: 0x001E05BE File Offset: 0x001DE7BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayOpenRequest other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.LevelPlayId == other.LevelPlayId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CB94 RID: 52116 RVA: 0x001E05FC File Offset: 0x001DE7FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.LevelPlayId != 0)
			{
				num ^= this.LevelPlayId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CB95 RID: 52117 RVA: 0x001E0654 File Offset: 0x001DE854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CB96 RID: 52118 RVA: 0x001E0661 File Offset: 0x001DE861
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CB97 RID: 52119 RVA: 0x001E066C File Offset: 0x001DE86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelPlayId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelPlayId);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CB98 RID: 52120 RVA: 0x001E06C4 File Offset: 0x001DE8C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.LevelPlayId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelPlayId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CB99 RID: 52121 RVA: 0x001E071C File Offset: 0x001DE91C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayOpenRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.LevelPlayId != 0)
			{
				this.LevelPlayId = other.LevelPlayId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CB9A RID: 52122 RVA: 0x001E076C File Offset: 0x001DE96C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CB9B RID: 52123 RVA: 0x001E0778 File Offset: 0x001DE978
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
				if (num != 8U)
				{
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.InstId = input.ReadInt32();
					}
				}
				else
				{
					this.LevelPlayId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005670 RID: 22128
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005671 RID: 22129
		public const int InstIdFieldNumber = 6;

		// Token: 0x04005672 RID: 22130
		private int instId_;

		// Token: 0x04005673 RID: 22131
		public const int LevelPlayIdFieldNumber = 1;

		// Token: 0x04005674 RID: 22132
		private int levelPlayId_;
	}
}
