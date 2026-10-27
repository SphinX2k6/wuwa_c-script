using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008A5 RID: 2213
	[NetMessage(EMessageId.KurotatoLimitTaskReceiveResponse)]
	public sealed class KurotatoLimitTaskReceiveResponse : IMessage<KurotatoLimitTaskReceiveResponse>, IMessage, IEquatable<KurotatoLimitTaskReceiveResponse>, IDeepCloneable<KurotatoLimitTaskReceiveResponse>, IBufferMessage
	{
		// Token: 0x0600C498 RID: 50328 RVA: 0x001D2229 File Offset: 0x001D0429
		[NullableContext(1)]
		public static KurotatoLimitTaskReceiveResponse Create()
		{
			return new KurotatoLimitTaskReceiveResponse();
		}

		// Token: 0x170027BF RID: 10175
		// (get) Token: 0x0600C499 RID: 50329 RVA: 0x001D2230 File Offset: 0x001D0430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027C0 RID: 10176
		// (get) Token: 0x0600C49A RID: 50330 RVA: 0x001D2233 File Offset: 0x001D0433
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoLimitTaskReceiveResponse.Descriptor;
			}
		}

		// Token: 0x0600C49B RID: 50331 RVA: 0x001D223A File Offset: 0x001D043A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoLimitTaskReceiveResponse()
		{
		}

		// Token: 0x0600C49C RID: 50332 RVA: 0x001D2242 File Offset: 0x001D0442
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoLimitTaskReceiveResponse(KurotatoLimitTaskReceiveResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C49D RID: 50333 RVA: 0x001D2267 File Offset: 0x001D0467
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoLimitTaskReceiveResponse Clone()
		{
			return new KurotatoLimitTaskReceiveResponse(this);
		}

		// Token: 0x170027C1 RID: 10177
		// (get) Token: 0x0600C49E RID: 50334 RVA: 0x001D226F File Offset: 0x001D046F
		// (set) Token: 0x0600C49F RID: 50335 RVA: 0x001D2277 File Offset: 0x001D0477
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x0600C4A0 RID: 50336 RVA: 0x001D2280 File Offset: 0x001D0480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoLimitTaskReceiveResponse);
		}

		// Token: 0x0600C4A1 RID: 50337 RVA: 0x001D228E File Offset: 0x001D048E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoLimitTaskReceiveResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C4A2 RID: 50338 RVA: 0x001D22BC File Offset: 0x001D04BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C4A3 RID: 50339 RVA: 0x001D2301 File Offset: 0x001D0501
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C4A4 RID: 50340 RVA: 0x001D230E File Offset: 0x001D050E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C4A5 RID: 50341 RVA: 0x001D2317 File Offset: 0x001D0517
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C4A6 RID: 50342 RVA: 0x001D234C File Offset: 0x001D054C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C4A7 RID: 50343 RVA: 0x001D238A File Offset: 0x001D058A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoLimitTaskReceiveResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C4A8 RID: 50344 RVA: 0x001D23BB File Offset: 0x001D05BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C4A9 RID: 50345 RVA: 0x001D23C4 File Offset: 0x001D05C4
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040054C5 RID: 21701
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054C6 RID: 21702
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x040054C7 RID: 21703
		private ErrorCode errorCode_;
	}
}
