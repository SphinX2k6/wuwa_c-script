using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200069A RID: 1690
	[NetMessage(EMessageId.GameplayTagRequest)]
	public sealed class GameplayTagRequest : IMessage<GameplayTagRequest>, IMessage, IEquatable<GameplayTagRequest>, IDeepCloneable<GameplayTagRequest>, IBufferMessage
	{
		// Token: 0x06009B8A RID: 39818 RVA: 0x0017B19C File Offset: 0x0017939C
		[NullableContext(1)]
		public static GameplayTagRequest Create()
		{
			return new GameplayTagRequest();
		}

		// Token: 0x17001F44 RID: 8004
		// (get) Token: 0x06009B8B RID: 39819 RVA: 0x0017B1A3 File Offset: 0x001793A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F45 RID: 8005
		// (get) Token: 0x06009B8C RID: 39820 RVA: 0x0017B1A6 File Offset: 0x001793A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameplayTagRequest.Descriptor;
			}
		}

		// Token: 0x06009B8D RID: 39821 RVA: 0x0017B1AD File Offset: 0x001793AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayTagRequest()
		{
		}

		// Token: 0x06009B8E RID: 39822 RVA: 0x0017B1B5 File Offset: 0x001793B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayTagRequest(GameplayTagRequest other) : this()
		{
			this.tagId_ = other.tagId_;
			this.tagCount_ = other.tagCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009B8F RID: 39823 RVA: 0x0017B1E6 File Offset: 0x001793E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayTagRequest Clone()
		{
			return new GameplayTagRequest(this);
		}

		// Token: 0x17001F46 RID: 8006
		// (get) Token: 0x06009B90 RID: 39824 RVA: 0x0017B1EE File Offset: 0x001793EE
		// (set) Token: 0x06009B91 RID: 39825 RVA: 0x0017B1F6 File Offset: 0x001793F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TagId
		{
			get
			{
				return this.tagId_;
			}
			set
			{
				this.tagId_ = value;
			}
		}

		// Token: 0x17001F47 RID: 8007
		// (get) Token: 0x06009B92 RID: 39826 RVA: 0x0017B1FF File Offset: 0x001793FF
		// (set) Token: 0x06009B93 RID: 39827 RVA: 0x0017B207 File Offset: 0x00179407
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

		// Token: 0x06009B94 RID: 39828 RVA: 0x0017B210 File Offset: 0x00179410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameplayTagRequest);
		}

		// Token: 0x06009B95 RID: 39829 RVA: 0x0017B21E File Offset: 0x0017941E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GameplayTagRequest other)
		{
			return other != null && (other == this || (this.TagId == other.TagId && this.TagCount == other.TagCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009B96 RID: 39830 RVA: 0x0017B25C File Offset: 0x0017945C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TagId != 0)
			{
				num ^= this.TagId.GetHashCode();
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

		// Token: 0x06009B97 RID: 39831 RVA: 0x0017B2B4 File Offset: 0x001794B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009B98 RID: 39832 RVA: 0x0017B2C1 File Offset: 0x001794C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009B99 RID: 39833 RVA: 0x0017B2CC File Offset: 0x001794CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TagId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.TagId);
			}
			if (this.TagCount != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.TagCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009B9A RID: 39834 RVA: 0x0017B328 File Offset: 0x00179528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TagId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TagId);
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

		// Token: 0x06009B9B RID: 39835 RVA: 0x0017B380 File Offset: 0x00179580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GameplayTagRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TagId != 0)
			{
				this.TagId = other.TagId;
			}
			if (other.TagCount != 0)
			{
				this.TagCount = other.TagCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009B9C RID: 39836 RVA: 0x0017B3D0 File Offset: 0x001795D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009B9D RID: 39837 RVA: 0x0017B3DC File Offset: 0x001795DC
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
					if (num != 80U)
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
					this.TagId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040049D9 RID: 18905
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049DA RID: 18906
		public const int TagIdFieldNumber = 8;

		// Token: 0x040049DB RID: 18907
		private int tagId_;

		// Token: 0x040049DC RID: 18908
		public const int TagCountFieldNumber = 10;

		// Token: 0x040049DD RID: 18909
		private int tagCount_;
	}
}
