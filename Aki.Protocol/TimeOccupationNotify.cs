using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001378 RID: 4984
	[NetMessage(EMessageId.TimeOccupationNotify)]
	public sealed class TimeOccupationNotify : IMessage<TimeOccupationNotify>, IMessage, IEquatable<TimeOccupationNotify>, IDeepCloneable<TimeOccupationNotify>, IBufferMessage
	{
		// Token: 0x0601A769 RID: 108393 RVA: 0x003D77C2 File Offset: 0x003D59C2
		[NullableContext(1)]
		public static TimeOccupationNotify Create()
		{
			return new TimeOccupationNotify();
		}

		// Token: 0x17005943 RID: 22851
		// (get) Token: 0x0601A76A RID: 108394 RVA: 0x003D77C9 File Offset: 0x003D59C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005944 RID: 22852
		// (get) Token: 0x0601A76B RID: 108395 RVA: 0x003D77CC File Offset: 0x003D59CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimeOccupationNotify.Descriptor;
			}
		}

		// Token: 0x0601A76C RID: 108396 RVA: 0x003D77D3 File Offset: 0x003D59D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeOccupationNotify()
		{
		}

		// Token: 0x0601A76D RID: 108397 RVA: 0x003D77DB File Offset: 0x003D59DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeOccupationNotify(TimeOccupationNotify other) : this()
		{
			this.handleType_ = other.handleType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A76E RID: 108398 RVA: 0x003D7800 File Offset: 0x003D5A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimeOccupationNotify Clone()
		{
			return new TimeOccupationNotify(this);
		}

		// Token: 0x17005945 RID: 22853
		// (get) Token: 0x0601A76F RID: 108399 RVA: 0x003D7808 File Offset: 0x003D5A08
		// (set) Token: 0x0601A770 RID: 108400 RVA: 0x003D7810 File Offset: 0x003D5A10
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

		// Token: 0x0601A771 RID: 108401 RVA: 0x003D7819 File Offset: 0x003D5A19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimeOccupationNotify);
		}

		// Token: 0x0601A772 RID: 108402 RVA: 0x003D7827 File Offset: 0x003D5A27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimeOccupationNotify other)
		{
			return other != null && (other == this || (this.HandleType == other.HandleType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A773 RID: 108403 RVA: 0x003D7858 File Offset: 0x003D5A58
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

		// Token: 0x0601A774 RID: 108404 RVA: 0x003D789D File Offset: 0x003D5A9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A775 RID: 108405 RVA: 0x003D78AA File Offset: 0x003D5AAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A776 RID: 108406 RVA: 0x003D78B3 File Offset: 0x003D5AB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HandleType != TimeHandleType.Lock)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.HandleType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A777 RID: 108407 RVA: 0x003D78E8 File Offset: 0x003D5AE8
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

		// Token: 0x0601A778 RID: 108408 RVA: 0x003D7926 File Offset: 0x003D5B26
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

		// Token: 0x0601A779 RID: 108409 RVA: 0x003D7957 File Offset: 0x003D5B57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A77A RID: 108410 RVA: 0x003D7960 File Offset: 0x003D5B60
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.HandleType = (TimeHandleType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009A0C RID: 39436
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A0D RID: 39437
		public const int HandleTypeFieldNumber = 4;

		// Token: 0x04009A0E RID: 39438
		private TimeHandleType handleType_;
	}
}
