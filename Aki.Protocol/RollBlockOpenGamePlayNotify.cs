using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200111C RID: 4380
	[NetMessage(EMessageId.RollBlockOpenGamePlayNotify)]
	public sealed class RollBlockOpenGamePlayNotify : IMessage<RollBlockOpenGamePlayNotify>, IMessage, IEquatable<RollBlockOpenGamePlayNotify>, IDeepCloneable<RollBlockOpenGamePlayNotify>, IBufferMessage
	{
		// Token: 0x06017682 RID: 95874 RVA: 0x00367D01 File Offset: 0x00365F01
		[NullableContext(1)]
		public static RollBlockOpenGamePlayNotify Create()
		{
			return new RollBlockOpenGamePlayNotify();
		}

		// Token: 0x17004EA7 RID: 20135
		// (get) Token: 0x06017683 RID: 95875 RVA: 0x00367D08 File Offset: 0x00365F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004EA8 RID: 20136
		// (get) Token: 0x06017684 RID: 95876 RVA: 0x00367D0B File Offset: 0x00365F0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockOpenGamePlayNotify.Descriptor;
			}
		}

		// Token: 0x06017685 RID: 95877 RVA: 0x00367D12 File Offset: 0x00365F12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockOpenGamePlayNotify()
		{
		}

		// Token: 0x06017686 RID: 95878 RVA: 0x00367D1A File Offset: 0x00365F1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockOpenGamePlayNotify(RollBlockOpenGamePlayNotify other) : this()
		{
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017687 RID: 95879 RVA: 0x00367D4F File Offset: 0x00365F4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockOpenGamePlayNotify Clone()
		{
			return new RollBlockOpenGamePlayNotify(this);
		}

		// Token: 0x17004EA9 RID: 20137
		// (get) Token: 0x06017688 RID: 95880 RVA: 0x00367D57 File Offset: 0x00365F57
		// (set) Token: 0x06017689 RID: 95881 RVA: 0x00367D5F File Offset: 0x00365F5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockGamePlayPbInfo Info
		{
			get
			{
				return this.info_;
			}
			set
			{
				this.info_ = value;
			}
		}

		// Token: 0x0601768A RID: 95882 RVA: 0x00367D68 File Offset: 0x00365F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockOpenGamePlayNotify);
		}

		// Token: 0x0601768B RID: 95883 RVA: 0x00367D76 File Offset: 0x00365F76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockOpenGamePlayNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Info, other.Info) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601768C RID: 95884 RVA: 0x00367DAC File Offset: 0x00365FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.info_ != null)
			{
				num ^= this.Info.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601768D RID: 95885 RVA: 0x00367DE8 File Offset: 0x00365FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601768E RID: 95886 RVA: 0x00367DF5 File Offset: 0x00365FF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601768F RID: 95887 RVA: 0x00367DFE File Offset: 0x00365FFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.info_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Info);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017690 RID: 95888 RVA: 0x00367E30 File Offset: 0x00366030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.info_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017691 RID: 95889 RVA: 0x00367E70 File Offset: 0x00366070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBlockOpenGamePlayNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.info_ != null)
			{
				if (this.info_ == null)
				{
					this.Info = new RollBlockGamePlayPbInfo();
				}
				this.Info.MergeFrom(other.Info);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017692 RID: 95890 RVA: 0x00367EC4 File Offset: 0x003660C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017693 RID: 95891 RVA: 0x00367ED0 File Offset: 0x003660D0
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
					if (this.info_ == null)
					{
						this.Info = new RollBlockGamePlayPbInfo();
					}
					input.ReadMessage(this.Info);
				}
			}
		}

		// Token: 0x04008BC7 RID: 35783
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008BC8 RID: 35784
		public const int InfoFieldNumber = 1;

		// Token: 0x04008BC9 RID: 35785
		private RollBlockGamePlayPbInfo info_;
	}
}
