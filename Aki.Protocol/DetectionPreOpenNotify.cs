using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003B6 RID: 950
	[NetMessage(EMessageId.DetectionPreOpenNotify)]
	public sealed class DetectionPreOpenNotify : IMessage<DetectionPreOpenNotify>, IMessage, IEquatable<DetectionPreOpenNotify>, IDeepCloneable<DetectionPreOpenNotify>, IBufferMessage
	{
		// Token: 0x06005D59 RID: 23897 RVA: 0x000E2994 File Offset: 0x000E0B94
		[NullableContext(1)]
		public static DetectionPreOpenNotify Create()
		{
			return new DetectionPreOpenNotify();
		}

		// Token: 0x1700114C RID: 4428
		// (get) Token: 0x06005D5A RID: 23898 RVA: 0x000E299B File Offset: 0x000E0B9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700114D RID: 4429
		// (get) Token: 0x06005D5B RID: 23899 RVA: 0x000E299E File Offset: 0x000E0B9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DetectionPreOpenNotify.Descriptor;
			}
		}

		// Token: 0x06005D5C RID: 23900 RVA: 0x000E29A5 File Offset: 0x000E0BA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionPreOpenNotify()
		{
		}

		// Token: 0x06005D5D RID: 23901 RVA: 0x000E29C3 File Offset: 0x000E0BC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionPreOpenNotify(DetectionPreOpenNotify other) : this()
		{
			this.preOpenDungeonDetections_ = other.preOpenDungeonDetections_.Clone();
			this.preOpenSilenceAreaDetections_ = other.preOpenSilenceAreaDetections_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005D5E RID: 23902 RVA: 0x000E29FE File Offset: 0x000E0BFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionPreOpenNotify Clone()
		{
			return new DetectionPreOpenNotify(this);
		}

		// Token: 0x1700114E RID: 4430
		// (get) Token: 0x06005D5F RID: 23903 RVA: 0x000E2A06 File Offset: 0x000E0C06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PreOpenDetections> PreOpenDungeonDetections
		{
			get
			{
				return this.preOpenDungeonDetections_;
			}
		}

		// Token: 0x1700114F RID: 4431
		// (get) Token: 0x06005D60 RID: 23904 RVA: 0x000E2A0E File Offset: 0x000E0C0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PreOpenDetections> PreOpenSilenceAreaDetections
		{
			get
			{
				return this.preOpenSilenceAreaDetections_;
			}
		}

		// Token: 0x06005D61 RID: 23905 RVA: 0x000E2A16 File Offset: 0x000E0C16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DetectionPreOpenNotify);
		}

		// Token: 0x06005D62 RID: 23906 RVA: 0x000E2A24 File Offset: 0x000E0C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DetectionPreOpenNotify other)
		{
			return other != null && (other == this || (this.preOpenDungeonDetections_.Equals(other.preOpenDungeonDetections_) && this.preOpenSilenceAreaDetections_.Equals(other.preOpenSilenceAreaDetections_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005D63 RID: 23907 RVA: 0x000E2A78 File Offset: 0x000E0C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.preOpenDungeonDetections_.GetHashCode();
			num ^= this.preOpenSilenceAreaDetections_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005D64 RID: 23908 RVA: 0x000E2ABA File Offset: 0x000E0CBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005D65 RID: 23909 RVA: 0x000E2AC7 File Offset: 0x000E0CC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005D66 RID: 23910 RVA: 0x000E2AD0 File Offset: 0x000E0CD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.preOpenSilenceAreaDetections_.WriteTo(ref output, DetectionPreOpenNotify._repeated_preOpenSilenceAreaDetections_codec);
			this.preOpenDungeonDetections_.WriteTo(ref output, DetectionPreOpenNotify._repeated_preOpenDungeonDetections_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005D67 RID: 23911 RVA: 0x000E2B08 File Offset: 0x000E0D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.preOpenDungeonDetections_.CalculateSize(DetectionPreOpenNotify._repeated_preOpenDungeonDetections_codec);
			num += this.preOpenSilenceAreaDetections_.CalculateSize(DetectionPreOpenNotify._repeated_preOpenSilenceAreaDetections_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005D68 RID: 23912 RVA: 0x000E2B54 File Offset: 0x000E0D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DetectionPreOpenNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.preOpenDungeonDetections_.Add(other.preOpenDungeonDetections_);
			this.preOpenSilenceAreaDetections_.Add(other.preOpenSilenceAreaDetections_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005D69 RID: 23913 RVA: 0x000E2B93 File Offset: 0x000E0D93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005D6A RID: 23914 RVA: 0x000E2B9C File Offset: 0x000E0D9C
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
				if (num != 74U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.preOpenDungeonDetections_.AddEntriesFrom(ref input, DetectionPreOpenNotify._repeated_preOpenDungeonDetections_codec);
					}
				}
				else
				{
					this.preOpenSilenceAreaDetections_.AddEntriesFrom(ref input, DetectionPreOpenNotify._repeated_preOpenSilenceAreaDetections_codec);
				}
			}
		}

		// Token: 0x040036D3 RID: 14035
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036D4 RID: 14036
		public const int PreOpenDungeonDetectionsFieldNumber = 15;

		// Token: 0x040036D5 RID: 14037
		private static readonly FieldCodec<PreOpenDetections> _repeated_preOpenDungeonDetections_codec = FieldCodec.ForMessage<PreOpenDetections>(122U, PreOpenDetections.Parser);

		// Token: 0x040036D6 RID: 14038
		private readonly RepeatedField<PreOpenDetections> preOpenDungeonDetections_ = new RepeatedField<PreOpenDetections>();

		// Token: 0x040036D7 RID: 14039
		public const int PreOpenSilenceAreaDetectionsFieldNumber = 9;

		// Token: 0x040036D8 RID: 14040
		private static readonly FieldCodec<PreOpenDetections> _repeated_preOpenSilenceAreaDetections_codec = FieldCodec.ForMessage<PreOpenDetections>(74U, PreOpenDetections.Parser);

		// Token: 0x040036D9 RID: 14041
		private readonly RepeatedField<PreOpenDetections> preOpenSilenceAreaDetections_ = new RepeatedField<PreOpenDetections>();
	}
}
