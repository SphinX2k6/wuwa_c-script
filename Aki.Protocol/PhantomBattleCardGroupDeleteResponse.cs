using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C3A RID: 3130
	[NetMessage(EMessageId.PhantomBattleCardGroupDeleteResponse)]
	public sealed class PhantomBattleCardGroupDeleteResponse : IMessage<PhantomBattleCardGroupDeleteResponse>, IMessage, IEquatable<PhantomBattleCardGroupDeleteResponse>, IDeepCloneable<PhantomBattleCardGroupDeleteResponse>, IBufferMessage
	{
		// Token: 0x06010FFD RID: 69629 RVA: 0x0027DD24 File Offset: 0x0027BF24
		[NullableContext(1)]
		public static PhantomBattleCardGroupDeleteResponse Create()
		{
			return new PhantomBattleCardGroupDeleteResponse();
		}

		// Token: 0x1700382C RID: 14380
		// (get) Token: 0x06010FFE RID: 69630 RVA: 0x0027DD2B File Offset: 0x0027BF2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700382D RID: 14381
		// (get) Token: 0x06010FFF RID: 69631 RVA: 0x0027DD2E File Offset: 0x0027BF2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardGroupDeleteResponse.Descriptor;
			}
		}

		// Token: 0x06011000 RID: 69632 RVA: 0x0027DD35 File Offset: 0x0027BF35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupDeleteResponse()
		{
		}

		// Token: 0x06011001 RID: 69633 RVA: 0x0027DD48 File Offset: 0x0027BF48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupDeleteResponse(PhantomBattleCardGroupDeleteResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.phantomBattleCardGroupInfo_ = other.phantomBattleCardGroupInfo_.Clone();
			this.lastUseCardGroupIndex_ = other.lastUseCardGroupIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011002 RID: 69634 RVA: 0x0027DD95 File Offset: 0x0027BF95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupDeleteResponse Clone()
		{
			return new PhantomBattleCardGroupDeleteResponse(this);
		}

		// Token: 0x1700382E RID: 14382
		// (get) Token: 0x06011003 RID: 69635 RVA: 0x0027DD9D File Offset: 0x0027BF9D
		// (set) Token: 0x06011004 RID: 69636 RVA: 0x0027DDA5 File Offset: 0x0027BFA5
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

		// Token: 0x1700382F RID: 14383
		// (get) Token: 0x06011005 RID: 69637 RVA: 0x0027DDAE File Offset: 0x0027BFAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleCardGroupInfo> PhantomBattleCardGroupInfo
		{
			get
			{
				return this.phantomBattleCardGroupInfo_;
			}
		}

		// Token: 0x17003830 RID: 14384
		// (get) Token: 0x06011006 RID: 69638 RVA: 0x0027DDB6 File Offset: 0x0027BFB6
		// (set) Token: 0x06011007 RID: 69639 RVA: 0x0027DDBE File Offset: 0x0027BFBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LastUseCardGroupIndex
		{
			get
			{
				return this.lastUseCardGroupIndex_;
			}
			set
			{
				this.lastUseCardGroupIndex_ = value;
			}
		}

		// Token: 0x06011008 RID: 69640 RVA: 0x0027DDC7 File Offset: 0x0027BFC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardGroupDeleteResponse);
		}

		// Token: 0x06011009 RID: 69641 RVA: 0x0027DDD8 File Offset: 0x0027BFD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardGroupDeleteResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.phantomBattleCardGroupInfo_.Equals(other.phantomBattleCardGroupInfo_) && this.LastUseCardGroupIndex == other.LastUseCardGroupIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601100A RID: 69642 RVA: 0x0027DE38 File Offset: 0x0027C038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.phantomBattleCardGroupInfo_.GetHashCode();
			if (this.LastUseCardGroupIndex != 0)
			{
				num ^= this.LastUseCardGroupIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601100B RID: 69643 RVA: 0x0027DEA4 File Offset: 0x0027C0A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601100C RID: 69644 RVA: 0x0027DEB1 File Offset: 0x0027C0B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601100D RID: 69645 RVA: 0x0027DEBC File Offset: 0x0027C0BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.LastUseCardGroupIndex != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.LastUseCardGroupIndex);
			}
			this.phantomBattleCardGroupInfo_.WriteTo(ref output, PhantomBattleCardGroupDeleteResponse._repeated_phantomBattleCardGroupInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601100E RID: 69646 RVA: 0x0027DF28 File Offset: 0x0027C128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.phantomBattleCardGroupInfo_.CalculateSize(PhantomBattleCardGroupDeleteResponse._repeated_phantomBattleCardGroupInfo_codec);
			if (this.LastUseCardGroupIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LastUseCardGroupIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601100F RID: 69647 RVA: 0x0027DF94 File Offset: 0x0027C194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardGroupDeleteResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.phantomBattleCardGroupInfo_.Add(other.phantomBattleCardGroupInfo_);
			if (other.LastUseCardGroupIndex != 0)
			{
				this.LastUseCardGroupIndex = other.LastUseCardGroupIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011010 RID: 69648 RVA: 0x0027DFF5 File Offset: 0x0027C1F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011011 RID: 69649 RVA: 0x0027E000 File Offset: 0x0027C200
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
					if (num != 72U)
					{
						if (num != 106U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.phantomBattleCardGroupInfo_.AddEntriesFrom(ref input, PhantomBattleCardGroupDeleteResponse._repeated_phantomBattleCardGroupInfo_codec);
						}
					}
					else
					{
						this.LastUseCardGroupIndex = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006C31 RID: 27697
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C32 RID: 27698
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04006C33 RID: 27699
		private ErrorCode errorCode_;

		// Token: 0x04006C34 RID: 27700
		public const int PhantomBattleCardGroupInfoFieldNumber = 13;

		// Token: 0x04006C35 RID: 27701
		private static readonly FieldCodec<PhantomBattleCardGroupInfo> _repeated_phantomBattleCardGroupInfo_codec = FieldCodec.ForMessage<PhantomBattleCardGroupInfo>(106U, Aki.Protocol.PhantomBattleCardGroupInfo.Parser);

		// Token: 0x04006C36 RID: 27702
		private readonly RepeatedField<PhantomBattleCardGroupInfo> phantomBattleCardGroupInfo_ = new RepeatedField<PhantomBattleCardGroupInfo>();

		// Token: 0x04006C37 RID: 27703
		public const int LastUseCardGroupIndexFieldNumber = 9;

		// Token: 0x04006C38 RID: 27704
		private int lastUseCardGroupIndex_;
	}
}
