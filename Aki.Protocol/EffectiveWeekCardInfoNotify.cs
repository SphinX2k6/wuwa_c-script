using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200042C RID: 1068
	[NetMessage(EMessageId.EffectiveWeekCardInfoNotify)]
	public sealed class EffectiveWeekCardInfoNotify : IMessage<EffectiveWeekCardInfoNotify>, IMessage, IEquatable<EffectiveWeekCardInfoNotify>, IDeepCloneable<EffectiveWeekCardInfoNotify>, IBufferMessage
	{
		// Token: 0x06006685 RID: 26245 RVA: 0x000F67F2 File Offset: 0x000F49F2
		[NullableContext(1)]
		public static EffectiveWeekCardInfoNotify Create()
		{
			return new EffectiveWeekCardInfoNotify();
		}

		// Token: 0x17001341 RID: 4929
		// (get) Token: 0x06006686 RID: 26246 RVA: 0x000F67F9 File Offset: 0x000F49F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001342 RID: 4930
		// (get) Token: 0x06006687 RID: 26247 RVA: 0x000F67FC File Offset: 0x000F49FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EffectiveWeekCardInfoNotify.Descriptor;
			}
		}

		// Token: 0x06006688 RID: 26248 RVA: 0x000F6803 File Offset: 0x000F4A03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EffectiveWeekCardInfoNotify()
		{
		}

		// Token: 0x06006689 RID: 26249 RVA: 0x000F6818 File Offset: 0x000F4A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EffectiveWeekCardInfoNotify(EffectiveWeekCardInfoNotify other) : this()
		{
			this.infos_ = ((other.infos_ != null) ? other.infos_.Clone() : null);
			this.weekCardInfos_ = other.weekCardInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600668A RID: 26250 RVA: 0x000F6869 File Offset: 0x000F4A69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EffectiveWeekCardInfoNotify Clone()
		{
			return new EffectiveWeekCardInfoNotify(this);
		}

		// Token: 0x17001343 RID: 4931
		// (get) Token: 0x0600668B RID: 26251 RVA: 0x000F6871 File Offset: 0x000F4A71
		// (set) Token: 0x0600668C RID: 26252 RVA: 0x000F6879 File Offset: 0x000F4A79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeekCardInfo Infos
		{
			get
			{
				return this.infos_;
			}
			set
			{
				this.infos_ = value;
			}
		}

		// Token: 0x17001344 RID: 4932
		// (get) Token: 0x0600668D RID: 26253 RVA: 0x000F6882 File Offset: 0x000F4A82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<WeekCardInfo> WeekCardInfos
		{
			get
			{
				return this.weekCardInfos_;
			}
		}

		// Token: 0x0600668E RID: 26254 RVA: 0x000F688A File Offset: 0x000F4A8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EffectiveWeekCardInfoNotify);
		}

		// Token: 0x0600668F RID: 26255 RVA: 0x000F6898 File Offset: 0x000F4A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EffectiveWeekCardInfoNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Infos, other.Infos) && this.weekCardInfos_.Equals(other.weekCardInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006690 RID: 26256 RVA: 0x000F68EC File Offset: 0x000F4AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.infos_ != null)
			{
				num ^= this.Infos.GetHashCode();
			}
			num ^= this.weekCardInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006691 RID: 26257 RVA: 0x000F6936 File Offset: 0x000F4B36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006692 RID: 26258 RVA: 0x000F6943 File Offset: 0x000F4B43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006693 RID: 26259 RVA: 0x000F694C File Offset: 0x000F4B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.infos_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Infos);
			}
			this.weekCardInfos_.WriteTo(ref output, EffectiveWeekCardInfoNotify._repeated_weekCardInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006694 RID: 26260 RVA: 0x000F699C File Offset: 0x000F4B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.infos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Infos);
			}
			num += this.weekCardInfos_.CalculateSize(EffectiveWeekCardInfoNotify._repeated_weekCardInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006695 RID: 26261 RVA: 0x000F69F0 File Offset: 0x000F4BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EffectiveWeekCardInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.infos_ != null)
			{
				if (this.infos_ == null)
				{
					this.Infos = new WeekCardInfo();
				}
				this.Infos.MergeFrom(other.Infos);
			}
			this.weekCardInfos_.Add(other.weekCardInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006696 RID: 26262 RVA: 0x000F6A55 File Offset: 0x000F4C55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006697 RID: 26263 RVA: 0x000F6A60 File Offset: 0x000F4C60
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
				if (num != 34U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.weekCardInfos_.AddEntriesFrom(ref input, EffectiveWeekCardInfoNotify._repeated_weekCardInfos_codec);
					}
				}
				else
				{
					if (this.infos_ == null)
					{
						this.Infos = new WeekCardInfo();
					}
					input.ReadMessage(this.Infos);
				}
			}
		}

		// Token: 0x04003927 RID: 14631
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003928 RID: 14632
		public const int InfosFieldNumber = 4;

		// Token: 0x04003929 RID: 14633
		private WeekCardInfo infos_;

		// Token: 0x0400392A RID: 14634
		public const int WeekCardInfosFieldNumber = 11;

		// Token: 0x0400392B RID: 14635
		private static readonly FieldCodec<WeekCardInfo> _repeated_weekCardInfos_codec = FieldCodec.ForMessage<WeekCardInfo>(90U, WeekCardInfo.Parser);

		// Token: 0x0400392C RID: 14636
		private readonly RepeatedField<WeekCardInfo> weekCardInfos_ = new RepeatedField<WeekCardInfo>();
	}
}
