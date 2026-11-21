using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001204 RID: 4612
	[NetMessage(EMessageId.SetBaoziStateResponse)]
	public sealed class SetBaoziStateResponse : IMessage<SetBaoziStateResponse>, IMessage, IEquatable<SetBaoziStateResponse>, IDeepCloneable<SetBaoziStateResponse>, IBufferMessage
	{
		// Token: 0x06018A51 RID: 100945 RVA: 0x0039843B File Offset: 0x0039663B
		[NullableContext(1)]
		public static SetBaoziStateResponse Create()
		{
			return new SetBaoziStateResponse();
		}

		// Token: 0x1700533F RID: 21311
		// (get) Token: 0x06018A52 RID: 100946 RVA: 0x00398442 File Offset: 0x00396642
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005340 RID: 21312
		// (get) Token: 0x06018A53 RID: 100947 RVA: 0x00398445 File Offset: 0x00396645
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetBaoziStateResponse.Descriptor;
			}
		}

		// Token: 0x06018A54 RID: 100948 RVA: 0x0039844C File Offset: 0x0039664C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetBaoziStateResponse()
		{
		}

		// Token: 0x06018A55 RID: 100949 RVA: 0x00398454 File Offset: 0x00396654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetBaoziStateResponse(SetBaoziStateResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018A56 RID: 100950 RVA: 0x00398479 File Offset: 0x00396679
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetBaoziStateResponse Clone()
		{
			return new SetBaoziStateResponse(this);
		}

		// Token: 0x17005341 RID: 21313
		// (get) Token: 0x06018A57 RID: 100951 RVA: 0x00398481 File Offset: 0x00396681
		// (set) Token: 0x06018A58 RID: 100952 RVA: 0x00398489 File Offset: 0x00396689
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x06018A59 RID: 100953 RVA: 0x00398492 File Offset: 0x00396692
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetBaoziStateResponse);
		}

		// Token: 0x06018A5A RID: 100954 RVA: 0x003984A0 File Offset: 0x003966A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetBaoziStateResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018A5B RID: 100955 RVA: 0x003984D0 File Offset: 0x003966D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018A5C RID: 100956 RVA: 0x00398515 File Offset: 0x00396715
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018A5D RID: 100957 RVA: 0x00398522 File Offset: 0x00396722
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018A5E RID: 100958 RVA: 0x0039852B File Offset: 0x0039672B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018A5F RID: 100959 RVA: 0x0039855C File Offset: 0x0039675C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018A60 RID: 100960 RVA: 0x0039859A File Offset: 0x0039679A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetBaoziStateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018A61 RID: 100961 RVA: 0x003985CB File Offset: 0x003967CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018A62 RID: 100962 RVA: 0x003985D4 File Offset: 0x003967D4
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400927D RID: 37501
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400927E RID: 37502
		public const int ErrCodeFieldNumber = 1;

		// Token: 0x0400927F RID: 37503
		private ErrorCode errCode_;
	}
}
