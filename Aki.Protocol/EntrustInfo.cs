using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004BA RID: 1210
	public sealed class EntrustInfo : IMessage<EntrustInfo>, IMessage, IEquatable<EntrustInfo>, IDeepCloneable<EntrustInfo>, IBufferMessage
	{
		// Token: 0x0600738C RID: 29580 RVA: 0x0011BC18 File Offset: 0x00119E18
		[NullableContext(1)]
		public static EntrustInfo Create()
		{
			return new EntrustInfo();
		}

		// Token: 0x1700165E RID: 5726
		// (get) Token: 0x0600738D RID: 29581 RVA: 0x0011BC1F File Offset: 0x00119E1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EntrustInfo> Parser
		{
			get
			{
				return EntrustInfo._parser;
			}
		}

		// Token: 0x1700165F RID: 5727
		// (get) Token: 0x0600738E RID: 29582 RVA: 0x0011BC26 File Offset: 0x00119E26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001660 RID: 5728
		// (get) Token: 0x0600738F RID: 29583 RVA: 0x0011BC29 File Offset: 0x00119E29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntrustInfo.Descriptor;
			}
		}

		// Token: 0x06007390 RID: 29584 RVA: 0x0011BC30 File Offset: 0x00119E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntrustInfo()
		{
		}

		// Token: 0x06007391 RID: 29585 RVA: 0x0011BC38 File Offset: 0x00119E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntrustInfo(EntrustInfo other) : this()
		{
			this.entrustId_ = other.entrustId_;
			this.isVisiable_ = other.isVisiable_;
			this.historyLevel_ = other.historyLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007392 RID: 29586 RVA: 0x0011BC75 File Offset: 0x00119E75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntrustInfo Clone()
		{
			return new EntrustInfo(this);
		}

		// Token: 0x17001661 RID: 5729
		// (get) Token: 0x06007393 RID: 29587 RVA: 0x0011BC7D File Offset: 0x00119E7D
		// (set) Token: 0x06007394 RID: 29588 RVA: 0x0011BC85 File Offset: 0x00119E85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntrustId
		{
			get
			{
				return this.entrustId_;
			}
			set
			{
				this.entrustId_ = value;
			}
		}

		// Token: 0x17001662 RID: 5730
		// (get) Token: 0x06007395 RID: 29589 RVA: 0x0011BC8E File Offset: 0x00119E8E
		// (set) Token: 0x06007396 RID: 29590 RVA: 0x0011BC96 File Offset: 0x00119E96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsVisiable
		{
			get
			{
				return this.isVisiable_;
			}
			set
			{
				this.isVisiable_ = value;
			}
		}

		// Token: 0x17001663 RID: 5731
		// (get) Token: 0x06007397 RID: 29591 RVA: 0x0011BC9F File Offset: 0x00119E9F
		// (set) Token: 0x06007398 RID: 29592 RVA: 0x0011BCA7 File Offset: 0x00119EA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HistoryLevel
		{
			get
			{
				return this.historyLevel_;
			}
			set
			{
				this.historyLevel_ = value;
			}
		}

		// Token: 0x06007399 RID: 29593 RVA: 0x0011BCB0 File Offset: 0x00119EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntrustInfo);
		}

		// Token: 0x0600739A RID: 29594 RVA: 0x0011BCC0 File Offset: 0x00119EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntrustInfo other)
		{
			return other != null && (other == this || (this.EntrustId == other.EntrustId && this.IsVisiable == other.IsVisiable && this.HistoryLevel == other.HistoryLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600739B RID: 29595 RVA: 0x0011BD1C File Offset: 0x00119F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntrustId != 0)
			{
				num ^= this.EntrustId.GetHashCode();
			}
			if (this.IsVisiable)
			{
				num ^= this.IsVisiable.GetHashCode();
			}
			if (this.HistoryLevel != 0)
			{
				num ^= this.HistoryLevel.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600739C RID: 29596 RVA: 0x0011BD8D File Offset: 0x00119F8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600739D RID: 29597 RVA: 0x0011BD9A File Offset: 0x00119F9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600739E RID: 29598 RVA: 0x0011BDA4 File Offset: 0x00119FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntrustId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.EntrustId);
			}
			if (this.IsVisiable)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsVisiable);
			}
			if (this.HistoryLevel != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.HistoryLevel);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600739F RID: 29599 RVA: 0x0011BE18 File Offset: 0x0011A018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntrustId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntrustId);
			}
			if (this.IsVisiable)
			{
				num += 2;
			}
			if (this.HistoryLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HistoryLevel);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060073A0 RID: 29600 RVA: 0x0011BE7C File Offset: 0x0011A07C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntrustInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntrustId != 0)
			{
				this.EntrustId = other.EntrustId;
			}
			if (other.IsVisiable)
			{
				this.IsVisiable = other.IsVisiable;
			}
			if (other.HistoryLevel != 0)
			{
				this.HistoryLevel = other.HistoryLevel;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060073A1 RID: 29601 RVA: 0x0011BEE0 File Offset: 0x0011A0E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060073A2 RID: 29602 RVA: 0x0011BEEC File Offset: 0x0011A0EC
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
							this.HistoryLevel = input.ReadInt32();
						}
					}
					else
					{
						this.IsVisiable = input.ReadBool();
					}
				}
				else
				{
					this.EntrustId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003D86 RID: 15750
		private static readonly MessageParser<EntrustInfo> _parser = new MessageParser<EntrustInfo>(() => new EntrustInfo());

		// Token: 0x04003D87 RID: 15751
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D88 RID: 15752
		public const int EntrustIdFieldNumber = 1;

		// Token: 0x04003D89 RID: 15753
		private int entrustId_;

		// Token: 0x04003D8A RID: 15754
		public const int IsVisiableFieldNumber = 2;

		// Token: 0x04003D8B RID: 15755
		private bool isVisiable_;

		// Token: 0x04003D8C RID: 15756
		public const int HistoryLevelFieldNumber = 3;

		// Token: 0x04003D8D RID: 15757
		private int historyLevel_;
	}
}
