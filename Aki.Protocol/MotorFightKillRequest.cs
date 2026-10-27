using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A43 RID: 2627
	[NetMessage(EMessageId.MotorFightKillRequest)]
	public sealed class MotorFightKillRequest : IMessage<MotorFightKillRequest>, IMessage, IEquatable<MotorFightKillRequest>, IDeepCloneable<MotorFightKillRequest>, IBufferMessage
	{
		// Token: 0x0600E551 RID: 58705 RVA: 0x0021850D File Offset: 0x0021670D
		[NullableContext(1)]
		public static MotorFightKillRequest Create()
		{
			return new MotorFightKillRequest();
		}

		// Token: 0x17002E7D RID: 11901
		// (get) Token: 0x0600E552 RID: 58706 RVA: 0x00218514 File Offset: 0x00216714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E7E RID: 11902
		// (get) Token: 0x0600E553 RID: 58707 RVA: 0x00218517 File Offset: 0x00216717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightKillRequest.Descriptor;
			}
		}

		// Token: 0x0600E554 RID: 58708 RVA: 0x0021851E File Offset: 0x0021671E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightKillRequest()
		{
		}

		// Token: 0x0600E555 RID: 58709 RVA: 0x00218528 File Offset: 0x00216728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightKillRequest(MotorFightKillRequest other) : this()
		{
			this.waveGroupIndex_ = other.waveGroupIndex_;
			this.entityId_ = other.entityId_;
			this.isBoss_ = other.isBoss_;
			this.isKilled_ = other.isKilled_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E556 RID: 58710 RVA: 0x0021857C File Offset: 0x0021677C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightKillRequest Clone()
		{
			return new MotorFightKillRequest(this);
		}

		// Token: 0x17002E7F RID: 11903
		// (get) Token: 0x0600E557 RID: 58711 RVA: 0x00218584 File Offset: 0x00216784
		// (set) Token: 0x0600E558 RID: 58712 RVA: 0x0021858C File Offset: 0x0021678C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WaveGroupIndex
		{
			get
			{
				return this.waveGroupIndex_;
			}
			set
			{
				this.waveGroupIndex_ = value;
			}
		}

		// Token: 0x17002E80 RID: 11904
		// (get) Token: 0x0600E559 RID: 58713 RVA: 0x00218595 File Offset: 0x00216795
		// (set) Token: 0x0600E55A RID: 58714 RVA: 0x0021859D File Offset: 0x0021679D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17002E81 RID: 11905
		// (get) Token: 0x0600E55B RID: 58715 RVA: 0x002185A6 File Offset: 0x002167A6
		// (set) Token: 0x0600E55C RID: 58716 RVA: 0x002185AE File Offset: 0x002167AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsBoss
		{
			get
			{
				return this.isBoss_;
			}
			set
			{
				this.isBoss_ = value;
			}
		}

		// Token: 0x17002E82 RID: 11906
		// (get) Token: 0x0600E55D RID: 58717 RVA: 0x002185B7 File Offset: 0x002167B7
		// (set) Token: 0x0600E55E RID: 58718 RVA: 0x002185BF File Offset: 0x002167BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsKilled
		{
			get
			{
				return this.isKilled_;
			}
			set
			{
				this.isKilled_ = value;
			}
		}

		// Token: 0x0600E55F RID: 58719 RVA: 0x002185C8 File Offset: 0x002167C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightKillRequest);
		}

		// Token: 0x0600E560 RID: 58720 RVA: 0x002185D8 File Offset: 0x002167D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightKillRequest other)
		{
			return other != null && (other == this || (this.WaveGroupIndex == other.WaveGroupIndex && this.EntityId == other.EntityId && this.IsBoss == other.IsBoss && this.IsKilled == other.IsKilled && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E561 RID: 58721 RVA: 0x00218644 File Offset: 0x00216844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WaveGroupIndex != 0)
			{
				num ^= this.WaveGroupIndex.GetHashCode();
			}
			if (this.EntityId != 0)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.IsBoss)
			{
				num ^= this.IsBoss.GetHashCode();
			}
			if (this.IsKilled)
			{
				num ^= this.IsKilled.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E562 RID: 58722 RVA: 0x002186CE File Offset: 0x002168CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E563 RID: 58723 RVA: 0x002186DB File Offset: 0x002168DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E564 RID: 58724 RVA: 0x002186E4 File Offset: 0x002168E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.EntityId);
			}
			if (this.WaveGroupIndex != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.WaveGroupIndex);
			}
			if (this.IsKilled)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsKilled);
			}
			if (this.IsBoss)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.IsBoss);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E565 RID: 58725 RVA: 0x00218778 File Offset: 0x00216978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WaveGroupIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WaveGroupIndex);
			}
			if (this.EntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityId);
			}
			if (this.IsBoss)
			{
				num += 2;
			}
			if (this.IsKilled)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E566 RID: 58726 RVA: 0x002187E8 File Offset: 0x002169E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightKillRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WaveGroupIndex != 0)
			{
				this.WaveGroupIndex = other.WaveGroupIndex;
			}
			if (other.EntityId != 0)
			{
				this.EntityId = other.EntityId;
			}
			if (other.IsBoss)
			{
				this.IsBoss = other.IsBoss;
			}
			if (other.IsKilled)
			{
				this.IsKilled = other.IsKilled;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E567 RID: 58727 RVA: 0x00218860 File Offset: 0x00216A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E568 RID: 58728 RVA: 0x0021886C File Offset: 0x00216A6C
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
				if (num <= 72U)
				{
					if (num == 16U)
					{
						this.EntityId = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.WaveGroupIndex = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.IsKilled = input.ReadBool();
						continue;
					}
					if (num == 120U)
					{
						this.IsBoss = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005DB4 RID: 23988
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005DB5 RID: 23989
		public const int WaveGroupIndexFieldNumber = 9;

		// Token: 0x04005DB6 RID: 23990
		private int waveGroupIndex_;

		// Token: 0x04005DB7 RID: 23991
		public const int EntityIdFieldNumber = 2;

		// Token: 0x04005DB8 RID: 23992
		private int entityId_;

		// Token: 0x04005DB9 RID: 23993
		public const int IsBossFieldNumber = 15;

		// Token: 0x04005DBA RID: 23994
		private bool isBoss_;

		// Token: 0x04005DBB RID: 23995
		public const int IsKilledFieldNumber = 11;

		// Token: 0x04005DBC RID: 23996
		private bool isKilled_;
	}
}
