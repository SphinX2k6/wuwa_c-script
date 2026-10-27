using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000921 RID: 2337
	public sealed class LineCrossActivityData : IMessage<LineCrossActivityData>, IMessage, IEquatable<LineCrossActivityData>, IDeepCloneable<LineCrossActivityData>, IBufferMessage
	{
		// Token: 0x0600CE30 RID: 52784 RVA: 0x001E6102 File Offset: 0x001E4302
		[NullableContext(1)]
		public static LineCrossActivityData Create()
		{
			return new LineCrossActivityData();
		}

		// Token: 0x170029A7 RID: 10663
		// (get) Token: 0x0600CE31 RID: 52785 RVA: 0x001E6109 File Offset: 0x001E4309
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029A8 RID: 10664
		// (get) Token: 0x0600CE32 RID: 52786 RVA: 0x001E610C File Offset: 0x001E430C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LineCrossActivityData.Descriptor;
			}
		}

		// Token: 0x0600CE33 RID: 52787 RVA: 0x001E6113 File Offset: 0x001E4313
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineCrossActivityData()
		{
		}

		// Token: 0x0600CE34 RID: 52788 RVA: 0x001E6126 File Offset: 0x001E4326
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineCrossActivityData(LineCrossActivityData other) : this()
		{
			this.challenges_ = other.challenges_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CE35 RID: 52789 RVA: 0x001E6150 File Offset: 0x001E4350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineCrossActivityData Clone()
		{
			return new LineCrossActivityData(this);
		}

		// Token: 0x170029A9 RID: 10665
		// (get) Token: 0x0600CE36 RID: 52790 RVA: 0x001E6158 File Offset: 0x001E4358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LineCrossChallengeData> Challenges
		{
			get
			{
				return this.challenges_;
			}
		}

		// Token: 0x0600CE37 RID: 52791 RVA: 0x001E6160 File Offset: 0x001E4360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LineCrossActivityData);
		}

		// Token: 0x0600CE38 RID: 52792 RVA: 0x001E616E File Offset: 0x001E436E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LineCrossActivityData other)
		{
			return other != null && (other == this || (this.challenges_.Equals(other.challenges_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CE39 RID: 52793 RVA: 0x001E61A4 File Offset: 0x001E43A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.challenges_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CE3A RID: 52794 RVA: 0x001E61D8 File Offset: 0x001E43D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CE3B RID: 52795 RVA: 0x001E61E5 File Offset: 0x001E43E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CE3C RID: 52796 RVA: 0x001E61EE File Offset: 0x001E43EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.challenges_.WriteTo(ref output, LineCrossActivityData._repeated_challenges_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CE3D RID: 52797 RVA: 0x001E6218 File Offset: 0x001E4418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.challenges_.CalculateSize(LineCrossActivityData._repeated_challenges_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CE3E RID: 52798 RVA: 0x001E6251 File Offset: 0x001E4451
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LineCrossActivityData other)
		{
			if (other == null)
			{
				return;
			}
			this.challenges_.Add(other.challenges_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CE3F RID: 52799 RVA: 0x001E627F File Offset: 0x001E447F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CE40 RID: 52800 RVA: 0x001E6288 File Offset: 0x001E4488
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.challenges_.AddEntriesFrom(ref input, LineCrossActivityData._repeated_challenges_codec);
				}
			}
		}

		// Token: 0x0400572C RID: 22316
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400572D RID: 22317
		public const int ChallengesFieldNumber = 1;

		// Token: 0x0400572E RID: 22318
		private static readonly FieldCodec<LineCrossChallengeData> _repeated_challenges_codec = FieldCodec.ForMessage<LineCrossChallengeData>(10U, LineCrossChallengeData.Parser);

		// Token: 0x0400572F RID: 22319
		private readonly RepeatedField<LineCrossChallengeData> challenges_ = new RepeatedField<LineCrossChallengeData>();
	}
}
