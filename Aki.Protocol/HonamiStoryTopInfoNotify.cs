using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007A9 RID: 1961
	[NetMessage(EMessageId.HonamiStoryTopInfoNotify)]
	public sealed class HonamiStoryTopInfoNotify : IMessage<HonamiStoryTopInfoNotify>, IMessage, IEquatable<HonamiStoryTopInfoNotify>, IDeepCloneable<HonamiStoryTopInfoNotify>, IBufferMessage
	{
		// Token: 0x0600B0B7 RID: 45239 RVA: 0x001A7B7F File Offset: 0x001A5D7F
		[NullableContext(1)]
		public static HonamiStoryTopInfoNotify Create()
		{
			return new HonamiStoryTopInfoNotify();
		}

		// Token: 0x170023A7 RID: 9127
		// (get) Token: 0x0600B0B8 RID: 45240 RVA: 0x001A7B86 File Offset: 0x001A5D86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023A8 RID: 9128
		// (get) Token: 0x0600B0B9 RID: 45241 RVA: 0x001A7B89 File Offset: 0x001A5D89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryTopInfoNotify.Descriptor;
			}
		}

		// Token: 0x0600B0BA RID: 45242 RVA: 0x001A7B90 File Offset: 0x001A5D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryTopInfoNotify()
		{
		}

		// Token: 0x0600B0BB RID: 45243 RVA: 0x001A7BA3 File Offset: 0x001A5DA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryTopInfoNotify(HonamiStoryTopInfoNotify other) : this()
		{
			this.honamiStoryTopInfos_ = other.honamiStoryTopInfos_.Clone();
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B0BC RID: 45244 RVA: 0x001A7BD9 File Offset: 0x001A5DD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryTopInfoNotify Clone()
		{
			return new HonamiStoryTopInfoNotify(this);
		}

		// Token: 0x170023A9 RID: 9129
		// (get) Token: 0x0600B0BD RID: 45245 RVA: 0x001A7BE1 File Offset: 0x001A5DE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HonamiStoryTopInfo> HonamiStoryTopInfos
		{
			get
			{
				return this.honamiStoryTopInfos_;
			}
		}

		// Token: 0x170023AA RID: 9130
		// (get) Token: 0x0600B0BE RID: 45246 RVA: 0x001A7BE9 File Offset: 0x001A5DE9
		// (set) Token: 0x0600B0BF RID: 45247 RVA: 0x001A7BF1 File Offset: 0x001A5DF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x0600B0C0 RID: 45248 RVA: 0x001A7BFA File Offset: 0x001A5DFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryTopInfoNotify);
		}

		// Token: 0x0600B0C1 RID: 45249 RVA: 0x001A7C08 File Offset: 0x001A5E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryTopInfoNotify other)
		{
			return other != null && (other == this || (this.honamiStoryTopInfos_.Equals(other.honamiStoryTopInfos_) && this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B0C2 RID: 45250 RVA: 0x001A7C58 File Offset: 0x001A5E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.honamiStoryTopInfos_.GetHashCode();
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B0C3 RID: 45251 RVA: 0x001A7CA5 File Offset: 0x001A5EA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B0C4 RID: 45252 RVA: 0x001A7CB2 File Offset: 0x001A5EB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B0C5 RID: 45253 RVA: 0x001A7CBC File Offset: 0x001A5EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.honamiStoryTopInfos_.WriteTo(ref output, HonamiStoryTopInfoNotify._repeated_honamiStoryTopInfos_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B0C6 RID: 45254 RVA: 0x001A7D0C File Offset: 0x001A5F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.honamiStoryTopInfos_.CalculateSize(HonamiStoryTopInfoNotify._repeated_honamiStoryTopInfos_codec);
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B0C7 RID: 45255 RVA: 0x001A7D60 File Offset: 0x001A5F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryTopInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.honamiStoryTopInfos_.Add(other.honamiStoryTopInfos_);
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B0C8 RID: 45256 RVA: 0x001A7DAD File Offset: 0x001A5FAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B0C9 RID: 45257 RVA: 0x001A7DB8 File Offset: 0x001A5FB8
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
				if (num != 18U)
				{
					if (num != 24U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.honamiStoryTopInfos_.AddEntriesFrom(ref input, HonamiStoryTopInfoNotify._repeated_honamiStoryTopInfos_codec);
				}
			}
		}

		// Token: 0x04004F55 RID: 20309
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F56 RID: 20310
		public const int HonamiStoryTopInfosFieldNumber = 2;

		// Token: 0x04004F57 RID: 20311
		private static readonly FieldCodec<HonamiStoryTopInfo> _repeated_honamiStoryTopInfos_codec = FieldCodec.ForMessage<HonamiStoryTopInfo>(18U, HonamiStoryTopInfo.Parser);

		// Token: 0x04004F58 RID: 20312
		private readonly RepeatedField<HonamiStoryTopInfo> honamiStoryTopInfos_ = new RepeatedField<HonamiStoryTopInfo>();

		// Token: 0x04004F59 RID: 20313
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x04004F5A RID: 20314
		private int activityId_;
	}
}
