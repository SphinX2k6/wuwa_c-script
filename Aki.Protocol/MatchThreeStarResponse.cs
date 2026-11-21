using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009B7 RID: 2487
	[NetMessage(EMessageId.MatchThreeStarResponse)]
	public sealed class MatchThreeStarResponse : IMessage<MatchThreeStarResponse>, IMessage, IEquatable<MatchThreeStarResponse>, IDeepCloneable<MatchThreeStarResponse>, IBufferMessage
	{
		// Token: 0x0600DA99 RID: 55961 RVA: 0x0020214C File Offset: 0x0020034C
		[NullableContext(1)]
		public static MatchThreeStarResponse Create()
		{
			return new MatchThreeStarResponse();
		}

		// Token: 0x17002C4C RID: 11340
		// (get) Token: 0x0600DA9A RID: 55962 RVA: 0x00202153 File Offset: 0x00200353
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C4D RID: 11341
		// (get) Token: 0x0600DA9B RID: 55963 RVA: 0x00202156 File Offset: 0x00200356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchThreeStarResponse.Descriptor;
			}
		}

		// Token: 0x0600DA9C RID: 55964 RVA: 0x0020215D File Offset: 0x0020035D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeStarResponse()
		{
		}

		// Token: 0x0600DA9D RID: 55965 RVA: 0x00202170 File Offset: 0x00200370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeStarResponse(MatchThreeStarResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.traceId_ = other.traceId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DA9E RID: 55966 RVA: 0x002021A1 File Offset: 0x002003A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeStarResponse Clone()
		{
			return new MatchThreeStarResponse(this);
		}

		// Token: 0x17002C4E RID: 11342
		// (get) Token: 0x0600DA9F RID: 55967 RVA: 0x002021A9 File Offset: 0x002003A9
		// (set) Token: 0x0600DAA0 RID: 55968 RVA: 0x002021B1 File Offset: 0x002003B1
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

		// Token: 0x17002C4F RID: 11343
		// (get) Token: 0x0600DAA1 RID: 55969 RVA: 0x002021BA File Offset: 0x002003BA
		// (set) Token: 0x0600DAA2 RID: 55970 RVA: 0x002021C2 File Offset: 0x002003C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TraceId
		{
			get
			{
				return this.traceId_;
			}
			set
			{
				this.traceId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0600DAA3 RID: 55971 RVA: 0x002021D5 File Offset: 0x002003D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchThreeStarResponse);
		}

		// Token: 0x0600DAA4 RID: 55972 RVA: 0x002021E4 File Offset: 0x002003E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchThreeStarResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && !(this.TraceId != other.TraceId) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DAA5 RID: 55973 RVA: 0x00202234 File Offset: 0x00200434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.TraceId.Length != 0)
			{
				num ^= this.TraceId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DAA6 RID: 55974 RVA: 0x00202294 File Offset: 0x00200494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DAA7 RID: 55975 RVA: 0x002022A1 File Offset: 0x002004A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DAA8 RID: 55976 RVA: 0x002022AC File Offset: 0x002004AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TraceId.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.TraceId);
			}
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

		// Token: 0x0600DAA9 RID: 55977 RVA: 0x0020230C File Offset: 0x0020050C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.TraceId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TraceId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DAAA RID: 55978 RVA: 0x00202368 File Offset: 0x00200568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchThreeStarResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.TraceId.Length != 0)
			{
				this.TraceId = other.TraceId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DAAB RID: 55979 RVA: 0x002023BD File Offset: 0x002005BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DAAC RID: 55980 RVA: 0x002023C8 File Offset: 0x002005C8
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
				if (num != 34U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.TraceId = input.ReadString();
				}
			}
		}

		// Token: 0x04005B2E RID: 23342
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B2F RID: 23343
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04005B30 RID: 23344
		private ErrorCode errorCode_;

		// Token: 0x04005B31 RID: 23345
		public const int TraceIdFieldNumber = 4;

		// Token: 0x04005B32 RID: 23346
		private string traceId_ = "";
	}
}
