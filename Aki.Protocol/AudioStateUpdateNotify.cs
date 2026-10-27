using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200012C RID: 300
	[NetMessage(EMessageId.AudioStateUpdateNotify)]
	public sealed class AudioStateUpdateNotify : IMessage<AudioStateUpdateNotify>, IMessage, IEquatable<AudioStateUpdateNotify>, IDeepCloneable<AudioStateUpdateNotify>, IBufferMessage
	{
		// Token: 0x060027DB RID: 10203 RVA: 0x00069460 File Offset: 0x00067660
		[NullableContext(1)]
		public static AudioStateUpdateNotify Create()
		{
			return new AudioStateUpdateNotify();
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x060027DC RID: 10204 RVA: 0x00069467 File Offset: 0x00067667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x060027DD RID: 10205 RVA: 0x0006946A File Offset: 0x0006766A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AudioStateUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060027DE RID: 10206 RVA: 0x00069471 File Offset: 0x00067671
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AudioStateUpdateNotify()
		{
		}

		// Token: 0x060027DF RID: 10207 RVA: 0x00069484 File Offset: 0x00067684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AudioStateUpdateNotify(AudioStateUpdateNotify other) : this()
		{
			this.audioStates_ = other.audioStates_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060027E0 RID: 10208 RVA: 0x000694AE File Offset: 0x000676AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AudioStateUpdateNotify Clone()
		{
			return new AudioStateUpdateNotify(this);
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x060027E1 RID: 10209 RVA: 0x000694B6 File Offset: 0x000676B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AudioStatePb> AudioStates
		{
			get
			{
				return this.audioStates_;
			}
		}

		// Token: 0x060027E2 RID: 10210 RVA: 0x000694BE File Offset: 0x000676BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AudioStateUpdateNotify);
		}

		// Token: 0x060027E3 RID: 10211 RVA: 0x000694CC File Offset: 0x000676CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AudioStateUpdateNotify other)
		{
			return other != null && (other == this || (this.audioStates_.Equals(other.audioStates_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060027E4 RID: 10212 RVA: 0x00069500 File Offset: 0x00067700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.audioStates_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060027E5 RID: 10213 RVA: 0x00069534 File Offset: 0x00067734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060027E6 RID: 10214 RVA: 0x00069541 File Offset: 0x00067741
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060027E7 RID: 10215 RVA: 0x0006954A File Offset: 0x0006774A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.audioStates_.WriteTo(ref output, AudioStateUpdateNotify._repeated_audioStates_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060027E8 RID: 10216 RVA: 0x00069574 File Offset: 0x00067774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.audioStates_.CalculateSize(AudioStateUpdateNotify._repeated_audioStates_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060027E9 RID: 10217 RVA: 0x000695AD File Offset: 0x000677AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AudioStateUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.audioStates_.Add(other.audioStates_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060027EA RID: 10218 RVA: 0x000695DB File Offset: 0x000677DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060027EB RID: 10219 RVA: 0x000695E4 File Offset: 0x000677E4
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
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.audioStates_.AddEntriesFrom(ref input, AudioStateUpdateNotify._repeated_audioStates_codec);
				}
			}
		}

		// Token: 0x04002680 RID: 9856
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002681 RID: 9857
		public const int AudioStatesFieldNumber = 7;

		// Token: 0x04002682 RID: 9858
		private static readonly FieldCodec<AudioStatePb> _repeated_audioStates_codec = FieldCodec.ForMessage<AudioStatePb>(58U, AudioStatePb.Parser);

		// Token: 0x04002683 RID: 9859
		private readonly RepeatedField<AudioStatePb> audioStates_ = new RepeatedField<AudioStatePb>();
	}
}
