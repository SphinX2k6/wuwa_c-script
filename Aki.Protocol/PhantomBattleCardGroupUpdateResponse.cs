using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C40 RID: 3136
	[NetMessage(EMessageId.PhantomBattleCardGroupUpdateResponse)]
	public sealed class PhantomBattleCardGroupUpdateResponse : IMessage<PhantomBattleCardGroupUpdateResponse>, IMessage, IEquatable<PhantomBattleCardGroupUpdateResponse>, IDeepCloneable<PhantomBattleCardGroupUpdateResponse>, IBufferMessage
	{
		// Token: 0x06011080 RID: 69760 RVA: 0x0027F1D2 File Offset: 0x0027D3D2
		[NullableContext(1)]
		public static PhantomBattleCardGroupUpdateResponse Create()
		{
			return new PhantomBattleCardGroupUpdateResponse();
		}

		// Token: 0x1700384B RID: 14411
		// (get) Token: 0x06011081 RID: 69761 RVA: 0x0027F1D9 File Offset: 0x0027D3D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700384C RID: 14412
		// (get) Token: 0x06011082 RID: 69762 RVA: 0x0027F1DC File Offset: 0x0027D3DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardGroupUpdateResponse.Descriptor;
			}
		}

		// Token: 0x06011083 RID: 69763 RVA: 0x0027F1E3 File Offset: 0x0027D3E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupUpdateResponse()
		{
		}

		// Token: 0x06011084 RID: 69764 RVA: 0x0027F1EC File Offset: 0x0027D3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupUpdateResponse(PhantomBattleCardGroupUpdateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.phantomBattleCardGroupInfo_ = ((other.phantomBattleCardGroupInfo_ != null) ? other.phantomBattleCardGroupInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011085 RID: 69765 RVA: 0x0027F238 File Offset: 0x0027D438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupUpdateResponse Clone()
		{
			return new PhantomBattleCardGroupUpdateResponse(this);
		}

		// Token: 0x1700384D RID: 14413
		// (get) Token: 0x06011086 RID: 69766 RVA: 0x0027F240 File Offset: 0x0027D440
		// (set) Token: 0x06011087 RID: 69767 RVA: 0x0027F248 File Offset: 0x0027D448
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

		// Token: 0x1700384E RID: 14414
		// (get) Token: 0x06011088 RID: 69768 RVA: 0x0027F251 File Offset: 0x0027D451
		// (set) Token: 0x06011089 RID: 69769 RVA: 0x0027F259 File Offset: 0x0027D459
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupInfo PhantomBattleCardGroupInfo
		{
			get
			{
				return this.phantomBattleCardGroupInfo_;
			}
			set
			{
				this.phantomBattleCardGroupInfo_ = value;
			}
		}

		// Token: 0x0601108A RID: 69770 RVA: 0x0027F262 File Offset: 0x0027D462
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardGroupUpdateResponse);
		}

		// Token: 0x0601108B RID: 69771 RVA: 0x0027F270 File Offset: 0x0027D470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardGroupUpdateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.PhantomBattleCardGroupInfo, other.PhantomBattleCardGroupInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601108C RID: 69772 RVA: 0x0027F2C0 File Offset: 0x0027D4C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.phantomBattleCardGroupInfo_ != null)
			{
				num ^= this.PhantomBattleCardGroupInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601108D RID: 69773 RVA: 0x0027F31B File Offset: 0x0027D51B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601108E RID: 69774 RVA: 0x0027F328 File Offset: 0x0027D528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601108F RID: 69775 RVA: 0x0027F334 File Offset: 0x0027D534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.phantomBattleCardGroupInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.PhantomBattleCardGroupInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011090 RID: 69776 RVA: 0x0027F38C File Offset: 0x0027D58C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.phantomBattleCardGroupInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleCardGroupInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011091 RID: 69777 RVA: 0x0027F3E4 File Offset: 0x0027D5E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardGroupUpdateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.phantomBattleCardGroupInfo_ != null)
			{
				if (this.phantomBattleCardGroupInfo_ == null)
				{
					this.PhantomBattleCardGroupInfo = new PhantomBattleCardGroupInfo();
				}
				this.PhantomBattleCardGroupInfo.MergeFrom(other.PhantomBattleCardGroupInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011092 RID: 69778 RVA: 0x0027F44C File Offset: 0x0027D64C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011093 RID: 69779 RVA: 0x0027F458 File Offset: 0x0027D658
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
				if (num != 8U)
				{
					if (num != 34U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.phantomBattleCardGroupInfo_ == null)
						{
							this.PhantomBattleCardGroupInfo = new PhantomBattleCardGroupInfo();
						}
						input.ReadMessage(this.PhantomBattleCardGroupInfo);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006C62 RID: 27746
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C63 RID: 27747
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04006C64 RID: 27748
		private ErrorCode errorCode_;

		// Token: 0x04006C65 RID: 27749
		public const int PhantomBattleCardGroupInfoFieldNumber = 4;

		// Token: 0x04006C66 RID: 27750
		private PhantomBattleCardGroupInfo phantomBattleCardGroupInfo_;
	}
}
