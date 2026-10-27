using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AFD RID: 2813
	[NetMessage(EMessageId.NewbieAdventureTaskUpdateNotify)]
	public sealed class NewbieAdventureTaskUpdateNotify : IMessage<NewbieAdventureTaskUpdateNotify>, IMessage, IEquatable<NewbieAdventureTaskUpdateNotify>, IDeepCloneable<NewbieAdventureTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600F487 RID: 62599 RVA: 0x0023B19D File Offset: 0x0023939D
		[NullableContext(1)]
		public static NewbieAdventureTaskUpdateNotify Create()
		{
			return new NewbieAdventureTaskUpdateNotify();
		}

		// Token: 0x170031CE RID: 12750
		// (get) Token: 0x0600F488 RID: 62600 RVA: 0x0023B1A4 File Offset: 0x002393A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031CF RID: 12751
		// (get) Token: 0x0600F489 RID: 62601 RVA: 0x0023B1A7 File Offset: 0x002393A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieAdventureTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600F48A RID: 62602 RVA: 0x0023B1AE File Offset: 0x002393AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureTaskUpdateNotify()
		{
		}

		// Token: 0x0600F48B RID: 62603 RVA: 0x0023B1C1 File Offset: 0x002393C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureTaskUpdateNotify(NewbieAdventureTaskUpdateNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.chapter_ = other.chapter_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F48C RID: 62604 RVA: 0x0023B1F7 File Offset: 0x002393F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureTaskUpdateNotify Clone()
		{
			return new NewbieAdventureTaskUpdateNotify(this);
		}

		// Token: 0x170031D0 RID: 12752
		// (get) Token: 0x0600F48D RID: 62605 RVA: 0x0023B1FF File Offset: 0x002393FF
		// (set) Token: 0x0600F48E RID: 62606 RVA: 0x0023B207 File Offset: 0x00239407
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

		// Token: 0x170031D1 RID: 12753
		// (get) Token: 0x0600F48F RID: 62607 RVA: 0x0023B210 File Offset: 0x00239410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NewbieAdventureV2ChapterPb> Chapter
		{
			get
			{
				return this.chapter_;
			}
		}

		// Token: 0x0600F490 RID: 62608 RVA: 0x0023B218 File Offset: 0x00239418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieAdventureTaskUpdateNotify);
		}

		// Token: 0x0600F491 RID: 62609 RVA: 0x0023B228 File Offset: 0x00239428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieAdventureTaskUpdateNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.chapter_.Equals(other.chapter_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F492 RID: 62610 RVA: 0x0023B278 File Offset: 0x00239478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.chapter_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F493 RID: 62611 RVA: 0x0023B2C5 File Offset: 0x002394C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F494 RID: 62612 RVA: 0x0023B2D2 File Offset: 0x002394D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F495 RID: 62613 RVA: 0x0023B2DC File Offset: 0x002394DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ActivityId);
			}
			this.chapter_.WriteTo(ref output, NewbieAdventureTaskUpdateNotify._repeated_chapter_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F496 RID: 62614 RVA: 0x0023B32C File Offset: 0x0023952C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.chapter_.CalculateSize(NewbieAdventureTaskUpdateNotify._repeated_chapter_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F497 RID: 62615 RVA: 0x0023B380 File Offset: 0x00239580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewbieAdventureTaskUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.chapter_.Add(other.chapter_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F498 RID: 62616 RVA: 0x0023B3CD File Offset: 0x002395CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F499 RID: 62617 RVA: 0x0023B3D8 File Offset: 0x002395D8
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
				if (num != 16U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.chapter_.AddEntriesFrom(ref input, NewbieAdventureTaskUpdateNotify._repeated_chapter_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006270 RID: 25200
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006271 RID: 25201
		public const int ActivityIdFieldNumber = 2;

		// Token: 0x04006272 RID: 25202
		private int activityId_;

		// Token: 0x04006273 RID: 25203
		public const int ChapterFieldNumber = 11;

		// Token: 0x04006274 RID: 25204
		private static readonly FieldCodec<NewbieAdventureV2ChapterPb> _repeated_chapter_codec = FieldCodec.ForMessage<NewbieAdventureV2ChapterPb>(90U, NewbieAdventureV2ChapterPb.Parser);

		// Token: 0x04006275 RID: 25205
		private readonly RepeatedField<NewbieAdventureV2ChapterPb> chapter_ = new RepeatedField<NewbieAdventureV2ChapterPb>();
	}
}
