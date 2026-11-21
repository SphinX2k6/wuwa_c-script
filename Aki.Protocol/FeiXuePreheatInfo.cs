using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200051D RID: 1309
	public sealed class FeiXuePreheatInfo : IMessage<FeiXuePreheatInfo>, IMessage, IEquatable<FeiXuePreheatInfo>, IDeepCloneable<FeiXuePreheatInfo>, IBufferMessage
	{
		// Token: 0x06007B2C RID: 31532 RVA: 0x0012AFCD File Offset: 0x001291CD
		[NullableContext(1)]
		public static FeiXuePreheatInfo Create()
		{
			return new FeiXuePreheatInfo();
		}

		// Token: 0x170017DF RID: 6111
		// (get) Token: 0x06007B2D RID: 31533 RVA: 0x0012AFD4 File Offset: 0x001291D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FeiXuePreheatInfo> Parser
		{
			get
			{
				return FeiXuePreheatInfo._parser;
			}
		}

		// Token: 0x170017E0 RID: 6112
		// (get) Token: 0x06007B2E RID: 31534 RVA: 0x0012AFDB File Offset: 0x001291DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017E1 RID: 6113
		// (get) Token: 0x06007B2F RID: 31535 RVA: 0x0012AFDE File Offset: 0x001291DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FeiXuePreheatInfo.Descriptor;
			}
		}

		// Token: 0x06007B30 RID: 31536 RVA: 0x0012AFE5 File Offset: 0x001291E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeiXuePreheatInfo()
		{
		}

		// Token: 0x06007B31 RID: 31537 RVA: 0x0012AFED File Offset: 0x001291ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeiXuePreheatInfo(FeiXuePreheatInfo other) : this()
		{
			this.id_ = other.id_;
			this.state_ = other.state_;
			this.questUnlockTime_ = other.questUnlockTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007B32 RID: 31538 RVA: 0x0012B02A File Offset: 0x0012922A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeiXuePreheatInfo Clone()
		{
			return new FeiXuePreheatInfo(this);
		}

		// Token: 0x170017E2 RID: 6114
		// (get) Token: 0x06007B33 RID: 31539 RVA: 0x0012B032 File Offset: 0x00129232
		// (set) Token: 0x06007B34 RID: 31540 RVA: 0x0012B03A File Offset: 0x0012923A
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

		// Token: 0x170017E3 RID: 6115
		// (get) Token: 0x06007B35 RID: 31541 RVA: 0x0012B043 File Offset: 0x00129243
		// (set) Token: 0x06007B36 RID: 31542 RVA: 0x0012B04B File Offset: 0x0012924B
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

		// Token: 0x170017E4 RID: 6116
		// (get) Token: 0x06007B37 RID: 31543 RVA: 0x0012B054 File Offset: 0x00129254
		// (set) Token: 0x06007B38 RID: 31544 RVA: 0x0012B05C File Offset: 0x0012925C
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

		// Token: 0x06007B39 RID: 31545 RVA: 0x0012B065 File Offset: 0x00129265
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FeiXuePreheatInfo);
		}

		// Token: 0x06007B3A RID: 31546 RVA: 0x0012B074 File Offset: 0x00129274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FeiXuePreheatInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.State == other.State && this.QuestUnlockTime == other.QuestUnlockTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007B3B RID: 31547 RVA: 0x0012B0D0 File Offset: 0x001292D0
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

		// Token: 0x06007B3C RID: 31548 RVA: 0x0012B141 File Offset: 0x00129341
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007B3D RID: 31549 RVA: 0x0012B14E File Offset: 0x0012934E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007B3E RID: 31550 RVA: 0x0012B158 File Offset: 0x00129358
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

		// Token: 0x06007B3F RID: 31551 RVA: 0x0012B1CC File Offset: 0x001293CC
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

		// Token: 0x06007B40 RID: 31552 RVA: 0x0012B23C File Offset: 0x0012943C
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

		// Token: 0x06007B41 RID: 31553 RVA: 0x0012B2A0 File Offset: 0x001294A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007B42 RID: 31554 RVA: 0x0012B2AC File Offset: 0x001294AC
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

		// Token: 0x04003F6D RID: 16237
		private static readonly MessageParser<FeiXuePreheatInfo> _parser = new MessageParser<FeiXuePreheatInfo>(() => new FeiXuePreheatInfo());

		// Token: 0x04003F6E RID: 16238
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F6F RID: 16239
		public const int IdFieldNumber = 1;

		// Token: 0x04003F70 RID: 16240
		private int id_;

		// Token: 0x04003F71 RID: 16241
		public const int StateFieldNumber = 2;

		// Token: 0x04003F72 RID: 16242
		private int state_;

		// Token: 0x04003F73 RID: 16243
		public const int QuestUnlockTimeFieldNumber = 3;

		// Token: 0x04003F74 RID: 16244
		private long questUnlockTime_;
	}
}
