using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D38 RID: 3384
	[NetMessage(EMessageId.PhotoMemoryRewardResponse)]
	public sealed class PhotoMemoryRewardResponse : IMessage<PhotoMemoryRewardResponse>, IMessage, IEquatable<PhotoMemoryRewardResponse>, IDeepCloneable<PhotoMemoryRewardResponse>, IBufferMessage
	{
		// Token: 0x0601243E RID: 74814 RVA: 0x002AA919 File Offset: 0x002A8B19
		[NullableContext(1)]
		public static PhotoMemoryRewardResponse Create()
		{
			return new PhotoMemoryRewardResponse();
		}

		// Token: 0x17003C85 RID: 15493
		// (get) Token: 0x0601243F RID: 74815 RVA: 0x002AA920 File Offset: 0x002A8B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C86 RID: 15494
		// (get) Token: 0x06012440 RID: 74816 RVA: 0x002AA923 File Offset: 0x002A8B23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhotoMemoryRewardResponse.Descriptor;
			}
		}

		// Token: 0x06012441 RID: 74817 RVA: 0x002AA92A File Offset: 0x002A8B2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryRewardResponse()
		{
		}

		// Token: 0x06012442 RID: 74818 RVA: 0x002AA932 File Offset: 0x002A8B32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryRewardResponse(PhotoMemoryRewardResponse other) : this()
		{
			this.error_ = other.error_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012443 RID: 74819 RVA: 0x002AA957 File Offset: 0x002A8B57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryRewardResponse Clone()
		{
			return new PhotoMemoryRewardResponse(this);
		}

		// Token: 0x17003C87 RID: 15495
		// (get) Token: 0x06012444 RID: 74820 RVA: 0x002AA95F File Offset: 0x002A8B5F
		// (set) Token: 0x06012445 RID: 74821 RVA: 0x002AA967 File Offset: 0x002A8B67
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

		// Token: 0x06012446 RID: 74822 RVA: 0x002AA970 File Offset: 0x002A8B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhotoMemoryRewardResponse);
		}

		// Token: 0x06012447 RID: 74823 RVA: 0x002AA97E File Offset: 0x002A8B7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhotoMemoryRewardResponse other)
		{
			return other != null && (other == this || (this.Error == other.Error && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012448 RID: 74824 RVA: 0x002AA9AC File Offset: 0x002A8BAC
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

		// Token: 0x06012449 RID: 74825 RVA: 0x002AA9F1 File Offset: 0x002A8BF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601244A RID: 74826 RVA: 0x002AA9FE File Offset: 0x002A8BFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601244B RID: 74827 RVA: 0x002AAA07 File Offset: 0x002A8C07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Error != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.Error);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601244C RID: 74828 RVA: 0x002AAA3C File Offset: 0x002A8C3C
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

		// Token: 0x0601244D RID: 74829 RVA: 0x002AAA7A File Offset: 0x002A8C7A
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

		// Token: 0x0601244E RID: 74830 RVA: 0x002AAAAB File Offset: 0x002A8CAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601244F RID: 74831 RVA: 0x002AAAB4 File Offset: 0x002A8CB4
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Error = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040071F0 RID: 29168
		private UnknownFieldSet _unknownFields;

		// Token: 0x040071F1 RID: 29169
		public const int ErrorFieldNumber = 11;

		// Token: 0x040071F2 RID: 29170
		private ErrorCode error_;
	}
}
