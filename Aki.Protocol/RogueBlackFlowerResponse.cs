using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F72 RID: 3954
	[NetMessage(EMessageId.RogueBlackFlowerResponse)]
	public sealed class RogueBlackFlowerResponse : IMessage<RogueBlackFlowerResponse>, IMessage, IEquatable<RogueBlackFlowerResponse>, IDeepCloneable<RogueBlackFlowerResponse>, IBufferMessage
	{
		// Token: 0x060152A5 RID: 86693 RVA: 0x00312244 File Offset: 0x00310444
		[NullableContext(1)]
		public static RogueBlackFlowerResponse Create()
		{
			return new RogueBlackFlowerResponse();
		}

		// Token: 0x17004671 RID: 18033
		// (get) Token: 0x060152A6 RID: 86694 RVA: 0x0031224B File Offset: 0x0031044B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004672 RID: 18034
		// (get) Token: 0x060152A7 RID: 86695 RVA: 0x0031224E File Offset: 0x0031044E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueBlackFlowerResponse.Descriptor;
			}
		}

		// Token: 0x060152A8 RID: 86696 RVA: 0x00312255 File Offset: 0x00310455
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBlackFlowerResponse()
		{
		}

		// Token: 0x060152A9 RID: 86697 RVA: 0x0031225D File Offset: 0x0031045D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBlackFlowerResponse(RogueBlackFlowerResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060152AA RID: 86698 RVA: 0x00312282 File Offset: 0x00310482
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBlackFlowerResponse Clone()
		{
			return new RogueBlackFlowerResponse(this);
		}

		// Token: 0x17004673 RID: 18035
		// (get) Token: 0x060152AB RID: 86699 RVA: 0x0031228A File Offset: 0x0031048A
		// (set) Token: 0x060152AC RID: 86700 RVA: 0x00312292 File Offset: 0x00310492
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

		// Token: 0x060152AD RID: 86701 RVA: 0x0031229B File Offset: 0x0031049B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueBlackFlowerResponse);
		}

		// Token: 0x060152AE RID: 86702 RVA: 0x003122A9 File Offset: 0x003104A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueBlackFlowerResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060152AF RID: 86703 RVA: 0x003122D8 File Offset: 0x003104D8
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

		// Token: 0x060152B0 RID: 86704 RVA: 0x0031231D File Offset: 0x0031051D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060152B1 RID: 86705 RVA: 0x0031232A File Offset: 0x0031052A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060152B2 RID: 86706 RVA: 0x00312333 File Offset: 0x00310533
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060152B3 RID: 86707 RVA: 0x00312368 File Offset: 0x00310568
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

		// Token: 0x060152B4 RID: 86708 RVA: 0x003123A6 File Offset: 0x003105A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueBlackFlowerResponse other)
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

		// Token: 0x060152B5 RID: 86709 RVA: 0x003123D7 File Offset: 0x003105D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060152B6 RID: 86710 RVA: 0x003123E0 File Offset: 0x003105E0
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007FBB RID: 32699
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007FBC RID: 32700
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04007FBD RID: 32701
		private ErrorCode errorCode_;
	}
}
