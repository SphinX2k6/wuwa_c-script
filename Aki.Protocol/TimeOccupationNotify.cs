using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013EB RID: 5099
	[NetMessage(EMessageId.TimeOccupationNotify)]
	public sealed class TimeOccupationNotify : IMessage<TimeOccupationNotify>, IMessage, IEquatable<TimeOccupationNotify>, IDeepCloneable<TimeOccupationNotify>, IBufferMessage
	{
		// Token: 0x0601B1F2 RID: 111090 RVA: 0x003F29D6 File Offset: 0x003F0BD6
		[NullableContext(1)]
		public static TimeOccupationNotify Create()
		{
			return new TimeOccupationNotify();
		}

		// Token: 0x17005BD7 RID: 23511
		// (get) Token: 0x0601B1F3 RID: 111091 RVA: 0x003F29DD File Offset: 0x003F0BDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005BD8 RID: 23512
		// (get) Token: 0x0601B1F4 RID: 111092 RVA: 0x003F29E0 File Offset: 0x003F0BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimeOccupationNotify.Descriptor;
			}
		}

		// Token: 0x0601B1F5 RID: 111093 RVA: 0x003F29E7 File Offset: 0x003F0BE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeOccupationNotify()
		{
		}

		// Token: 0x0601B1F6 RID: 111094 RVA: 0x003F29EF File Offset: 0x003F0BEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeOccupationNotify(TimeOccupationNotify other) : this()
		{
			this.handleType_ = other.handleType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B1F7 RID: 111095 RVA: 0x003F2A14 File Offset: 0x003F0C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeOccupationNotify Clone()
		{
			return new TimeOccupationNotify(this);
		}

		// Token: 0x17005BD9 RID: 23513
		// (get) Token: 0x0601B1F8 RID: 111096 RVA: 0x003F2A1C File Offset: 0x003F0C1C
		// (set) Token: 0x0601B1F9 RID: 111097 RVA: 0x003F2A24 File Offset: 0x003F0C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeHandleType HandleType
		{
			get
			{
				return this.handleType_;
			}
			set
			{
				this.handleType_ = value;
			}
		}

		// Token: 0x0601B1FA RID: 111098 RVA: 0x003F2A2D File Offset: 0x003F0C2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimeOccupationNotify);
		}

		// Token: 0x0601B1FB RID: 111099 RVA: 0x003F2A3B File Offset: 0x003F0C3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimeOccupationNotify other)
		{
			return other != null && (other == this || (this.HandleType == other.HandleType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B1FC RID: 111100 RVA: 0x003F2A6C File Offset: 0x003F0C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HandleType != TimeHandleType.Lock)
			{
				num ^= this.HandleType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B1FD RID: 111101 RVA: 0x003F2AB1 File Offset: 0x003F0CB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B1FE RID: 111102 RVA: 0x003F2ABE File Offset: 0x003F0CBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B1FF RID: 111103 RVA: 0x003F2AC7 File Offset: 0x003F0CC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HandleType != TimeHandleType.Lock)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.HandleType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B200 RID: 111104 RVA: 0x003F2AFC File Offset: 0x003F0CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HandleType != TimeHandleType.Lock)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.HandleType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B201 RID: 111105 RVA: 0x003F2B3A File Offset: 0x003F0D3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TimeOccupationNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HandleType != TimeHandleType.Lock)
			{
				this.HandleType = other.HandleType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B202 RID: 111106 RVA: 0x003F2B6B File Offset: 0x003F0D6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B203 RID: 111107 RVA: 0x003F2B74 File Offset: 0x003F0D74
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
					this.HandleType = (TimeHandleType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009E51 RID: 40529
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E52 RID: 40530
		public const int HandleTypeFieldNumber = 9;

		// Token: 0x04009E53 RID: 40531
		private TimeHandleType handleType_;
	}
}
