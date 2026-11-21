using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001010 RID: 4112
	[NetMessage(EMessageId.RogueTowerTrialResultRequest)]
	public sealed class RogueTowerTrialResultRequest : IMessage<RogueTowerTrialResultRequest>, IMessage, IEquatable<RogueTowerTrialResultRequest>, IDeepCloneable<RogueTowerTrialResultRequest>, IBufferMessage
	{
		// Token: 0x06016035 RID: 90165 RVA: 0x00333B57 File Offset: 0x00331D57
		[NullableContext(1)]
		public static RogueTowerTrialResultRequest Create()
		{
			return new RogueTowerTrialResultRequest();
		}

		// Token: 0x1700499C RID: 18844
		// (get) Token: 0x06016036 RID: 90166 RVA: 0x00333B5E File Offset: 0x00331D5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700499D RID: 18845
		// (get) Token: 0x06016037 RID: 90167 RVA: 0x00333B61 File Offset: 0x00331D61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTowerTrialResultRequest.Descriptor;
			}
		}

		// Token: 0x06016038 RID: 90168 RVA: 0x00333B68 File Offset: 0x00331D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialResultRequest()
		{
		}

		// Token: 0x06016039 RID: 90169 RVA: 0x00333B70 File Offset: 0x00331D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialResultRequest(RogueTowerTrialResultRequest other) : this()
		{
			this.instId_ = other.instId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601603A RID: 90170 RVA: 0x00333B95 File Offset: 0x00331D95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialResultRequest Clone()
		{
			return new RogueTowerTrialResultRequest(this);
		}

		// Token: 0x1700499E RID: 18846
		// (get) Token: 0x0601603B RID: 90171 RVA: 0x00333B9D File Offset: 0x00331D9D
		// (set) Token: 0x0601603C RID: 90172 RVA: 0x00333BA5 File Offset: 0x00331DA5
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

		// Token: 0x0601603D RID: 90173 RVA: 0x00333BAE File Offset: 0x00331DAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTowerTrialResultRequest);
		}

		// Token: 0x0601603E RID: 90174 RVA: 0x00333BBC File Offset: 0x00331DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTowerTrialResultRequest other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601603F RID: 90175 RVA: 0x00333BEC File Offset: 0x00331DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x06016040 RID: 90176 RVA: 0x00333C2B File Offset: 0x00331E2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016041 RID: 90177 RVA: 0x00333C38 File Offset: 0x00331E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016042 RID: 90178 RVA: 0x00333C41 File Offset: 0x00331E41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016043 RID: 90179 RVA: 0x00333C74 File Offset: 0x00331E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x06016044 RID: 90180 RVA: 0x00333CB2 File Offset: 0x00331EB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTowerTrialResultRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016045 RID: 90181 RVA: 0x00333CE3 File Offset: 0x00331EE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016046 RID: 90182 RVA: 0x00333CEC File Offset: 0x00331EEC
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.InstId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008472 RID: 33906
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008473 RID: 33907
		public const int InstIdFieldNumber = 9;

		// Token: 0x04008474 RID: 33908
		private int instId_;
	}
}
