using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CCB RID: 3275
	[NetMessage(EMessageId.PhantomInteractionSkinChangeResponse)]
	public sealed class PhantomInteractionSkinChangeResponse : IMessage<PhantomInteractionSkinChangeResponse>, IMessage, IEquatable<PhantomInteractionSkinChangeResponse>, IDeepCloneable<PhantomInteractionSkinChangeResponse>, IBufferMessage
	{
		// Token: 0x06011BED RID: 72685 RVA: 0x00299109 File Offset: 0x00297309
		[NullableContext(1)]
		public static PhantomInteractionSkinChangeResponse Create()
		{
			return new PhantomInteractionSkinChangeResponse();
		}

		// Token: 0x17003AC8 RID: 15048
		// (get) Token: 0x06011BEE RID: 72686 RVA: 0x00299110 File Offset: 0x00297310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003AC9 RID: 15049
		// (get) Token: 0x06011BEF RID: 72687 RVA: 0x00299113 File Offset: 0x00297313
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomInteractionSkinChangeResponse.Descriptor;
			}
		}

		// Token: 0x06011BF0 RID: 72688 RVA: 0x0029911A File Offset: 0x0029731A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomInteractionSkinChangeResponse()
		{
		}

		// Token: 0x06011BF1 RID: 72689 RVA: 0x00299122 File Offset: 0x00297322
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomInteractionSkinChangeResponse(PhantomInteractionSkinChangeResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011BF2 RID: 72690 RVA: 0x00299147 File Offset: 0x00297347
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomInteractionSkinChangeResponse Clone()
		{
			return new PhantomInteractionSkinChangeResponse(this);
		}

		// Token: 0x17003ACA RID: 15050
		// (get) Token: 0x06011BF3 RID: 72691 RVA: 0x0029914F File Offset: 0x0029734F
		// (set) Token: 0x06011BF4 RID: 72692 RVA: 0x00299157 File Offset: 0x00297357
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

		// Token: 0x06011BF5 RID: 72693 RVA: 0x00299160 File Offset: 0x00297360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomInteractionSkinChangeResponse);
		}

		// Token: 0x06011BF6 RID: 72694 RVA: 0x0029916E File Offset: 0x0029736E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomInteractionSkinChangeResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011BF7 RID: 72695 RVA: 0x0029919C File Offset: 0x0029739C
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

		// Token: 0x06011BF8 RID: 72696 RVA: 0x002991E1 File Offset: 0x002973E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011BF9 RID: 72697 RVA: 0x002991EE File Offset: 0x002973EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011BFA RID: 72698 RVA: 0x002991F7 File Offset: 0x002973F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011BFB RID: 72699 RVA: 0x0029922C File Offset: 0x0029742C
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

		// Token: 0x06011BFC RID: 72700 RVA: 0x0029926A File Offset: 0x0029746A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomInteractionSkinChangeResponse other)
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

		// Token: 0x06011BFD RID: 72701 RVA: 0x0029929B File Offset: 0x0029749B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011BFE RID: 72702 RVA: 0x002992A4 File Offset: 0x002974A4
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006FE2 RID: 28642
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006FE3 RID: 28643
		public const int CodeFieldNumber = 10;

		// Token: 0x04006FE4 RID: 28644
		private ErrorCode code_;
	}
}
