using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001288 RID: 4744
	public sealed class SquadPropComponentPb : IMessage<SquadPropComponentPb>, IMessage, IEquatable<SquadPropComponentPb>, IDeepCloneable<SquadPropComponentPb>, IBufferMessage
	{
		// Token: 0x0601942F RID: 103471 RVA: 0x003AC809 File Offset: 0x003AAA09
		[NullableContext(1)]
		public static SquadPropComponentPb Create()
		{
			return new SquadPropComponentPb();
		}

		// Token: 0x17005535 RID: 21813
		// (get) Token: 0x06019430 RID: 103472 RVA: 0x003AC810 File Offset: 0x003AAA10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005536 RID: 21814
		// (get) Token: 0x06019431 RID: 103473 RVA: 0x003AC813 File Offset: 0x003AAA13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SquadPropComponentPb.Descriptor;
			}
		}

		// Token: 0x06019432 RID: 103474 RVA: 0x003AC81A File Offset: 0x003AAA1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SquadPropComponentPb()
		{
		}

		// Token: 0x06019433 RID: 103475 RVA: 0x003AC82D File Offset: 0x003AAA2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SquadPropComponentPb(SquadPropComponentPb other) : this()
		{
			this.attributes_ = other.attributes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019434 RID: 103476 RVA: 0x003AC857 File Offset: 0x003AAA57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SquadPropComponentPb Clone()
		{
			return new SquadPropComponentPb(this);
		}

		// Token: 0x17005537 RID: 21815
		// (get) Token: 0x06019435 RID: 103477 RVA: 0x003AC85F File Offset: 0x003AAA5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GameplayAttributeData> Attributes
		{
			get
			{
				return this.attributes_;
			}
		}

		// Token: 0x06019436 RID: 103478 RVA: 0x003AC867 File Offset: 0x003AAA67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SquadPropComponentPb);
		}

		// Token: 0x06019437 RID: 103479 RVA: 0x003AC875 File Offset: 0x003AAA75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SquadPropComponentPb other)
		{
			return other != null && (other == this || (this.attributes_.Equals(other.attributes_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019438 RID: 103480 RVA: 0x003AC8A8 File Offset: 0x003AAAA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.attributes_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019439 RID: 103481 RVA: 0x003AC8DC File Offset: 0x003AAADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601943A RID: 103482 RVA: 0x003AC8E9 File Offset: 0x003AAAE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601943B RID: 103483 RVA: 0x003AC8F2 File Offset: 0x003AAAF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.attributes_.WriteTo(ref output, SquadPropComponentPb._repeated_attributes_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601943C RID: 103484 RVA: 0x003AC91C File Offset: 0x003AAB1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.attributes_.CalculateSize(SquadPropComponentPb._repeated_attributes_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601943D RID: 103485 RVA: 0x003AC955 File Offset: 0x003AAB55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SquadPropComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			this.attributes_.Add(other.attributes_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601943E RID: 103486 RVA: 0x003AC983 File Offset: 0x003AAB83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601943F RID: 103487 RVA: 0x003AC98C File Offset: 0x003AAB8C
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
					this.attributes_.AddEntriesFrom(ref input, SquadPropComponentPb._repeated_attributes_codec);
				}
			}
		}

		// Token: 0x0400948D RID: 38029
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400948E RID: 38030
		public const int AttributesFieldNumber = 1;

		// Token: 0x0400948F RID: 38031
		private static readonly FieldCodec<GameplayAttributeData> _repeated_attributes_codec = FieldCodec.ForMessage<GameplayAttributeData>(10U, GameplayAttributeData.Parser);

		// Token: 0x04009490 RID: 38032
		private readonly RepeatedField<GameplayAttributeData> attributes_ = new RepeatedField<GameplayAttributeData>();
	}
}
