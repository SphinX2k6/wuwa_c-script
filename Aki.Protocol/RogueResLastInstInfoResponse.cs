using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FE3 RID: 4067
	[NetMessage(EMessageId.RogueResLastInstInfoResponse)]
	public sealed class RogueResLastInstInfoResponse : IMessage<RogueResLastInstInfoResponse>, IMessage, IEquatable<RogueResLastInstInfoResponse>, IDeepCloneable<RogueResLastInstInfoResponse>, IBufferMessage
	{
		// Token: 0x06015C4F RID: 89167 RVA: 0x0032A1F6 File Offset: 0x003283F6
		[NullableContext(1)]
		public static RogueResLastInstInfoResponse Create()
		{
			return new RogueResLastInstInfoResponse();
		}

		// Token: 0x170048B2 RID: 18610
		// (get) Token: 0x06015C50 RID: 89168 RVA: 0x0032A1FD File Offset: 0x003283FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170048B3 RID: 18611
		// (get) Token: 0x06015C51 RID: 89169 RVA: 0x0032A200 File Offset: 0x00328400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResLastInstInfoResponse.Descriptor;
			}
		}

		// Token: 0x06015C52 RID: 89170 RVA: 0x0032A207 File Offset: 0x00328407
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResLastInstInfoResponse()
		{
		}

		// Token: 0x06015C53 RID: 89171 RVA: 0x0032A20F File Offset: 0x0032840F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResLastInstInfoResponse(RogueResLastInstInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.instId_ = other.instId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015C54 RID: 89172 RVA: 0x0032A240 File Offset: 0x00328440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResLastInstInfoResponse Clone()
		{
			return new RogueResLastInstInfoResponse(this);
		}

		// Token: 0x170048B4 RID: 18612
		// (get) Token: 0x06015C55 RID: 89173 RVA: 0x0032A248 File Offset: 0x00328448
		// (set) Token: 0x06015C56 RID: 89174 RVA: 0x0032A250 File Offset: 0x00328450
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

		// Token: 0x170048B5 RID: 18613
		// (get) Token: 0x06015C57 RID: 89175 RVA: 0x0032A259 File Offset: 0x00328459
		// (set) Token: 0x06015C58 RID: 89176 RVA: 0x0032A261 File Offset: 0x00328461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x06015C59 RID: 89177 RVA: 0x0032A26A File Offset: 0x0032846A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResLastInstInfoResponse);
		}

		// Token: 0x06015C5A RID: 89178 RVA: 0x0032A278 File Offset: 0x00328478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResLastInstInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.InstId == other.InstId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015C5B RID: 89179 RVA: 0x0032A2B8 File Offset: 0x003284B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015C5C RID: 89180 RVA: 0x0032A316 File Offset: 0x00328516
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015C5D RID: 89181 RVA: 0x0032A323 File Offset: 0x00328523
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015C5E RID: 89182 RVA: 0x0032A32C File Offset: 0x0032852C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.InstId);
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

		// Token: 0x06015C5F RID: 89183 RVA: 0x0032A388 File Offset: 0x00328588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015C60 RID: 89184 RVA: 0x0032A3E0 File Offset: 0x003285E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResLastInstInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015C61 RID: 89185 RVA: 0x0032A430 File Offset: 0x00328630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015C62 RID: 89186 RVA: 0x0032A43C File Offset: 0x0032863C
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
					this.InstId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008320 RID: 33568
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008321 RID: 33569
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04008322 RID: 33570
		private ErrorCode errorCode_;

		// Token: 0x04008323 RID: 33571
		public const int InstIdFieldNumber = 3;

		// Token: 0x04008324 RID: 33572
		private int instId_;
	}
}
