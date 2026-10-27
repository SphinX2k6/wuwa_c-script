using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000104 RID: 260
	[NetMessage(EMessageId.ApplyGameplayEffectResponse)]
	public sealed class ApplyGameplayEffectResponse : IMessage<ApplyGameplayEffectResponse>, IMessage, IEquatable<ApplyGameplayEffectResponse>, IDeepCloneable<ApplyGameplayEffectResponse>, IBufferMessage
	{
		// Token: 0x06002482 RID: 9346 RVA: 0x00061A8F File Offset: 0x0005FC8F
		[NullableContext(1)]
		public static ApplyGameplayEffectResponse Create()
		{
			return new ApplyGameplayEffectResponse();
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06002483 RID: 9347 RVA: 0x00061A96 File Offset: 0x0005FC96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06002484 RID: 9348 RVA: 0x00061A99 File Offset: 0x0005FC99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ApplyGameplayEffectResponse.Descriptor;
			}
		}

		// Token: 0x06002485 RID: 9349 RVA: 0x00061AA0 File Offset: 0x0005FCA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyGameplayEffectResponse()
		{
		}

		// Token: 0x06002486 RID: 9350 RVA: 0x00061AA8 File Offset: 0x0005FCA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyGameplayEffectResponse(ApplyGameplayEffectResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002487 RID: 9351 RVA: 0x00061ACD File Offset: 0x0005FCCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyGameplayEffectResponse Clone()
		{
			return new ApplyGameplayEffectResponse(this);
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06002488 RID: 9352 RVA: 0x00061AD5 File Offset: 0x0005FCD5
		// (set) Token: 0x06002489 RID: 9353 RVA: 0x00061ADD File Offset: 0x0005FCDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x0600248A RID: 9354 RVA: 0x00061AE6 File Offset: 0x0005FCE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ApplyGameplayEffectResponse);
		}

		// Token: 0x0600248B RID: 9355 RVA: 0x00061AF4 File Offset: 0x0005FCF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ApplyGameplayEffectResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600248C RID: 9356 RVA: 0x00061B24 File Offset: 0x0005FD24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600248D RID: 9357 RVA: 0x00061B69 File Offset: 0x0005FD69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600248E RID: 9358 RVA: 0x00061B76 File Offset: 0x0005FD76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600248F RID: 9359 RVA: 0x00061B7F File Offset: 0x0005FD7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002490 RID: 9360 RVA: 0x00061BB4 File Offset: 0x0005FDB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002491 RID: 9361 RVA: 0x00061BF2 File Offset: 0x0005FDF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ApplyGameplayEffectResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002492 RID: 9362 RVA: 0x00061C23 File Offset: 0x0005FE23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002493 RID: 9363 RVA: 0x00061C2C File Offset: 0x0005FE2C
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002577 RID: 9591
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002578 RID: 9592
		public const int ErrCodeFieldNumber = 13;

		// Token: 0x04002579 RID: 9593
		private ErrorCode errCode_;
	}
}
