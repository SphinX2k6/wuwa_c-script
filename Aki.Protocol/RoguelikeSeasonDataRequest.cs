using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FA7 RID: 4007
	[NetMessage(EMessageId.RoguelikeSeasonDataRequest)]
	public sealed class RoguelikeSeasonDataRequest : IMessage<RoguelikeSeasonDataRequest>, IMessage, IEquatable<RoguelikeSeasonDataRequest>, IDeepCloneable<RoguelikeSeasonDataRequest>, IBufferMessage
	{
		// Token: 0x06015748 RID: 87880 RVA: 0x0031DF5F File Offset: 0x0031C15F
		[NullableContext(1)]
		public static RoguelikeSeasonDataRequest Create()
		{
			return new RoguelikeSeasonDataRequest();
		}

		// Token: 0x1700478F RID: 18319
		// (get) Token: 0x06015749 RID: 87881 RVA: 0x0031DF66 File Offset: 0x0031C166
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004790 RID: 18320
		// (get) Token: 0x0601574A RID: 87882 RVA: 0x0031DF69 File Offset: 0x0031C169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeSeasonDataRequest.Descriptor;
			}
		}

		// Token: 0x0601574B RID: 87883 RVA: 0x0031DF70 File Offset: 0x0031C170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeSeasonDataRequest()
		{
		}

		// Token: 0x0601574C RID: 87884 RVA: 0x0031DF78 File Offset: 0x0031C178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeSeasonDataRequest(RoguelikeSeasonDataRequest other) : this()
		{
			this.seasonId_ = other.seasonId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601574D RID: 87885 RVA: 0x0031DF9D File Offset: 0x0031C19D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeSeasonDataRequest Clone()
		{
			return new RoguelikeSeasonDataRequest(this);
		}

		// Token: 0x17004791 RID: 18321
		// (get) Token: 0x0601574E RID: 87886 RVA: 0x0031DFA5 File Offset: 0x0031C1A5
		// (set) Token: 0x0601574F RID: 87887 RVA: 0x0031DFAD File Offset: 0x0031C1AD
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

		// Token: 0x06015750 RID: 87888 RVA: 0x0031DFB6 File Offset: 0x0031C1B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeSeasonDataRequest);
		}

		// Token: 0x06015751 RID: 87889 RVA: 0x0031DFC4 File Offset: 0x0031C1C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeSeasonDataRequest other)
		{
			return other != null && (other == this || (this.SeasonId == other.SeasonId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015752 RID: 87890 RVA: 0x0031DFF4 File Offset: 0x0031C1F4
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

		// Token: 0x06015753 RID: 87891 RVA: 0x0031E033 File Offset: 0x0031C233
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015754 RID: 87892 RVA: 0x0031E040 File Offset: 0x0031C240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015755 RID: 87893 RVA: 0x0031E049 File Offset: 0x0031C249
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

		// Token: 0x06015756 RID: 87894 RVA: 0x0031E07C File Offset: 0x0031C27C
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

		// Token: 0x06015757 RID: 87895 RVA: 0x0031E0BA File Offset: 0x0031C2BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeSeasonDataRequest other)
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

		// Token: 0x06015758 RID: 87896 RVA: 0x0031E0EB File Offset: 0x0031C2EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015759 RID: 87897 RVA: 0x0031E0F4 File Offset: 0x0031C2F4
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

		// Token: 0x04008177 RID: 33143
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008178 RID: 33144
		public const int SeasonIdFieldNumber = 3;

		// Token: 0x04008179 RID: 33145
		private int seasonId_;
	}
}
