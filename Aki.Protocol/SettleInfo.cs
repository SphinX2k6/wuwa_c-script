using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200121B RID: 4635
	public sealed class SettleInfo : IMessage<SettleInfo>, IMessage, IEquatable<SettleInfo>, IDeepCloneable<SettleInfo>, IBufferMessage
	{
		// Token: 0x06018BFD RID: 101373 RVA: 0x0039B4E1 File Offset: 0x003996E1
		[NullableContext(1)]
		public static SettleInfo Create()
		{
			return new SettleInfo();
		}

		// Token: 0x1700538B RID: 21387
		// (get) Token: 0x06018BFE RID: 101374 RVA: 0x0039B4E8 File Offset: 0x003996E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700538C RID: 21388
		// (get) Token: 0x06018BFF RID: 101375 RVA: 0x0039B4EB File Offset: 0x003996EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SettleInfo.Descriptor;
			}
		}

		// Token: 0x06018C00 RID: 101376 RVA: 0x0039B4F2 File Offset: 0x003996F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SettleInfo()
		{
		}

		// Token: 0x06018C01 RID: 101377 RVA: 0x0039B4FA File Offset: 0x003996FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SettleInfo(SettleInfo other) : this()
		{
			this.id_ = other.id_;
			this.num_ = other.num_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018C02 RID: 101378 RVA: 0x0039B52B File Offset: 0x0039972B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SettleInfo Clone()
		{
			return new SettleInfo(this);
		}

		// Token: 0x1700538D RID: 21389
		// (get) Token: 0x06018C03 RID: 101379 RVA: 0x0039B533 File Offset: 0x00399733
		// (set) Token: 0x06018C04 RID: 101380 RVA: 0x0039B53B File Offset: 0x0039973B
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

		// Token: 0x1700538E RID: 21390
		// (get) Token: 0x06018C05 RID: 101381 RVA: 0x0039B544 File Offset: 0x00399744
		// (set) Token: 0x06018C06 RID: 101382 RVA: 0x0039B54C File Offset: 0x0039974C
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

		// Token: 0x06018C07 RID: 101383 RVA: 0x0039B555 File Offset: 0x00399755
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SettleInfo);
		}

		// Token: 0x06018C08 RID: 101384 RVA: 0x0039B563 File Offset: 0x00399763
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SettleInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Num == other.Num && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018C09 RID: 101385 RVA: 0x0039B5A4 File Offset: 0x003997A4
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

		// Token: 0x06018C0A RID: 101386 RVA: 0x0039B5FC File Offset: 0x003997FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018C0B RID: 101387 RVA: 0x0039B609 File Offset: 0x00399809
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018C0C RID: 101388 RVA: 0x0039B614 File Offset: 0x00399814
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

		// Token: 0x06018C0D RID: 101389 RVA: 0x0039B66C File Offset: 0x0039986C
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

		// Token: 0x06018C0E RID: 101390 RVA: 0x0039B6C4 File Offset: 0x003998C4
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

		// Token: 0x06018C0F RID: 101391 RVA: 0x0039B714 File Offset: 0x00399914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018C10 RID: 101392 RVA: 0x0039B720 File Offset: 0x00399920
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

		// Token: 0x040092D1 RID: 37585
		private UnknownFieldSet _unknownFields;

		// Token: 0x040092D2 RID: 37586
		public const int IdFieldNumber = 1;

		// Token: 0x040092D3 RID: 37587
		private int id_;

		// Token: 0x040092D4 RID: 37588
		public const int NumFieldNumber = 2;

		// Token: 0x040092D5 RID: 37589
		private int num_;
	}
}
