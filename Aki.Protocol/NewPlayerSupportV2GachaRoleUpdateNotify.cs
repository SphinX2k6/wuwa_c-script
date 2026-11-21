using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B1A RID: 2842
	[NetMessage(EMessageId.NewPlayerSupportV2GachaRoleUpdateNotify)]
	public sealed class NewPlayerSupportV2GachaRoleUpdateNotify : IMessage<NewPlayerSupportV2GachaRoleUpdateNotify>, IMessage, IEquatable<NewPlayerSupportV2GachaRoleUpdateNotify>, IDeepCloneable<NewPlayerSupportV2GachaRoleUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600F712 RID: 63250 RVA: 0x00240E62 File Offset: 0x0023F062
		[NullableContext(1)]
		public static NewPlayerSupportV2GachaRoleUpdateNotify Create()
		{
			return new NewPlayerSupportV2GachaRoleUpdateNotify();
		}

		// Token: 0x17003252 RID: 12882
		// (get) Token: 0x0600F713 RID: 63251 RVA: 0x00240E69 File Offset: 0x0023F069
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003253 RID: 12883
		// (get) Token: 0x0600F714 RID: 63252 RVA: 0x00240E6C File Offset: 0x0023F06C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewPlayerSupportV2GachaRoleUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600F715 RID: 63253 RVA: 0x00240E73 File Offset: 0x0023F073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportV2GachaRoleUpdateNotify()
		{
		}

		// Token: 0x0600F716 RID: 63254 RVA: 0x00240E86 File Offset: 0x0023F086
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportV2GachaRoleUpdateNotify(NewPlayerSupportV2GachaRoleUpdateNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.deduplicateGachaRoleIds_ = other.deduplicateGachaRoleIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F717 RID: 63255 RVA: 0x00240EBC File Offset: 0x0023F0BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportV2GachaRoleUpdateNotify Clone()
		{
			return new NewPlayerSupportV2GachaRoleUpdateNotify(this);
		}

		// Token: 0x17003254 RID: 12884
		// (get) Token: 0x0600F718 RID: 63256 RVA: 0x00240EC4 File Offset: 0x0023F0C4
		// (set) Token: 0x0600F719 RID: 63257 RVA: 0x00240ECC File Offset: 0x0023F0CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17003255 RID: 12885
		// (get) Token: 0x0600F71A RID: 63258 RVA: 0x00240ED5 File Offset: 0x0023F0D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DeduplicateGachaRoleIds
		{
			get
			{
				return this.deduplicateGachaRoleIds_;
			}
		}

		// Token: 0x0600F71B RID: 63259 RVA: 0x00240EDD File Offset: 0x0023F0DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewPlayerSupportV2GachaRoleUpdateNotify);
		}

		// Token: 0x0600F71C RID: 63260 RVA: 0x00240EEC File Offset: 0x0023F0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewPlayerSupportV2GachaRoleUpdateNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.deduplicateGachaRoleIds_.Equals(other.deduplicateGachaRoleIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F71D RID: 63261 RVA: 0x00240F3C File Offset: 0x0023F13C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.deduplicateGachaRoleIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F71E RID: 63262 RVA: 0x00240F89 File Offset: 0x0023F189
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F71F RID: 63263 RVA: 0x00240F96 File Offset: 0x0023F196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F720 RID: 63264 RVA: 0x00240FA0 File Offset: 0x0023F1A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.deduplicateGachaRoleIds_.WriteTo(ref output, NewPlayerSupportV2GachaRoleUpdateNotify._repeated_deduplicateGachaRoleIds_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F721 RID: 63265 RVA: 0x00240FF0 File Offset: 0x0023F1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.deduplicateGachaRoleIds_.CalculateSize(NewPlayerSupportV2GachaRoleUpdateNotify._repeated_deduplicateGachaRoleIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F722 RID: 63266 RVA: 0x00241044 File Offset: 0x0023F244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewPlayerSupportV2GachaRoleUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.deduplicateGachaRoleIds_.Add(other.deduplicateGachaRoleIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F723 RID: 63267 RVA: 0x00241091 File Offset: 0x0023F291
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F724 RID: 63268 RVA: 0x0024109C File Offset: 0x0023F29C
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
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.deduplicateGachaRoleIds_.AddEntriesFrom(ref input, NewPlayerSupportV2GachaRoleUpdateNotify._repeated_deduplicateGachaRoleIds_codec);
				}
			}
		}

		// Token: 0x0400638B RID: 25483
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400638C RID: 25484
		public const int ActivityIdFieldNumber = 13;

		// Token: 0x0400638D RID: 25485
		private int activityId_;

		// Token: 0x0400638E RID: 25486
		public const int DeduplicateGachaRoleIdsFieldNumber = 10;

		// Token: 0x0400638F RID: 25487
		private static readonly FieldCodec<int> _repeated_deduplicateGachaRoleIds_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04006390 RID: 25488
		private readonly RepeatedField<int> deduplicateGachaRoleIds_ = new RepeatedField<int>();
	}
}
