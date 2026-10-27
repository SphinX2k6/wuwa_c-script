using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200062C RID: 1580
	[NetMessage(EMessageId.FormationChangeResponse)]
	public sealed class FormationChangeResponse : IMessage<FormationChangeResponse>, IMessage, IEquatable<FormationChangeResponse>, IDeepCloneable<FormationChangeResponse>, IBufferMessage
	{
		// Token: 0x060091B1 RID: 37297 RVA: 0x00160868 File Offset: 0x0015EA68
		[NullableContext(1)]
		public static FormationChangeResponse Create()
		{
			return new FormationChangeResponse();
		}

		// Token: 0x17001CF7 RID: 7415
		// (get) Token: 0x060091B2 RID: 37298 RVA: 0x0016086F File Offset: 0x0015EA6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001CF8 RID: 7416
		// (get) Token: 0x060091B3 RID: 37299 RVA: 0x00160872 File Offset: 0x0015EA72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FormationChangeResponse.Descriptor;
			}
		}

		// Token: 0x060091B4 RID: 37300 RVA: 0x00160879 File Offset: 0x0015EA79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationChangeResponse()
		{
		}

		// Token: 0x060091B5 RID: 37301 RVA: 0x0016088C File Offset: 0x0015EA8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationChangeResponse(FormationChangeResponse other) : this()
		{
			this.changeList_ = other.changeList_.Clone();
			this.formationId_ = other.formationId_;
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060091B6 RID: 37302 RVA: 0x001608D9 File Offset: 0x0015EAD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationChangeResponse Clone()
		{
			return new FormationChangeResponse(this);
		}

		// Token: 0x17001CF9 RID: 7417
		// (get) Token: 0x060091B7 RID: 37303 RVA: 0x001608E1 File Offset: 0x0015EAE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FormationChangeInfo> ChangeList
		{
			get
			{
				return this.changeList_;
			}
		}

		// Token: 0x17001CFA RID: 7418
		// (get) Token: 0x060091B8 RID: 37304 RVA: 0x001608E9 File Offset: 0x0015EAE9
		// (set) Token: 0x060091B9 RID: 37305 RVA: 0x001608F1 File Offset: 0x0015EAF1
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

		// Token: 0x17001CFB RID: 7419
		// (get) Token: 0x060091BA RID: 37306 RVA: 0x001608FA File Offset: 0x0015EAFA
		// (set) Token: 0x060091BB RID: 37307 RVA: 0x00160902 File Offset: 0x0015EB02
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

		// Token: 0x060091BC RID: 37308 RVA: 0x0016090B File Offset: 0x0015EB0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FormationChangeResponse);
		}

		// Token: 0x060091BD RID: 37309 RVA: 0x0016091C File Offset: 0x0015EB1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FormationChangeResponse other)
		{
			return other != null && (other == this || (this.changeList_.Equals(other.changeList_) && this.FormationId == other.FormationId && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060091BE RID: 37310 RVA: 0x0016097C File Offset: 0x0015EB7C
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

		// Token: 0x060091BF RID: 37311 RVA: 0x001609E8 File Offset: 0x0015EBE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060091C0 RID: 37312 RVA: 0x001609F5 File Offset: 0x0015EBF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060091C1 RID: 37313 RVA: 0x00160A00 File Offset: 0x0015EC00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FormationId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.FormationId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.changeList_.WriteTo(ref output, FormationChangeResponse._repeated_changeList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060091C2 RID: 37314 RVA: 0x00160A6C File Offset: 0x0015EC6C
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

		// Token: 0x060091C3 RID: 37315 RVA: 0x00160AD8 File Offset: 0x0015ECD8
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

		// Token: 0x060091C4 RID: 37316 RVA: 0x00160B39 File Offset: 0x0015ED39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060091C5 RID: 37317 RVA: 0x00160B44 File Offset: 0x0015ED44
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
					if (num != 32U)
					{
						if (num != 90U)
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

		// Token: 0x04004659 RID: 18009
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400465A RID: 18010
		public const int ChangeListFieldNumber = 11;

		// Token: 0x0400465B RID: 18011
		private static readonly FieldCodec<FormationChangeInfo> _repeated_changeList_codec = FieldCodec.ForMessage<FormationChangeInfo>(90U, FormationChangeInfo.Parser);

		// Token: 0x0400465C RID: 18012
		private readonly RepeatedField<FormationChangeInfo> changeList_ = new RepeatedField<FormationChangeInfo>();

		// Token: 0x0400465D RID: 18013
		public const int FormationIdFieldNumber = 3;

		// Token: 0x0400465E RID: 18014
		private int formationId_;

		// Token: 0x0400465F RID: 18015
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04004660 RID: 18016
		private ErrorCode errorCode_;
	}
}
