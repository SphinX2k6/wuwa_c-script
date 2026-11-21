using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008EF RID: 2287
	[NetMessage(EMessageId.LevelPlayOpenRequest)]
	public sealed class LevelPlayOpenRequest : IMessage<LevelPlayOpenRequest>, IMessage, IEquatable<LevelPlayOpenRequest>, IDeepCloneable<LevelPlayOpenRequest>, IBufferMessage
	{
		// Token: 0x0600CA6C RID: 51820 RVA: 0x001DE260 File Offset: 0x001DC460
		[NullableContext(1)]
		public static LevelPlayOpenRequest Create()
		{
			return new LevelPlayOpenRequest();
		}

		// Token: 0x170028DA RID: 10458
		// (get) Token: 0x0600CA6D RID: 51821 RVA: 0x001DE267 File Offset: 0x001DC467
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028DB RID: 10459
		// (get) Token: 0x0600CA6E RID: 51822 RVA: 0x001DE26A File Offset: 0x001DC46A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayOpenRequest.Descriptor;
			}
		}

		// Token: 0x0600CA6F RID: 51823 RVA: 0x001DE271 File Offset: 0x001DC471
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayOpenRequest()
		{
		}

		// Token: 0x0600CA70 RID: 51824 RVA: 0x001DE279 File Offset: 0x001DC479
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayOpenRequest(LevelPlayOpenRequest other) : this()
		{
			this.instId_ = other.instId_;
			this.levelPlayId_ = other.levelPlayId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CA71 RID: 51825 RVA: 0x001DE2AA File Offset: 0x001DC4AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayOpenRequest Clone()
		{
			return new LevelPlayOpenRequest(this);
		}

		// Token: 0x170028DC RID: 10460
		// (get) Token: 0x0600CA72 RID: 51826 RVA: 0x001DE2B2 File Offset: 0x001DC4B2
		// (set) Token: 0x0600CA73 RID: 51827 RVA: 0x001DE2BA File Offset: 0x001DC4BA
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

		// Token: 0x170028DD RID: 10461
		// (get) Token: 0x0600CA74 RID: 51828 RVA: 0x001DE2C3 File Offset: 0x001DC4C3
		// (set) Token: 0x0600CA75 RID: 51829 RVA: 0x001DE2CB File Offset: 0x001DC4CB
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

		// Token: 0x0600CA76 RID: 51830 RVA: 0x001DE2D4 File Offset: 0x001DC4D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayOpenRequest);
		}

		// Token: 0x0600CA77 RID: 51831 RVA: 0x001DE2E2 File Offset: 0x001DC4E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayOpenRequest other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.LevelPlayId == other.LevelPlayId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CA78 RID: 51832 RVA: 0x001DE320 File Offset: 0x001DC520
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

		// Token: 0x0600CA79 RID: 51833 RVA: 0x001DE378 File Offset: 0x001DC578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CA7A RID: 51834 RVA: 0x001DE385 File Offset: 0x001DC585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CA7B RID: 51835 RVA: 0x001DE390 File Offset: 0x001DC590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.InstId);
			}
			if (this.LevelPlayId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.LevelPlayId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CA7C RID: 51836 RVA: 0x001DE3EC File Offset: 0x001DC5EC
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

		// Token: 0x0600CA7D RID: 51837 RVA: 0x001DE444 File Offset: 0x001DC644
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

		// Token: 0x0600CA7E RID: 51838 RVA: 0x001DE494 File Offset: 0x001DC694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CA7F RID: 51839 RVA: 0x001DE4A0 File Offset: 0x001DC6A0
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
				if (num != 56U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.LevelPlayId = input.ReadInt32();
					}
				}
				else
				{
					this.InstId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005677 RID: 22135
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005678 RID: 22136
		public const int InstIdFieldNumber = 7;

		// Token: 0x04005679 RID: 22137
		private int instId_;

		// Token: 0x0400567A RID: 22138
		public const int LevelPlayIdFieldNumber = 13;

		// Token: 0x0400567B RID: 22139
		private int levelPlayId_;
	}
}
