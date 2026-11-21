using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AEC RID: 2796
	[NetMessage(EMessageId.NewbieAdventureTaskUpdateNotify)]
	public sealed class NewbieAdventureTaskUpdateNotify : IMessage<NewbieAdventureTaskUpdateNotify>, IMessage, IEquatable<NewbieAdventureTaskUpdateNotify>, IDeepCloneable<NewbieAdventureTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600F36D RID: 62317 RVA: 0x00238F91 File Offset: 0x00237191
		[NullableContext(1)]
		public static NewbieAdventureTaskUpdateNotify Create()
		{
			return new NewbieAdventureTaskUpdateNotify();
		}

		// Token: 0x17003190 RID: 12688
		// (get) Token: 0x0600F36E RID: 62318 RVA: 0x00238F98 File Offset: 0x00237198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003191 RID: 12689
		// (get) Token: 0x0600F36F RID: 62319 RVA: 0x00238F9B File Offset: 0x0023719B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieAdventureTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600F370 RID: 62320 RVA: 0x00238FA2 File Offset: 0x002371A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureTaskUpdateNotify()
		{
		}

		// Token: 0x0600F371 RID: 62321 RVA: 0x00238FB5 File Offset: 0x002371B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureTaskUpdateNotify(NewbieAdventureTaskUpdateNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.chapter_ = other.chapter_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F372 RID: 62322 RVA: 0x00238FEB File Offset: 0x002371EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureTaskUpdateNotify Clone()
		{
			return new NewbieAdventureTaskUpdateNotify(this);
		}

		// Token: 0x17003192 RID: 12690
		// (get) Token: 0x0600F373 RID: 62323 RVA: 0x00238FF3 File Offset: 0x002371F3
		// (set) Token: 0x0600F374 RID: 62324 RVA: 0x00238FFB File Offset: 0x002371FB
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

		// Token: 0x17003193 RID: 12691
		// (get) Token: 0x0600F375 RID: 62325 RVA: 0x00239004 File Offset: 0x00237204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NewbieAdventureV2ChapterPb> Chapter
		{
			get
			{
				return this.chapter_;
			}
		}

		// Token: 0x0600F376 RID: 62326 RVA: 0x0023900C File Offset: 0x0023720C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieAdventureTaskUpdateNotify);
		}

		// Token: 0x0600F377 RID: 62327 RVA: 0x0023901C File Offset: 0x0023721C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieAdventureTaskUpdateNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.chapter_.Equals(other.chapter_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F378 RID: 62328 RVA: 0x0023906C File Offset: 0x0023726C
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

		// Token: 0x0600F379 RID: 62329 RVA: 0x002390B9 File Offset: 0x002372B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F37A RID: 62330 RVA: 0x002390C6 File Offset: 0x002372C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F37B RID: 62331 RVA: 0x002390D0 File Offset: 0x002372D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActivityId);
			}
			this.chapter_.WriteTo(ref output, NewbieAdventureTaskUpdateNotify._repeated_chapter_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F37C RID: 62332 RVA: 0x00239120 File Offset: 0x00237320
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

		// Token: 0x0600F37D RID: 62333 RVA: 0x00239174 File Offset: 0x00237374
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

		// Token: 0x0600F37E RID: 62334 RVA: 0x002391C1 File Offset: 0x002373C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F37F RID: 62335 RVA: 0x002391CC File Offset: 0x002373CC
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
				if (num != 24U)
				{
					if (num != 42U)
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

		// Token: 0x04006279 RID: 25209
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400627A RID: 25210
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x0400627B RID: 25211
		private int activityId_;

		// Token: 0x0400627C RID: 25212
		public const int ChapterFieldNumber = 5;

		// Token: 0x0400627D RID: 25213
		private static readonly FieldCodec<NewbieAdventureV2ChapterPb> _repeated_chapter_codec = FieldCodec.ForMessage<NewbieAdventureV2ChapterPb>(42U, NewbieAdventureV2ChapterPb.Parser);

		// Token: 0x0400627E RID: 25214
		private readonly RepeatedField<NewbieAdventureV2ChapterPb> chapter_ = new RepeatedField<NewbieAdventureV2ChapterPb>();
	}
}
