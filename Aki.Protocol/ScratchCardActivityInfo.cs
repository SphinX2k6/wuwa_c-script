using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011D5 RID: 4565
	public sealed class ScratchCardActivityInfo : IMessage<ScratchCardActivityInfo>, IMessage, IEquatable<ScratchCardActivityInfo>, IDeepCloneable<ScratchCardActivityInfo>, IBufferMessage
	{
		// Token: 0x060185E6 RID: 99814 RVA: 0x0038BFDB File Offset: 0x0038A1DB
		[NullableContext(1)]
		public static ScratchCardActivityInfo Create()
		{
			return new ScratchCardActivityInfo();
		}

		// Token: 0x17005220 RID: 21024
		// (get) Token: 0x060185E7 RID: 99815 RVA: 0x0038BFE2 File Offset: 0x0038A1E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005221 RID: 21025
		// (get) Token: 0x060185E8 RID: 99816 RVA: 0x0038BFE5 File Offset: 0x0038A1E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ScratchCardActivityInfo.Descriptor;
			}
		}

		// Token: 0x060185E9 RID: 99817 RVA: 0x0038BFEC File Offset: 0x0038A1EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardActivityInfo()
		{
		}

		// Token: 0x060185EA RID: 99818 RVA: 0x0038C00A File Offset: 0x0038A20A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardActivityInfo(ScratchCardActivityInfo other) : this()
		{
			this.roundInfos_ = other.roundInfos_.Clone();
			this.scratchTimeInfos_ = other.scratchTimeInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060185EB RID: 99819 RVA: 0x0038C045 File Offset: 0x0038A245
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardActivityInfo Clone()
		{
			return new ScratchCardActivityInfo(this);
		}

		// Token: 0x17005222 RID: 21026
		// (get) Token: 0x060185EC RID: 99820 RVA: 0x0038C04D File Offset: 0x0038A24D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ScratchCardRoundInfo> RoundInfos
		{
			get
			{
				return this.roundInfos_;
			}
		}

		// Token: 0x17005223 RID: 21027
		// (get) Token: 0x060185ED RID: 99821 RVA: 0x0038C055 File Offset: 0x0038A255
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ScratchCardTimeInfo> ScratchTimeInfos
		{
			get
			{
				return this.scratchTimeInfos_;
			}
		}

		// Token: 0x060185EE RID: 99822 RVA: 0x0038C05D File Offset: 0x0038A25D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ScratchCardActivityInfo);
		}

		// Token: 0x060185EF RID: 99823 RVA: 0x0038C06C File Offset: 0x0038A26C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ScratchCardActivityInfo other)
		{
			return other != null && (other == this || (this.roundInfos_.Equals(other.roundInfos_) && this.scratchTimeInfos_.Equals(other.scratchTimeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060185F0 RID: 99824 RVA: 0x0038C0C0 File Offset: 0x0038A2C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.roundInfos_.GetHashCode();
			num ^= this.scratchTimeInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060185F1 RID: 99825 RVA: 0x0038C102 File Offset: 0x0038A302
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060185F2 RID: 99826 RVA: 0x0038C10F File Offset: 0x0038A30F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060185F3 RID: 99827 RVA: 0x0038C118 File Offset: 0x0038A318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roundInfos_.WriteTo(ref output, ScratchCardActivityInfo._repeated_roundInfos_codec);
			this.scratchTimeInfos_.WriteTo(ref output, ScratchCardActivityInfo._repeated_scratchTimeInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060185F4 RID: 99828 RVA: 0x0038C150 File Offset: 0x0038A350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roundInfos_.CalculateSize(ScratchCardActivityInfo._repeated_roundInfos_codec);
			num += this.scratchTimeInfos_.CalculateSize(ScratchCardActivityInfo._repeated_scratchTimeInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060185F5 RID: 99829 RVA: 0x0038C19C File Offset: 0x0038A39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ScratchCardActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.roundInfos_.Add(other.roundInfos_);
			this.scratchTimeInfos_.Add(other.scratchTimeInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060185F6 RID: 99830 RVA: 0x0038C1DB File Offset: 0x0038A3DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060185F7 RID: 99831 RVA: 0x0038C1E4 File Offset: 0x0038A3E4
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
				if (num != 10U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.scratchTimeInfos_.AddEntriesFrom(ref input, ScratchCardActivityInfo._repeated_scratchTimeInfos_codec);
					}
				}
				else
				{
					this.roundInfos_.AddEntriesFrom(ref input, ScratchCardActivityInfo._repeated_roundInfos_codec);
				}
			}
		}

		// Token: 0x040090C7 RID: 37063
		private UnknownFieldSet _unknownFields;

		// Token: 0x040090C8 RID: 37064
		public const int RoundInfosFieldNumber = 1;

		// Token: 0x040090C9 RID: 37065
		private static readonly FieldCodec<ScratchCardRoundInfo> _repeated_roundInfos_codec = FieldCodec.ForMessage<ScratchCardRoundInfo>(10U, ScratchCardRoundInfo.Parser);

		// Token: 0x040090CA RID: 37066
		private readonly RepeatedField<ScratchCardRoundInfo> roundInfos_ = new RepeatedField<ScratchCardRoundInfo>();

		// Token: 0x040090CB RID: 37067
		public const int ScratchTimeInfosFieldNumber = 2;

		// Token: 0x040090CC RID: 37068
		private static readonly FieldCodec<ScratchCardTimeInfo> _repeated_scratchTimeInfos_codec = FieldCodec.ForMessage<ScratchCardTimeInfo>(18U, ScratchCardTimeInfo.Parser);

		// Token: 0x040090CD RID: 37069
		private readonly RepeatedField<ScratchCardTimeInfo> scratchTimeInfos_ = new RepeatedField<ScratchCardTimeInfo>();
	}
}
