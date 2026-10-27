using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AF7 RID: 2807
	[NetMessage(EMessageId.NewbieAdventureChapterDropRequest)]
	public sealed class NewbieAdventureChapterDropRequest : IMessage<NewbieAdventureChapterDropRequest>, IMessage, IEquatable<NewbieAdventureChapterDropRequest>, IDeepCloneable<NewbieAdventureChapterDropRequest>, IBufferMessage
	{
		// Token: 0x0600F413 RID: 62483 RVA: 0x0023A370 File Offset: 0x00238570
		[NullableContext(1)]
		public static NewbieAdventureChapterDropRequest Create()
		{
			return new NewbieAdventureChapterDropRequest();
		}

		// Token: 0x170031B8 RID: 12728
		// (get) Token: 0x0600F414 RID: 62484 RVA: 0x0023A377 File Offset: 0x00238577
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031B9 RID: 12729
		// (get) Token: 0x0600F415 RID: 62485 RVA: 0x0023A37A File Offset: 0x0023857A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieAdventureChapterDropRequest.Descriptor;
			}
		}

		// Token: 0x0600F416 RID: 62486 RVA: 0x0023A381 File Offset: 0x00238581
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureChapterDropRequest()
		{
		}

		// Token: 0x0600F417 RID: 62487 RVA: 0x0023A389 File Offset: 0x00238589
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureChapterDropRequest(NewbieAdventureChapterDropRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.chapterId_ = other.chapterId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F418 RID: 62488 RVA: 0x0023A3BA File Offset: 0x002385BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureChapterDropRequest Clone()
		{
			return new NewbieAdventureChapterDropRequest(this);
		}

		// Token: 0x170031BA RID: 12730
		// (get) Token: 0x0600F419 RID: 62489 RVA: 0x0023A3C2 File Offset: 0x002385C2
		// (set) Token: 0x0600F41A RID: 62490 RVA: 0x0023A3CA File Offset: 0x002385CA
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

		// Token: 0x170031BB RID: 12731
		// (get) Token: 0x0600F41B RID: 62491 RVA: 0x0023A3D3 File Offset: 0x002385D3
		// (set) Token: 0x0600F41C RID: 62492 RVA: 0x0023A3DB File Offset: 0x002385DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChapterId
		{
			get
			{
				return this.chapterId_;
			}
			set
			{
				this.chapterId_ = value;
			}
		}

		// Token: 0x0600F41D RID: 62493 RVA: 0x0023A3E4 File Offset: 0x002385E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieAdventureChapterDropRequest);
		}

		// Token: 0x0600F41E RID: 62494 RVA: 0x0023A3F2 File Offset: 0x002385F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieAdventureChapterDropRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.ChapterId == other.ChapterId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F41F RID: 62495 RVA: 0x0023A430 File Offset: 0x00238630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.ChapterId != 0)
			{
				num ^= this.ChapterId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F420 RID: 62496 RVA: 0x0023A488 File Offset: 0x00238688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F421 RID: 62497 RVA: 0x0023A495 File Offset: 0x00238695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F422 RID: 62498 RVA: 0x0023A4A0 File Offset: 0x002386A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChapterId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ChapterId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F423 RID: 62499 RVA: 0x0023A4FC File Offset: 0x002386FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.ChapterId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChapterId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F424 RID: 62500 RVA: 0x0023A554 File Offset: 0x00238754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewbieAdventureChapterDropRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.ChapterId != 0)
			{
				this.ChapterId = other.ChapterId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F425 RID: 62501 RVA: 0x0023A5A4 File Offset: 0x002387A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F426 RID: 62502 RVA: 0x0023A5B0 File Offset: 0x002387B0
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
				if (num != 64U)
				{
					if (num != 112U)
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
					this.ChapterId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006255 RID: 25173
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006256 RID: 25174
		public const int ActivityIdFieldNumber = 14;

		// Token: 0x04006257 RID: 25175
		private int activityId_;

		// Token: 0x04006258 RID: 25176
		public const int ChapterIdFieldNumber = 8;

		// Token: 0x04006259 RID: 25177
		private int chapterId_;
	}
}
