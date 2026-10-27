using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000530 RID: 1328
	public sealed class FavorQuest : IMessage<FavorQuest>, IMessage, IEquatable<FavorQuest>, IDeepCloneable<FavorQuest>, IBufferMessage
	{
		// Token: 0x06007C6E RID: 31854 RVA: 0x0012D757 File Offset: 0x0012B957
		[NullableContext(1)]
		public static FavorQuest Create()
		{
			return new FavorQuest();
		}

		// Token: 0x17001825 RID: 6181
		// (get) Token: 0x06007C6F RID: 31855 RVA: 0x0012D75E File Offset: 0x0012B95E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001826 RID: 6182
		// (get) Token: 0x06007C70 RID: 31856 RVA: 0x0012D761 File Offset: 0x0012B961
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FavorQuest.Descriptor;
			}
		}

		// Token: 0x06007C71 RID: 31857 RVA: 0x0012D768 File Offset: 0x0012B968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FavorQuest()
		{
		}

		// Token: 0x06007C72 RID: 31858 RVA: 0x0012D770 File Offset: 0x0012B970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FavorQuest(FavorQuest other) : this()
		{
			this.chapter_ = other.chapter_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007C73 RID: 31859 RVA: 0x0012D7A1 File Offset: 0x0012B9A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FavorQuest Clone()
		{
			return new FavorQuest(this);
		}

		// Token: 0x17001827 RID: 6183
		// (get) Token: 0x06007C74 RID: 31860 RVA: 0x0012D7A9 File Offset: 0x0012B9A9
		// (set) Token: 0x06007C75 RID: 31861 RVA: 0x0012D7B1 File Offset: 0x0012B9B1
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

		// Token: 0x17001828 RID: 6184
		// (get) Token: 0x06007C76 RID: 31862 RVA: 0x0012D7BA File Offset: 0x0012B9BA
		// (set) Token: 0x06007C77 RID: 31863 RVA: 0x0012D7C2 File Offset: 0x0012B9C2
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

		// Token: 0x06007C78 RID: 31864 RVA: 0x0012D7CB File Offset: 0x0012B9CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FavorQuest);
		}

		// Token: 0x06007C79 RID: 31865 RVA: 0x0012D7D9 File Offset: 0x0012B9D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FavorQuest other)
		{
			return other != null && (other == this || (this.Chapter == other.Chapter && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007C7A RID: 31866 RVA: 0x0012D818 File Offset: 0x0012BA18
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

		// Token: 0x06007C7B RID: 31867 RVA: 0x0012D876 File Offset: 0x0012BA76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007C7C RID: 31868 RVA: 0x0012D883 File Offset: 0x0012BA83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007C7D RID: 31869 RVA: 0x0012D88C File Offset: 0x0012BA8C
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

		// Token: 0x06007C7E RID: 31870 RVA: 0x0012D8E4 File Offset: 0x0012BAE4
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

		// Token: 0x06007C7F RID: 31871 RVA: 0x0012D93C File Offset: 0x0012BB3C
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

		// Token: 0x06007C80 RID: 31872 RVA: 0x0012D98C File Offset: 0x0012BB8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007C81 RID: 31873 RVA: 0x0012D998 File Offset: 0x0012BB98
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

		// Token: 0x04003F6E RID: 16238
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F6F RID: 16239
		public const int ChapterFieldNumber = 1;

		// Token: 0x04003F70 RID: 16240
		private int chapter_;

		// Token: 0x04003F71 RID: 16241
		public const int StatusFieldNumber = 2;

		// Token: 0x04003F72 RID: 16242
		private FavorQuestStatus status_;
	}
}
