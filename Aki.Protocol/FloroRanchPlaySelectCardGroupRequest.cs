using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005B5 RID: 1461
	[NetMessage(EMessageId.FloroRanchPlaySelectCardGroupRequest)]
	public sealed class FloroRanchPlaySelectCardGroupRequest : IMessage<FloroRanchPlaySelectCardGroupRequest>, IMessage, IEquatable<FloroRanchPlaySelectCardGroupRequest>, IDeepCloneable<FloroRanchPlaySelectCardGroupRequest>, IBufferMessage
	{
		// Token: 0x06008788 RID: 34696 RVA: 0x00147365 File Offset: 0x00145565
		[NullableContext(1)]
		public static FloroRanchPlaySelectCardGroupRequest Create()
		{
			return new FloroRanchPlaySelectCardGroupRequest();
		}

		// Token: 0x17001A91 RID: 6801
		// (get) Token: 0x06008789 RID: 34697 RVA: 0x0014736C File Offset: 0x0014556C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A92 RID: 6802
		// (get) Token: 0x0600878A RID: 34698 RVA: 0x0014736F File Offset: 0x0014556F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlaySelectCardGroupRequest.Descriptor;
			}
		}

		// Token: 0x0600878B RID: 34699 RVA: 0x00147376 File Offset: 0x00145576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlaySelectCardGroupRequest()
		{
		}

		// Token: 0x0600878C RID: 34700 RVA: 0x0014738C File Offset: 0x0014558C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlaySelectCardGroupRequest(FloroRanchPlaySelectCardGroupRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.subInsId_ = other.subInsId_;
			this.cardId_ = other.cardId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600878D RID: 34701 RVA: 0x001473D9 File Offset: 0x001455D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlaySelectCardGroupRequest Clone()
		{
			return new FloroRanchPlaySelectCardGroupRequest(this);
		}

		// Token: 0x17001A93 RID: 6803
		// (get) Token: 0x0600878E RID: 34702 RVA: 0x001473E1 File Offset: 0x001455E1
		// (set) Token: 0x0600878F RID: 34703 RVA: 0x001473E9 File Offset: 0x001455E9
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

		// Token: 0x17001A94 RID: 6804
		// (get) Token: 0x06008790 RID: 34704 RVA: 0x001473F2 File Offset: 0x001455F2
		// (set) Token: 0x06008791 RID: 34705 RVA: 0x001473FA File Offset: 0x001455FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubInsId
		{
			get
			{
				return this.subInsId_;
			}
			set
			{
				this.subInsId_ = value;
			}
		}

		// Token: 0x17001A95 RID: 6805
		// (get) Token: 0x06008792 RID: 34706 RVA: 0x00147403 File Offset: 0x00145603
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CardId
		{
			get
			{
				return this.cardId_;
			}
		}

		// Token: 0x06008793 RID: 34707 RVA: 0x0014740B File Offset: 0x0014560B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlaySelectCardGroupRequest);
		}

		// Token: 0x06008794 RID: 34708 RVA: 0x0014741C File Offset: 0x0014561C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlaySelectCardGroupRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.SubInsId == other.SubInsId && this.cardId_.Equals(other.cardId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008795 RID: 34709 RVA: 0x0014747C File Offset: 0x0014567C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.SubInsId != 0)
			{
				num ^= this.SubInsId.GetHashCode();
			}
			num ^= this.cardId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008796 RID: 34710 RVA: 0x001474E2 File Offset: 0x001456E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008797 RID: 34711 RVA: 0x001474EF File Offset: 0x001456EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008798 RID: 34712 RVA: 0x001474F8 File Offset: 0x001456F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubInsId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SubInsId);
			}
			this.cardId_.WriteTo(ref output, FloroRanchPlaySelectCardGroupRequest._repeated_cardId_codec);
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

		// Token: 0x06008799 RID: 34713 RVA: 0x00147564 File Offset: 0x00145764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.SubInsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubInsId);
			}
			num += this.cardId_.CalculateSize(FloroRanchPlaySelectCardGroupRequest._repeated_cardId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600879A RID: 34714 RVA: 0x001475D0 File Offset: 0x001457D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlaySelectCardGroupRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.SubInsId != 0)
			{
				this.SubInsId = other.SubInsId;
			}
			this.cardId_.Add(other.cardId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600879B RID: 34715 RVA: 0x00147631 File Offset: 0x00145831
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600879C RID: 34716 RVA: 0x0014763C File Offset: 0x0014583C
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
						this.SubInsId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						goto IL_45;
					}
				}
				else
				{
					if (num == 18U)
					{
						goto IL_45;
					}
					if (num == 104U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_45:
				this.cardId_.AddEntriesFrom(ref input, FloroRanchPlaySelectCardGroupRequest._repeated_cardId_codec);
			}
		}

		// Token: 0x04004350 RID: 17232
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004351 RID: 17233
		public const int ActivityIdFieldNumber = 13;

		// Token: 0x04004352 RID: 17234
		private int activityId_;

		// Token: 0x04004353 RID: 17235
		public const int SubInsIdFieldNumber = 1;

		// Token: 0x04004354 RID: 17236
		private int subInsId_;

		// Token: 0x04004355 RID: 17237
		public const int CardIdFieldNumber = 2;

		// Token: 0x04004356 RID: 17238
		private static readonly FieldCodec<int> _repeated_cardId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04004357 RID: 17239
		private readonly RepeatedField<int> cardId_ = new RepeatedField<int>();
	}
}
