using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012EB RID: 4843
	[NetMessage(EMessageId.SurvivorsTalentLevelUpResponse)]
	public sealed class SurvivorsTalentLevelUpResponse : IMessage<SurvivorsTalentLevelUpResponse>, IMessage, IEquatable<SurvivorsTalentLevelUpResponse>, IDeepCloneable<SurvivorsTalentLevelUpResponse>, IBufferMessage
	{
		// Token: 0x06019C16 RID: 105494 RVA: 0x003BE669 File Offset: 0x003BC869
		[NullableContext(1)]
		public static SurvivorsTalentLevelUpResponse Create()
		{
			return new SurvivorsTalentLevelUpResponse();
		}

		// Token: 0x170056E0 RID: 22240
		// (get) Token: 0x06019C17 RID: 105495 RVA: 0x003BE670 File Offset: 0x003BC870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170056E1 RID: 22241
		// (get) Token: 0x06019C18 RID: 105496 RVA: 0x003BE673 File Offset: 0x003BC873
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsTalentLevelUpResponse.Descriptor;
			}
		}

		// Token: 0x06019C19 RID: 105497 RVA: 0x003BE67A File Offset: 0x003BC87A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsTalentLevelUpResponse()
		{
		}

		// Token: 0x06019C1A RID: 105498 RVA: 0x003BE682 File Offset: 0x003BC882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsTalentLevelUpResponse(SurvivorsTalentLevelUpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019C1B RID: 105499 RVA: 0x003BE6B3 File Offset: 0x003BC8B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsTalentLevelUpResponse Clone()
		{
			return new SurvivorsTalentLevelUpResponse(this);
		}

		// Token: 0x170056E2 RID: 22242
		// (get) Token: 0x06019C1C RID: 105500 RVA: 0x003BE6BB File Offset: 0x003BC8BB
		// (set) Token: 0x06019C1D RID: 105501 RVA: 0x003BE6C3 File Offset: 0x003BC8C3
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

		// Token: 0x170056E3 RID: 22243
		// (get) Token: 0x06019C1E RID: 105502 RVA: 0x003BE6CC File Offset: 0x003BC8CC
		// (set) Token: 0x06019C1F RID: 105503 RVA: 0x003BE6D4 File Offset: 0x003BC8D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x06019C20 RID: 105504 RVA: 0x003BE6DD File Offset: 0x003BC8DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsTalentLevelUpResponse);
		}

		// Token: 0x06019C21 RID: 105505 RVA: 0x003BE6EB File Offset: 0x003BC8EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsTalentLevelUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019C22 RID: 105506 RVA: 0x003BE72C File Offset: 0x003BC92C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019C23 RID: 105507 RVA: 0x003BE78A File Offset: 0x003BC98A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019C24 RID: 105508 RVA: 0x003BE797 File Offset: 0x003BC997
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019C25 RID: 105509 RVA: 0x003BE7A0 File Offset: 0x003BC9A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019C26 RID: 105510 RVA: 0x003BE7FC File Offset: 0x003BC9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019C27 RID: 105511 RVA: 0x003BE854 File Offset: 0x003BCA54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsTalentLevelUpResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019C28 RID: 105512 RVA: 0x003BE8A4 File Offset: 0x003BCAA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019C29 RID: 105513 RVA: 0x003BE8B0 File Offset: 0x003BCAB0
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Level = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040096CC RID: 38604
		private UnknownFieldSet _unknownFields;

		// Token: 0x040096CD RID: 38605
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x040096CE RID: 38606
		private ErrorCode errorCode_;

		// Token: 0x040096CF RID: 38607
		public const int LevelFieldNumber = 4;

		// Token: 0x040096D0 RID: 38608
		private int level_;
	}
}
