using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006EA RID: 1770
	public sealed class GmEntityFsmTransitionInfo : IMessage<GmEntityFsmTransitionInfo>, IMessage, IEquatable<GmEntityFsmTransitionInfo>, IDeepCloneable<GmEntityFsmTransitionInfo>, IBufferMessage
	{
		// Token: 0x0600A1A9 RID: 41385 RVA: 0x001874FD File Offset: 0x001856FD
		[NullableContext(1)]
		public static GmEntityFsmTransitionInfo Create()
		{
			return new GmEntityFsmTransitionInfo();
		}

		// Token: 0x17002079 RID: 8313
		// (get) Token: 0x0600A1AA RID: 41386 RVA: 0x00187504 File Offset: 0x00185704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GmEntityFsmTransitionInfo> Parser
		{
			get
			{
				return GmEntityFsmTransitionInfo._parser;
			}
		}

		// Token: 0x1700207A RID: 8314
		// (get) Token: 0x0600A1AB RID: 41387 RVA: 0x0018750B File Offset: 0x0018570B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700207B RID: 8315
		// (get) Token: 0x0600A1AC RID: 41388 RVA: 0x0018750E File Offset: 0x0018570E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GmEntityFsmTransitionInfo.Descriptor;
			}
		}

		// Token: 0x0600A1AD RID: 41389 RVA: 0x00187515 File Offset: 0x00185715
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmEntityFsmTransitionInfo()
		{
		}

		// Token: 0x0600A1AE RID: 41390 RVA: 0x00187528 File Offset: 0x00185728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmEntityFsmTransitionInfo(GmEntityFsmTransitionInfo other) : this()
		{
			this.toStateIndex_ = other.toStateIndex_;
			this.gmEntityFsmConditions_ = other.gmEntityFsmConditions_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A1AF RID: 41391 RVA: 0x0018755E File Offset: 0x0018575E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmEntityFsmTransitionInfo Clone()
		{
			return new GmEntityFsmTransitionInfo(this);
		}

		// Token: 0x1700207C RID: 8316
		// (get) Token: 0x0600A1B0 RID: 41392 RVA: 0x00187566 File Offset: 0x00185766
		// (set) Token: 0x0600A1B1 RID: 41393 RVA: 0x0018756E File Offset: 0x0018576E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ToStateIndex
		{
			get
			{
				return this.toStateIndex_;
			}
			set
			{
				this.toStateIndex_ = value;
			}
		}

		// Token: 0x1700207D RID: 8317
		// (get) Token: 0x0600A1B2 RID: 41394 RVA: 0x00187577 File Offset: 0x00185777
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<bool> GmEntityFsmConditions
		{
			get
			{
				return this.gmEntityFsmConditions_;
			}
		}

		// Token: 0x0600A1B3 RID: 41395 RVA: 0x0018757F File Offset: 0x0018577F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GmEntityFsmTransitionInfo);
		}

		// Token: 0x0600A1B4 RID: 41396 RVA: 0x00187590 File Offset: 0x00185790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GmEntityFsmTransitionInfo other)
		{
			return other != null && (other == this || (this.ToStateIndex == other.ToStateIndex && this.gmEntityFsmConditions_.Equals(other.gmEntityFsmConditions_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A1B5 RID: 41397 RVA: 0x001875E0 File Offset: 0x001857E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ToStateIndex != 0)
			{
				num ^= this.ToStateIndex.GetHashCode();
			}
			num ^= this.gmEntityFsmConditions_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A1B6 RID: 41398 RVA: 0x0018762D File Offset: 0x0018582D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A1B7 RID: 41399 RVA: 0x0018763A File Offset: 0x0018583A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A1B8 RID: 41400 RVA: 0x00187644 File Offset: 0x00185844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ToStateIndex != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ToStateIndex);
			}
			this.gmEntityFsmConditions_.WriteTo(ref output, GmEntityFsmTransitionInfo._repeated_gmEntityFsmConditions_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A1B9 RID: 41401 RVA: 0x00187694 File Offset: 0x00185894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ToStateIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ToStateIndex);
			}
			num += this.gmEntityFsmConditions_.CalculateSize(GmEntityFsmTransitionInfo._repeated_gmEntityFsmConditions_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A1BA RID: 41402 RVA: 0x001876E8 File Offset: 0x001858E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GmEntityFsmTransitionInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ToStateIndex != 0)
			{
				this.ToStateIndex = other.ToStateIndex;
			}
			this.gmEntityFsmConditions_.Add(other.gmEntityFsmConditions_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A1BB RID: 41403 RVA: 0x00187735 File Offset: 0x00185935
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A1BC RID: 41404 RVA: 0x00187740 File Offset: 0x00185940
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
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.gmEntityFsmConditions_.AddEntriesFrom(ref input, GmEntityFsmTransitionInfo._repeated_gmEntityFsmConditions_codec);
					}
				}
				else
				{
					this.ToStateIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004B65 RID: 19301
		private static readonly MessageParser<GmEntityFsmTransitionInfo> _parser = new MessageParser<GmEntityFsmTransitionInfo>(() => new GmEntityFsmTransitionInfo());

		// Token: 0x04004B66 RID: 19302
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B67 RID: 19303
		public const int ToStateIndexFieldNumber = 1;

		// Token: 0x04004B68 RID: 19304
		private int toStateIndex_;

		// Token: 0x04004B69 RID: 19305
		public const int GmEntityFsmConditionsFieldNumber = 2;

		// Token: 0x04004B6A RID: 19306
		private static readonly FieldCodec<bool> _repeated_gmEntityFsmConditions_codec = FieldCodec.ForBool(18U);

		// Token: 0x04004B6B RID: 19307
		private readonly RepeatedField<bool> gmEntityFsmConditions_ = new RepeatedField<bool>();
	}
}
