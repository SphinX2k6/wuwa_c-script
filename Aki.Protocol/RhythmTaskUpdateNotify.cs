using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F42 RID: 3906
	[NetMessage(EMessageId.RhythmTaskUpdateNotify)]
	public sealed class RhythmTaskUpdateNotify : IMessage<RhythmTaskUpdateNotify>, IMessage, IEquatable<RhythmTaskUpdateNotify>, IDeepCloneable<RhythmTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x06014ED1 RID: 85713 RVA: 0x00309D5D File Offset: 0x00307F5D
		[NullableContext(1)]
		public static RhythmTaskUpdateNotify Create()
		{
			return new RhythmTaskUpdateNotify();
		}

		// Token: 0x170045A1 RID: 17825
		// (get) Token: 0x06014ED2 RID: 85714 RVA: 0x00309D64 File Offset: 0x00307F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045A2 RID: 17826
		// (get) Token: 0x06014ED3 RID: 85715 RVA: 0x00309D67 File Offset: 0x00307F67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06014ED4 RID: 85716 RVA: 0x00309D6E File Offset: 0x00307F6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmTaskUpdateNotify()
		{
		}

		// Token: 0x06014ED5 RID: 85717 RVA: 0x00309D81 File Offset: 0x00307F81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmTaskUpdateNotify(RhythmTaskUpdateNotify other) : this()
		{
			this.rhythmTask_ = other.rhythmTask_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014ED6 RID: 85718 RVA: 0x00309DAB File Offset: 0x00307FAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmTaskUpdateNotify Clone()
		{
			return new RhythmTaskUpdateNotify(this);
		}

		// Token: 0x170045A3 RID: 17827
		// (get) Token: 0x06014ED7 RID: 85719 RVA: 0x00309DB3 File Offset: 0x00307FB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RhythmTaskPb> RhythmTask
		{
			get
			{
				return this.rhythmTask_;
			}
		}

		// Token: 0x06014ED8 RID: 85720 RVA: 0x00309DBB File Offset: 0x00307FBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmTaskUpdateNotify);
		}

		// Token: 0x06014ED9 RID: 85721 RVA: 0x00309DC9 File Offset: 0x00307FC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmTaskUpdateNotify other)
		{
			return other != null && (other == this || (this.rhythmTask_.Equals(other.rhythmTask_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014EDA RID: 85722 RVA: 0x00309DFC File Offset: 0x00307FFC
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

		// Token: 0x06014EDB RID: 85723 RVA: 0x00309E30 File Offset: 0x00308030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014EDC RID: 85724 RVA: 0x00309E3D File Offset: 0x0030803D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014EDD RID: 85725 RVA: 0x00309E46 File Offset: 0x00308046
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

		// Token: 0x06014EDE RID: 85726 RVA: 0x00309E70 File Offset: 0x00308070
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

		// Token: 0x06014EDF RID: 85727 RVA: 0x00309EA9 File Offset: 0x003080A9
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

		// Token: 0x06014EE0 RID: 85728 RVA: 0x00309ED7 File Offset: 0x003080D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014EE1 RID: 85729 RVA: 0x00309EE0 File Offset: 0x003080E0
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rhythmTask_.AddEntriesFrom(ref input, RhythmTaskUpdateNotify._repeated_rhythmTask_codec);
				}
			}
		}

		// Token: 0x04007EA3 RID: 32419
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007EA4 RID: 32420
		public const int RhythmTaskFieldNumber = 6;

		// Token: 0x04007EA5 RID: 32421
		private static readonly FieldCodec<RhythmTaskPb> _repeated_rhythmTask_codec = FieldCodec.ForMessage<RhythmTaskPb>(50U, RhythmTaskPb.Parser);

		// Token: 0x04007EA6 RID: 32422
		private readonly RepeatedField<RhythmTaskPb> rhythmTask_ = new RepeatedField<RhythmTaskPb>();
	}
}
