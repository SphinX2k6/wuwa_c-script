using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200135C RID: 4956
	[NetMessage(EMessageId.ThemeWorldScoreRequest)]
	public sealed class ThemeWorldScoreRequest : IMessage<ThemeWorldScoreRequest>, IMessage, IEquatable<ThemeWorldScoreRequest>, IDeepCloneable<ThemeWorldScoreRequest>, IBufferMessage
	{
		// Token: 0x0601A53F RID: 107839 RVA: 0x003D31CD File Offset: 0x003D13CD
		[NullableContext(1)]
		public static ThemeWorldScoreRequest Create()
		{
			return new ThemeWorldScoreRequest();
		}

		// Token: 0x170058D5 RID: 22741
		// (get) Token: 0x0601A540 RID: 107840 RVA: 0x003D31D4 File Offset: 0x003D13D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058D6 RID: 22742
		// (get) Token: 0x0601A541 RID: 107841 RVA: 0x003D31D7 File Offset: 0x003D13D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ThemeWorldScoreRequest.Descriptor;
			}
		}

		// Token: 0x0601A542 RID: 107842 RVA: 0x003D31DE File Offset: 0x003D13DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThemeWorldScoreRequest()
		{
		}

		// Token: 0x0601A543 RID: 107843 RVA: 0x003D31F1 File Offset: 0x003D13F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThemeWorldScoreRequest(ThemeWorldScoreRequest other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A544 RID: 107844 RVA: 0x003D321B File Offset: 0x003D141B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ThemeWorldScoreRequest Clone()
		{
			return new ThemeWorldScoreRequest(this);
		}

		// Token: 0x170058D7 RID: 22743
		// (get) Token: 0x0601A545 RID: 107845 RVA: 0x003D3223 File Offset: 0x003D1423
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x0601A546 RID: 107846 RVA: 0x003D322B File Offset: 0x003D142B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ThemeWorldScoreRequest);
		}

		// Token: 0x0601A547 RID: 107847 RVA: 0x003D3239 File Offset: 0x003D1439
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ThemeWorldScoreRequest other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A548 RID: 107848 RVA: 0x003D326C File Offset: 0x003D146C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ids_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A549 RID: 107849 RVA: 0x003D32A0 File Offset: 0x003D14A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A54A RID: 107850 RVA: 0x003D32AD File Offset: 0x003D14AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A54B RID: 107851 RVA: 0x003D32B6 File Offset: 0x003D14B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ids_.WriteTo(ref output, ThemeWorldScoreRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A54C RID: 107852 RVA: 0x003D32E0 File Offset: 0x003D14E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ids_.CalculateSize(ThemeWorldScoreRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A54D RID: 107853 RVA: 0x003D3319 File Offset: 0x003D1519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ThemeWorldScoreRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A54E RID: 107854 RVA: 0x003D3347 File Offset: 0x003D1547
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A54F RID: 107855 RVA: 0x003D3350 File Offset: 0x003D1550
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
				if (num != 24U && num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ids_.AddEntriesFrom(ref input, ThemeWorldScoreRequest._repeated_ids_codec);
				}
			}
		}

		// Token: 0x0400997E RID: 39294
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400997F RID: 39295
		public const int IdsFieldNumber = 3;

		// Token: 0x04009980 RID: 39296
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04009981 RID: 39297
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
