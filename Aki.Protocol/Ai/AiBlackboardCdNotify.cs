using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x020016A3 RID: 5795
	[NetMessage(EMessageId.AiBlackboardCdNotify)]
	public sealed class AiBlackboardCdNotify : IMessage<AiBlackboardCdNotify>, IMessage, IEquatable<AiBlackboardCdNotify>, IDeepCloneable<AiBlackboardCdNotify>, IBufferMessage
	{
		// Token: 0x0601D0A3 RID: 118947 RVA: 0x00440275 File Offset: 0x0043E475
		[NullableContext(1)]
		public static AiBlackboardCdNotify Create()
		{
			return new AiBlackboardCdNotify();
		}

		// Token: 0x1700628A RID: 25226
		// (get) Token: 0x0601D0A4 RID: 118948 RVA: 0x0044027C File Offset: 0x0043E47C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700628B RID: 25227
		// (get) Token: 0x0601D0A5 RID: 118949 RVA: 0x0044027F File Offset: 0x0043E47F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AiBlackboardCdNotify.Descriptor;
			}
		}

		// Token: 0x0601D0A6 RID: 118950 RVA: 0x00440286 File Offset: 0x0043E486
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardCdNotify()
		{
		}

		// Token: 0x0601D0A7 RID: 118951 RVA: 0x004402B0 File Offset: 0x0043E4B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardCdNotify(AiBlackboardCdNotify other) : this()
		{
			this.aiBlackboardCdDel_ = other.aiBlackboardCdDel_.Clone();
			this.aiBlackboardCdModify_ = other.aiBlackboardCdModify_.Clone();
			this.aiBlackboardCdComplete_ = other.aiBlackboardCdComplete_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D0A8 RID: 118952 RVA: 0x00440307 File Offset: 0x0043E507
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardCdNotify Clone()
		{
			return new AiBlackboardCdNotify(this);
		}

		// Token: 0x1700628C RID: 25228
		// (get) Token: 0x0601D0A9 RID: 118953 RVA: 0x0044030F File Offset: 0x0043E50F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> AiBlackboardCdDel
		{
			get
			{
				return this.aiBlackboardCdDel_;
			}
		}

		// Token: 0x1700628D RID: 25229
		// (get) Token: 0x0601D0AA RID: 118954 RVA: 0x00440317 File Offset: 0x0043E517
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Int2Long> AiBlackboardCdModify
		{
			get
			{
				return this.aiBlackboardCdModify_;
			}
		}

		// Token: 0x1700628E RID: 25230
		// (get) Token: 0x0601D0AB RID: 118955 RVA: 0x0044031F File Offset: 0x0043E51F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Int2Bool> AiBlackboardCdComplete
		{
			get
			{
				return this.aiBlackboardCdComplete_;
			}
		}

		// Token: 0x0601D0AC RID: 118956 RVA: 0x00440327 File Offset: 0x0043E527
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AiBlackboardCdNotify);
		}

		// Token: 0x0601D0AD RID: 118957 RVA: 0x00440338 File Offset: 0x0043E538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AiBlackboardCdNotify other)
		{
			return other != null && (other == this || (this.aiBlackboardCdDel_.Equals(other.aiBlackboardCdDel_) && this.aiBlackboardCdModify_.Equals(other.aiBlackboardCdModify_) && this.aiBlackboardCdComplete_.Equals(other.aiBlackboardCdComplete_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D0AE RID: 118958 RVA: 0x004403A0 File Offset: 0x0043E5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.aiBlackboardCdDel_.GetHashCode();
			num ^= this.aiBlackboardCdModify_.GetHashCode();
			num ^= this.aiBlackboardCdComplete_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D0AF RID: 118959 RVA: 0x004403F0 File Offset: 0x0043E5F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D0B0 RID: 118960 RVA: 0x004403FD File Offset: 0x0043E5FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D0B1 RID: 118961 RVA: 0x00440408 File Offset: 0x0043E608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.aiBlackboardCdDel_.WriteTo(ref output, AiBlackboardCdNotify._repeated_aiBlackboardCdDel_codec);
			this.aiBlackboardCdComplete_.WriteTo(ref output, AiBlackboardCdNotify._repeated_aiBlackboardCdComplete_codec);
			this.aiBlackboardCdModify_.WriteTo(ref output, AiBlackboardCdNotify._repeated_aiBlackboardCdModify_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D0B2 RID: 118962 RVA: 0x0044045C File Offset: 0x0043E65C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.aiBlackboardCdDel_.CalculateSize(AiBlackboardCdNotify._repeated_aiBlackboardCdDel_codec);
			num += this.aiBlackboardCdModify_.CalculateSize(AiBlackboardCdNotify._repeated_aiBlackboardCdModify_codec);
			num += this.aiBlackboardCdComplete_.CalculateSize(AiBlackboardCdNotify._repeated_aiBlackboardCdComplete_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D0B3 RID: 118963 RVA: 0x004404BC File Offset: 0x0043E6BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AiBlackboardCdNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.aiBlackboardCdDel_.Add(other.aiBlackboardCdDel_);
			this.aiBlackboardCdModify_.Add(other.aiBlackboardCdModify_);
			this.aiBlackboardCdComplete_.Add(other.aiBlackboardCdComplete_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D0B4 RID: 118964 RVA: 0x00440517 File Offset: 0x0043E717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D0B5 RID: 118965 RVA: 0x00440520 File Offset: 0x0043E720
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
				if (num <= 82U)
				{
					if (num == 80U || num == 82U)
					{
						this.aiBlackboardCdDel_.AddEntriesFrom(ref input, AiBlackboardCdNotify._repeated_aiBlackboardCdDel_codec);
						continue;
					}
				}
				else
				{
					if (num == 98U)
					{
						this.aiBlackboardCdComplete_.AddEntriesFrom(ref input, AiBlackboardCdNotify._repeated_aiBlackboardCdComplete_codec);
						continue;
					}
					if (num == 114U)
					{
						this.aiBlackboardCdModify_.AddEntriesFrom(ref input, AiBlackboardCdNotify._repeated_aiBlackboardCdModify_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400C402 RID: 50178
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C403 RID: 50179
		public const int AiBlackboardCdDelFieldNumber = 10;

		// Token: 0x0400C404 RID: 50180
		private static readonly FieldCodec<int> _repeated_aiBlackboardCdDel_codec = FieldCodec.ForInt32(82U);

		// Token: 0x0400C405 RID: 50181
		private readonly RepeatedField<int> aiBlackboardCdDel_ = new RepeatedField<int>();

		// Token: 0x0400C406 RID: 50182
		public const int AiBlackboardCdModifyFieldNumber = 14;

		// Token: 0x0400C407 RID: 50183
		private static readonly FieldCodec<Int2Long> _repeated_aiBlackboardCdModify_codec = FieldCodec.ForMessage<Int2Long>(114U, Int2Long.Parser);

		// Token: 0x0400C408 RID: 50184
		private readonly RepeatedField<Int2Long> aiBlackboardCdModify_ = new RepeatedField<Int2Long>();

		// Token: 0x0400C409 RID: 50185
		public const int AiBlackboardCdCompleteFieldNumber = 12;

		// Token: 0x0400C40A RID: 50186
		private static readonly FieldCodec<Int2Bool> _repeated_aiBlackboardCdComplete_codec = FieldCodec.ForMessage<Int2Bool>(98U, Int2Bool.Parser);

		// Token: 0x0400C40B RID: 50187
		private readonly RepeatedField<Int2Bool> aiBlackboardCdComplete_ = new RepeatedField<Int2Bool>();
	}
}
