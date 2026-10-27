using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B91 RID: 2961
	public sealed class OneSynthesisInfo : IMessage<OneSynthesisInfo>, IMessage, IEquatable<OneSynthesisInfo>, IDeepCloneable<OneSynthesisInfo>, IBufferMessage
	{
		// Token: 0x060100CE RID: 65742 RVA: 0x0025793E File Offset: 0x00255B3E
		[NullableContext(1)]
		public static OneSynthesisInfo Create()
		{
			return new OneSynthesisInfo();
		}

		// Token: 0x1700348B RID: 13451
		// (get) Token: 0x060100CF RID: 65743 RVA: 0x00257945 File Offset: 0x00255B45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OneSynthesisInfo> Parser
		{
			get
			{
				return OneSynthesisInfo._parser;
			}
		}

		// Token: 0x1700348C RID: 13452
		// (get) Token: 0x060100D0 RID: 65744 RVA: 0x0025794C File Offset: 0x00255B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700348D RID: 13453
		// (get) Token: 0x060100D1 RID: 65745 RVA: 0x0025794F File Offset: 0x00255B4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OneSynthesisInfo.Descriptor;
			}
		}

		// Token: 0x060100D2 RID: 65746 RVA: 0x00257956 File Offset: 0x00255B56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneSynthesisInfo()
		{
		}

		// Token: 0x060100D3 RID: 65747 RVA: 0x00257960 File Offset: 0x00255B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneSynthesisInfo(OneSynthesisInfo other) : this()
		{
			this.id_ = other.id_;
			this.count_ = other.count_;
			this.lastRoleId_ = other.lastRoleId_;
			this.limitCount_ = other.limitCount_;
			this.limitSynthesisCount_ = other.limitSynthesisCount_;
			this.limitBeginTime_ = other.limitBeginTime_;
			this.limitEndTime_ = other.limitEndTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060100D4 RID: 65748 RVA: 0x002579D8 File Offset: 0x00255BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneSynthesisInfo Clone()
		{
			return new OneSynthesisInfo(this);
		}

		// Token: 0x1700348E RID: 13454
		// (get) Token: 0x060100D5 RID: 65749 RVA: 0x002579E0 File Offset: 0x00255BE0
		// (set) Token: 0x060100D6 RID: 65750 RVA: 0x002579E8 File Offset: 0x00255BE8
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

		// Token: 0x1700348F RID: 13455
		// (get) Token: 0x060100D7 RID: 65751 RVA: 0x002579F1 File Offset: 0x00255BF1
		// (set) Token: 0x060100D8 RID: 65752 RVA: 0x002579F9 File Offset: 0x00255BF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x17003490 RID: 13456
		// (get) Token: 0x060100D9 RID: 65753 RVA: 0x00257A02 File Offset: 0x00255C02
		// (set) Token: 0x060100DA RID: 65754 RVA: 0x00257A0A File Offset: 0x00255C0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LastRoleId
		{
			get
			{
				return this.lastRoleId_;
			}
			set
			{
				this.lastRoleId_ = value;
			}
		}

		// Token: 0x17003491 RID: 13457
		// (get) Token: 0x060100DB RID: 65755 RVA: 0x00257A13 File Offset: 0x00255C13
		// (set) Token: 0x060100DC RID: 65756 RVA: 0x00257A1B File Offset: 0x00255C1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LimitCount
		{
			get
			{
				return this.limitCount_;
			}
			set
			{
				this.limitCount_ = value;
			}
		}

		// Token: 0x17003492 RID: 13458
		// (get) Token: 0x060100DD RID: 65757 RVA: 0x00257A24 File Offset: 0x00255C24
		// (set) Token: 0x060100DE RID: 65758 RVA: 0x00257A2C File Offset: 0x00255C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LimitSynthesisCount
		{
			get
			{
				return this.limitSynthesisCount_;
			}
			set
			{
				this.limitSynthesisCount_ = value;
			}
		}

		// Token: 0x17003493 RID: 13459
		// (get) Token: 0x060100DF RID: 65759 RVA: 0x00257A35 File Offset: 0x00255C35
		// (set) Token: 0x060100E0 RID: 65760 RVA: 0x00257A3D File Offset: 0x00255C3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LimitBeginTime
		{
			get
			{
				return this.limitBeginTime_;
			}
			set
			{
				this.limitBeginTime_ = value;
			}
		}

		// Token: 0x17003494 RID: 13460
		// (get) Token: 0x060100E1 RID: 65761 RVA: 0x00257A46 File Offset: 0x00255C46
		// (set) Token: 0x060100E2 RID: 65762 RVA: 0x00257A4E File Offset: 0x00255C4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LimitEndTime
		{
			get
			{
				return this.limitEndTime_;
			}
			set
			{
				this.limitEndTime_ = value;
			}
		}

		// Token: 0x060100E3 RID: 65763 RVA: 0x00257A57 File Offset: 0x00255C57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OneSynthesisInfo);
		}

		// Token: 0x060100E4 RID: 65764 RVA: 0x00257A68 File Offset: 0x00255C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OneSynthesisInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Count == other.Count && this.LastRoleId == other.LastRoleId && this.LimitCount == other.LimitCount && this.LimitSynthesisCount == other.LimitSynthesisCount && this.LimitBeginTime == other.LimitBeginTime && this.LimitEndTime == other.LimitEndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060100E5 RID: 65765 RVA: 0x00257B04 File Offset: 0x00255D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this.LastRoleId != 0)
			{
				num ^= this.LastRoleId.GetHashCode();
			}
			if (this.LimitCount != 0)
			{
				num ^= this.LimitCount.GetHashCode();
			}
			if (this.LimitSynthesisCount != 0)
			{
				num ^= this.LimitSynthesisCount.GetHashCode();
			}
			if (this.LimitBeginTime != 0L)
			{
				num ^= this.LimitBeginTime.GetHashCode();
			}
			if (this.LimitEndTime != 0L)
			{
				num ^= this.LimitEndTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060100E6 RID: 65766 RVA: 0x00257BD9 File Offset: 0x00255DD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060100E7 RID: 65767 RVA: 0x00257BE6 File Offset: 0x00255DE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060100E8 RID: 65768 RVA: 0x00257BF0 File Offset: 0x00255DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Count);
			}
			if (this.LastRoleId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.LastRoleId);
			}
			if (this.LimitCount != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.LimitCount);
			}
			if (this.LimitSynthesisCount != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.LimitSynthesisCount);
			}
			if (this.LimitBeginTime != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.LimitBeginTime);
			}
			if (this.LimitEndTime != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.LimitEndTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060100E9 RID: 65769 RVA: 0x00257CD4 File Offset: 0x00255ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this.LastRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LastRoleId);
			}
			if (this.LimitCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LimitCount);
			}
			if (this.LimitSynthesisCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LimitSynthesisCount);
			}
			if (this.LimitBeginTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LimitBeginTime);
			}
			if (this.LimitEndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LimitEndTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060100EA RID: 65770 RVA: 0x00257DA4 File Offset: 0x00255FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OneSynthesisInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			if (other.LastRoleId != 0)
			{
				this.LastRoleId = other.LastRoleId;
			}
			if (other.LimitCount != 0)
			{
				this.LimitCount = other.LimitCount;
			}
			if (other.LimitSynthesisCount != 0)
			{
				this.LimitSynthesisCount = other.LimitSynthesisCount;
			}
			if (other.LimitBeginTime != 0L)
			{
				this.LimitBeginTime = other.LimitBeginTime;
			}
			if (other.LimitEndTime != 0L)
			{
				this.LimitEndTime = other.LimitEndTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060100EB RID: 65771 RVA: 0x00257E58 File Offset: 0x00256058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060100EC RID: 65772 RVA: 0x00257E64 File Offset: 0x00256064
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Count = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.LastRoleId = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 40U)
				{
					if (num == 32U)
					{
						this.LimitCount = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.LimitSynthesisCount = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.LimitBeginTime = input.ReadInt64();
						continue;
					}
					if (num == 56U)
					{
						this.LimitEndTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006650 RID: 26192
		private static readonly MessageParser<OneSynthesisInfo> _parser = new MessageParser<OneSynthesisInfo>(() => new OneSynthesisInfo());

		// Token: 0x04006651 RID: 26193
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006652 RID: 26194
		public const int IdFieldNumber = 1;

		// Token: 0x04006653 RID: 26195
		private int id_;

		// Token: 0x04006654 RID: 26196
		public const int CountFieldNumber = 2;

		// Token: 0x04006655 RID: 26197
		private int count_;

		// Token: 0x04006656 RID: 26198
		public const int LastRoleIdFieldNumber = 3;

		// Token: 0x04006657 RID: 26199
		private int lastRoleId_;

		// Token: 0x04006658 RID: 26200
		public const int LimitCountFieldNumber = 4;

		// Token: 0x04006659 RID: 26201
		private int limitCount_;

		// Token: 0x0400665A RID: 26202
		public const int LimitSynthesisCountFieldNumber = 5;

		// Token: 0x0400665B RID: 26203
		private int limitSynthesisCount_;

		// Token: 0x0400665C RID: 26204
		public const int LimitBeginTimeFieldNumber = 6;

		// Token: 0x0400665D RID: 26205
		private long limitBeginTime_;

		// Token: 0x0400665E RID: 26206
		public const int LimitEndTimeFieldNumber = 7;

		// Token: 0x0400665F RID: 26207
		private long limitEndTime_;
	}
}
