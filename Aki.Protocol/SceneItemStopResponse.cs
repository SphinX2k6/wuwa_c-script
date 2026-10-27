using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200117B RID: 4475
	[NetMessage(EMessageId.SceneItemStopResponse)]
	public sealed class SceneItemStopResponse : IMessage<SceneItemStopResponse>, IMessage, IEquatable<SceneItemStopResponse>, IDeepCloneable<SceneItemStopResponse>, IBufferMessage
	{
		// Token: 0x06017DA7 RID: 97703 RVA: 0x00376E24 File Offset: 0x00375024
		[NullableContext(1)]
		public static SceneItemStopResponse Create()
		{
			return new SceneItemStopResponse();
		}

		// Token: 0x17005020 RID: 20512
		// (get) Token: 0x06017DA8 RID: 97704 RVA: 0x00376E2B File Offset: 0x0037502B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005021 RID: 20513
		// (get) Token: 0x06017DA9 RID: 97705 RVA: 0x00376E2E File Offset: 0x0037502E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemStopResponse.Descriptor;
			}
		}

		// Token: 0x06017DAA RID: 97706 RVA: 0x00376E35 File Offset: 0x00375035
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemStopResponse()
		{
		}

		// Token: 0x06017DAB RID: 97707 RVA: 0x00376E3D File Offset: 0x0037503D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemStopResponse(SceneItemStopResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017DAC RID: 97708 RVA: 0x00376E62 File Offset: 0x00375062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemStopResponse Clone()
		{
			return new SceneItemStopResponse(this);
		}

		// Token: 0x17005022 RID: 20514
		// (get) Token: 0x06017DAD RID: 97709 RVA: 0x00376E6A File Offset: 0x0037506A
		// (set) Token: 0x06017DAE RID: 97710 RVA: 0x00376E72 File Offset: 0x00375072
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

		// Token: 0x06017DAF RID: 97711 RVA: 0x00376E7B File Offset: 0x0037507B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemStopResponse);
		}

		// Token: 0x06017DB0 RID: 97712 RVA: 0x00376E89 File Offset: 0x00375089
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemStopResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017DB1 RID: 97713 RVA: 0x00376EB8 File Offset: 0x003750B8
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

		// Token: 0x06017DB2 RID: 97714 RVA: 0x00376EFD File Offset: 0x003750FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017DB3 RID: 97715 RVA: 0x00376F0A File Offset: 0x0037510A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017DB4 RID: 97716 RVA: 0x00376F13 File Offset: 0x00375113
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017DB5 RID: 97717 RVA: 0x00376F48 File Offset: 0x00375148
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

		// Token: 0x06017DB6 RID: 97718 RVA: 0x00376F86 File Offset: 0x00375186
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemStopResponse other)
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

		// Token: 0x06017DB7 RID: 97719 RVA: 0x00376FB7 File Offset: 0x003751B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017DB8 RID: 97720 RVA: 0x00376FC0 File Offset: 0x003751C0
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008D64 RID: 36196
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D65 RID: 36197
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04008D66 RID: 36198
		private ErrorCode errorCode_;
	}
}
