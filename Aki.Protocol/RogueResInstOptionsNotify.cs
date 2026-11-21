using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FDC RID: 4060
	[NetMessage(EMessageId.RogueResInstOptionsNotify)]
	public sealed class RogueResInstOptionsNotify : IMessage<RogueResInstOptionsNotify>, IMessage, IEquatable<RogueResInstOptionsNotify>, IDeepCloneable<RogueResInstOptionsNotify>, IBufferMessage
	{
		// Token: 0x06015BD1 RID: 89041 RVA: 0x00329357 File Offset: 0x00327557
		[NullableContext(1)]
		public static RogueResInstOptionsNotify Create()
		{
			return new RogueResInstOptionsNotify();
		}

		// Token: 0x1700489C RID: 18588
		// (get) Token: 0x06015BD2 RID: 89042 RVA: 0x0032935E File Offset: 0x0032755E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700489D RID: 18589
		// (get) Token: 0x06015BD3 RID: 89043 RVA: 0x00329361 File Offset: 0x00327561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResInstOptionsNotify.Descriptor;
			}
		}

		// Token: 0x06015BD4 RID: 89044 RVA: 0x00329368 File Offset: 0x00327568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResInstOptionsNotify()
		{
		}

		// Token: 0x06015BD5 RID: 89045 RVA: 0x0032937B File Offset: 0x0032757B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResInstOptionsNotify(RogueResInstOptionsNotify other) : this()
		{
			this.rogueResOptionDict_ = other.rogueResOptionDict_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015BD6 RID: 89046 RVA: 0x003293A5 File Offset: 0x003275A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResInstOptionsNotify Clone()
		{
			return new RogueResInstOptionsNotify(this);
		}

		// Token: 0x1700489E RID: 18590
		// (get) Token: 0x06015BD7 RID: 89047 RVA: 0x003293AD File Offset: 0x003275AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, RogueResOption> RogueResOptionDict
		{
			get
			{
				return this.rogueResOptionDict_;
			}
		}

		// Token: 0x06015BD8 RID: 89048 RVA: 0x003293B5 File Offset: 0x003275B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResInstOptionsNotify);
		}

		// Token: 0x06015BD9 RID: 89049 RVA: 0x003293C3 File Offset: 0x003275C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResInstOptionsNotify other)
		{
			return other != null && (other == this || (this.RogueResOptionDict.Equals(other.RogueResOptionDict) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015BDA RID: 89050 RVA: 0x003293F8 File Offset: 0x003275F8
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

		// Token: 0x06015BDB RID: 89051 RVA: 0x0032942C File Offset: 0x0032762C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015BDC RID: 89052 RVA: 0x00329439 File Offset: 0x00327639
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015BDD RID: 89053 RVA: 0x00329442 File Offset: 0x00327642
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

		// Token: 0x06015BDE RID: 89054 RVA: 0x0032946C File Offset: 0x0032766C
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

		// Token: 0x06015BDF RID: 89055 RVA: 0x003294A5 File Offset: 0x003276A5
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

		// Token: 0x06015BE0 RID: 89056 RVA: 0x003294D3 File Offset: 0x003276D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015BE1 RID: 89057 RVA: 0x003294DC File Offset: 0x003276DC
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rogueResOptionDict_.AddEntriesFrom(ref input, RogueResInstOptionsNotify._map_rogueResOptionDict_codec);
				}
			}
		}

		// Token: 0x04008305 RID: 33541
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008306 RID: 33542
		public const int RogueResOptionDictFieldNumber = 10;

		// Token: 0x04008307 RID: 33543
		private static readonly MapField<int, RogueResOption>.Codec _map_rogueResOptionDict_codec = new MapField<int, RogueResOption>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<RogueResOption>(18U, RogueResOption.Parser), 82U);

		// Token: 0x04008308 RID: 33544
		private readonly MapField<int, RogueResOption> rogueResOptionDict_ = new MapField<int, RogueResOption>();
	}
}
