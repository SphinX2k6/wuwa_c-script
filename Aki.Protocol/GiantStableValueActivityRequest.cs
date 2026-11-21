using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006D2 RID: 1746
	[NetMessage(EMessageId.GiantStableValueActivityRequest)]
	public sealed class GiantStableValueActivityRequest : IMessage<GiantStableValueActivityRequest>, IMessage, IEquatable<GiantStableValueActivityRequest>, IDeepCloneable<GiantStableValueActivityRequest>, IBufferMessage
	{
		// Token: 0x06009FC8 RID: 40904 RVA: 0x00183633 File Offset: 0x00181833
		[NullableContext(1)]
		public static GiantStableValueActivityRequest Create()
		{
			return new GiantStableValueActivityRequest();
		}

		// Token: 0x17002015 RID: 8213
		// (get) Token: 0x06009FC9 RID: 40905 RVA: 0x0018363A File Offset: 0x0018183A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002016 RID: 8214
		// (get) Token: 0x06009FCA RID: 40906 RVA: 0x0018363D File Offset: 0x0018183D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiantStableValueActivityRequest.Descriptor;
			}
		}

		// Token: 0x06009FCB RID: 40907 RVA: 0x00183644 File Offset: 0x00181844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantStableValueActivityRequest()
		{
		}

		// Token: 0x06009FCC RID: 40908 RVA: 0x00183657 File Offset: 0x00181857
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantStableValueActivityRequest(GiantStableValueActivityRequest other) : this()
		{
			this.rewardIds_ = other.rewardIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009FCD RID: 40909 RVA: 0x00183681 File Offset: 0x00181881
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantStableValueActivityRequest Clone()
		{
			return new GiantStableValueActivityRequest(this);
		}

		// Token: 0x17002017 RID: 8215
		// (get) Token: 0x06009FCE RID: 40910 RVA: 0x00183689 File Offset: 0x00181889
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardIds
		{
			get
			{
				return this.rewardIds_;
			}
		}

		// Token: 0x06009FCF RID: 40911 RVA: 0x00183691 File Offset: 0x00181891
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiantStableValueActivityRequest);
		}

		// Token: 0x06009FD0 RID: 40912 RVA: 0x0018369F File Offset: 0x0018189F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiantStableValueActivityRequest other)
		{
			return other != null && (other == this || (this.rewardIds_.Equals(other.rewardIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009FD1 RID: 40913 RVA: 0x001836D4 File Offset: 0x001818D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.rewardIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009FD2 RID: 40914 RVA: 0x00183708 File Offset: 0x00181908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009FD3 RID: 40915 RVA: 0x00183715 File Offset: 0x00181915
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009FD4 RID: 40916 RVA: 0x0018371E File Offset: 0x0018191E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rewardIds_.WriteTo(ref output, GiantStableValueActivityRequest._repeated_rewardIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009FD5 RID: 40917 RVA: 0x00183748 File Offset: 0x00181948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rewardIds_.CalculateSize(GiantStableValueActivityRequest._repeated_rewardIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009FD6 RID: 40918 RVA: 0x00183781 File Offset: 0x00181981
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GiantStableValueActivityRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.rewardIds_.Add(other.rewardIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009FD7 RID: 40919 RVA: 0x001837AF File Offset: 0x001819AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009FD8 RID: 40920 RVA: 0x001837B8 File Offset: 0x001819B8
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
				if (num != 32U && num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rewardIds_.AddEntriesFrom(ref input, GiantStableValueActivityRequest._repeated_rewardIds_codec);
				}
			}
		}

		// Token: 0x04004ADB RID: 19163
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004ADC RID: 19164
		public const int RewardIdsFieldNumber = 4;

		// Token: 0x04004ADD RID: 19165
		private static readonly FieldCodec<int> _repeated_rewardIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04004ADE RID: 19166
		private readonly RepeatedField<int> rewardIds_ = new RepeatedField<int>();
	}
}
