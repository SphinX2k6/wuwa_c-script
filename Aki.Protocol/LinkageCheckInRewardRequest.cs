using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000927 RID: 2343
	[NetMessage(EMessageId.LinkageCheckInRewardRequest)]
	public sealed class LinkageCheckInRewardRequest : IMessage<LinkageCheckInRewardRequest>, IMessage, IEquatable<LinkageCheckInRewardRequest>, IDeepCloneable<LinkageCheckInRewardRequest>, IBufferMessage
	{
		// Token: 0x0600CEAB RID: 52907 RVA: 0x001E7127 File Offset: 0x001E5327
		[NullableContext(1)]
		public static LinkageCheckInRewardRequest Create()
		{
			return new LinkageCheckInRewardRequest();
		}

		// Token: 0x170029C1 RID: 10689
		// (get) Token: 0x0600CEAC RID: 52908 RVA: 0x001E712E File Offset: 0x001E532E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029C2 RID: 10690
		// (get) Token: 0x0600CEAD RID: 52909 RVA: 0x001E7131 File Offset: 0x001E5331
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LinkageCheckInRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600CEAE RID: 52910 RVA: 0x001E7138 File Offset: 0x001E5338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LinkageCheckInRewardRequest()
		{
		}

		// Token: 0x0600CEAF RID: 52911 RVA: 0x001E714B File Offset: 0x001E534B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LinkageCheckInRewardRequest(LinkageCheckInRewardRequest other) : this()
		{
			this.taskIds_ = other.taskIds_.Clone();
			this.type_ = other.type_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CEB0 RID: 52912 RVA: 0x001E7181 File Offset: 0x001E5381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LinkageCheckInRewardRequest Clone()
		{
			return new LinkageCheckInRewardRequest(this);
		}

		// Token: 0x170029C3 RID: 10691
		// (get) Token: 0x0600CEB1 RID: 52913 RVA: 0x001E7189 File Offset: 0x001E5389
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x170029C4 RID: 10692
		// (get) Token: 0x0600CEB2 RID: 52914 RVA: 0x001E7191 File Offset: 0x001E5391
		// (set) Token: 0x0600CEB3 RID: 52915 RVA: 0x001E7199 File Offset: 0x001E5399
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LinkageCheckInType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x0600CEB4 RID: 52916 RVA: 0x001E71A2 File Offset: 0x001E53A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LinkageCheckInRewardRequest);
		}

		// Token: 0x0600CEB5 RID: 52917 RVA: 0x001E71B0 File Offset: 0x001E53B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LinkageCheckInRewardRequest other)
		{
			return other != null && (other == this || (this.taskIds_.Equals(other.taskIds_) && this.Type == other.Type && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CEB6 RID: 52918 RVA: 0x001E7200 File Offset: 0x001E5400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.taskIds_.GetHashCode();
			if (this.Type != LinkageCheckInType.NormalCheckIn)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CEB7 RID: 52919 RVA: 0x001E7253 File Offset: 0x001E5453
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CEB8 RID: 52920 RVA: 0x001E7260 File Offset: 0x001E5460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CEB9 RID: 52921 RVA: 0x001E726C File Offset: 0x001E546C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, LinkageCheckInRewardRequest._repeated_taskIds_codec);
			if (this.Type != LinkageCheckInType.NormalCheckIn)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CEBA RID: 52922 RVA: 0x001E72BC File Offset: 0x001E54BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.taskIds_.CalculateSize(LinkageCheckInRewardRequest._repeated_taskIds_codec);
			if (this.Type != LinkageCheckInType.NormalCheckIn)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CEBB RID: 52923 RVA: 0x001E7310 File Offset: 0x001E5510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LinkageCheckInRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.taskIds_.Add(other.taskIds_);
			if (other.Type != LinkageCheckInType.NormalCheckIn)
			{
				this.Type = other.Type;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CEBC RID: 52924 RVA: 0x001E735D File Offset: 0x001E555D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CEBD RID: 52925 RVA: 0x001E7368 File Offset: 0x001E5568
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
				if (num != 56U && num != 58U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Type = (LinkageCheckInType)input.ReadEnum();
					}
				}
				else
				{
					this.taskIds_.AddEntriesFrom(ref input, LinkageCheckInRewardRequest._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x04005751 RID: 22353
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005752 RID: 22354
		public const int TaskIdsFieldNumber = 7;

		// Token: 0x04005753 RID: 22355
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04005754 RID: 22356
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();

		// Token: 0x04005755 RID: 22357
		public const int TypeFieldNumber = 14;

		// Token: 0x04005756 RID: 22358
		private LinkageCheckInType type_;
	}
}
