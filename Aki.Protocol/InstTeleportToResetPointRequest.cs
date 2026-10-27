using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200082D RID: 2093
	[NetMessage(EMessageId.InstTeleportToResetPointRequest)]
	public sealed class InstTeleportToResetPointRequest : IMessage<InstTeleportToResetPointRequest>, IMessage, IEquatable<InstTeleportToResetPointRequest>, IDeepCloneable<InstTeleportToResetPointRequest>, IBufferMessage
	{
		// Token: 0x0600BB21 RID: 47905 RVA: 0x001BDF40 File Offset: 0x001BC140
		[NullableContext(1)]
		public static InstTeleportToResetPointRequest Create()
		{
			return new InstTeleportToResetPointRequest();
		}

		// Token: 0x170025CD RID: 9677
		// (get) Token: 0x0600BB22 RID: 47906 RVA: 0x001BDF47 File Offset: 0x001BC147
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170025CE RID: 9678
		// (get) Token: 0x0600BB23 RID: 47907 RVA: 0x001BDF4A File Offset: 0x001BC14A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InstTeleportToResetPointRequest.Descriptor;
			}
		}

		// Token: 0x0600BB24 RID: 47908 RVA: 0x001BDF51 File Offset: 0x001BC151
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstTeleportToResetPointRequest()
		{
		}

		// Token: 0x0600BB25 RID: 47909 RVA: 0x001BDF59 File Offset: 0x001BC159
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstTeleportToResetPointRequest(InstTeleportToResetPointRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BB26 RID: 47910 RVA: 0x001BDF72 File Offset: 0x001BC172
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstTeleportToResetPointRequest Clone()
		{
			return new InstTeleportToResetPointRequest(this);
		}

		// Token: 0x0600BB27 RID: 47911 RVA: 0x001BDF7A File Offset: 0x001BC17A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InstTeleportToResetPointRequest);
		}

		// Token: 0x0600BB28 RID: 47912 RVA: 0x001BDF88 File Offset: 0x001BC188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InstTeleportToResetPointRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600BB29 RID: 47913 RVA: 0x001BDFA8 File Offset: 0x001BC1A8
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

		// Token: 0x0600BB2A RID: 47914 RVA: 0x001BDFCE File Offset: 0x001BC1CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BB2B RID: 47915 RVA: 0x001BDFDB File Offset: 0x001BC1DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BB2C RID: 47916 RVA: 0x001BDFE4 File Offset: 0x001BC1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BB2D RID: 47917 RVA: 0x001BDFFC File Offset: 0x001BC1FC
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

		// Token: 0x0600BB2E RID: 47918 RVA: 0x001BE022 File Offset: 0x001BC222
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InstTeleportToResetPointRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BB2F RID: 47919 RVA: 0x001BE03F File Offset: 0x001BC23F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BB30 RID: 47920 RVA: 0x001BE048 File Offset: 0x001BC248
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

		// Token: 0x04005237 RID: 21047
		private UnknownFieldSet _unknownFields;
	}
}
