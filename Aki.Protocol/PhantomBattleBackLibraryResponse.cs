using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C1C RID: 3100
	[NetMessage(EMessageId.PhantomBattleBackLibraryResponse)]
	public sealed class PhantomBattleBackLibraryResponse : IMessage<PhantomBattleBackLibraryResponse>, IMessage, IEquatable<PhantomBattleBackLibraryResponse>, IDeepCloneable<PhantomBattleBackLibraryResponse>, IBufferMessage
	{
		// Token: 0x06010D7A RID: 68986 RVA: 0x00277F55 File Offset: 0x00276155
		[NullableContext(1)]
		public static PhantomBattleBackLibraryResponse Create()
		{
			return new PhantomBattleBackLibraryResponse();
		}

		// Token: 0x1700379C RID: 14236
		// (get) Token: 0x06010D7B RID: 68987 RVA: 0x00277F5C File Offset: 0x0027615C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700379D RID: 14237
		// (get) Token: 0x06010D7C RID: 68988 RVA: 0x00277F5F File Offset: 0x0027615F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleBackLibraryResponse.Descriptor;
			}
		}

		// Token: 0x06010D7D RID: 68989 RVA: 0x00277F66 File Offset: 0x00276166
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBackLibraryResponse()
		{
		}

		// Token: 0x06010D7E RID: 68990 RVA: 0x00277F6E File Offset: 0x0027616E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBackLibraryResponse(PhantomBattleBackLibraryResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.cardUid_ = other.cardUid_;
			this.curCardLibraryNum_ = other.curCardLibraryNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010D7F RID: 68991 RVA: 0x00277FAB File Offset: 0x002761AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBackLibraryResponse Clone()
		{
			return new PhantomBattleBackLibraryResponse(this);
		}

		// Token: 0x1700379E RID: 14238
		// (get) Token: 0x06010D80 RID: 68992 RVA: 0x00277FB3 File Offset: 0x002761B3
		// (set) Token: 0x06010D81 RID: 68993 RVA: 0x00277FBB File Offset: 0x002761BB
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

		// Token: 0x1700379F RID: 14239
		// (get) Token: 0x06010D82 RID: 68994 RVA: 0x00277FC4 File Offset: 0x002761C4
		// (set) Token: 0x06010D83 RID: 68995 RVA: 0x00277FCC File Offset: 0x002761CC
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

		// Token: 0x170037A0 RID: 14240
		// (get) Token: 0x06010D84 RID: 68996 RVA: 0x00277FD5 File Offset: 0x002761D5
		// (set) Token: 0x06010D85 RID: 68997 RVA: 0x00277FDD File Offset: 0x002761DD
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

		// Token: 0x06010D86 RID: 68998 RVA: 0x00277FE6 File Offset: 0x002761E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleBackLibraryResponse);
		}

		// Token: 0x06010D87 RID: 68999 RVA: 0x00277FF4 File Offset: 0x002761F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleBackLibraryResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.CardUid == other.CardUid && this.CurCardLibraryNum == other.CurCardLibraryNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010D88 RID: 69000 RVA: 0x00278050 File Offset: 0x00276250
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

		// Token: 0x06010D89 RID: 69001 RVA: 0x002780C7 File Offset: 0x002762C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010D8A RID: 69002 RVA: 0x002780D4 File Offset: 0x002762D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010D8B RID: 69003 RVA: 0x002780E0 File Offset: 0x002762E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CardUid != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.CardUid);
			}
			if (this.CurCardLibraryNum != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.CurCardLibraryNum);
			}
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

		// Token: 0x06010D8C RID: 69004 RVA: 0x00278158 File Offset: 0x00276358
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

		// Token: 0x06010D8D RID: 69005 RVA: 0x002781C8 File Offset: 0x002763C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleBackLibraryResponse other)
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

		// Token: 0x06010D8E RID: 69006 RVA: 0x0027822C File Offset: 0x0027642C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010D8F RID: 69007 RVA: 0x00278238 File Offset: 0x00276438
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
				if (num != 72U)
				{
					if (num != 96U)
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
						this.CurCardLibraryNum = input.ReadInt32();
					}
				}
				else
				{
					this.CardUid = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006B5C RID: 27484
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B5D RID: 27485
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04006B5E RID: 27486
		private ErrorCode errorCode_;

		// Token: 0x04006B5F RID: 27487
		public const int CardUidFieldNumber = 9;

		// Token: 0x04006B60 RID: 27488
		private int cardUid_;

		// Token: 0x04006B61 RID: 27489
		public const int CurCardLibraryNumFieldNumber = 12;

		// Token: 0x04006B62 RID: 27490
		private int curCardLibraryNum_;
	}
}
