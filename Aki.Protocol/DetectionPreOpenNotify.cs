using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003CD RID: 973
	[NetMessage(EMessageId.DetectionPreOpenNotify)]
	public sealed class DetectionPreOpenNotify : IMessage<DetectionPreOpenNotify>, IMessage, IEquatable<DetectionPreOpenNotify>, IDeepCloneable<DetectionPreOpenNotify>, IBufferMessage
	{
		// Token: 0x06005EE9 RID: 24297 RVA: 0x000E5B18 File Offset: 0x000E3D18
		[NullableContext(1)]
		public static DetectionPreOpenNotify Create()
		{
			return new DetectionPreOpenNotify();
		}

		// Token: 0x170011A1 RID: 4513
		// (get) Token: 0x06005EEA RID: 24298 RVA: 0x000E5B1F File Offset: 0x000E3D1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011A2 RID: 4514
		// (get) Token: 0x06005EEB RID: 24299 RVA: 0x000E5B22 File Offset: 0x000E3D22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DetectionPreOpenNotify.Descriptor;
			}
		}

		// Token: 0x06005EEC RID: 24300 RVA: 0x000E5B29 File Offset: 0x000E3D29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionPreOpenNotify()
		{
		}

		// Token: 0x06005EED RID: 24301 RVA: 0x000E5B47 File Offset: 0x000E3D47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionPreOpenNotify(DetectionPreOpenNotify other) : this()
		{
			this.preOpenDungeonDetections_ = other.preOpenDungeonDetections_.Clone();
			this.preOpenSilenceAreaDetections_ = other.preOpenSilenceAreaDetections_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005EEE RID: 24302 RVA: 0x000E5B82 File Offset: 0x000E3D82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionPreOpenNotify Clone()
		{
			return new DetectionPreOpenNotify(this);
		}

		// Token: 0x170011A3 RID: 4515
		// (get) Token: 0x06005EEF RID: 24303 RVA: 0x000E5B8A File Offset: 0x000E3D8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PreOpenDetections> PreOpenDungeonDetections
		{
			get
			{
				return this.preOpenDungeonDetections_;
			}
		}

		// Token: 0x170011A4 RID: 4516
		// (get) Token: 0x06005EF0 RID: 24304 RVA: 0x000E5B92 File Offset: 0x000E3D92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PreOpenDetections> PreOpenSilenceAreaDetections
		{
			get
			{
				return this.preOpenSilenceAreaDetections_;
			}
		}

		// Token: 0x06005EF1 RID: 24305 RVA: 0x000E5B9A File Offset: 0x000E3D9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DetectionPreOpenNotify);
		}

		// Token: 0x06005EF2 RID: 24306 RVA: 0x000E5BA8 File Offset: 0x000E3DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DetectionPreOpenNotify other)
		{
			return other != null && (other == this || (this.preOpenDungeonDetections_.Equals(other.preOpenDungeonDetections_) && this.preOpenSilenceAreaDetections_.Equals(other.preOpenSilenceAreaDetections_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005EF3 RID: 24307 RVA: 0x000E5BFC File Offset: 0x000E3DFC
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

		// Token: 0x06005EF4 RID: 24308 RVA: 0x000E5C3E File Offset: 0x000E3E3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005EF5 RID: 24309 RVA: 0x000E5C4B File Offset: 0x000E3E4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005EF6 RID: 24310 RVA: 0x000E5C54 File Offset: 0x000E3E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.preOpenDungeonDetections_.WriteTo(ref output, DetectionPreOpenNotify._repeated_preOpenDungeonDetections_codec);
			this.preOpenSilenceAreaDetections_.WriteTo(ref output, DetectionPreOpenNotify._repeated_preOpenSilenceAreaDetections_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005EF7 RID: 24311 RVA: 0x000E5C8C File Offset: 0x000E3E8C
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

		// Token: 0x06005EF8 RID: 24312 RVA: 0x000E5CD8 File Offset: 0x000E3ED8
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

		// Token: 0x06005EF9 RID: 24313 RVA: 0x000E5D17 File Offset: 0x000E3F17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005EFA RID: 24314 RVA: 0x000E5D20 File Offset: 0x000E3F20
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
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.preOpenSilenceAreaDetections_.AddEntriesFrom(ref input, DetectionPreOpenNotify._repeated_preOpenSilenceAreaDetections_codec);
					}
				}
				else
				{
					this.preOpenDungeonDetections_.AddEntriesFrom(ref input, DetectionPreOpenNotify._repeated_preOpenDungeonDetections_codec);
				}
			}
		}

		// Token: 0x040036E6 RID: 14054
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036E7 RID: 14055
		public const int PreOpenDungeonDetectionsFieldNumber = 9;

		// Token: 0x040036E8 RID: 14056
		private static readonly FieldCodec<PreOpenDetections> _repeated_preOpenDungeonDetections_codec = FieldCodec.ForMessage<PreOpenDetections>(74U, PreOpenDetections.Parser);

		// Token: 0x040036E9 RID: 14057
		private readonly RepeatedField<PreOpenDetections> preOpenDungeonDetections_ = new RepeatedField<PreOpenDetections>();

		// Token: 0x040036EA RID: 14058
		public const int PreOpenSilenceAreaDetectionsFieldNumber = 14;

		// Token: 0x040036EB RID: 14059
		private static readonly FieldCodec<PreOpenDetections> _repeated_preOpenSilenceAreaDetections_codec = FieldCodec.ForMessage<PreOpenDetections>(114U, PreOpenDetections.Parser);

		// Token: 0x040036EC RID: 14060
		private readonly RepeatedField<PreOpenDetections> preOpenSilenceAreaDetections_ = new RepeatedField<PreOpenDetections>();
	}
}
