using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F79 RID: 3961
	[NetMessage(EMessageId.RogueInstExtraInfoRequest)]
	public sealed class RogueInstExtraInfoRequest : IMessage<RogueInstExtraInfoRequest>, IMessage, IEquatable<RogueInstExtraInfoRequest>, IDeepCloneable<RogueInstExtraInfoRequest>, IBufferMessage
	{
		// Token: 0x06015368 RID: 86888 RVA: 0x00314832 File Offset: 0x00312A32
		[NullableContext(1)]
		public static RogueInstExtraInfoRequest Create()
		{
			return new RogueInstExtraInfoRequest();
		}

		// Token: 0x170046AD RID: 18093
		// (get) Token: 0x06015369 RID: 86889 RVA: 0x00314839 File Offset: 0x00312A39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170046AE RID: 18094
		// (get) Token: 0x0601536A RID: 86890 RVA: 0x0031483C File Offset: 0x00312A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueInstExtraInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601536B RID: 86891 RVA: 0x00314843 File Offset: 0x00312A43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueInstExtraInfoRequest()
		{
		}

		// Token: 0x0601536C RID: 86892 RVA: 0x0031484B File Offset: 0x00312A4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueInstExtraInfoRequest(RogueInstExtraInfoRequest other) : this()
		{
			this.seasonId_ = other.seasonId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601536D RID: 86893 RVA: 0x00314870 File Offset: 0x00312A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueInstExtraInfoRequest Clone()
		{
			return new RogueInstExtraInfoRequest(this);
		}

		// Token: 0x170046AF RID: 18095
		// (get) Token: 0x0601536E RID: 86894 RVA: 0x00314878 File Offset: 0x00312A78
		// (set) Token: 0x0601536F RID: 86895 RVA: 0x00314880 File Offset: 0x00312A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SeasonId
		{
			get
			{
				return this.seasonId_;
			}
			set
			{
				this.seasonId_ = value;
			}
		}

		// Token: 0x06015370 RID: 86896 RVA: 0x00314889 File Offset: 0x00312A89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueInstExtraInfoRequest);
		}

		// Token: 0x06015371 RID: 86897 RVA: 0x00314897 File Offset: 0x00312A97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueInstExtraInfoRequest other)
		{
			return other != null && (other == this || (this.SeasonId == other.SeasonId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015372 RID: 86898 RVA: 0x003148C8 File Offset: 0x00312AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SeasonId != 0)
			{
				num ^= this.SeasonId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015373 RID: 86899 RVA: 0x00314907 File Offset: 0x00312B07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015374 RID: 86900 RVA: 0x00314914 File Offset: 0x00312B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015375 RID: 86901 RVA: 0x0031491D File Offset: 0x00312B1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SeasonId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SeasonId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015376 RID: 86902 RVA: 0x00314950 File Offset: 0x00312B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SeasonId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SeasonId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015377 RID: 86903 RVA: 0x0031498E File Offset: 0x00312B8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueInstExtraInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SeasonId != 0)
			{
				this.SeasonId = other.SeasonId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015378 RID: 86904 RVA: 0x003149BF File Offset: 0x00312BBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015379 RID: 86905 RVA: 0x003149C8 File Offset: 0x00312BC8
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SeasonId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008025 RID: 32805
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008026 RID: 32806
		public const int SeasonIdFieldNumber = 3;

		// Token: 0x04008027 RID: 32807
		private int seasonId_;
	}
}
