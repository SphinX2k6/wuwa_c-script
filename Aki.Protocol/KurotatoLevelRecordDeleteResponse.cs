using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008A3 RID: 2211
	[NetMessage(EMessageId.KurotatoLevelRecordDeleteResponse)]
	public sealed class KurotatoLevelRecordDeleteResponse : IMessage<KurotatoLevelRecordDeleteResponse>, IMessage, IEquatable<KurotatoLevelRecordDeleteResponse>, IDeepCloneable<KurotatoLevelRecordDeleteResponse>, IBufferMessage
	{
		// Token: 0x0600C474 RID: 50292 RVA: 0x001D1E6D File Offset: 0x001D006D
		[NullableContext(1)]
		public static KurotatoLevelRecordDeleteResponse Create()
		{
			return new KurotatoLevelRecordDeleteResponse();
		}

		// Token: 0x170027B9 RID: 10169
		// (get) Token: 0x0600C475 RID: 50293 RVA: 0x001D1E74 File Offset: 0x001D0074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027BA RID: 10170
		// (get) Token: 0x0600C476 RID: 50294 RVA: 0x001D1E77 File Offset: 0x001D0077
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoLevelRecordDeleteResponse.Descriptor;
			}
		}

		// Token: 0x0600C477 RID: 50295 RVA: 0x001D1E7E File Offset: 0x001D007E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoLevelRecordDeleteResponse()
		{
		}

		// Token: 0x0600C478 RID: 50296 RVA: 0x001D1E86 File Offset: 0x001D0086
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoLevelRecordDeleteResponse(KurotatoLevelRecordDeleteResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C479 RID: 50297 RVA: 0x001D1EAB File Offset: 0x001D00AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoLevelRecordDeleteResponse Clone()
		{
			return new KurotatoLevelRecordDeleteResponse(this);
		}

		// Token: 0x170027BB RID: 10171
		// (get) Token: 0x0600C47A RID: 50298 RVA: 0x001D1EB3 File Offset: 0x001D00B3
		// (set) Token: 0x0600C47B RID: 50299 RVA: 0x001D1EBB File Offset: 0x001D00BB
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

		// Token: 0x0600C47C RID: 50300 RVA: 0x001D1EC4 File Offset: 0x001D00C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoLevelRecordDeleteResponse);
		}

		// Token: 0x0600C47D RID: 50301 RVA: 0x001D1ED2 File Offset: 0x001D00D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoLevelRecordDeleteResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C47E RID: 50302 RVA: 0x001D1F00 File Offset: 0x001D0100
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

		// Token: 0x0600C47F RID: 50303 RVA: 0x001D1F45 File Offset: 0x001D0145
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C480 RID: 50304 RVA: 0x001D1F52 File Offset: 0x001D0152
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C481 RID: 50305 RVA: 0x001D1F5B File Offset: 0x001D015B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C482 RID: 50306 RVA: 0x001D1F8C File Offset: 0x001D018C
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

		// Token: 0x0600C483 RID: 50307 RVA: 0x001D1FCA File Offset: 0x001D01CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoLevelRecordDeleteResponse other)
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

		// Token: 0x0600C484 RID: 50308 RVA: 0x001D1FFB File Offset: 0x001D01FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C485 RID: 50309 RVA: 0x001D2004 File Offset: 0x001D0204
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040054BE RID: 21694
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054BF RID: 21695
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040054C0 RID: 21696
		private ErrorCode errorCode_;
	}
}
