using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000699 RID: 1689
	[NetMessage(EMessageId.GameplayTagPush)]
	public sealed class GameplayTagPush : IMessage<GameplayTagPush>, IMessage, IEquatable<GameplayTagPush>, IDeepCloneable<GameplayTagPush>, IBufferMessage
	{
		// Token: 0x06009B76 RID: 39798 RVA: 0x0017AF04 File Offset: 0x00179104
		[NullableContext(1)]
		public static GameplayTagPush Create()
		{
			return new GameplayTagPush();
		}

		// Token: 0x17001F40 RID: 8000
		// (get) Token: 0x06009B77 RID: 39799 RVA: 0x0017AF0B File Offset: 0x0017910B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F41 RID: 8001
		// (get) Token: 0x06009B78 RID: 39800 RVA: 0x0017AF0E File Offset: 0x0017910E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameplayTagPush.Descriptor;
			}
		}

		// Token: 0x06009B79 RID: 39801 RVA: 0x0017AF15 File Offset: 0x00179115
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayTagPush()
		{
		}

		// Token: 0x06009B7A RID: 39802 RVA: 0x0017AF1D File Offset: 0x0017911D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayTagPush(GameplayTagPush other) : this()
		{
			this.tagId_ = other.tagId_;
			this.tagCount_ = other.tagCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009B7B RID: 39803 RVA: 0x0017AF4E File Offset: 0x0017914E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayTagPush Clone()
		{
			return new GameplayTagPush(this);
		}

		// Token: 0x17001F42 RID: 8002
		// (get) Token: 0x06009B7C RID: 39804 RVA: 0x0017AF56 File Offset: 0x00179156
		// (set) Token: 0x06009B7D RID: 39805 RVA: 0x0017AF5E File Offset: 0x0017915E
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

		// Token: 0x17001F43 RID: 8003
		// (get) Token: 0x06009B7E RID: 39806 RVA: 0x0017AF67 File Offset: 0x00179167
		// (set) Token: 0x06009B7F RID: 39807 RVA: 0x0017AF6F File Offset: 0x0017916F
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

		// Token: 0x06009B80 RID: 39808 RVA: 0x0017AF78 File Offset: 0x00179178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameplayTagPush);
		}

		// Token: 0x06009B81 RID: 39809 RVA: 0x0017AF86 File Offset: 0x00179186
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GameplayTagPush other)
		{
			return other != null && (other == this || (this.TagId == other.TagId && this.TagCount == other.TagCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009B82 RID: 39810 RVA: 0x0017AFC4 File Offset: 0x001791C4
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

		// Token: 0x06009B83 RID: 39811 RVA: 0x0017B01C File Offset: 0x0017921C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009B84 RID: 39812 RVA: 0x0017B029 File Offset: 0x00179229
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009B85 RID: 39813 RVA: 0x0017B034 File Offset: 0x00179234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TagCount != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TagCount);
			}
			if (this.TagId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.TagId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009B86 RID: 39814 RVA: 0x0017B090 File Offset: 0x00179290
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

		// Token: 0x06009B87 RID: 39815 RVA: 0x0017B0E8 File Offset: 0x001792E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GameplayTagPush other)
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

		// Token: 0x06009B88 RID: 39816 RVA: 0x0017B138 File Offset: 0x00179338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009B89 RID: 39817 RVA: 0x0017B144 File Offset: 0x00179344
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
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TagId = input.ReadInt32();
					}
				}
				else
				{
					this.TagCount = input.ReadInt32();
				}
			}
		}

		// Token: 0x040049D4 RID: 18900
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049D5 RID: 18901
		public const int TagIdFieldNumber = 11;

		// Token: 0x040049D6 RID: 18902
		private int tagId_;

		// Token: 0x040049D7 RID: 18903
		public const int TagCountFieldNumber = 3;

		// Token: 0x040049D8 RID: 18904
		private int tagCount_;
	}
}
