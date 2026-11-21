using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AB7 RID: 2743
	public sealed class MovingEntityData : IMessage<MovingEntityData>, IMessage, IEquatable<MovingEntityData>, IDeepCloneable<MovingEntityData>, IBufferMessage
	{
		// Token: 0x0600EF33 RID: 61235 RVA: 0x0022F934 File Offset: 0x0022DB34
		[NullableContext(1)]
		public static MovingEntityData Create()
		{
			return new MovingEntityData();
		}

		// Token: 0x170030AC RID: 12460
		// (get) Token: 0x0600EF34 RID: 61236 RVA: 0x0022F93B File Offset: 0x0022DB3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MovingEntityData> Parser
		{
			get
			{
				return MovingEntityData._parser;
			}
		}

		// Token: 0x170030AD RID: 12461
		// (get) Token: 0x0600EF35 RID: 61237 RVA: 0x0022F942 File Offset: 0x0022DB42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170030AE RID: 12462
		// (get) Token: 0x0600EF36 RID: 61238 RVA: 0x0022F945 File Offset: 0x0022DB45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MovingEntityData.Descriptor;
			}
		}

		// Token: 0x0600EF37 RID: 61239 RVA: 0x0022F94C File Offset: 0x0022DB4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovingEntityData()
		{
		}

		// Token: 0x0600EF38 RID: 61240 RVA: 0x0022F960 File Offset: 0x0022DB60
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

		// Token: 0x0600EF39 RID: 61241 RVA: 0x0022F9B9 File Offset: 0x0022DBB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MovingEntityData Clone()
		{
			return new MovingEntityData(this);
		}

		// Token: 0x170030AF RID: 12463
		// (get) Token: 0x0600EF3A RID: 61242 RVA: 0x0022F9C1 File Offset: 0x0022DBC1
		// (set) Token: 0x0600EF3B RID: 61243 RVA: 0x0022F9C9 File Offset: 0x0022DBC9
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

		// Token: 0x170030B0 RID: 12464
		// (get) Token: 0x0600EF3C RID: 61244 RVA: 0x0022F9D2 File Offset: 0x0022DBD2
		// (set) Token: 0x0600EF3D RID: 61245 RVA: 0x0022F9DA File Offset: 0x0022DBDA
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

		// Token: 0x170030B1 RID: 12465
		// (get) Token: 0x0600EF3E RID: 61246 RVA: 0x0022F9E3 File Offset: 0x0022DBE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MoveReplaySample> MoveInfos
		{
			get
			{
				return this.moveInfos_;
			}
		}

		// Token: 0x170030B2 RID: 12466
		// (get) Token: 0x0600EF3F RID: 61247 RVA: 0x0022F9EB File Offset: 0x0022DBEB
		// (set) Token: 0x0600EF40 RID: 61248 RVA: 0x0022F9F3 File Offset: 0x0022DBF3
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

		// Token: 0x0600EF41 RID: 61249 RVA: 0x0022F9FC File Offset: 0x0022DBFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MovingEntityData);
		}

		// Token: 0x0600EF42 RID: 61250 RVA: 0x0022FA0C File Offset: 0x0022DC0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MovingEntityData other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.Originator == other.Originator && this.moveInfos_.Equals(other.moveInfos_) && this.ForcePush == other.ForcePush && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EF43 RID: 61251 RVA: 0x0022FA7C File Offset: 0x0022DC7C
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

		// Token: 0x0600EF44 RID: 61252 RVA: 0x0022FAFB File Offset: 0x0022DCFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EF45 RID: 61253 RVA: 0x0022FB08 File Offset: 0x0022DD08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EF46 RID: 61254 RVA: 0x0022FB14 File Offset: 0x0022DD14
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

		// Token: 0x0600EF47 RID: 61255 RVA: 0x0022FB9C File Offset: 0x0022DD9C
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

		// Token: 0x0600EF48 RID: 61256 RVA: 0x0022FC14 File Offset: 0x0022DE14
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

		// Token: 0x0600EF49 RID: 61257 RVA: 0x0022FC89 File Offset: 0x0022DE89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EF4A RID: 61258 RVA: 0x0022FC94 File Offset: 0x0022DE94
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

		// Token: 0x0400612D RID: 24877
		private static readonly MessageParser<MovingEntityData> _parser = new MessageParser<MovingEntityData>(() => new MovingEntityData());

		// Token: 0x0400612E RID: 24878
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400612F RID: 24879
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04006130 RID: 24880
		private long entityId_;

		// Token: 0x04006131 RID: 24881
		public const int OriginatorFieldNumber = 2;

		// Token: 0x04006132 RID: 24882
		private long originator_;

		// Token: 0x04006133 RID: 24883
		public const int MoveInfosFieldNumber = 3;

		// Token: 0x04006134 RID: 24884
		private static readonly FieldCodec<MoveReplaySample> _repeated_moveInfos_codec = FieldCodec.ForMessage<MoveReplaySample>(26U, MoveReplaySample.Parser);

		// Token: 0x04006135 RID: 24885
		private readonly RepeatedField<MoveReplaySample> moveInfos_ = new RepeatedField<MoveReplaySample>();

		// Token: 0x04006136 RID: 24886
		public const int ForcePushFieldNumber = 4;

		// Token: 0x04006137 RID: 24887
		private bool forcePush_;
	}
}
