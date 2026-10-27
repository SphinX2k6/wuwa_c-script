using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000922 RID: 2338
	[NetMessage(EMessageId.LineCrossActivityUpdateNotify)]
	public sealed class LineCrossActivityUpdateNotify : IMessage<LineCrossActivityUpdateNotify>, IMessage, IEquatable<LineCrossActivityUpdateNotify>, IDeepCloneable<LineCrossActivityUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600CE42 RID: 52802 RVA: 0x001E62E5 File Offset: 0x001E44E5
		[NullableContext(1)]
		public static LineCrossActivityUpdateNotify Create()
		{
			return new LineCrossActivityUpdateNotify();
		}

		// Token: 0x170029AA RID: 10666
		// (get) Token: 0x0600CE43 RID: 52803 RVA: 0x001E62EC File Offset: 0x001E44EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029AB RID: 10667
		// (get) Token: 0x0600CE44 RID: 52804 RVA: 0x001E62EF File Offset: 0x001E44EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LineCrossActivityUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600CE45 RID: 52805 RVA: 0x001E62F6 File Offset: 0x001E44F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineCrossActivityUpdateNotify()
		{
		}

		// Token: 0x0600CE46 RID: 52806 RVA: 0x001E6309 File Offset: 0x001E4509
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineCrossActivityUpdateNotify(LineCrossActivityUpdateNotify other) : this()
		{
			this.challenges_ = other.challenges_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CE47 RID: 52807 RVA: 0x001E6333 File Offset: 0x001E4533
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineCrossActivityUpdateNotify Clone()
		{
			return new LineCrossActivityUpdateNotify(this);
		}

		// Token: 0x170029AC RID: 10668
		// (get) Token: 0x0600CE48 RID: 52808 RVA: 0x001E633B File Offset: 0x001E453B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LineCrossChallengeData> Challenges
		{
			get
			{
				return this.challenges_;
			}
		}

		// Token: 0x0600CE49 RID: 52809 RVA: 0x001E6343 File Offset: 0x001E4543
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LineCrossActivityUpdateNotify);
		}

		// Token: 0x0600CE4A RID: 52810 RVA: 0x001E6351 File Offset: 0x001E4551
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LineCrossActivityUpdateNotify other)
		{
			return other != null && (other == this || (this.challenges_.Equals(other.challenges_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CE4B RID: 52811 RVA: 0x001E6384 File Offset: 0x001E4584
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

		// Token: 0x0600CE4C RID: 52812 RVA: 0x001E63B8 File Offset: 0x001E45B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CE4D RID: 52813 RVA: 0x001E63C5 File Offset: 0x001E45C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CE4E RID: 52814 RVA: 0x001E63CE File Offset: 0x001E45CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.challenges_.WriteTo(ref output, LineCrossActivityUpdateNotify._repeated_challenges_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CE4F RID: 52815 RVA: 0x001E63F8 File Offset: 0x001E45F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.challenges_.CalculateSize(LineCrossActivityUpdateNotify._repeated_challenges_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CE50 RID: 52816 RVA: 0x001E6431 File Offset: 0x001E4631
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LineCrossActivityUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.challenges_.Add(other.challenges_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CE51 RID: 52817 RVA: 0x001E645F File Offset: 0x001E465F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CE52 RID: 52818 RVA: 0x001E6468 File Offset: 0x001E4668
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.challenges_.AddEntriesFrom(ref input, LineCrossActivityUpdateNotify._repeated_challenges_codec);
				}
			}
		}

		// Token: 0x04005730 RID: 22320
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005731 RID: 22321
		public const int ChallengesFieldNumber = 5;

		// Token: 0x04005732 RID: 22322
		private static readonly FieldCodec<LineCrossChallengeData> _repeated_challenges_codec = FieldCodec.ForMessage<LineCrossChallengeData>(42U, LineCrossChallengeData.Parser);

		// Token: 0x04005733 RID: 22323
		private readonly RepeatedField<LineCrossChallengeData> challenges_ = new RepeatedField<LineCrossChallengeData>();
	}
}
