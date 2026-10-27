using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x020016AE RID: 5806
	public sealed class AiHateEntity : IMessage<AiHateEntity>, IMessage, IEquatable<AiHateEntity>, IDeepCloneable<AiHateEntity>, IBufferMessage
	{
		// Token: 0x0601D173 RID: 119155 RVA: 0x00441BC1 File Offset: 0x0043FDC1
		[NullableContext(1)]
		public static AiHateEntity Create()
		{
			return new AiHateEntity();
		}

		// Token: 0x170062B2 RID: 25266
		// (get) Token: 0x0601D174 RID: 119156 RVA: 0x00441BC8 File Offset: 0x0043FDC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AiHateEntity> Parser
		{
			get
			{
				return AiHateEntity._parser;
			}
		}

		// Token: 0x170062B3 RID: 25267
		// (get) Token: 0x0601D175 RID: 119157 RVA: 0x00441BCF File Offset: 0x0043FDCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170062B4 RID: 25268
		// (get) Token: 0x0601D176 RID: 119158 RVA: 0x00441BD2 File Offset: 0x0043FDD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AiHateEntity.Descriptor;
			}
		}

		// Token: 0x0601D177 RID: 119159 RVA: 0x00441BD9 File Offset: 0x0043FDD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiHateEntity()
		{
		}

		// Token: 0x0601D178 RID: 119160 RVA: 0x00441BE1 File Offset: 0x0043FDE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiHateEntity(AiHateEntity other) : this()
		{
			this.entityId_ = other.entityId_;
			this.hatredValue_ = other.hatredValue_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D179 RID: 119161 RVA: 0x00441C12 File Offset: 0x0043FE12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiHateEntity Clone()
		{
			return new AiHateEntity(this);
		}

		// Token: 0x170062B5 RID: 25269
		// (get) Token: 0x0601D17A RID: 119162 RVA: 0x00441C1A File Offset: 0x0043FE1A
		// (set) Token: 0x0601D17B RID: 119163 RVA: 0x00441C22 File Offset: 0x0043FE22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
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

		// Token: 0x170062B6 RID: 25270
		// (get) Token: 0x0601D17C RID: 119164 RVA: 0x00441C2B File Offset: 0x0043FE2B
		// (set) Token: 0x0601D17D RID: 119165 RVA: 0x00441C33 File Offset: 0x0043FE33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HatredValue
		{
			get
			{
				return this.hatredValue_;
			}
			set
			{
				this.hatredValue_ = value;
			}
		}

		// Token: 0x0601D17E RID: 119166 RVA: 0x00441C3C File Offset: 0x0043FE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AiHateEntity);
		}

		// Token: 0x0601D17F RID: 119167 RVA: 0x00441C4A File Offset: 0x0043FE4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AiHateEntity other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.HatredValue == other.HatredValue && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D180 RID: 119168 RVA: 0x00441C88 File Offset: 0x0043FE88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.HatredValue != 0)
			{
				num ^= this.HatredValue.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D181 RID: 119169 RVA: 0x00441CE0 File Offset: 0x0043FEE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D182 RID: 119170 RVA: 0x00441CED File Offset: 0x0043FEED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D183 RID: 119171 RVA: 0x00441CF8 File Offset: 0x0043FEF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this.HatredValue != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.HatredValue);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D184 RID: 119172 RVA: 0x00441D50 File Offset: 0x0043FF50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.HatredValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HatredValue);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D185 RID: 119173 RVA: 0x00441DA8 File Offset: 0x0043FFA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AiHateEntity other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.HatredValue != 0)
			{
				this.HatredValue = other.HatredValue;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D186 RID: 119174 RVA: 0x00441DF8 File Offset: 0x0043FFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D187 RID: 119175 RVA: 0x00441E04 File Offset: 0x00440004
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
						this.HatredValue = input.ReadInt32();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400C43A RID: 50234
		private static readonly MessageParser<AiHateEntity> _parser = new MessageParser<AiHateEntity>(() => new AiHateEntity());

		// Token: 0x0400C43B RID: 50235
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C43C RID: 50236
		public const int EntityIdFieldNumber = 1;

		// Token: 0x0400C43D RID: 50237
		private long entityId_;

		// Token: 0x0400C43E RID: 50238
		public const int HatredValueFieldNumber = 2;

		// Token: 0x0400C43F RID: 50239
		private int hatredValue_;
	}
}
