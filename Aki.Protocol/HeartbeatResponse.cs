using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200073B RID: 1851
	[NetMessage(EMessageId.HeartbeatResponse)]
	public sealed class HeartbeatResponse : IMessage<HeartbeatResponse>, IMessage, IEquatable<HeartbeatResponse>, IDeepCloneable<HeartbeatResponse>, IBufferMessage
	{
		// Token: 0x0600A808 RID: 43016 RVA: 0x00194855 File Offset: 0x00192A55
		[NullableContext(1)]
		public static HeartbeatResponse Create()
		{
			return new HeartbeatResponse();
		}

		// Token: 0x170021C5 RID: 8645
		// (get) Token: 0x0600A809 RID: 43017 RVA: 0x0019485C File Offset: 0x00192A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170021C6 RID: 8646
		// (get) Token: 0x0600A80A RID: 43018 RVA: 0x0019485F File Offset: 0x00192A5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeartbeatResponse.Descriptor;
			}
		}

		// Token: 0x0600A80B RID: 43019 RVA: 0x00194866 File Offset: 0x00192A66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeartbeatResponse()
		{
		}

		// Token: 0x0600A80C RID: 43020 RVA: 0x0019486E File Offset: 0x00192A6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeartbeatResponse(HeartbeatResponse other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A80D RID: 43021 RVA: 0x00194887 File Offset: 0x00192A87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeartbeatResponse Clone()
		{
			return new HeartbeatResponse(this);
		}

		// Token: 0x0600A80E RID: 43022 RVA: 0x0019488F File Offset: 0x00192A8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeartbeatResponse);
		}

		// Token: 0x0600A80F RID: 43023 RVA: 0x0019489D File Offset: 0x00192A9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HeartbeatResponse other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600A810 RID: 43024 RVA: 0x001948BC File Offset: 0x00192ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A811 RID: 43025 RVA: 0x001948E2 File Offset: 0x00192AE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A812 RID: 43026 RVA: 0x001948EF File Offset: 0x00192AEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A813 RID: 43027 RVA: 0x001948F8 File Offset: 0x00192AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A814 RID: 43028 RVA: 0x00194910 File Offset: 0x00192B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A815 RID: 43029 RVA: 0x00194936 File Offset: 0x00192B36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HeartbeatResponse other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A816 RID: 43030 RVA: 0x00194953 File Offset: 0x00192B53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A817 RID: 43031 RVA: 0x0019495C File Offset: 0x00192B5C
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004D0E RID: 19726
		private UnknownFieldSet _unknownFields;
	}
}
