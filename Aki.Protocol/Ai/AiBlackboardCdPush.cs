using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x020016A4 RID: 5796
	[NetMessage(EMessageId.AiBlackboardCdPush)]
	public sealed class AiBlackboardCdPush : IMessage<AiBlackboardCdPush>, IMessage, IEquatable<AiBlackboardCdPush>, IDeepCloneable<AiBlackboardCdPush>, IBufferMessage
	{
		// Token: 0x0601D0B7 RID: 118967 RVA: 0x004405D6 File Offset: 0x0043E7D6
		[NullableContext(1)]
		public static AiBlackboardCdPush Create()
		{
			return new AiBlackboardCdPush();
		}

		// Token: 0x1700628F RID: 25231
		// (get) Token: 0x0601D0B8 RID: 118968 RVA: 0x004405DD File Offset: 0x0043E7DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006290 RID: 25232
		// (get) Token: 0x0601D0B9 RID: 118969 RVA: 0x004405E0 File Offset: 0x0043E7E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AiBlackboardCdPush.Descriptor;
			}
		}

		// Token: 0x0601D0BA RID: 118970 RVA: 0x004405E7 File Offset: 0x0043E7E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardCdPush()
		{
		}

		// Token: 0x0601D0BB RID: 118971 RVA: 0x00440605 File Offset: 0x0043E805
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardCdPush(AiBlackboardCdPush other) : this()
		{
			this.aiBlackboardCdModify_ = other.aiBlackboardCdModify_.Clone();
			this.aiBlackboardCdComplete_ = other.aiBlackboardCdComplete_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D0BC RID: 118972 RVA: 0x00440640 File Offset: 0x0043E840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardCdPush Clone()
		{
			return new AiBlackboardCdPush(this);
		}

		// Token: 0x17006291 RID: 25233
		// (get) Token: 0x0601D0BD RID: 118973 RVA: 0x00440648 File Offset: 0x0043E848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Int2Long> AiBlackboardCdModify
		{
			get
			{
				return this.aiBlackboardCdModify_;
			}
		}

		// Token: 0x17006292 RID: 25234
		// (get) Token: 0x0601D0BE RID: 118974 RVA: 0x00440650 File Offset: 0x0043E850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Int2Bool> AiBlackboardCdComplete
		{
			get
			{
				return this.aiBlackboardCdComplete_;
			}
		}

		// Token: 0x0601D0BF RID: 118975 RVA: 0x00440658 File Offset: 0x0043E858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AiBlackboardCdPush);
		}

		// Token: 0x0601D0C0 RID: 118976 RVA: 0x00440668 File Offset: 0x0043E868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AiBlackboardCdPush other)
		{
			return other != null && (other == this || (this.aiBlackboardCdModify_.Equals(other.aiBlackboardCdModify_) && this.aiBlackboardCdComplete_.Equals(other.aiBlackboardCdComplete_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D0C1 RID: 118977 RVA: 0x004406BC File Offset: 0x0043E8BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.aiBlackboardCdModify_.GetHashCode();
			num ^= this.aiBlackboardCdComplete_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D0C2 RID: 118978 RVA: 0x004406FE File Offset: 0x0043E8FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D0C3 RID: 118979 RVA: 0x0044070B File Offset: 0x0043E90B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D0C4 RID: 118980 RVA: 0x00440714 File Offset: 0x0043E914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.aiBlackboardCdComplete_.WriteTo(ref output, AiBlackboardCdPush._repeated_aiBlackboardCdComplete_codec);
			this.aiBlackboardCdModify_.WriteTo(ref output, AiBlackboardCdPush._repeated_aiBlackboardCdModify_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D0C5 RID: 118981 RVA: 0x0044074C File Offset: 0x0043E94C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.aiBlackboardCdModify_.CalculateSize(AiBlackboardCdPush._repeated_aiBlackboardCdModify_codec);
			num += this.aiBlackboardCdComplete_.CalculateSize(AiBlackboardCdPush._repeated_aiBlackboardCdComplete_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D0C6 RID: 118982 RVA: 0x00440798 File Offset: 0x0043E998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AiBlackboardCdPush other)
		{
			if (other == null)
			{
				return;
			}
			this.aiBlackboardCdModify_.Add(other.aiBlackboardCdModify_);
			this.aiBlackboardCdComplete_.Add(other.aiBlackboardCdComplete_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D0C7 RID: 118983 RVA: 0x004407D7 File Offset: 0x0043E9D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D0C8 RID: 118984 RVA: 0x004407E0 File Offset: 0x0043E9E0
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
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.aiBlackboardCdModify_.AddEntriesFrom(ref input, AiBlackboardCdPush._repeated_aiBlackboardCdModify_codec);
					}
				}
				else
				{
					this.aiBlackboardCdComplete_.AddEntriesFrom(ref input, AiBlackboardCdPush._repeated_aiBlackboardCdComplete_codec);
				}
			}
		}

		// Token: 0x0400C40C RID: 50188
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C40D RID: 50189
		public const int AiBlackboardCdModifyFieldNumber = 15;

		// Token: 0x0400C40E RID: 50190
		private static readonly FieldCodec<Int2Long> _repeated_aiBlackboardCdModify_codec = FieldCodec.ForMessage<Int2Long>(122U, Int2Long.Parser);

		// Token: 0x0400C40F RID: 50191
		private readonly RepeatedField<Int2Long> aiBlackboardCdModify_ = new RepeatedField<Int2Long>();

		// Token: 0x0400C410 RID: 50192
		public const int AiBlackboardCdCompleteFieldNumber = 3;

		// Token: 0x0400C411 RID: 50193
		private static readonly FieldCodec<Int2Bool> _repeated_aiBlackboardCdComplete_codec = FieldCodec.ForMessage<Int2Bool>(26U, Int2Bool.Parser);

		// Token: 0x0400C412 RID: 50194
		private readonly RepeatedField<Int2Bool> aiBlackboardCdComplete_ = new RepeatedField<Int2Bool>();
	}
}
