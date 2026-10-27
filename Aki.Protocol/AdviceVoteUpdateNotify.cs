using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000D5 RID: 213
	[NetMessage(EMessageId.AdviceVoteUpdateNotify)]
	public sealed class AdviceVoteUpdateNotify : IMessage<AdviceVoteUpdateNotify>, IMessage, IEquatable<AdviceVoteUpdateNotify>, IDeepCloneable<AdviceVoteUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600205C RID: 8284 RVA: 0x00057459 File Offset: 0x00055659
		[NullableContext(1)]
		public static AdviceVoteUpdateNotify Create()
		{
			return new AdviceVoteUpdateNotify();
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x0600205D RID: 8285 RVA: 0x00057460 File Offset: 0x00055660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x0600205E RID: 8286 RVA: 0x00057463 File Offset: 0x00055663
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdviceVoteUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600205F RID: 8287 RVA: 0x0005746A File Offset: 0x0005566A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceVoteUpdateNotify()
		{
		}

		// Token: 0x06002060 RID: 8288 RVA: 0x00057472 File Offset: 0x00055672
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceVoteUpdateNotify(AdviceVoteUpdateNotify other) : this()
		{
			this.id_ = other.id_;
			this.upVote_ = other.upVote_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002061 RID: 8289 RVA: 0x000574A3 File Offset: 0x000556A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceVoteUpdateNotify Clone()
		{
			return new AdviceVoteUpdateNotify(this);
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06002062 RID: 8290 RVA: 0x000574AB File Offset: 0x000556AB
		// (set) Token: 0x06002063 RID: 8291 RVA: 0x000574B3 File Offset: 0x000556B3
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

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06002064 RID: 8292 RVA: 0x000574BC File Offset: 0x000556BC
		// (set) Token: 0x06002065 RID: 8293 RVA: 0x000574C4 File Offset: 0x000556C4
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

		// Token: 0x06002066 RID: 8294 RVA: 0x000574CD File Offset: 0x000556CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdviceVoteUpdateNotify);
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x000574DB File Offset: 0x000556DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdviceVoteUpdateNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.UpVote == other.UpVote && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002068 RID: 8296 RVA: 0x0005751C File Offset: 0x0005571C
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

		// Token: 0x06002069 RID: 8297 RVA: 0x00057574 File Offset: 0x00055774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600206A RID: 8298 RVA: 0x00057581 File Offset: 0x00055781
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600206B RID: 8299 RVA: 0x0005758C File Offset: 0x0005578C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.Id);
			}
			if (this.UpVote != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.UpVote);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600206C RID: 8300 RVA: 0x000575E8 File Offset: 0x000557E8
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

		// Token: 0x0600206D RID: 8301 RVA: 0x00057640 File Offset: 0x00055840
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

		// Token: 0x0600206E RID: 8302 RVA: 0x00057690 File Offset: 0x00055890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600206F RID: 8303 RVA: 0x0005769C File Offset: 0x0005589C
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
				if (num != 32U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.UpVote = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x040023F0 RID: 9200
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023F1 RID: 9201
		public const int IdFieldNumber = 4;

		// Token: 0x040023F2 RID: 9202
		private long id_;

		// Token: 0x040023F3 RID: 9203
		public const int UpVoteFieldNumber = 15;

		// Token: 0x040023F4 RID: 9204
		private int upVote_;
	}
}
