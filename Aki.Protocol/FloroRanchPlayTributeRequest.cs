using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005D3 RID: 1491
	[NetMessage(EMessageId.FloroRanchPlayTributeRequest)]
	public sealed class FloroRanchPlayTributeRequest : IMessage<FloroRanchPlayTributeRequest>, IMessage, IEquatable<FloroRanchPlayTributeRequest>, IDeepCloneable<FloroRanchPlayTributeRequest>, IBufferMessage
	{
		// Token: 0x060089E6 RID: 35302 RVA: 0x0014D165 File Offset: 0x0014B365
		[NullableContext(1)]
		public static FloroRanchPlayTributeRequest Create()
		{
			return new FloroRanchPlayTributeRequest();
		}

		// Token: 0x17001B23 RID: 6947
		// (get) Token: 0x060089E7 RID: 35303 RVA: 0x0014D16C File Offset: 0x0014B36C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B24 RID: 6948
		// (get) Token: 0x060089E8 RID: 35304 RVA: 0x0014D16F File Offset: 0x0014B36F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayTributeRequest.Descriptor;
			}
		}

		// Token: 0x060089E9 RID: 35305 RVA: 0x0014D176 File Offset: 0x0014B376
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayTributeRequest()
		{
		}

		// Token: 0x060089EA RID: 35306 RVA: 0x0014D17E File Offset: 0x0014B37E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayTributeRequest(FloroRanchPlayTributeRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.subInsId_ = other.subInsId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060089EB RID: 35307 RVA: 0x0014D1AF File Offset: 0x0014B3AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayTributeRequest Clone()
		{
			return new FloroRanchPlayTributeRequest(this);
		}

		// Token: 0x17001B25 RID: 6949
		// (get) Token: 0x060089EC RID: 35308 RVA: 0x0014D1B7 File Offset: 0x0014B3B7
		// (set) Token: 0x060089ED RID: 35309 RVA: 0x0014D1BF File Offset: 0x0014B3BF
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

		// Token: 0x17001B26 RID: 6950
		// (get) Token: 0x060089EE RID: 35310 RVA: 0x0014D1C8 File Offset: 0x0014B3C8
		// (set) Token: 0x060089EF RID: 35311 RVA: 0x0014D1D0 File Offset: 0x0014B3D0
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

		// Token: 0x060089F0 RID: 35312 RVA: 0x0014D1D9 File Offset: 0x0014B3D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayTributeRequest);
		}

		// Token: 0x060089F1 RID: 35313 RVA: 0x0014D1E7 File Offset: 0x0014B3E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayTributeRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.SubInsId == other.SubInsId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060089F2 RID: 35314 RVA: 0x0014D228 File Offset: 0x0014B428
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

		// Token: 0x060089F3 RID: 35315 RVA: 0x0014D280 File Offset: 0x0014B480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060089F4 RID: 35316 RVA: 0x0014D28D File Offset: 0x0014B48D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060089F5 RID: 35317 RVA: 0x0014D298 File Offset: 0x0014B498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubInsId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.SubInsId);
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

		// Token: 0x060089F6 RID: 35318 RVA: 0x0014D2F4 File Offset: 0x0014B4F4
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

		// Token: 0x060089F7 RID: 35319 RVA: 0x0014D34C File Offset: 0x0014B54C
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

		// Token: 0x060089F8 RID: 35320 RVA: 0x0014D39C File Offset: 0x0014B59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060089F9 RID: 35321 RVA: 0x0014D3A8 File Offset: 0x0014B5A8
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
					this.SubInsId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040043C0 RID: 17344
		private UnknownFieldSet _unknownFields;

		// Token: 0x040043C1 RID: 17345
		public const int ActivityIdFieldNumber = 11;

		// Token: 0x040043C2 RID: 17346
		private int activityId_;

		// Token: 0x040043C3 RID: 17347
		public const int SubInsIdFieldNumber = 4;

		// Token: 0x040043C4 RID: 17348
		private int subInsId_;
	}
}
