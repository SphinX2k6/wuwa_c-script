using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000112 RID: 274
	[NetMessage(EMessageId.AreaTerminalPinOperationResponse)]
	public sealed class AreaTerminalPinOperationResponse : IMessage<AreaTerminalPinOperationResponse>, IMessage, IEquatable<AreaTerminalPinOperationResponse>, IDeepCloneable<AreaTerminalPinOperationResponse>, IBufferMessage
	{
		// Token: 0x060025EC RID: 9708 RVA: 0x0006533C File Offset: 0x0006353C
		[NullableContext(1)]
		public static AreaTerminalPinOperationResponse Create()
		{
			return new AreaTerminalPinOperationResponse();
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x060025ED RID: 9709 RVA: 0x00065343 File Offset: 0x00063543
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x060025EE RID: 9710 RVA: 0x00065346 File Offset: 0x00063546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AreaTerminalPinOperationResponse.Descriptor;
			}
		}

		// Token: 0x060025EF RID: 9711 RVA: 0x0006534D File Offset: 0x0006354D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AreaTerminalPinOperationResponse()
		{
		}

		// Token: 0x060025F0 RID: 9712 RVA: 0x00065355 File Offset: 0x00063555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AreaTerminalPinOperationResponse(AreaTerminalPinOperationResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060025F1 RID: 9713 RVA: 0x0006537A File Offset: 0x0006357A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AreaTerminalPinOperationResponse Clone()
		{
			return new AreaTerminalPinOperationResponse(this);
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x060025F2 RID: 9714 RVA: 0x00065382 File Offset: 0x00063582
		// (set) Token: 0x060025F3 RID: 9715 RVA: 0x0006538A File Offset: 0x0006358A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x060025F4 RID: 9716 RVA: 0x00065393 File Offset: 0x00063593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AreaTerminalPinOperationResponse);
		}

		// Token: 0x060025F5 RID: 9717 RVA: 0x000653A1 File Offset: 0x000635A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AreaTerminalPinOperationResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060025F6 RID: 9718 RVA: 0x000653D0 File Offset: 0x000635D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060025F7 RID: 9719 RVA: 0x00065415 File Offset: 0x00063615
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060025F8 RID: 9720 RVA: 0x00065422 File Offset: 0x00063622
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060025F9 RID: 9721 RVA: 0x0006542B File Offset: 0x0006362B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060025FA RID: 9722 RVA: 0x00065460 File Offset: 0x00063660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060025FB RID: 9723 RVA: 0x0006549E File Offset: 0x0006369E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AreaTerminalPinOperationResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060025FC RID: 9724 RVA: 0x000654CF File Offset: 0x000636CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060025FD RID: 9725 RVA: 0x000654D8 File Offset: 0x000636D8
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002640 RID: 9792
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002641 RID: 9793
		public const int CodeFieldNumber = 8;

		// Token: 0x04002642 RID: 9794
		private ErrorCode code_;
	}
}
