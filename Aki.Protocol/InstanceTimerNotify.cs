using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000809 RID: 2057
	[NetMessage(EMessageId.InstanceTimerNotify)]
	public sealed class InstanceTimerNotify : IMessage<InstanceTimerNotify>, IMessage, IEquatable<InstanceTimerNotify>, IDeepCloneable<InstanceTimerNotify>, IBufferMessage
	{
		// Token: 0x0600B844 RID: 47172 RVA: 0x001B726B File Offset: 0x001B546B
		[NullableContext(1)]
		public static InstanceTimerNotify Create()
		{
			return new InstanceTimerNotify();
		}

		// Token: 0x1700251B RID: 9499
		// (get) Token: 0x0600B845 RID: 47173 RVA: 0x001B7272 File Offset: 0x001B5472
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700251C RID: 9500
		// (get) Token: 0x0600B846 RID: 47174 RVA: 0x001B7275 File Offset: 0x001B5475
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InstanceTimerNotify.Descriptor;
			}
		}

		// Token: 0x0600B847 RID: 47175 RVA: 0x001B727C File Offset: 0x001B547C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstanceTimerNotify()
		{
		}

		// Token: 0x0600B848 RID: 47176 RVA: 0x001B728F File Offset: 0x001B548F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstanceTimerNotify(InstanceTimerNotify other) : this()
		{
			this.instanceTimers_ = other.instanceTimers_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B849 RID: 47177 RVA: 0x001B72B9 File Offset: 0x001B54B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstanceTimerNotify Clone()
		{
			return new InstanceTimerNotify(this);
		}

		// Token: 0x1700251D RID: 9501
		// (get) Token: 0x0600B84A RID: 47178 RVA: 0x001B72C1 File Offset: 0x001B54C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, InstanceTimer> InstanceTimers
		{
			get
			{
				return this.instanceTimers_;
			}
		}

		// Token: 0x0600B84B RID: 47179 RVA: 0x001B72C9 File Offset: 0x001B54C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InstanceTimerNotify);
		}

		// Token: 0x0600B84C RID: 47180 RVA: 0x001B72D7 File Offset: 0x001B54D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InstanceTimerNotify other)
		{
			return other != null && (other == this || (this.InstanceTimers.Equals(other.InstanceTimers) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B84D RID: 47181 RVA: 0x001B730C File Offset: 0x001B550C
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

		// Token: 0x0600B84E RID: 47182 RVA: 0x001B7340 File Offset: 0x001B5540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B84F RID: 47183 RVA: 0x001B734D File Offset: 0x001B554D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B850 RID: 47184 RVA: 0x001B7356 File Offset: 0x001B5556
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

		// Token: 0x0600B851 RID: 47185 RVA: 0x001B7380 File Offset: 0x001B5580
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

		// Token: 0x0600B852 RID: 47186 RVA: 0x001B73B9 File Offset: 0x001B55B9
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

		// Token: 0x0600B853 RID: 47187 RVA: 0x001B73E7 File Offset: 0x001B55E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B854 RID: 47188 RVA: 0x001B73F0 File Offset: 0x001B55F0
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
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.instanceTimers_.AddEntriesFrom(ref input, InstanceTimerNotify._map_instanceTimers_codec);
				}
			}
		}

		// Token: 0x04005185 RID: 20869
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005186 RID: 20870
		public const int InstanceTimersFieldNumber = 15;

		// Token: 0x04005187 RID: 20871
		private static readonly MapField<int, InstanceTimer>.Codec _map_instanceTimers_codec = new MapField<int, InstanceTimer>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<InstanceTimer>(18U, InstanceTimer.Parser), 122U);

		// Token: 0x04005188 RID: 20872
		private readonly MapField<int, InstanceTimer> instanceTimers_ = new MapField<int, InstanceTimer>();
	}
}
