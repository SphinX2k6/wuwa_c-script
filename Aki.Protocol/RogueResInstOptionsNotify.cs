using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FEC RID: 4076
	[NetMessage(EMessageId.RogueResInstOptionsNotify)]
	public sealed class RogueResInstOptionsNotify : IMessage<RogueResInstOptionsNotify>, IMessage, IEquatable<RogueResInstOptionsNotify>, IDeepCloneable<RogueResInstOptionsNotify>, IBufferMessage
	{
		// Token: 0x06015CB6 RID: 89270 RVA: 0x0032AA1A File Offset: 0x00328C1A
		[NullableContext(1)]
		public static RogueResInstOptionsNotify Create()
		{
			return new RogueResInstOptionsNotify();
		}

		// Token: 0x170048C6 RID: 18630
		// (get) Token: 0x06015CB7 RID: 89271 RVA: 0x0032AA21 File Offset: 0x00328C21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170048C7 RID: 18631
		// (get) Token: 0x06015CB8 RID: 89272 RVA: 0x0032AA24 File Offset: 0x00328C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResInstOptionsNotify.Descriptor;
			}
		}

		// Token: 0x06015CB9 RID: 89273 RVA: 0x0032AA2B File Offset: 0x00328C2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResInstOptionsNotify()
		{
		}

		// Token: 0x06015CBA RID: 89274 RVA: 0x0032AA3E File Offset: 0x00328C3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResInstOptionsNotify(RogueResInstOptionsNotify other) : this()
		{
			this.rogueResOptionDict_ = other.rogueResOptionDict_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015CBB RID: 89275 RVA: 0x0032AA68 File Offset: 0x00328C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResInstOptionsNotify Clone()
		{
			return new RogueResInstOptionsNotify(this);
		}

		// Token: 0x170048C8 RID: 18632
		// (get) Token: 0x06015CBC RID: 89276 RVA: 0x0032AA70 File Offset: 0x00328C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, RogueResOption> RogueResOptionDict
		{
			get
			{
				return this.rogueResOptionDict_;
			}
		}

		// Token: 0x06015CBD RID: 89277 RVA: 0x0032AA78 File Offset: 0x00328C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResInstOptionsNotify);
		}

		// Token: 0x06015CBE RID: 89278 RVA: 0x0032AA86 File Offset: 0x00328C86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResInstOptionsNotify other)
		{
			return other != null && (other == this || (this.RogueResOptionDict.Equals(other.RogueResOptionDict) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015CBF RID: 89279 RVA: 0x0032AABC File Offset: 0x00328CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.RogueResOptionDict.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015CC0 RID: 89280 RVA: 0x0032AAF0 File Offset: 0x00328CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015CC1 RID: 89281 RVA: 0x0032AAFD File Offset: 0x00328CFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015CC2 RID: 89282 RVA: 0x0032AB06 File Offset: 0x00328D06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rogueResOptionDict_.WriteTo(ref output, RogueResInstOptionsNotify._map_rogueResOptionDict_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015CC3 RID: 89283 RVA: 0x0032AB30 File Offset: 0x00328D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rogueResOptionDict_.CalculateSize(RogueResInstOptionsNotify._map_rogueResOptionDict_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015CC4 RID: 89284 RVA: 0x0032AB69 File Offset: 0x00328D69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResInstOptionsNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.rogueResOptionDict_.MergeFrom(other.rogueResOptionDict_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015CC5 RID: 89285 RVA: 0x0032AB97 File Offset: 0x00328D97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015CC6 RID: 89286 RVA: 0x0032ABA0 File Offset: 0x00328DA0
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
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rogueResOptionDict_.AddEntriesFrom(ref input, RogueResInstOptionsNotify._map_rogueResOptionDict_codec);
				}
			}
		}

		// Token: 0x040082DB RID: 33499
		private UnknownFieldSet _unknownFields;

		// Token: 0x040082DC RID: 33500
		public const int RogueResOptionDictFieldNumber = 3;

		// Token: 0x040082DD RID: 33501
		private static readonly MapField<int, RogueResOption>.Codec _map_rogueResOptionDict_codec = new MapField<int, RogueResOption>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<RogueResOption>(18U, RogueResOption.Parser), 26U);

		// Token: 0x040082DE RID: 33502
		private readonly MapField<int, RogueResOption> rogueResOptionDict_ = new MapField<int, RogueResOption>();
	}
}
