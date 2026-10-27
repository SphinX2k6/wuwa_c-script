using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004D5 RID: 1237
	[NetMessage(EMessageId.EquipSkinTakeOnRequest)]
	public sealed class EquipSkinTakeOnRequest : IMessage<EquipSkinTakeOnRequest>, IMessage, IEquatable<EquipSkinTakeOnRequest>, IDeepCloneable<EquipSkinTakeOnRequest>, IBufferMessage
	{
		// Token: 0x06007574 RID: 30068 RVA: 0x0011F8D7 File Offset: 0x0011DAD7
		[NullableContext(1)]
		public static EquipSkinTakeOnRequest Create()
		{
			return new EquipSkinTakeOnRequest();
		}

		// Token: 0x170016C7 RID: 5831
		// (get) Token: 0x06007575 RID: 30069 RVA: 0x0011F8DE File Offset: 0x0011DADE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016C8 RID: 5832
		// (get) Token: 0x06007576 RID: 30070 RVA: 0x0011F8E1 File Offset: 0x0011DAE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EquipSkinTakeOnRequest.Descriptor;
			}
		}

		// Token: 0x06007577 RID: 30071 RVA: 0x0011F8E8 File Offset: 0x0011DAE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipSkinTakeOnRequest()
		{
		}

		// Token: 0x06007578 RID: 30072 RVA: 0x0011F8F0 File Offset: 0x0011DAF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipSkinTakeOnRequest(EquipSkinTakeOnRequest other) : this()
		{
			this.data_ = ((other.data_ != null) ? other.data_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007579 RID: 30073 RVA: 0x0011F925 File Offset: 0x0011DB25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipSkinTakeOnRequest Clone()
		{
			return new EquipSkinTakeOnRequest(this);
		}

		// Token: 0x170016C9 RID: 5833
		// (get) Token: 0x0600757A RID: 30074 RVA: 0x0011F92D File Offset: 0x0011DB2D
		// (set) Token: 0x0600757B RID: 30075 RVA: 0x0011F935 File Offset: 0x0011DB35
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

		// Token: 0x0600757C RID: 30076 RVA: 0x0011F93E File Offset: 0x0011DB3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EquipSkinTakeOnRequest);
		}

		// Token: 0x0600757D RID: 30077 RVA: 0x0011F94C File Offset: 0x0011DB4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EquipSkinTakeOnRequest other)
		{
			return other != null && (other == this || (object.Equals(this.Data, other.Data) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600757E RID: 30078 RVA: 0x0011F980 File Offset: 0x0011DB80
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

		// Token: 0x0600757F RID: 30079 RVA: 0x0011F9BC File Offset: 0x0011DBBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007580 RID: 30080 RVA: 0x0011F9C9 File Offset: 0x0011DBC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007581 RID: 30081 RVA: 0x0011F9D2 File Offset: 0x0011DBD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.data_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.Data);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007582 RID: 30082 RVA: 0x0011FA04 File Offset: 0x0011DC04
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

		// Token: 0x06007583 RID: 30083 RVA: 0x0011FA44 File Offset: 0x0011DC44
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

		// Token: 0x06007584 RID: 30084 RVA: 0x0011FA98 File Offset: 0x0011DC98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007585 RID: 30085 RVA: 0x0011FAA4 File Offset: 0x0011DCA4
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
				if (num != 90U)
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

		// Token: 0x04003DB3 RID: 15795
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DB4 RID: 15796
		public const int DataFieldNumber = 11;

		// Token: 0x04003DB5 RID: 15797
		private RoleSkinEquipData data_;
	}
}
