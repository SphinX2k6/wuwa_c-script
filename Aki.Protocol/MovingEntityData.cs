using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AC8 RID: 2760
	public sealed class MovingEntityData : IMessage<MovingEntityData>, IMessage, IEquatable<MovingEntityData>, IDeepCloneable<MovingEntityData>, IBufferMessage
	{
		// Token: 0x0600F04D RID: 61517 RVA: 0x00231B40 File Offset: 0x0022FD40
		[NullableContext(1)]
		public static MovingEntityData Create()
		{
			return new MovingEntityData();
		}

		// Token: 0x170030EA RID: 12522
		// (get) Token: 0x0600F04E RID: 61518 RVA: 0x00231B47 File Offset: 0x0022FD47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MovingEntityData> Parser
		{
			get
			{
				return MovingEntityData._parser;
			}
		}

		// Token: 0x170030EB RID: 12523
		// (get) Token: 0x0600F04F RID: 61519 RVA: 0x00231B4E File Offset: 0x0022FD4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170030EC RID: 12524
		// (get) Token: 0x0600F050 RID: 61520 RVA: 0x00231B51 File Offset: 0x0022FD51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MovingEntityData.Descriptor;
			}
		}

		// Token: 0x0600F051 RID: 61521 RVA: 0x00231B58 File Offset: 0x0022FD58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovingEntityData()
		{
		}

		// Token: 0x0600F052 RID: 61522 RVA: 0x00231B6C File Offset: 0x0022FD6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovingEntityData(MovingEntityData other) : this()
		{
			this.entityId_ = other.entityId_;
			this.originator_ = other.originator_;
			this.moveInfos_ = other.moveInfos_.Clone();
			this.forcePush_ = other.forcePush_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F053 RID: 61523 RVA: 0x00231BC5 File Offset: 0x0022FDC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovingEntityData Clone()
		{
			return new MovingEntityData(this);
		}

		// Token: 0x170030ED RID: 12525
		// (get) Token: 0x0600F054 RID: 61524 RVA: 0x00231BCD File Offset: 0x0022FDCD
		// (set) Token: 0x0600F055 RID: 61525 RVA: 0x00231BD5 File Offset: 0x0022FDD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
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

		// Token: 0x170030EE RID: 12526
		// (get) Token: 0x0600F056 RID: 61526 RVA: 0x00231BDE File Offset: 0x0022FDDE
		// (set) Token: 0x0600F057 RID: 61527 RVA: 0x00231BE6 File Offset: 0x0022FDE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Originator
		{
			get
			{
				return this.originator_;
			}
			set
			{
				this.originator_ = value;
			}
		}

		// Token: 0x170030EF RID: 12527
		// (get) Token: 0x0600F058 RID: 61528 RVA: 0x00231BEF File Offset: 0x0022FDEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MoveReplaySample> MoveInfos
		{
			get
			{
				return this.moveInfos_;
			}
		}

		// Token: 0x170030F0 RID: 12528
		// (get) Token: 0x0600F059 RID: 61529 RVA: 0x00231BF7 File Offset: 0x0022FDF7
		// (set) Token: 0x0600F05A RID: 61530 RVA: 0x00231BFF File Offset: 0x0022FDFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ForcePush
		{
			get
			{
				return this.forcePush_;
			}
			set
			{
				this.forcePush_ = value;
			}
		}

		// Token: 0x0600F05B RID: 61531 RVA: 0x00231C08 File Offset: 0x0022FE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MovingEntityData);
		}

		// Token: 0x0600F05C RID: 61532 RVA: 0x00231C18 File Offset: 0x0022FE18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MovingEntityData other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.Originator == other.Originator && this.moveInfos_.Equals(other.moveInfos_) && this.ForcePush == other.ForcePush && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F05D RID: 61533 RVA: 0x00231C88 File Offset: 0x0022FE88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.Originator != 0L)
			{
				num ^= this.Originator.GetHashCode();
			}
			num ^= this.moveInfos_.GetHashCode();
			if (this.ForcePush)
			{
				num ^= this.ForcePush.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F05E RID: 61534 RVA: 0x00231D07 File Offset: 0x0022FF07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F05F RID: 61535 RVA: 0x00231D14 File Offset: 0x0022FF14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F060 RID: 61536 RVA: 0x00231D20 File Offset: 0x0022FF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this.Originator != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.Originator);
			}
			this.moveInfos_.WriteTo(ref output, MovingEntityData._repeated_moveInfos_codec);
			if (this.ForcePush)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.ForcePush);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F061 RID: 61537 RVA: 0x00231DA8 File Offset: 0x0022FFA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.Originator != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Originator);
			}
			num += this.moveInfos_.CalculateSize(MovingEntityData._repeated_moveInfos_codec);
			if (this.ForcePush)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F062 RID: 61538 RVA: 0x00231E20 File Offset: 0x00230020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MovingEntityData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.Originator != 0L)
			{
				this.Originator = other.Originator;
			}
			this.moveInfos_.Add(other.moveInfos_);
			if (other.ForcePush)
			{
				this.ForcePush = other.ForcePush;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F063 RID: 61539 RVA: 0x00231E95 File Offset: 0x00230095
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F064 RID: 61540 RVA: 0x00231EA0 File Offset: 0x002300A0
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
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 16U)
					{
						this.Originator = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						this.moveInfos_.AddEntriesFrom(ref input, MovingEntityData._repeated_moveInfos_codec);
						continue;
					}
					if (num == 32U)
					{
						this.ForcePush = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006124 RID: 24868
		private static readonly MessageParser<MovingEntityData> _parser = new MessageParser<MovingEntityData>(() => new MovingEntityData());

		// Token: 0x04006125 RID: 24869
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006126 RID: 24870
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04006127 RID: 24871
		private long entityId_;

		// Token: 0x04006128 RID: 24872
		public const int OriginatorFieldNumber = 2;

		// Token: 0x04006129 RID: 24873
		private long originator_;

		// Token: 0x0400612A RID: 24874
		public const int MoveInfosFieldNumber = 3;

		// Token: 0x0400612B RID: 24875
		private static readonly FieldCodec<MoveReplaySample> _repeated_moveInfos_codec = FieldCodec.ForMessage<MoveReplaySample>(26U, MoveReplaySample.Parser);

		// Token: 0x0400612C RID: 24876
		private readonly RepeatedField<MoveReplaySample> moveInfos_ = new RepeatedField<MoveReplaySample>();

		// Token: 0x0400612D RID: 24877
		public const int ForcePushFieldNumber = 4;

		// Token: 0x0400612E RID: 24878
		private bool forcePush_;
	}
}
