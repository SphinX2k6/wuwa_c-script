using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B36 RID: 2870
	[NetMessage(EMessageId.NewTowerRoleEnergyResponse)]
	public sealed class NewTowerRoleEnergyResponse : IMessage<NewTowerRoleEnergyResponse>, IMessage, IEquatable<NewTowerRoleEnergyResponse>, IDeepCloneable<NewTowerRoleEnergyResponse>, IBufferMessage
	{
		// Token: 0x0600F95D RID: 63837 RVA: 0x00246339 File Offset: 0x00244539
		[NullableContext(1)]
		public static NewTowerRoleEnergyResponse Create()
		{
			return new NewTowerRoleEnergyResponse();
		}

		// Token: 0x170032D6 RID: 13014
		// (get) Token: 0x0600F95E RID: 63838 RVA: 0x00246340 File Offset: 0x00244540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170032D7 RID: 13015
		// (get) Token: 0x0600F95F RID: 63839 RVA: 0x00246343 File Offset: 0x00244543
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerRoleEnergyResponse.Descriptor;
			}
		}

		// Token: 0x0600F960 RID: 63840 RVA: 0x0024634A File Offset: 0x0024454A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRoleEnergyResponse()
		{
		}

		// Token: 0x0600F961 RID: 63841 RVA: 0x0024635D File Offset: 0x0024455D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRoleEnergyResponse(NewTowerRoleEnergyResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.recordRoleEnergys_ = other.recordRoleEnergys_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F962 RID: 63842 RVA: 0x00246393 File Offset: 0x00244593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRoleEnergyResponse Clone()
		{
			return new NewTowerRoleEnergyResponse(this);
		}

		// Token: 0x170032D8 RID: 13016
		// (get) Token: 0x0600F963 RID: 63843 RVA: 0x0024639B File Offset: 0x0024459B
		// (set) Token: 0x0600F964 RID: 63844 RVA: 0x002463A3 File Offset: 0x002445A3
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

		// Token: 0x170032D9 RID: 13017
		// (get) Token: 0x0600F965 RID: 63845 RVA: 0x002463AC File Offset: 0x002445AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RecordRoleEnergy> RecordRoleEnergys
		{
			get
			{
				return this.recordRoleEnergys_;
			}
		}

		// Token: 0x0600F966 RID: 63846 RVA: 0x002463B4 File Offset: 0x002445B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerRoleEnergyResponse);
		}

		// Token: 0x0600F967 RID: 63847 RVA: 0x002463C4 File Offset: 0x002445C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerRoleEnergyResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.recordRoleEnergys_.Equals(other.recordRoleEnergys_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F968 RID: 63848 RVA: 0x00246414 File Offset: 0x00244614
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

		// Token: 0x0600F969 RID: 63849 RVA: 0x00246467 File Offset: 0x00244667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F96A RID: 63850 RVA: 0x00246474 File Offset: 0x00244674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F96B RID: 63851 RVA: 0x00246480 File Offset: 0x00244680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.recordRoleEnergys_.WriteTo(ref output, NewTowerRoleEnergyResponse._repeated_recordRoleEnergys_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F96C RID: 63852 RVA: 0x002464D0 File Offset: 0x002446D0
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

		// Token: 0x0600F96D RID: 63853 RVA: 0x00246524 File Offset: 0x00244724
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

		// Token: 0x0600F96E RID: 63854 RVA: 0x00246571 File Offset: 0x00244771
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F96F RID: 63855 RVA: 0x0024657C File Offset: 0x0024477C
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
				if (num != 82U)
				{
					if (num != 120U)
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

		// Token: 0x0400644F RID: 25679
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006450 RID: 25680
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04006451 RID: 25681
		private ErrorCode errorCode_;

		// Token: 0x04006452 RID: 25682
		public const int RecordRoleEnergysFieldNumber = 10;

		// Token: 0x04006453 RID: 25683
		private static readonly FieldCodec<RecordRoleEnergy> _repeated_recordRoleEnergys_codec = FieldCodec.ForMessage<RecordRoleEnergy>(82U, RecordRoleEnergy.Parser);

		// Token: 0x04006454 RID: 25684
		private readonly RepeatedField<RecordRoleEnergy> recordRoleEnergys_ = new RepeatedField<RecordRoleEnergy>();
	}
}
