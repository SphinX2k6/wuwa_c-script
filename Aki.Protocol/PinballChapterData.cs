using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D32 RID: 3378
	public sealed class PinballChapterData : IMessage<PinballChapterData>, IMessage, IEquatable<PinballChapterData>, IDeepCloneable<PinballChapterData>, IBufferMessage
	{
		// Token: 0x06012404 RID: 74756 RVA: 0x002AA695 File Offset: 0x002A8895
		[NullableContext(1)]
		public static PinballChapterData Create()
		{
			return new PinballChapterData();
		}

		// Token: 0x17003C77 RID: 15479
		// (get) Token: 0x06012405 RID: 74757 RVA: 0x002AA69C File Offset: 0x002A889C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PinballChapterData> Parser
		{
			get
			{
				return PinballChapterData._parser;
			}
		}

		// Token: 0x17003C78 RID: 15480
		// (get) Token: 0x06012406 RID: 74758 RVA: 0x002AA6A3 File Offset: 0x002A88A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C79 RID: 15481
		// (get) Token: 0x06012407 RID: 74759 RVA: 0x002AA6A6 File Offset: 0x002A88A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballChapterData.Descriptor;
			}
		}

		// Token: 0x06012408 RID: 74760 RVA: 0x002AA6AD File Offset: 0x002A88AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballChapterData()
		{
		}

		// Token: 0x06012409 RID: 74761 RVA: 0x002AA6B5 File Offset: 0x002A88B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballChapterData(PinballChapterData other) : this()
		{
			this.chapterId_ = other.chapterId_;
			this.unLockTime_ = other.unLockTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601240A RID: 74762 RVA: 0x002AA6E6 File Offset: 0x002A88E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballChapterData Clone()
		{
			return new PinballChapterData(this);
		}

		// Token: 0x17003C7A RID: 15482
		// (get) Token: 0x0601240B RID: 74763 RVA: 0x002AA6EE File Offset: 0x002A88EE
		// (set) Token: 0x0601240C RID: 74764 RVA: 0x002AA6F6 File Offset: 0x002A88F6
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

		// Token: 0x17003C7B RID: 15483
		// (get) Token: 0x0601240D RID: 74765 RVA: 0x002AA6FF File Offset: 0x002A88FF
		// (set) Token: 0x0601240E RID: 74766 RVA: 0x002AA707 File Offset: 0x002A8907
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long UnLockTime
		{
			get
			{
				return this.unLockTime_;
			}
			set
			{
				this.unLockTime_ = value;
			}
		}

		// Token: 0x0601240F RID: 74767 RVA: 0x002AA710 File Offset: 0x002A8910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballChapterData);
		}

		// Token: 0x06012410 RID: 74768 RVA: 0x002AA71E File Offset: 0x002A891E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballChapterData other)
		{
			return other != null && (other == this || (this.ChapterId == other.ChapterId && this.UnLockTime == other.UnLockTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012411 RID: 74769 RVA: 0x002AA75C File Offset: 0x002A895C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChapterId != 0)
			{
				num ^= this.ChapterId.GetHashCode();
			}
			if (this.UnLockTime != 0L)
			{
				num ^= this.UnLockTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012412 RID: 74770 RVA: 0x002AA7B4 File Offset: 0x002A89B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012413 RID: 74771 RVA: 0x002AA7C1 File Offset: 0x002A89C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012414 RID: 74772 RVA: 0x002AA7CC File Offset: 0x002A89CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChapterId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ChapterId);
			}
			if (this.UnLockTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.UnLockTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012415 RID: 74773 RVA: 0x002AA824 File Offset: 0x002A8A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChapterId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChapterId);
			}
			if (this.UnLockTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UnLockTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012416 RID: 74774 RVA: 0x002AA87C File Offset: 0x002A8A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballChapterData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChapterId != 0)
			{
				this.ChapterId = other.ChapterId;
			}
			if (other.UnLockTime != 0L)
			{
				this.UnLockTime = other.UnLockTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012417 RID: 74775 RVA: 0x002AA8CC File Offset: 0x002A8ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012418 RID: 74776 RVA: 0x002AA8D8 File Offset: 0x002A8AD8
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.UnLockTime = input.ReadInt64();
					}
				}
				else
				{
					this.ChapterId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400723D RID: 29245
		private static readonly MessageParser<PinballChapterData> _parser = new MessageParser<PinballChapterData>(() => new PinballChapterData());

		// Token: 0x0400723E RID: 29246
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400723F RID: 29247
		public const int ChapterIdFieldNumber = 1;

		// Token: 0x04007240 RID: 29248
		private int chapterId_;

		// Token: 0x04007241 RID: 29249
		public const int UnLockTimeFieldNumber = 2;

		// Token: 0x04007242 RID: 29250
		private long unLockTime_;
	}
}
