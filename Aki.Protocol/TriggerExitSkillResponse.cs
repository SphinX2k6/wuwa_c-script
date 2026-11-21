using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014E1 RID: 5345
	[NetMessage(EMessageId.TriggerExitSkillResponse)]
	public sealed class TriggerExitSkillResponse : IMessage<TriggerExitSkillResponse>, IMessage, IEquatable<TriggerExitSkillResponse>, IDeepCloneable<TriggerExitSkillResponse>, IBufferMessage
	{
		// Token: 0x0601C590 RID: 116112 RVA: 0x0041D097 File Offset: 0x0041B297
		[NullableContext(1)]
		public static TriggerExitSkillResponse Create()
		{
			return new TriggerExitSkillResponse();
		}

		// Token: 0x17005FF5 RID: 24565
		// (get) Token: 0x0601C591 RID: 116113 RVA: 0x0041D09E File Offset: 0x0041B29E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005FF6 RID: 24566
		// (get) Token: 0x0601C592 RID: 116114 RVA: 0x0041D0A1 File Offset: 0x0041B2A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TriggerExitSkillResponse.Descriptor;
			}
		}

		// Token: 0x0601C593 RID: 116115 RVA: 0x0041D0A8 File Offset: 0x0041B2A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TriggerExitSkillResponse()
		{
		}

		// Token: 0x0601C594 RID: 116116 RVA: 0x0041D0B0 File Offset: 0x0041B2B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TriggerExitSkillResponse(TriggerExitSkillResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C595 RID: 116117 RVA: 0x0041D0D5 File Offset: 0x0041B2D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TriggerExitSkillResponse Clone()
		{
			return new TriggerExitSkillResponse(this);
		}

		// Token: 0x17005FF7 RID: 24567
		// (get) Token: 0x0601C596 RID: 116118 RVA: 0x0041D0DD File Offset: 0x0041B2DD
		// (set) Token: 0x0601C597 RID: 116119 RVA: 0x0041D0E5 File Offset: 0x0041B2E5
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

		// Token: 0x0601C598 RID: 116120 RVA: 0x0041D0EE File Offset: 0x0041B2EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TriggerExitSkillResponse);
		}

		// Token: 0x0601C599 RID: 116121 RVA: 0x0041D0FC File Offset: 0x0041B2FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TriggerExitSkillResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C59A RID: 116122 RVA: 0x0041D12C File Offset: 0x0041B32C
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

		// Token: 0x0601C59B RID: 116123 RVA: 0x0041D171 File Offset: 0x0041B371
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C59C RID: 116124 RVA: 0x0041D17E File Offset: 0x0041B37E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C59D RID: 116125 RVA: 0x0041D187 File Offset: 0x0041B387
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C59E RID: 116126 RVA: 0x0041D1BC File Offset: 0x0041B3BC
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

		// Token: 0x0601C59F RID: 116127 RVA: 0x0041D1FA File Offset: 0x0041B3FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TriggerExitSkillResponse other)
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

		// Token: 0x0601C5A0 RID: 116128 RVA: 0x0041D22B File Offset: 0x0041B42B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C5A1 RID: 116129 RVA: 0x0041D234 File Offset: 0x0041B434
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A3CD RID: 41933
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A3CE RID: 41934
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x0400A3CF RID: 41935
		private ErrorCode errorCode_;
	}
}
