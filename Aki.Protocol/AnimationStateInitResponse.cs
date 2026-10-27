using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000F5 RID: 245
	[NetMessage(EMessageId.AnimationStateInitResponse)]
	public sealed class AnimationStateInitResponse : IMessage<AnimationStateInitResponse>, IMessage, IEquatable<AnimationStateInitResponse>, IDeepCloneable<AnimationStateInitResponse>, IBufferMessage
	{
		// Token: 0x060022F7 RID: 8951 RVA: 0x0005D545 File Offset: 0x0005B745
		[NullableContext(1)]
		public static AnimationStateInitResponse Create()
		{
			return new AnimationStateInitResponse();
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x060022F8 RID: 8952 RVA: 0x0005D54C File Offset: 0x0005B74C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x060022F9 RID: 8953 RVA: 0x0005D54F File Offset: 0x0005B74F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimationStateInitResponse.Descriptor;
			}
		}

		// Token: 0x060022FA RID: 8954 RVA: 0x0005D556 File Offset: 0x0005B756
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateInitResponse()
		{
		}

		// Token: 0x060022FB RID: 8955 RVA: 0x0005D55E File Offset: 0x0005B75E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateInitResponse(AnimationStateInitResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060022FC RID: 8956 RVA: 0x0005D583 File Offset: 0x0005B783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateInitResponse Clone()
		{
			return new AnimationStateInitResponse(this);
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x060022FD RID: 8957 RVA: 0x0005D58B File Offset: 0x0005B78B
		// (set) Token: 0x060022FE RID: 8958 RVA: 0x0005D593 File Offset: 0x0005B793
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

		// Token: 0x060022FF RID: 8959 RVA: 0x0005D59C File Offset: 0x0005B79C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimationStateInitResponse);
		}

		// Token: 0x06002300 RID: 8960 RVA: 0x0005D5AA File Offset: 0x0005B7AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimationStateInitResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002301 RID: 8961 RVA: 0x0005D5D8 File Offset: 0x0005B7D8
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

		// Token: 0x06002302 RID: 8962 RVA: 0x0005D61D File Offset: 0x0005B81D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002303 RID: 8963 RVA: 0x0005D62A File Offset: 0x0005B82A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002304 RID: 8964 RVA: 0x0005D633 File Offset: 0x0005B833
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002305 RID: 8965 RVA: 0x0005D668 File Offset: 0x0005B868
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

		// Token: 0x06002306 RID: 8966 RVA: 0x0005D6A6 File Offset: 0x0005B8A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AnimationStateInitResponse other)
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

		// Token: 0x06002307 RID: 8967 RVA: 0x0005D6D7 File Offset: 0x0005B8D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002308 RID: 8968 RVA: 0x0005D6E0 File Offset: 0x0005B8E0
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040024CA RID: 9418
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024CB RID: 9419
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x040024CC RID: 9420
		private ErrorCode errorCode_;
	}
}
