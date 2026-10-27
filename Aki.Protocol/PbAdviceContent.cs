using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BFC RID: 3068
	public sealed class PbAdviceContent : IMessage<PbAdviceContent>, IMessage, IEquatable<PbAdviceContent>, IDeepCloneable<PbAdviceContent>, IBufferMessage
	{
		// Token: 0x06010A69 RID: 68201 RVA: 0x00270076 File Offset: 0x0026E276
		[NullableContext(1)]
		public static PbAdviceContent Create()
		{
			return new PbAdviceContent();
		}

		// Token: 0x170036E0 RID: 14048
		// (get) Token: 0x06010A6A RID: 68202 RVA: 0x0027007D File Offset: 0x0026E27D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PbAdviceContent> Parser
		{
			get
			{
				return PbAdviceContent._parser;
			}
		}

		// Token: 0x170036E1 RID: 14049
		// (get) Token: 0x06010A6B RID: 68203 RVA: 0x00270084 File Offset: 0x0026E284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170036E2 RID: 14050
		// (get) Token: 0x06010A6C RID: 68204 RVA: 0x00270087 File Offset: 0x0026E287
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbAdviceContent.Descriptor;
			}
		}

		// Token: 0x06010A6D RID: 68205 RVA: 0x0027008E File Offset: 0x0026E28E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbAdviceContent()
		{
		}

		// Token: 0x06010A6E RID: 68206 RVA: 0x00270096 File Offset: 0x0026E296
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbAdviceContent(PbAdviceContent other) : this()
		{
			this.type_ = other.type_;
			this.id_ = other.id_;
			this.word_ = other.word_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010A6F RID: 68207 RVA: 0x002700D3 File Offset: 0x0026E2D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbAdviceContent Clone()
		{
			return new PbAdviceContent(this);
		}

		// Token: 0x170036E3 RID: 14051
		// (get) Token: 0x06010A70 RID: 68208 RVA: 0x002700DB File Offset: 0x0026E2DB
		// (set) Token: 0x06010A71 RID: 68209 RVA: 0x002700E3 File Offset: 0x0026E2E3
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

		// Token: 0x170036E4 RID: 14052
		// (get) Token: 0x06010A72 RID: 68210 RVA: 0x002700EC File Offset: 0x0026E2EC
		// (set) Token: 0x06010A73 RID: 68211 RVA: 0x002700F4 File Offset: 0x0026E2F4
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

		// Token: 0x170036E5 RID: 14053
		// (get) Token: 0x06010A74 RID: 68212 RVA: 0x002700FD File Offset: 0x0026E2FD
		// (set) Token: 0x06010A75 RID: 68213 RVA: 0x00270105 File Offset: 0x0026E305
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

		// Token: 0x06010A76 RID: 68214 RVA: 0x0027010E File Offset: 0x0026E30E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbAdviceContent);
		}

		// Token: 0x06010A77 RID: 68215 RVA: 0x0027011C File Offset: 0x0026E31C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbAdviceContent other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.Id == other.Id && this.Word == other.Word && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010A78 RID: 68216 RVA: 0x00270178 File Offset: 0x0026E378
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

		// Token: 0x06010A79 RID: 68217 RVA: 0x002701EF File Offset: 0x0026E3EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010A7A RID: 68218 RVA: 0x002701FC File Offset: 0x0026E3FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010A7B RID: 68219 RVA: 0x00270208 File Offset: 0x0026E408
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

		// Token: 0x06010A7C RID: 68220 RVA: 0x0027027C File Offset: 0x0026E47C
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

		// Token: 0x06010A7D RID: 68221 RVA: 0x002702EC File Offset: 0x0026E4EC
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

		// Token: 0x06010A7E RID: 68222 RVA: 0x00270350 File Offset: 0x0026E550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010A7F RID: 68223 RVA: 0x0027035C File Offset: 0x0026E55C
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

		// Token: 0x040069D4 RID: 27092
		private static readonly MessageParser<PbAdviceContent> _parser = new MessageParser<PbAdviceContent>(() => new PbAdviceContent());

		// Token: 0x040069D5 RID: 27093
		private UnknownFieldSet _unknownFields;

		// Token: 0x040069D6 RID: 27094
		public const int TypeFieldNumber = 1;

		// Token: 0x040069D7 RID: 27095
		private PbAdviceContentType type_;

		// Token: 0x040069D8 RID: 27096
		public const int IdFieldNumber = 2;

		// Token: 0x040069D9 RID: 27097
		private int id_;

		// Token: 0x040069DA RID: 27098
		public const int WordFieldNumber = 3;

		// Token: 0x040069DB RID: 27099
		private int word_;
	}
}
