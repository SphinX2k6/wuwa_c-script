using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200048B RID: 1163
	public sealed class EntityMapMarkInfoPb : IMessage<EntityMapMarkInfoPb>, IMessage, IEquatable<EntityMapMarkInfoPb>, IDeepCloneable<EntityMapMarkInfoPb>, IBufferMessage
	{
		// Token: 0x06006F97 RID: 28567 RVA: 0x0011293F File Offset: 0x00110B3F
		[NullableContext(1)]
		public static EntityMapMarkInfoPb Create()
		{
			return new EntityMapMarkInfoPb();
		}

		// Token: 0x1700157D RID: 5501
		// (get) Token: 0x06006F98 RID: 28568 RVA: 0x00112946 File Offset: 0x00110B46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EntityMapMarkInfoPb> Parser
		{
			get
			{
				return EntityMapMarkInfoPb._parser;
			}
		}

		// Token: 0x1700157E RID: 5502
		// (get) Token: 0x06006F99 RID: 28569 RVA: 0x0011294D File Offset: 0x00110B4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700157F RID: 5503
		// (get) Token: 0x06006F9A RID: 28570 RVA: 0x00112950 File Offset: 0x00110B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityMapMarkInfoPb.Descriptor;
			}
		}

		// Token: 0x06006F9B RID: 28571 RVA: 0x00112957 File Offset: 0x00110B57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityMapMarkInfoPb()
		{
		}

		// Token: 0x06006F9C RID: 28572 RVA: 0x00112960 File Offset: 0x00110B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityMapMarkInfoPb(EntityMapMarkInfoPb other) : this()
		{
			this.instId_ = other.instId_;
			this.templateId_ = other.templateId_;
			this.location_ = ((other.location_ != null) ? other.location_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006F9D RID: 28573 RVA: 0x001129B8 File Offset: 0x00110BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityMapMarkInfoPb Clone()
		{
			return new EntityMapMarkInfoPb(this);
		}

		// Token: 0x17001580 RID: 5504
		// (get) Token: 0x06006F9E RID: 28574 RVA: 0x001129C0 File Offset: 0x00110BC0
		// (set) Token: 0x06006F9F RID: 28575 RVA: 0x001129C8 File Offset: 0x00110BC8
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

		// Token: 0x17001581 RID: 5505
		// (get) Token: 0x06006FA0 RID: 28576 RVA: 0x001129D1 File Offset: 0x00110BD1
		// (set) Token: 0x06006FA1 RID: 28577 RVA: 0x001129D9 File Offset: 0x00110BD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TemplateId
		{
			get
			{
				return this.templateId_;
			}
			set
			{
				this.templateId_ = value;
			}
		}

		// Token: 0x17001582 RID: 5506
		// (get) Token: 0x06006FA2 RID: 28578 RVA: 0x001129E2 File Offset: 0x00110BE2
		// (set) Token: 0x06006FA3 RID: 28579 RVA: 0x001129EA File Offset: 0x00110BEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Location
		{
			get
			{
				return this.location_;
			}
			set
			{
				this.location_ = value;
			}
		}

		// Token: 0x06006FA4 RID: 28580 RVA: 0x001129F3 File Offset: 0x00110BF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityMapMarkInfoPb);
		}

		// Token: 0x06006FA5 RID: 28581 RVA: 0x00112A04 File Offset: 0x00110C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityMapMarkInfoPb other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.TemplateId == other.TemplateId && object.Equals(this.Location, other.Location) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006FA6 RID: 28582 RVA: 0x00112A64 File Offset: 0x00110C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.TemplateId != 0)
			{
				num ^= this.TemplateId.GetHashCode();
			}
			if (this.location_ != null)
			{
				num ^= this.Location.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006FA7 RID: 28583 RVA: 0x00112AD2 File Offset: 0x00110CD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006FA8 RID: 28584 RVA: 0x00112ADF File Offset: 0x00110CDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006FA9 RID: 28585 RVA: 0x00112AE8 File Offset: 0x00110CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.InstId);
			}
			if (this.TemplateId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TemplateId);
			}
			if (this.location_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Location);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006FAA RID: 28586 RVA: 0x00112B5C File Offset: 0x00110D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.TemplateId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TemplateId);
			}
			if (this.location_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Location);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006FAB RID: 28587 RVA: 0x00112BCC File Offset: 0x00110DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityMapMarkInfoPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.TemplateId != 0)
			{
				this.TemplateId = other.TemplateId;
			}
			if (other.location_ != null)
			{
				if (this.location_ == null)
				{
					this.Location = new Vector();
				}
				this.Location.MergeFrom(other.Location);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006FAC RID: 28588 RVA: 0x00112C48 File Offset: 0x00110E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006FAD RID: 28589 RVA: 0x00112C54 File Offset: 0x00110E54
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
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.location_ == null)
							{
								this.Location = new Vector();
							}
							input.ReadMessage(this.Location);
						}
					}
					else
					{
						this.TemplateId = input.ReadInt32();
					}
				}
				else
				{
					this.InstId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003C5E RID: 15454
		private static readonly MessageParser<EntityMapMarkInfoPb> _parser = new MessageParser<EntityMapMarkInfoPb>(() => new EntityMapMarkInfoPb());

		// Token: 0x04003C5F RID: 15455
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C60 RID: 15456
		public const int InstIdFieldNumber = 1;

		// Token: 0x04003C61 RID: 15457
		private int instId_;

		// Token: 0x04003C62 RID: 15458
		public const int TemplateIdFieldNumber = 2;

		// Token: 0x04003C63 RID: 15459
		private int templateId_;

		// Token: 0x04003C64 RID: 15460
		public const int LocationFieldNumber = 3;

		// Token: 0x04003C65 RID: 15461
		private Vector location_;
	}
}
