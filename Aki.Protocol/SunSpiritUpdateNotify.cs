using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200132C RID: 4908
	[NetMessage(EMessageId.SunSpiritUpdateNotify)]
	public sealed class SunSpiritUpdateNotify : IMessage<SunSpiritUpdateNotify>, IMessage, IEquatable<SunSpiritUpdateNotify>, IDeepCloneable<SunSpiritUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601A29A RID: 107162 RVA: 0x003D00A7 File Offset: 0x003CE2A7
		[NullableContext(1)]
		public static SunSpiritUpdateNotify Create()
		{
			return new SunSpiritUpdateNotify();
		}

		// Token: 0x17005894 RID: 22676
		// (get) Token: 0x0601A29B RID: 107163 RVA: 0x003D00AE File Offset: 0x003CE2AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005895 RID: 22677
		// (get) Token: 0x0601A29C RID: 107164 RVA: 0x003D00B1 File Offset: 0x003CE2B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SunSpiritUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601A29D RID: 107165 RVA: 0x003D00B8 File Offset: 0x003CE2B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritUpdateNotify()
		{
		}

		// Token: 0x0601A29E RID: 107166 RVA: 0x003D00CB File Offset: 0x003CE2CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritUpdateNotify(SunSpiritUpdateNotify other) : this()
		{
			this.spiritInfo_ = other.spiritInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A29F RID: 107167 RVA: 0x003D00F5 File Offset: 0x003CE2F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritUpdateNotify Clone()
		{
			return new SunSpiritUpdateNotify(this);
		}

		// Token: 0x17005896 RID: 22678
		// (get) Token: 0x0601A2A0 RID: 107168 RVA: 0x003D00FD File Offset: 0x003CE2FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SunSpiritPb> SpiritInfo
		{
			get
			{
				return this.spiritInfo_;
			}
		}

		// Token: 0x0601A2A1 RID: 107169 RVA: 0x003D0105 File Offset: 0x003CE305
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SunSpiritUpdateNotify);
		}

		// Token: 0x0601A2A2 RID: 107170 RVA: 0x003D0113 File Offset: 0x003CE313
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SunSpiritUpdateNotify other)
		{
			return other != null && (other == this || (this.spiritInfo_.Equals(other.spiritInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A2A3 RID: 107171 RVA: 0x003D0148 File Offset: 0x003CE348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.spiritInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A2A4 RID: 107172 RVA: 0x003D017C File Offset: 0x003CE37C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A2A5 RID: 107173 RVA: 0x003D0189 File Offset: 0x003CE389
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A2A6 RID: 107174 RVA: 0x003D0192 File Offset: 0x003CE392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.spiritInfo_.WriteTo(ref output, SunSpiritUpdateNotify._repeated_spiritInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A2A7 RID: 107175 RVA: 0x003D01BC File Offset: 0x003CE3BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.spiritInfo_.CalculateSize(SunSpiritUpdateNotify._repeated_spiritInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A2A8 RID: 107176 RVA: 0x003D01F5 File Offset: 0x003CE3F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SunSpiritUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.spiritInfo_.Add(other.spiritInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A2A9 RID: 107177 RVA: 0x003D0223 File Offset: 0x003CE423
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A2AA RID: 107178 RVA: 0x003D022C File Offset: 0x003CE42C
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
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.spiritInfo_.AddEntriesFrom(ref input, SunSpiritUpdateNotify._repeated_spiritInfo_codec);
				}
			}
		}

		// Token: 0x040099E2 RID: 39394
		private UnknownFieldSet _unknownFields;

		// Token: 0x040099E3 RID: 39395
		public const int SpiritInfoFieldNumber = 8;

		// Token: 0x040099E4 RID: 39396
		private static readonly FieldCodec<SunSpiritPb> _repeated_spiritInfo_codec = FieldCodec.ForMessage<SunSpiritPb>(66U, SunSpiritPb.Parser);

		// Token: 0x040099E5 RID: 39397
		private readonly RepeatedField<SunSpiritPb> spiritInfo_ = new RepeatedField<SunSpiritPb>();
	}
}
