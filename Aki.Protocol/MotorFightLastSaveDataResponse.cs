using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A47 RID: 2631
	[NetMessage(EMessageId.MotorFightLastSaveDataResponse)]
	public sealed class MotorFightLastSaveDataResponse : IMessage<MotorFightLastSaveDataResponse>, IMessage, IEquatable<MotorFightLastSaveDataResponse>, IDeepCloneable<MotorFightLastSaveDataResponse>, IBufferMessage
	{
		// Token: 0x0600E5A1 RID: 58785 RVA: 0x00218F4A File Offset: 0x0021714A
		[NullableContext(1)]
		public static MotorFightLastSaveDataResponse Create()
		{
			return new MotorFightLastSaveDataResponse();
		}

		// Token: 0x17002E8D RID: 11917
		// (get) Token: 0x0600E5A2 RID: 58786 RVA: 0x00218F51 File Offset: 0x00217151
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E8E RID: 11918
		// (get) Token: 0x0600E5A3 RID: 58787 RVA: 0x00218F54 File Offset: 0x00217154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightLastSaveDataResponse.Descriptor;
			}
		}

		// Token: 0x0600E5A4 RID: 58788 RVA: 0x00218F5B File Offset: 0x0021715B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightLastSaveDataResponse()
		{
		}

		// Token: 0x0600E5A5 RID: 58789 RVA: 0x00218F64 File Offset: 0x00217164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightLastSaveDataResponse(MotorFightLastSaveDataResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this.exists_ = other.exists_;
			this.lastSaveData_ = ((other.lastSaveData_ != null) ? other.lastSaveData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E5A6 RID: 58790 RVA: 0x00218FBC File Offset: 0x002171BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightLastSaveDataResponse Clone()
		{
			return new MotorFightLastSaveDataResponse(this);
		}

		// Token: 0x17002E8F RID: 11919
		// (get) Token: 0x0600E5A7 RID: 58791 RVA: 0x00218FC4 File Offset: 0x002171C4
		// (set) Token: 0x0600E5A8 RID: 58792 RVA: 0x00218FCC File Offset: 0x002171CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x17002E90 RID: 11920
		// (get) Token: 0x0600E5A9 RID: 58793 RVA: 0x00218FD5 File Offset: 0x002171D5
		// (set) Token: 0x0600E5AA RID: 58794 RVA: 0x00218FDD File Offset: 0x002171DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Exists
		{
			get
			{
				return this.exists_;
			}
			set
			{
				this.exists_ = value;
			}
		}

		// Token: 0x17002E91 RID: 11921
		// (get) Token: 0x0600E5AB RID: 58795 RVA: 0x00218FE6 File Offset: 0x002171E6
		// (set) Token: 0x0600E5AC RID: 58796 RVA: 0x00218FEE File Offset: 0x002171EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightLastSaveData LastSaveData
		{
			get
			{
				return this.lastSaveData_;
			}
			set
			{
				this.lastSaveData_ = value;
			}
		}

		// Token: 0x0600E5AD RID: 58797 RVA: 0x00218FF7 File Offset: 0x002171F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightLastSaveDataResponse);
		}

		// Token: 0x0600E5AE RID: 58798 RVA: 0x00219008 File Offset: 0x00217208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightLastSaveDataResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && this.Exists == other.Exists && object.Equals(this.LastSaveData, other.LastSaveData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E5AF RID: 58799 RVA: 0x00219068 File Offset: 0x00217268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this.Exists)
			{
				num ^= this.Exists.GetHashCode();
			}
			if (this.lastSaveData_ != null)
			{
				num ^= this.LastSaveData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E5B0 RID: 58800 RVA: 0x002190DC File Offset: 0x002172DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E5B1 RID: 58801 RVA: 0x002190E9 File Offset: 0x002172E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E5B2 RID: 58802 RVA: 0x002190F4 File Offset: 0x002172F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.lastSaveData_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.LastSaveData);
			}
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this.Exists)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.Exists);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E5B3 RID: 58803 RVA: 0x0021916C File Offset: 0x0021736C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this.Exists)
			{
				num += 2;
			}
			if (this.lastSaveData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LastSaveData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E5B4 RID: 58804 RVA: 0x002191D0 File Offset: 0x002173D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightLastSaveDataResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			if (other.Exists)
			{
				this.Exists = other.Exists;
			}
			if (other.lastSaveData_ != null)
			{
				if (this.lastSaveData_ == null)
				{
					this.LastSaveData = new MotorFightLastSaveData();
				}
				this.LastSaveData.MergeFrom(other.LastSaveData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E5B5 RID: 58805 RVA: 0x0021924C File Offset: 0x0021744C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E5B6 RID: 58806 RVA: 0x00219258 File Offset: 0x00217458
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
					if (num != 48U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Exists = input.ReadBool();
						}
					}
					else
					{
						this.ErrCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					if (this.lastSaveData_ == null)
					{
						this.LastSaveData = new MotorFightLastSaveData();
					}
					input.ReadMessage(this.LastSaveData);
				}
			}
		}

		// Token: 0x04005DC8 RID: 24008
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005DC9 RID: 24009
		public const int ErrCodeFieldNumber = 6;

		// Token: 0x04005DCA RID: 24010
		private ErrorCode errCode_;

		// Token: 0x04005DCB RID: 24011
		public const int ExistsFieldNumber = 13;

		// Token: 0x04005DCC RID: 24012
		private bool exists_;

		// Token: 0x04005DCD RID: 24013
		public const int LastSaveDataFieldNumber = 2;

		// Token: 0x04005DCE RID: 24014
		private MotorFightLastSaveData lastSaveData_;
	}
}
