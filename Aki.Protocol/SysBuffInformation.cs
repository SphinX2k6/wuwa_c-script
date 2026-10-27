using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001316 RID: 4886
	public sealed class SysBuffInformation : IMessage<SysBuffInformation>, IMessage, IEquatable<SysBuffInformation>, IDeepCloneable<SysBuffInformation>, IBufferMessage
	{
		// Token: 0x06019F6D RID: 106349 RVA: 0x003C59C1 File Offset: 0x003C3BC1
		[NullableContext(1)]
		public static SysBuffInformation Create()
		{
			return new SysBuffInformation();
		}

		// Token: 0x1700578C RID: 22412
		// (get) Token: 0x06019F6E RID: 106350 RVA: 0x003C59C8 File Offset: 0x003C3BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SysBuffInformation> Parser
		{
			get
			{
				return SysBuffInformation._parser;
			}
		}

		// Token: 0x1700578D RID: 22413
		// (get) Token: 0x06019F6F RID: 106351 RVA: 0x003C59CF File Offset: 0x003C3BCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700578E RID: 22414
		// (get) Token: 0x06019F70 RID: 106352 RVA: 0x003C59D2 File Offset: 0x003C3BD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SysBuffInformation.Descriptor;
			}
		}

		// Token: 0x06019F71 RID: 106353 RVA: 0x003C59D9 File Offset: 0x003C3BD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SysBuffInformation()
		{
		}

		// Token: 0x06019F72 RID: 106354 RVA: 0x003C59E4 File Offset: 0x003C3BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SysBuffInformation(SysBuffInformation other) : this()
		{
			this.serverId_ = other.serverId_;
			this.buffId_ = other.buffId_;
			this.level_ = other.level_;
			this.messageId_ = other.messageId_;
			this.instigatorId_ = other.instigatorId_;
			this.duration_ = other.duration_;
			this.stackCount_ = other.stackCount_;
			this.applyType_ = other.applyType_;
			this.isIterable_ = other.isIterable_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019F73 RID: 106355 RVA: 0x003C5A74 File Offset: 0x003C3C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SysBuffInformation Clone()
		{
			return new SysBuffInformation(this);
		}

		// Token: 0x1700578F RID: 22415
		// (get) Token: 0x06019F74 RID: 106356 RVA: 0x003C5A7C File Offset: 0x003C3C7C
		// (set) Token: 0x06019F75 RID: 106357 RVA: 0x003C5A84 File Offset: 0x003C3C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ServerId
		{
			get
			{
				return this.serverId_;
			}
			set
			{
				this.serverId_ = value;
			}
		}

		// Token: 0x17005790 RID: 22416
		// (get) Token: 0x06019F76 RID: 106358 RVA: 0x003C5A8D File Offset: 0x003C3C8D
		// (set) Token: 0x06019F77 RID: 106359 RVA: 0x003C5A95 File Offset: 0x003C3C95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BuffId
		{
			get
			{
				return this.buffId_;
			}
			set
			{
				this.buffId_ = value;
			}
		}

		// Token: 0x17005791 RID: 22417
		// (get) Token: 0x06019F78 RID: 106360 RVA: 0x003C5A9E File Offset: 0x003C3C9E
		// (set) Token: 0x06019F79 RID: 106361 RVA: 0x003C5AA6 File Offset: 0x003C3CA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17005792 RID: 22418
		// (get) Token: 0x06019F7A RID: 106362 RVA: 0x003C5AAF File Offset: 0x003C3CAF
		// (set) Token: 0x06019F7B RID: 106363 RVA: 0x003C5AB7 File Offset: 0x003C3CB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long MessageId
		{
			get
			{
				return this.messageId_;
			}
			set
			{
				this.messageId_ = value;
			}
		}

		// Token: 0x17005793 RID: 22419
		// (get) Token: 0x06019F7C RID: 106364 RVA: 0x003C5AC0 File Offset: 0x003C3CC0
		// (set) Token: 0x06019F7D RID: 106365 RVA: 0x003C5AC8 File Offset: 0x003C3CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long InstigatorId
		{
			get
			{
				return this.instigatorId_;
			}
			set
			{
				this.instigatorId_ = value;
			}
		}

		// Token: 0x17005794 RID: 22420
		// (get) Token: 0x06019F7E RID: 106366 RVA: 0x003C5AD1 File Offset: 0x003C3CD1
		// (set) Token: 0x06019F7F RID: 106367 RVA: 0x003C5AD9 File Offset: 0x003C3CD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Duration
		{
			get
			{
				return this.duration_;
			}
			set
			{
				this.duration_ = value;
			}
		}

		// Token: 0x17005795 RID: 22421
		// (get) Token: 0x06019F80 RID: 106368 RVA: 0x003C5AE2 File Offset: 0x003C3CE2
		// (set) Token: 0x06019F81 RID: 106369 RVA: 0x003C5AEA File Offset: 0x003C3CEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StackCount
		{
			get
			{
				return this.stackCount_;
			}
			set
			{
				this.stackCount_ = value;
			}
		}

		// Token: 0x17005796 RID: 22422
		// (get) Token: 0x06019F82 RID: 106370 RVA: 0x003C5AF3 File Offset: 0x003C3CF3
		// (set) Token: 0x06019F83 RID: 106371 RVA: 0x003C5AFB File Offset: 0x003C3CFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyGEType ApplyType
		{
			get
			{
				return this.applyType_;
			}
			set
			{
				this.applyType_ = value;
			}
		}

		// Token: 0x17005797 RID: 22423
		// (get) Token: 0x06019F84 RID: 106372 RVA: 0x003C5B04 File Offset: 0x003C3D04
		// (set) Token: 0x06019F85 RID: 106373 RVA: 0x003C5B0C File Offset: 0x003C3D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsIterable
		{
			get
			{
				return this.isIterable_;
			}
			set
			{
				this.isIterable_ = value;
			}
		}

		// Token: 0x06019F86 RID: 106374 RVA: 0x003C5B15 File Offset: 0x003C3D15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SysBuffInformation);
		}

		// Token: 0x06019F87 RID: 106375 RVA: 0x003C5B24 File Offset: 0x003C3D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SysBuffInformation other)
		{
			return other != null && (other == this || (this.ServerId == other.ServerId && this.BuffId == other.BuffId && this.Level == other.Level && this.MessageId == other.MessageId && this.InstigatorId == other.InstigatorId && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Duration, other.Duration) && this.StackCount == other.StackCount && this.ApplyType == other.ApplyType && this.IsIterable == other.IsIterable && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019F88 RID: 106376 RVA: 0x003C5BE8 File Offset: 0x003C3DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ServerId != 0)
			{
				num ^= this.ServerId.GetHashCode();
			}
			if (this.BuffId != 0L)
			{
				num ^= this.BuffId.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.MessageId != 0L)
			{
				num ^= this.MessageId.GetHashCode();
			}
			if (this.InstigatorId != 0L)
			{
				num ^= this.InstigatorId.GetHashCode();
			}
			if (this.Duration != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Duration);
			}
			if (this.StackCount != 0)
			{
				num ^= this.StackCount.GetHashCode();
			}
			if (this.ApplyType != ApplyGEType.Common)
			{
				num ^= this.ApplyType.GetHashCode();
			}
			if (this.IsIterable)
			{
				num ^= this.IsIterable.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019F89 RID: 106377 RVA: 0x003C5CFD File Offset: 0x003C3EFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019F8A RID: 106378 RVA: 0x003C5D0A File Offset: 0x003C3F0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019F8B RID: 106379 RVA: 0x003C5D14 File Offset: 0x003C3F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ServerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ServerId);
			}
			if (this.BuffId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.BuffId);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Level);
			}
			if (this.MessageId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.MessageId);
			}
			if (this.InstigatorId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.InstigatorId);
			}
			if (this.Duration != 0f)
			{
				output.WriteRawTag(53);
				output.WriteFloat(this.Duration);
			}
			if (this.StackCount != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.StackCount);
			}
			if (this.ApplyType != ApplyGEType.Common)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ApplyType);
			}
			if (this.IsIterable)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsIterable);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019F8C RID: 106380 RVA: 0x003C5E38 File Offset: 0x003C4038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ServerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ServerId);
			}
			if (this.BuffId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BuffId);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.MessageId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.MessageId);
			}
			if (this.InstigatorId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.InstigatorId);
			}
			if (this.Duration != 0f)
			{
				num += 5;
			}
			if (this.StackCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StackCount);
			}
			if (this.ApplyType != ApplyGEType.Common)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ApplyType);
			}
			if (this.IsIterable)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019F8D RID: 106381 RVA: 0x003C5F24 File Offset: 0x003C4124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SysBuffInformation other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ServerId != 0)
			{
				this.ServerId = other.ServerId;
			}
			if (other.BuffId != 0L)
			{
				this.BuffId = other.BuffId;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.MessageId != 0L)
			{
				this.MessageId = other.MessageId;
			}
			if (other.InstigatorId != 0L)
			{
				this.InstigatorId = other.InstigatorId;
			}
			if (other.Duration != 0f)
			{
				this.Duration = other.Duration;
			}
			if (other.StackCount != 0)
			{
				this.StackCount = other.StackCount;
			}
			if (other.ApplyType != ApplyGEType.Common)
			{
				this.ApplyType = other.ApplyType;
			}
			if (other.IsIterable)
			{
				this.IsIterable = other.IsIterable;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019F8E RID: 106382 RVA: 0x003C6005 File Offset: 0x003C4205
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019F8F RID: 106383 RVA: 0x003C6010 File Offset: 0x003C4210
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
				if (num <= 32U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.ServerId = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.BuffId = input.ReadInt64();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.Level = input.ReadInt32();
							continue;
						}
						if (num == 32U)
						{
							this.MessageId = input.ReadInt64();
							continue;
						}
					}
				}
				else if (num <= 53U)
				{
					if (num == 40U)
					{
						this.InstigatorId = input.ReadInt64();
						continue;
					}
					if (num == 53U)
					{
						this.Duration = input.ReadFloat();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.StackCount = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.ApplyType = (ApplyGEType)input.ReadEnum();
						continue;
					}
					if (num == 72U)
					{
						this.IsIterable = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040097B1 RID: 38833
		private static readonly MessageParser<SysBuffInformation> _parser = new MessageParser<SysBuffInformation>(() => new SysBuffInformation());

		// Token: 0x040097B2 RID: 38834
		private UnknownFieldSet _unknownFields;

		// Token: 0x040097B3 RID: 38835
		public const int ServerIdFieldNumber = 1;

		// Token: 0x040097B4 RID: 38836
		private int serverId_;

		// Token: 0x040097B5 RID: 38837
		public const int BuffIdFieldNumber = 2;

		// Token: 0x040097B6 RID: 38838
		private long buffId_;

		// Token: 0x040097B7 RID: 38839
		public const int LevelFieldNumber = 3;

		// Token: 0x040097B8 RID: 38840
		private int level_;

		// Token: 0x040097B9 RID: 38841
		public const int MessageIdFieldNumber = 4;

		// Token: 0x040097BA RID: 38842
		private long messageId_;

		// Token: 0x040097BB RID: 38843
		public const int InstigatorIdFieldNumber = 5;

		// Token: 0x040097BC RID: 38844
		private long instigatorId_;

		// Token: 0x040097BD RID: 38845
		public const int DurationFieldNumber = 6;

		// Token: 0x040097BE RID: 38846
		private float duration_;

		// Token: 0x040097BF RID: 38847
		public const int StackCountFieldNumber = 7;

		// Token: 0x040097C0 RID: 38848
		private int stackCount_;

		// Token: 0x040097C1 RID: 38849
		public const int ApplyTypeFieldNumber = 8;

		// Token: 0x040097C2 RID: 38850
		private ApplyGEType applyType_;

		// Token: 0x040097C3 RID: 38851
		public const int IsIterableFieldNumber = 9;

		// Token: 0x040097C4 RID: 38852
		private bool isIterable_;
	}
}
