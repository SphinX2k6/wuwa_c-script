using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004BE RID: 1214
	[NetMessage(EMessageId.EquipSkinTakeOnRequest)]
	public sealed class EquipSkinTakeOnRequest : IMessage<EquipSkinTakeOnRequest>, IMessage, IEquatable<EquipSkinTakeOnRequest>, IDeepCloneable<EquipSkinTakeOnRequest>, IBufferMessage
	{
		// Token: 0x060073E4 RID: 29668 RVA: 0x0011C7BF File Offset: 0x0011A9BF
		[NullableContext(1)]
		public static EquipSkinTakeOnRequest Create()
		{
			return new EquipSkinTakeOnRequest();
		}

		// Token: 0x17001672 RID: 5746
		// (get) Token: 0x060073E5 RID: 29669 RVA: 0x0011C7C6 File Offset: 0x0011A9C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001673 RID: 5747
		// (get) Token: 0x060073E6 RID: 29670 RVA: 0x0011C7C9 File Offset: 0x0011A9C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EquipSkinTakeOnRequest.Descriptor;
			}
		}

		// Token: 0x060073E7 RID: 29671 RVA: 0x0011C7D0 File Offset: 0x0011A9D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipSkinTakeOnRequest()
		{
		}

		// Token: 0x060073E8 RID: 29672 RVA: 0x0011C7D8 File Offset: 0x0011A9D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipSkinTakeOnRequest(EquipSkinTakeOnRequest other) : this()
		{
			this.data_ = ((other.data_ != null) ? other.data_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060073E9 RID: 29673 RVA: 0x0011C80D File Offset: 0x0011AA0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipSkinTakeOnRequest Clone()
		{
			return new EquipSkinTakeOnRequest(this);
		}

		// Token: 0x17001674 RID: 5748
		// (get) Token: 0x060073EA RID: 29674 RVA: 0x0011C815 File Offset: 0x0011AA15
		// (set) Token: 0x060073EB RID: 29675 RVA: 0x0011C81D File Offset: 0x0011AA1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinEquipData Data
		{
			get
			{
				return this.data_;
			}
			set
			{
				this.data_ = value;
			}
		}

		// Token: 0x060073EC RID: 29676 RVA: 0x0011C826 File Offset: 0x0011AA26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EquipSkinTakeOnRequest);
		}

		// Token: 0x060073ED RID: 29677 RVA: 0x0011C834 File Offset: 0x0011AA34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EquipSkinTakeOnRequest other)
		{
			return other != null && (other == this || (object.Equals(this.Data, other.Data) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060073EE RID: 29678 RVA: 0x0011C868 File Offset: 0x0011AA68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.data_ != null)
			{
				num ^= this.Data.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060073EF RID: 29679 RVA: 0x0011C8A4 File Offset: 0x0011AAA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060073F0 RID: 29680 RVA: 0x0011C8B1 File Offset: 0x0011AAB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060073F1 RID: 29681 RVA: 0x0011C8BA File Offset: 0x0011AABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.data_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Data);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060073F2 RID: 29682 RVA: 0x0011C8EC File Offset: 0x0011AAEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.data_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Data);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060073F3 RID: 29683 RVA: 0x0011C92C File Offset: 0x0011AB2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EquipSkinTakeOnRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.data_ != null)
			{
				if (this.data_ == null)
				{
					this.Data = new RoleSkinEquipData();
				}
				this.Data.MergeFrom(other.Data);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060073F4 RID: 29684 RVA: 0x0011C980 File Offset: 0x0011AB80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060073F5 RID: 29685 RVA: 0x0011C98C File Offset: 0x0011AB8C
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.data_ == null)
					{
						this.Data = new RoleSkinEquipData();
					}
					input.ReadMessage(this.Data);
				}
			}
		}

		// Token: 0x04003D9F RID: 15775
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DA0 RID: 15776
		public const int DataFieldNumber = 10;

		// Token: 0x04003DA1 RID: 15777
		private RoleSkinEquipData data_;
	}
}
