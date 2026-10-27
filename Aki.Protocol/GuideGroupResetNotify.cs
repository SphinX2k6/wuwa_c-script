using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000725 RID: 1829
	[NetMessage(EMessageId.GuideGroupResetNotify)]
	public sealed class GuideGroupResetNotify : IMessage<GuideGroupResetNotify>, IMessage, IEquatable<GuideGroupResetNotify>, IDeepCloneable<GuideGroupResetNotify>, IBufferMessage
	{
		// Token: 0x0600A628 RID: 42536 RVA: 0x00190B4B File Offset: 0x0018ED4B
		[NullableContext(1)]
		public static GuideGroupResetNotify Create()
		{
			return new GuideGroupResetNotify();
		}

		// Token: 0x1700216F RID: 8559
		// (get) Token: 0x0600A629 RID: 42537 RVA: 0x00190B52 File Offset: 0x0018ED52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002170 RID: 8560
		// (get) Token: 0x0600A62A RID: 42538 RVA: 0x00190B55 File Offset: 0x0018ED55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GuideGroupResetNotify.Descriptor;
			}
		}

		// Token: 0x0600A62B RID: 42539 RVA: 0x00190B5C File Offset: 0x0018ED5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideGroupResetNotify()
		{
		}

		// Token: 0x0600A62C RID: 42540 RVA: 0x00190B6F File Offset: 0x0018ED6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideGroupResetNotify(GuideGroupResetNotify other) : this()
		{
			this.groupIds_ = other.groupIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A62D RID: 42541 RVA: 0x00190B99 File Offset: 0x0018ED99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideGroupResetNotify Clone()
		{
			return new GuideGroupResetNotify(this);
		}

		// Token: 0x17002171 RID: 8561
		// (get) Token: 0x0600A62E RID: 42542 RVA: 0x00190BA1 File Offset: 0x0018EDA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> GroupIds
		{
			get
			{
				return this.groupIds_;
			}
		}

		// Token: 0x0600A62F RID: 42543 RVA: 0x00190BA9 File Offset: 0x0018EDA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GuideGroupResetNotify);
		}

		// Token: 0x0600A630 RID: 42544 RVA: 0x00190BB7 File Offset: 0x0018EDB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GuideGroupResetNotify other)
		{
			return other != null && (other == this || (this.groupIds_.Equals(other.groupIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A631 RID: 42545 RVA: 0x00190BEC File Offset: 0x0018EDEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.groupIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A632 RID: 42546 RVA: 0x00190C20 File Offset: 0x0018EE20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A633 RID: 42547 RVA: 0x00190C2D File Offset: 0x0018EE2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A634 RID: 42548 RVA: 0x00190C36 File Offset: 0x0018EE36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.groupIds_.WriteTo(ref output, GuideGroupResetNotify._repeated_groupIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A635 RID: 42549 RVA: 0x00190C60 File Offset: 0x0018EE60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.groupIds_.CalculateSize(GuideGroupResetNotify._repeated_groupIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A636 RID: 42550 RVA: 0x00190C99 File Offset: 0x0018EE99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GuideGroupResetNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.groupIds_.Add(other.groupIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A637 RID: 42551 RVA: 0x00190CC7 File Offset: 0x0018EEC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A638 RID: 42552 RVA: 0x00190CD0 File Offset: 0x0018EED0
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
				if (num != 48U && num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.groupIds_.AddEntriesFrom(ref input, GuideGroupResetNotify._repeated_groupIds_codec);
				}
			}
		}

		// Token: 0x04004C49 RID: 19529
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C4A RID: 19530
		public const int GroupIdsFieldNumber = 6;

		// Token: 0x04004C4B RID: 19531
		private static readonly FieldCodec<int> _repeated_groupIds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04004C4C RID: 19532
		private readonly RepeatedField<int> groupIds_ = new RepeatedField<int>();
	}
}
