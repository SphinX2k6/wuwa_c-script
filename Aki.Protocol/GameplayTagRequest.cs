using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006AE RID: 1710
	[NetMessage(EMessageId.GameplayTagRequest)]
	public sealed class GameplayTagRequest : IMessage<GameplayTagRequest>, IMessage, IEquatable<GameplayTagRequest>, IDeepCloneable<GameplayTagRequest>, IBufferMessage
	{
		// Token: 0x06009CE0 RID: 40160 RVA: 0x0017DBCF File Offset: 0x0017BDCF
		[NullableContext(1)]
		public static GameplayTagRequest Create()
		{
			return new GameplayTagRequest();
		}

		// Token: 0x17001F8E RID: 8078
		// (get) Token: 0x06009CE1 RID: 40161 RVA: 0x0017DBD6 File Offset: 0x0017BDD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F8F RID: 8079
		// (get) Token: 0x06009CE2 RID: 40162 RVA: 0x0017DBD9 File Offset: 0x0017BDD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameplayTagRequest.Descriptor;
			}
		}

		// Token: 0x06009CE3 RID: 40163 RVA: 0x0017DBE0 File Offset: 0x0017BDE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayTagRequest()
		{
		}

		// Token: 0x06009CE4 RID: 40164 RVA: 0x0017DBE8 File Offset: 0x0017BDE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayTagRequest(GameplayTagRequest other) : this()
		{
			this.tagId_ = other.tagId_;
			this.tagCount_ = other.tagCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009CE5 RID: 40165 RVA: 0x0017DC19 File Offset: 0x0017BE19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayTagRequest Clone()
		{
			return new GameplayTagRequest(this);
		}

		// Token: 0x17001F90 RID: 8080
		// (get) Token: 0x06009CE6 RID: 40166 RVA: 0x0017DC21 File Offset: 0x0017BE21
		// (set) Token: 0x06009CE7 RID: 40167 RVA: 0x0017DC29 File Offset: 0x0017BE29
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

		// Token: 0x17001F91 RID: 8081
		// (get) Token: 0x06009CE8 RID: 40168 RVA: 0x0017DC32 File Offset: 0x0017BE32
		// (set) Token: 0x06009CE9 RID: 40169 RVA: 0x0017DC3A File Offset: 0x0017BE3A
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

		// Token: 0x06009CEA RID: 40170 RVA: 0x0017DC43 File Offset: 0x0017BE43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameplayTagRequest);
		}

		// Token: 0x06009CEB RID: 40171 RVA: 0x0017DC51 File Offset: 0x0017BE51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GameplayTagRequest other)
		{
			return other != null && (other == this || (this.TagId == other.TagId && this.TagCount == other.TagCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009CEC RID: 40172 RVA: 0x0017DC90 File Offset: 0x0017BE90
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

		// Token: 0x06009CED RID: 40173 RVA: 0x0017DCE8 File Offset: 0x0017BEE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009CEE RID: 40174 RVA: 0x0017DCF5 File Offset: 0x0017BEF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009CEF RID: 40175 RVA: 0x0017DD00 File Offset: 0x0017BF00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TagCount != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.TagCount);
			}
			if (this.TagId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.TagId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009CF0 RID: 40176 RVA: 0x0017DD5C File Offset: 0x0017BF5C
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

		// Token: 0x06009CF1 RID: 40177 RVA: 0x0017DDB4 File Offset: 0x0017BFB4
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

		// Token: 0x06009CF2 RID: 40178 RVA: 0x0017DE04 File Offset: 0x0017C004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009CF3 RID: 40179 RVA: 0x0017DE10 File Offset: 0x0017C010
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
				if (num != 32U)
				{
					if (num != 96U)
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

		// Token: 0x040049E0 RID: 18912
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049E1 RID: 18913
		public const int TagIdFieldNumber = 12;

		// Token: 0x040049E2 RID: 18914
		private int tagId_;

		// Token: 0x040049E3 RID: 18915
		public const int TagCountFieldNumber = 4;

		// Token: 0x040049E4 RID: 18916
		private int tagCount_;
	}
}
