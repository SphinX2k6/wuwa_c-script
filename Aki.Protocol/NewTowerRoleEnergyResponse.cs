using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B47 RID: 2887
	[NetMessage(EMessageId.NewTowerRoleEnergyResponse)]
	public sealed class NewTowerRoleEnergyResponse : IMessage<NewTowerRoleEnergyResponse>, IMessage, IEquatable<NewTowerRoleEnergyResponse>, IDeepCloneable<NewTowerRoleEnergyResponse>, IBufferMessage
	{
		// Token: 0x0600FA77 RID: 64119 RVA: 0x00248551 File Offset: 0x00246751
		[NullableContext(1)]
		public static NewTowerRoleEnergyResponse Create()
		{
			return new NewTowerRoleEnergyResponse();
		}

		// Token: 0x17003314 RID: 13076
		// (get) Token: 0x0600FA78 RID: 64120 RVA: 0x00248558 File Offset: 0x00246758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003315 RID: 13077
		// (get) Token: 0x0600FA79 RID: 64121 RVA: 0x0024855B File Offset: 0x0024675B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerRoleEnergyResponse.Descriptor;
			}
		}

		// Token: 0x0600FA7A RID: 64122 RVA: 0x00248562 File Offset: 0x00246762
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRoleEnergyResponse()
		{
		}

		// Token: 0x0600FA7B RID: 64123 RVA: 0x00248575 File Offset: 0x00246775
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRoleEnergyResponse(NewTowerRoleEnergyResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.recordRoleEnergys_ = other.recordRoleEnergys_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FA7C RID: 64124 RVA: 0x002485AB File Offset: 0x002467AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRoleEnergyResponse Clone()
		{
			return new NewTowerRoleEnergyResponse(this);
		}

		// Token: 0x17003316 RID: 13078
		// (get) Token: 0x0600FA7D RID: 64125 RVA: 0x002485B3 File Offset: 0x002467B3
		// (set) Token: 0x0600FA7E RID: 64126 RVA: 0x002485BB File Offset: 0x002467BB
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

		// Token: 0x17003317 RID: 13079
		// (get) Token: 0x0600FA7F RID: 64127 RVA: 0x002485C4 File Offset: 0x002467C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RecordRoleEnergy> RecordRoleEnergys
		{
			get
			{
				return this.recordRoleEnergys_;
			}
		}

		// Token: 0x0600FA80 RID: 64128 RVA: 0x002485CC File Offset: 0x002467CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerRoleEnergyResponse);
		}

		// Token: 0x0600FA81 RID: 64129 RVA: 0x002485DC File Offset: 0x002467DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerRoleEnergyResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.recordRoleEnergys_.Equals(other.recordRoleEnergys_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FA82 RID: 64130 RVA: 0x0024862C File Offset: 0x0024682C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.recordRoleEnergys_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FA83 RID: 64131 RVA: 0x0024867F File Offset: 0x0024687F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FA84 RID: 64132 RVA: 0x0024868C File Offset: 0x0024688C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FA85 RID: 64133 RVA: 0x00248698 File Offset: 0x00246898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.recordRoleEnergys_.WriteTo(ref output, NewTowerRoleEnergyResponse._repeated_recordRoleEnergys_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FA86 RID: 64134 RVA: 0x002486E8 File Offset: 0x002468E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.recordRoleEnergys_.CalculateSize(NewTowerRoleEnergyResponse._repeated_recordRoleEnergys_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FA87 RID: 64135 RVA: 0x0024873C File Offset: 0x0024693C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerRoleEnergyResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.recordRoleEnergys_.Add(other.recordRoleEnergys_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FA88 RID: 64136 RVA: 0x00248789 File Offset: 0x00246989
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FA89 RID: 64137 RVA: 0x00248794 File Offset: 0x00246994
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
				if (num != 18U)
				{
					if (num != 40U)
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
					this.recordRoleEnergys_.AddEntriesFrom(ref input, NewTowerRoleEnergyResponse._repeated_recordRoleEnergys_codec);
				}
			}
		}

		// Token: 0x04006446 RID: 25670
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006447 RID: 25671
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04006448 RID: 25672
		private ErrorCode errorCode_;

		// Token: 0x04006449 RID: 25673
		public const int RecordRoleEnergysFieldNumber = 2;

		// Token: 0x0400644A RID: 25674
		private static readonly FieldCodec<RecordRoleEnergy> _repeated_recordRoleEnergys_codec = FieldCodec.ForMessage<RecordRoleEnergy>(18U, RecordRoleEnergy.Parser);

		// Token: 0x0400644B RID: 25675
		private readonly RepeatedField<RecordRoleEnergy> recordRoleEnergys_ = new RepeatedField<RecordRoleEnergy>();
	}
}
