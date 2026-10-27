using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001381 RID: 4993
	[NetMessage(EMessageId.TimeResetNotify)]
	public sealed class TimeResetNotify : IMessage<TimeResetNotify>, IMessage, IEquatable<TimeResetNotify>, IDeepCloneable<TimeResetNotify>, IBufferMessage
	{
		// Token: 0x0601A813 RID: 108563 RVA: 0x003D8C0D File Offset: 0x003D6E0D
		[NullableContext(1)]
		public static TimeResetNotify Create()
		{
			return new TimeResetNotify();
		}

		// Token: 0x17005962 RID: 22882
		// (get) Token: 0x0601A814 RID: 108564 RVA: 0x003D8C14 File Offset: 0x003D6E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005963 RID: 22883
		// (get) Token: 0x0601A815 RID: 108565 RVA: 0x003D8C17 File Offset: 0x003D6E17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimeResetNotify.Descriptor;
			}
		}

		// Token: 0x0601A816 RID: 108566 RVA: 0x003D8C1E File Offset: 0x003D6E1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeResetNotify()
		{
		}

		// Token: 0x0601A817 RID: 108567 RVA: 0x003D8C26 File Offset: 0x003D6E26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeResetNotify(TimeResetNotify other) : this()
		{
			this.resetId_ = other.resetId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A818 RID: 108568 RVA: 0x003D8C4B File Offset: 0x003D6E4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeResetNotify Clone()
		{
			return new TimeResetNotify(this);
		}

		// Token: 0x17005964 RID: 22884
		// (get) Token: 0x0601A819 RID: 108569 RVA: 0x003D8C53 File Offset: 0x003D6E53
		// (set) Token: 0x0601A81A RID: 108570 RVA: 0x003D8C5B File Offset: 0x003D6E5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ResetId
		{
			get
			{
				return this.resetId_;
			}
			set
			{
				this.resetId_ = value;
			}
		}

		// Token: 0x0601A81B RID: 108571 RVA: 0x003D8C64 File Offset: 0x003D6E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimeResetNotify);
		}

		// Token: 0x0601A81C RID: 108572 RVA: 0x003D8C72 File Offset: 0x003D6E72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimeResetNotify other)
		{
			return other != null && (other == this || (this.ResetId == other.ResetId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A81D RID: 108573 RVA: 0x003D8CA0 File Offset: 0x003D6EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ResetId != 0)
			{
				num ^= this.ResetId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A81E RID: 108574 RVA: 0x003D8CDF File Offset: 0x003D6EDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A81F RID: 108575 RVA: 0x003D8CEC File Offset: 0x003D6EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A820 RID: 108576 RVA: 0x003D8CF5 File Offset: 0x003D6EF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ResetId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ResetId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A821 RID: 108577 RVA: 0x003D8D28 File Offset: 0x003D6F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ResetId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ResetId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A822 RID: 108578 RVA: 0x003D8D66 File Offset: 0x003D6F66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TimeResetNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ResetId != 0)
			{
				this.ResetId = other.ResetId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A823 RID: 108579 RVA: 0x003D8D97 File Offset: 0x003D6F97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A824 RID: 108580 RVA: 0x003D8DA0 File Offset: 0x003D6FA0
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ResetId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009A31 RID: 39473
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A32 RID: 39474
		public const int ResetIdFieldNumber = 9;

		// Token: 0x04009A33 RID: 39475
		private int resetId_;
	}
}
