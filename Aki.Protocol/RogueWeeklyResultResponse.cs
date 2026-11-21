using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001035 RID: 4149
	[NetMessage(EMessageId.RogueWeeklyResultResponse)]
	public sealed class RogueWeeklyResultResponse : IMessage<RogueWeeklyResultResponse>, IMessage, IEquatable<RogueWeeklyResultResponse>, IDeepCloneable<RogueWeeklyResultResponse>, IBufferMessage
	{
		// Token: 0x0601632E RID: 90926 RVA: 0x0033A24E File Offset: 0x0033844E
		[NullableContext(1)]
		public static RogueWeeklyResultResponse Create()
		{
			return new RogueWeeklyResultResponse();
		}

		// Token: 0x17004A3C RID: 19004
		// (get) Token: 0x0601632F RID: 90927 RVA: 0x0033A255 File Offset: 0x00338455
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A3D RID: 19005
		// (get) Token: 0x06016330 RID: 90928 RVA: 0x0033A258 File Offset: 0x00338458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyResultResponse.Descriptor;
			}
		}

		// Token: 0x06016331 RID: 90929 RVA: 0x0033A25F File Offset: 0x0033845F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyResultResponse()
		{
		}

		// Token: 0x06016332 RID: 90930 RVA: 0x0033A267 File Offset: 0x00338467
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyResultResponse(RogueWeeklyResultResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016333 RID: 90931 RVA: 0x0033A28C File Offset: 0x0033848C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyResultResponse Clone()
		{
			return new RogueWeeklyResultResponse(this);
		}

		// Token: 0x17004A3E RID: 19006
		// (get) Token: 0x06016334 RID: 90932 RVA: 0x0033A294 File Offset: 0x00338494
		// (set) Token: 0x06016335 RID: 90933 RVA: 0x0033A29C File Offset: 0x0033849C
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

		// Token: 0x06016336 RID: 90934 RVA: 0x0033A2A5 File Offset: 0x003384A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyResultResponse);
		}

		// Token: 0x06016337 RID: 90935 RVA: 0x0033A2B3 File Offset: 0x003384B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyResultResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016338 RID: 90936 RVA: 0x0033A2E4 File Offset: 0x003384E4
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

		// Token: 0x06016339 RID: 90937 RVA: 0x0033A329 File Offset: 0x00338529
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601633A RID: 90938 RVA: 0x0033A336 File Offset: 0x00338536
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601633B RID: 90939 RVA: 0x0033A33F File Offset: 0x0033853F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601633C RID: 90940 RVA: 0x0033A374 File Offset: 0x00338574
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

		// Token: 0x0601633D RID: 90941 RVA: 0x0033A3B2 File Offset: 0x003385B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWeeklyResultResponse other)
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

		// Token: 0x0601633E RID: 90942 RVA: 0x0033A3E3 File Offset: 0x003385E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601633F RID: 90943 RVA: 0x0033A3EC File Offset: 0x003385EC
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008546 RID: 34118
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008547 RID: 34119
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04008548 RID: 34120
		private ErrorCode errorCode_;
	}
}
