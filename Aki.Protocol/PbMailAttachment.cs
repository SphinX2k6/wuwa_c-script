using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BF7 RID: 3063
	public sealed class PbMailAttachment : IMessage<PbMailAttachment>, IMessage, IEquatable<PbMailAttachment>, IDeepCloneable<PbMailAttachment>, IBufferMessage
	{
		// Token: 0x06010A6B RID: 68203 RVA: 0x002709EA File Offset: 0x0026EBEA
		[NullableContext(1)]
		public static PbMailAttachment Create()
		{
			return new PbMailAttachment();
		}

		// Token: 0x170036E9 RID: 14057
		// (get) Token: 0x06010A6C RID: 68204 RVA: 0x002709F1 File Offset: 0x0026EBF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PbMailAttachment> Parser
		{
			get
			{
				return PbMailAttachment._parser;
			}
		}

		// Token: 0x170036EA RID: 14058
		// (get) Token: 0x06010A6D RID: 68205 RVA: 0x002709F8 File Offset: 0x0026EBF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170036EB RID: 14059
		// (get) Token: 0x06010A6E RID: 68206 RVA: 0x002709FB File Offset: 0x0026EBFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbMailAttachment.Descriptor;
			}
		}

		// Token: 0x06010A6F RID: 68207 RVA: 0x00270A02 File Offset: 0x0026EC02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbMailAttachment()
		{
		}

		// Token: 0x06010A70 RID: 68208 RVA: 0x00270A0A File Offset: 0x0026EC0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbMailAttachment(PbMailAttachment other) : this()
		{
			this.id_ = other.id_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010A71 RID: 68209 RVA: 0x00270A3B File Offset: 0x0026EC3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbMailAttachment Clone()
		{
			return new PbMailAttachment(this);
		}

		// Token: 0x170036EC RID: 14060
		// (get) Token: 0x06010A72 RID: 68210 RVA: 0x00270A43 File Offset: 0x0026EC43
		// (set) Token: 0x06010A73 RID: 68211 RVA: 0x00270A4B File Offset: 0x0026EC4B
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

		// Token: 0x170036ED RID: 14061
		// (get) Token: 0x06010A74 RID: 68212 RVA: 0x00270A54 File Offset: 0x0026EC54
		// (set) Token: 0x06010A75 RID: 68213 RVA: 0x00270A5C File Offset: 0x0026EC5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x06010A76 RID: 68214 RVA: 0x00270A65 File Offset: 0x0026EC65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbMailAttachment);
		}

		// Token: 0x06010A77 RID: 68215 RVA: 0x00270A73 File Offset: 0x0026EC73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbMailAttachment other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010A78 RID: 68216 RVA: 0x00270AB4 File Offset: 0x0026ECB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010A79 RID: 68217 RVA: 0x00270B0C File Offset: 0x0026ED0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010A7A RID: 68218 RVA: 0x00270B19 File Offset: 0x0026ED19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010A7B RID: 68219 RVA: 0x00270B24 File Offset: 0x0026ED24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Count);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010A7C RID: 68220 RVA: 0x00270B7C File Offset: 0x0026ED7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010A7D RID: 68221 RVA: 0x00270BD4 File Offset: 0x0026EDD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PbMailAttachment other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010A7E RID: 68222 RVA: 0x00270C24 File Offset: 0x0026EE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010A7F RID: 68223 RVA: 0x00270C30 File Offset: 0x0026EE30
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
						this.Count = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006A47 RID: 27207
		private static readonly MessageParser<PbMailAttachment> _parser = new MessageParser<PbMailAttachment>(() => new PbMailAttachment());

		// Token: 0x04006A48 RID: 27208
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006A49 RID: 27209
		public const int IdFieldNumber = 1;

		// Token: 0x04006A4A RID: 27210
		private int id_;

		// Token: 0x04006A4B RID: 27211
		public const int CountFieldNumber = 2;

		// Token: 0x04006A4C RID: 27212
		private int count_;
	}
}
