using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A3D RID: 2621
	public sealed class MotorFightCollectItemInfo : IMessage<MotorFightCollectItemInfo>, IMessage, IEquatable<MotorFightCollectItemInfo>, IDeepCloneable<MotorFightCollectItemInfo>, IBufferMessage
	{
		// Token: 0x0600E4DB RID: 58587 RVA: 0x0021769F File Offset: 0x0021589F
		[NullableContext(1)]
		public static MotorFightCollectItemInfo Create()
		{
			return new MotorFightCollectItemInfo();
		}

		// Token: 0x17002E66 RID: 11878
		// (get) Token: 0x0600E4DC RID: 58588 RVA: 0x002176A6 File Offset: 0x002158A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorFightCollectItemInfo> Parser
		{
			get
			{
				return MotorFightCollectItemInfo._parser;
			}
		}

		// Token: 0x17002E67 RID: 11879
		// (get) Token: 0x0600E4DD RID: 58589 RVA: 0x002176AD File Offset: 0x002158AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E68 RID: 11880
		// (get) Token: 0x0600E4DE RID: 58590 RVA: 0x002176B0 File Offset: 0x002158B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightCollectItemInfo.Descriptor;
			}
		}

		// Token: 0x0600E4DF RID: 58591 RVA: 0x002176B7 File Offset: 0x002158B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightCollectItemInfo()
		{
		}

		// Token: 0x0600E4E0 RID: 58592 RVA: 0x002176BF File Offset: 0x002158BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightCollectItemInfo(MotorFightCollectItemInfo other) : this()
		{
			this.itemId_ = other.itemId_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E4E1 RID: 58593 RVA: 0x002176F0 File Offset: 0x002158F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightCollectItemInfo Clone()
		{
			return new MotorFightCollectItemInfo(this);
		}

		// Token: 0x17002E69 RID: 11881
		// (get) Token: 0x0600E4E2 RID: 58594 RVA: 0x002176F8 File Offset: 0x002158F8
		// (set) Token: 0x0600E4E3 RID: 58595 RVA: 0x00217700 File Offset: 0x00215900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x17002E6A RID: 11882
		// (get) Token: 0x0600E4E4 RID: 58596 RVA: 0x00217709 File Offset: 0x00215909
		// (set) Token: 0x0600E4E5 RID: 58597 RVA: 0x00217711 File Offset: 0x00215911
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x0600E4E6 RID: 58598 RVA: 0x0021771A File Offset: 0x0021591A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightCollectItemInfo);
		}

		// Token: 0x0600E4E7 RID: 58599 RVA: 0x00217728 File Offset: 0x00215928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightCollectItemInfo other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E4E8 RID: 58600 RVA: 0x00217768 File Offset: 0x00215968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E4E9 RID: 58601 RVA: 0x002177C0 File Offset: 0x002159C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E4EA RID: 58602 RVA: 0x002177CD File Offset: 0x002159CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E4EB RID: 58603 RVA: 0x002177D8 File Offset: 0x002159D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Count);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E4EC RID: 58604 RVA: 0x00217830 File Offset: 0x00215A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E4ED RID: 58605 RVA: 0x00217888 File Offset: 0x00215A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightCollectItemInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E4EE RID: 58606 RVA: 0x002178D8 File Offset: 0x00215AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E4EF RID: 58607 RVA: 0x002178E4 File Offset: 0x00215AE4
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
						this.Count = input.ReadInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005D98 RID: 23960
		private static readonly MessageParser<MotorFightCollectItemInfo> _parser = new MessageParser<MotorFightCollectItemInfo>(() => new MotorFightCollectItemInfo());

		// Token: 0x04005D99 RID: 23961
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D9A RID: 23962
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04005D9B RID: 23963
		private int itemId_;

		// Token: 0x04005D9C RID: 23964
		public const int CountFieldNumber = 2;

		// Token: 0x04005D9D RID: 23965
		private int count_;
	}
}
