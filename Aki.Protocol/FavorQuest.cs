using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200051B RID: 1307
	public sealed class FavorQuest : IMessage<FavorQuest>, IMessage, IEquatable<FavorQuest>, IDeepCloneable<FavorQuest>, IBufferMessage
	{
		// Token: 0x06007B06 RID: 31494 RVA: 0x0012AB53 File Offset: 0x00128D53
		[NullableContext(1)]
		public static FavorQuest Create()
		{
			return new FavorQuest();
		}

		// Token: 0x170017D8 RID: 6104
		// (get) Token: 0x06007B07 RID: 31495 RVA: 0x0012AB5A File Offset: 0x00128D5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017D9 RID: 6105
		// (get) Token: 0x06007B08 RID: 31496 RVA: 0x0012AB5D File Offset: 0x00128D5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FavorQuest.Descriptor;
			}
		}

		// Token: 0x06007B09 RID: 31497 RVA: 0x0012AB64 File Offset: 0x00128D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FavorQuest()
		{
		}

		// Token: 0x06007B0A RID: 31498 RVA: 0x0012AB6C File Offset: 0x00128D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FavorQuest(FavorQuest other) : this()
		{
			this.chapter_ = other.chapter_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007B0B RID: 31499 RVA: 0x0012AB9D File Offset: 0x00128D9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FavorQuest Clone()
		{
			return new FavorQuest(this);
		}

		// Token: 0x170017DA RID: 6106
		// (get) Token: 0x06007B0C RID: 31500 RVA: 0x0012ABA5 File Offset: 0x00128DA5
		// (set) Token: 0x06007B0D RID: 31501 RVA: 0x0012ABAD File Offset: 0x00128DAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Chapter
		{
			get
			{
				return this.chapter_;
			}
			set
			{
				this.chapter_ = value;
			}
		}

		// Token: 0x170017DB RID: 6107
		// (get) Token: 0x06007B0E RID: 31502 RVA: 0x0012ABB6 File Offset: 0x00128DB6
		// (set) Token: 0x06007B0F RID: 31503 RVA: 0x0012ABBE File Offset: 0x00128DBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FavorQuestStatus Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x06007B10 RID: 31504 RVA: 0x0012ABC7 File Offset: 0x00128DC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FavorQuest);
		}

		// Token: 0x06007B11 RID: 31505 RVA: 0x0012ABD5 File Offset: 0x00128DD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FavorQuest other)
		{
			return other != null && (other == this || (this.Chapter == other.Chapter && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007B12 RID: 31506 RVA: 0x0012AC14 File Offset: 0x00128E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Chapter != 0)
			{
				num ^= this.Chapter.GetHashCode();
			}
			if (this.Status != FavorQuestStatus.Locked)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007B13 RID: 31507 RVA: 0x0012AC72 File Offset: 0x00128E72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007B14 RID: 31508 RVA: 0x0012AC7F File Offset: 0x00128E7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007B15 RID: 31509 RVA: 0x0012AC88 File Offset: 0x00128E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Chapter != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Chapter);
			}
			if (this.Status != FavorQuestStatus.Locked)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007B16 RID: 31510 RVA: 0x0012ACE0 File Offset: 0x00128EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Chapter != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Chapter);
			}
			if (this.Status != FavorQuestStatus.Locked)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007B17 RID: 31511 RVA: 0x0012AD38 File Offset: 0x00128F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FavorQuest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Chapter != 0)
			{
				this.Chapter = other.Chapter;
			}
			if (other.Status != FavorQuestStatus.Locked)
			{
				this.Status = other.Status;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007B18 RID: 31512 RVA: 0x0012AD88 File Offset: 0x00128F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007B19 RID: 31513 RVA: 0x0012AD94 File Offset: 0x00128F94
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
						this.Status = (FavorQuestStatus)input.ReadEnum();
					}
				}
				else
				{
					this.Chapter = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003F64 RID: 16228
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F65 RID: 16229
		public const int ChapterFieldNumber = 1;

		// Token: 0x04003F66 RID: 16230
		private int chapter_;

		// Token: 0x04003F67 RID: 16231
		public const int StatusFieldNumber = 2;

		// Token: 0x04003F68 RID: 16232
		private FavorQuestStatus status_;
	}
}
