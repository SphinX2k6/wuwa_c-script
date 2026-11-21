using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000085 RID: 133
	[NetMessage(EMessageId.ActivityDisableNotify)]
	public sealed class ActivityDisableNotify : IMessage<ActivityDisableNotify>, IMessage, IEquatable<ActivityDisableNotify>, IDeepCloneable<ActivityDisableNotify>, IBufferMessage
	{
		// Token: 0x06001A56 RID: 6742 RVA: 0x0004AB63 File Offset: 0x00048D63
		[NullableContext(1)]
		public static ActivityDisableNotify Create()
		{
			return new ActivityDisableNotify();
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06001A57 RID: 6743 RVA: 0x0004AB6A File Offset: 0x00048D6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06001A58 RID: 6744 RVA: 0x0004AB6D File Offset: 0x00048D6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityDisableNotify.Descriptor;
			}
		}

		// Token: 0x06001A59 RID: 6745 RVA: 0x0004AB74 File Offset: 0x00048D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityDisableNotify()
		{
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x0004AB87 File Offset: 0x00048D87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityDisableNotify(ActivityDisableNotify other) : this()
		{
			this.activityIds_ = other.activityIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x0004ABB1 File Offset: 0x00048DB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityDisableNotify Clone()
		{
			return new ActivityDisableNotify(this);
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06001A5C RID: 6748 RVA: 0x0004ABB9 File Offset: 0x00048DB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ActivityIds
		{
			get
			{
				return this.activityIds_;
			}
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x0004ABC1 File Offset: 0x00048DC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityDisableNotify);
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x0004ABCF File Offset: 0x00048DCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityDisableNotify other)
		{
			return other != null && (other == this || (this.activityIds_.Equals(other.activityIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x0004AC04 File Offset: 0x00048E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.activityIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001A60 RID: 6752 RVA: 0x0004AC38 File Offset: 0x00048E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001A61 RID: 6753 RVA: 0x0004AC45 File Offset: 0x00048E45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001A62 RID: 6754 RVA: 0x0004AC4E File Offset: 0x00048E4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.activityIds_.WriteTo(ref output, ActivityDisableNotify._repeated_activityIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001A63 RID: 6755 RVA: 0x0004AC78 File Offset: 0x00048E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.activityIds_.CalculateSize(ActivityDisableNotify._repeated_activityIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001A64 RID: 6756 RVA: 0x0004ACB1 File Offset: 0x00048EB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActivityDisableNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.activityIds_.Add(other.activityIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001A65 RID: 6757 RVA: 0x0004ACDF File Offset: 0x00048EDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001A66 RID: 6758 RVA: 0x0004ACE8 File Offset: 0x00048EE8
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
				if (num != 72U && num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.activityIds_.AddEntriesFrom(ref input, ActivityDisableNotify._repeated_activityIds_codec);
				}
			}
		}

		// Token: 0x0400229A RID: 8858
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400229B RID: 8859
		public const int ActivityIdsFieldNumber = 9;

		// Token: 0x0400229C RID: 8860
		private static readonly FieldCodec<int> _repeated_activityIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x0400229D RID: 8861
		private readonly RepeatedField<int> activityIds_ = new RepeatedField<int>();
	}
}
