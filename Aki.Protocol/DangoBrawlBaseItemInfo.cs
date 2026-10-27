using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000339 RID: 825
	public sealed class DangoBrawlBaseItemInfo : IMessage<DangoBrawlBaseItemInfo>, IMessage, IEquatable<DangoBrawlBaseItemInfo>, IDeepCloneable<DangoBrawlBaseItemInfo>, IBufferMessage
	{
		// Token: 0x060052CD RID: 21197 RVA: 0x000CA20E File Offset: 0x000C840E
		[NullableContext(1)]
		public static DangoBrawlBaseItemInfo Create()
		{
			return new DangoBrawlBaseItemInfo();
		}

		// Token: 0x17000F04 RID: 3844
		// (get) Token: 0x060052CE RID: 21198 RVA: 0x000CA215 File Offset: 0x000C8415
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F05 RID: 3845
		// (get) Token: 0x060052CF RID: 21199 RVA: 0x000CA218 File Offset: 0x000C8418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlBaseItemInfo.Descriptor;
			}
		}

		// Token: 0x060052D0 RID: 21200 RVA: 0x000CA21F File Offset: 0x000C841F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBaseItemInfo()
		{
		}

		// Token: 0x060052D1 RID: 21201 RVA: 0x000CA227 File Offset: 0x000C8427
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBaseItemInfo(DangoBrawlBaseItemInfo other) : this()
		{
			this.uid_ = other.uid_;
			this.configId_ = other.configId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060052D2 RID: 21202 RVA: 0x000CA258 File Offset: 0x000C8458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBaseItemInfo Clone()
		{
			return new DangoBrawlBaseItemInfo(this);
		}

		// Token: 0x17000F06 RID: 3846
		// (get) Token: 0x060052D3 RID: 21203 RVA: 0x000CA260 File Offset: 0x000C8460
		// (set) Token: 0x060052D4 RID: 21204 RVA: 0x000CA268 File Offset: 0x000C8468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Uid
		{
			get
			{
				return this.uid_;
			}
			set
			{
				this.uid_ = value;
			}
		}

		// Token: 0x17000F07 RID: 3847
		// (get) Token: 0x060052D5 RID: 21205 RVA: 0x000CA271 File Offset: 0x000C8471
		// (set) Token: 0x060052D6 RID: 21206 RVA: 0x000CA279 File Offset: 0x000C8479
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x060052D7 RID: 21207 RVA: 0x000CA282 File Offset: 0x000C8482
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlBaseItemInfo);
		}

		// Token: 0x060052D8 RID: 21208 RVA: 0x000CA290 File Offset: 0x000C8490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlBaseItemInfo other)
		{
			return other != null && (other == this || (this.Uid == other.Uid && this.ConfigId == other.ConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060052D9 RID: 21209 RVA: 0x000CA2D0 File Offset: 0x000C84D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Uid != 0)
			{
				num ^= this.Uid.GetHashCode();
			}
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060052DA RID: 21210 RVA: 0x000CA328 File Offset: 0x000C8528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060052DB RID: 21211 RVA: 0x000CA335 File Offset: 0x000C8535
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060052DC RID: 21212 RVA: 0x000CA340 File Offset: 0x000C8540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Uid != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Uid);
			}
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060052DD RID: 21213 RVA: 0x000CA398 File Offset: 0x000C8598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Uid != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Uid);
			}
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060052DE RID: 21214 RVA: 0x000CA3F0 File Offset: 0x000C85F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlBaseItemInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Uid != 0)
			{
				this.Uid = other.Uid;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060052DF RID: 21215 RVA: 0x000CA440 File Offset: 0x000C8640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060052E0 RID: 21216 RVA: 0x000CA44C File Offset: 0x000C864C
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ConfigId = input.ReadInt32();
					}
				}
				else
				{
					this.Uid = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400334E RID: 13134
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400334F RID: 13135
		public const int UidFieldNumber = 1;

		// Token: 0x04003350 RID: 13136
		private int uid_;

		// Token: 0x04003351 RID: 13137
		public const int ConfigIdFieldNumber = 2;

		// Token: 0x04003352 RID: 13138
		private int configId_;
	}
}
