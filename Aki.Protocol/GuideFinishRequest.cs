using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200070F RID: 1807
	[NetMessage(EMessageId.GuideFinishRequest)]
	public sealed class GuideFinishRequest : IMessage<GuideFinishRequest>, IMessage, IEquatable<GuideFinishRequest>, IDeepCloneable<GuideFinishRequest>, IBufferMessage
	{
		// Token: 0x0600A4AC RID: 42156 RVA: 0x0018DC91 File Offset: 0x0018BE91
		[NullableContext(1)]
		public static GuideFinishRequest Create()
		{
			return new GuideFinishRequest();
		}

		// Token: 0x1700211E RID: 8478
		// (get) Token: 0x0600A4AD RID: 42157 RVA: 0x0018DC98 File Offset: 0x0018BE98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700211F RID: 8479
		// (get) Token: 0x0600A4AE RID: 42158 RVA: 0x0018DC9B File Offset: 0x0018BE9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GuideFinishRequest.Descriptor;
			}
		}

		// Token: 0x0600A4AF RID: 42159 RVA: 0x0018DCA2 File Offset: 0x0018BEA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideFinishRequest()
		{
		}

		// Token: 0x0600A4B0 RID: 42160 RVA: 0x0018DCAA File Offset: 0x0018BEAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideFinishRequest(GuideFinishRequest other) : this()
		{
			this.groupId_ = other.groupId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A4B1 RID: 42161 RVA: 0x0018DCCF File Offset: 0x0018BECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideFinishRequest Clone()
		{
			return new GuideFinishRequest(this);
		}

		// Token: 0x17002120 RID: 8480
		// (get) Token: 0x0600A4B2 RID: 42162 RVA: 0x0018DCD7 File Offset: 0x0018BED7
		// (set) Token: 0x0600A4B3 RID: 42163 RVA: 0x0018DCDF File Offset: 0x0018BEDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x0600A4B4 RID: 42164 RVA: 0x0018DCE8 File Offset: 0x0018BEE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GuideFinishRequest);
		}

		// Token: 0x0600A4B5 RID: 42165 RVA: 0x0018DCF6 File Offset: 0x0018BEF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GuideFinishRequest other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A4B6 RID: 42166 RVA: 0x0018DD24 File Offset: 0x0018BF24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GroupId != 0)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A4B7 RID: 42167 RVA: 0x0018DD63 File Offset: 0x0018BF63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A4B8 RID: 42168 RVA: 0x0018DD70 File Offset: 0x0018BF70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A4B9 RID: 42169 RVA: 0x0018DD79 File Offset: 0x0018BF79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GroupId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A4BA RID: 42170 RVA: 0x0018DDAC File Offset: 0x0018BFAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A4BB RID: 42171 RVA: 0x0018DDEA File Offset: 0x0018BFEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GuideFinishRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GroupId != 0)
			{
				this.GroupId = other.GroupId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A4BC RID: 42172 RVA: 0x0018DE1B File Offset: 0x0018C01B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A4BD RID: 42173 RVA: 0x0018DE24 File Offset: 0x0018C024
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.GroupId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004C39 RID: 19513
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C3A RID: 19514
		public const int GroupIdFieldNumber = 8;

		// Token: 0x04004C3B RID: 19515
		private int groupId_;
	}
}
