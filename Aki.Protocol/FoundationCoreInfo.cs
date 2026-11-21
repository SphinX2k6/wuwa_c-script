using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000623 RID: 1571
	public sealed class FoundationCoreInfo : IMessage<FoundationCoreInfo>, IMessage, IEquatable<FoundationCoreInfo>, IDeepCloneable<FoundationCoreInfo>, IBufferMessage
	{
		// Token: 0x06009143 RID: 37187 RVA: 0x0015FF8C File Offset: 0x0015E18C
		[NullableContext(1)]
		public static FoundationCoreInfo Create()
		{
			return new FoundationCoreInfo();
		}

		// Token: 0x17001CE0 RID: 7392
		// (get) Token: 0x06009144 RID: 37188 RVA: 0x0015FF93 File Offset: 0x0015E193
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001CE1 RID: 7393
		// (get) Token: 0x06009145 RID: 37189 RVA: 0x0015FF96 File Offset: 0x0015E196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FoundationCoreInfo.Descriptor;
			}
		}

		// Token: 0x06009146 RID: 37190 RVA: 0x0015FF9D File Offset: 0x0015E19D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationCoreInfo()
		{
		}

		// Token: 0x06009147 RID: 37191 RVA: 0x0015FFBC File Offset: 0x0015E1BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationCoreInfo(FoundationCoreInfo other) : this()
		{
			this.sourceEntityId_ = other.sourceEntityId_;
			this.elementalBoxId_ = other.elementalBoxId_;
			this.state_ = other.state_;
			this.elementalType_ = other.elementalType_;
			this.priority_ = other.priority_;
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009148 RID: 37192 RVA: 0x00160028 File Offset: 0x0015E228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationCoreInfo Clone()
		{
			return new FoundationCoreInfo(this);
		}

		// Token: 0x17001CE2 RID: 7394
		// (get) Token: 0x06009149 RID: 37193 RVA: 0x00160030 File Offset: 0x0015E230
		// (set) Token: 0x0600914A RID: 37194 RVA: 0x00160038 File Offset: 0x0015E238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SourceEntityId
		{
			get
			{
				return this.sourceEntityId_;
			}
			set
			{
				this.sourceEntityId_ = value;
			}
		}

		// Token: 0x17001CE3 RID: 7395
		// (get) Token: 0x0600914B RID: 37195 RVA: 0x00160041 File Offset: 0x0015E241
		// (set) Token: 0x0600914C RID: 37196 RVA: 0x00160049 File Offset: 0x0015E249
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ElementalBoxId
		{
			get
			{
				return this.elementalBoxId_;
			}
			set
			{
				this.elementalBoxId_ = value;
			}
		}

		// Token: 0x17001CE4 RID: 7396
		// (get) Token: 0x0600914D RID: 37197 RVA: 0x00160052 File Offset: 0x0015E252
		// (set) Token: 0x0600914E RID: 37198 RVA: 0x0016005A File Offset: 0x0015E25A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001CE5 RID: 7397
		// (get) Token: 0x0600914F RID: 37199 RVA: 0x0016006D File Offset: 0x0015E26D
		// (set) Token: 0x06009150 RID: 37200 RVA: 0x00160075 File Offset: 0x0015E275
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ElementalType
		{
			get
			{
				return this.elementalType_;
			}
			set
			{
				this.elementalType_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001CE6 RID: 7398
		// (get) Token: 0x06009151 RID: 37201 RVA: 0x00160088 File Offset: 0x0015E288
		// (set) Token: 0x06009152 RID: 37202 RVA: 0x00160090 File Offset: 0x0015E290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Priority
		{
			get
			{
				return this.priority_;
			}
			set
			{
				this.priority_ = value;
			}
		}

		// Token: 0x17001CE7 RID: 7399
		// (get) Token: 0x06009153 RID: 37203 RVA: 0x00160099 File Offset: 0x0015E299
		// (set) Token: 0x06009154 RID: 37204 RVA: 0x001600A1 File Offset: 0x0015E2A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x06009155 RID: 37205 RVA: 0x001600AA File Offset: 0x0015E2AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FoundationCoreInfo);
		}

		// Token: 0x06009156 RID: 37206 RVA: 0x001600B8 File Offset: 0x0015E2B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FoundationCoreInfo other)
		{
			return other != null && (other == this || (this.SourceEntityId == other.SourceEntityId && this.ElementalBoxId == other.ElementalBoxId && !(this.State != other.State) && !(this.ElementalType != other.ElementalType) && this.Priority == other.Priority && this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009157 RID: 37207 RVA: 0x0016014C File Offset: 0x0015E34C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SourceEntityId != 0)
			{
				num ^= this.SourceEntityId.GetHashCode();
			}
			if (this.ElementalBoxId != 0)
			{
				num ^= this.ElementalBoxId.GetHashCode();
			}
			if (this.State.Length != 0)
			{
				num ^= this.State.GetHashCode();
			}
			if (this.ElementalType.Length != 0)
			{
				num ^= this.ElementalType.GetHashCode();
			}
			if (this.Priority != 0)
			{
				num ^= this.Priority.GetHashCode();
			}
			if (this.EntityId != 0)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009158 RID: 37208 RVA: 0x0016020C File Offset: 0x0015E40C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009159 RID: 37209 RVA: 0x00160219 File Offset: 0x0015E419
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600915A RID: 37210 RVA: 0x00160224 File Offset: 0x0015E424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SourceEntityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SourceEntityId);
			}
			if (this.ElementalBoxId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ElementalBoxId);
			}
			if (this.State.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.State);
			}
			if (this.ElementalType.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.ElementalType);
			}
			if (this.Priority != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Priority);
			}
			if (this.EntityId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600915B RID: 37211 RVA: 0x001602F8 File Offset: 0x0015E4F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SourceEntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SourceEntityId);
			}
			if (this.ElementalBoxId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ElementalBoxId);
			}
			if (this.State.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.State);
			}
			if (this.ElementalType.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ElementalType);
			}
			if (this.Priority != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Priority);
			}
			if (this.EntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600915C RID: 37212 RVA: 0x001603B8 File Offset: 0x0015E5B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FoundationCoreInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SourceEntityId != 0)
			{
				this.SourceEntityId = other.SourceEntityId;
			}
			if (other.ElementalBoxId != 0)
			{
				this.ElementalBoxId = other.ElementalBoxId;
			}
			if (other.State.Length != 0)
			{
				this.State = other.State;
			}
			if (other.ElementalType.Length != 0)
			{
				this.ElementalType = other.ElementalType;
			}
			if (other.Priority != 0)
			{
				this.Priority = other.Priority;
			}
			if (other.EntityId != 0)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600915D RID: 37213 RVA: 0x00160462 File Offset: 0x0015E662
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600915E RID: 37214 RVA: 0x0016046C File Offset: 0x0015E66C
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
				if (num <= 26U)
				{
					if (num == 8U)
					{
						this.SourceEntityId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.ElementalBoxId = input.ReadInt32();
						continue;
					}
					if (num == 26U)
					{
						this.State = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 34U)
					{
						this.ElementalType = input.ReadString();
						continue;
					}
					if (num == 40U)
					{
						this.Priority = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.EntityId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400469C RID: 18076
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400469D RID: 18077
		public const int SourceEntityIdFieldNumber = 1;

		// Token: 0x0400469E RID: 18078
		private int sourceEntityId_;

		// Token: 0x0400469F RID: 18079
		public const int ElementalBoxIdFieldNumber = 2;

		// Token: 0x040046A0 RID: 18080
		private int elementalBoxId_;

		// Token: 0x040046A1 RID: 18081
		public const int StateFieldNumber = 3;

		// Token: 0x040046A2 RID: 18082
		private string state_ = "";

		// Token: 0x040046A3 RID: 18083
		public const int ElementalTypeFieldNumber = 4;

		// Token: 0x040046A4 RID: 18084
		private string elementalType_ = "";

		// Token: 0x040046A5 RID: 18085
		public const int PriorityFieldNumber = 5;

		// Token: 0x040046A6 RID: 18086
		private int priority_;

		// Token: 0x040046A7 RID: 18087
		public const int EntityIdFieldNumber = 6;

		// Token: 0x040046A8 RID: 18088
		private int entityId_;
	}
}
