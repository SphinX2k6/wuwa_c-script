using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B43 RID: 2883
	[NetMessage(EMessageId.NewTowerUpdateRecordResponse)]
	public sealed class NewTowerUpdateRecordResponse : IMessage<NewTowerUpdateRecordResponse>, IMessage, IEquatable<NewTowerUpdateRecordResponse>, IDeepCloneable<NewTowerUpdateRecordResponse>, IBufferMessage
	{
		// Token: 0x0600FA4D RID: 64077 RVA: 0x00247F20 File Offset: 0x00246120
		[NullableContext(1)]
		public static NewTowerUpdateRecordResponse Create()
		{
			return new NewTowerUpdateRecordResponse();
		}

		// Token: 0x17003302 RID: 13058
		// (get) Token: 0x0600FA4E RID: 64078 RVA: 0x00247F27 File Offset: 0x00246127
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003303 RID: 13059
		// (get) Token: 0x0600FA4F RID: 64079 RVA: 0x00247F2A File Offset: 0x0024612A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerUpdateRecordResponse.Descriptor;
			}
		}

		// Token: 0x0600FA50 RID: 64080 RVA: 0x00247F31 File Offset: 0x00246131
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerUpdateRecordResponse()
		{
		}

		// Token: 0x0600FA51 RID: 64081 RVA: 0x00247F3C File Offset: 0x0024613C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerUpdateRecordResponse(NewTowerUpdateRecordResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.record_ = ((other.record_ != null) ? other.record_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FA52 RID: 64082 RVA: 0x00247F88 File Offset: 0x00246188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerUpdateRecordResponse Clone()
		{
			return new NewTowerUpdateRecordResponse(this);
		}

		// Token: 0x17003304 RID: 13060
		// (get) Token: 0x0600FA53 RID: 64083 RVA: 0x00247F90 File Offset: 0x00246190
		// (set) Token: 0x0600FA54 RID: 64084 RVA: 0x00247F98 File Offset: 0x00246198
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

		// Token: 0x17003305 RID: 13061
		// (get) Token: 0x0600FA55 RID: 64085 RVA: 0x00247FA1 File Offset: 0x002461A1
		// (set) Token: 0x0600FA56 RID: 64086 RVA: 0x00247FA9 File Offset: 0x002461A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerClimbingLevelRecord Record
		{
			get
			{
				return this.record_;
			}
			set
			{
				this.record_ = value;
			}
		}

		// Token: 0x0600FA57 RID: 64087 RVA: 0x00247FB2 File Offset: 0x002461B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerUpdateRecordResponse);
		}

		// Token: 0x0600FA58 RID: 64088 RVA: 0x00247FC0 File Offset: 0x002461C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerUpdateRecordResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.Record, other.Record) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FA59 RID: 64089 RVA: 0x00248010 File Offset: 0x00246210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.record_ != null)
			{
				num ^= this.Record.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FA5A RID: 64090 RVA: 0x0024806B File Offset: 0x0024626B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FA5B RID: 64091 RVA: 0x00248078 File Offset: 0x00246278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FA5C RID: 64092 RVA: 0x00248084 File Offset: 0x00246284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.record_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.Record);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FA5D RID: 64093 RVA: 0x002480E0 File Offset: 0x002462E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.record_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Record);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FA5E RID: 64094 RVA: 0x00248138 File Offset: 0x00246338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerUpdateRecordResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.record_ != null)
			{
				if (this.record_ == null)
				{
					this.Record = new NewTowerClimbingLevelRecord();
				}
				this.Record.MergeFrom(other.Record);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FA5F RID: 64095 RVA: 0x002481A0 File Offset: 0x002463A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FA60 RID: 64096 RVA: 0x002481AC File Offset: 0x002463AC
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
				if (num != 88U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.record_ == null)
						{
							this.Record = new NewTowerClimbingLevelRecord();
						}
						input.ReadMessage(this.Record);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006489 RID: 25737
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400648A RID: 25738
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x0400648B RID: 25739
		private ErrorCode errorCode_;

		// Token: 0x0400648C RID: 25740
		public const int RecordFieldNumber = 15;

		// Token: 0x0400648D RID: 25741
		private NewTowerClimbingLevelRecord record_;
	}
}
