using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000618 RID: 1560
	[NetMessage(EMessageId.FormationChangeResponse)]
	public sealed class FormationChangeResponse : IMessage<FormationChangeResponse>, IMessage, IEquatable<FormationChangeResponse>, IDeepCloneable<FormationChangeResponse>, IBufferMessage
	{
		// Token: 0x0600905B RID: 36955 RVA: 0x0015DE38 File Offset: 0x0015C038
		[NullableContext(1)]
		public static FormationChangeResponse Create()
		{
			return new FormationChangeResponse();
		}

		// Token: 0x17001CAD RID: 7341
		// (get) Token: 0x0600905C RID: 36956 RVA: 0x0015DE3F File Offset: 0x0015C03F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001CAE RID: 7342
		// (get) Token: 0x0600905D RID: 36957 RVA: 0x0015DE42 File Offset: 0x0015C042
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FormationChangeResponse.Descriptor;
			}
		}

		// Token: 0x0600905E RID: 36958 RVA: 0x0015DE49 File Offset: 0x0015C049
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationChangeResponse()
		{
		}

		// Token: 0x0600905F RID: 36959 RVA: 0x0015DE5C File Offset: 0x0015C05C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationChangeResponse(FormationChangeResponse other) : this()
		{
			this.changeList_ = other.changeList_.Clone();
			this.formationId_ = other.formationId_;
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009060 RID: 36960 RVA: 0x0015DEA9 File Offset: 0x0015C0A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationChangeResponse Clone()
		{
			return new FormationChangeResponse(this);
		}

		// Token: 0x17001CAF RID: 7343
		// (get) Token: 0x06009061 RID: 36961 RVA: 0x0015DEB1 File Offset: 0x0015C0B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FormationChangeInfo> ChangeList
		{
			get
			{
				return this.changeList_;
			}
		}

		// Token: 0x17001CB0 RID: 7344
		// (get) Token: 0x06009062 RID: 36962 RVA: 0x0015DEB9 File Offset: 0x0015C0B9
		// (set) Token: 0x06009063 RID: 36963 RVA: 0x0015DEC1 File Offset: 0x0015C0C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FormationId
		{
			get
			{
				return this.formationId_;
			}
			set
			{
				this.formationId_ = value;
			}
		}

		// Token: 0x17001CB1 RID: 7345
		// (get) Token: 0x06009064 RID: 36964 RVA: 0x0015DECA File Offset: 0x0015C0CA
		// (set) Token: 0x06009065 RID: 36965 RVA: 0x0015DED2 File Offset: 0x0015C0D2
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

		// Token: 0x06009066 RID: 36966 RVA: 0x0015DEDB File Offset: 0x0015C0DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FormationChangeResponse);
		}

		// Token: 0x06009067 RID: 36967 RVA: 0x0015DEEC File Offset: 0x0015C0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FormationChangeResponse other)
		{
			return other != null && (other == this || (this.changeList_.Equals(other.changeList_) && this.FormationId == other.FormationId && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009068 RID: 36968 RVA: 0x0015DF4C File Offset: 0x0015C14C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.changeList_.GetHashCode();
			if (this.FormationId != 0)
			{
				num ^= this.FormationId.GetHashCode();
			}
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

		// Token: 0x06009069 RID: 36969 RVA: 0x0015DFB8 File Offset: 0x0015C1B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600906A RID: 36970 RVA: 0x0015DFC5 File Offset: 0x0015C1C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600906B RID: 36971 RVA: 0x0015DFD0 File Offset: 0x0015C1D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FormationId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.FormationId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.changeList_.WriteTo(ref output, FormationChangeResponse._repeated_changeList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600906C RID: 36972 RVA: 0x0015E03C File Offset: 0x0015C23C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.changeList_.CalculateSize(FormationChangeResponse._repeated_changeList_codec);
			if (this.FormationId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FormationId);
			}
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

		// Token: 0x0600906D RID: 36973 RVA: 0x0015E0A8 File Offset: 0x0015C2A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FormationChangeResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.changeList_.Add(other.changeList_);
			if (other.FormationId != 0)
			{
				this.FormationId = other.FormationId;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600906E RID: 36974 RVA: 0x0015E109 File Offset: 0x0015C309
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600906F RID: 36975 RVA: 0x0015E114 File Offset: 0x0015C314
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
				if (num != 16U)
				{
					if (num != 48U)
					{
						if (num != 66U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.changeList_.AddEntriesFrom(ref input, FormationChangeResponse._repeated_changeList_codec);
						}
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.FormationId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004652 RID: 18002
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004653 RID: 18003
		public const int ChangeListFieldNumber = 8;

		// Token: 0x04004654 RID: 18004
		private static readonly FieldCodec<FormationChangeInfo> _repeated_changeList_codec = FieldCodec.ForMessage<FormationChangeInfo>(66U, FormationChangeInfo.Parser);

		// Token: 0x04004655 RID: 18005
		private readonly RepeatedField<FormationChangeInfo> changeList_ = new RepeatedField<FormationChangeInfo>();

		// Token: 0x04004656 RID: 18006
		public const int FormationIdFieldNumber = 2;

		// Token: 0x04004657 RID: 18007
		private int formationId_;

		// Token: 0x04004658 RID: 18008
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04004659 RID: 18009
		private ErrorCode errorCode_;
	}
}
