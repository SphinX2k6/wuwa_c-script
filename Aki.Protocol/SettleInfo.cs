using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011E1 RID: 4577
	public sealed class SettleInfo : IMessage<SettleInfo>, IMessage, IEquatable<SettleInfo>, IDeepCloneable<SettleInfo>, IBufferMessage
	{
		// Token: 0x0601865C RID: 99932 RVA: 0x0038C1B1 File Offset: 0x0038A3B1
		[NullableContext(1)]
		public static SettleInfo Create()
		{
			return new SettleInfo();
		}

		// Token: 0x1700521F RID: 21023
		// (get) Token: 0x0601865D RID: 99933 RVA: 0x0038C1B8 File Offset: 0x0038A3B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005220 RID: 21024
		// (get) Token: 0x0601865E RID: 99934 RVA: 0x0038C1BB File Offset: 0x0038A3BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SettleInfo.Descriptor;
			}
		}

		// Token: 0x0601865F RID: 99935 RVA: 0x0038C1C2 File Offset: 0x0038A3C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SettleInfo()
		{
		}

		// Token: 0x06018660 RID: 99936 RVA: 0x0038C1CA File Offset: 0x0038A3CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SettleInfo(SettleInfo other) : this()
		{
			this.id_ = other.id_;
			this.num_ = other.num_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018661 RID: 99937 RVA: 0x0038C1FB File Offset: 0x0038A3FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SettleInfo Clone()
		{
			return new SettleInfo(this);
		}

		// Token: 0x17005221 RID: 21025
		// (get) Token: 0x06018662 RID: 99938 RVA: 0x0038C203 File Offset: 0x0038A403
		// (set) Token: 0x06018663 RID: 99939 RVA: 0x0038C20B File Offset: 0x0038A40B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17005222 RID: 21026
		// (get) Token: 0x06018664 RID: 99940 RVA: 0x0038C214 File Offset: 0x0038A414
		// (set) Token: 0x06018665 RID: 99941 RVA: 0x0038C21C File Offset: 0x0038A41C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Num
		{
			get
			{
				return this.num_;
			}
			set
			{
				this.num_ = value;
			}
		}

		// Token: 0x06018666 RID: 99942 RVA: 0x0038C225 File Offset: 0x0038A425
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SettleInfo);
		}

		// Token: 0x06018667 RID: 99943 RVA: 0x0038C233 File Offset: 0x0038A433
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SettleInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Num == other.Num && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018668 RID: 99944 RVA: 0x0038C274 File Offset: 0x0038A474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Num != 0)
			{
				num ^= this.Num.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018669 RID: 99945 RVA: 0x0038C2CC File Offset: 0x0038A4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601866A RID: 99946 RVA: 0x0038C2D9 File Offset: 0x0038A4D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601866B RID: 99947 RVA: 0x0038C2E4 File Offset: 0x0038A4E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Num != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Num);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601866C RID: 99948 RVA: 0x0038C33C File Offset: 0x0038A53C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Num != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Num);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601866D RID: 99949 RVA: 0x0038C394 File Offset: 0x0038A594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SettleInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Num != 0)
			{
				this.Num = other.Num;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601866E RID: 99950 RVA: 0x0038C3E4 File Offset: 0x0038A5E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601866F RID: 99951 RVA: 0x0038C3F0 File Offset: 0x0038A5F0
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
						this.Num = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400903E RID: 36926
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400903F RID: 36927
		public const int IdFieldNumber = 1;

		// Token: 0x04009040 RID: 36928
		private int id_;

		// Token: 0x04009041 RID: 36929
		public const int NumFieldNumber = 2;

		// Token: 0x04009042 RID: 36930
		private int num_;
	}
}
