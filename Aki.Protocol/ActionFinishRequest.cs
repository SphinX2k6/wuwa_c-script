using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200006C RID: 108
	[NetMessage(EMessageId.ActionFinishRequest)]
	public sealed class ActionFinishRequest : IMessage<ActionFinishRequest>, IMessage, IEquatable<ActionFinishRequest>, IDeepCloneable<ActionFinishRequest>, IBufferMessage
	{
		// Token: 0x06001731 RID: 5937 RVA: 0x0003CA0C File Offset: 0x0003AC0C
		[NullableContext(1)]
		public static ActionFinishRequest Create()
		{
			return new ActionFinishRequest();
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06001732 RID: 5938 RVA: 0x0003CA13 File Offset: 0x0003AC13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06001733 RID: 5939 RVA: 0x0003CA16 File Offset: 0x0003AC16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActionFinishRequest.Descriptor;
			}
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x0003CA1D File Offset: 0x0003AC1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionFinishRequest()
		{
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x0003CA30 File Offset: 0x0003AC30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionFinishRequest(ActionFinishRequest other) : this()
		{
			this.playerId_ = other.playerId_;
			this.incId_ = other.incId_;
			this.startIndex_ = other.startIndex_;
			this.errorMsg_ = other.errorMsg_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001736 RID: 5942 RVA: 0x0003CA84 File Offset: 0x0003AC84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionFinishRequest Clone()
		{
			return new ActionFinishRequest(this);
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06001737 RID: 5943 RVA: 0x0003CA8C File Offset: 0x0003AC8C
		// (set) Token: 0x06001738 RID: 5944 RVA: 0x0003CA94 File Offset: 0x0003AC94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06001739 RID: 5945 RVA: 0x0003CA9D File Offset: 0x0003AC9D
		// (set) Token: 0x0600173A RID: 5946 RVA: 0x0003CAA5 File Offset: 0x0003ACA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x0600173B RID: 5947 RVA: 0x0003CAAE File Offset: 0x0003ACAE
		// (set) Token: 0x0600173C RID: 5948 RVA: 0x0003CAB6 File Offset: 0x0003ACB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StartIndex
		{
			get
			{
				return this.startIndex_;
			}
			set
			{
				this.startIndex_ = value;
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600173D RID: 5949 RVA: 0x0003CABF File Offset: 0x0003ACBF
		// (set) Token: 0x0600173E RID: 5950 RVA: 0x0003CAC7 File Offset: 0x0003ACC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ErrorMsg
		{
			get
			{
				return this.errorMsg_;
			}
			set
			{
				this.errorMsg_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0600173F RID: 5951 RVA: 0x0003CADA File Offset: 0x0003ACDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActionFinishRequest);
		}

		// Token: 0x06001740 RID: 5952 RVA: 0x0003CAE8 File Offset: 0x0003ACE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActionFinishRequest other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.IncId == other.IncId && this.StartIndex == other.StartIndex && !(this.ErrorMsg != other.ErrorMsg) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001741 RID: 5953 RVA: 0x0003CB58 File Offset: 0x0003AD58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.StartIndex != 0)
			{
				num ^= this.StartIndex.GetHashCode();
			}
			if (this.ErrorMsg.Length != 0)
			{
				num ^= this.ErrorMsg.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001742 RID: 5954 RVA: 0x0003CBE4 File Offset: 0x0003ADE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001743 RID: 5955 RVA: 0x0003CBF1 File Offset: 0x0003ADF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001744 RID: 5956 RVA: 0x0003CBFC File Offset: 0x0003ADFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorMsg.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ErrorMsg);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.PlayerId);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.IncId);
			}
			if (this.StartIndex != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.StartIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x0003CC94 File Offset: 0x0003AE94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.StartIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StartIndex);
			}
			if (this.ErrorMsg.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ErrorMsg);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x0003CD20 File Offset: 0x0003AF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActionFinishRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.StartIndex != 0)
			{
				this.StartIndex = other.StartIndex;
			}
			if (other.ErrorMsg.Length != 0)
			{
				this.ErrorMsg = other.ErrorMsg;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x0003CD9D File Offset: 0x0003AF9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x0003CDA8 File Offset: 0x0003AFA8
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
				if (num <= 24U)
				{
					if (num == 10U)
					{
						this.ErrorMsg = input.ReadString();
						continue;
					}
					if (num == 24U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 40U)
					{
						this.IncId = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.StartIndex = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002163 RID: 8547
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002164 RID: 8548
		public const int PlayerIdFieldNumber = 3;

		// Token: 0x04002165 RID: 8549
		private int playerId_;

		// Token: 0x04002166 RID: 8550
		public const int IncIdFieldNumber = 5;

		// Token: 0x04002167 RID: 8551
		private int incId_;

		// Token: 0x04002168 RID: 8552
		public const int StartIndexFieldNumber = 14;

		// Token: 0x04002169 RID: 8553
		private int startIndex_;

		// Token: 0x0400216A RID: 8554
		public const int ErrorMsgFieldNumber = 1;

		// Token: 0x0400216B RID: 8555
		private string errorMsg_ = "";
	}
}
