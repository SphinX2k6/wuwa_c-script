using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001260 RID: 4704
	[NetMessage(EMessageId.SneakTimeResponse)]
	public sealed class SneakTimeResponse : IMessage<SneakTimeResponse>, IMessage, IEquatable<SneakTimeResponse>, IDeepCloneable<SneakTimeResponse>, IBufferMessage
	{
		// Token: 0x060190FD RID: 102653 RVA: 0x003A57A0 File Offset: 0x003A39A0
		[NullableContext(1)]
		public static SneakTimeResponse Create()
		{
			return new SneakTimeResponse();
		}

		// Token: 0x17005487 RID: 21639
		// (get) Token: 0x060190FE RID: 102654 RVA: 0x003A57A7 File Offset: 0x003A39A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005488 RID: 21640
		// (get) Token: 0x060190FF RID: 102655 RVA: 0x003A57AA File Offset: 0x003A39AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SneakTimeResponse.Descriptor;
			}
		}

		// Token: 0x06019100 RID: 102656 RVA: 0x003A57B1 File Offset: 0x003A39B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakTimeResponse()
		{
		}

		// Token: 0x06019101 RID: 102657 RVA: 0x003A57B9 File Offset: 0x003A39B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakTimeResponse(SneakTimeResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019102 RID: 102658 RVA: 0x003A57DE File Offset: 0x003A39DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakTimeResponse Clone()
		{
			return new SneakTimeResponse(this);
		}

		// Token: 0x17005489 RID: 21641
		// (get) Token: 0x06019103 RID: 102659 RVA: 0x003A57E6 File Offset: 0x003A39E6
		// (set) Token: 0x06019104 RID: 102660 RVA: 0x003A57EE File Offset: 0x003A39EE
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

		// Token: 0x06019105 RID: 102661 RVA: 0x003A57F7 File Offset: 0x003A39F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SneakTimeResponse);
		}

		// Token: 0x06019106 RID: 102662 RVA: 0x003A5805 File Offset: 0x003A3A05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SneakTimeResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019107 RID: 102663 RVA: 0x003A5834 File Offset: 0x003A3A34
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

		// Token: 0x06019108 RID: 102664 RVA: 0x003A5879 File Offset: 0x003A3A79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019109 RID: 102665 RVA: 0x003A5886 File Offset: 0x003A3A86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601910A RID: 102666 RVA: 0x003A588F File Offset: 0x003A3A8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601910B RID: 102667 RVA: 0x003A58C4 File Offset: 0x003A3AC4
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

		// Token: 0x0601910C RID: 102668 RVA: 0x003A5902 File Offset: 0x003A3B02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SneakTimeResponse other)
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

		// Token: 0x0601910D RID: 102669 RVA: 0x003A5933 File Offset: 0x003A3B33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601910E RID: 102670 RVA: 0x003A593C File Offset: 0x003A3B3C
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
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040093A3 RID: 37795
		private UnknownFieldSet _unknownFields;

		// Token: 0x040093A4 RID: 37796
		public const int ErrorIdFieldNumber = 6;

		// Token: 0x040093A5 RID: 37797
		private ErrorCode errorId_;
	}
}
