using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FEA RID: 4074
	[NetMessage(EMessageId.RogueResOpDataNotify)]
	public sealed class RogueResOpDataNotify : IMessage<RogueResOpDataNotify>, IMessage, IEquatable<RogueResOpDataNotify>, IDeepCloneable<RogueResOpDataNotify>, IBufferMessage
	{
		// Token: 0x06015CF3 RID: 89331 RVA: 0x0032BFA5 File Offset: 0x0032A1A5
		[NullableContext(1)]
		public static RogueResOpDataNotify Create()
		{
			return new RogueResOpDataNotify();
		}

		// Token: 0x170048DA RID: 18650
		// (get) Token: 0x06015CF4 RID: 89332 RVA: 0x0032BFAC File Offset: 0x0032A1AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170048DB RID: 18651
		// (get) Token: 0x06015CF5 RID: 89333 RVA: 0x0032BFAF File Offset: 0x0032A1AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResOpDataNotify.Descriptor;
			}
		}

		// Token: 0x06015CF6 RID: 89334 RVA: 0x0032BFB6 File Offset: 0x0032A1B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResOpDataNotify()
		{
		}

		// Token: 0x06015CF7 RID: 89335 RVA: 0x0032BFC9 File Offset: 0x0032A1C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResOpDataNotify(RogueResOpDataNotify other) : this()
		{
			this.rogueResOpDatas_ = other.rogueResOpDatas_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015CF8 RID: 89336 RVA: 0x0032BFF3 File Offset: 0x0032A1F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResOpDataNotify Clone()
		{
			return new RogueResOpDataNotify(this);
		}

		// Token: 0x170048DC RID: 18652
		// (get) Token: 0x06015CF9 RID: 89337 RVA: 0x0032BFFB File Offset: 0x0032A1FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueResOpData> RogueResOpDatas
		{
			get
			{
				return this.rogueResOpDatas_;
			}
		}

		// Token: 0x06015CFA RID: 89338 RVA: 0x0032C003 File Offset: 0x0032A203
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResOpDataNotify);
		}

		// Token: 0x06015CFB RID: 89339 RVA: 0x0032C011 File Offset: 0x0032A211
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResOpDataNotify other)
		{
			return other != null && (other == this || (this.rogueResOpDatas_.Equals(other.rogueResOpDatas_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015CFC RID: 89340 RVA: 0x0032C044 File Offset: 0x0032A244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.rogueResOpDatas_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015CFD RID: 89341 RVA: 0x0032C078 File Offset: 0x0032A278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015CFE RID: 89342 RVA: 0x0032C085 File Offset: 0x0032A285
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015CFF RID: 89343 RVA: 0x0032C08E File Offset: 0x0032A28E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rogueResOpDatas_.WriteTo(ref output, RogueResOpDataNotify._repeated_rogueResOpDatas_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015D00 RID: 89344 RVA: 0x0032C0B8 File Offset: 0x0032A2B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rogueResOpDatas_.CalculateSize(RogueResOpDataNotify._repeated_rogueResOpDatas_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015D01 RID: 89345 RVA: 0x0032C0F1 File Offset: 0x0032A2F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResOpDataNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.rogueResOpDatas_.Add(other.rogueResOpDatas_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015D02 RID: 89346 RVA: 0x0032C11F File Offset: 0x0032A31F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015D03 RID: 89347 RVA: 0x0032C128 File Offset: 0x0032A328
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rogueResOpDatas_.AddEntriesFrom(ref input, RogueResOpDataNotify._repeated_rogueResOpDatas_codec);
				}
			}
		}

		// Token: 0x04008350 RID: 33616
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008351 RID: 33617
		public const int RogueResOpDatasFieldNumber = 6;

		// Token: 0x04008352 RID: 33618
		private static readonly FieldCodec<RogueResOpData> _repeated_rogueResOpDatas_codec = FieldCodec.ForMessage<RogueResOpData>(50U, RogueResOpData.Parser);

		// Token: 0x04008353 RID: 33619
		private readonly RepeatedField<RogueResOpData> rogueResOpDatas_ = new RepeatedField<RogueResOpData>();
	}
}
