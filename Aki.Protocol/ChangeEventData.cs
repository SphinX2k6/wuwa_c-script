using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200024F RID: 591
	public sealed class ChangeEventData : IMessage<ChangeEventData>, IMessage, IEquatable<ChangeEventData>, IDeepCloneable<ChangeEventData>, IBufferMessage
	{
		// Token: 0x06003F09 RID: 16137 RVA: 0x0009B445 File Offset: 0x00099645
		[NullableContext(1)]
		public static ChangeEventData Create()
		{
			return new ChangeEventData();
		}

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x06003F0A RID: 16138 RVA: 0x0009B44C File Offset: 0x0009964C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChangeEventData> Parser
		{
			get
			{
				return ChangeEventData._parser;
			}
		}

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x06003F0B RID: 16139 RVA: 0x0009B453 File Offset: 0x00099653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x06003F0C RID: 16140 RVA: 0x0009B456 File Offset: 0x00099656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeEventData.Descriptor;
			}
		}

		// Token: 0x06003F0D RID: 16141 RVA: 0x0009B45D File Offset: 0x0009965D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeEventData()
		{
		}

		// Token: 0x06003F0E RID: 16142 RVA: 0x0009B468 File Offset: 0x00099668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeEventData(ChangeEventData other) : this()
		{
			this.index_ = other.index_;
			this.rogueResGridData_ = ((other.rogueResGridData_ != null) ? other.rogueResGridData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003F0F RID: 16143 RVA: 0x0009B4B4 File Offset: 0x000996B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeEventData Clone()
		{
			return new ChangeEventData(this);
		}

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x06003F10 RID: 16144 RVA: 0x0009B4BC File Offset: 0x000996BC
		// (set) Token: 0x06003F11 RID: 16145 RVA: 0x0009B4C4 File Offset: 0x000996C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x06003F12 RID: 16146 RVA: 0x0009B4CD File Offset: 0x000996CD
		// (set) Token: 0x06003F13 RID: 16147 RVA: 0x0009B4D5 File Offset: 0x000996D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGridData RogueResGridData
		{
			get
			{
				return this.rogueResGridData_;
			}
			set
			{
				this.rogueResGridData_ = value;
			}
		}

		// Token: 0x06003F14 RID: 16148 RVA: 0x0009B4DE File Offset: 0x000996DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeEventData);
		}

		// Token: 0x06003F15 RID: 16149 RVA: 0x0009B4EC File Offset: 0x000996EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeEventData other)
		{
			return other != null && (other == this || (this.Index == other.Index && object.Equals(this.RogueResGridData, other.RogueResGridData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003F16 RID: 16150 RVA: 0x0009B53C File Offset: 0x0009973C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.rogueResGridData_ != null)
			{
				num ^= this.RogueResGridData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003F17 RID: 16151 RVA: 0x0009B591 File Offset: 0x00099791
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003F18 RID: 16152 RVA: 0x0009B59E File Offset: 0x0009979E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003F19 RID: 16153 RVA: 0x0009B5A8 File Offset: 0x000997A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Index);
			}
			if (this.rogueResGridData_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.RogueResGridData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003F1A RID: 16154 RVA: 0x0009B600 File Offset: 0x00099800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this.rogueResGridData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueResGridData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003F1B RID: 16155 RVA: 0x0009B658 File Offset: 0x00099858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeEventData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			if (other.rogueResGridData_ != null)
			{
				if (this.rogueResGridData_ == null)
				{
					this.RogueResGridData = new RogueResGridData();
				}
				this.RogueResGridData.MergeFrom(other.RogueResGridData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003F1C RID: 16156 RVA: 0x0009B6C0 File Offset: 0x000998C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003F1D RID: 16157 RVA: 0x0009B6CC File Offset: 0x000998CC
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.rogueResGridData_ == null)
						{
							this.RogueResGridData = new RogueResGridData();
						}
						input.ReadMessage(this.RogueResGridData);
					}
				}
				else
				{
					this.Index = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002D06 RID: 11526
		private static readonly MessageParser<ChangeEventData> _parser = new MessageParser<ChangeEventData>(() => new ChangeEventData());

		// Token: 0x04002D07 RID: 11527
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D08 RID: 11528
		public const int IndexFieldNumber = 1;

		// Token: 0x04002D09 RID: 11529
		private int index_;

		// Token: 0x04002D0A RID: 11530
		public const int RogueResGridDataFieldNumber = 2;

		// Token: 0x04002D0B RID: 11531
		private RogueResGridData rogueResGridData_;
	}
}
