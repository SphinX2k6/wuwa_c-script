using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001329 RID: 4905
	[NetMessage(EMessageId.SunSpiritListNotify)]
	public sealed class SunSpiritListNotify : IMessage<SunSpiritListNotify>, IMessage, IEquatable<SunSpiritListNotify>, IDeepCloneable<SunSpiritListNotify>, IBufferMessage
	{
		// Token: 0x0601A25C RID: 107100 RVA: 0x003CF881 File Offset: 0x003CDA81
		[NullableContext(1)]
		public static SunSpiritListNotify Create()
		{
			return new SunSpiritListNotify();
		}

		// Token: 0x17005887 RID: 22663
		// (get) Token: 0x0601A25D RID: 107101 RVA: 0x003CF888 File Offset: 0x003CDA88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005888 RID: 22664
		// (get) Token: 0x0601A25E RID: 107102 RVA: 0x003CF88B File Offset: 0x003CDA8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SunSpiritListNotify.Descriptor;
			}
		}

		// Token: 0x0601A25F RID: 107103 RVA: 0x003CF892 File Offset: 0x003CDA92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritListNotify()
		{
		}

		// Token: 0x0601A260 RID: 107104 RVA: 0x003CF8A5 File Offset: 0x003CDAA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritListNotify(SunSpiritListNotify other) : this()
		{
			this.spiritInfo_ = other.spiritInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A261 RID: 107105 RVA: 0x003CF8CF File Offset: 0x003CDACF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritListNotify Clone()
		{
			return new SunSpiritListNotify(this);
		}

		// Token: 0x17005889 RID: 22665
		// (get) Token: 0x0601A262 RID: 107106 RVA: 0x003CF8D7 File Offset: 0x003CDAD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SunSpiritPb> SpiritInfo
		{
			get
			{
				return this.spiritInfo_;
			}
		}

		// Token: 0x0601A263 RID: 107107 RVA: 0x003CF8DF File Offset: 0x003CDADF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SunSpiritListNotify);
		}

		// Token: 0x0601A264 RID: 107108 RVA: 0x003CF8ED File Offset: 0x003CDAED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SunSpiritListNotify other)
		{
			return other != null && (other == this || (this.spiritInfo_.Equals(other.spiritInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A265 RID: 107109 RVA: 0x003CF920 File Offset: 0x003CDB20
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

		// Token: 0x0601A266 RID: 107110 RVA: 0x003CF954 File Offset: 0x003CDB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A267 RID: 107111 RVA: 0x003CF961 File Offset: 0x003CDB61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A268 RID: 107112 RVA: 0x003CF96A File Offset: 0x003CDB6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.spiritInfo_.WriteTo(ref output, SunSpiritListNotify._repeated_spiritInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A269 RID: 107113 RVA: 0x003CF994 File Offset: 0x003CDB94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.spiritInfo_.CalculateSize(SunSpiritListNotify._repeated_spiritInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A26A RID: 107114 RVA: 0x003CF9CD File Offset: 0x003CDBCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SunSpiritListNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.spiritInfo_.Add(other.spiritInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A26B RID: 107115 RVA: 0x003CF9FB File Offset: 0x003CDBFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A26C RID: 107116 RVA: 0x003CFA04 File Offset: 0x003CDC04
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.spiritInfo_.AddEntriesFrom(ref input, SunSpiritListNotify._repeated_spiritInfo_codec);
				}
			}
		}

		// Token: 0x040099D1 RID: 39377
		private UnknownFieldSet _unknownFields;

		// Token: 0x040099D2 RID: 39378
		public const int SpiritInfoFieldNumber = 11;

		// Token: 0x040099D3 RID: 39379
		private static readonly FieldCodec<SunSpiritPb> _repeated_spiritInfo_codec = FieldCodec.ForMessage<SunSpiritPb>(90U, SunSpiritPb.Parser);

		// Token: 0x040099D4 RID: 39380
		private readonly RepeatedField<SunSpiritPb> spiritInfo_ = new RepeatedField<SunSpiritPb>();
	}
}
