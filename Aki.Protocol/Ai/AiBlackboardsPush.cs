using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x020016A7 RID: 5799
	[NetMessage(EMessageId.AiBlackboardsPush)]
	public sealed class AiBlackboardsPush : IMessage<AiBlackboardsPush>, IMessage, IEquatable<AiBlackboardsPush>, IDeepCloneable<AiBlackboardsPush>, IBufferMessage
	{
		// Token: 0x0601D0EF RID: 119023 RVA: 0x00440CD9 File Offset: 0x0043EED9
		[NullableContext(1)]
		public static AiBlackboardsPush Create()
		{
			return new AiBlackboardsPush();
		}

		// Token: 0x1700629A RID: 25242
		// (get) Token: 0x0601D0F0 RID: 119024 RVA: 0x00440CE0 File Offset: 0x0043EEE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700629B RID: 25243
		// (get) Token: 0x0601D0F1 RID: 119025 RVA: 0x00440CE3 File Offset: 0x0043EEE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AiBlackboardsPush.Descriptor;
			}
		}

		// Token: 0x0601D0F2 RID: 119026 RVA: 0x00440CEA File Offset: 0x0043EEEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardsPush()
		{
		}

		// Token: 0x0601D0F3 RID: 119027 RVA: 0x00440CFD File Offset: 0x0043EEFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardsPush(AiBlackboardsPush other) : this()
		{
			this.aiBlackboards_ = other.aiBlackboards_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D0F4 RID: 119028 RVA: 0x00440D27 File Offset: 0x0043EF27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardsPush Clone()
		{
			return new AiBlackboardsPush(this);
		}

		// Token: 0x1700629C RID: 25244
		// (get) Token: 0x0601D0F5 RID: 119029 RVA: 0x00440D2F File Offset: 0x0043EF2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BlackboardParam> AiBlackboards
		{
			get
			{
				return this.aiBlackboards_;
			}
		}

		// Token: 0x0601D0F6 RID: 119030 RVA: 0x00440D37 File Offset: 0x0043EF37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AiBlackboardsPush);
		}

		// Token: 0x0601D0F7 RID: 119031 RVA: 0x00440D45 File Offset: 0x0043EF45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AiBlackboardsPush other)
		{
			return other != null && (other == this || (this.aiBlackboards_.Equals(other.aiBlackboards_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D0F8 RID: 119032 RVA: 0x00440D78 File Offset: 0x0043EF78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.aiBlackboards_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D0F9 RID: 119033 RVA: 0x00440DAC File Offset: 0x0043EFAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D0FA RID: 119034 RVA: 0x00440DB9 File Offset: 0x0043EFB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D0FB RID: 119035 RVA: 0x00440DC2 File Offset: 0x0043EFC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.aiBlackboards_.WriteTo(ref output, AiBlackboardsPush._repeated_aiBlackboards_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D0FC RID: 119036 RVA: 0x00440DEC File Offset: 0x0043EFEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.aiBlackboards_.CalculateSize(AiBlackboardsPush._repeated_aiBlackboards_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D0FD RID: 119037 RVA: 0x00440E25 File Offset: 0x0043F025
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AiBlackboardsPush other)
		{
			if (other == null)
			{
				return;
			}
			this.aiBlackboards_.Add(other.aiBlackboards_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D0FE RID: 119038 RVA: 0x00440E53 File Offset: 0x0043F053
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D0FF RID: 119039 RVA: 0x00440E5C File Offset: 0x0043F05C
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.aiBlackboards_.AddEntriesFrom(ref input, AiBlackboardsPush._repeated_aiBlackboards_codec);
				}
			}
		}

		// Token: 0x0400C41D RID: 50205
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C41E RID: 50206
		public const int AiBlackboardsFieldNumber = 5;

		// Token: 0x0400C41F RID: 50207
		private static readonly FieldCodec<BlackboardParam> _repeated_aiBlackboards_codec = FieldCodec.ForMessage<BlackboardParam>(42U, BlackboardParam.Parser);

		// Token: 0x0400C420 RID: 50208
		private readonly RepeatedField<BlackboardParam> aiBlackboards_ = new RepeatedField<BlackboardParam>();
	}
}
