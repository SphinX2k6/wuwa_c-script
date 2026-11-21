using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001328 RID: 4904
	public sealed class SunSpiritGearComponentPb : IMessage<SunSpiritGearComponentPb>, IMessage, IEquatable<SunSpiritGearComponentPb>, IDeepCloneable<SunSpiritGearComponentPb>, IBufferMessage
	{
		// Token: 0x0601A24A RID: 107082 RVA: 0x003CF6A0 File Offset: 0x003CD8A0
		[NullableContext(1)]
		public static SunSpiritGearComponentPb Create()
		{
			return new SunSpiritGearComponentPb();
		}

		// Token: 0x17005884 RID: 22660
		// (get) Token: 0x0601A24B RID: 107083 RVA: 0x003CF6A7 File Offset: 0x003CD8A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005885 RID: 22661
		// (get) Token: 0x0601A24C RID: 107084 RVA: 0x003CF6AA File Offset: 0x003CD8AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SunSpiritGearComponentPb.Descriptor;
			}
		}

		// Token: 0x0601A24D RID: 107085 RVA: 0x003CF6B1 File Offset: 0x003CD8B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritGearComponentPb()
		{
		}

		// Token: 0x0601A24E RID: 107086 RVA: 0x003CF6C4 File Offset: 0x003CD8C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritGearComponentPb(SunSpiritGearComponentPb other) : this()
		{
			this.takeUpInfo_ = other.takeUpInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A24F RID: 107087 RVA: 0x003CF6EE File Offset: 0x003CD8EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritGearComponentPb Clone()
		{
			return new SunSpiritGearComponentPb(this);
		}

		// Token: 0x17005886 RID: 22662
		// (get) Token: 0x0601A250 RID: 107088 RVA: 0x003CF6F6 File Offset: 0x003CD8F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SunSpiritPb> TakeUpInfo
		{
			get
			{
				return this.takeUpInfo_;
			}
		}

		// Token: 0x0601A251 RID: 107089 RVA: 0x003CF6FE File Offset: 0x003CD8FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SunSpiritGearComponentPb);
		}

		// Token: 0x0601A252 RID: 107090 RVA: 0x003CF70C File Offset: 0x003CD90C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SunSpiritGearComponentPb other)
		{
			return other != null && (other == this || (this.takeUpInfo_.Equals(other.takeUpInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A253 RID: 107091 RVA: 0x003CF740 File Offset: 0x003CD940
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

		// Token: 0x0601A254 RID: 107092 RVA: 0x003CF774 File Offset: 0x003CD974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A255 RID: 107093 RVA: 0x003CF781 File Offset: 0x003CD981
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A256 RID: 107094 RVA: 0x003CF78A File Offset: 0x003CD98A
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

		// Token: 0x0601A257 RID: 107095 RVA: 0x003CF7B4 File Offset: 0x003CD9B4
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

		// Token: 0x0601A258 RID: 107096 RVA: 0x003CF7ED File Offset: 0x003CD9ED
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

		// Token: 0x0601A259 RID: 107097 RVA: 0x003CF81B File Offset: 0x003CDA1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A25A RID: 107098 RVA: 0x003CF824 File Offset: 0x003CDA24
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

		// Token: 0x040099CD RID: 39373
		private UnknownFieldSet _unknownFields;

		// Token: 0x040099CE RID: 39374
		public const int TakeUpInfoFieldNumber = 1;

		// Token: 0x040099CF RID: 39375
		private static readonly FieldCodec<SunSpiritPb> _repeated_takeUpInfo_codec = FieldCodec.ForMessage<SunSpiritPb>(10U, SunSpiritPb.Parser);

		// Token: 0x040099D0 RID: 39376
		private readonly RepeatedField<SunSpiritPb> takeUpInfo_ = new RepeatedField<SunSpiritPb>();
	}
}
