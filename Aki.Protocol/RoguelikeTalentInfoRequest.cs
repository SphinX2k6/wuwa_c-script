using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FAE RID: 4014
	[NetMessage(EMessageId.RoguelikeTalentInfoRequest)]
	public sealed class RoguelikeTalentInfoRequest : IMessage<RoguelikeTalentInfoRequest>, IMessage, IEquatable<RoguelikeTalentInfoRequest>, IDeepCloneable<RoguelikeTalentInfoRequest>, IBufferMessage
	{
		// Token: 0x060157E1 RID: 88033 RVA: 0x0031F74D File Offset: 0x0031D94D
		[NullableContext(1)]
		public static RoguelikeTalentInfoRequest Create()
		{
			return new RoguelikeTalentInfoRequest();
		}

		// Token: 0x170047B2 RID: 18354
		// (get) Token: 0x060157E2 RID: 88034 RVA: 0x0031F754 File Offset: 0x0031D954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047B3 RID: 18355
		// (get) Token: 0x060157E3 RID: 88035 RVA: 0x0031F757 File Offset: 0x0031D957
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeTalentInfoRequest.Descriptor;
			}
		}

		// Token: 0x060157E4 RID: 88036 RVA: 0x0031F75E File Offset: 0x0031D95E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTalentInfoRequest()
		{
		}

		// Token: 0x060157E5 RID: 88037 RVA: 0x0031F766 File Offset: 0x0031D966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTalentInfoRequest(RoguelikeTalentInfoRequest other) : this()
		{
			this.seasonId_ = other.seasonId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060157E6 RID: 88038 RVA: 0x0031F78B File Offset: 0x0031D98B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTalentInfoRequest Clone()
		{
			return new RoguelikeTalentInfoRequest(this);
		}

		// Token: 0x170047B4 RID: 18356
		// (get) Token: 0x060157E7 RID: 88039 RVA: 0x0031F793 File Offset: 0x0031D993
		// (set) Token: 0x060157E8 RID: 88040 RVA: 0x0031F79B File Offset: 0x0031D99B
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

		// Token: 0x060157E9 RID: 88041 RVA: 0x0031F7A4 File Offset: 0x0031D9A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeTalentInfoRequest);
		}

		// Token: 0x060157EA RID: 88042 RVA: 0x0031F7B2 File Offset: 0x0031D9B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeTalentInfoRequest other)
		{
			return other != null && (other == this || (this.SeasonId == other.SeasonId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060157EB RID: 88043 RVA: 0x0031F7E0 File Offset: 0x0031D9E0
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

		// Token: 0x060157EC RID: 88044 RVA: 0x0031F81F File Offset: 0x0031DA1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060157ED RID: 88045 RVA: 0x0031F82C File Offset: 0x0031DA2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060157EE RID: 88046 RVA: 0x0031F835 File Offset: 0x0031DA35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SeasonId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SeasonId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060157EF RID: 88047 RVA: 0x0031F868 File Offset: 0x0031DA68
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

		// Token: 0x060157F0 RID: 88048 RVA: 0x0031F8A6 File Offset: 0x0031DAA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeTalentInfoRequest other)
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

		// Token: 0x060157F1 RID: 88049 RVA: 0x0031F8D7 File Offset: 0x0031DAD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060157F2 RID: 88050 RVA: 0x0031F8E0 File Offset: 0x0031DAE0
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SeasonId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040081AD RID: 33197
		private UnknownFieldSet _unknownFields;

		// Token: 0x040081AE RID: 33198
		public const int SeasonIdFieldNumber = 1;

		// Token: 0x040081AF RID: 33199
		private int seasonId_;
	}
}
