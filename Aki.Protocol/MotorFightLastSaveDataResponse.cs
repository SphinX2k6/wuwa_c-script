using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A36 RID: 2614
	[NetMessage(EMessageId.MotorFightLastSaveDataResponse)]
	public sealed class MotorFightLastSaveDataResponse : IMessage<MotorFightLastSaveDataResponse>, IMessage, IEquatable<MotorFightLastSaveDataResponse>, IDeepCloneable<MotorFightLastSaveDataResponse>, IBufferMessage
	{
		// Token: 0x0600E487 RID: 58503 RVA: 0x00216D56 File Offset: 0x00214F56
		[NullableContext(1)]
		public static MotorFightLastSaveDataResponse Create()
		{
			return new MotorFightLastSaveDataResponse();
		}

		// Token: 0x17002E4F RID: 11855
		// (get) Token: 0x0600E488 RID: 58504 RVA: 0x00216D5D File Offset: 0x00214F5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E50 RID: 11856
		// (get) Token: 0x0600E489 RID: 58505 RVA: 0x00216D60 File Offset: 0x00214F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightLastSaveDataResponse.Descriptor;
			}
		}

		// Token: 0x0600E48A RID: 58506 RVA: 0x00216D67 File Offset: 0x00214F67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightLastSaveDataResponse()
		{
		}

		// Token: 0x0600E48B RID: 58507 RVA: 0x00216D70 File Offset: 0x00214F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightLastSaveDataResponse(MotorFightLastSaveDataResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this.exists_ = other.exists_;
			this.lastSaveData_ = ((other.lastSaveData_ != null) ? other.lastSaveData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E48C RID: 58508 RVA: 0x00216DC8 File Offset: 0x00214FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightLastSaveDataResponse Clone()
		{
			return new MotorFightLastSaveDataResponse(this);
		}

		// Token: 0x17002E51 RID: 11857
		// (get) Token: 0x0600E48D RID: 58509 RVA: 0x00216DD0 File Offset: 0x00214FD0
		// (set) Token: 0x0600E48E RID: 58510 RVA: 0x00216DD8 File Offset: 0x00214FD8
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

		// Token: 0x17002E52 RID: 11858
		// (get) Token: 0x0600E48F RID: 58511 RVA: 0x00216DE1 File Offset: 0x00214FE1
		// (set) Token: 0x0600E490 RID: 58512 RVA: 0x00216DE9 File Offset: 0x00214FE9
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

		// Token: 0x17002E53 RID: 11859
		// (get) Token: 0x0600E491 RID: 58513 RVA: 0x00216DF2 File Offset: 0x00214FF2
		// (set) Token: 0x0600E492 RID: 58514 RVA: 0x00216DFA File Offset: 0x00214FFA
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

		// Token: 0x0600E493 RID: 58515 RVA: 0x00216E03 File Offset: 0x00215003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightLastSaveDataResponse);
		}

		// Token: 0x0600E494 RID: 58516 RVA: 0x00216E14 File Offset: 0x00215014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightLastSaveDataResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && this.Exists == other.Exists && object.Equals(this.LastSaveData, other.LastSaveData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E495 RID: 58517 RVA: 0x00216E74 File Offset: 0x00215074
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

		// Token: 0x0600E496 RID: 58518 RVA: 0x00216EE8 File Offset: 0x002150E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E497 RID: 58519 RVA: 0x00216EF5 File Offset: 0x002150F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E498 RID: 58520 RVA: 0x00216F00 File Offset: 0x00215100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.lastSaveData_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.LastSaveData);
			}
			if (this.Exists)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.Exists);
			}
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E499 RID: 58521 RVA: 0x00216F78 File Offset: 0x00215178
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

		// Token: 0x0600E49A RID: 58522 RVA: 0x00216FDC File Offset: 0x002151DC
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

		// Token: 0x0600E49B RID: 58523 RVA: 0x00217058 File Offset: 0x00215258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E49C RID: 58524 RVA: 0x00217064 File Offset: 0x00215264
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
				if (num != 34U)
				{
					if (num != 48U)
					{
						if (num != 72U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ErrCode = (ErrorCode)input.ReadEnum();
						}
					}
					else
					{
						this.Exists = input.ReadBool();
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

		// Token: 0x04005DD1 RID: 24017
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005DD2 RID: 24018
		public const int ErrCodeFieldNumber = 9;

		// Token: 0x04005DD3 RID: 24019
		private ErrorCode errCode_;

		// Token: 0x04005DD4 RID: 24020
		public const int ExistsFieldNumber = 6;

		// Token: 0x04005DD5 RID: 24021
		private bool exists_;

		// Token: 0x04005DD6 RID: 24022
		public const int LastSaveDataFieldNumber = 4;

		// Token: 0x04005DD7 RID: 24023
		private MotorFightLastSaveData lastSaveData_;
	}
}
