using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000711 RID: 1809
	[NetMessage(EMessageId.GuideGroupResetNotify)]
	public sealed class GuideGroupResetNotify : IMessage<GuideGroupResetNotify>, IMessage, IEquatable<GuideGroupResetNotify>, IDeepCloneable<GuideGroupResetNotify>, IBufferMessage
	{
		// Token: 0x0600A4D2 RID: 42194 RVA: 0x0018E117 File Offset: 0x0018C317
		[NullableContext(1)]
		public static GuideGroupResetNotify Create()
		{
			return new GuideGroupResetNotify();
		}

		// Token: 0x17002125 RID: 8485
		// (get) Token: 0x0600A4D3 RID: 42195 RVA: 0x0018E11E File Offset: 0x0018C31E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002126 RID: 8486
		// (get) Token: 0x0600A4D4 RID: 42196 RVA: 0x0018E121 File Offset: 0x0018C321
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GuideGroupResetNotify.Descriptor;
			}
		}

		// Token: 0x0600A4D5 RID: 42197 RVA: 0x0018E128 File Offset: 0x0018C328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideGroupResetNotify()
		{
		}

		// Token: 0x0600A4D6 RID: 42198 RVA: 0x0018E13B File Offset: 0x0018C33B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideGroupResetNotify(GuideGroupResetNotify other) : this()
		{
			this.groupIds_ = other.groupIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A4D7 RID: 42199 RVA: 0x0018E165 File Offset: 0x0018C365
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideGroupResetNotify Clone()
		{
			return new GuideGroupResetNotify(this);
		}

		// Token: 0x17002127 RID: 8487
		// (get) Token: 0x0600A4D8 RID: 42200 RVA: 0x0018E16D File Offset: 0x0018C36D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> GroupIds
		{
			get
			{
				return this.groupIds_;
			}
		}

		// Token: 0x0600A4D9 RID: 42201 RVA: 0x0018E175 File Offset: 0x0018C375
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GuideGroupResetNotify);
		}

		// Token: 0x0600A4DA RID: 42202 RVA: 0x0018E183 File Offset: 0x0018C383
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GuideGroupResetNotify other)
		{
			return other != null && (other == this || (this.groupIds_.Equals(other.groupIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A4DB RID: 42203 RVA: 0x0018E1B8 File Offset: 0x0018C3B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.groupIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A4DC RID: 42204 RVA: 0x0018E1EC File Offset: 0x0018C3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A4DD RID: 42205 RVA: 0x0018E1F9 File Offset: 0x0018C3F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A4DE RID: 42206 RVA: 0x0018E202 File Offset: 0x0018C402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.groupIds_.WriteTo(ref output, GuideGroupResetNotify._repeated_groupIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A4DF RID: 42207 RVA: 0x0018E22C File Offset: 0x0018C42C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.groupIds_.CalculateSize(GuideGroupResetNotify._repeated_groupIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A4E0 RID: 42208 RVA: 0x0018E265 File Offset: 0x0018C465
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GuideGroupResetNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.groupIds_.Add(other.groupIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A4E1 RID: 42209 RVA: 0x0018E293 File Offset: 0x0018C493
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A4E2 RID: 42210 RVA: 0x0018E29C File Offset: 0x0018C49C
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
				if (num != 64U && num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.groupIds_.AddEntriesFrom(ref input, GuideGroupResetNotify._repeated_groupIds_codec);
				}
			}
		}

		// Token: 0x04004C42 RID: 19522
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C43 RID: 19523
		public const int GroupIdsFieldNumber = 8;

		// Token: 0x04004C44 RID: 19524
		private static readonly FieldCodec<int> _repeated_groupIds_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04004C45 RID: 19525
		private readonly RepeatedField<int> groupIds_ = new RepeatedField<int>();
	}
}
