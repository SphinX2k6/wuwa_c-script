using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000697 RID: 1687
	public sealed class GameplayTagData : IMessage<GameplayTagData>, IMessage, IEquatable<GameplayTagData>, IDeepCloneable<GameplayTagData>, IBufferMessage
	{
		// Token: 0x06009B4C RID: 39756 RVA: 0x0017A9A4 File Offset: 0x00178BA4
		[NullableContext(1)]
		public static GameplayTagData Create()
		{
			return new GameplayTagData();
		}

		// Token: 0x17001F37 RID: 7991
		// (get) Token: 0x06009B4D RID: 39757 RVA: 0x0017A9AB File Offset: 0x00178BAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GameplayTagData> Parser
		{
			get
			{
				return GameplayTagData._parser;
			}
		}

		// Token: 0x17001F38 RID: 7992
		// (get) Token: 0x06009B4E RID: 39758 RVA: 0x0017A9B2 File Offset: 0x00178BB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F39 RID: 7993
		// (get) Token: 0x06009B4F RID: 39759 RVA: 0x0017A9B5 File Offset: 0x00178BB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameplayTagData.Descriptor;
			}
		}

		// Token: 0x06009B50 RID: 39760 RVA: 0x0017A9BC File Offset: 0x00178BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayTagData()
		{
		}

		// Token: 0x06009B51 RID: 39761 RVA: 0x0017A9C4 File Offset: 0x00178BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayTagData(GameplayTagData other) : this()
		{
			this.id_ = other.id_;
			this.tagCount_ = other.tagCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009B52 RID: 39762 RVA: 0x0017A9F5 File Offset: 0x00178BF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayTagData Clone()
		{
			return new GameplayTagData(this);
		}

		// Token: 0x17001F3A RID: 7994
		// (get) Token: 0x06009B53 RID: 39763 RVA: 0x0017A9FD File Offset: 0x00178BFD
		// (set) Token: 0x06009B54 RID: 39764 RVA: 0x0017AA05 File Offset: 0x00178C05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17001F3B RID: 7995
		// (get) Token: 0x06009B55 RID: 39765 RVA: 0x0017AA0E File Offset: 0x00178C0E
		// (set) Token: 0x06009B56 RID: 39766 RVA: 0x0017AA16 File Offset: 0x00178C16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TagCount
		{
			get
			{
				return this.tagCount_;
			}
			set
			{
				this.tagCount_ = value;
			}
		}

		// Token: 0x06009B57 RID: 39767 RVA: 0x0017AA1F File Offset: 0x00178C1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameplayTagData);
		}

		// Token: 0x06009B58 RID: 39768 RVA: 0x0017AA2D File Offset: 0x00178C2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GameplayTagData other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.TagCount == other.TagCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009B59 RID: 39769 RVA: 0x0017AA6C File Offset: 0x00178C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.TagCount != 0)
			{
				num ^= this.TagCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009B5A RID: 39770 RVA: 0x0017AAC4 File Offset: 0x00178CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009B5B RID: 39771 RVA: 0x0017AAD1 File Offset: 0x00178CD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009B5C RID: 39772 RVA: 0x0017AADC File Offset: 0x00178CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.TagCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TagCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009B5D RID: 39773 RVA: 0x0017AB34 File Offset: 0x00178D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.TagCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TagCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009B5E RID: 39774 RVA: 0x0017AB8C File Offset: 0x00178D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GameplayTagData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.TagCount != 0)
			{
				this.TagCount = other.TagCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009B5F RID: 39775 RVA: 0x0017ABDC File Offset: 0x00178DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009B60 RID: 39776 RVA: 0x0017ABE8 File Offset: 0x00178DE8
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
						this.TagCount = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040049C8 RID: 18888
		private static readonly MessageParser<GameplayTagData> _parser = new MessageParser<GameplayTagData>(() => new GameplayTagData());

		// Token: 0x040049C9 RID: 18889
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049CA RID: 18890
		public const int IdFieldNumber = 1;

		// Token: 0x040049CB RID: 18891
		private int id_;

		// Token: 0x040049CC RID: 18892
		public const int TagCountFieldNumber = 2;

		// Token: 0x040049CD RID: 18893
		private int tagCount_;
	}
}
