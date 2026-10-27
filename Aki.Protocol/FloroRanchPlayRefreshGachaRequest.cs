using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005C4 RID: 1476
	[NetMessage(EMessageId.FloroRanchPlayRefreshGachaRequest)]
	public sealed class FloroRanchPlayRefreshGachaRequest : IMessage<FloroRanchPlayRefreshGachaRequest>, IMessage, IEquatable<FloroRanchPlayRefreshGachaRequest>, IDeepCloneable<FloroRanchPlayRefreshGachaRequest>, IBufferMessage
	{
		// Token: 0x0600886A RID: 34922 RVA: 0x00148A70 File Offset: 0x00146C70
		[NullableContext(1)]
		public static FloroRanchPlayRefreshGachaRequest Create()
		{
			return new FloroRanchPlayRefreshGachaRequest();
		}

		// Token: 0x17001ABF RID: 6847
		// (get) Token: 0x0600886B RID: 34923 RVA: 0x00148A77 File Offset: 0x00146C77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001AC0 RID: 6848
		// (get) Token: 0x0600886C RID: 34924 RVA: 0x00148A7A File Offset: 0x00146C7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayRefreshGachaRequest.Descriptor;
			}
		}

		// Token: 0x0600886D RID: 34925 RVA: 0x00148A81 File Offset: 0x00146C81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayRefreshGachaRequest()
		{
		}

		// Token: 0x0600886E RID: 34926 RVA: 0x00148A89 File Offset: 0x00146C89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayRefreshGachaRequest(FloroRanchPlayRefreshGachaRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.subInsId_ = other.subInsId_;
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600886F RID: 34927 RVA: 0x00148AC6 File Offset: 0x00146CC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayRefreshGachaRequest Clone()
		{
			return new FloroRanchPlayRefreshGachaRequest(this);
		}

		// Token: 0x17001AC1 RID: 6849
		// (get) Token: 0x06008870 RID: 34928 RVA: 0x00148ACE File Offset: 0x00146CCE
		// (set) Token: 0x06008871 RID: 34929 RVA: 0x00148AD6 File Offset: 0x00146CD6
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

		// Token: 0x17001AC2 RID: 6850
		// (get) Token: 0x06008872 RID: 34930 RVA: 0x00148ADF File Offset: 0x00146CDF
		// (set) Token: 0x06008873 RID: 34931 RVA: 0x00148AE7 File Offset: 0x00146CE7
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

		// Token: 0x17001AC3 RID: 6851
		// (get) Token: 0x06008874 RID: 34932 RVA: 0x00148AF0 File Offset: 0x00146CF0
		// (set) Token: 0x06008875 RID: 34933 RVA: 0x00148AF8 File Offset: 0x00146CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x06008876 RID: 34934 RVA: 0x00148B01 File Offset: 0x00146D01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayRefreshGachaRequest);
		}

		// Token: 0x06008877 RID: 34935 RVA: 0x00148B10 File Offset: 0x00146D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayRefreshGachaRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.SubInsId == other.SubInsId && this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008878 RID: 34936 RVA: 0x00148B6C File Offset: 0x00146D6C
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
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008879 RID: 34937 RVA: 0x00148BDD File Offset: 0x00146DDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600887A RID: 34938 RVA: 0x00148BEA File Offset: 0x00146DEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600887B RID: 34939 RVA: 0x00148BF4 File Offset: 0x00146DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubInsId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SubInsId);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.IncId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600887C RID: 34940 RVA: 0x00148C68 File Offset: 0x00146E68
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
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600887D RID: 34941 RVA: 0x00148CD8 File Offset: 0x00146ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayRefreshGachaRequest other)
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
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600887E RID: 34942 RVA: 0x00148D3C File Offset: 0x00146F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600887F RID: 34943 RVA: 0x00148D48 File Offset: 0x00146F48
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
				if (num != 8U)
				{
					if (num != 40U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ActivityId = input.ReadInt32();
						}
					}
					else
					{
						this.IncId = input.ReadInt32();
					}
				}
				else
				{
					this.SubInsId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400432D RID: 17197
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400432E RID: 17198
		public const int ActivityIdFieldNumber = 11;

		// Token: 0x0400432F RID: 17199
		private int activityId_;

		// Token: 0x04004330 RID: 17200
		public const int SubInsIdFieldNumber = 1;

		// Token: 0x04004331 RID: 17201
		private int subInsId_;

		// Token: 0x04004332 RID: 17202
		public const int IncIdFieldNumber = 5;

		// Token: 0x04004333 RID: 17203
		private int incId_;
	}
}
