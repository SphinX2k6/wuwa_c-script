using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EBB RID: 3771
	[NetMessage(EMessageId.ReceivedSilentFirstAwardRequest)]
	public sealed class ReceivedSilentFirstAwardRequest : IMessage<ReceivedSilentFirstAwardRequest>, IMessage, IEquatable<ReceivedSilentFirstAwardRequest>, IDeepCloneable<ReceivedSilentFirstAwardRequest>, IBufferMessage
	{
		// Token: 0x060143F2 RID: 82930 RVA: 0x002F1E7D File Offset: 0x002F007D
		[NullableContext(1)]
		public static ReceivedSilentFirstAwardRequest Create()
		{
			return new ReceivedSilentFirstAwardRequest();
		}

		// Token: 0x17004352 RID: 17234
		// (get) Token: 0x060143F3 RID: 82931 RVA: 0x002F1E84 File Offset: 0x002F0084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004353 RID: 17235
		// (get) Token: 0x060143F4 RID: 82932 RVA: 0x002F1E87 File Offset: 0x002F0087
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReceivedSilentFirstAwardRequest.Descriptor;
			}
		}

		// Token: 0x060143F5 RID: 82933 RVA: 0x002F1E8E File Offset: 0x002F008E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReceivedSilentFirstAwardRequest()
		{
		}

		// Token: 0x060143F6 RID: 82934 RVA: 0x002F1E96 File Offset: 0x002F0096
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReceivedSilentFirstAwardRequest(ReceivedSilentFirstAwardRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060143F7 RID: 82935 RVA: 0x002F1EBB File Offset: 0x002F00BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReceivedSilentFirstAwardRequest Clone()
		{
			return new ReceivedSilentFirstAwardRequest(this);
		}

		// Token: 0x17004354 RID: 17236
		// (get) Token: 0x060143F8 RID: 82936 RVA: 0x002F1EC3 File Offset: 0x002F00C3
		// (set) Token: 0x060143F9 RID: 82937 RVA: 0x002F1ECB File Offset: 0x002F00CB
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

		// Token: 0x060143FA RID: 82938 RVA: 0x002F1ED4 File Offset: 0x002F00D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReceivedSilentFirstAwardRequest);
		}

		// Token: 0x060143FB RID: 82939 RVA: 0x002F1EE2 File Offset: 0x002F00E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReceivedSilentFirstAwardRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060143FC RID: 82940 RVA: 0x002F1F10 File Offset: 0x002F0110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060143FD RID: 82941 RVA: 0x002F1F4F File Offset: 0x002F014F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060143FE RID: 82942 RVA: 0x002F1F5C File Offset: 0x002F015C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060143FF RID: 82943 RVA: 0x002F1F65 File Offset: 0x002F0165
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014400 RID: 82944 RVA: 0x002F1F98 File Offset: 0x002F0198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014401 RID: 82945 RVA: 0x002F1FD6 File Offset: 0x002F01D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReceivedSilentFirstAwardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014402 RID: 82946 RVA: 0x002F2007 File Offset: 0x002F0207
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014403 RID: 82947 RVA: 0x002F2010 File Offset: 0x002F0210
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007B7C RID: 31612
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B7D RID: 31613
		public const int IdFieldNumber = 5;

		// Token: 0x04007B7E RID: 31614
		private int id_;
	}
}
