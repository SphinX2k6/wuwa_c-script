using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001040 RID: 4160
	[NetMessage(EMessageId.RogueWeeklyOptionSelectRequest)]
	public sealed class RogueWeeklyOptionSelectRequest : IMessage<RogueWeeklyOptionSelectRequest>, IMessage, IEquatable<RogueWeeklyOptionSelectRequest>, IDeepCloneable<RogueWeeklyOptionSelectRequest>, IBufferMessage
	{
		// Token: 0x060163AF RID: 91055 RVA: 0x0033AC36 File Offset: 0x00338E36
		[NullableContext(1)]
		public static RogueWeeklyOptionSelectRequest Create()
		{
			return new RogueWeeklyOptionSelectRequest();
		}

		// Token: 0x17004A52 RID: 19026
		// (get) Token: 0x060163B0 RID: 91056 RVA: 0x0033AC3D File Offset: 0x00338E3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A53 RID: 19027
		// (get) Token: 0x060163B1 RID: 91057 RVA: 0x0033AC40 File Offset: 0x00338E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyOptionSelectRequest.Descriptor;
			}
		}

		// Token: 0x060163B2 RID: 91058 RVA: 0x0033AC47 File Offset: 0x00338E47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyOptionSelectRequest()
		{
		}

		// Token: 0x060163B3 RID: 91059 RVA: 0x0033AC4F File Offset: 0x00338E4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyOptionSelectRequest(RogueWeeklyOptionSelectRequest other) : this()
		{
			this.bindId_ = other.bindId_;
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060163B4 RID: 91060 RVA: 0x0033AC80 File Offset: 0x00338E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyOptionSelectRequest Clone()
		{
			return new RogueWeeklyOptionSelectRequest(this);
		}

		// Token: 0x17004A54 RID: 19028
		// (get) Token: 0x060163B5 RID: 91061 RVA: 0x0033AC88 File Offset: 0x00338E88
		// (set) Token: 0x060163B6 RID: 91062 RVA: 0x0033AC90 File Offset: 0x00338E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BindId
		{
			get
			{
				return this.bindId_;
			}
			set
			{
				this.bindId_ = value;
			}
		}

		// Token: 0x17004A55 RID: 19029
		// (get) Token: 0x060163B7 RID: 91063 RVA: 0x0033AC99 File Offset: 0x00338E99
		// (set) Token: 0x060163B8 RID: 91064 RVA: 0x0033ACA1 File Offset: 0x00338EA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x060163B9 RID: 91065 RVA: 0x0033ACAA File Offset: 0x00338EAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyOptionSelectRequest);
		}

		// Token: 0x060163BA RID: 91066 RVA: 0x0033ACB8 File Offset: 0x00338EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyOptionSelectRequest other)
		{
			return other != null && (other == this || (this.BindId == other.BindId && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060163BB RID: 91067 RVA: 0x0033ACF8 File Offset: 0x00338EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BindId != 0)
			{
				num ^= this.BindId.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060163BC RID: 91068 RVA: 0x0033AD50 File Offset: 0x00338F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060163BD RID: 91069 RVA: 0x0033AD5D File Offset: 0x00338F5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060163BE RID: 91070 RVA: 0x0033AD68 File Offset: 0x00338F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Index);
			}
			if (this.BindId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.BindId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060163BF RID: 91071 RVA: 0x0033ADC4 File Offset: 0x00338FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BindId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BindId);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060163C0 RID: 91072 RVA: 0x0033AE1C File Offset: 0x0033901C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWeeklyOptionSelectRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BindId != 0)
			{
				this.BindId = other.BindId;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060163C1 RID: 91073 RVA: 0x0033AE6C File Offset: 0x0033906C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060163C2 RID: 91074 RVA: 0x0033AE78 File Offset: 0x00339078
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
				if (num != 80U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BindId = input.ReadInt32();
					}
				}
				else
				{
					this.Index = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008502 RID: 34050
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008503 RID: 34051
		public const int BindIdFieldNumber = 15;

		// Token: 0x04008504 RID: 34052
		private int bindId_;

		// Token: 0x04008505 RID: 34053
		public const int IndexFieldNumber = 10;

		// Token: 0x04008506 RID: 34054
		private int index_;
	}
}
