using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005BE RID: 1470
	[NetMessage(EMessageId.FloroRanchPlayTributeRequest)]
	public sealed class FloroRanchPlayTributeRequest : IMessage<FloroRanchPlayTributeRequest>, IMessage, IEquatable<FloroRanchPlayTributeRequest>, IDeepCloneable<FloroRanchPlayTributeRequest>, IBufferMessage
	{
		// Token: 0x0600887E RID: 34942 RVA: 0x0014A549 File Offset: 0x00148749
		[NullableContext(1)]
		public static FloroRanchPlayTributeRequest Create()
		{
			return new FloroRanchPlayTributeRequest();
		}

		// Token: 0x17001AD6 RID: 6870
		// (get) Token: 0x0600887F RID: 34943 RVA: 0x0014A550 File Offset: 0x00148750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001AD7 RID: 6871
		// (get) Token: 0x06008880 RID: 34944 RVA: 0x0014A553 File Offset: 0x00148753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayTributeRequest.Descriptor;
			}
		}

		// Token: 0x06008881 RID: 34945 RVA: 0x0014A55A File Offset: 0x0014875A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayTributeRequest()
		{
		}

		// Token: 0x06008882 RID: 34946 RVA: 0x0014A562 File Offset: 0x00148762
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayTributeRequest(FloroRanchPlayTributeRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.subInsId_ = other.subInsId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008883 RID: 34947 RVA: 0x0014A593 File Offset: 0x00148793
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayTributeRequest Clone()
		{
			return new FloroRanchPlayTributeRequest(this);
		}

		// Token: 0x17001AD8 RID: 6872
		// (get) Token: 0x06008884 RID: 34948 RVA: 0x0014A59B File Offset: 0x0014879B
		// (set) Token: 0x06008885 RID: 34949 RVA: 0x0014A5A3 File Offset: 0x001487A3
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

		// Token: 0x17001AD9 RID: 6873
		// (get) Token: 0x06008886 RID: 34950 RVA: 0x0014A5AC File Offset: 0x001487AC
		// (set) Token: 0x06008887 RID: 34951 RVA: 0x0014A5B4 File Offset: 0x001487B4
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

		// Token: 0x06008888 RID: 34952 RVA: 0x0014A5BD File Offset: 0x001487BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayTributeRequest);
		}

		// Token: 0x06008889 RID: 34953 RVA: 0x0014A5CB File Offset: 0x001487CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayTributeRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.SubInsId == other.SubInsId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600888A RID: 34954 RVA: 0x0014A60C File Offset: 0x0014880C
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

		// Token: 0x0600888B RID: 34955 RVA: 0x0014A664 File Offset: 0x00148864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600888C RID: 34956 RVA: 0x0014A671 File Offset: 0x00148871
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600888D RID: 34957 RVA: 0x0014A67C File Offset: 0x0014887C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ActivityId);
			}
			if (this.SubInsId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.SubInsId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600888E RID: 34958 RVA: 0x0014A6D8 File Offset: 0x001488D8
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

		// Token: 0x0600888F RID: 34959 RVA: 0x0014A730 File Offset: 0x00148930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayTributeRequest other)
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

		// Token: 0x06008890 RID: 34960 RVA: 0x0014A780 File Offset: 0x00148980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008891 RID: 34961 RVA: 0x0014A78C File Offset: 0x0014898C
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
				if (num != 56U)
				{
					if (num != 88U)
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

		// Token: 0x040043B6 RID: 17334
		private UnknownFieldSet _unknownFields;

		// Token: 0x040043B7 RID: 17335
		public const int ActivityIdFieldNumber = 7;

		// Token: 0x040043B8 RID: 17336
		private int activityId_;

		// Token: 0x040043B9 RID: 17337
		public const int SubInsIdFieldNumber = 11;

		// Token: 0x040043BA RID: 17338
		private int subInsId_;
	}
}
