using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A32 RID: 2610
	[NetMessage(EMessageId.MotorFightKillRequest)]
	public sealed class MotorFightKillRequest : IMessage<MotorFightKillRequest>, IMessage, IEquatable<MotorFightKillRequest>, IDeepCloneable<MotorFightKillRequest>, IBufferMessage
	{
		// Token: 0x0600E437 RID: 58423 RVA: 0x0021631D File Offset: 0x0021451D
		[NullableContext(1)]
		public static MotorFightKillRequest Create()
		{
			return new MotorFightKillRequest();
		}

		// Token: 0x17002E3F RID: 11839
		// (get) Token: 0x0600E438 RID: 58424 RVA: 0x00216324 File Offset: 0x00214524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E40 RID: 11840
		// (get) Token: 0x0600E439 RID: 58425 RVA: 0x00216327 File Offset: 0x00214527
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightKillRequest.Descriptor;
			}
		}

		// Token: 0x0600E43A RID: 58426 RVA: 0x0021632E File Offset: 0x0021452E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightKillRequest()
		{
		}

		// Token: 0x0600E43B RID: 58427 RVA: 0x00216338 File Offset: 0x00214538
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

		// Token: 0x0600E43C RID: 58428 RVA: 0x0021638C File Offset: 0x0021458C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightKillRequest Clone()
		{
			return new MotorFightKillRequest(this);
		}

		// Token: 0x17002E41 RID: 11841
		// (get) Token: 0x0600E43D RID: 58429 RVA: 0x00216394 File Offset: 0x00214594
		// (set) Token: 0x0600E43E RID: 58430 RVA: 0x0021639C File Offset: 0x0021459C
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

		// Token: 0x17002E42 RID: 11842
		// (get) Token: 0x0600E43F RID: 58431 RVA: 0x002163A5 File Offset: 0x002145A5
		// (set) Token: 0x0600E440 RID: 58432 RVA: 0x002163AD File Offset: 0x002145AD
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

		// Token: 0x17002E43 RID: 11843
		// (get) Token: 0x0600E441 RID: 58433 RVA: 0x002163B6 File Offset: 0x002145B6
		// (set) Token: 0x0600E442 RID: 58434 RVA: 0x002163BE File Offset: 0x002145BE
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

		// Token: 0x17002E44 RID: 11844
		// (get) Token: 0x0600E443 RID: 58435 RVA: 0x002163C7 File Offset: 0x002145C7
		// (set) Token: 0x0600E444 RID: 58436 RVA: 0x002163CF File Offset: 0x002145CF
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

		// Token: 0x0600E445 RID: 58437 RVA: 0x002163D8 File Offset: 0x002145D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightKillRequest);
		}

		// Token: 0x0600E446 RID: 58438 RVA: 0x002163E8 File Offset: 0x002145E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightKillRequest other)
		{
			return other != null && (other == this || (this.WaveGroupIndex == other.WaveGroupIndex && this.EntityId == other.EntityId && this.IsBoss == other.IsBoss && this.IsKilled == other.IsKilled && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E447 RID: 58439 RVA: 0x00216454 File Offset: 0x00214654
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

		// Token: 0x0600E448 RID: 58440 RVA: 0x002164DE File Offset: 0x002146DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E449 RID: 58441 RVA: 0x002164EB File Offset: 0x002146EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E44A RID: 58442 RVA: 0x002164F4 File Offset: 0x002146F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WaveGroupIndex != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.WaveGroupIndex);
			}
			if (this.IsKilled)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsKilled);
			}
			if (this.EntityId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.EntityId);
			}
			if (this.IsBoss)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.IsBoss);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E44B RID: 58443 RVA: 0x00216584 File Offset: 0x00214784
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

		// Token: 0x0600E44C RID: 58444 RVA: 0x002165F4 File Offset: 0x002147F4
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

		// Token: 0x0600E44D RID: 58445 RVA: 0x0021666C File Offset: 0x0021486C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E44E RID: 58446 RVA: 0x00216678 File Offset: 0x00214878
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.WaveGroupIndex = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.IsKilled = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.EntityId = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.IsBoss = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005DBD RID: 23997
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005DBE RID: 23998
		public const int WaveGroupIndexFieldNumber = 1;

		// Token: 0x04005DBF RID: 23999
		private int waveGroupIndex_;

		// Token: 0x04005DC0 RID: 24000
		public const int EntityIdFieldNumber = 11;

		// Token: 0x04005DC1 RID: 24001
		private int entityId_;

		// Token: 0x04005DC2 RID: 24002
		public const int IsBossFieldNumber = 14;

		// Token: 0x04005DC3 RID: 24003
		private bool isBoss_;

		// Token: 0x04005DC4 RID: 24004
		public const int IsKilledFieldNumber = 2;

		// Token: 0x04005DC5 RID: 24005
		private bool isKilled_;
	}
}
