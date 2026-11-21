using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D66 RID: 3430
	public sealed class PlacementItemPb : IMessage<PlacementItemPb>, IMessage, IEquatable<PlacementItemPb>, IDeepCloneable<PlacementItemPb>, IBufferMessage
	{
		// Token: 0x0601283E RID: 75838 RVA: 0x002B3E8D File Offset: 0x002B208D
		[NullableContext(1)]
		public static PlacementItemPb Create()
		{
			return new PlacementItemPb();
		}

		// Token: 0x17003D5F RID: 15711
		// (get) Token: 0x0601283F RID: 75839 RVA: 0x002B3E94 File Offset: 0x002B2094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D60 RID: 15712
		// (get) Token: 0x06012840 RID: 75840 RVA: 0x002B3E97 File Offset: 0x002B2097
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlacementItemPb.Descriptor;
			}
		}

		// Token: 0x06012841 RID: 75841 RVA: 0x002B3E9E File Offset: 0x002B209E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlacementItemPb()
		{
		}

		// Token: 0x06012842 RID: 75842 RVA: 0x002B3EA6 File Offset: 0x002B20A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlacementItemPb(PlacementItemPb other) : this()
		{
			this.locatedBoardEntityConfigId_ = other.locatedBoardEntityConfigId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012843 RID: 75843 RVA: 0x002B3ECB File Offset: 0x002B20CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlacementItemPb Clone()
		{
			return new PlacementItemPb(this);
		}

		// Token: 0x17003D61 RID: 15713
		// (get) Token: 0x06012844 RID: 75844 RVA: 0x002B3ED3 File Offset: 0x002B20D3
		// (set) Token: 0x06012845 RID: 75845 RVA: 0x002B3EDB File Offset: 0x002B20DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LocatedBoardEntityConfigId
		{
			get
			{
				return this.locatedBoardEntityConfigId_;
			}
			set
			{
				this.locatedBoardEntityConfigId_ = value;
			}
		}

		// Token: 0x06012846 RID: 75846 RVA: 0x002B3EE4 File Offset: 0x002B20E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlacementItemPb);
		}

		// Token: 0x06012847 RID: 75847 RVA: 0x002B3EF2 File Offset: 0x002B20F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlacementItemPb other)
		{
			return other != null && (other == this || (this.LocatedBoardEntityConfigId == other.LocatedBoardEntityConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012848 RID: 75848 RVA: 0x002B3F20 File Offset: 0x002B2120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LocatedBoardEntityConfigId != 0)
			{
				num ^= this.LocatedBoardEntityConfigId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012849 RID: 75849 RVA: 0x002B3F5F File Offset: 0x002B215F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601284A RID: 75850 RVA: 0x002B3F6C File Offset: 0x002B216C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601284B RID: 75851 RVA: 0x002B3F75 File Offset: 0x002B2175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LocatedBoardEntityConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LocatedBoardEntityConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601284C RID: 75852 RVA: 0x002B3FA8 File Offset: 0x002B21A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LocatedBoardEntityConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LocatedBoardEntityConfigId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601284D RID: 75853 RVA: 0x002B3FE6 File Offset: 0x002B21E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlacementItemPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LocatedBoardEntityConfigId != 0)
			{
				this.LocatedBoardEntityConfigId = other.LocatedBoardEntityConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601284E RID: 75854 RVA: 0x002B4017 File Offset: 0x002B2217
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601284F RID: 75855 RVA: 0x002B4020 File Offset: 0x002B2220
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
					this.LocatedBoardEntityConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400736E RID: 29550
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400736F RID: 29551
		public const int LocatedBoardEntityConfigIdFieldNumber = 1;

		// Token: 0x04007370 RID: 29552
		private int locatedBoardEntityConfigId_;
	}
}
