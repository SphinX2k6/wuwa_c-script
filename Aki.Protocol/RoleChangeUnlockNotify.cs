using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200104E RID: 4174
	[NetMessage(EMessageId.RoleChangeUnlockNotify)]
	public sealed class RoleChangeUnlockNotify : IMessage<RoleChangeUnlockNotify>, IMessage, IEquatable<RoleChangeUnlockNotify>, IDeepCloneable<RoleChangeUnlockNotify>, IBufferMessage
	{
		// Token: 0x0601654F RID: 91471 RVA: 0x0033F6DF File Offset: 0x0033D8DF
		[NullableContext(1)]
		public static RoleChangeUnlockNotify Create()
		{
			return new RoleChangeUnlockNotify();
		}

		// Token: 0x17004ABC RID: 19132
		// (get) Token: 0x06016550 RID: 91472 RVA: 0x0033F6E6 File Offset: 0x0033D8E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004ABD RID: 19133
		// (get) Token: 0x06016551 RID: 91473 RVA: 0x0033F6E9 File Offset: 0x0033D8E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleChangeUnlockNotify.Descriptor;
			}
		}

		// Token: 0x06016552 RID: 91474 RVA: 0x0033F6F0 File Offset: 0x0033D8F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleChangeUnlockNotify()
		{
		}

		// Token: 0x06016553 RID: 91475 RVA: 0x0033F703 File Offset: 0x0033D903
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleChangeUnlockNotify(RoleChangeUnlockNotify other) : this()
		{
			this.unlockRoleIds_ = other.unlockRoleIds_.Clone();
			this.canChangeSexTime_ = other.canChangeSexTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016554 RID: 91476 RVA: 0x0033F739 File Offset: 0x0033D939
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleChangeUnlockNotify Clone()
		{
			return new RoleChangeUnlockNotify(this);
		}

		// Token: 0x17004ABE RID: 19134
		// (get) Token: 0x06016555 RID: 91477 RVA: 0x0033F741 File Offset: 0x0033D941
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockRoleIds
		{
			get
			{
				return this.unlockRoleIds_;
			}
		}

		// Token: 0x17004ABF RID: 19135
		// (get) Token: 0x06016556 RID: 91478 RVA: 0x0033F749 File Offset: 0x0033D949
		// (set) Token: 0x06016557 RID: 91479 RVA: 0x0033F751 File Offset: 0x0033D951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CanChangeSexTime
		{
			get
			{
				return this.canChangeSexTime_;
			}
			set
			{
				this.canChangeSexTime_ = value;
			}
		}

		// Token: 0x06016558 RID: 91480 RVA: 0x0033F75A File Offset: 0x0033D95A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleChangeUnlockNotify);
		}

		// Token: 0x06016559 RID: 91481 RVA: 0x0033F768 File Offset: 0x0033D968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleChangeUnlockNotify other)
		{
			return other != null && (other == this || (this.unlockRoleIds_.Equals(other.unlockRoleIds_) && this.CanChangeSexTime == other.CanChangeSexTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601655A RID: 91482 RVA: 0x0033F7B8 File Offset: 0x0033D9B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockRoleIds_.GetHashCode();
			if (this.CanChangeSexTime != 0L)
			{
				num ^= this.CanChangeSexTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601655B RID: 91483 RVA: 0x0033F805 File Offset: 0x0033DA05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601655C RID: 91484 RVA: 0x0033F812 File Offset: 0x0033DA12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601655D RID: 91485 RVA: 0x0033F81C File Offset: 0x0033DA1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockRoleIds_.WriteTo(ref output, RoleChangeUnlockNotify._repeated_unlockRoleIds_codec);
			if (this.CanChangeSexTime != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.CanChangeSexTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601655E RID: 91486 RVA: 0x0033F86C File Offset: 0x0033DA6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockRoleIds_.CalculateSize(RoleChangeUnlockNotify._repeated_unlockRoleIds_codec);
			if (this.CanChangeSexTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CanChangeSexTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601655F RID: 91487 RVA: 0x0033F8C0 File Offset: 0x0033DAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleChangeUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockRoleIds_.Add(other.unlockRoleIds_);
			if (other.CanChangeSexTime != 0L)
			{
				this.CanChangeSexTime = other.CanChangeSexTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016560 RID: 91488 RVA: 0x0033F90D File Offset: 0x0033DB0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016561 RID: 91489 RVA: 0x0033F918 File Offset: 0x0033DB18
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
				if (num != 24U && num != 26U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CanChangeSexTime = input.ReadInt64();
					}
				}
				else
				{
					this.unlockRoleIds_.AddEntriesFrom(ref input, RoleChangeUnlockNotify._repeated_unlockRoleIds_codec);
				}
			}
		}

		// Token: 0x0400860B RID: 34315
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400860C RID: 34316
		public const int UnlockRoleIdsFieldNumber = 3;

		// Token: 0x0400860D RID: 34317
		private static readonly FieldCodec<int> _repeated_unlockRoleIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x0400860E RID: 34318
		private readonly RepeatedField<int> unlockRoleIds_ = new RepeatedField<int>();

		// Token: 0x0400860F RID: 34319
		public const int CanChangeSexTimeFieldNumber = 14;

		// Token: 0x04008610 RID: 34320
		private long canChangeSexTime_;
	}
}
