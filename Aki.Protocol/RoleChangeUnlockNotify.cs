using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200105E RID: 4190
	[NetMessage(EMessageId.RoleChangeUnlockNotify)]
	public sealed class RoleChangeUnlockNotify : IMessage<RoleChangeUnlockNotify>, IMessage, IEquatable<RoleChangeUnlockNotify>, IDeepCloneable<RoleChangeUnlockNotify>, IBufferMessage
	{
		// Token: 0x06016634 RID: 91700 RVA: 0x00340DB3 File Offset: 0x0033EFB3
		[NullableContext(1)]
		public static RoleChangeUnlockNotify Create()
		{
			return new RoleChangeUnlockNotify();
		}

		// Token: 0x17004AE6 RID: 19174
		// (get) Token: 0x06016635 RID: 91701 RVA: 0x00340DBA File Offset: 0x0033EFBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004AE7 RID: 19175
		// (get) Token: 0x06016636 RID: 91702 RVA: 0x00340DBD File Offset: 0x0033EFBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleChangeUnlockNotify.Descriptor;
			}
		}

		// Token: 0x06016637 RID: 91703 RVA: 0x00340DC4 File Offset: 0x0033EFC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleChangeUnlockNotify()
		{
		}

		// Token: 0x06016638 RID: 91704 RVA: 0x00340DD7 File Offset: 0x0033EFD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleChangeUnlockNotify(RoleChangeUnlockNotify other) : this()
		{
			this.unlockRoleIds_ = other.unlockRoleIds_.Clone();
			this.canChangeSexTime_ = other.canChangeSexTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016639 RID: 91705 RVA: 0x00340E0D File Offset: 0x0033F00D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleChangeUnlockNotify Clone()
		{
			return new RoleChangeUnlockNotify(this);
		}

		// Token: 0x17004AE8 RID: 19176
		// (get) Token: 0x0601663A RID: 91706 RVA: 0x00340E15 File Offset: 0x0033F015
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockRoleIds
		{
			get
			{
				return this.unlockRoleIds_;
			}
		}

		// Token: 0x17004AE9 RID: 19177
		// (get) Token: 0x0601663B RID: 91707 RVA: 0x00340E1D File Offset: 0x0033F01D
		// (set) Token: 0x0601663C RID: 91708 RVA: 0x00340E25 File Offset: 0x0033F025
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

		// Token: 0x0601663D RID: 91709 RVA: 0x00340E2E File Offset: 0x0033F02E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleChangeUnlockNotify);
		}

		// Token: 0x0601663E RID: 91710 RVA: 0x00340E3C File Offset: 0x0033F03C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleChangeUnlockNotify other)
		{
			return other != null && (other == this || (this.unlockRoleIds_.Equals(other.unlockRoleIds_) && this.CanChangeSexTime == other.CanChangeSexTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601663F RID: 91711 RVA: 0x00340E8C File Offset: 0x0033F08C
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

		// Token: 0x06016640 RID: 91712 RVA: 0x00340ED9 File Offset: 0x0033F0D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016641 RID: 91713 RVA: 0x00340EE6 File Offset: 0x0033F0E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016642 RID: 91714 RVA: 0x00340EF0 File Offset: 0x0033F0F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockRoleIds_.WriteTo(ref output, RoleChangeUnlockNotify._repeated_unlockRoleIds_codec);
			if (this.CanChangeSexTime != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.CanChangeSexTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016643 RID: 91715 RVA: 0x00340F40 File Offset: 0x0033F140
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

		// Token: 0x06016644 RID: 91716 RVA: 0x00340F94 File Offset: 0x0033F194
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

		// Token: 0x06016645 RID: 91717 RVA: 0x00340FE1 File Offset: 0x0033F1E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016646 RID: 91718 RVA: 0x00340FEC File Offset: 0x0033F1EC
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
				if (num != 80U && num != 82U)
				{
					if (num != 88U)
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

		// Token: 0x040085E1 RID: 34273
		private UnknownFieldSet _unknownFields;

		// Token: 0x040085E2 RID: 34274
		public const int UnlockRoleIdsFieldNumber = 10;

		// Token: 0x040085E3 RID: 34275
		private static readonly FieldCodec<int> _repeated_unlockRoleIds_codec = FieldCodec.ForInt32(82U);

		// Token: 0x040085E4 RID: 34276
		private readonly RepeatedField<int> unlockRoleIds_ = new RepeatedField<int>();

		// Token: 0x040085E5 RID: 34277
		public const int CanChangeSexTimeFieldNumber = 11;

		// Token: 0x040085E6 RID: 34278
		private long canChangeSexTime_;
	}
}
