using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x020016B6 RID: 5814
	[NetMessage(EMessageId.AiInformationRequest)]
	public sealed class AiInformationRequest : IMessage<AiInformationRequest>, IMessage, IEquatable<AiInformationRequest>, IDeepCloneable<AiInformationRequest>, IBufferMessage
	{
		// Token: 0x0601D209 RID: 119305 RVA: 0x00442D5C File Offset: 0x00440F5C
		[NullableContext(1)]
		public static AiInformationRequest Create()
		{
			return new AiInformationRequest();
		}

		// Token: 0x170062CE RID: 25294
		// (get) Token: 0x0601D20A RID: 119306 RVA: 0x00442D63 File Offset: 0x00440F63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170062CF RID: 25295
		// (get) Token: 0x0601D20B RID: 119307 RVA: 0x00442D66 File Offset: 0x00440F66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AiInformationRequest.Descriptor;
			}
		}

		// Token: 0x0601D20C RID: 119308 RVA: 0x00442D6D File Offset: 0x00440F6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiInformationRequest()
		{
		}

		// Token: 0x0601D20D RID: 119309 RVA: 0x00442D75 File Offset: 0x00440F75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiInformationRequest(AiInformationRequest other) : this()
		{
			this.aiInfo_ = ((other.aiInfo_ != null) ? other.aiInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D20E RID: 119310 RVA: 0x00442DAA File Offset: 0x00440FAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiInformationRequest Clone()
		{
			return new AiInformationRequest(this);
		}

		// Token: 0x170062D0 RID: 25296
		// (get) Token: 0x0601D20F RID: 119311 RVA: 0x00442DB2 File Offset: 0x00440FB2
		// (set) Token: 0x0601D210 RID: 119312 RVA: 0x00442DBA File Offset: 0x00440FBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiInformation AiInfo
		{
			get
			{
				return this.aiInfo_;
			}
			set
			{
				this.aiInfo_ = value;
			}
		}

		// Token: 0x0601D211 RID: 119313 RVA: 0x00442DC3 File Offset: 0x00440FC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AiInformationRequest);
		}

		// Token: 0x0601D212 RID: 119314 RVA: 0x00442DD1 File Offset: 0x00440FD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AiInformationRequest other)
		{
			return other != null && (other == this || (object.Equals(this.AiInfo, other.AiInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D213 RID: 119315 RVA: 0x00442E04 File Offset: 0x00441004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.aiInfo_ != null)
			{
				num ^= this.AiInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D214 RID: 119316 RVA: 0x00442E40 File Offset: 0x00441040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D215 RID: 119317 RVA: 0x00442E4D File Offset: 0x0044104D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D216 RID: 119318 RVA: 0x00442E56 File Offset: 0x00441056
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.aiInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.AiInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D217 RID: 119319 RVA: 0x00442E88 File Offset: 0x00441088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.aiInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AiInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D218 RID: 119320 RVA: 0x00442EC8 File Offset: 0x004410C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AiInformationRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.aiInfo_ != null)
			{
				if (this.aiInfo_ == null)
				{
					this.AiInfo = new AiInformation();
				}
				this.AiInfo.MergeFrom(other.AiInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D219 RID: 119321 RVA: 0x00442F1C File Offset: 0x0044111C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D21A RID: 119322 RVA: 0x00442F28 File Offset: 0x00441128
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.aiInfo_ == null)
					{
						this.AiInfo = new AiInformation();
					}
					input.ReadMessage(this.AiInfo);
				}
			}
		}

		// Token: 0x0400C460 RID: 50272
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C461 RID: 50273
		public const int AiInfoFieldNumber = 14;

		// Token: 0x0400C462 RID: 50274
		private AiInformation aiInfo_;
	}
}
