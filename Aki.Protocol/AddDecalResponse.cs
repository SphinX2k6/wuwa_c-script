using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000A3 RID: 163
	[NetMessage(EMessageId.AddDecalResponse)]
	public sealed class AddDecalResponse : IMessage<AddDecalResponse>, IMessage, IEquatable<AddDecalResponse>, IDeepCloneable<AddDecalResponse>, IBufferMessage
	{
		// Token: 0x06001CB6 RID: 7350 RVA: 0x0004FAFD File Offset: 0x0004DCFD
		[NullableContext(1)]
		public static AddDecalResponse Create()
		{
			return new AddDecalResponse();
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06001CB7 RID: 7351 RVA: 0x0004FB04 File Offset: 0x0004DD04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06001CB8 RID: 7352 RVA: 0x0004FB07 File Offset: 0x0004DD07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddDecalResponse.Descriptor;
			}
		}

		// Token: 0x06001CB9 RID: 7353 RVA: 0x0004FB0E File Offset: 0x0004DD0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddDecalResponse()
		{
		}

		// Token: 0x06001CBA RID: 7354 RVA: 0x0004FB16 File Offset: 0x0004DD16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddDecalResponse(AddDecalResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x0004FB3B File Offset: 0x0004DD3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddDecalResponse Clone()
		{
			return new AddDecalResponse(this);
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06001CBC RID: 7356 RVA: 0x0004FB43 File Offset: 0x0004DD43
		// (set) Token: 0x06001CBD RID: 7357 RVA: 0x0004FB4B File Offset: 0x0004DD4B
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

		// Token: 0x06001CBE RID: 7358 RVA: 0x0004FB54 File Offset: 0x0004DD54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddDecalResponse);
		}

		// Token: 0x06001CBF RID: 7359 RVA: 0x0004FB62 File Offset: 0x0004DD62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddDecalResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001CC0 RID: 7360 RVA: 0x0004FB90 File Offset: 0x0004DD90
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

		// Token: 0x06001CC1 RID: 7361 RVA: 0x0004FBD5 File Offset: 0x0004DDD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001CC2 RID: 7362 RVA: 0x0004FBE2 File Offset: 0x0004DDE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001CC3 RID: 7363 RVA: 0x0004FBEB File Offset: 0x0004DDEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001CC4 RID: 7364 RVA: 0x0004FC20 File Offset: 0x0004DE20
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

		// Token: 0x06001CC5 RID: 7365 RVA: 0x0004FC5E File Offset: 0x0004DE5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AddDecalResponse other)
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

		// Token: 0x06001CC6 RID: 7366 RVA: 0x0004FC8F File Offset: 0x0004DE8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001CC7 RID: 7367 RVA: 0x0004FC98 File Offset: 0x0004DE98
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
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002341 RID: 9025
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002342 RID: 9026
		public const int ErrCodeFieldNumber = 8;

		// Token: 0x04002343 RID: 9027
		private ErrorCode errCode_;
	}
}
