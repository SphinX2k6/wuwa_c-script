using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D63 RID: 3427
	[NetMessage(EMessageId.PinballTaskRewardRequest)]
	public sealed class PinballTaskRewardRequest : IMessage<PinballTaskRewardRequest>, IMessage, IEquatable<PinballTaskRewardRequest>, IDeepCloneable<PinballTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x060127BC RID: 75708 RVA: 0x002B27B3 File Offset: 0x002B09B3
		[NullableContext(1)]
		public static PinballTaskRewardRequest Create()
		{
			return new PinballTaskRewardRequest();
		}

		// Token: 0x17003D47 RID: 15687
		// (get) Token: 0x060127BD RID: 75709 RVA: 0x002B27BA File Offset: 0x002B09BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D48 RID: 15688
		// (get) Token: 0x060127BE RID: 75710 RVA: 0x002B27BD File Offset: 0x002B09BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x060127BF RID: 75711 RVA: 0x002B27C4 File Offset: 0x002B09C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballTaskRewardRequest()
		{
		}

		// Token: 0x060127C0 RID: 75712 RVA: 0x002B27D7 File Offset: 0x002B09D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballTaskRewardRequest(PinballTaskRewardRequest other) : this()
		{
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060127C1 RID: 75713 RVA: 0x002B2801 File Offset: 0x002B0A01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballTaskRewardRequest Clone()
		{
			return new PinballTaskRewardRequest(this);
		}

		// Token: 0x17003D49 RID: 15689
		// (get) Token: 0x060127C2 RID: 75714 RVA: 0x002B2809 File Offset: 0x002B0A09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x060127C3 RID: 75715 RVA: 0x002B2811 File Offset: 0x002B0A11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballTaskRewardRequest);
		}

		// Token: 0x060127C4 RID: 75716 RVA: 0x002B281F File Offset: 0x002B0A1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballTaskRewardRequest other)
		{
			return other != null && (other == this || (this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060127C5 RID: 75717 RVA: 0x002B2854 File Offset: 0x002B0A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.taskIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060127C6 RID: 75718 RVA: 0x002B2888 File Offset: 0x002B0A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060127C7 RID: 75719 RVA: 0x002B2895 File Offset: 0x002B0A95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060127C8 RID: 75720 RVA: 0x002B289E File Offset: 0x002B0A9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, PinballTaskRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060127C9 RID: 75721 RVA: 0x002B28C8 File Offset: 0x002B0AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.taskIds_.CalculateSize(PinballTaskRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060127CA RID: 75722 RVA: 0x002B2901 File Offset: 0x002B0B01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballTaskRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.taskIds_.Add(other.taskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060127CB RID: 75723 RVA: 0x002B292F File Offset: 0x002B0B2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060127CC RID: 75724 RVA: 0x002B2938 File Offset: 0x002B0B38
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
				if (num != 64U && num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.taskIds_.AddEntriesFrom(ref input, PinballTaskRewardRequest._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x040072F9 RID: 29433
		private UnknownFieldSet _unknownFields;

		// Token: 0x040072FA RID: 29434
		public const int TaskIdsFieldNumber = 8;

		// Token: 0x040072FB RID: 29435
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(66U);

		// Token: 0x040072FC RID: 29436
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
