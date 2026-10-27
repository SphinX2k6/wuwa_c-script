using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001450 RID: 5200
	public sealed class TrapDefenseSpecialCellPbData : IMessage<TrapDefenseSpecialCellPbData>, IMessage, IEquatable<TrapDefenseSpecialCellPbData>, IDeepCloneable<TrapDefenseSpecialCellPbData>, IBufferMessage
	{
		// Token: 0x0601B89C RID: 112796 RVA: 0x003FC79A File Offset: 0x003FA99A
		[NullableContext(1)]
		public static TrapDefenseSpecialCellPbData Create()
		{
			return new TrapDefenseSpecialCellPbData();
		}

		// Token: 0x17005CDA RID: 23770
		// (get) Token: 0x0601B89D RID: 112797 RVA: 0x003FC7A1 File Offset: 0x003FA9A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005CDB RID: 23771
		// (get) Token: 0x0601B89E RID: 112798 RVA: 0x003FC7A4 File Offset: 0x003FA9A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseSpecialCellPbData.Descriptor;
			}
		}

		// Token: 0x0601B89F RID: 112799 RVA: 0x003FC7AB File Offset: 0x003FA9AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSpecialCellPbData()
		{
		}

		// Token: 0x0601B8A0 RID: 112800 RVA: 0x003FC7B3 File Offset: 0x003FA9B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSpecialCellPbData(TrapDefenseSpecialCellPbData other) : this()
		{
			this.configId_ = other.configId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B8A1 RID: 112801 RVA: 0x003FC7D8 File Offset: 0x003FA9D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSpecialCellPbData Clone()
		{
			return new TrapDefenseSpecialCellPbData(this);
		}

		// Token: 0x17005CDC RID: 23772
		// (get) Token: 0x0601B8A2 RID: 112802 RVA: 0x003FC7E0 File Offset: 0x003FA9E0
		// (set) Token: 0x0601B8A3 RID: 112803 RVA: 0x003FC7E8 File Offset: 0x003FA9E8
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

		// Token: 0x0601B8A4 RID: 112804 RVA: 0x003FC7F1 File Offset: 0x003FA9F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseSpecialCellPbData);
		}

		// Token: 0x0601B8A5 RID: 112805 RVA: 0x003FC7FF File Offset: 0x003FA9FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseSpecialCellPbData other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B8A6 RID: 112806 RVA: 0x003FC830 File Offset: 0x003FAA30
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

		// Token: 0x0601B8A7 RID: 112807 RVA: 0x003FC86F File Offset: 0x003FAA6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B8A8 RID: 112808 RVA: 0x003FC87C File Offset: 0x003FAA7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B8A9 RID: 112809 RVA: 0x003FC885 File Offset: 0x003FAA85
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

		// Token: 0x0601B8AA RID: 112810 RVA: 0x003FC8B8 File Offset: 0x003FAAB8
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

		// Token: 0x0601B8AB RID: 112811 RVA: 0x003FC8F6 File Offset: 0x003FAAF6
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

		// Token: 0x0601B8AC RID: 112812 RVA: 0x003FC927 File Offset: 0x003FAB27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B8AD RID: 112813 RVA: 0x003FC930 File Offset: 0x003FAB30
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

		// Token: 0x04009EC6 RID: 40646
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009EC7 RID: 40647
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x04009EC8 RID: 40648
		private int configId_;
	}
}
