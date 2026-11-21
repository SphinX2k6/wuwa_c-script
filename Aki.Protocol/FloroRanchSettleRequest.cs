using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005CC RID: 1484
	[NetMessage(EMessageId.FloroRanchSettleRequest)]
	public sealed class FloroRanchSettleRequest : IMessage<FloroRanchSettleRequest>, IMessage, IEquatable<FloroRanchSettleRequest>, IDeepCloneable<FloroRanchSettleRequest>, IBufferMessage
	{
		// Token: 0x060089C1 RID: 35265 RVA: 0x0014D8E6 File Offset: 0x0014BAE6
		[NullableContext(1)]
		public static FloroRanchSettleRequest Create()
		{
			return new FloroRanchSettleRequest();
		}

		// Token: 0x17001B24 RID: 6948
		// (get) Token: 0x060089C2 RID: 35266 RVA: 0x0014D8ED File Offset: 0x0014BAED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B25 RID: 6949
		// (get) Token: 0x060089C3 RID: 35267 RVA: 0x0014D8F0 File Offset: 0x0014BAF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchSettleRequest.Descriptor;
			}
		}

		// Token: 0x060089C4 RID: 35268 RVA: 0x0014D8F7 File Offset: 0x0014BAF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchSettleRequest()
		{
		}

		// Token: 0x060089C5 RID: 35269 RVA: 0x0014D8FF File Offset: 0x0014BAFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchSettleRequest(FloroRanchSettleRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.subInsId_ = other.subInsId_;
			this.settle_ = other.settle_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060089C6 RID: 35270 RVA: 0x0014D93C File Offset: 0x0014BB3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchSettleRequest Clone()
		{
			return new FloroRanchSettleRequest(this);
		}

		// Token: 0x17001B26 RID: 6950
		// (get) Token: 0x060089C7 RID: 35271 RVA: 0x0014D944 File Offset: 0x0014BB44
		// (set) Token: 0x060089C8 RID: 35272 RVA: 0x0014D94C File Offset: 0x0014BB4C
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

		// Token: 0x17001B27 RID: 6951
		// (get) Token: 0x060089C9 RID: 35273 RVA: 0x0014D955 File Offset: 0x0014BB55
		// (set) Token: 0x060089CA RID: 35274 RVA: 0x0014D95D File Offset: 0x0014BB5D
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

		// Token: 0x17001B28 RID: 6952
		// (get) Token: 0x060089CB RID: 35275 RVA: 0x0014D966 File Offset: 0x0014BB66
		// (set) Token: 0x060089CC RID: 35276 RVA: 0x0014D96E File Offset: 0x0014BB6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Settle
		{
			get
			{
				return this.settle_;
			}
			set
			{
				this.settle_ = value;
			}
		}

		// Token: 0x060089CD RID: 35277 RVA: 0x0014D977 File Offset: 0x0014BB77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchSettleRequest);
		}

		// Token: 0x060089CE RID: 35278 RVA: 0x0014D988 File Offset: 0x0014BB88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchSettleRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.SubInsId == other.SubInsId && this.Settle == other.Settle && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060089CF RID: 35279 RVA: 0x0014D9E4 File Offset: 0x0014BBE4
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
			if (this.Settle)
			{
				num ^= this.Settle.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060089D0 RID: 35280 RVA: 0x0014DA55 File Offset: 0x0014BC55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060089D1 RID: 35281 RVA: 0x0014DA62 File Offset: 0x0014BC62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060089D2 RID: 35282 RVA: 0x0014DA6C File Offset: 0x0014BC6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubInsId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.SubInsId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ActivityId);
			}
			if (this.Settle)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.Settle);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060089D3 RID: 35283 RVA: 0x0014DAE4 File Offset: 0x0014BCE4
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
			if (this.Settle)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060089D4 RID: 35284 RVA: 0x0014DB48 File Offset: 0x0014BD48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchSettleRequest other)
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
			if (other.Settle)
			{
				this.Settle = other.Settle;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060089D5 RID: 35285 RVA: 0x0014DBAC File Offset: 0x0014BDAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060089D6 RID: 35286 RVA: 0x0014DBB8 File Offset: 0x0014BDB8
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
				if (num != 80U)
				{
					if (num != 104U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Settle = input.ReadBool();
						}
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

		// Token: 0x0400442B RID: 17451
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400442C RID: 17452
		public const int ActivityIdFieldNumber = 13;

		// Token: 0x0400442D RID: 17453
		private int activityId_;

		// Token: 0x0400442E RID: 17454
		public const int SubInsIdFieldNumber = 10;

		// Token: 0x0400442F RID: 17455
		private int subInsId_;

		// Token: 0x04004430 RID: 17456
		public const int SettleFieldNumber = 15;

		// Token: 0x04004431 RID: 17457
		private bool settle_;
	}
}
