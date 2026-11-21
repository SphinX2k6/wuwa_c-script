using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004C3 RID: 1219
	[NetMessage(EMessageId.EquipTakeOnRequest)]
	public sealed class EquipTakeOnRequest : IMessage<EquipTakeOnRequest>, IMessage, IEquatable<EquipTakeOnRequest>, IDeepCloneable<EquipTakeOnRequest>, IBufferMessage
	{
		// Token: 0x06007440 RID: 29760 RVA: 0x0011D231 File Offset: 0x0011B431
		[NullableContext(1)]
		public static EquipTakeOnRequest Create()
		{
			return new EquipTakeOnRequest();
		}

		// Token: 0x17001682 RID: 5762
		// (get) Token: 0x06007441 RID: 29761 RVA: 0x0011D238 File Offset: 0x0011B438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001683 RID: 5763
		// (get) Token: 0x06007442 RID: 29762 RVA: 0x0011D23B File Offset: 0x0011B43B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EquipTakeOnRequest.Descriptor;
			}
		}

		// Token: 0x06007443 RID: 29763 RVA: 0x0011D242 File Offset: 0x0011B442
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipTakeOnRequest()
		{
		}

		// Token: 0x06007444 RID: 29764 RVA: 0x0011D24A File Offset: 0x0011B44A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipTakeOnRequest(EquipTakeOnRequest other) : this()
		{
			this.data_ = ((other.data_ != null) ? other.data_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007445 RID: 29765 RVA: 0x0011D27F File Offset: 0x0011B47F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipTakeOnRequest Clone()
		{
			return new EquipTakeOnRequest(this);
		}

		// Token: 0x17001684 RID: 5764
		// (get) Token: 0x06007446 RID: 29766 RVA: 0x0011D287 File Offset: 0x0011B487
		// (set) Token: 0x06007447 RID: 29767 RVA: 0x0011D28F File Offset: 0x0011B48F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleLoadEquipData Data
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

		// Token: 0x06007448 RID: 29768 RVA: 0x0011D298 File Offset: 0x0011B498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EquipTakeOnRequest);
		}

		// Token: 0x06007449 RID: 29769 RVA: 0x0011D2A6 File Offset: 0x0011B4A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EquipTakeOnRequest other)
		{
			return other != null && (other == this || (object.Equals(this.Data, other.Data) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600744A RID: 29770 RVA: 0x0011D2DC File Offset: 0x0011B4DC
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

		// Token: 0x0600744B RID: 29771 RVA: 0x0011D318 File Offset: 0x0011B518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600744C RID: 29772 RVA: 0x0011D325 File Offset: 0x0011B525
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600744D RID: 29773 RVA: 0x0011D32E File Offset: 0x0011B52E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.data_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Data);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600744E RID: 29774 RVA: 0x0011D360 File Offset: 0x0011B560
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

		// Token: 0x0600744F RID: 29775 RVA: 0x0011D3A0 File Offset: 0x0011B5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EquipTakeOnRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.data_ != null)
			{
				if (this.data_ == null)
				{
					this.Data = new RoleLoadEquipData();
				}
				this.Data.MergeFrom(other.Data);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007450 RID: 29776 RVA: 0x0011D3F4 File Offset: 0x0011B5F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007451 RID: 29777 RVA: 0x0011D400 File Offset: 0x0011B600
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
					if (this.data_ == null)
					{
						this.Data = new RoleLoadEquipData();
					}
					input.ReadMessage(this.Data);
				}
			}
		}

		// Token: 0x04003DB2 RID: 15794
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DB3 RID: 15795
		public const int DataFieldNumber = 8;

		// Token: 0x04003DB4 RID: 15796
		private RoleLoadEquipData data_;
	}
}
