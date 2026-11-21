using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000415 RID: 1045
	[NetMessage(EMessageId.EffectiveWeekCardInfoNotify)]
	public sealed class EffectiveWeekCardInfoNotify : IMessage<EffectiveWeekCardInfoNotify>, IMessage, IEquatable<EffectiveWeekCardInfoNotify>, IDeepCloneable<EffectiveWeekCardInfoNotify>, IBufferMessage
	{
		// Token: 0x060064F5 RID: 25845 RVA: 0x000F367D File Offset: 0x000F187D
		[NullableContext(1)]
		public static EffectiveWeekCardInfoNotify Create()
		{
			return new EffectiveWeekCardInfoNotify();
		}

		// Token: 0x170012EC RID: 4844
		// (get) Token: 0x060064F6 RID: 25846 RVA: 0x000F3684 File Offset: 0x000F1884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170012ED RID: 4845
		// (get) Token: 0x060064F7 RID: 25847 RVA: 0x000F3687 File Offset: 0x000F1887
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EffectiveWeekCardInfoNotify.Descriptor;
			}
		}

		// Token: 0x060064F8 RID: 25848 RVA: 0x000F368E File Offset: 0x000F188E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EffectiveWeekCardInfoNotify()
		{
		}

		// Token: 0x060064F9 RID: 25849 RVA: 0x000F36A4 File Offset: 0x000F18A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EffectiveWeekCardInfoNotify(EffectiveWeekCardInfoNotify other) : this()
		{
			this.infos_ = ((other.infos_ != null) ? other.infos_.Clone() : null);
			this.weekCardInfos_ = other.weekCardInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060064FA RID: 25850 RVA: 0x000F36F5 File Offset: 0x000F18F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EffectiveWeekCardInfoNotify Clone()
		{
			return new EffectiveWeekCardInfoNotify(this);
		}

		// Token: 0x170012EE RID: 4846
		// (get) Token: 0x060064FB RID: 25851 RVA: 0x000F36FD File Offset: 0x000F18FD
		// (set) Token: 0x060064FC RID: 25852 RVA: 0x000F3705 File Offset: 0x000F1905
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

		// Token: 0x170012EF RID: 4847
		// (get) Token: 0x060064FD RID: 25853 RVA: 0x000F370E File Offset: 0x000F190E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<WeekCardInfo> WeekCardInfos
		{
			get
			{
				return this.weekCardInfos_;
			}
		}

		// Token: 0x060064FE RID: 25854 RVA: 0x000F3716 File Offset: 0x000F1916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EffectiveWeekCardInfoNotify);
		}

		// Token: 0x060064FF RID: 25855 RVA: 0x000F3724 File Offset: 0x000F1924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EffectiveWeekCardInfoNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Infos, other.Infos) && this.weekCardInfos_.Equals(other.weekCardInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006500 RID: 25856 RVA: 0x000F3778 File Offset: 0x000F1978
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

		// Token: 0x06006501 RID: 25857 RVA: 0x000F37C2 File Offset: 0x000F19C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006502 RID: 25858 RVA: 0x000F37CF File Offset: 0x000F19CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006503 RID: 25859 RVA: 0x000F37D8 File Offset: 0x000F19D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.weekCardInfos_.WriteTo(ref output, EffectiveWeekCardInfoNotify._repeated_weekCardInfos_codec);
			if (this.infos_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.Infos);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006504 RID: 25860 RVA: 0x000F3828 File Offset: 0x000F1A28
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

		// Token: 0x06006505 RID: 25861 RVA: 0x000F387C File Offset: 0x000F1A7C
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

		// Token: 0x06006506 RID: 25862 RVA: 0x000F38E1 File Offset: 0x000F1AE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006507 RID: 25863 RVA: 0x000F38EC File Offset: 0x000F1AEC
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
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.weekCardInfos_.AddEntriesFrom(ref input, EffectiveWeekCardInfoNotify._repeated_weekCardInfos_codec);
				}
			}
		}

		// Token: 0x04003914 RID: 14612
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003915 RID: 14613
		public const int InfosFieldNumber = 15;

		// Token: 0x04003916 RID: 14614
		private WeekCardInfo infos_;

		// Token: 0x04003917 RID: 14615
		public const int WeekCardInfosFieldNumber = 4;

		// Token: 0x04003918 RID: 14616
		private static readonly FieldCodec<WeekCardInfo> _repeated_weekCardInfos_codec = FieldCodec.ForMessage<WeekCardInfo>(34U, WeekCardInfo.Parser);

		// Token: 0x04003919 RID: 14617
		private readonly RepeatedField<WeekCardInfo> weekCardInfos_ = new RepeatedField<WeekCardInfo>();
	}
}
