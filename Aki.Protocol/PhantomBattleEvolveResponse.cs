using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C76 RID: 3190
	[NetMessage(EMessageId.PhantomBattleEvolveResponse)]
	public sealed class PhantomBattleEvolveResponse : IMessage<PhantomBattleEvolveResponse>, IMessage, IEquatable<PhantomBattleEvolveResponse>, IDeepCloneable<PhantomBattleEvolveResponse>, IBufferMessage
	{
		// Token: 0x06011510 RID: 70928 RVA: 0x0028A100 File Offset: 0x00288300
		[NullableContext(1)]
		public static PhantomBattleEvolveResponse Create()
		{
			return new PhantomBattleEvolveResponse();
		}

		// Token: 0x17003953 RID: 14675
		// (get) Token: 0x06011511 RID: 70929 RVA: 0x0028A107 File Offset: 0x00288307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003954 RID: 14676
		// (get) Token: 0x06011512 RID: 70930 RVA: 0x0028A10A File Offset: 0x0028830A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleEvolveResponse.Descriptor;
			}
		}

		// Token: 0x06011513 RID: 70931 RVA: 0x0028A111 File Offset: 0x00288311
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleEvolveResponse()
		{
		}

		// Token: 0x06011514 RID: 70932 RVA: 0x0028A11C File Offset: 0x0028831C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleEvolveResponse(PhantomBattleEvolveResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.phantomBattleFighterInfo_ = ((other.phantomBattleFighterInfo_ != null) ? other.phantomBattleFighterInfo_.Clone() : null);
			this.canEvolveNum_ = other.canEvolveNum_;
			this.cardLibraryNum_ = other.cardLibraryNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011515 RID: 70933 RVA: 0x0028A180 File Offset: 0x00288380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleEvolveResponse Clone()
		{
			return new PhantomBattleEvolveResponse(this);
		}

		// Token: 0x17003955 RID: 14677
		// (get) Token: 0x06011516 RID: 70934 RVA: 0x0028A188 File Offset: 0x00288388
		// (set) Token: 0x06011517 RID: 70935 RVA: 0x0028A190 File Offset: 0x00288390
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

		// Token: 0x17003956 RID: 14678
		// (get) Token: 0x06011518 RID: 70936 RVA: 0x0028A199 File Offset: 0x00288399
		// (set) Token: 0x06011519 RID: 70937 RVA: 0x0028A1A1 File Offset: 0x002883A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleFighterInfo PhantomBattleFighterInfo
		{
			get
			{
				return this.phantomBattleFighterInfo_;
			}
			set
			{
				this.phantomBattleFighterInfo_ = value;
			}
		}

		// Token: 0x17003957 RID: 14679
		// (get) Token: 0x0601151A RID: 70938 RVA: 0x0028A1AA File Offset: 0x002883AA
		// (set) Token: 0x0601151B RID: 70939 RVA: 0x0028A1B2 File Offset: 0x002883B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CanEvolveNum
		{
			get
			{
				return this.canEvolveNum_;
			}
			set
			{
				this.canEvolveNum_ = value;
			}
		}

		// Token: 0x17003958 RID: 14680
		// (get) Token: 0x0601151C RID: 70940 RVA: 0x0028A1BB File Offset: 0x002883BB
		// (set) Token: 0x0601151D RID: 70941 RVA: 0x0028A1C3 File Offset: 0x002883C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardLibraryNum
		{
			get
			{
				return this.cardLibraryNum_;
			}
			set
			{
				this.cardLibraryNum_ = value;
			}
		}

		// Token: 0x0601151E RID: 70942 RVA: 0x0028A1CC File Offset: 0x002883CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleEvolveResponse);
		}

		// Token: 0x0601151F RID: 70943 RVA: 0x0028A1DC File Offset: 0x002883DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleEvolveResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.PhantomBattleFighterInfo, other.PhantomBattleFighterInfo) && this.CanEvolveNum == other.CanEvolveNum && this.CardLibraryNum == other.CardLibraryNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011520 RID: 70944 RVA: 0x0028A24C File Offset: 0x0028844C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.phantomBattleFighterInfo_ != null)
			{
				num ^= this.PhantomBattleFighterInfo.GetHashCode();
			}
			if (this.CanEvolveNum != 0)
			{
				num ^= this.CanEvolveNum.GetHashCode();
			}
			if (this.CardLibraryNum != 0)
			{
				num ^= this.CardLibraryNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011521 RID: 70945 RVA: 0x0028A2D9 File Offset: 0x002884D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011522 RID: 70946 RVA: 0x0028A2E6 File Offset: 0x002884E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011523 RID: 70947 RVA: 0x0028A2F0 File Offset: 0x002884F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.phantomBattleFighterInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.PhantomBattleFighterInfo);
			}
			if (this.CanEvolveNum != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.CanEvolveNum);
			}
			if (this.CardLibraryNum != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.CardLibraryNum);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011524 RID: 70948 RVA: 0x0028A384 File Offset: 0x00288584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.phantomBattleFighterInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleFighterInfo);
			}
			if (this.CanEvolveNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CanEvolveNum);
			}
			if (this.CardLibraryNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardLibraryNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011525 RID: 70949 RVA: 0x0028A40C File Offset: 0x0028860C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleEvolveResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.phantomBattleFighterInfo_ != null)
			{
				if (this.phantomBattleFighterInfo_ == null)
				{
					this.PhantomBattleFighterInfo = new PhantomBattleFighterInfo();
				}
				this.PhantomBattleFighterInfo.MergeFrom(other.PhantomBattleFighterInfo);
			}
			if (other.CanEvolveNum != 0)
			{
				this.CanEvolveNum = other.CanEvolveNum;
			}
			if (other.CardLibraryNum != 0)
			{
				this.CardLibraryNum = other.CardLibraryNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011526 RID: 70950 RVA: 0x0028A49C File Offset: 0x0028869C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011527 RID: 70951 RVA: 0x0028A4A8 File Offset: 0x002886A8
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
				if (num <= 64U)
				{
					if (num == 50U)
					{
						if (this.phantomBattleFighterInfo_ == null)
						{
							this.PhantomBattleFighterInfo = new PhantomBattleFighterInfo();
						}
						input.ReadMessage(this.PhantomBattleFighterInfo);
						continue;
					}
					if (num == 64U)
					{
						this.CanEvolveNum = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.CardLibraryNum = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006DDC RID: 28124
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006DDD RID: 28125
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04006DDE RID: 28126
		private ErrorCode errorCode_;

		// Token: 0x04006DDF RID: 28127
		public const int PhantomBattleFighterInfoFieldNumber = 6;

		// Token: 0x04006DE0 RID: 28128
		private PhantomBattleFighterInfo phantomBattleFighterInfo_;

		// Token: 0x04006DE1 RID: 28129
		public const int CanEvolveNumFieldNumber = 8;

		// Token: 0x04006DE2 RID: 28130
		private int canEvolveNum_;

		// Token: 0x04006DE3 RID: 28131
		public const int CardLibraryNumFieldNumber = 12;

		// Token: 0x04006DE4 RID: 28132
		private int cardLibraryNum_;
	}
}
