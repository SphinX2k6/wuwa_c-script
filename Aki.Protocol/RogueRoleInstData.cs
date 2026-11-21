using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001003 RID: 4099
	public sealed class RogueRoleInstData : IMessage<RogueRoleInstData>, IMessage, IEquatable<RogueRoleInstData>, IDeepCloneable<RogueRoleInstData>, IBufferMessage
	{
		// Token: 0x06015F20 RID: 89888 RVA: 0x003315DC File Offset: 0x0032F7DC
		[NullableContext(1)]
		public static RogueRoleInstData Create()
		{
			return new RogueRoleInstData();
		}

		// Token: 0x1700495F RID: 18783
		// (get) Token: 0x06015F21 RID: 89889 RVA: 0x003315E3 File Offset: 0x0032F7E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueRoleInstData> Parser
		{
			get
			{
				return RogueRoleInstData._parser;
			}
		}

		// Token: 0x17004960 RID: 18784
		// (get) Token: 0x06015F22 RID: 89890 RVA: 0x003315EA File Offset: 0x0032F7EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004961 RID: 18785
		// (get) Token: 0x06015F23 RID: 89891 RVA: 0x003315ED File Offset: 0x0032F7ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueRoleInstData.Descriptor;
			}
		}

		// Token: 0x06015F24 RID: 89892 RVA: 0x003315F4 File Offset: 0x0032F7F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueRoleInstData()
		{
		}

		// Token: 0x06015F25 RID: 89893 RVA: 0x003315FC File Offset: 0x0032F7FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueRoleInstData(RogueRoleInstData other) : this()
		{
			this.instId_ = other.instId_;
			this.isUnlock_ = other.isUnlock_;
			this.isFinish_ = other.isFinish_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015F26 RID: 89894 RVA: 0x00331639 File Offset: 0x0032F839
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueRoleInstData Clone()
		{
			return new RogueRoleInstData(this);
		}

		// Token: 0x17004962 RID: 18786
		// (get) Token: 0x06015F27 RID: 89895 RVA: 0x00331641 File Offset: 0x0032F841
		// (set) Token: 0x06015F28 RID: 89896 RVA: 0x00331649 File Offset: 0x0032F849
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x17004963 RID: 18787
		// (get) Token: 0x06015F29 RID: 89897 RVA: 0x00331652 File Offset: 0x0032F852
		// (set) Token: 0x06015F2A RID: 89898 RVA: 0x0033165A File Offset: 0x0032F85A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUnlock
		{
			get
			{
				return this.isUnlock_;
			}
			set
			{
				this.isUnlock_ = value;
			}
		}

		// Token: 0x17004964 RID: 18788
		// (get) Token: 0x06015F2B RID: 89899 RVA: 0x00331663 File Offset: 0x0032F863
		// (set) Token: 0x06015F2C RID: 89900 RVA: 0x0033166B File Offset: 0x0032F86B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFinish
		{
			get
			{
				return this.isFinish_;
			}
			set
			{
				this.isFinish_ = value;
			}
		}

		// Token: 0x06015F2D RID: 89901 RVA: 0x00331674 File Offset: 0x0032F874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueRoleInstData);
		}

		// Token: 0x06015F2E RID: 89902 RVA: 0x00331684 File Offset: 0x0032F884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueRoleInstData other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.IsUnlock == other.IsUnlock && this.IsFinish == other.IsFinish && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015F2F RID: 89903 RVA: 0x003316E0 File Offset: 0x0032F8E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.IsUnlock)
			{
				num ^= this.IsUnlock.GetHashCode();
			}
			if (this.IsFinish)
			{
				num ^= this.IsFinish.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015F30 RID: 89904 RVA: 0x00331751 File Offset: 0x0032F951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015F31 RID: 89905 RVA: 0x0033175E File Offset: 0x0032F95E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015F32 RID: 89906 RVA: 0x00331768 File Offset: 0x0032F968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.InstId);
			}
			if (this.IsUnlock)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsUnlock);
			}
			if (this.IsFinish)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsFinish);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015F33 RID: 89907 RVA: 0x003317DC File Offset: 0x0032F9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.IsUnlock)
			{
				num += 2;
			}
			if (this.IsFinish)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015F34 RID: 89908 RVA: 0x00331834 File Offset: 0x0032FA34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueRoleInstData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.IsUnlock)
			{
				this.IsUnlock = other.IsUnlock;
			}
			if (other.IsFinish)
			{
				this.IsFinish = other.IsFinish;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015F35 RID: 89909 RVA: 0x00331898 File Offset: 0x0032FA98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015F36 RID: 89910 RVA: 0x003318A4 File Offset: 0x0032FAA4
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsFinish = input.ReadBool();
						}
					}
					else
					{
						this.IsUnlock = input.ReadBool();
					}
				}
				else
				{
					this.InstId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400841F RID: 33823
		private static readonly MessageParser<RogueRoleInstData> _parser = new MessageParser<RogueRoleInstData>(() => new RogueRoleInstData());

		// Token: 0x04008420 RID: 33824
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008421 RID: 33825
		public const int InstIdFieldNumber = 1;

		// Token: 0x04008422 RID: 33826
		private int instId_;

		// Token: 0x04008423 RID: 33827
		public const int IsUnlockFieldNumber = 2;

		// Token: 0x04008424 RID: 33828
		private bool isUnlock_;

		// Token: 0x04008425 RID: 33829
		public const int IsFinishFieldNumber = 3;

		// Token: 0x04008426 RID: 33830
		private bool isFinish_;
	}
}
