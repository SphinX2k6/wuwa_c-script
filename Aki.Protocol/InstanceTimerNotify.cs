using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200081D RID: 2077
	[NetMessage(EMessageId.InstanceTimerNotify)]
	public sealed class InstanceTimerNotify : IMessage<InstanceTimerNotify>, IMessage, IEquatable<InstanceTimerNotify>, IDeepCloneable<InstanceTimerNotify>, IBufferMessage
	{
		// Token: 0x0600B99A RID: 47514 RVA: 0x001B9CA7 File Offset: 0x001B7EA7
		[NullableContext(1)]
		public static InstanceTimerNotify Create()
		{
			return new InstanceTimerNotify();
		}

		// Token: 0x17002565 RID: 9573
		// (get) Token: 0x0600B99B RID: 47515 RVA: 0x001B9CAE File Offset: 0x001B7EAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002566 RID: 9574
		// (get) Token: 0x0600B99C RID: 47516 RVA: 0x001B9CB1 File Offset: 0x001B7EB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InstanceTimerNotify.Descriptor;
			}
		}

		// Token: 0x0600B99D RID: 47517 RVA: 0x001B9CB8 File Offset: 0x001B7EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstanceTimerNotify()
		{
		}

		// Token: 0x0600B99E RID: 47518 RVA: 0x001B9CCB File Offset: 0x001B7ECB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstanceTimerNotify(InstanceTimerNotify other) : this()
		{
			this.instanceTimers_ = other.instanceTimers_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B99F RID: 47519 RVA: 0x001B9CF5 File Offset: 0x001B7EF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstanceTimerNotify Clone()
		{
			return new InstanceTimerNotify(this);
		}

		// Token: 0x17002567 RID: 9575
		// (get) Token: 0x0600B9A0 RID: 47520 RVA: 0x001B9CFD File Offset: 0x001B7EFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, InstanceTimer> InstanceTimers
		{
			get
			{
				return this.instanceTimers_;
			}
		}

		// Token: 0x0600B9A1 RID: 47521 RVA: 0x001B9D05 File Offset: 0x001B7F05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InstanceTimerNotify);
		}

		// Token: 0x0600B9A2 RID: 47522 RVA: 0x001B9D13 File Offset: 0x001B7F13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InstanceTimerNotify other)
		{
			return other != null && (other == this || (this.InstanceTimers.Equals(other.InstanceTimers) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B9A3 RID: 47523 RVA: 0x001B9D48 File Offset: 0x001B7F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.InstanceTimers.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B9A4 RID: 47524 RVA: 0x001B9D7C File Offset: 0x001B7F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B9A5 RID: 47525 RVA: 0x001B9D89 File Offset: 0x001B7F89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B9A6 RID: 47526 RVA: 0x001B9D92 File Offset: 0x001B7F92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.instanceTimers_.WriteTo(ref output, InstanceTimerNotify._map_instanceTimers_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B9A7 RID: 47527 RVA: 0x001B9DBC File Offset: 0x001B7FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.instanceTimers_.CalculateSize(InstanceTimerNotify._map_instanceTimers_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B9A8 RID: 47528 RVA: 0x001B9DF5 File Offset: 0x001B7FF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InstanceTimerNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.instanceTimers_.MergeFrom(other.instanceTimers_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B9A9 RID: 47529 RVA: 0x001B9E23 File Offset: 0x001B8023
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B9AA RID: 47530 RVA: 0x001B9E2C File Offset: 0x001B802C
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.instanceTimers_.AddEntriesFrom(ref input, InstanceTimerNotify._map_instanceTimers_codec);
				}
			}
		}

		// Token: 0x0400518C RID: 20876
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400518D RID: 20877
		public const int InstanceTimersFieldNumber = 1;

		// Token: 0x0400518E RID: 20878
		private static readonly MapField<int, InstanceTimer>.Codec _map_instanceTimers_codec = new MapField<int, InstanceTimer>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<InstanceTimer>(18U, InstanceTimer.Parser), 10U);

		// Token: 0x0400518F RID: 20879
		private readonly MapField<int, InstanceTimer> instanceTimers_ = new MapField<int, InstanceTimer>();
	}
}
