using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014C3 RID: 5315
	public sealed class TrapDefenseSpecialCellPbData : IMessage<TrapDefenseSpecialCellPbData>, IMessage, IEquatable<TrapDefenseSpecialCellPbData>, IDeepCloneable<TrapDefenseSpecialCellPbData>, IBufferMessage
	{
		// Token: 0x0601C327 RID: 115495 RVA: 0x00417A6E File Offset: 0x00415C6E
		[NullableContext(1)]
		public static TrapDefenseSpecialCellPbData Create()
		{
			return new TrapDefenseSpecialCellPbData();
		}

		// Token: 0x17005F6F RID: 24431
		// (get) Token: 0x0601C328 RID: 115496 RVA: 0x00417A75 File Offset: 0x00415C75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F70 RID: 24432
		// (get) Token: 0x0601C329 RID: 115497 RVA: 0x00417A78 File Offset: 0x00415C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseSpecialCellPbData.Descriptor;
			}
		}

		// Token: 0x0601C32A RID: 115498 RVA: 0x00417A7F File Offset: 0x00415C7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSpecialCellPbData()
		{
		}

		// Token: 0x0601C32B RID: 115499 RVA: 0x00417A87 File Offset: 0x00415C87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSpecialCellPbData(TrapDefenseSpecialCellPbData other) : this()
		{
			this.configId_ = other.configId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C32C RID: 115500 RVA: 0x00417AAC File Offset: 0x00415CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSpecialCellPbData Clone()
		{
			return new TrapDefenseSpecialCellPbData(this);
		}

		// Token: 0x17005F71 RID: 24433
		// (get) Token: 0x0601C32D RID: 115501 RVA: 0x00417AB4 File Offset: 0x00415CB4
		// (set) Token: 0x0601C32E RID: 115502 RVA: 0x00417ABC File Offset: 0x00415CBC
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

		// Token: 0x0601C32F RID: 115503 RVA: 0x00417AC5 File Offset: 0x00415CC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseSpecialCellPbData);
		}

		// Token: 0x0601C330 RID: 115504 RVA: 0x00417AD3 File Offset: 0x00415CD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseSpecialCellPbData other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C331 RID: 115505 RVA: 0x00417B04 File Offset: 0x00415D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0601C332 RID: 115506 RVA: 0x00417B43 File Offset: 0x00415D43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C333 RID: 115507 RVA: 0x00417B50 File Offset: 0x00415D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C334 RID: 115508 RVA: 0x00417B59 File Offset: 0x00415D59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C335 RID: 115509 RVA: 0x00417B8C File Offset: 0x00415D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0601C336 RID: 115510 RVA: 0x00417BCA File Offset: 0x00415DCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseSpecialCellPbData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C337 RID: 115511 RVA: 0x00417BFB File Offset: 0x00415DFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C338 RID: 115512 RVA: 0x00417C04 File Offset: 0x00415E04
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A30D RID: 41741
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A30E RID: 41742
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x0400A30F RID: 41743
		private int configId_;
	}
}
