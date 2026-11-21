using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000645 RID: 1605
	[NetMessage(EMessageId.FriendRemarkRequest)]
	public sealed class FriendRemarkRequest : IMessage<FriendRemarkRequest>, IMessage, IEquatable<FriendRemarkRequest>, IDeepCloneable<FriendRemarkRequest>, IBufferMessage
	{
		// Token: 0x060093EC RID: 37868 RVA: 0x00165B71 File Offset: 0x00163D71
		[NullableContext(1)]
		public static FriendRemarkRequest Create()
		{
			return new FriendRemarkRequest();
		}

		// Token: 0x17001D6A RID: 7530
		// (get) Token: 0x060093ED RID: 37869 RVA: 0x00165B78 File Offset: 0x00163D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D6B RID: 7531
		// (get) Token: 0x060093EE RID: 37870 RVA: 0x00165B7B File Offset: 0x00163D7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendRemarkRequest.Descriptor;
			}
		}

		// Token: 0x060093EF RID: 37871 RVA: 0x00165B82 File Offset: 0x00163D82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendRemarkRequest()
		{
		}

		// Token: 0x060093F0 RID: 37872 RVA: 0x00165B95 File Offset: 0x00163D95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendRemarkRequest(FriendRemarkRequest other) : this()
		{
			this.id_ = other.id_;
			this.remark_ = other.remark_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060093F1 RID: 37873 RVA: 0x00165BC6 File Offset: 0x00163DC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendRemarkRequest Clone()
		{
			return new FriendRemarkRequest(this);
		}

		// Token: 0x17001D6C RID: 7532
		// (get) Token: 0x060093F2 RID: 37874 RVA: 0x00165BCE File Offset: 0x00163DCE
		// (set) Token: 0x060093F3 RID: 37875 RVA: 0x00165BD6 File Offset: 0x00163DD6
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

		// Token: 0x17001D6D RID: 7533
		// (get) Token: 0x060093F4 RID: 37876 RVA: 0x00165BDF File Offset: 0x00163DDF
		// (set) Token: 0x060093F5 RID: 37877 RVA: 0x00165BE7 File Offset: 0x00163DE7
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

		// Token: 0x060093F6 RID: 37878 RVA: 0x00165BFA File Offset: 0x00163DFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendRemarkRequest);
		}

		// Token: 0x060093F7 RID: 37879 RVA: 0x00165C08 File Offset: 0x00163E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendRemarkRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && !(this.Remark != other.Remark) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060093F8 RID: 37880 RVA: 0x00165C58 File Offset: 0x00163E58
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

		// Token: 0x060093F9 RID: 37881 RVA: 0x00165CB2 File Offset: 0x00163EB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060093FA RID: 37882 RVA: 0x00165CBF File Offset: 0x00163EBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060093FB RID: 37883 RVA: 0x00165CC8 File Offset: 0x00163EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Id);
			}
			if (this.Remark.Length != 0)
			{
				output.WriteRawTag(98);
				output.WriteString(this.Remark);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060093FC RID: 37884 RVA: 0x00165D28 File Offset: 0x00163F28
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

		// Token: 0x060093FD RID: 37885 RVA: 0x00165D84 File Offset: 0x00163F84
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

		// Token: 0x060093FE RID: 37886 RVA: 0x00165DD9 File Offset: 0x00163FD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060093FF RID: 37887 RVA: 0x00165DE4 File Offset: 0x00163FE4
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
				if (num != 24U)
				{
					if (num != 98U)
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

		// Token: 0x04004752 RID: 18258
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004753 RID: 18259
		public const int IdFieldNumber = 3;

		// Token: 0x04004754 RID: 18260
		private int id_;

		// Token: 0x04004755 RID: 18261
		public const int RemarkFieldNumber = 12;

		// Token: 0x04004756 RID: 18262
		private string remark_ = "";
	}
}
