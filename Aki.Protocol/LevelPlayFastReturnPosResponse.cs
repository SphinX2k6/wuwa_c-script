using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008E8 RID: 2280
	[NetMessage(EMessageId.LevelPlayFastReturnPosResponse)]
	public sealed class LevelPlayFastReturnPosResponse : IMessage<LevelPlayFastReturnPosResponse>, IMessage, IEquatable<LevelPlayFastReturnPosResponse>, IDeepCloneable<LevelPlayFastReturnPosResponse>, IBufferMessage
	{
		// Token: 0x0600C9E2 RID: 51682 RVA: 0x001DD195 File Offset: 0x001DB395
		[NullableContext(1)]
		public static LevelPlayFastReturnPosResponse Create()
		{
			return new LevelPlayFastReturnPosResponse();
		}

		// Token: 0x170028BE RID: 10430
		// (get) Token: 0x0600C9E3 RID: 51683 RVA: 0x001DD19C File Offset: 0x001DB39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028BF RID: 10431
		// (get) Token: 0x0600C9E4 RID: 51684 RVA: 0x001DD19F File Offset: 0x001DB39F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayFastReturnPosResponse.Descriptor;
			}
		}

		// Token: 0x0600C9E5 RID: 51685 RVA: 0x001DD1A6 File Offset: 0x001DB3A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayFastReturnPosResponse()
		{
		}

		// Token: 0x0600C9E6 RID: 51686 RVA: 0x001DD1AE File Offset: 0x001DB3AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayFastReturnPosResponse(LevelPlayFastReturnPosResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C9E7 RID: 51687 RVA: 0x001DD1D3 File Offset: 0x001DB3D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayFastReturnPosResponse Clone()
		{
			return new LevelPlayFastReturnPosResponse(this);
		}

		// Token: 0x170028C0 RID: 10432
		// (get) Token: 0x0600C9E8 RID: 51688 RVA: 0x001DD1DB File Offset: 0x001DB3DB
		// (set) Token: 0x0600C9E9 RID: 51689 RVA: 0x001DD1E3 File Offset: 0x001DB3E3
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

		// Token: 0x0600C9EA RID: 51690 RVA: 0x001DD1EC File Offset: 0x001DB3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayFastReturnPosResponse);
		}

		// Token: 0x0600C9EB RID: 51691 RVA: 0x001DD1FA File Offset: 0x001DB3FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayFastReturnPosResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C9EC RID: 51692 RVA: 0x001DD228 File Offset: 0x001DB428
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

		// Token: 0x0600C9ED RID: 51693 RVA: 0x001DD26D File Offset: 0x001DB46D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C9EE RID: 51694 RVA: 0x001DD27A File Offset: 0x001DB47A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C9EF RID: 51695 RVA: 0x001DD283 File Offset: 0x001DB483
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

		// Token: 0x0600C9F0 RID: 51696 RVA: 0x001DD2B8 File Offset: 0x001DB4B8
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

		// Token: 0x0600C9F1 RID: 51697 RVA: 0x001DD2F6 File Offset: 0x001DB4F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayFastReturnPosResponse other)
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

		// Token: 0x0600C9F2 RID: 51698 RVA: 0x001DD327 File Offset: 0x001DB527
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C9F3 RID: 51699 RVA: 0x001DD330 File Offset: 0x001DB530
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

		// Token: 0x04005652 RID: 22098
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005653 RID: 22099
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04005654 RID: 22100
		private ErrorCode errorCode_;
	}
}
