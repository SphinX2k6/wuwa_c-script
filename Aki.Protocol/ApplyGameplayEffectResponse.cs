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
		// Token: 0x060024B9 RID: 9401 RVA: 0x00062562 File Offset: 0x00060762
		[NullableContext(1)]
		public static ApplyGameplayEffectResponse Create()
		{
			return new ApplyGameplayEffectResponse();
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x060024BA RID: 9402 RVA: 0x00062569 File Offset: 0x00060769
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x060024BB RID: 9403 RVA: 0x0006256C File Offset: 0x0006076C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ApplyGameplayEffectResponse.Descriptor;
			}
		}

		// Token: 0x060024BC RID: 9404 RVA: 0x00062573 File Offset: 0x00060773
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyGameplayEffectResponse()
		{
		}

		// Token: 0x060024BD RID: 9405 RVA: 0x0006257B File Offset: 0x0006077B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyGameplayEffectResponse(ApplyGameplayEffectResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060024BE RID: 9406 RVA: 0x000625A0 File Offset: 0x000607A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyGameplayEffectResponse Clone()
		{
			return new ApplyGameplayEffectResponse(this);
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x060024BF RID: 9407 RVA: 0x000625A8 File Offset: 0x000607A8
		// (set) Token: 0x060024C0 RID: 9408 RVA: 0x000625B0 File Offset: 0x000607B0
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

		// Token: 0x060024C1 RID: 9409 RVA: 0x000625B9 File Offset: 0x000607B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ApplyGameplayEffectResponse);
		}

		// Token: 0x060024C2 RID: 9410 RVA: 0x000625C7 File Offset: 0x000607C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ApplyGameplayEffectResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060024C3 RID: 9411 RVA: 0x000625F8 File Offset: 0x000607F8
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

		// Token: 0x060024C4 RID: 9412 RVA: 0x0006263D File Offset: 0x0006083D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060024C5 RID: 9413 RVA: 0x0006264A File Offset: 0x0006084A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060024C6 RID: 9414 RVA: 0x00062653 File Offset: 0x00060853
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

		// Token: 0x060024C7 RID: 9415 RVA: 0x00062688 File Offset: 0x00060888
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

		// Token: 0x060024C8 RID: 9416 RVA: 0x000626C6 File Offset: 0x000608C6
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

		// Token: 0x060024C9 RID: 9417 RVA: 0x000626F7 File Offset: 0x000608F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060024CA RID: 9418 RVA: 0x00062700 File Offset: 0x00060900
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

		// Token: 0x040025D6 RID: 9686
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025D7 RID: 9687
		public const int ErrCodeFieldNumber = 13;

		// Token: 0x040025D8 RID: 9688
		private ErrorCode errCode_;
	}
}
