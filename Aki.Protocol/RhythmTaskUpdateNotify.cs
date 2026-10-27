using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F52 RID: 3922
	[NetMessage(EMessageId.RhythmTaskUpdateNotify)]
	public sealed class RhythmTaskUpdateNotify : IMessage<RhythmTaskUpdateNotify>, IMessage, IEquatable<RhythmTaskUpdateNotify>, IDeepCloneable<RhythmTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x06014FB6 RID: 85942 RVA: 0x0030B419 File Offset: 0x00309619
		[NullableContext(1)]
		public static RhythmTaskUpdateNotify Create()
		{
			return new RhythmTaskUpdateNotify();
		}

		// Token: 0x170045CB RID: 17867
		// (get) Token: 0x06014FB7 RID: 85943 RVA: 0x0030B420 File Offset: 0x00309620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045CC RID: 17868
		// (get) Token: 0x06014FB8 RID: 85944 RVA: 0x0030B423 File Offset: 0x00309623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06014FB9 RID: 85945 RVA: 0x0030B42A File Offset: 0x0030962A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmTaskUpdateNotify()
		{
		}

		// Token: 0x06014FBA RID: 85946 RVA: 0x0030B43D File Offset: 0x0030963D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmTaskUpdateNotify(RhythmTaskUpdateNotify other) : this()
		{
			this.rhythmTask_ = other.rhythmTask_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014FBB RID: 85947 RVA: 0x0030B467 File Offset: 0x00309667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmTaskUpdateNotify Clone()
		{
			return new RhythmTaskUpdateNotify(this);
		}

		// Token: 0x170045CD RID: 17869
		// (get) Token: 0x06014FBC RID: 85948 RVA: 0x0030B46F File Offset: 0x0030966F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RhythmTaskPb> RhythmTask
		{
			get
			{
				return this.rhythmTask_;
			}
		}

		// Token: 0x06014FBD RID: 85949 RVA: 0x0030B477 File Offset: 0x00309677
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmTaskUpdateNotify);
		}

		// Token: 0x06014FBE RID: 85950 RVA: 0x0030B485 File Offset: 0x00309685
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmTaskUpdateNotify other)
		{
			return other != null && (other == this || (this.rhythmTask_.Equals(other.rhythmTask_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014FBF RID: 85951 RVA: 0x0030B4B8 File Offset: 0x003096B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.rhythmTask_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014FC0 RID: 85952 RVA: 0x0030B4EC File Offset: 0x003096EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014FC1 RID: 85953 RVA: 0x0030B4F9 File Offset: 0x003096F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014FC2 RID: 85954 RVA: 0x0030B502 File Offset: 0x00309702
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rhythmTask_.WriteTo(ref output, RhythmTaskUpdateNotify._repeated_rhythmTask_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014FC3 RID: 85955 RVA: 0x0030B52C File Offset: 0x0030972C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rhythmTask_.CalculateSize(RhythmTaskUpdateNotify._repeated_rhythmTask_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014FC4 RID: 85956 RVA: 0x0030B565 File Offset: 0x00309765
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RhythmTaskUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.rhythmTask_.Add(other.rhythmTask_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014FC5 RID: 85957 RVA: 0x0030B593 File Offset: 0x00309793
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014FC6 RID: 85958 RVA: 0x0030B59C File Offset: 0x0030979C
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
					this.rhythmTask_.AddEntriesFrom(ref input, RhythmTaskUpdateNotify._repeated_rhythmTask_codec);
				}
			}
		}

		// Token: 0x04007E79 RID: 32377
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E7A RID: 32378
		public const int RhythmTaskFieldNumber = 12;

		// Token: 0x04007E7B RID: 32379
		private static readonly FieldCodec<RhythmTaskPb> _repeated_rhythmTask_codec = FieldCodec.ForMessage<RhythmTaskPb>(98U, RhythmTaskPb.Parser);

		// Token: 0x04007E7C RID: 32380
		private readonly RepeatedField<RhythmTaskPb> rhythmTask_ = new RepeatedField<RhythmTaskPb>();
	}
}
