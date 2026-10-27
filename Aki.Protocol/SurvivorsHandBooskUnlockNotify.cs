using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012CA RID: 4810
	[NetMessage(EMessageId.SurvivorsHandBooskUnlockNotify)]
	public sealed class SurvivorsHandBooskUnlockNotify : IMessage<SurvivorsHandBooskUnlockNotify>, IMessage, IEquatable<SurvivorsHandBooskUnlockNotify>, IDeepCloneable<SurvivorsHandBooskUnlockNotify>, IBufferMessage
	{
		// Token: 0x0601997D RID: 104829 RVA: 0x003B86C2 File Offset: 0x003B68C2
		[NullableContext(1)]
		public static SurvivorsHandBooskUnlockNotify Create()
		{
			return new SurvivorsHandBooskUnlockNotify();
		}

		// Token: 0x17005655 RID: 22101
		// (get) Token: 0x0601997E RID: 104830 RVA: 0x003B86C9 File Offset: 0x003B68C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005656 RID: 22102
		// (get) Token: 0x0601997F RID: 104831 RVA: 0x003B86CC File Offset: 0x003B68CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsHandBooskUnlockNotify.Descriptor;
			}
		}

		// Token: 0x06019980 RID: 104832 RVA: 0x003B86D3 File Offset: 0x003B68D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsHandBooskUnlockNotify()
		{
		}

		// Token: 0x06019981 RID: 104833 RVA: 0x003B86FC File Offset: 0x003B68FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsHandBooskUnlockNotify(SurvivorsHandBooskUnlockNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.unlockWeaponHandBooks_ = other.unlockWeaponHandBooks_.Clone();
			this.unlockRoleHandBooks_ = other.unlockRoleHandBooks_.Clone();
			this.unlockItemHandBooks_ = other.unlockItemHandBooks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019982 RID: 104834 RVA: 0x003B875F File Offset: 0x003B695F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsHandBooskUnlockNotify Clone()
		{
			return new SurvivorsHandBooskUnlockNotify(this);
		}

		// Token: 0x17005657 RID: 22103
		// (get) Token: 0x06019983 RID: 104835 RVA: 0x003B8767 File Offset: 0x003B6967
		// (set) Token: 0x06019984 RID: 104836 RVA: 0x003B876F File Offset: 0x003B696F
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

		// Token: 0x17005658 RID: 22104
		// (get) Token: 0x06019985 RID: 104837 RVA: 0x003B8778 File Offset: 0x003B6978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockWeaponHandBooks
		{
			get
			{
				return this.unlockWeaponHandBooks_;
			}
		}

		// Token: 0x17005659 RID: 22105
		// (get) Token: 0x06019986 RID: 104838 RVA: 0x003B8780 File Offset: 0x003B6980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockRoleHandBooks
		{
			get
			{
				return this.unlockRoleHandBooks_;
			}
		}

		// Token: 0x1700565A RID: 22106
		// (get) Token: 0x06019987 RID: 104839 RVA: 0x003B8788 File Offset: 0x003B6988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockItemHandBooks
		{
			get
			{
				return this.unlockItemHandBooks_;
			}
		}

		// Token: 0x06019988 RID: 104840 RVA: 0x003B8790 File Offset: 0x003B6990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsHandBooskUnlockNotify);
		}

		// Token: 0x06019989 RID: 104841 RVA: 0x003B87A0 File Offset: 0x003B69A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsHandBooskUnlockNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.unlockWeaponHandBooks_.Equals(other.unlockWeaponHandBooks_) && this.unlockRoleHandBooks_.Equals(other.unlockRoleHandBooks_) && this.unlockItemHandBooks_.Equals(other.unlockItemHandBooks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601998A RID: 104842 RVA: 0x003B8818 File Offset: 0x003B6A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.unlockWeaponHandBooks_.GetHashCode();
			num ^= this.unlockRoleHandBooks_.GetHashCode();
			num ^= this.unlockItemHandBooks_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601998B RID: 104843 RVA: 0x003B8881 File Offset: 0x003B6A81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601998C RID: 104844 RVA: 0x003B888E File Offset: 0x003B6A8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601998D RID: 104845 RVA: 0x003B8898 File Offset: 0x003B6A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockItemHandBooks_.WriteTo(ref output, SurvivorsHandBooskUnlockNotify._repeated_unlockItemHandBooks_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ActivityId);
			}
			this.unlockRoleHandBooks_.WriteTo(ref output, SurvivorsHandBooskUnlockNotify._repeated_unlockRoleHandBooks_codec);
			this.unlockWeaponHandBooks_.WriteTo(ref output, SurvivorsHandBooskUnlockNotify._repeated_unlockWeaponHandBooks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601998E RID: 104846 RVA: 0x003B8908 File Offset: 0x003B6B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.unlockWeaponHandBooks_.CalculateSize(SurvivorsHandBooskUnlockNotify._repeated_unlockWeaponHandBooks_codec);
			num += this.unlockRoleHandBooks_.CalculateSize(SurvivorsHandBooskUnlockNotify._repeated_unlockRoleHandBooks_codec);
			num += this.unlockItemHandBooks_.CalculateSize(SurvivorsHandBooskUnlockNotify._repeated_unlockItemHandBooks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601998F RID: 104847 RVA: 0x003B8980 File Offset: 0x003B6B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsHandBooskUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.unlockWeaponHandBooks_.Add(other.unlockWeaponHandBooks_);
			this.unlockRoleHandBooks_.Add(other.unlockRoleHandBooks_);
			this.unlockItemHandBooks_.Add(other.unlockItemHandBooks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019990 RID: 104848 RVA: 0x003B89EF File Offset: 0x003B6BEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019991 RID: 104849 RVA: 0x003B89F8 File Offset: 0x003B6BF8
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
				if (num <= 56U)
				{
					if (num == 8U || num == 10U)
					{
						this.unlockItemHandBooks_.AddEntriesFrom(ref input, SurvivorsHandBooskUnlockNotify._repeated_unlockItemHandBooks_codec);
						continue;
					}
					if (num == 56U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 82U)
				{
					if (num == 80U || num == 82U)
					{
						this.unlockRoleHandBooks_.AddEntriesFrom(ref input, SurvivorsHandBooskUnlockNotify._repeated_unlockRoleHandBooks_codec);
						continue;
					}
				}
				else if (num == 88U || num == 90U)
				{
					this.unlockWeaponHandBooks_.AddEntriesFrom(ref input, SurvivorsHandBooskUnlockNotify._repeated_unlockWeaponHandBooks_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009618 RID: 38424
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009619 RID: 38425
		public const int ActivityIdFieldNumber = 7;

		// Token: 0x0400961A RID: 38426
		private int activityId_;

		// Token: 0x0400961B RID: 38427
		public const int UnlockWeaponHandBooksFieldNumber = 11;

		// Token: 0x0400961C RID: 38428
		private static readonly FieldCodec<int> _repeated_unlockWeaponHandBooks_codec = FieldCodec.ForInt32(90U);

		// Token: 0x0400961D RID: 38429
		private readonly RepeatedField<int> unlockWeaponHandBooks_ = new RepeatedField<int>();

		// Token: 0x0400961E RID: 38430
		public const int UnlockRoleHandBooksFieldNumber = 10;

		// Token: 0x0400961F RID: 38431
		private static readonly FieldCodec<int> _repeated_unlockRoleHandBooks_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04009620 RID: 38432
		private readonly RepeatedField<int> unlockRoleHandBooks_ = new RepeatedField<int>();

		// Token: 0x04009621 RID: 38433
		public const int UnlockItemHandBooksFieldNumber = 1;

		// Token: 0x04009622 RID: 38434
		private static readonly FieldCodec<int> _repeated_unlockItemHandBooks_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04009623 RID: 38435
		private readonly RepeatedField<int> unlockItemHandBooks_ = new RepeatedField<int>();
	}
}
