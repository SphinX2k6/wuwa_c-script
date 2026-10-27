using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000532 RID: 1330
	public sealed class FeiXuePreheatInfo : IMessage<FeiXuePreheatInfo>, IMessage, IEquatable<FeiXuePreheatInfo>, IDeepCloneable<FeiXuePreheatInfo>, IBufferMessage
	{
		// Token: 0x06007C94 RID: 31892 RVA: 0x0012DBD1 File Offset: 0x0012BDD1
		[NullableContext(1)]
		public static FeiXuePreheatInfo Create()
		{
			return new FeiXuePreheatInfo();
		}

		// Token: 0x1700182C RID: 6188
		// (get) Token: 0x06007C95 RID: 31893 RVA: 0x0012DBD8 File Offset: 0x0012BDD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FeiXuePreheatInfo> Parser
		{
			get
			{
				return FeiXuePreheatInfo._parser;
			}
		}

		// Token: 0x1700182D RID: 6189
		// (get) Token: 0x06007C96 RID: 31894 RVA: 0x0012DBDF File Offset: 0x0012BDDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700182E RID: 6190
		// (get) Token: 0x06007C97 RID: 31895 RVA: 0x0012DBE2 File Offset: 0x0012BDE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FeiXuePreheatInfo.Descriptor;
			}
		}

		// Token: 0x06007C98 RID: 31896 RVA: 0x0012DBE9 File Offset: 0x0012BDE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeiXuePreheatInfo()
		{
		}

		// Token: 0x06007C99 RID: 31897 RVA: 0x0012DBF1 File Offset: 0x0012BDF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeiXuePreheatInfo(FeiXuePreheatInfo other) : this()
		{
			this.id_ = other.id_;
			this.state_ = other.state_;
			this.questUnlockTime_ = other.questUnlockTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007C9A RID: 31898 RVA: 0x0012DC2E File Offset: 0x0012BE2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeiXuePreheatInfo Clone()
		{
			return new FeiXuePreheatInfo(this);
		}

		// Token: 0x1700182F RID: 6191
		// (get) Token: 0x06007C9B RID: 31899 RVA: 0x0012DC36 File Offset: 0x0012BE36
		// (set) Token: 0x06007C9C RID: 31900 RVA: 0x0012DC3E File Offset: 0x0012BE3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17001830 RID: 6192
		// (get) Token: 0x06007C9D RID: 31901 RVA: 0x0012DC47 File Offset: 0x0012BE47
		// (set) Token: 0x06007C9E RID: 31902 RVA: 0x0012DC4F File Offset: 0x0012BE4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x17001831 RID: 6193
		// (get) Token: 0x06007C9F RID: 31903 RVA: 0x0012DC58 File Offset: 0x0012BE58
		// (set) Token: 0x06007CA0 RID: 31904 RVA: 0x0012DC60 File Offset: 0x0012BE60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long QuestUnlockTime
		{
			get
			{
				return this.questUnlockTime_;
			}
			set
			{
				this.questUnlockTime_ = value;
			}
		}

		// Token: 0x06007CA1 RID: 31905 RVA: 0x0012DC69 File Offset: 0x0012BE69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FeiXuePreheatInfo);
		}

		// Token: 0x06007CA2 RID: 31906 RVA: 0x0012DC78 File Offset: 0x0012BE78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FeiXuePreheatInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.State == other.State && this.QuestUnlockTime == other.QuestUnlockTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007CA3 RID: 31907 RVA: 0x0012DCD4 File Offset: 0x0012BED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.State != 0)
			{
				num ^= this.State.GetHashCode();
			}
			if (this.QuestUnlockTime != 0L)
			{
				num ^= this.QuestUnlockTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007CA4 RID: 31908 RVA: 0x0012DD45 File Offset: 0x0012BF45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007CA5 RID: 31909 RVA: 0x0012DD52 File Offset: 0x0012BF52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007CA6 RID: 31910 RVA: 0x0012DD5C File Offset: 0x0012BF5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.State != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.State);
			}
			if (this.QuestUnlockTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.QuestUnlockTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007CA7 RID: 31911 RVA: 0x0012DDD0 File Offset: 0x0012BFD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.State != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.State);
			}
			if (this.QuestUnlockTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.QuestUnlockTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007CA8 RID: 31912 RVA: 0x0012DE40 File Offset: 0x0012C040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FeiXuePreheatInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.State != 0)
			{
				this.State = other.State;
			}
			if (other.QuestUnlockTime != 0L)
			{
				this.QuestUnlockTime = other.QuestUnlockTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007CA9 RID: 31913 RVA: 0x0012DEA4 File Offset: 0x0012C0A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007CAA RID: 31914 RVA: 0x0012DEB0 File Offset: 0x0012C0B0
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
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.QuestUnlockTime = input.ReadInt64();
						}
					}
					else
					{
						this.State = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003F77 RID: 16247
		private static readonly MessageParser<FeiXuePreheatInfo> _parser = new MessageParser<FeiXuePreheatInfo>(() => new FeiXuePreheatInfo());

		// Token: 0x04003F78 RID: 16248
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F79 RID: 16249
		public const int IdFieldNumber = 1;

		// Token: 0x04003F7A RID: 16250
		private int id_;

		// Token: 0x04003F7B RID: 16251
		public const int StateFieldNumber = 2;

		// Token: 0x04003F7C RID: 16252
		private int state_;

		// Token: 0x04003F7D RID: 16253
		public const int QuestUnlockTimeFieldNumber = 3;

		// Token: 0x04003F7E RID: 16254
		private long questUnlockTime_;
	}
}
