using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D28 RID: 3368
	[NetMessage(EMessageId.PhotoMemoryRewardResponse)]
	public sealed class PhotoMemoryRewardResponse : IMessage<PhotoMemoryRewardResponse>, IMessage, IEquatable<PhotoMemoryRewardResponse>, IDeepCloneable<PhotoMemoryRewardResponse>, IBufferMessage
	{
		// Token: 0x06012342 RID: 74562 RVA: 0x002A8CF1 File Offset: 0x002A6EF1
		[NullableContext(1)]
		public static PhotoMemoryRewardResponse Create()
		{
			return new PhotoMemoryRewardResponse();
		}

		// Token: 0x17003C50 RID: 15440
		// (get) Token: 0x06012343 RID: 74563 RVA: 0x002A8CF8 File Offset: 0x002A6EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C51 RID: 15441
		// (get) Token: 0x06012344 RID: 74564 RVA: 0x002A8CFB File Offset: 0x002A6EFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhotoMemoryRewardResponse.Descriptor;
			}
		}

		// Token: 0x06012345 RID: 74565 RVA: 0x002A8D02 File Offset: 0x002A6F02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryRewardResponse()
		{
		}

		// Token: 0x06012346 RID: 74566 RVA: 0x002A8D0A File Offset: 0x002A6F0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryRewardResponse(PhotoMemoryRewardResponse other) : this()
		{
			this.error_ = other.error_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012347 RID: 74567 RVA: 0x002A8D2F File Offset: 0x002A6F2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryRewardResponse Clone()
		{
			return new PhotoMemoryRewardResponse(this);
		}

		// Token: 0x17003C52 RID: 15442
		// (get) Token: 0x06012348 RID: 74568 RVA: 0x002A8D37 File Offset: 0x002A6F37
		// (set) Token: 0x06012349 RID: 74569 RVA: 0x002A8D3F File Offset: 0x002A6F3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Error
		{
			get
			{
				return this.error_;
			}
			set
			{
				this.error_ = value;
			}
		}

		// Token: 0x0601234A RID: 74570 RVA: 0x002A8D48 File Offset: 0x002A6F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhotoMemoryRewardResponse);
		}

		// Token: 0x0601234B RID: 74571 RVA: 0x002A8D56 File Offset: 0x002A6F56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhotoMemoryRewardResponse other)
		{
			return other != null && (other == this || (this.Error == other.Error && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601234C RID: 74572 RVA: 0x002A8D84 File Offset: 0x002A6F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Error != ErrorCode.Success)
			{
				num ^= this.Error.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601234D RID: 74573 RVA: 0x002A8DC9 File Offset: 0x002A6FC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601234E RID: 74574 RVA: 0x002A8DD6 File Offset: 0x002A6FD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601234F RID: 74575 RVA: 0x002A8DDF File Offset: 0x002A6FDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Error != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.Error);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012350 RID: 74576 RVA: 0x002A8E14 File Offset: 0x002A7014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Error != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Error);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012351 RID: 74577 RVA: 0x002A8E52 File Offset: 0x002A7052
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhotoMemoryRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Error != ErrorCode.Success)
			{
				this.Error = other.Error;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012352 RID: 74578 RVA: 0x002A8E83 File Offset: 0x002A7083
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012353 RID: 74579 RVA: 0x002A8E8C File Offset: 0x002A708C
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
					this.Error = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007208 RID: 29192
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007209 RID: 29193
		public const int ErrorFieldNumber = 8;

		// Token: 0x0400720A RID: 29194
		private ErrorCode error_;
	}
}
