using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000960 RID: 2400
	[NetMessage(EMessageId.MailBindInfoResponse)]
	public sealed class MailBindInfoResponse : IMessage<MailBindInfoResponse>, IMessage, IEquatable<MailBindInfoResponse>, IDeepCloneable<MailBindInfoResponse>, IBufferMessage
	{
		// Token: 0x0600D3AC RID: 54188 RVA: 0x001F3172 File Offset: 0x001F1372
		[NullableContext(1)]
		public static MailBindInfoResponse Create()
		{
			return new MailBindInfoResponse();
		}

		// Token: 0x17002AD9 RID: 10969
		// (get) Token: 0x0600D3AD RID: 54189 RVA: 0x001F3179 File Offset: 0x001F1379
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002ADA RID: 10970
		// (get) Token: 0x0600D3AE RID: 54190 RVA: 0x001F317C File Offset: 0x001F137C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MailBindInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600D3AF RID: 54191 RVA: 0x001F3183 File Offset: 0x001F1383
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindInfoResponse()
		{
		}

		// Token: 0x0600D3B0 RID: 54192 RVA: 0x001F318B File Offset: 0x001F138B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindInfoResponse(MailBindInfoResponse other) : this()
		{
			this.mailBindInfo_ = ((other.mailBindInfo_ != null) ? other.mailBindInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D3B1 RID: 54193 RVA: 0x001F31C0 File Offset: 0x001F13C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindInfoResponse Clone()
		{
			return new MailBindInfoResponse(this);
		}

		// Token: 0x17002ADB RID: 10971
		// (get) Token: 0x0600D3B2 RID: 54194 RVA: 0x001F31C8 File Offset: 0x001F13C8
		// (set) Token: 0x0600D3B3 RID: 54195 RVA: 0x001F31D0 File Offset: 0x001F13D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailBindInfo MailBindInfo
		{
			get
			{
				return this.mailBindInfo_;
			}
			set
			{
				this.mailBindInfo_ = value;
			}
		}

		// Token: 0x0600D3B4 RID: 54196 RVA: 0x001F31D9 File Offset: 0x001F13D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MailBindInfoResponse);
		}

		// Token: 0x0600D3B5 RID: 54197 RVA: 0x001F31E7 File Offset: 0x001F13E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MailBindInfoResponse other)
		{
			return other != null && (other == this || (object.Equals(this.MailBindInfo, other.MailBindInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D3B6 RID: 54198 RVA: 0x001F321C File Offset: 0x001F141C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.mailBindInfo_ != null)
			{
				num ^= this.MailBindInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D3B7 RID: 54199 RVA: 0x001F3258 File Offset: 0x001F1458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D3B8 RID: 54200 RVA: 0x001F3265 File Offset: 0x001F1465
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D3B9 RID: 54201 RVA: 0x001F326E File Offset: 0x001F146E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.mailBindInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.MailBindInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D3BA RID: 54202 RVA: 0x001F32A0 File Offset: 0x001F14A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.mailBindInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MailBindInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D3BB RID: 54203 RVA: 0x001F32E0 File Offset: 0x001F14E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MailBindInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.mailBindInfo_ != null)
			{
				if (this.mailBindInfo_ == null)
				{
					this.MailBindInfo = new MailBindInfo();
				}
				this.MailBindInfo.MergeFrom(other.MailBindInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D3BC RID: 54204 RVA: 0x001F3334 File Offset: 0x001F1534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D3BD RID: 54205 RVA: 0x001F3340 File Offset: 0x001F1540
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.mailBindInfo_ == null)
					{
						this.MailBindInfo = new MailBindInfo();
					}
					input.ReadMessage(this.MailBindInfo);
				}
			}
		}

		// Token: 0x04005940 RID: 22848
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005941 RID: 22849
		public const int MailBindInfoFieldNumber = 14;

		// Token: 0x04005942 RID: 22850
		private MailBindInfo mailBindInfo_;
	}
}
