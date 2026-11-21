using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aki.Protocol.BattleDefine;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B96 RID: 2966
	[NetMessage(EMessageId.OrderApplyBuffRequest)]
	public sealed class OrderApplyBuffRequest : IMessage<OrderApplyBuffRequest>, IMessage, IEquatable<OrderApplyBuffRequest>, IDeepCloneable<OrderApplyBuffRequest>, IBufferMessage
	{
		// Token: 0x060101BA RID: 65978 RVA: 0x0025A855 File Offset: 0x00258A55
		[NullableContext(1)]
		public static OrderApplyBuffRequest Create()
		{
			return new OrderApplyBuffRequest();
		}

		// Token: 0x170034CE RID: 13518
		// (get) Token: 0x060101BB RID: 65979 RVA: 0x0025A85C File Offset: 0x00258A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170034CF RID: 13519
		// (get) Token: 0x060101BC RID: 65980 RVA: 0x0025A85F File Offset: 0x00258A5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OrderApplyBuffRequest.Descriptor;
			}
		}

		// Token: 0x060101BD RID: 65981 RVA: 0x0025A866 File Offset: 0x00258A66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderApplyBuffRequest()
		{
		}

		// Token: 0x060101BE RID: 65982 RVA: 0x0025A87C File Offset: 0x00258A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderApplyBuffRequest(OrderApplyBuffRequest other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.level_ = other.level_;
			this.instigatorId_ = other.instigatorId_;
			this.applyType_ = other.applyType_;
			this.duration_ = other.duration_;
			this.serverId_ = other.serverId_;
			this.stackCount_ = other.stackCount_;
			this.isIterable_ = other.isIterable_;
			this.transferContextId_ = ((other.transferContextId_ != null) ? other.transferContextId_.Clone() : null);
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060101BF RID: 65983 RVA: 0x0025A934 File Offset: 0x00258B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrderApplyBuffRequest Clone()
		{
			return new OrderApplyBuffRequest(this);
		}

		// Token: 0x170034D0 RID: 13520
		// (get) Token: 0x060101C0 RID: 65984 RVA: 0x0025A93C File Offset: 0x00258B3C
		// (set) Token: 0x060101C1 RID: 65985 RVA: 0x0025A944 File Offset: 0x00258B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
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

		// Token: 0x170034D1 RID: 13521
		// (get) Token: 0x060101C2 RID: 65986 RVA: 0x0025A94D File Offset: 0x00258B4D
		// (set) Token: 0x060101C3 RID: 65987 RVA: 0x0025A955 File Offset: 0x00258B55
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

		// Token: 0x170034D2 RID: 13522
		// (get) Token: 0x060101C4 RID: 65988 RVA: 0x0025A95E File Offset: 0x00258B5E
		// (set) Token: 0x060101C5 RID: 65989 RVA: 0x0025A966 File Offset: 0x00258B66
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

		// Token: 0x170034D3 RID: 13523
		// (get) Token: 0x060101C6 RID: 65990 RVA: 0x0025A96F File Offset: 0x00258B6F
		// (set) Token: 0x060101C7 RID: 65991 RVA: 0x0025A977 File Offset: 0x00258B77
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

		// Token: 0x170034D4 RID: 13524
		// (get) Token: 0x060101C8 RID: 65992 RVA: 0x0025A980 File Offset: 0x00258B80
		// (set) Token: 0x060101C9 RID: 65993 RVA: 0x0025A998 File Offset: 0x00258B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Duration
		{
			get
			{
				if ((this._hasBits0 & 1) != 0)
				{
					return this.duration_;
				}
				return OrderApplyBuffRequest.DurationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.duration_ = value;
			}
		}

		// Token: 0x170034D5 RID: 13525
		// (get) Token: 0x060101CA RID: 65994 RVA: 0x0025A9AF File Offset: 0x00258BAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDuration
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060101CB RID: 65995 RVA: 0x0025A9BC File Offset: 0x00258BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDuration()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170034D6 RID: 13526
		// (get) Token: 0x060101CC RID: 65996 RVA: 0x0025A9CD File Offset: 0x00258BCD
		// (set) Token: 0x060101CD RID: 65997 RVA: 0x0025A9D5 File Offset: 0x00258BD5
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

		// Token: 0x170034D7 RID: 13527
		// (get) Token: 0x060101CE RID: 65998 RVA: 0x0025A9DE File Offset: 0x00258BDE
		// (set) Token: 0x060101CF RID: 65999 RVA: 0x0025A9E6 File Offset: 0x00258BE6
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

		// Token: 0x170034D8 RID: 13528
		// (get) Token: 0x060101D0 RID: 66000 RVA: 0x0025A9EF File Offset: 0x00258BEF
		// (set) Token: 0x060101D1 RID: 66001 RVA: 0x0025A9F7 File Offset: 0x00258BF7
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

		// Token: 0x170034D9 RID: 13529
		// (get) Token: 0x060101D2 RID: 66002 RVA: 0x0025AA00 File Offset: 0x00258C00
		// (set) Token: 0x060101D3 RID: 66003 RVA: 0x0025AA08 File Offset: 0x00258C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransferContextId TransferContextId
		{
			get
			{
				return this.transferContextId_;
			}
			set
			{
				this.transferContextId_ = value;
			}
		}

		// Token: 0x170034DA RID: 13530
		// (get) Token: 0x060101D4 RID: 66004 RVA: 0x0025AA11 File Offset: 0x00258C11
		// (set) Token: 0x060101D5 RID: 66005 RVA: 0x0025AA19 File Offset: 0x00258C19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x060101D6 RID: 66006 RVA: 0x0025AA2C File Offset: 0x00258C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OrderApplyBuffRequest);
		}

		// Token: 0x060101D7 RID: 66007 RVA: 0x0025AA3C File Offset: 0x00258C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OrderApplyBuffRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Level == other.Level && this.InstigatorId == other.InstigatorId && this.ApplyType == other.ApplyType && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Duration, other.Duration) && this.ServerId == other.ServerId && this.StackCount == other.StackCount && this.IsIterable == other.IsIterable && object.Equals(this.TransferContextId, other.TransferContextId) && !(this.Reason != other.Reason) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060101D8 RID: 66008 RVA: 0x0025AB1C File Offset: 0x00258D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.InstigatorId != 0L)
			{
				num ^= this.InstigatorId.GetHashCode();
			}
			if (this.ApplyType != ApplyGEType.Common)
			{
				num ^= this.ApplyType.GetHashCode();
			}
			if (this.HasDuration)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Duration);
			}
			if (this.ServerId != 0)
			{
				num ^= this.ServerId.GetHashCode();
			}
			if (this.StackCount != 0)
			{
				num ^= this.StackCount.GetHashCode();
			}
			if (this.IsIterable)
			{
				num ^= this.IsIterable.GetHashCode();
			}
			if (this.transferContextId_ != null)
			{
				num ^= this.TransferContextId.GetHashCode();
			}
			if (this.Reason.Length != 0)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060101D9 RID: 66009 RVA: 0x0025AC44 File Offset: 0x00258E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060101DA RID: 66010 RVA: 0x0025AC51 File Offset: 0x00258E51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060101DB RID: 66011 RVA: 0x0025AC5C File Offset: 0x00258E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstigatorId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.InstigatorId);
			}
			if (this.IsIterable)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsIterable);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Level);
			}
			if (this.transferContextId_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.TransferContextId);
			}
			if (this.Reason.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.Reason);
			}
			if (this.StackCount != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.StackCount);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.Id);
			}
			if (this.ServerId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ServerId);
			}
			if (this.ApplyType != ApplyGEType.Common)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ApplyType);
			}
			if (this.HasDuration)
			{
				output.WriteRawTag(125);
				output.WriteFloat(this.Duration);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060101DC RID: 66012 RVA: 0x0025AD9C File Offset: 0x00258F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.InstigatorId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.InstigatorId);
			}
			if (this.ApplyType != ApplyGEType.Common)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ApplyType);
			}
			if (this.HasDuration)
			{
				num += 5;
			}
			if (this.ServerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ServerId);
			}
			if (this.StackCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StackCount);
			}
			if (this.IsIterable)
			{
				num += 2;
			}
			if (this.transferContextId_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TransferContextId);
			}
			if (this.Reason.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Reason);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060101DD RID: 66013 RVA: 0x0025AEA0 File Offset: 0x002590A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OrderApplyBuffRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.InstigatorId != 0L)
			{
				this.InstigatorId = other.InstigatorId;
			}
			if (other.ApplyType != ApplyGEType.Common)
			{
				this.ApplyType = other.ApplyType;
			}
			if (other.HasDuration)
			{
				this.Duration = other.Duration;
			}
			if (other.ServerId != 0)
			{
				this.ServerId = other.ServerId;
			}
			if (other.StackCount != 0)
			{
				this.StackCount = other.StackCount;
			}
			if (other.IsIterable)
			{
				this.IsIterable = other.IsIterable;
			}
			if (other.transferContextId_ != null)
			{
				if (this.transferContextId_ == null)
				{
					this.TransferContextId = new TransferContextId();
				}
				this.TransferContextId.MergeFrom(other.TransferContextId);
			}
			if (other.Reason.Length != 0)
			{
				this.Reason = other.Reason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060101DE RID: 66014 RVA: 0x0025AFAD File Offset: 0x002591AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060101DF RID: 66015 RVA: 0x0025AFB8 File Offset: 0x002591B8
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
				if (num <= 42U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.InstigatorId = input.ReadInt64();
							continue;
						}
						if (num == 16U)
						{
							this.IsIterable = input.ReadBool();
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
						if (num == 34U)
						{
							if (this.transferContextId_ == null)
							{
								this.TransferContextId = new TransferContextId();
							}
							input.ReadMessage(this.TransferContextId);
							continue;
						}
						if (num == 42U)
						{
							this.Reason = input.ReadString();
							continue;
						}
					}
				}
				else if (num <= 56U)
				{
					if (num == 48U)
					{
						this.StackCount = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.Id = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.ServerId = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.ApplyType = (ApplyGEType)input.ReadEnum();
						continue;
					}
					if (num == 125U)
					{
						this.Duration = input.ReadFloat();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006717 RID: 26391
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006718 RID: 26392
		private int _hasBits0;

		// Token: 0x04006719 RID: 26393
		public const int IdFieldNumber = 7;

		// Token: 0x0400671A RID: 26394
		private long id_;

		// Token: 0x0400671B RID: 26395
		public const int LevelFieldNumber = 3;

		// Token: 0x0400671C RID: 26396
		private int level_;

		// Token: 0x0400671D RID: 26397
		public const int InstigatorIdFieldNumber = 1;

		// Token: 0x0400671E RID: 26398
		private long instigatorId_;

		// Token: 0x0400671F RID: 26399
		public const int ApplyTypeFieldNumber = 13;

		// Token: 0x04006720 RID: 26400
		private ApplyGEType applyType_;

		// Token: 0x04006721 RID: 26401
		public const int DurationFieldNumber = 15;

		// Token: 0x04006722 RID: 26402
		private static readonly float DurationDefaultValue;

		// Token: 0x04006723 RID: 26403
		private float duration_;

		// Token: 0x04006724 RID: 26404
		public const int ServerIdFieldNumber = 10;

		// Token: 0x04006725 RID: 26405
		private int serverId_;

		// Token: 0x04006726 RID: 26406
		public const int StackCountFieldNumber = 6;

		// Token: 0x04006727 RID: 26407
		private int stackCount_;

		// Token: 0x04006728 RID: 26408
		public const int IsIterableFieldNumber = 2;

		// Token: 0x04006729 RID: 26409
		private bool isIterable_;

		// Token: 0x0400672A RID: 26410
		public const int TransferContextIdFieldNumber = 4;

		// Token: 0x0400672B RID: 26411
		private TransferContextId transferContextId_;

		// Token: 0x0400672C RID: 26412
		public const int ReasonFieldNumber = 5;

		// Token: 0x0400672D RID: 26413
		private string reason_ = "";
	}
}
