using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F3E RID: 3902
	[NetMessage(EMessageId.RhythmSubLevelUpdateNotify)]
	public sealed class RhythmSubLevelUpdateNotify : IMessage<RhythmSubLevelUpdateNotify>, IMessage, IEquatable<RhythmSubLevelUpdateNotify>, IDeepCloneable<RhythmSubLevelUpdateNotify>, IBufferMessage
	{
		// Token: 0x06014E84 RID: 85636 RVA: 0x00309412 File Offset: 0x00307612
		[NullableContext(1)]
		public static RhythmSubLevelUpdateNotify Create()
		{
			return new RhythmSubLevelUpdateNotify();
		}

		// Token: 0x17004592 RID: 17810
		// (get) Token: 0x06014E85 RID: 85637 RVA: 0x00309419 File Offset: 0x00307619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004593 RID: 17811
		// (get) Token: 0x06014E86 RID: 85638 RVA: 0x0030941C File Offset: 0x0030761C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmSubLevelUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06014E87 RID: 85639 RVA: 0x00309423 File Offset: 0x00307623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmSubLevelUpdateNotify()
		{
		}

		// Token: 0x06014E88 RID: 85640 RVA: 0x00309436 File Offset: 0x00307636
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmSubLevelUpdateNotify(RhythmSubLevelUpdateNotify other) : this()
		{
			this.updateSubLevelPb_ = other.updateSubLevelPb_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014E89 RID: 85641 RVA: 0x00309460 File Offset: 0x00307660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmSubLevelUpdateNotify Clone()
		{
			return new RhythmSubLevelUpdateNotify(this);
		}

		// Token: 0x17004594 RID: 17812
		// (get) Token: 0x06014E8A RID: 85642 RVA: 0x00309468 File Offset: 0x00307668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RhythmSubLevelPb> UpdateSubLevelPb
		{
			get
			{
				return this.updateSubLevelPb_;
			}
		}

		// Token: 0x06014E8B RID: 85643 RVA: 0x00309470 File Offset: 0x00307670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmSubLevelUpdateNotify);
		}

		// Token: 0x06014E8C RID: 85644 RVA: 0x0030947E File Offset: 0x0030767E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmSubLevelUpdateNotify other)
		{
			return other != null && (other == this || (this.updateSubLevelPb_.Equals(other.updateSubLevelPb_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014E8D RID: 85645 RVA: 0x003094B4 File Offset: 0x003076B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.updateSubLevelPb_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014E8E RID: 85646 RVA: 0x003094E8 File Offset: 0x003076E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014E8F RID: 85647 RVA: 0x003094F5 File Offset: 0x003076F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014E90 RID: 85648 RVA: 0x003094FE File Offset: 0x003076FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.updateSubLevelPb_.WriteTo(ref output, RhythmSubLevelUpdateNotify._repeated_updateSubLevelPb_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014E91 RID: 85649 RVA: 0x00309528 File Offset: 0x00307728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.updateSubLevelPb_.CalculateSize(RhythmSubLevelUpdateNotify._repeated_updateSubLevelPb_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014E92 RID: 85650 RVA: 0x00309561 File Offset: 0x00307761
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RhythmSubLevelUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.updateSubLevelPb_.Add(other.updateSubLevelPb_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014E93 RID: 85651 RVA: 0x0030958F File Offset: 0x0030778F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014E94 RID: 85652 RVA: 0x00309598 File Offset: 0x00307798
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.updateSubLevelPb_.AddEntriesFrom(ref input, RhythmSubLevelUpdateNotify._repeated_updateSubLevelPb_codec);
				}
			}
		}

		// Token: 0x04007E8F RID: 32399
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E90 RID: 32400
		public const int UpdateSubLevelPbFieldNumber = 14;

		// Token: 0x04007E91 RID: 32401
		private static readonly FieldCodec<RhythmSubLevelPb> _repeated_updateSubLevelPb_codec = FieldCodec.ForMessage<RhythmSubLevelPb>(114U, RhythmSubLevelPb.Parser);

		// Token: 0x04007E92 RID: 32402
		private readonly RepeatedField<RhythmSubLevelPb> updateSubLevelPb_ = new RepeatedField<RhythmSubLevelPb>();
	}
}
