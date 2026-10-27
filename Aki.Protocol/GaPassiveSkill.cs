using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006B2 RID: 1714
	public sealed class GaPassiveSkill : IMessage<GaPassiveSkill>, IMessage, IEquatable<GaPassiveSkill>, IDeepCloneable<GaPassiveSkill>, IBufferMessage
	{
		// Token: 0x06009D28 RID: 40232 RVA: 0x0017E3A4 File Offset: 0x0017C5A4
		[NullableContext(1)]
		public static GaPassiveSkill Create()
		{
			return new GaPassiveSkill();
		}

		// Token: 0x17001F9A RID: 8090
		// (get) Token: 0x06009D29 RID: 40233 RVA: 0x0017E3AB File Offset: 0x0017C5AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GaPassiveSkill> Parser
		{
			get
			{
				return GaPassiveSkill._parser;
			}
		}

		// Token: 0x17001F9B RID: 8091
		// (get) Token: 0x06009D2A RID: 40234 RVA: 0x0017E3B2 File Offset: 0x0017C5B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F9C RID: 8092
		// (get) Token: 0x06009D2B RID: 40235 RVA: 0x0017E3B5 File Offset: 0x0017C5B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GaPassiveSkill.Descriptor;
			}
		}

		// Token: 0x06009D2C RID: 40236 RVA: 0x0017E3BC File Offset: 0x0017C5BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GaPassiveSkill()
		{
		}

		// Token: 0x06009D2D RID: 40237 RVA: 0x0017E3C4 File Offset: 0x0017C5C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GaPassiveSkill(GaPassiveSkill other) : this()
		{
			this.skillId_ = other.skillId_;
			this.contextId_ = other.contextId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009D2E RID: 40238 RVA: 0x0017E3F5 File Offset: 0x0017C5F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GaPassiveSkill Clone()
		{
			return new GaPassiveSkill(this);
		}

		// Token: 0x17001F9D RID: 8093
		// (get) Token: 0x06009D2F RID: 40239 RVA: 0x0017E3FD File Offset: 0x0017C5FD
		// (set) Token: 0x06009D30 RID: 40240 RVA: 0x0017E405 File Offset: 0x0017C605
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

		// Token: 0x17001F9E RID: 8094
		// (get) Token: 0x06009D31 RID: 40241 RVA: 0x0017E40E File Offset: 0x0017C60E
		// (set) Token: 0x06009D32 RID: 40242 RVA: 0x0017E416 File Offset: 0x0017C616
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

		// Token: 0x06009D33 RID: 40243 RVA: 0x0017E41F File Offset: 0x0017C61F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GaPassiveSkill);
		}

		// Token: 0x06009D34 RID: 40244 RVA: 0x0017E42D File Offset: 0x0017C62D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GaPassiveSkill other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.ContextId == other.ContextId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009D35 RID: 40245 RVA: 0x0017E46C File Offset: 0x0017C66C
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

		// Token: 0x06009D36 RID: 40246 RVA: 0x0017E4C4 File Offset: 0x0017C6C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009D37 RID: 40247 RVA: 0x0017E4D1 File Offset: 0x0017C6D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009D38 RID: 40248 RVA: 0x0017E4DC File Offset: 0x0017C6DC
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

		// Token: 0x06009D39 RID: 40249 RVA: 0x0017E534 File Offset: 0x0017C734
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

		// Token: 0x06009D3A RID: 40250 RVA: 0x0017E58C File Offset: 0x0017C78C
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

		// Token: 0x06009D3B RID: 40251 RVA: 0x0017E5DC File Offset: 0x0017C7DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009D3C RID: 40252 RVA: 0x0017E5E8 File Offset: 0x0017C7E8
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

		// Token: 0x040049EC RID: 18924
		private static readonly MessageParser<GaPassiveSkill> _parser = new MessageParser<GaPassiveSkill>(() => new GaPassiveSkill());

		// Token: 0x040049ED RID: 18925
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049EE RID: 18926
		public const int SkillIdFieldNumber = 1;

		// Token: 0x040049EF RID: 18927
		private long skillId_;

		// Token: 0x040049F0 RID: 18928
		public const int ContextIdFieldNumber = 2;

		// Token: 0x040049F1 RID: 18929
		private long contextId_;
	}
}
