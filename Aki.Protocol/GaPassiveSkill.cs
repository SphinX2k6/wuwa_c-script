using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200069E RID: 1694
	public sealed class GaPassiveSkill : IMessage<GaPassiveSkill>, IMessage, IEquatable<GaPassiveSkill>, IDeepCloneable<GaPassiveSkill>, IBufferMessage
	{
		// Token: 0x06009BD2 RID: 39890 RVA: 0x0017B974 File Offset: 0x00179B74
		[NullableContext(1)]
		public static GaPassiveSkill Create()
		{
			return new GaPassiveSkill();
		}

		// Token: 0x17001F50 RID: 8016
		// (get) Token: 0x06009BD3 RID: 39891 RVA: 0x0017B97B File Offset: 0x00179B7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GaPassiveSkill> Parser
		{
			get
			{
				return GaPassiveSkill._parser;
			}
		}

		// Token: 0x17001F51 RID: 8017
		// (get) Token: 0x06009BD4 RID: 39892 RVA: 0x0017B982 File Offset: 0x00179B82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F52 RID: 8018
		// (get) Token: 0x06009BD5 RID: 39893 RVA: 0x0017B985 File Offset: 0x00179B85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GaPassiveSkill.Descriptor;
			}
		}

		// Token: 0x06009BD6 RID: 39894 RVA: 0x0017B98C File Offset: 0x00179B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GaPassiveSkill()
		{
		}

		// Token: 0x06009BD7 RID: 39895 RVA: 0x0017B994 File Offset: 0x00179B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GaPassiveSkill(GaPassiveSkill other) : this()
		{
			this.skillId_ = other.skillId_;
			this.contextId_ = other.contextId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009BD8 RID: 39896 RVA: 0x0017B9C5 File Offset: 0x00179BC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GaPassiveSkill Clone()
		{
			return new GaPassiveSkill(this);
		}

		// Token: 0x17001F53 RID: 8019
		// (get) Token: 0x06009BD9 RID: 39897 RVA: 0x0017B9CD File Offset: 0x00179BCD
		// (set) Token: 0x06009BDA RID: 39898 RVA: 0x0017B9D5 File Offset: 0x00179BD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x17001F54 RID: 8020
		// (get) Token: 0x06009BDB RID: 39899 RVA: 0x0017B9DE File Offset: 0x00179BDE
		// (set) Token: 0x06009BDC RID: 39900 RVA: 0x0017B9E6 File Offset: 0x00179BE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ContextId
		{
			get
			{
				return this.contextId_;
			}
			set
			{
				this.contextId_ = value;
			}
		}

		// Token: 0x06009BDD RID: 39901 RVA: 0x0017B9EF File Offset: 0x00179BEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GaPassiveSkill);
		}

		// Token: 0x06009BDE RID: 39902 RVA: 0x0017B9FD File Offset: 0x00179BFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GaPassiveSkill other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.ContextId == other.ContextId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009BDF RID: 39903 RVA: 0x0017BA3C File Offset: 0x00179C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillId != 0L)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.ContextId != 0L)
			{
				num ^= this.ContextId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009BE0 RID: 39904 RVA: 0x0017BA94 File Offset: 0x00179C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009BE1 RID: 39905 RVA: 0x0017BAA1 File Offset: 0x00179CA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009BE2 RID: 39906 RVA: 0x0017BAAC File Offset: 0x00179CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.SkillId);
			}
			if (this.ContextId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.ContextId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009BE3 RID: 39907 RVA: 0x0017BB04 File Offset: 0x00179D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SkillId);
			}
			if (this.ContextId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ContextId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009BE4 RID: 39908 RVA: 0x0017BB5C File Offset: 0x00179D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GaPassiveSkill other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillId != 0L)
			{
				this.SkillId = other.SkillId;
			}
			if (other.ContextId != 0L)
			{
				this.ContextId = other.ContextId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009BE5 RID: 39909 RVA: 0x0017BBAC File Offset: 0x00179DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009BE6 RID: 39910 RVA: 0x0017BBB8 File Offset: 0x00179DB8
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
						this.ContextId = input.ReadInt64();
					}
				}
				else
				{
					this.SkillId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040049E5 RID: 18917
		private static readonly MessageParser<GaPassiveSkill> _parser = new MessageParser<GaPassiveSkill>(() => new GaPassiveSkill());

		// Token: 0x040049E6 RID: 18918
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049E7 RID: 18919
		public const int SkillIdFieldNumber = 1;

		// Token: 0x040049E8 RID: 18920
		private long skillId_;

		// Token: 0x040049E9 RID: 18921
		public const int ContextIdFieldNumber = 2;

		// Token: 0x040049EA RID: 18922
		private long contextId_;
	}
}
