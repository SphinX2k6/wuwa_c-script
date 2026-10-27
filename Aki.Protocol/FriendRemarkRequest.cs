using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000659 RID: 1625
	[NetMessage(EMessageId.FriendRemarkRequest)]
	public sealed class FriendRemarkRequest : IMessage<FriendRemarkRequest>, IMessage, IEquatable<FriendRemarkRequest>, IDeepCloneable<FriendRemarkRequest>, IBufferMessage
	{
		// Token: 0x06009542 RID: 38210 RVA: 0x001685A5 File Offset: 0x001667A5
		[NullableContext(1)]
		public static FriendRemarkRequest Create()
		{
			return new FriendRemarkRequest();
		}

		// Token: 0x17001DB4 RID: 7604
		// (get) Token: 0x06009543 RID: 38211 RVA: 0x001685AC File Offset: 0x001667AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001DB5 RID: 7605
		// (get) Token: 0x06009544 RID: 38212 RVA: 0x001685AF File Offset: 0x001667AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendRemarkRequest.Descriptor;
			}
		}

		// Token: 0x06009545 RID: 38213 RVA: 0x001685B6 File Offset: 0x001667B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendRemarkRequest()
		{
		}

		// Token: 0x06009546 RID: 38214 RVA: 0x001685C9 File Offset: 0x001667C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendRemarkRequest(FriendRemarkRequest other) : this()
		{
			this.id_ = other.id_;
			this.remark_ = other.remark_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009547 RID: 38215 RVA: 0x001685FA File Offset: 0x001667FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendRemarkRequest Clone()
		{
			return new FriendRemarkRequest(this);
		}

		// Token: 0x17001DB6 RID: 7606
		// (get) Token: 0x06009548 RID: 38216 RVA: 0x00168602 File Offset: 0x00166802
		// (set) Token: 0x06009549 RID: 38217 RVA: 0x0016860A File Offset: 0x0016680A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
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

		// Token: 0x17001DB7 RID: 7607
		// (get) Token: 0x0600954A RID: 38218 RVA: 0x00168613 File Offset: 0x00166813
		// (set) Token: 0x0600954B RID: 38219 RVA: 0x0016861B File Offset: 0x0016681B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Remark
		{
			get
			{
				return this.remark_;
			}
			set
			{
				this.remark_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0600954C RID: 38220 RVA: 0x0016862E File Offset: 0x0016682E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendRemarkRequest);
		}

		// Token: 0x0600954D RID: 38221 RVA: 0x0016863C File Offset: 0x0016683C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendRemarkRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && !(this.Remark != other.Remark) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600954E RID: 38222 RVA: 0x0016868C File Offset: 0x0016688C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Remark.Length != 0)
			{
				num ^= this.Remark.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600954F RID: 38223 RVA: 0x001686E6 File Offset: 0x001668E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009550 RID: 38224 RVA: 0x001686F3 File Offset: 0x001668F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009551 RID: 38225 RVA: 0x001686FC File Offset: 0x001668FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Id);
			}
			if (this.Remark.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteString(this.Remark);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009552 RID: 38226 RVA: 0x0016875C File Offset: 0x0016695C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Remark.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Remark);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009553 RID: 38227 RVA: 0x001687B8 File Offset: 0x001669B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FriendRemarkRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Remark.Length != 0)
			{
				this.Remark = other.Remark;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009554 RID: 38228 RVA: 0x0016880D File Offset: 0x00166A0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009555 RID: 38229 RVA: 0x00168818 File Offset: 0x00166A18
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
					if (num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Remark = input.ReadString();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004759 RID: 18265
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400475A RID: 18266
		public const int IdFieldNumber = 6;

		// Token: 0x0400475B RID: 18267
		private int id_;

		// Token: 0x0400475C RID: 18268
		public const int RemarkFieldNumber = 9;

		// Token: 0x0400475D RID: 18269
		private string remark_ = "";
	}
}
