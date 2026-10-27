using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CEB RID: 3307
	[NetMessage(EMessageId.PhantomMusicSaveResponse)]
	public sealed class PhantomMusicSaveResponse : IMessage<PhantomMusicSaveResponse>, IMessage, IEquatable<PhantomMusicSaveResponse>, IDeepCloneable<PhantomMusicSaveResponse>, IBufferMessage
	{
		// Token: 0x06011E34 RID: 73268 RVA: 0x0029DD7D File Offset: 0x0029BF7D
		[NullableContext(1)]
		public static PhantomMusicSaveResponse Create()
		{
			return new PhantomMusicSaveResponse();
		}

		// Token: 0x17003B47 RID: 15175
		// (get) Token: 0x06011E35 RID: 73269 RVA: 0x0029DD84 File Offset: 0x0029BF84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B48 RID: 15176
		// (get) Token: 0x06011E36 RID: 73270 RVA: 0x0029DD87 File Offset: 0x0029BF87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomMusicSaveResponse.Descriptor;
			}
		}

		// Token: 0x06011E37 RID: 73271 RVA: 0x0029DD8E File Offset: 0x0029BF8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicSaveResponse()
		{
		}

		// Token: 0x06011E38 RID: 73272 RVA: 0x0029DD96 File Offset: 0x0029BF96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicSaveResponse(PhantomMusicSaveResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011E39 RID: 73273 RVA: 0x0029DDBB File Offset: 0x0029BFBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicSaveResponse Clone()
		{
			return new PhantomMusicSaveResponse(this);
		}

		// Token: 0x17003B49 RID: 15177
		// (get) Token: 0x06011E3A RID: 73274 RVA: 0x0029DDC3 File Offset: 0x0029BFC3
		// (set) Token: 0x06011E3B RID: 73275 RVA: 0x0029DDCB File Offset: 0x0029BFCB
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

		// Token: 0x06011E3C RID: 73276 RVA: 0x0029DDD4 File Offset: 0x0029BFD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomMusicSaveResponse);
		}

		// Token: 0x06011E3D RID: 73277 RVA: 0x0029DDE2 File Offset: 0x0029BFE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomMusicSaveResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011E3E RID: 73278 RVA: 0x0029DE10 File Offset: 0x0029C010
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

		// Token: 0x06011E3F RID: 73279 RVA: 0x0029DE55 File Offset: 0x0029C055
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011E40 RID: 73280 RVA: 0x0029DE62 File Offset: 0x0029C062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011E41 RID: 73281 RVA: 0x0029DE6B File Offset: 0x0029C06B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011E42 RID: 73282 RVA: 0x0029DEA0 File Offset: 0x0029C0A0
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

		// Token: 0x06011E43 RID: 73283 RVA: 0x0029DEDE File Offset: 0x0029C0DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomMusicSaveResponse other)
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

		// Token: 0x06011E44 RID: 73284 RVA: 0x0029DF0F File Offset: 0x0029C10F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011E45 RID: 73285 RVA: 0x0029DF18 File Offset: 0x0029C118
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400703F RID: 28735
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007040 RID: 28736
		public const int ErrCodeFieldNumber = 14;

		// Token: 0x04007041 RID: 28737
		private ErrorCode errCode_;
	}
}
