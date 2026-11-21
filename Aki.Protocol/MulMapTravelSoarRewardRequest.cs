using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ACF RID: 2767
	[NetMessage(EMessageId.MulMapTravelSoarRewardRequest)]
	public sealed class MulMapTravelSoarRewardRequest : IMessage<MulMapTravelSoarRewardRequest>, IMessage, IEquatable<MulMapTravelSoarRewardRequest>, IDeepCloneable<MulMapTravelSoarRewardRequest>, IBufferMessage
	{
		// Token: 0x0600F117 RID: 61719 RVA: 0x00233B20 File Offset: 0x00231D20
		[NullableContext(1)]
		public static MulMapTravelSoarRewardRequest Create()
		{
			return new MulMapTravelSoarRewardRequest();
		}

		// Token: 0x17003112 RID: 12562
		// (get) Token: 0x0600F118 RID: 61720 RVA: 0x00233B27 File Offset: 0x00231D27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003113 RID: 12563
		// (get) Token: 0x0600F119 RID: 61721 RVA: 0x00233B2A File Offset: 0x00231D2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MulMapTravelSoarRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600F11A RID: 61722 RVA: 0x00233B31 File Offset: 0x00231D31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulMapTravelSoarRewardRequest()
		{
		}

		// Token: 0x0600F11B RID: 61723 RVA: 0x00233B44 File Offset: 0x00231D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulMapTravelSoarRewardRequest(MulMapTravelSoarRewardRequest other) : this()
		{
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F11C RID: 61724 RVA: 0x00233B6E File Offset: 0x00231D6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulMapTravelSoarRewardRequest Clone()
		{
			return new MulMapTravelSoarRewardRequest(this);
		}

		// Token: 0x17003114 RID: 12564
		// (get) Token: 0x0600F11D RID: 61725 RVA: 0x00233B76 File Offset: 0x00231D76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x0600F11E RID: 61726 RVA: 0x00233B7E File Offset: 0x00231D7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MulMapTravelSoarRewardRequest);
		}

		// Token: 0x0600F11F RID: 61727 RVA: 0x00233B8C File Offset: 0x00231D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MulMapTravelSoarRewardRequest other)
		{
			return other != null && (other == this || (this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F120 RID: 61728 RVA: 0x00233BC0 File Offset: 0x00231DC0
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

		// Token: 0x0600F121 RID: 61729 RVA: 0x00233BF4 File Offset: 0x00231DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F122 RID: 61730 RVA: 0x00233C01 File Offset: 0x00231E01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F123 RID: 61731 RVA: 0x00233C0A File Offset: 0x00231E0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, MulMapTravelSoarRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F124 RID: 61732 RVA: 0x00233C34 File Offset: 0x00231E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.taskIds_.CalculateSize(MulMapTravelSoarRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F125 RID: 61733 RVA: 0x00233C6D File Offset: 0x00231E6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MulMapTravelSoarRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.taskIds_.Add(other.taskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F126 RID: 61734 RVA: 0x00233C9B File Offset: 0x00231E9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F127 RID: 61735 RVA: 0x00233CA4 File Offset: 0x00231EA4
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
				if (num != 104U && num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.taskIds_.AddEntriesFrom(ref input, MulMapTravelSoarRewardRequest._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x040061C5 RID: 25029
		private UnknownFieldSet _unknownFields;

		// Token: 0x040061C6 RID: 25030
		public const int TaskIdsFieldNumber = 13;

		// Token: 0x040061C7 RID: 25031
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(106U);

		// Token: 0x040061C8 RID: 25032
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
