using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DE3 RID: 3555
	[NetMessage(EMessageId.PrivateChatOperateResponse)]
	public sealed class PrivateChatOperateResponse : IMessage<PrivateChatOperateResponse>, IMessage, IEquatable<PrivateChatOperateResponse>, IDeepCloneable<PrivateChatOperateResponse>, IBufferMessage
	{
		// Token: 0x06013206 RID: 78342 RVA: 0x002C93A4 File Offset: 0x002C75A4
		[NullableContext(1)]
		public static PrivateChatOperateResponse Create()
		{
			return new PrivateChatOperateResponse();
		}

		// Token: 0x17003F73 RID: 16243
		// (get) Token: 0x06013207 RID: 78343 RVA: 0x002C93AB File Offset: 0x002C75AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F74 RID: 16244
		// (get) Token: 0x06013208 RID: 78344 RVA: 0x002C93AE File Offset: 0x002C75AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PrivateChatOperateResponse.Descriptor;
			}
		}

		// Token: 0x06013209 RID: 78345 RVA: 0x002C93B5 File Offset: 0x002C75B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatOperateResponse()
		{
		}

		// Token: 0x0601320A RID: 78346 RVA: 0x002C93BD File Offset: 0x002C75BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatOperateResponse(PrivateChatOperateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601320B RID: 78347 RVA: 0x002C93E2 File Offset: 0x002C75E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatOperateResponse Clone()
		{
			return new PrivateChatOperateResponse(this);
		}

		// Token: 0x17003F75 RID: 16245
		// (get) Token: 0x0601320C RID: 78348 RVA: 0x002C93EA File Offset: 0x002C75EA
		// (set) Token: 0x0601320D RID: 78349 RVA: 0x002C93F2 File Offset: 0x002C75F2
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

		// Token: 0x0601320E RID: 78350 RVA: 0x002C93FB File Offset: 0x002C75FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PrivateChatOperateResponse);
		}

		// Token: 0x0601320F RID: 78351 RVA: 0x002C9409 File Offset: 0x002C7609
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PrivateChatOperateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013210 RID: 78352 RVA: 0x002C9438 File Offset: 0x002C7638
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

		// Token: 0x06013211 RID: 78353 RVA: 0x002C947D File Offset: 0x002C767D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013212 RID: 78354 RVA: 0x002C948A File Offset: 0x002C768A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013213 RID: 78355 RVA: 0x002C9493 File Offset: 0x002C7693
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013214 RID: 78356 RVA: 0x002C94C8 File Offset: 0x002C76C8
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

		// Token: 0x06013215 RID: 78357 RVA: 0x002C9506 File Offset: 0x002C7706
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PrivateChatOperateResponse other)
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

		// Token: 0x06013216 RID: 78358 RVA: 0x002C9537 File Offset: 0x002C7737
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013217 RID: 78359 RVA: 0x002C9540 File Offset: 0x002C7740
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040075DE RID: 30174
		private UnknownFieldSet _unknownFields;

		// Token: 0x040075DF RID: 30175
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x040075E0 RID: 30176
		private ErrorCode errorCode_;
	}
}
