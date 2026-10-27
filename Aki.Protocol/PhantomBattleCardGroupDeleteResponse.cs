using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C4A RID: 3146
	[NetMessage(EMessageId.PhantomBattleCardGroupDeleteResponse)]
	public sealed class PhantomBattleCardGroupDeleteResponse : IMessage<PhantomBattleCardGroupDeleteResponse>, IMessage, IEquatable<PhantomBattleCardGroupDeleteResponse>, IDeepCloneable<PhantomBattleCardGroupDeleteResponse>, IBufferMessage
	{
		// Token: 0x060110FD RID: 69885 RVA: 0x0027FA8C File Offset: 0x0027DC8C
		[NullableContext(1)]
		public static PhantomBattleCardGroupDeleteResponse Create()
		{
			return new PhantomBattleCardGroupDeleteResponse();
		}

		// Token: 0x17003863 RID: 14435
		// (get) Token: 0x060110FE RID: 69886 RVA: 0x0027FA93 File Offset: 0x0027DC93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003864 RID: 14436
		// (get) Token: 0x060110FF RID: 69887 RVA: 0x0027FA96 File Offset: 0x0027DC96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardGroupDeleteResponse.Descriptor;
			}
		}

		// Token: 0x06011100 RID: 69888 RVA: 0x0027FA9D File Offset: 0x0027DC9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupDeleteResponse()
		{
		}

		// Token: 0x06011101 RID: 69889 RVA: 0x0027FAB0 File Offset: 0x0027DCB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupDeleteResponse(PhantomBattleCardGroupDeleteResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.phantomBattleCardGroupInfo_ = other.phantomBattleCardGroupInfo_.Clone();
			this.lastUseCardGroupIndex_ = other.lastUseCardGroupIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011102 RID: 69890 RVA: 0x0027FAFD File Offset: 0x0027DCFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupDeleteResponse Clone()
		{
			return new PhantomBattleCardGroupDeleteResponse(this);
		}

		// Token: 0x17003865 RID: 14437
		// (get) Token: 0x06011103 RID: 69891 RVA: 0x0027FB05 File Offset: 0x0027DD05
		// (set) Token: 0x06011104 RID: 69892 RVA: 0x0027FB0D File Offset: 0x0027DD0D
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

		// Token: 0x17003866 RID: 14438
		// (get) Token: 0x06011105 RID: 69893 RVA: 0x0027FB16 File Offset: 0x0027DD16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleCardGroupInfo> PhantomBattleCardGroupInfo
		{
			get
			{
				return this.phantomBattleCardGroupInfo_;
			}
		}

		// Token: 0x17003867 RID: 14439
		// (get) Token: 0x06011106 RID: 69894 RVA: 0x0027FB1E File Offset: 0x0027DD1E
		// (set) Token: 0x06011107 RID: 69895 RVA: 0x0027FB26 File Offset: 0x0027DD26
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

		// Token: 0x06011108 RID: 69896 RVA: 0x0027FB2F File Offset: 0x0027DD2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardGroupDeleteResponse);
		}

		// Token: 0x06011109 RID: 69897 RVA: 0x0027FB40 File Offset: 0x0027DD40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardGroupDeleteResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.phantomBattleCardGroupInfo_.Equals(other.phantomBattleCardGroupInfo_) && this.LastUseCardGroupIndex == other.LastUseCardGroupIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601110A RID: 69898 RVA: 0x0027FBA0 File Offset: 0x0027DDA0
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

		// Token: 0x0601110B RID: 69899 RVA: 0x0027FC0C File Offset: 0x0027DE0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601110C RID: 69900 RVA: 0x0027FC19 File Offset: 0x0027DE19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601110D RID: 69901 RVA: 0x0027FC24 File Offset: 0x0027DE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.LastUseCardGroupIndex != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.LastUseCardGroupIndex);
			}
			this.phantomBattleCardGroupInfo_.WriteTo(ref output, PhantomBattleCardGroupDeleteResponse._repeated_phantomBattleCardGroupInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601110E RID: 69902 RVA: 0x0027FC90 File Offset: 0x0027DE90
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

		// Token: 0x0601110F RID: 69903 RVA: 0x0027FCFC File Offset: 0x0027DEFC
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

		// Token: 0x06011110 RID: 69904 RVA: 0x0027FD5D File Offset: 0x0027DF5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011111 RID: 69905 RVA: 0x0027FD68 File Offset: 0x0027DF68
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
				if (num != 40U)
				{
					if (num != 80U)
					{
						if (num != 90U)
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

		// Token: 0x04006C1D RID: 27677
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C1E RID: 27678
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04006C1F RID: 27679
		private ErrorCode errorCode_;

		// Token: 0x04006C20 RID: 27680
		public const int PhantomBattleCardGroupInfoFieldNumber = 11;

		// Token: 0x04006C21 RID: 27681
		private static readonly FieldCodec<PhantomBattleCardGroupInfo> _repeated_phantomBattleCardGroupInfo_codec = FieldCodec.ForMessage<PhantomBattleCardGroupInfo>(90U, Aki.Protocol.PhantomBattleCardGroupInfo.Parser);

		// Token: 0x04006C22 RID: 27682
		private readonly RepeatedField<PhantomBattleCardGroupInfo> phantomBattleCardGroupInfo_ = new RepeatedField<PhantomBattleCardGroupInfo>();

		// Token: 0x04006C23 RID: 27683
		public const int LastUseCardGroupIndexFieldNumber = 10;

		// Token: 0x04006C24 RID: 27684
		private int lastUseCardGroupIndex_;
	}
}
