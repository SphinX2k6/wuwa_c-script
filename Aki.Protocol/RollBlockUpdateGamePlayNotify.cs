using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001126 RID: 4390
	[NetMessage(EMessageId.RollBlockUpdateGamePlayNotify)]
	public sealed class RollBlockUpdateGamePlayNotify : IMessage<RollBlockUpdateGamePlayNotify>, IMessage, IEquatable<RollBlockUpdateGamePlayNotify>, IDeepCloneable<RollBlockUpdateGamePlayNotify>, IBufferMessage
	{
		// Token: 0x0601773E RID: 96062 RVA: 0x00369324 File Offset: 0x00367524
		[NullableContext(1)]
		public static RollBlockUpdateGamePlayNotify Create()
		{
			return new RollBlockUpdateGamePlayNotify();
		}

		// Token: 0x17004EC9 RID: 20169
		// (get) Token: 0x0601773F RID: 96063 RVA: 0x0036932B File Offset: 0x0036752B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004ECA RID: 20170
		// (get) Token: 0x06017740 RID: 96064 RVA: 0x0036932E File Offset: 0x0036752E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockUpdateGamePlayNotify.Descriptor;
			}
		}

		// Token: 0x06017741 RID: 96065 RVA: 0x00369335 File Offset: 0x00367535
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockUpdateGamePlayNotify()
		{
		}

		// Token: 0x06017742 RID: 96066 RVA: 0x0036933D File Offset: 0x0036753D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockUpdateGamePlayNotify(RollBlockUpdateGamePlayNotify other) : this()
		{
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017743 RID: 96067 RVA: 0x00369372 File Offset: 0x00367572
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockUpdateGamePlayNotify Clone()
		{
			return new RollBlockUpdateGamePlayNotify(this);
		}

		// Token: 0x17004ECB RID: 20171
		// (get) Token: 0x06017744 RID: 96068 RVA: 0x0036937A File Offset: 0x0036757A
		// (set) Token: 0x06017745 RID: 96069 RVA: 0x00369382 File Offset: 0x00367582
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

		// Token: 0x06017746 RID: 96070 RVA: 0x0036938B File Offset: 0x0036758B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockUpdateGamePlayNotify);
		}

		// Token: 0x06017747 RID: 96071 RVA: 0x00369399 File Offset: 0x00367599
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockUpdateGamePlayNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Info, other.Info) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017748 RID: 96072 RVA: 0x003693CC File Offset: 0x003675CC
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

		// Token: 0x06017749 RID: 96073 RVA: 0x00369408 File Offset: 0x00367608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601774A RID: 96074 RVA: 0x00369415 File Offset: 0x00367615
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601774B RID: 96075 RVA: 0x0036941E File Offset: 0x0036761E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.info_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Info);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601774C RID: 96076 RVA: 0x00369450 File Offset: 0x00367650
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

		// Token: 0x0601774D RID: 96077 RVA: 0x00369490 File Offset: 0x00367690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBlockUpdateGamePlayNotify other)
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

		// Token: 0x0601774E RID: 96078 RVA: 0x003694E4 File Offset: 0x003676E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601774F RID: 96079 RVA: 0x003694F0 File Offset: 0x003676F0
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
				if (num != 66U)
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

		// Token: 0x04008BEF RID: 35823
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008BF0 RID: 35824
		public const int InfoFieldNumber = 8;

		// Token: 0x04008BF1 RID: 35825
		private RollBlockGamePlayPbInfo info_;
	}
}
