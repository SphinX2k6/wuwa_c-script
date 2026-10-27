using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B2B RID: 2859
	[NetMessage(EMessageId.NewPlayerSupportV2GachaRoleUpdateNotify)]
	public sealed class NewPlayerSupportV2GachaRoleUpdateNotify : IMessage<NewPlayerSupportV2GachaRoleUpdateNotify>, IMessage, IEquatable<NewPlayerSupportV2GachaRoleUpdateNotify>, IDeepCloneable<NewPlayerSupportV2GachaRoleUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600F82C RID: 63532 RVA: 0x0024307E File Offset: 0x0024127E
		[NullableContext(1)]
		public static NewPlayerSupportV2GachaRoleUpdateNotify Create()
		{
			return new NewPlayerSupportV2GachaRoleUpdateNotify();
		}

		// Token: 0x17003290 RID: 12944
		// (get) Token: 0x0600F82D RID: 63533 RVA: 0x00243085 File Offset: 0x00241285
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003291 RID: 12945
		// (get) Token: 0x0600F82E RID: 63534 RVA: 0x00243088 File Offset: 0x00241288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewPlayerSupportV2GachaRoleUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600F82F RID: 63535 RVA: 0x0024308F File Offset: 0x0024128F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportV2GachaRoleUpdateNotify()
		{
		}

		// Token: 0x0600F830 RID: 63536 RVA: 0x002430A2 File Offset: 0x002412A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportV2GachaRoleUpdateNotify(NewPlayerSupportV2GachaRoleUpdateNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.deduplicateGachaRoleIds_ = other.deduplicateGachaRoleIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F831 RID: 63537 RVA: 0x002430D8 File Offset: 0x002412D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportV2GachaRoleUpdateNotify Clone()
		{
			return new NewPlayerSupportV2GachaRoleUpdateNotify(this);
		}

		// Token: 0x17003292 RID: 12946
		// (get) Token: 0x0600F832 RID: 63538 RVA: 0x002430E0 File Offset: 0x002412E0
		// (set) Token: 0x0600F833 RID: 63539 RVA: 0x002430E8 File Offset: 0x002412E8
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

		// Token: 0x17003293 RID: 12947
		// (get) Token: 0x0600F834 RID: 63540 RVA: 0x002430F1 File Offset: 0x002412F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DeduplicateGachaRoleIds
		{
			get
			{
				return this.deduplicateGachaRoleIds_;
			}
		}

		// Token: 0x0600F835 RID: 63541 RVA: 0x002430F9 File Offset: 0x002412F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewPlayerSupportV2GachaRoleUpdateNotify);
		}

		// Token: 0x0600F836 RID: 63542 RVA: 0x00243108 File Offset: 0x00241308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewPlayerSupportV2GachaRoleUpdateNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.deduplicateGachaRoleIds_.Equals(other.deduplicateGachaRoleIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F837 RID: 63543 RVA: 0x00243158 File Offset: 0x00241358
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

		// Token: 0x0600F838 RID: 63544 RVA: 0x002431A5 File Offset: 0x002413A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F839 RID: 63545 RVA: 0x002431B2 File Offset: 0x002413B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F83A RID: 63546 RVA: 0x002431BC File Offset: 0x002413BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ActivityId);
			}
			this.deduplicateGachaRoleIds_.WriteTo(ref output, NewPlayerSupportV2GachaRoleUpdateNotify._repeated_deduplicateGachaRoleIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F83B RID: 63547 RVA: 0x0024320C File Offset: 0x0024140C
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

		// Token: 0x0600F83C RID: 63548 RVA: 0x00243260 File Offset: 0x00241460
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

		// Token: 0x0600F83D RID: 63549 RVA: 0x002432AD File Offset: 0x002414AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F83E RID: 63550 RVA: 0x002432B8 File Offset: 0x002414B8
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
				if (num != 80U)
				{
					if (num != 96U && num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.deduplicateGachaRoleIds_.AddEntriesFrom(ref input, NewPlayerSupportV2GachaRoleUpdateNotify._repeated_deduplicateGachaRoleIds_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006382 RID: 25474
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006383 RID: 25475
		public const int ActivityIdFieldNumber = 10;

		// Token: 0x04006384 RID: 25476
		private int activityId_;

		// Token: 0x04006385 RID: 25477
		public const int DeduplicateGachaRoleIdsFieldNumber = 12;

		// Token: 0x04006386 RID: 25478
		private static readonly FieldCodec<int> _repeated_deduplicateGachaRoleIds_codec = FieldCodec.ForInt32(98U);

		// Token: 0x04006387 RID: 25479
		private readonly RepeatedField<int> deduplicateGachaRoleIds_ = new RepeatedField<int>();
	}
}
