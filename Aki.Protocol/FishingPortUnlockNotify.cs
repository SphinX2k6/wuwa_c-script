using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000570 RID: 1392
	[NetMessage(EMessageId.FishingPortUnlockNotify)]
	public sealed class FishingPortUnlockNotify : IMessage<FishingPortUnlockNotify>, IMessage, IEquatable<FishingPortUnlockNotify>, IDeepCloneable<FishingPortUnlockNotify>, IBufferMessage
	{
		// Token: 0x0600819B RID: 33179 RVA: 0x001391D3 File Offset: 0x001373D3
		[NullableContext(1)]
		public static FishingPortUnlockNotify Create()
		{
			return new FishingPortUnlockNotify();
		}

		// Token: 0x17001946 RID: 6470
		// (get) Token: 0x0600819C RID: 33180 RVA: 0x001391DA File Offset: 0x001373DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001947 RID: 6471
		// (get) Token: 0x0600819D RID: 33181 RVA: 0x001391DD File Offset: 0x001373DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingPortUnlockNotify.Descriptor;
			}
		}

		// Token: 0x0600819E RID: 33182 RVA: 0x001391E4 File Offset: 0x001373E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingPortUnlockNotify()
		{
		}

		// Token: 0x0600819F RID: 33183 RVA: 0x001391F7 File Offset: 0x001373F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingPortUnlockNotify(FishingPortUnlockNotify other) : this()
		{
			this.unlockPortId_ = other.unlockPortId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060081A0 RID: 33184 RVA: 0x00139221 File Offset: 0x00137421
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingPortUnlockNotify Clone()
		{
			return new FishingPortUnlockNotify(this);
		}

		// Token: 0x17001948 RID: 6472
		// (get) Token: 0x060081A1 RID: 33185 RVA: 0x00139229 File Offset: 0x00137429
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockPortId
		{
			get
			{
				return this.unlockPortId_;
			}
		}

		// Token: 0x060081A2 RID: 33186 RVA: 0x00139231 File Offset: 0x00137431
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingPortUnlockNotify);
		}

		// Token: 0x060081A3 RID: 33187 RVA: 0x0013923F File Offset: 0x0013743F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingPortUnlockNotify other)
		{
			return other != null && (other == this || (this.unlockPortId_.Equals(other.unlockPortId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060081A4 RID: 33188 RVA: 0x00139274 File Offset: 0x00137474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockPortId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060081A5 RID: 33189 RVA: 0x001392A8 File Offset: 0x001374A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060081A6 RID: 33190 RVA: 0x001392B5 File Offset: 0x001374B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060081A7 RID: 33191 RVA: 0x001392BE File Offset: 0x001374BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockPortId_.WriteTo(ref output, FishingPortUnlockNotify._repeated_unlockPortId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060081A8 RID: 33192 RVA: 0x001392E8 File Offset: 0x001374E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockPortId_.CalculateSize(FishingPortUnlockNotify._repeated_unlockPortId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060081A9 RID: 33193 RVA: 0x00139321 File Offset: 0x00137521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingPortUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockPortId_.Add(other.unlockPortId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060081AA RID: 33194 RVA: 0x0013934F File Offset: 0x0013754F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060081AB RID: 33195 RVA: 0x00139358 File Offset: 0x00137558
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
				if (num != 56U && num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.unlockPortId_.AddEntriesFrom(ref input, FishingPortUnlockNotify._repeated_unlockPortId_codec);
				}
			}
		}

		// Token: 0x0400410F RID: 16655
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004110 RID: 16656
		public const int UnlockPortIdFieldNumber = 7;

		// Token: 0x04004111 RID: 16657
		private static readonly FieldCodec<int> _repeated_unlockPortId_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04004112 RID: 16658
		private readonly RepeatedField<int> unlockPortId_ = new RepeatedField<int>();
	}
}
