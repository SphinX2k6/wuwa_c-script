using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001172 RID: 4466
	[NetMessage(EMessageId.SceneItemSequenceFrameStartResponse)]
	public sealed class SceneItemSequenceFrameStartResponse : IMessage<SceneItemSequenceFrameStartResponse>, IMessage, IEquatable<SceneItemSequenceFrameStartResponse>, IDeepCloneable<SceneItemSequenceFrameStartResponse>, IBufferMessage
	{
		// Token: 0x06017CF3 RID: 97523 RVA: 0x003756F1 File Offset: 0x003738F1
		[NullableContext(1)]
		public static SceneItemSequenceFrameStartResponse Create()
		{
			return new SceneItemSequenceFrameStartResponse();
		}

		// Token: 0x17004FFC RID: 20476
		// (get) Token: 0x06017CF4 RID: 97524 RVA: 0x003756F8 File Offset: 0x003738F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004FFD RID: 20477
		// (get) Token: 0x06017CF5 RID: 97525 RVA: 0x003756FB File Offset: 0x003738FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemSequenceFrameStartResponse.Descriptor;
			}
		}

		// Token: 0x06017CF6 RID: 97526 RVA: 0x00375702 File Offset: 0x00373902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSequenceFrameStartResponse()
		{
		}

		// Token: 0x06017CF7 RID: 97527 RVA: 0x0037570A File Offset: 0x0037390A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSequenceFrameStartResponse(SceneItemSequenceFrameStartResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017CF8 RID: 97528 RVA: 0x0037572F File Offset: 0x0037392F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSequenceFrameStartResponse Clone()
		{
			return new SceneItemSequenceFrameStartResponse(this);
		}

		// Token: 0x17004FFE RID: 20478
		// (get) Token: 0x06017CF9 RID: 97529 RVA: 0x00375737 File Offset: 0x00373937
		// (set) Token: 0x06017CFA RID: 97530 RVA: 0x0037573F File Offset: 0x0037393F
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

		// Token: 0x06017CFB RID: 97531 RVA: 0x00375748 File Offset: 0x00373948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemSequenceFrameStartResponse);
		}

		// Token: 0x06017CFC RID: 97532 RVA: 0x00375756 File Offset: 0x00373956
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemSequenceFrameStartResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017CFD RID: 97533 RVA: 0x00375784 File Offset: 0x00373984
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

		// Token: 0x06017CFE RID: 97534 RVA: 0x003757C9 File Offset: 0x003739C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017CFF RID: 97535 RVA: 0x003757D6 File Offset: 0x003739D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017D00 RID: 97536 RVA: 0x003757DF File Offset: 0x003739DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017D01 RID: 97537 RVA: 0x00375814 File Offset: 0x00373A14
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

		// Token: 0x06017D02 RID: 97538 RVA: 0x00375852 File Offset: 0x00373A52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemSequenceFrameStartResponse other)
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

		// Token: 0x06017D03 RID: 97539 RVA: 0x00375883 File Offset: 0x00373A83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017D04 RID: 97540 RVA: 0x0037588C File Offset: 0x00373A8C
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
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008D37 RID: 36151
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D38 RID: 36152
		public const int CodeFieldNumber = 12;

		// Token: 0x04008D39 RID: 36153
		private ErrorCode code_;
	}
}
