using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C2E RID: 3118
	[NetMessage(EMessageId.PhantomBattleBackSlotCardLibraryResponse)]
	public sealed class PhantomBattleBackSlotCardLibraryResponse : IMessage<PhantomBattleBackSlotCardLibraryResponse>, IMessage, IEquatable<PhantomBattleBackSlotCardLibraryResponse>, IDeepCloneable<PhantomBattleBackSlotCardLibraryResponse>, IBufferMessage
	{
		// Token: 0x06010EA2 RID: 69282 RVA: 0x0027A1E1 File Offset: 0x002783E1
		[NullableContext(1)]
		public static PhantomBattleBackSlotCardLibraryResponse Create()
		{
			return new PhantomBattleBackSlotCardLibraryResponse();
		}

		// Token: 0x170037DB RID: 14299
		// (get) Token: 0x06010EA3 RID: 69283 RVA: 0x0027A1E8 File Offset: 0x002783E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170037DC RID: 14300
		// (get) Token: 0x06010EA4 RID: 69284 RVA: 0x0027A1EB File Offset: 0x002783EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleBackSlotCardLibraryResponse.Descriptor;
			}
		}

		// Token: 0x06010EA5 RID: 69285 RVA: 0x0027A1F2 File Offset: 0x002783F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBackSlotCardLibraryResponse()
		{
		}

		// Token: 0x06010EA6 RID: 69286 RVA: 0x0027A1FA File Offset: 0x002783FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBackSlotCardLibraryResponse(PhantomBattleBackSlotCardLibraryResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.cardUid_ = other.cardUid_;
			this.curCardLibraryNum_ = other.curCardLibraryNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010EA7 RID: 69287 RVA: 0x0027A237 File Offset: 0x00278437
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBackSlotCardLibraryResponse Clone()
		{
			return new PhantomBattleBackSlotCardLibraryResponse(this);
		}

		// Token: 0x170037DD RID: 14301
		// (get) Token: 0x06010EA8 RID: 69288 RVA: 0x0027A23F File Offset: 0x0027843F
		// (set) Token: 0x06010EA9 RID: 69289 RVA: 0x0027A247 File Offset: 0x00278447
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

		// Token: 0x170037DE RID: 14302
		// (get) Token: 0x06010EAA RID: 69290 RVA: 0x0027A250 File Offset: 0x00278450
		// (set) Token: 0x06010EAB RID: 69291 RVA: 0x0027A258 File Offset: 0x00278458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardUid
		{
			get
			{
				return this.cardUid_;
			}
			set
			{
				this.cardUid_ = value;
			}
		}

		// Token: 0x170037DF RID: 14303
		// (get) Token: 0x06010EAC RID: 69292 RVA: 0x0027A261 File Offset: 0x00278461
		// (set) Token: 0x06010EAD RID: 69293 RVA: 0x0027A269 File Offset: 0x00278469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurCardLibraryNum
		{
			get
			{
				return this.curCardLibraryNum_;
			}
			set
			{
				this.curCardLibraryNum_ = value;
			}
		}

		// Token: 0x06010EAE RID: 69294 RVA: 0x0027A272 File Offset: 0x00278472
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleBackSlotCardLibraryResponse);
		}

		// Token: 0x06010EAF RID: 69295 RVA: 0x0027A280 File Offset: 0x00278480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleBackSlotCardLibraryResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.CardUid == other.CardUid && this.CurCardLibraryNum == other.CurCardLibraryNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010EB0 RID: 69296 RVA: 0x0027A2DC File Offset: 0x002784DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.CardUid != 0)
			{
				num ^= this.CardUid.GetHashCode();
			}
			if (this.CurCardLibraryNum != 0)
			{
				num ^= this.CurCardLibraryNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010EB1 RID: 69297 RVA: 0x0027A353 File Offset: 0x00278553
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010EB2 RID: 69298 RVA: 0x0027A360 File Offset: 0x00278560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010EB3 RID: 69299 RVA: 0x0027A36C File Offset: 0x0027856C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.CardUid != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.CardUid);
			}
			if (this.CurCardLibraryNum != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.CurCardLibraryNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010EB4 RID: 69300 RVA: 0x0027A3E4 File Offset: 0x002785E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.CardUid != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardUid);
			}
			if (this.CurCardLibraryNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurCardLibraryNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010EB5 RID: 69301 RVA: 0x0027A454 File Offset: 0x00278654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleBackSlotCardLibraryResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.CardUid != 0)
			{
				this.CardUid = other.CardUid;
			}
			if (other.CurCardLibraryNum != 0)
			{
				this.CurCardLibraryNum = other.CurCardLibraryNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010EB6 RID: 69302 RVA: 0x0027A4B8 File Offset: 0x002786B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010EB7 RID: 69303 RVA: 0x0027A4C4 File Offset: 0x002786C4
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
					if (num != 32U)
					{
						if (num != 40U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.CurCardLibraryNum = input.ReadInt32();
						}
					}
					else
					{
						this.CardUid = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006B52 RID: 27474
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B53 RID: 27475
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04006B54 RID: 27476
		private ErrorCode errorCode_;

		// Token: 0x04006B55 RID: 27477
		public const int CardUidFieldNumber = 4;

		// Token: 0x04006B56 RID: 27478
		private int cardUid_;

		// Token: 0x04006B57 RID: 27479
		public const int CurCardLibraryNumFieldNumber = 5;

		// Token: 0x04006B58 RID: 27480
		private int curCardLibraryNum_;
	}
}
