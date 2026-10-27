using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200125E RID: 4702
	[NetMessage(EMessageId.SneakResponse)]
	public sealed class SneakResponse : IMessage<SneakResponse>, IMessage, IEquatable<SneakResponse>, IDeepCloneable<SneakResponse>, IBufferMessage
	{
		// Token: 0x060190D7 RID: 102615 RVA: 0x003A5324 File Offset: 0x003A3524
		[NullableContext(1)]
		public static SneakResponse Create()
		{
			return new SneakResponse();
		}

		// Token: 0x17005480 RID: 21632
		// (get) Token: 0x060190D8 RID: 102616 RVA: 0x003A532B File Offset: 0x003A352B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005481 RID: 21633
		// (get) Token: 0x060190D9 RID: 102617 RVA: 0x003A532E File Offset: 0x003A352E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SneakResponse.Descriptor;
			}
		}

		// Token: 0x060190DA RID: 102618 RVA: 0x003A5335 File Offset: 0x003A3535
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakResponse()
		{
		}

		// Token: 0x060190DB RID: 102619 RVA: 0x003A533D File Offset: 0x003A353D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakResponse(SneakResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060190DC RID: 102620 RVA: 0x003A5362 File Offset: 0x003A3562
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakResponse Clone()
		{
			return new SneakResponse(this);
		}

		// Token: 0x17005482 RID: 21634
		// (get) Token: 0x060190DD RID: 102621 RVA: 0x003A536A File Offset: 0x003A356A
		// (set) Token: 0x060190DE RID: 102622 RVA: 0x003A5372 File Offset: 0x003A3572
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

		// Token: 0x060190DF RID: 102623 RVA: 0x003A537B File Offset: 0x003A357B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SneakResponse);
		}

		// Token: 0x060190E0 RID: 102624 RVA: 0x003A5389 File Offset: 0x003A3589
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SneakResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060190E1 RID: 102625 RVA: 0x003A53B8 File Offset: 0x003A35B8
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

		// Token: 0x060190E2 RID: 102626 RVA: 0x003A53FD File Offset: 0x003A35FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060190E3 RID: 102627 RVA: 0x003A540A File Offset: 0x003A360A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060190E4 RID: 102628 RVA: 0x003A5413 File Offset: 0x003A3613
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060190E5 RID: 102629 RVA: 0x003A5448 File Offset: 0x003A3648
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

		// Token: 0x060190E6 RID: 102630 RVA: 0x003A5486 File Offset: 0x003A3686
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SneakResponse other)
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

		// Token: 0x060190E7 RID: 102631 RVA: 0x003A54B7 File Offset: 0x003A36B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060190E8 RID: 102632 RVA: 0x003A54C0 File Offset: 0x003A36C0
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400939B RID: 37787
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400939C RID: 37788
		public const int ErrorIdFieldNumber = 15;

		// Token: 0x0400939D RID: 37789
		private ErrorCode errorId_;
	}
}
