using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200012F RID: 303
	[NetMessage(EMessageId.AudioStateUpdateNotify)]
	public sealed class AudioStateUpdateNotify : IMessage<AudioStateUpdateNotify>, IMessage, IEquatable<AudioStateUpdateNotify>, IDeepCloneable<AudioStateUpdateNotify>, IBufferMessage
	{
		// Token: 0x06002852 RID: 10322 RVA: 0x0006A888 File Offset: 0x00068A88
		[NullableContext(1)]
		public static AudioStateUpdateNotify Create()
		{
			return new AudioStateUpdateNotify();
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06002853 RID: 10323 RVA: 0x0006A88F File Offset: 0x00068A8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06002854 RID: 10324 RVA: 0x0006A892 File Offset: 0x00068A92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AudioStateUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06002855 RID: 10325 RVA: 0x0006A899 File Offset: 0x00068A99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AudioStateUpdateNotify()
		{
		}

		// Token: 0x06002856 RID: 10326 RVA: 0x0006A8AC File Offset: 0x00068AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AudioStateUpdateNotify(AudioStateUpdateNotify other) : this()
		{
			this.audioStates_ = other.audioStates_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002857 RID: 10327 RVA: 0x0006A8D6 File Offset: 0x00068AD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AudioStateUpdateNotify Clone()
		{
			return new AudioStateUpdateNotify(this);
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06002858 RID: 10328 RVA: 0x0006A8DE File Offset: 0x00068ADE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AudioStatePb> AudioStates
		{
			get
			{
				return this.audioStates_;
			}
		}

		// Token: 0x06002859 RID: 10329 RVA: 0x0006A8E6 File Offset: 0x00068AE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AudioStateUpdateNotify);
		}

		// Token: 0x0600285A RID: 10330 RVA: 0x0006A8F4 File Offset: 0x00068AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AudioStateUpdateNotify other)
		{
			return other != null && (other == this || (this.audioStates_.Equals(other.audioStates_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600285B RID: 10331 RVA: 0x0006A928 File Offset: 0x00068B28
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

		// Token: 0x0600285C RID: 10332 RVA: 0x0006A95C File Offset: 0x00068B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600285D RID: 10333 RVA: 0x0006A969 File Offset: 0x00068B69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600285E RID: 10334 RVA: 0x0006A972 File Offset: 0x00068B72
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

		// Token: 0x0600285F RID: 10335 RVA: 0x0006A99C File Offset: 0x00068B9C
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

		// Token: 0x06002860 RID: 10336 RVA: 0x0006A9D5 File Offset: 0x00068BD5
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

		// Token: 0x06002861 RID: 10337 RVA: 0x0006AA03 File Offset: 0x00068C03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002862 RID: 10338 RVA: 0x0006AA0C File Offset: 0x00068C0C
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
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.audioStates_.AddEntriesFrom(ref input, AudioStateUpdateNotify._repeated_audioStates_codec);
				}
			}
		}

		// Token: 0x040026F4 RID: 9972
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026F5 RID: 9973
		public const int AudioStatesFieldNumber = 12;

		// Token: 0x040026F6 RID: 9974
		private static readonly FieldCodec<AudioStatePb> _repeated_audioStates_codec = FieldCodec.ForMessage<AudioStatePb>(98U, AudioStatePb.Parser);

		// Token: 0x040026F7 RID: 9975
		private readonly RepeatedField<AudioStatePb> audioStates_ = new RepeatedField<AudioStatePb>();
	}
}
