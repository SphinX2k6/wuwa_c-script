using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006AD RID: 1709
	[NetMessage(EMessageId.GameplayTagPush)]
	public sealed class GameplayTagPush : IMessage<GameplayTagPush>, IMessage, IEquatable<GameplayTagPush>, IDeepCloneable<GameplayTagPush>, IBufferMessage
	{
		// Token: 0x06009CCC RID: 40140 RVA: 0x0017D93C File Offset: 0x0017BB3C
		[NullableContext(1)]
		public static GameplayTagPush Create()
		{
			return new GameplayTagPush();
		}

		// Token: 0x17001F8A RID: 8074
		// (get) Token: 0x06009CCD RID: 40141 RVA: 0x0017D943 File Offset: 0x0017BB43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F8B RID: 8075
		// (get) Token: 0x06009CCE RID: 40142 RVA: 0x0017D946 File Offset: 0x0017BB46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameplayTagPush.Descriptor;
			}
		}

		// Token: 0x06009CCF RID: 40143 RVA: 0x0017D94D File Offset: 0x0017BB4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayTagPush()
		{
		}

		// Token: 0x06009CD0 RID: 40144 RVA: 0x0017D955 File Offset: 0x0017BB55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayTagPush(GameplayTagPush other) : this()
		{
			this.tagId_ = other.tagId_;
			this.tagCount_ = other.tagCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009CD1 RID: 40145 RVA: 0x0017D986 File Offset: 0x0017BB86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayTagPush Clone()
		{
			return new GameplayTagPush(this);
		}

		// Token: 0x17001F8C RID: 8076
		// (get) Token: 0x06009CD2 RID: 40146 RVA: 0x0017D98E File Offset: 0x0017BB8E
		// (set) Token: 0x06009CD3 RID: 40147 RVA: 0x0017D996 File Offset: 0x0017BB96
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

		// Token: 0x17001F8D RID: 8077
		// (get) Token: 0x06009CD4 RID: 40148 RVA: 0x0017D99F File Offset: 0x0017BB9F
		// (set) Token: 0x06009CD5 RID: 40149 RVA: 0x0017D9A7 File Offset: 0x0017BBA7
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

		// Token: 0x06009CD6 RID: 40150 RVA: 0x0017D9B0 File Offset: 0x0017BBB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameplayTagPush);
		}

		// Token: 0x06009CD7 RID: 40151 RVA: 0x0017D9BE File Offset: 0x0017BBBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GameplayTagPush other)
		{
			return other != null && (other == this || (this.TagId == other.TagId && this.TagCount == other.TagCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009CD8 RID: 40152 RVA: 0x0017D9FC File Offset: 0x0017BBFC
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

		// Token: 0x06009CD9 RID: 40153 RVA: 0x0017DA54 File Offset: 0x0017BC54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009CDA RID: 40154 RVA: 0x0017DA61 File Offset: 0x0017BC61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009CDB RID: 40155 RVA: 0x0017DA6C File Offset: 0x0017BC6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TagCount != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TagCount);
			}
			if (this.TagId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.TagId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009CDC RID: 40156 RVA: 0x0017DAC4 File Offset: 0x0017BCC4
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

		// Token: 0x06009CDD RID: 40157 RVA: 0x0017DB1C File Offset: 0x0017BD1C
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

		// Token: 0x06009CDE RID: 40158 RVA: 0x0017DB6C File Offset: 0x0017BD6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009CDF RID: 40159 RVA: 0x0017DB78 File Offset: 0x0017BD78
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
					if (num != 32U)
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

		// Token: 0x040049DB RID: 18907
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049DC RID: 18908
		public const int TagIdFieldNumber = 4;

		// Token: 0x040049DD RID: 18909
		private int tagId_;

		// Token: 0x040049DE RID: 18910
		public const int TagCountFieldNumber = 1;

		// Token: 0x040049DF RID: 18911
		private int tagCount_;
	}
}
