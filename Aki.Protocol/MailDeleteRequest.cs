using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000966 RID: 2406
	[NetMessage(EMessageId.MailDeleteRequest)]
	public sealed class MailDeleteRequest : IMessage<MailDeleteRequest>, IMessage, IEquatable<MailDeleteRequest>, IDeepCloneable<MailDeleteRequest>, IBufferMessage
	{
		// Token: 0x0600D414 RID: 54292 RVA: 0x001F3BF8 File Offset: 0x001F1DF8
		[NullableContext(1)]
		public static MailDeleteRequest Create()
		{
			return new MailDeleteRequest();
		}

		// Token: 0x17002AE9 RID: 10985
		// (get) Token: 0x0600D415 RID: 54293 RVA: 0x001F3BFF File Offset: 0x001F1DFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002AEA RID: 10986
		// (get) Token: 0x0600D416 RID: 54294 RVA: 0x001F3C02 File Offset: 0x001F1E02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MailDeleteRequest.Descriptor;
			}
		}

		// Token: 0x0600D417 RID: 54295 RVA: 0x001F3C09 File Offset: 0x001F1E09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailDeleteRequest()
		{
		}

		// Token: 0x0600D418 RID: 54296 RVA: 0x001F3C1C File Offset: 0x001F1E1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailDeleteRequest(MailDeleteRequest other) : this()
		{
			this.mailIds_ = other.mailIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D419 RID: 54297 RVA: 0x001F3C46 File Offset: 0x001F1E46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailDeleteRequest Clone()
		{
			return new MailDeleteRequest(this);
		}

		// Token: 0x17002AEB RID: 10987
		// (get) Token: 0x0600D41A RID: 54298 RVA: 0x001F3C4E File Offset: 0x001F1E4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> MailIds
		{
			get
			{
				return this.mailIds_;
			}
		}

		// Token: 0x0600D41B RID: 54299 RVA: 0x001F3C56 File Offset: 0x001F1E56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MailDeleteRequest);
		}

		// Token: 0x0600D41C RID: 54300 RVA: 0x001F3C64 File Offset: 0x001F1E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MailDeleteRequest other)
		{
			return other != null && (other == this || (this.mailIds_.Equals(other.mailIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D41D RID: 54301 RVA: 0x001F3C98 File Offset: 0x001F1E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.mailIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D41E RID: 54302 RVA: 0x001F3CCC File Offset: 0x001F1ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D41F RID: 54303 RVA: 0x001F3CD9 File Offset: 0x001F1ED9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D420 RID: 54304 RVA: 0x001F3CE2 File Offset: 0x001F1EE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.mailIds_.WriteTo(ref output, MailDeleteRequest._repeated_mailIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D421 RID: 54305 RVA: 0x001F3D0C File Offset: 0x001F1F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.mailIds_.CalculateSize(MailDeleteRequest._repeated_mailIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D422 RID: 54306 RVA: 0x001F3D45 File Offset: 0x001F1F45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MailDeleteRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.mailIds_.Add(other.mailIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D423 RID: 54307 RVA: 0x001F3D73 File Offset: 0x001F1F73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D424 RID: 54308 RVA: 0x001F3D7C File Offset: 0x001F1F7C
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
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.mailIds_.AddEntriesFrom(ref input, MailDeleteRequest._repeated_mailIds_codec);
				}
			}
		}

		// Token: 0x0400594E RID: 22862
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400594F RID: 22863
		public const int MailIdsFieldNumber = 12;

		// Token: 0x04005950 RID: 22864
		private static readonly FieldCodec<string> _repeated_mailIds_codec = FieldCodec.ForString(98U);

		// Token: 0x04005951 RID: 22865
		private readonly RepeatedField<string> mailIds_ = new RepeatedField<string>();
	}
}
