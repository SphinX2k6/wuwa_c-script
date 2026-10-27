using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012B9 RID: 4793
	public sealed class SunSpiritGearComponentPb : IMessage<SunSpiritGearComponentPb>, IMessage, IEquatable<SunSpiritGearComponentPb>, IDeepCloneable<SunSpiritGearComponentPb>, IBufferMessage
	{
		// Token: 0x06019814 RID: 104468 RVA: 0x003B4F64 File Offset: 0x003B3164
		[NullableContext(1)]
		public static SunSpiritGearComponentPb Create()
		{
			return new SunSpiritGearComponentPb();
		}

		// Token: 0x17005603 RID: 22019
		// (get) Token: 0x06019815 RID: 104469 RVA: 0x003B4F6B File Offset: 0x003B316B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005604 RID: 22020
		// (get) Token: 0x06019816 RID: 104470 RVA: 0x003B4F6E File Offset: 0x003B316E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SunSpiritGearComponentPb.Descriptor;
			}
		}

		// Token: 0x06019817 RID: 104471 RVA: 0x003B4F75 File Offset: 0x003B3175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritGearComponentPb()
		{
		}

		// Token: 0x06019818 RID: 104472 RVA: 0x003B4F88 File Offset: 0x003B3188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritGearComponentPb(SunSpiritGearComponentPb other) : this()
		{
			this.takeUpInfo_ = other.takeUpInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019819 RID: 104473 RVA: 0x003B4FB2 File Offset: 0x003B31B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritGearComponentPb Clone()
		{
			return new SunSpiritGearComponentPb(this);
		}

		// Token: 0x17005605 RID: 22021
		// (get) Token: 0x0601981A RID: 104474 RVA: 0x003B4FBA File Offset: 0x003B31BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SunSpiritPb> TakeUpInfo
		{
			get
			{
				return this.takeUpInfo_;
			}
		}

		// Token: 0x0601981B RID: 104475 RVA: 0x003B4FC2 File Offset: 0x003B31C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SunSpiritGearComponentPb);
		}

		// Token: 0x0601981C RID: 104476 RVA: 0x003B4FD0 File Offset: 0x003B31D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SunSpiritGearComponentPb other)
		{
			return other != null && (other == this || (this.takeUpInfo_.Equals(other.takeUpInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601981D RID: 104477 RVA: 0x003B5004 File Offset: 0x003B3204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.takeUpInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601981E RID: 104478 RVA: 0x003B5038 File Offset: 0x003B3238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601981F RID: 104479 RVA: 0x003B5045 File Offset: 0x003B3245
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019820 RID: 104480 RVA: 0x003B504E File Offset: 0x003B324E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.takeUpInfo_.WriteTo(ref output, SunSpiritGearComponentPb._repeated_takeUpInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019821 RID: 104481 RVA: 0x003B5078 File Offset: 0x003B3278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.takeUpInfo_.CalculateSize(SunSpiritGearComponentPb._repeated_takeUpInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019822 RID: 104482 RVA: 0x003B50B1 File Offset: 0x003B32B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SunSpiritGearComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			this.takeUpInfo_.Add(other.takeUpInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019823 RID: 104483 RVA: 0x003B50DF File Offset: 0x003B32DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019824 RID: 104484 RVA: 0x003B50E8 File Offset: 0x003B32E8
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
					this.takeUpInfo_.AddEntriesFrom(ref input, SunSpiritGearComponentPb._repeated_takeUpInfo_codec);
				}
			}
		}

		// Token: 0x040095A3 RID: 38307
		private UnknownFieldSet _unknownFields;

		// Token: 0x040095A4 RID: 38308
		public const int TakeUpInfoFieldNumber = 1;

		// Token: 0x040095A5 RID: 38309
		private static readonly FieldCodec<SunSpiritPb> _repeated_takeUpInfo_codec = FieldCodec.ForMessage<SunSpiritPb>(10U, SunSpiritPb.Parser);

		// Token: 0x040095A6 RID: 38310
		private readonly RepeatedField<SunSpiritPb> takeUpInfo_ = new RepeatedField<SunSpiritPb>();
	}
}
