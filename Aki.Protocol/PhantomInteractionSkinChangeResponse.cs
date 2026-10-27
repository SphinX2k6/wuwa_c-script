using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CDB RID: 3291
	[NetMessage(EMessageId.PhantomInteractionSkinChangeResponse)]
	public sealed class PhantomInteractionSkinChangeResponse : IMessage<PhantomInteractionSkinChangeResponse>, IMessage, IEquatable<PhantomInteractionSkinChangeResponse>, IDeepCloneable<PhantomInteractionSkinChangeResponse>, IBufferMessage
	{
		// Token: 0x06011CE9 RID: 72937 RVA: 0x0029AD25 File Offset: 0x00298F25
		[NullableContext(1)]
		public static PhantomInteractionSkinChangeResponse Create()
		{
			return new PhantomInteractionSkinChangeResponse();
		}

		// Token: 0x17003AFD RID: 15101
		// (get) Token: 0x06011CEA RID: 72938 RVA: 0x0029AD2C File Offset: 0x00298F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003AFE RID: 15102
		// (get) Token: 0x06011CEB RID: 72939 RVA: 0x0029AD2F File Offset: 0x00298F2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomInteractionSkinChangeResponse.Descriptor;
			}
		}

		// Token: 0x06011CEC RID: 72940 RVA: 0x0029AD36 File Offset: 0x00298F36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomInteractionSkinChangeResponse()
		{
		}

		// Token: 0x06011CED RID: 72941 RVA: 0x0029AD3E File Offset: 0x00298F3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomInteractionSkinChangeResponse(PhantomInteractionSkinChangeResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011CEE RID: 72942 RVA: 0x0029AD63 File Offset: 0x00298F63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomInteractionSkinChangeResponse Clone()
		{
			return new PhantomInteractionSkinChangeResponse(this);
		}

		// Token: 0x17003AFF RID: 15103
		// (get) Token: 0x06011CEF RID: 72943 RVA: 0x0029AD6B File Offset: 0x00298F6B
		// (set) Token: 0x06011CF0 RID: 72944 RVA: 0x0029AD73 File Offset: 0x00298F73
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

		// Token: 0x06011CF1 RID: 72945 RVA: 0x0029AD7C File Offset: 0x00298F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomInteractionSkinChangeResponse);
		}

		// Token: 0x06011CF2 RID: 72946 RVA: 0x0029AD8A File Offset: 0x00298F8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomInteractionSkinChangeResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011CF3 RID: 72947 RVA: 0x0029ADB8 File Offset: 0x00298FB8
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

		// Token: 0x06011CF4 RID: 72948 RVA: 0x0029ADFD File Offset: 0x00298FFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011CF5 RID: 72949 RVA: 0x0029AE0A File Offset: 0x0029900A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011CF6 RID: 72950 RVA: 0x0029AE13 File Offset: 0x00299013
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011CF7 RID: 72951 RVA: 0x0029AE48 File Offset: 0x00299048
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

		// Token: 0x06011CF8 RID: 72952 RVA: 0x0029AE86 File Offset: 0x00299086
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

		// Token: 0x06011CF9 RID: 72953 RVA: 0x0029AEB7 File Offset: 0x002990B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011CFA RID: 72954 RVA: 0x0029AEC0 File Offset: 0x002990C0
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
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006FCA RID: 28618
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006FCB RID: 28619
		public const int CodeFieldNumber = 4;

		// Token: 0x04006FCC RID: 28620
		private ErrorCode code_;
	}
}
