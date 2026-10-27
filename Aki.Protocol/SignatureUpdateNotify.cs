using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200121B RID: 4635
	[NetMessage(EMessageId.SignatureUpdateNotify)]
	public sealed class SignatureUpdateNotify : IMessage<SignatureUpdateNotify>, IMessage, IEquatable<SignatureUpdateNotify>, IDeepCloneable<SignatureUpdateNotify>, IBufferMessage
	{
		// Token: 0x06018B2F RID: 101167 RVA: 0x0039774A File Offset: 0x0039594A
		[NullableContext(1)]
		public static SignatureUpdateNotify Create()
		{
			return new SignatureUpdateNotify();
		}

		// Token: 0x17005336 RID: 21302
		// (get) Token: 0x06018B30 RID: 101168 RVA: 0x00397751 File Offset: 0x00395951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005337 RID: 21303
		// (get) Token: 0x06018B31 RID: 101169 RVA: 0x00397754 File Offset: 0x00395954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SignatureUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06018B32 RID: 101170 RVA: 0x0039775B File Offset: 0x0039595B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignatureUpdateNotify()
		{
		}

		// Token: 0x06018B33 RID: 101171 RVA: 0x0039776E File Offset: 0x0039596E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignatureUpdateNotify(SignatureUpdateNotify other) : this()
		{
			this.signature_ = other.signature_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018B34 RID: 101172 RVA: 0x00397793 File Offset: 0x00395993
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignatureUpdateNotify Clone()
		{
			return new SignatureUpdateNotify(this);
		}

		// Token: 0x17005338 RID: 21304
		// (get) Token: 0x06018B35 RID: 101173 RVA: 0x0039779B File Offset: 0x0039599B
		// (set) Token: 0x06018B36 RID: 101174 RVA: 0x003977A3 File Offset: 0x003959A3
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

		// Token: 0x06018B37 RID: 101175 RVA: 0x003977B6 File Offset: 0x003959B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SignatureUpdateNotify);
		}

		// Token: 0x06018B38 RID: 101176 RVA: 0x003977C4 File Offset: 0x003959C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SignatureUpdateNotify other)
		{
			return other != null && (other == this || (!(this.Signature != other.Signature) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018B39 RID: 101177 RVA: 0x003977F8 File Offset: 0x003959F8
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

		// Token: 0x06018B3A RID: 101178 RVA: 0x00397839 File Offset: 0x00395A39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018B3B RID: 101179 RVA: 0x00397846 File Offset: 0x00395A46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018B3C RID: 101180 RVA: 0x0039784F File Offset: 0x00395A4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Signature.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteString(this.Signature);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018B3D RID: 101181 RVA: 0x00397888 File Offset: 0x00395A88
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

		// Token: 0x06018B3E RID: 101182 RVA: 0x003978CB File Offset: 0x00395ACB
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

		// Token: 0x06018B3F RID: 101183 RVA: 0x00397901 File Offset: 0x00395B01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018B40 RID: 101184 RVA: 0x0039790C File Offset: 0x00395B0C
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
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Signature = input.ReadString();
				}
			}
		}

		// Token: 0x040091D2 RID: 37330
		private UnknownFieldSet _unknownFields;

		// Token: 0x040091D3 RID: 37331
		public const int SignatureFieldNumber = 9;

		// Token: 0x040091D4 RID: 37332
		private string signature_ = "";
	}
}
