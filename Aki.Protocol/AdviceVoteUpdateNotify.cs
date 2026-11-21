using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000D6 RID: 214
	[NetMessage(EMessageId.AdviceVoteUpdateNotify)]
	public sealed class AdviceVoteUpdateNotify : IMessage<AdviceVoteUpdateNotify>, IMessage, IEquatable<AdviceVoteUpdateNotify>, IDeepCloneable<AdviceVoteUpdateNotify>, IBufferMessage
	{
		// Token: 0x060020A5 RID: 8357 RVA: 0x0005810D File Offset: 0x0005630D
		[NullableContext(1)]
		public static AdviceVoteUpdateNotify Create()
		{
			return new AdviceVoteUpdateNotify();
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x060020A6 RID: 8358 RVA: 0x00058114 File Offset: 0x00056314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x060020A7 RID: 8359 RVA: 0x00058117 File Offset: 0x00056317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdviceVoteUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060020A8 RID: 8360 RVA: 0x0005811E File Offset: 0x0005631E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceVoteUpdateNotify()
		{
		}

		// Token: 0x060020A9 RID: 8361 RVA: 0x00058126 File Offset: 0x00056326
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceVoteUpdateNotify(AdviceVoteUpdateNotify other) : this()
		{
			this.id_ = other.id_;
			this.upVote_ = other.upVote_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060020AA RID: 8362 RVA: 0x00058157 File Offset: 0x00056357
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceVoteUpdateNotify Clone()
		{
			return new AdviceVoteUpdateNotify(this);
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x060020AB RID: 8363 RVA: 0x0005815F File Offset: 0x0005635F
		// (set) Token: 0x060020AC RID: 8364 RVA: 0x00058167 File Offset: 0x00056367
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x060020AD RID: 8365 RVA: 0x00058170 File Offset: 0x00056370
		// (set) Token: 0x060020AE RID: 8366 RVA: 0x00058178 File Offset: 0x00056378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UpVote
		{
			get
			{
				return this.upVote_;
			}
			set
			{
				this.upVote_ = value;
			}
		}

		// Token: 0x060020AF RID: 8367 RVA: 0x00058181 File Offset: 0x00056381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdviceVoteUpdateNotify);
		}

		// Token: 0x060020B0 RID: 8368 RVA: 0x0005818F File Offset: 0x0005638F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdviceVoteUpdateNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.UpVote == other.UpVote && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060020B1 RID: 8369 RVA: 0x000581D0 File Offset: 0x000563D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.UpVote != 0)
			{
				num ^= this.UpVote.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060020B2 RID: 8370 RVA: 0x00058228 File Offset: 0x00056428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060020B3 RID: 8371 RVA: 0x00058235 File Offset: 0x00056435
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060020B4 RID: 8372 RVA: 0x00058240 File Offset: 0x00056440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.UpVote != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.UpVote);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060020B5 RID: 8373 RVA: 0x0005829C File Offset: 0x0005649C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this.UpVote != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UpVote);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060020B6 RID: 8374 RVA: 0x000582F4 File Offset: 0x000564F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdviceVoteUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			if (other.UpVote != 0)
			{
				this.UpVote = other.UpVote;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060020B7 RID: 8375 RVA: 0x00058344 File Offset: 0x00056544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060020B8 RID: 8376 RVA: 0x00058350 File Offset: 0x00056550
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
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadInt64();
					}
				}
				else
				{
					this.UpVote = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002453 RID: 9299
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002454 RID: 9300
		public const int IdFieldNumber = 13;

		// Token: 0x04002455 RID: 9301
		private long id_;

		// Token: 0x04002456 RID: 9302
		public const int UpVoteFieldNumber = 6;

		// Token: 0x04002457 RID: 9303
		private int upVote_;
	}
}
