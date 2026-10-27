using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004A2 RID: 1186
	public sealed class EntityMapMarkInfoPb : IMessage<EntityMapMarkInfoPb>, IMessage, IEquatable<EntityMapMarkInfoPb>, IDeepCloneable<EntityMapMarkInfoPb>, IBufferMessage
	{
		// Token: 0x06007125 RID: 28965 RVA: 0x001159B8 File Offset: 0x00113BB8
		[NullableContext(1)]
		public static EntityMapMarkInfoPb Create()
		{
			return new EntityMapMarkInfoPb();
		}

		// Token: 0x170015D1 RID: 5585
		// (get) Token: 0x06007126 RID: 28966 RVA: 0x001159BF File Offset: 0x00113BBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EntityMapMarkInfoPb> Parser
		{
			get
			{
				return EntityMapMarkInfoPb._parser;
			}
		}

		// Token: 0x170015D2 RID: 5586
		// (get) Token: 0x06007127 RID: 28967 RVA: 0x001159C6 File Offset: 0x00113BC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015D3 RID: 5587
		// (get) Token: 0x06007128 RID: 28968 RVA: 0x001159C9 File Offset: 0x00113BC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityMapMarkInfoPb.Descriptor;
			}
		}

		// Token: 0x06007129 RID: 28969 RVA: 0x001159D0 File Offset: 0x00113BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityMapMarkInfoPb()
		{
		}

		// Token: 0x0600712A RID: 28970 RVA: 0x001159D8 File Offset: 0x00113BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityMapMarkInfoPb(EntityMapMarkInfoPb other) : this()
		{
			this.instId_ = other.instId_;
			this.templateId_ = other.templateId_;
			this.location_ = ((other.location_ != null) ? other.location_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600712B RID: 28971 RVA: 0x00115A30 File Offset: 0x00113C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityMapMarkInfoPb Clone()
		{
			return new EntityMapMarkInfoPb(this);
		}

		// Token: 0x170015D4 RID: 5588
		// (get) Token: 0x0600712C RID: 28972 RVA: 0x00115A38 File Offset: 0x00113C38
		// (set) Token: 0x0600712D RID: 28973 RVA: 0x00115A40 File Offset: 0x00113C40
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

		// Token: 0x170015D5 RID: 5589
		// (get) Token: 0x0600712E RID: 28974 RVA: 0x00115A49 File Offset: 0x00113C49
		// (set) Token: 0x0600712F RID: 28975 RVA: 0x00115A51 File Offset: 0x00113C51
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

		// Token: 0x170015D6 RID: 5590
		// (get) Token: 0x06007130 RID: 28976 RVA: 0x00115A5A File Offset: 0x00113C5A
		// (set) Token: 0x06007131 RID: 28977 RVA: 0x00115A62 File Offset: 0x00113C62
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

		// Token: 0x06007132 RID: 28978 RVA: 0x00115A6B File Offset: 0x00113C6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityMapMarkInfoPb);
		}

		// Token: 0x06007133 RID: 28979 RVA: 0x00115A7C File Offset: 0x00113C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityMapMarkInfoPb other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.TemplateId == other.TemplateId && object.Equals(this.Location, other.Location) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007134 RID: 28980 RVA: 0x00115ADC File Offset: 0x00113CDC
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

		// Token: 0x06007135 RID: 28981 RVA: 0x00115B4A File Offset: 0x00113D4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007136 RID: 28982 RVA: 0x00115B57 File Offset: 0x00113D57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007137 RID: 28983 RVA: 0x00115B60 File Offset: 0x00113D60
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

		// Token: 0x06007138 RID: 28984 RVA: 0x00115BD4 File Offset: 0x00113DD4
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

		// Token: 0x06007139 RID: 28985 RVA: 0x00115C44 File Offset: 0x00113E44
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

		// Token: 0x0600713A RID: 28986 RVA: 0x00115CC0 File Offset: 0x00113EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600713B RID: 28987 RVA: 0x00115CCC File Offset: 0x00113ECC
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

		// Token: 0x04003C70 RID: 15472
		private static readonly MessageParser<EntityMapMarkInfoPb> _parser = new MessageParser<EntityMapMarkInfoPb>(() => new EntityMapMarkInfoPb());

		// Token: 0x04003C71 RID: 15473
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C72 RID: 15474
		public const int InstIdFieldNumber = 1;

		// Token: 0x04003C73 RID: 15475
		private int instId_;

		// Token: 0x04003C74 RID: 15476
		public const int TemplateIdFieldNumber = 2;

		// Token: 0x04003C75 RID: 15477
		private int templateId_;

		// Token: 0x04003C76 RID: 15478
		public const int LocationFieldNumber = 3;

		// Token: 0x04003C77 RID: 15479
		private Vector location_;
	}
}
