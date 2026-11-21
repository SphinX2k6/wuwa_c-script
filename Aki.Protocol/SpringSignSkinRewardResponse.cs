using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012F4 RID: 4852
	[NetMessage(EMessageId.SpringSignSkinRewardResponse)]
	public sealed class SpringSignSkinRewardResponse : IMessage<SpringSignSkinRewardResponse>, IMessage, IEquatable<SpringSignSkinRewardResponse>, IDeepCloneable<SpringSignSkinRewardResponse>, IBufferMessage
	{
		// Token: 0x06019E29 RID: 106025 RVA: 0x003C6826 File Offset: 0x003C4A26
		[NullableContext(1)]
		public static SpringSignSkinRewardResponse Create()
		{
			return new SpringSignSkinRewardResponse();
		}

		// Token: 0x170057AA RID: 22442
		// (get) Token: 0x06019E2A RID: 106026 RVA: 0x003C682D File Offset: 0x003C4A2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057AB RID: 22443
		// (get) Token: 0x06019E2B RID: 106027 RVA: 0x003C6830 File Offset: 0x003C4A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringSignSkinRewardResponse.Descriptor;
			}
		}

		// Token: 0x06019E2C RID: 106028 RVA: 0x003C6837 File Offset: 0x003C4A37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignSkinRewardResponse()
		{
		}

		// Token: 0x06019E2D RID: 106029 RVA: 0x003C683F File Offset: 0x003C4A3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignSkinRewardResponse(SpringSignSkinRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019E2E RID: 106030 RVA: 0x003C6864 File Offset: 0x003C4A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringSignSkinRewardResponse Clone()
		{
			return new SpringSignSkinRewardResponse(this);
		}

		// Token: 0x170057AC RID: 22444
		// (get) Token: 0x06019E2F RID: 106031 RVA: 0x003C686C File Offset: 0x003C4A6C
		// (set) Token: 0x06019E30 RID: 106032 RVA: 0x003C6874 File Offset: 0x003C4A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x06019E31 RID: 106033 RVA: 0x003C687D File Offset: 0x003C4A7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringSignSkinRewardResponse);
		}

		// Token: 0x06019E32 RID: 106034 RVA: 0x003C688B File Offset: 0x003C4A8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringSignSkinRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019E33 RID: 106035 RVA: 0x003C68BC File Offset: 0x003C4ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019E34 RID: 106036 RVA: 0x003C6901 File Offset: 0x003C4B01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019E35 RID: 106037 RVA: 0x003C690E File Offset: 0x003C4B0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019E36 RID: 106038 RVA: 0x003C6917 File Offset: 0x003C4B17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019E37 RID: 106039 RVA: 0x003C6948 File Offset: 0x003C4B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019E38 RID: 106040 RVA: 0x003C6986 File Offset: 0x003C4B86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpringSignSkinRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019E39 RID: 106041 RVA: 0x003C69B7 File Offset: 0x003C4BB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019E3A RID: 106042 RVA: 0x003C69C0 File Offset: 0x003C4BC0
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040098A8 RID: 39080
		private UnknownFieldSet _unknownFields;

		// Token: 0x040098A9 RID: 39081
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040098AA RID: 39082
		private ErrorCode errorCode_;
	}
}
