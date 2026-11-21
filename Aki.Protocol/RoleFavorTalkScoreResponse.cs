using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001069 RID: 4201
	[NetMessage(EMessageId.RoleFavorTalkScoreResponse)]
	public sealed class RoleFavorTalkScoreResponse : IMessage<RoleFavorTalkScoreResponse>, IMessage, IEquatable<RoleFavorTalkScoreResponse>, IDeepCloneable<RoleFavorTalkScoreResponse>, IBufferMessage
	{
		// Token: 0x06016799 RID: 92057 RVA: 0x00345078 File Offset: 0x00343278
		[NullableContext(1)]
		public static RoleFavorTalkScoreResponse Create()
		{
			return new RoleFavorTalkScoreResponse();
		}

		// Token: 0x17004B45 RID: 19269
		// (get) Token: 0x0601679A RID: 92058 RVA: 0x0034507F File Offset: 0x0034327F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B46 RID: 19270
		// (get) Token: 0x0601679B RID: 92059 RVA: 0x00345082 File Offset: 0x00343282
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleFavorTalkScoreResponse.Descriptor;
			}
		}

		// Token: 0x0601679C RID: 92060 RVA: 0x00345089 File Offset: 0x00343289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorTalkScoreResponse()
		{
		}

		// Token: 0x0601679D RID: 92061 RVA: 0x00345091 File Offset: 0x00343291
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorTalkScoreResponse(RoleFavorTalkScoreResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this.isComplete_ = other.isComplete_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601679E RID: 92062 RVA: 0x003450C2 File Offset: 0x003432C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorTalkScoreResponse Clone()
		{
			return new RoleFavorTalkScoreResponse(this);
		}

		// Token: 0x17004B47 RID: 19271
		// (get) Token: 0x0601679F RID: 92063 RVA: 0x003450CA File Offset: 0x003432CA
		// (set) Token: 0x060167A0 RID: 92064 RVA: 0x003450D2 File Offset: 0x003432D2
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

		// Token: 0x17004B48 RID: 19272
		// (get) Token: 0x060167A1 RID: 92065 RVA: 0x003450DB File Offset: 0x003432DB
		// (set) Token: 0x060167A2 RID: 92066 RVA: 0x003450E3 File Offset: 0x003432E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsComplete
		{
			get
			{
				return this.isComplete_;
			}
			set
			{
				this.isComplete_ = value;
			}
		}

		// Token: 0x060167A3 RID: 92067 RVA: 0x003450EC File Offset: 0x003432EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleFavorTalkScoreResponse);
		}

		// Token: 0x060167A4 RID: 92068 RVA: 0x003450FA File Offset: 0x003432FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleFavorTalkScoreResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && this.IsComplete == other.IsComplete && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060167A5 RID: 92069 RVA: 0x00345138 File Offset: 0x00343338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this.IsComplete)
			{
				num ^= this.IsComplete.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060167A6 RID: 92070 RVA: 0x00345196 File Offset: 0x00343396
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060167A7 RID: 92071 RVA: 0x003451A3 File Offset: 0x003433A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060167A8 RID: 92072 RVA: 0x003451AC File Offset: 0x003433AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsComplete)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsComplete);
			}
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060167A9 RID: 92073 RVA: 0x00345208 File Offset: 0x00343408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this.IsComplete)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060167AA RID: 92074 RVA: 0x00345254 File Offset: 0x00343454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleFavorTalkScoreResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			if (other.IsComplete)
			{
				this.IsComplete = other.IsComplete;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060167AB RID: 92075 RVA: 0x003452A4 File Offset: 0x003434A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060167AC RID: 92076 RVA: 0x003452B0 File Offset: 0x003434B0
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
				if (num != 40U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.IsComplete = input.ReadBool();
				}
			}
		}

		// Token: 0x040086DD RID: 34525
		private UnknownFieldSet _unknownFields;

		// Token: 0x040086DE RID: 34526
		public const int ErrCodeFieldNumber = 9;

		// Token: 0x040086DF RID: 34527
		private ErrorCode errCode_;

		// Token: 0x040086E0 RID: 34528
		public const int IsCompleteFieldNumber = 5;

		// Token: 0x040086E1 RID: 34529
		private bool isComplete_;
	}
}
