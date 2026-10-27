using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006AB RID: 1707
	public sealed class GameplayTagData : IMessage<GameplayTagData>, IMessage, IEquatable<GameplayTagData>, IDeepCloneable<GameplayTagData>, IBufferMessage
	{
		// Token: 0x06009CA2 RID: 40098 RVA: 0x0017D3DB File Offset: 0x0017B5DB
		[NullableContext(1)]
		public static GameplayTagData Create()
		{
			return new GameplayTagData();
		}

		// Token: 0x17001F81 RID: 8065
		// (get) Token: 0x06009CA3 RID: 40099 RVA: 0x0017D3E2 File Offset: 0x0017B5E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GameplayTagData> Parser
		{
			get
			{
				return GameplayTagData._parser;
			}
		}

		// Token: 0x17001F82 RID: 8066
		// (get) Token: 0x06009CA4 RID: 40100 RVA: 0x0017D3E9 File Offset: 0x0017B5E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F83 RID: 8067
		// (get) Token: 0x06009CA5 RID: 40101 RVA: 0x0017D3EC File Offset: 0x0017B5EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameplayTagData.Descriptor;
			}
		}

		// Token: 0x06009CA6 RID: 40102 RVA: 0x0017D3F3 File Offset: 0x0017B5F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayTagData()
		{
		}

		// Token: 0x06009CA7 RID: 40103 RVA: 0x0017D3FB File Offset: 0x0017B5FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayTagData(GameplayTagData other) : this()
		{
			this.id_ = other.id_;
			this.tagCount_ = other.tagCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009CA8 RID: 40104 RVA: 0x0017D42C File Offset: 0x0017B62C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayTagData Clone()
		{
			return new GameplayTagData(this);
		}

		// Token: 0x17001F84 RID: 8068
		// (get) Token: 0x06009CA9 RID: 40105 RVA: 0x0017D434 File Offset: 0x0017B634
		// (set) Token: 0x06009CAA RID: 40106 RVA: 0x0017D43C File Offset: 0x0017B63C
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

		// Token: 0x17001F85 RID: 8069
		// (get) Token: 0x06009CAB RID: 40107 RVA: 0x0017D445 File Offset: 0x0017B645
		// (set) Token: 0x06009CAC RID: 40108 RVA: 0x0017D44D File Offset: 0x0017B64D
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

		// Token: 0x06009CAD RID: 40109 RVA: 0x0017D456 File Offset: 0x0017B656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameplayTagData);
		}

		// Token: 0x06009CAE RID: 40110 RVA: 0x0017D464 File Offset: 0x0017B664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GameplayTagData other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.TagCount == other.TagCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009CAF RID: 40111 RVA: 0x0017D4A4 File Offset: 0x0017B6A4
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

		// Token: 0x06009CB0 RID: 40112 RVA: 0x0017D4FC File Offset: 0x0017B6FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009CB1 RID: 40113 RVA: 0x0017D509 File Offset: 0x0017B709
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009CB2 RID: 40114 RVA: 0x0017D514 File Offset: 0x0017B714
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

		// Token: 0x06009CB3 RID: 40115 RVA: 0x0017D56C File Offset: 0x0017B76C
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

		// Token: 0x06009CB4 RID: 40116 RVA: 0x0017D5C4 File Offset: 0x0017B7C4
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

		// Token: 0x06009CB5 RID: 40117 RVA: 0x0017D614 File Offset: 0x0017B814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009CB6 RID: 40118 RVA: 0x0017D620 File Offset: 0x0017B820
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

		// Token: 0x040049CF RID: 18895
		private static readonly MessageParser<GameplayTagData> _parser = new MessageParser<GameplayTagData>(() => new GameplayTagData());

		// Token: 0x040049D0 RID: 18896
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049D1 RID: 18897
		public const int IdFieldNumber = 1;

		// Token: 0x040049D2 RID: 18898
		private int id_;

		// Token: 0x040049D3 RID: 18899
		public const int TagCountFieldNumber = 2;

		// Token: 0x040049D4 RID: 18900
		private int tagCount_;
	}
}
