using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200069B RID: 1691
	[NetMessage(EMessageId.GameplayTagResponse)]
	public sealed class GameplayTagResponse : IMessage<GameplayTagResponse>, IMessage, IEquatable<GameplayTagResponse>, IDeepCloneable<GameplayTagResponse>, IBufferMessage
	{
		// Token: 0x06009B9E RID: 39838 RVA: 0x0017B434 File Offset: 0x00179634
		[NullableContext(1)]
		public static GameplayTagResponse Create()
		{
			return new GameplayTagResponse();
		}

		// Token: 0x17001F48 RID: 8008
		// (get) Token: 0x06009B9F RID: 39839 RVA: 0x0017B43B File Offset: 0x0017963B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F49 RID: 8009
		// (get) Token: 0x06009BA0 RID: 39840 RVA: 0x0017B43E File Offset: 0x0017963E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameplayTagResponse.Descriptor;
			}
		}

		// Token: 0x06009BA1 RID: 39841 RVA: 0x0017B445 File Offset: 0x00179645
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayTagResponse()
		{
		}

		// Token: 0x06009BA2 RID: 39842 RVA: 0x0017B44D File Offset: 0x0017964D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayTagResponse(GameplayTagResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009BA3 RID: 39843 RVA: 0x0017B472 File Offset: 0x00179672
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayTagResponse Clone()
		{
			return new GameplayTagResponse(this);
		}

		// Token: 0x17001F4A RID: 8010
		// (get) Token: 0x06009BA4 RID: 39844 RVA: 0x0017B47A File Offset: 0x0017967A
		// (set) Token: 0x06009BA5 RID: 39845 RVA: 0x0017B482 File Offset: 0x00179682
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

		// Token: 0x06009BA6 RID: 39846 RVA: 0x0017B48B File Offset: 0x0017968B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameplayTagResponse);
		}

		// Token: 0x06009BA7 RID: 39847 RVA: 0x0017B499 File Offset: 0x00179699
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GameplayTagResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009BA8 RID: 39848 RVA: 0x0017B4C8 File Offset: 0x001796C8
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

		// Token: 0x06009BA9 RID: 39849 RVA: 0x0017B50D File Offset: 0x0017970D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009BAA RID: 39850 RVA: 0x0017B51A File Offset: 0x0017971A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009BAB RID: 39851 RVA: 0x0017B523 File Offset: 0x00179723
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009BAC RID: 39852 RVA: 0x0017B558 File Offset: 0x00179758
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

		// Token: 0x06009BAD RID: 39853 RVA: 0x0017B596 File Offset: 0x00179796
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GameplayTagResponse other)
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

		// Token: 0x06009BAE RID: 39854 RVA: 0x0017B5C7 File Offset: 0x001797C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009BAF RID: 39855 RVA: 0x0017B5D0 File Offset: 0x001797D0
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040049DE RID: 18910
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049DF RID: 18911
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x040049E0 RID: 18912
		private ErrorCode errorCode_;
	}
}
