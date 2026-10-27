using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002CB RID: 715
	[NetMessage(EMessageId.ConditionGroupStateResponse)]
	public sealed class ConditionGroupStateResponse : IMessage<ConditionGroupStateResponse>, IMessage, IEquatable<ConditionGroupStateResponse>, IDeepCloneable<ConditionGroupStateResponse>, IBufferMessage
	{
		// Token: 0x06004962 RID: 18786 RVA: 0x000B39F4 File Offset: 0x000B1BF4
		[NullableContext(1)]
		public static ConditionGroupStateResponse Create()
		{
			return new ConditionGroupStateResponse();
		}

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x06004963 RID: 18787 RVA: 0x000B39FB File Offset: 0x000B1BFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x06004964 RID: 18788 RVA: 0x000B39FE File Offset: 0x000B1BFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConditionGroupStateResponse.Descriptor;
			}
		}

		// Token: 0x06004965 RID: 18789 RVA: 0x000B3A05 File Offset: 0x000B1C05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionGroupStateResponse()
		{
		}

		// Token: 0x06004966 RID: 18790 RVA: 0x000B3A18 File Offset: 0x000B1C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionGroupStateResponse(ConditionGroupStateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.conditionGroupFinishInfos_ = other.conditionGroupFinishInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004967 RID: 18791 RVA: 0x000B3A4E File Offset: 0x000B1C4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionGroupStateResponse Clone()
		{
			return new ConditionGroupStateResponse(this);
		}

		// Token: 0x17000CD9 RID: 3289
		// (get) Token: 0x06004968 RID: 18792 RVA: 0x000B3A56 File Offset: 0x000B1C56
		// (set) Token: 0x06004969 RID: 18793 RVA: 0x000B3A5E File Offset: 0x000B1C5E
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

		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x0600496A RID: 18794 RVA: 0x000B3A67 File Offset: 0x000B1C67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionGroupFinishInfo> ConditionGroupFinishInfos
		{
			get
			{
				return this.conditionGroupFinishInfos_;
			}
		}

		// Token: 0x0600496B RID: 18795 RVA: 0x000B3A6F File Offset: 0x000B1C6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConditionGroupStateResponse);
		}

		// Token: 0x0600496C RID: 18796 RVA: 0x000B3A80 File Offset: 0x000B1C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConditionGroupStateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.conditionGroupFinishInfos_.Equals(other.conditionGroupFinishInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600496D RID: 18797 RVA: 0x000B3AD0 File Offset: 0x000B1CD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.conditionGroupFinishInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600496E RID: 18798 RVA: 0x000B3B23 File Offset: 0x000B1D23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600496F RID: 18799 RVA: 0x000B3B30 File Offset: 0x000B1D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004970 RID: 18800 RVA: 0x000B3B3C File Offset: 0x000B1D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.conditionGroupFinishInfos_.WriteTo(ref output, ConditionGroupStateResponse._repeated_conditionGroupFinishInfos_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004971 RID: 18801 RVA: 0x000B3B8C File Offset: 0x000B1D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.conditionGroupFinishInfos_.CalculateSize(ConditionGroupStateResponse._repeated_conditionGroupFinishInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004972 RID: 18802 RVA: 0x000B3BE0 File Offset: 0x000B1DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConditionGroupStateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.conditionGroupFinishInfos_.Add(other.conditionGroupFinishInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004973 RID: 18803 RVA: 0x000B3C2D File Offset: 0x000B1E2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004974 RID: 18804 RVA: 0x000B3C38 File Offset: 0x000B1E38
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
				if (num != 10U)
				{
					if (num != 24U)
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
					this.conditionGroupFinishInfos_.AddEntriesFrom(ref input, ConditionGroupStateResponse._repeated_conditionGroupFinishInfos_codec);
				}
			}
		}

		// Token: 0x0400302A RID: 12330
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400302B RID: 12331
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x0400302C RID: 12332
		private ErrorCode errorCode_;

		// Token: 0x0400302D RID: 12333
		public const int ConditionGroupFinishInfosFieldNumber = 1;

		// Token: 0x0400302E RID: 12334
		private static readonly FieldCodec<ConditionGroupFinishInfo> _repeated_conditionGroupFinishInfos_codec = FieldCodec.ForMessage<ConditionGroupFinishInfo>(10U, ConditionGroupFinishInfo.Parser);

		// Token: 0x0400302F RID: 12335
		private readonly RepeatedField<ConditionGroupFinishInfo> conditionGroupFinishInfos_ = new RepeatedField<ConditionGroupFinishInfo>();
	}
}
