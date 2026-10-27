using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200138B RID: 5003
	[NetMessage(EMessageId.TotalTopUpActivityInfoNotify)]
	public sealed class TotalTopUpActivityInfoNotify : IMessage<TotalTopUpActivityInfoNotify>, IMessage, IEquatable<TotalTopUpActivityInfoNotify>, IDeepCloneable<TotalTopUpActivityInfoNotify>, IBufferMessage
	{
		// Token: 0x0601A8D5 RID: 108757 RVA: 0x003DA427 File Offset: 0x003D8627
		[NullableContext(1)]
		public static TotalTopUpActivityInfoNotify Create()
		{
			return new TotalTopUpActivityInfoNotify();
		}

		// Token: 0x17005987 RID: 22919
		// (get) Token: 0x0601A8D6 RID: 108758 RVA: 0x003DA42E File Offset: 0x003D862E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005988 RID: 22920
		// (get) Token: 0x0601A8D7 RID: 108759 RVA: 0x003DA431 File Offset: 0x003D8631
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TotalTopUpActivityInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601A8D8 RID: 108760 RVA: 0x003DA438 File Offset: 0x003D8638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpActivityInfoNotify()
		{
		}

		// Token: 0x0601A8D9 RID: 108761 RVA: 0x003DA440 File Offset: 0x003D8640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpActivityInfoNotify(TotalTopUpActivityInfoNotify other) : this()
		{
			this.totalTopUpActivityInfo_ = ((other.totalTopUpActivityInfo_ != null) ? other.totalTopUpActivityInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A8DA RID: 108762 RVA: 0x003DA475 File Offset: 0x003D8675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpActivityInfoNotify Clone()
		{
			return new TotalTopUpActivityInfoNotify(this);
		}

		// Token: 0x17005989 RID: 22921
		// (get) Token: 0x0601A8DB RID: 108763 RVA: 0x003DA47D File Offset: 0x003D867D
		// (set) Token: 0x0601A8DC RID: 108764 RVA: 0x003DA485 File Offset: 0x003D8685
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpActivityInfo TotalTopUpActivityInfo
		{
			get
			{
				return this.totalTopUpActivityInfo_;
			}
			set
			{
				this.totalTopUpActivityInfo_ = value;
			}
		}

		// Token: 0x0601A8DD RID: 108765 RVA: 0x003DA48E File Offset: 0x003D868E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TotalTopUpActivityInfoNotify);
		}

		// Token: 0x0601A8DE RID: 108766 RVA: 0x003DA49C File Offset: 0x003D869C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TotalTopUpActivityInfoNotify other)
		{
			return other != null && (other == this || (object.Equals(this.TotalTopUpActivityInfo, other.TotalTopUpActivityInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A8DF RID: 108767 RVA: 0x003DA4D0 File Offset: 0x003D86D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.totalTopUpActivityInfo_ != null)
			{
				num ^= this.TotalTopUpActivityInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A8E0 RID: 108768 RVA: 0x003DA50C File Offset: 0x003D870C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A8E1 RID: 108769 RVA: 0x003DA519 File Offset: 0x003D8719
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A8E2 RID: 108770 RVA: 0x003DA522 File Offset: 0x003D8722
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.totalTopUpActivityInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.TotalTopUpActivityInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A8E3 RID: 108771 RVA: 0x003DA554 File Offset: 0x003D8754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.totalTopUpActivityInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TotalTopUpActivityInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A8E4 RID: 108772 RVA: 0x003DA594 File Offset: 0x003D8794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TotalTopUpActivityInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.totalTopUpActivityInfo_ != null)
			{
				if (this.totalTopUpActivityInfo_ == null)
				{
					this.TotalTopUpActivityInfo = new TotalTopUpActivityInfo();
				}
				this.TotalTopUpActivityInfo.MergeFrom(other.TotalTopUpActivityInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A8E5 RID: 108773 RVA: 0x003DA5E8 File Offset: 0x003D87E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A8E6 RID: 108774 RVA: 0x003DA5F4 File Offset: 0x003D87F4
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.totalTopUpActivityInfo_ == null)
					{
						this.TotalTopUpActivityInfo = new TotalTopUpActivityInfo();
					}
					input.ReadMessage(this.TotalTopUpActivityInfo);
				}
			}
		}

		// Token: 0x04009A60 RID: 39520
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A61 RID: 39521
		public const int TotalTopUpActivityInfoFieldNumber = 14;

		// Token: 0x04009A62 RID: 39522
		private TotalTopUpActivityInfo totalTopUpActivityInfo_;
	}
}
