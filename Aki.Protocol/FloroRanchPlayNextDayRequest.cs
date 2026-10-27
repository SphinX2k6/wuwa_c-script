using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005C2 RID: 1474
	[NetMessage(EMessageId.FloroRanchPlayNextDayRequest)]
	public sealed class FloroRanchPlayNextDayRequest : IMessage<FloroRanchPlayNextDayRequest>, IMessage, IEquatable<FloroRanchPlayNextDayRequest>, IDeepCloneable<FloroRanchPlayNextDayRequest>, IBufferMessage
	{
		// Token: 0x06008842 RID: 34882 RVA: 0x00148523 File Offset: 0x00146723
		[NullableContext(1)]
		public static FloroRanchPlayNextDayRequest Create()
		{
			return new FloroRanchPlayNextDayRequest();
		}

		// Token: 0x17001AB7 RID: 6839
		// (get) Token: 0x06008843 RID: 34883 RVA: 0x0014852A File Offset: 0x0014672A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001AB8 RID: 6840
		// (get) Token: 0x06008844 RID: 34884 RVA: 0x0014852D File Offset: 0x0014672D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayNextDayRequest.Descriptor;
			}
		}

		// Token: 0x06008845 RID: 34885 RVA: 0x00148534 File Offset: 0x00146734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayNextDayRequest()
		{
		}

		// Token: 0x06008846 RID: 34886 RVA: 0x0014853C File Offset: 0x0014673C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayNextDayRequest(FloroRanchPlayNextDayRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.subInsId_ = other.subInsId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008847 RID: 34887 RVA: 0x0014856D File Offset: 0x0014676D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayNextDayRequest Clone()
		{
			return new FloroRanchPlayNextDayRequest(this);
		}

		// Token: 0x17001AB9 RID: 6841
		// (get) Token: 0x06008848 RID: 34888 RVA: 0x00148575 File Offset: 0x00146775
		// (set) Token: 0x06008849 RID: 34889 RVA: 0x0014857D File Offset: 0x0014677D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17001ABA RID: 6842
		// (get) Token: 0x0600884A RID: 34890 RVA: 0x00148586 File Offset: 0x00146786
		// (set) Token: 0x0600884B RID: 34891 RVA: 0x0014858E File Offset: 0x0014678E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubInsId
		{
			get
			{
				return this.subInsId_;
			}
			set
			{
				this.subInsId_ = value;
			}
		}

		// Token: 0x0600884C RID: 34892 RVA: 0x00148597 File Offset: 0x00146797
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayNextDayRequest);
		}

		// Token: 0x0600884D RID: 34893 RVA: 0x001485A5 File Offset: 0x001467A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayNextDayRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.SubInsId == other.SubInsId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600884E RID: 34894 RVA: 0x001485E4 File Offset: 0x001467E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.SubInsId != 0)
			{
				num ^= this.SubInsId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600884F RID: 34895 RVA: 0x0014863C File Offset: 0x0014683C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008850 RID: 34896 RVA: 0x00148649 File Offset: 0x00146849
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008851 RID: 34897 RVA: 0x00148654 File Offset: 0x00146854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActivityId);
			}
			if (this.SubInsId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.SubInsId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008852 RID: 34898 RVA: 0x001486B0 File Offset: 0x001468B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.SubInsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubInsId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008853 RID: 34899 RVA: 0x00148708 File Offset: 0x00146908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayNextDayRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.SubInsId != 0)
			{
				this.SubInsId = other.SubInsId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008854 RID: 34900 RVA: 0x00148758 File Offset: 0x00146958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008855 RID: 34901 RVA: 0x00148764 File Offset: 0x00146964
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
				if (num != 24U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SubInsId = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004322 RID: 17186
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004323 RID: 17187
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x04004324 RID: 17188
		private int activityId_;

		// Token: 0x04004325 RID: 17189
		public const int SubInsIdFieldNumber = 14;

		// Token: 0x04004326 RID: 17190
		private int subInsId_;
	}
}
