using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001257 RID: 4695
	[NetMessage(EMessageId.SignatureUpdateNotify)]
	public sealed class SignatureUpdateNotify : IMessage<SignatureUpdateNotify>, IMessage, IEquatable<SignatureUpdateNotify>, IDeepCloneable<SignatureUpdateNotify>, IBufferMessage
	{
		// Token: 0x06019109 RID: 102665 RVA: 0x003A75F3 File Offset: 0x003A57F3
		[NullableContext(1)]
		public static SignatureUpdateNotify Create()
		{
			return new SignatureUpdateNotify();
		}

		// Token: 0x170054B3 RID: 21683
		// (get) Token: 0x0601910A RID: 102666 RVA: 0x003A75FA File Offset: 0x003A57FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170054B4 RID: 21684
		// (get) Token: 0x0601910B RID: 102667 RVA: 0x003A75FD File Offset: 0x003A57FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SignatureUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601910C RID: 102668 RVA: 0x003A7604 File Offset: 0x003A5804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignatureUpdateNotify()
		{
		}

		// Token: 0x0601910D RID: 102669 RVA: 0x003A7617 File Offset: 0x003A5817
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignatureUpdateNotify(SignatureUpdateNotify other) : this()
		{
			this.signature_ = other.signature_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601910E RID: 102670 RVA: 0x003A763C File Offset: 0x003A583C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignatureUpdateNotify Clone()
		{
			return new SignatureUpdateNotify(this);
		}

		// Token: 0x170054B5 RID: 21685
		// (get) Token: 0x0601910F RID: 102671 RVA: 0x003A7644 File Offset: 0x003A5844
		// (set) Token: 0x06019110 RID: 102672 RVA: 0x003A764C File Offset: 0x003A584C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Signature
		{
			get
			{
				return this.signature_;
			}
			set
			{
				this.signature_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06019111 RID: 102673 RVA: 0x003A765F File Offset: 0x003A585F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SignatureUpdateNotify);
		}

		// Token: 0x06019112 RID: 102674 RVA: 0x003A766D File Offset: 0x003A586D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SignatureUpdateNotify other)
		{
			return other != null && (other == this || (!(this.Signature != other.Signature) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019113 RID: 102675 RVA: 0x003A76A0 File Offset: 0x003A58A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Signature.Length != 0)
			{
				num ^= this.Signature.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019114 RID: 102676 RVA: 0x003A76E1 File Offset: 0x003A58E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019115 RID: 102677 RVA: 0x003A76EE File Offset: 0x003A58EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019116 RID: 102678 RVA: 0x003A76F7 File Offset: 0x003A58F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Signature.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Signature);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019117 RID: 102679 RVA: 0x003A7730 File Offset: 0x003A5930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Signature.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Signature);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019118 RID: 102680 RVA: 0x003A7773 File Offset: 0x003A5973
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SignatureUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Signature.Length != 0)
			{
				this.Signature = other.Signature;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019119 RID: 102681 RVA: 0x003A77A9 File Offset: 0x003A59A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601911A RID: 102682 RVA: 0x003A77B4 File Offset: 0x003A59B4
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Signature = input.ReadString();
				}
			}
		}

		// Token: 0x04009483 RID: 38019
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009484 RID: 38020
		public const int SignatureFieldNumber = 4;

		// Token: 0x04009485 RID: 38021
		private string signature_ = "";
	}
}
