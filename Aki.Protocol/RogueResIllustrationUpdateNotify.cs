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
	[NetMessage(EMessageId.RogueResIllustrationUpdateNotify)]
	public sealed class RogueResIllustrationUpdateNotify : IMessage<RogueResIllustrationUpdateNotify>, IMessage, IEquatable<RogueResIllustrationUpdateNotify>, IDeepCloneable<RogueResIllustrationUpdateNotify>, IBufferMessage
	{
		// Token: 0x06015C6B RID: 89195 RVA: 0x0032975B File Offset: 0x0032795B
		[NullableContext(1)]
		public static RogueResIllustrationUpdateNotify Create()
		{
			return new RogueResIllustrationUpdateNotify();
		}

		// Token: 0x170048AC RID: 18604
		// (get) Token: 0x06015C6C RID: 89196 RVA: 0x00329762 File Offset: 0x00327962
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170048AD RID: 18605
		// (get) Token: 0x06015C6D RID: 89197 RVA: 0x00329765 File Offset: 0x00327965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResIllustrationUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06015C6E RID: 89198 RVA: 0x0032976C File Offset: 0x0032796C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResIllustrationUpdateNotify()
		{
		}

		// Token: 0x06015C6F RID: 89199 RVA: 0x0032977F File Offset: 0x0032797F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResIllustrationUpdateNotify(RogueResIllustrationUpdateNotify other) : this()
		{
			this.dict_ = other.dict_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015C70 RID: 89200 RVA: 0x003297A9 File Offset: 0x003279A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResIllustrationUpdateNotify Clone()
		{
			return new RogueResIllustrationUpdateNotify(this);
		}

		// Token: 0x170048AE RID: 18606
		// (get) Token: 0x06015C71 RID: 89201 RVA: 0x003297B1 File Offset: 0x003279B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, SignState> Dict
		{
			get
			{
				return this.dict_;
			}
		}

		// Token: 0x06015C72 RID: 89202 RVA: 0x003297B9 File Offset: 0x003279B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResIllustrationUpdateNotify);
		}

		// Token: 0x06015C73 RID: 89203 RVA: 0x003297C7 File Offset: 0x003279C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResIllustrationUpdateNotify other)
		{
			return other != null && (other == this || (this.Dict.Equals(other.Dict) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015C74 RID: 89204 RVA: 0x003297FC File Offset: 0x003279FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.Dict.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015C75 RID: 89205 RVA: 0x00329830 File Offset: 0x00327A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015C76 RID: 89206 RVA: 0x0032983D File Offset: 0x00327A3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015C77 RID: 89207 RVA: 0x00329846 File Offset: 0x00327A46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dict_.WriteTo(ref output, RogueResIllustrationUpdateNotify._map_dict_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015C78 RID: 89208 RVA: 0x00329870 File Offset: 0x00327A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.dict_.CalculateSize(RogueResIllustrationUpdateNotify._map_dict_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015C79 RID: 89209 RVA: 0x003298A9 File Offset: 0x00327AA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResIllustrationUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.dict_.MergeFrom(other.dict_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015C7A RID: 89210 RVA: 0x003298D7 File Offset: 0x00327AD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015C7B RID: 89211 RVA: 0x003298E0 File Offset: 0x00327AE0
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.dict_.AddEntriesFrom(ref input, RogueResIllustrationUpdateNotify._map_dict_codec);
				}
			}
		}

		// Token: 0x040082AA RID: 33450
		private UnknownFieldSet _unknownFields;

		// Token: 0x040082AB RID: 33451
		public const int DictFieldNumber = 2;

		// Token: 0x040082AC RID: 33452
		private static readonly MapField<int, SignState>.Codec _map_dict_codec = new MapField<int, SignState>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForEnum<SignState>(16U, (SignState x) => (int)x, (int x) => (SignState)x, SignState.Lock), 18U);

		// Token: 0x040082AD RID: 33453
		private readonly MapField<int, SignState> dict_ = new MapField<int, SignState>();
	}
}
