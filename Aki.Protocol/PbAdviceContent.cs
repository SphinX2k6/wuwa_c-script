using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BEC RID: 3052
	public sealed class PbAdviceContent : IMessage<PbAdviceContent>, IMessage, IEquatable<PbAdviceContent>, IDeepCloneable<PbAdviceContent>, IBufferMessage
	{
		// Token: 0x06010969 RID: 67945 RVA: 0x0026E30E File Offset: 0x0026C50E
		[NullableContext(1)]
		public static PbAdviceContent Create()
		{
			return new PbAdviceContent();
		}

		// Token: 0x170036A9 RID: 13993
		// (get) Token: 0x0601096A RID: 67946 RVA: 0x0026E315 File Offset: 0x0026C515
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PbAdviceContent> Parser
		{
			get
			{
				return PbAdviceContent._parser;
			}
		}

		// Token: 0x170036AA RID: 13994
		// (get) Token: 0x0601096B RID: 67947 RVA: 0x0026E31C File Offset: 0x0026C51C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170036AB RID: 13995
		// (get) Token: 0x0601096C RID: 67948 RVA: 0x0026E31F File Offset: 0x0026C51F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbAdviceContent.Descriptor;
			}
		}

		// Token: 0x0601096D RID: 67949 RVA: 0x0026E326 File Offset: 0x0026C526
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbAdviceContent()
		{
		}

		// Token: 0x0601096E RID: 67950 RVA: 0x0026E32E File Offset: 0x0026C52E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbAdviceContent(PbAdviceContent other) : this()
		{
			this.type_ = other.type_;
			this.id_ = other.id_;
			this.word_ = other.word_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601096F RID: 67951 RVA: 0x0026E36B File Offset: 0x0026C56B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbAdviceContent Clone()
		{
			return new PbAdviceContent(this);
		}

		// Token: 0x170036AC RID: 13996
		// (get) Token: 0x06010970 RID: 67952 RVA: 0x0026E373 File Offset: 0x0026C573
		// (set) Token: 0x06010971 RID: 67953 RVA: 0x0026E37B File Offset: 0x0026C57B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbAdviceContentType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x170036AD RID: 13997
		// (get) Token: 0x06010972 RID: 67954 RVA: 0x0026E384 File Offset: 0x0026C584
		// (set) Token: 0x06010973 RID: 67955 RVA: 0x0026E38C File Offset: 0x0026C58C
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

		// Token: 0x170036AE RID: 13998
		// (get) Token: 0x06010974 RID: 67956 RVA: 0x0026E395 File Offset: 0x0026C595
		// (set) Token: 0x06010975 RID: 67957 RVA: 0x0026E39D File Offset: 0x0026C59D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Word
		{
			get
			{
				return this.word_;
			}
			set
			{
				this.word_ = value;
			}
		}

		// Token: 0x06010976 RID: 67958 RVA: 0x0026E3A6 File Offset: 0x0026C5A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbAdviceContent);
		}

		// Token: 0x06010977 RID: 67959 RVA: 0x0026E3B4 File Offset: 0x0026C5B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbAdviceContent other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.Id == other.Id && this.Word == other.Word && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010978 RID: 67960 RVA: 0x0026E410 File Offset: 0x0026C610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != PbAdviceContentType.Sentence)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Word != 0)
			{
				num ^= this.Word.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010979 RID: 67961 RVA: 0x0026E487 File Offset: 0x0026C687
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601097A RID: 67962 RVA: 0x0026E494 File Offset: 0x0026C694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601097B RID: 67963 RVA: 0x0026E4A0 File Offset: 0x0026C6A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != PbAdviceContentType.Sentence)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Type);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Id);
			}
			if (this.Word != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Word);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601097C RID: 67964 RVA: 0x0026E514 File Offset: 0x0026C714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != PbAdviceContentType.Sentence)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Word != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Word);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601097D RID: 67965 RVA: 0x0026E584 File Offset: 0x0026C784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PbAdviceContent other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != PbAdviceContentType.Sentence)
			{
				this.Type = other.Type;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Word != 0)
			{
				this.Word = other.Word;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601097E RID: 67966 RVA: 0x0026E5E8 File Offset: 0x0026C7E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601097F RID: 67967 RVA: 0x0026E5F4 File Offset: 0x0026C7F4
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
							this.Word = input.ReadInt32();
						}
					}
					else
					{
						this.Id = input.ReadInt32();
					}
				}
				else
				{
					this.Type = (PbAdviceContentType)input.ReadEnum();
				}
			}
		}

		// Token: 0x040069E8 RID: 27112
		private static readonly MessageParser<PbAdviceContent> _parser = new MessageParser<PbAdviceContent>(() => new PbAdviceContent());

		// Token: 0x040069E9 RID: 27113
		private UnknownFieldSet _unknownFields;

		// Token: 0x040069EA RID: 27114
		public const int TypeFieldNumber = 1;

		// Token: 0x040069EB RID: 27115
		private PbAdviceContentType type_;

		// Token: 0x040069EC RID: 27116
		public const int IdFieldNumber = 2;

		// Token: 0x040069ED RID: 27117
		private int id_;

		// Token: 0x040069EE RID: 27118
		public const int WordFieldNumber = 3;

		// Token: 0x040069EF RID: 27119
		private int word_;
	}
}
