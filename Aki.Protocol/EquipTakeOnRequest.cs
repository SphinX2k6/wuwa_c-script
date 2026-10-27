using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004DA RID: 1242
	[NetMessage(EMessageId.EquipTakeOnRequest)]
	public sealed class EquipTakeOnRequest : IMessage<EquipTakeOnRequest>, IMessage, IEquatable<EquipTakeOnRequest>, IDeepCloneable<EquipTakeOnRequest>, IBufferMessage
	{
		// Token: 0x060075D0 RID: 30160 RVA: 0x00120349 File Offset: 0x0011E549
		[NullableContext(1)]
		public static EquipTakeOnRequest Create()
		{
			return new EquipTakeOnRequest();
		}

		// Token: 0x170016D7 RID: 5847
		// (get) Token: 0x060075D1 RID: 30161 RVA: 0x00120350 File Offset: 0x0011E550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016D8 RID: 5848
		// (get) Token: 0x060075D2 RID: 30162 RVA: 0x00120353 File Offset: 0x0011E553
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EquipTakeOnRequest.Descriptor;
			}
		}

		// Token: 0x060075D3 RID: 30163 RVA: 0x0012035A File Offset: 0x0011E55A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipTakeOnRequest()
		{
		}

		// Token: 0x060075D4 RID: 30164 RVA: 0x00120362 File Offset: 0x0011E562
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipTakeOnRequest(EquipTakeOnRequest other) : this()
		{
			this.data_ = ((other.data_ != null) ? other.data_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060075D5 RID: 30165 RVA: 0x00120397 File Offset: 0x0011E597
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipTakeOnRequest Clone()
		{
			return new EquipTakeOnRequest(this);
		}

		// Token: 0x170016D9 RID: 5849
		// (get) Token: 0x060075D6 RID: 30166 RVA: 0x0012039F File Offset: 0x0011E59F
		// (set) Token: 0x060075D7 RID: 30167 RVA: 0x001203A7 File Offset: 0x0011E5A7
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

		// Token: 0x060075D8 RID: 30168 RVA: 0x001203B0 File Offset: 0x0011E5B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EquipTakeOnRequest);
		}

		// Token: 0x060075D9 RID: 30169 RVA: 0x001203BE File Offset: 0x0011E5BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EquipTakeOnRequest other)
		{
			return other != null && (other == this || (object.Equals(this.Data, other.Data) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060075DA RID: 30170 RVA: 0x001203F4 File Offset: 0x0011E5F4
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

		// Token: 0x060075DB RID: 30171 RVA: 0x00120430 File Offset: 0x0011E630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060075DC RID: 30172 RVA: 0x0012043D File Offset: 0x0011E63D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060075DD RID: 30173 RVA: 0x00120446 File Offset: 0x0011E646
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.data_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Data);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060075DE RID: 30174 RVA: 0x00120478 File Offset: 0x0011E678
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

		// Token: 0x060075DF RID: 30175 RVA: 0x001204B8 File Offset: 0x0011E6B8
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

		// Token: 0x060075E0 RID: 30176 RVA: 0x0012050C File Offset: 0x0011E70C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060075E1 RID: 30177 RVA: 0x00120518 File Offset: 0x0011E718
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
				if (num != 42U)
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

		// Token: 0x04003DC6 RID: 15814
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DC7 RID: 15815
		public const int DataFieldNumber = 5;

		// Token: 0x04003DC8 RID: 15816
		private RoleLoadEquipData data_;
	}
}
