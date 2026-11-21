using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002D9 RID: 729
	[NetMessage(EMessageId.ConfirmQuestResourceResponse)]
	public sealed class ConfirmQuestResourceResponse : IMessage<ConfirmQuestResourceResponse>, IMessage, IEquatable<ConfirmQuestResourceResponse>, IDeepCloneable<ConfirmQuestResourceResponse>, IBufferMessage
	{
		// Token: 0x06004ACF RID: 19151 RVA: 0x000B714D File Offset: 0x000B534D
		[NullableContext(1)]
		public static ConfirmQuestResourceResponse Create()
		{
			return new ConfirmQuestResourceResponse();
		}

		// Token: 0x17000D25 RID: 3365
		// (get) Token: 0x06004AD0 RID: 19152 RVA: 0x000B7154 File Offset: 0x000B5354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D26 RID: 3366
		// (get) Token: 0x06004AD1 RID: 19153 RVA: 0x000B7157 File Offset: 0x000B5357
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConfirmQuestResourceResponse.Descriptor;
			}
		}

		// Token: 0x06004AD2 RID: 19154 RVA: 0x000B715E File Offset: 0x000B535E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConfirmQuestResourceResponse()
		{
		}

		// Token: 0x06004AD3 RID: 19155 RVA: 0x000B7166 File Offset: 0x000B5366
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConfirmQuestResourceResponse(ConfirmQuestResourceResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004AD4 RID: 19156 RVA: 0x000B718B File Offset: 0x000B538B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConfirmQuestResourceResponse Clone()
		{
			return new ConfirmQuestResourceResponse(this);
		}

		// Token: 0x17000D27 RID: 3367
		// (get) Token: 0x06004AD5 RID: 19157 RVA: 0x000B7193 File Offset: 0x000B5393
		// (set) Token: 0x06004AD6 RID: 19158 RVA: 0x000B719B File Offset: 0x000B539B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorId
		{
			get
			{
				return this.errorId_;
			}
			set
			{
				this.errorId_ = value;
			}
		}

		// Token: 0x06004AD7 RID: 19159 RVA: 0x000B71A4 File Offset: 0x000B53A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConfirmQuestResourceResponse);
		}

		// Token: 0x06004AD8 RID: 19160 RVA: 0x000B71B2 File Offset: 0x000B53B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConfirmQuestResourceResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004AD9 RID: 19161 RVA: 0x000B71E0 File Offset: 0x000B53E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorId != ErrorCode.Success)
			{
				num ^= this.ErrorId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004ADA RID: 19162 RVA: 0x000B7225 File Offset: 0x000B5425
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004ADB RID: 19163 RVA: 0x000B7232 File Offset: 0x000B5432
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004ADC RID: 19164 RVA: 0x000B723B File Offset: 0x000B543B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004ADD RID: 19165 RVA: 0x000B7270 File Offset: 0x000B5470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorId != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004ADE RID: 19166 RVA: 0x000B72AE File Offset: 0x000B54AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConfirmQuestResourceResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorId != ErrorCode.Success)
			{
				this.ErrorId = other.ErrorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004ADF RID: 19167 RVA: 0x000B72DF File Offset: 0x000B54DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004AE0 RID: 19168 RVA: 0x000B72E8 File Offset: 0x000B54E8
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040030EF RID: 12527
		private UnknownFieldSet _unknownFields;

		// Token: 0x040030F0 RID: 12528
		public const int ErrorIdFieldNumber = 9;

		// Token: 0x040030F1 RID: 12529
		private ErrorCode errorId_;
	}
}
