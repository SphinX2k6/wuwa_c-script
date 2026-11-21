using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200125E RID: 4702
	[NetMessage(EMessageId.SimpleCombatEntityBuffLayerCountNotify)]
	public sealed class SimpleCombatEntityBuffLayerCountNotify : IMessage<SimpleCombatEntityBuffLayerCountNotify>, IMessage, IEquatable<SimpleCombatEntityBuffLayerCountNotify>, IDeepCloneable<SimpleCombatEntityBuffLayerCountNotify>, IBufferMessage
	{
		// Token: 0x06019193 RID: 102803 RVA: 0x003A886F File Offset: 0x003A6A6F
		[NullableContext(1)]
		public static SimpleCombatEntityBuffLayerCountNotify Create()
		{
			return new SimpleCombatEntityBuffLayerCountNotify();
		}

		// Token: 0x170054D0 RID: 21712
		// (get) Token: 0x06019194 RID: 102804 RVA: 0x003A8876 File Offset: 0x003A6A76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170054D1 RID: 21713
		// (get) Token: 0x06019195 RID: 102805 RVA: 0x003A8879 File Offset: 0x003A6A79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SimpleCombatEntityBuffLayerCountNotify.Descriptor;
			}
		}

		// Token: 0x06019196 RID: 102806 RVA: 0x003A8880 File Offset: 0x003A6A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntityBuffLayerCountNotify()
		{
		}

		// Token: 0x06019197 RID: 102807 RVA: 0x003A8888 File Offset: 0x003A6A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntityBuffLayerCountNotify(SimpleCombatEntityBuffLayerCountNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.layerCount_ = other.layerCount_;
			this.buffId_ = other.buffId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019198 RID: 102808 RVA: 0x003A88C5 File Offset: 0x003A6AC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntityBuffLayerCountNotify Clone()
		{
			return new SimpleCombatEntityBuffLayerCountNotify(this);
		}

		// Token: 0x170054D2 RID: 21714
		// (get) Token: 0x06019199 RID: 102809 RVA: 0x003A88CD File Offset: 0x003A6ACD
		// (set) Token: 0x0601919A RID: 102810 RVA: 0x003A88D5 File Offset: 0x003A6AD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x170054D3 RID: 21715
		// (get) Token: 0x0601919B RID: 102811 RVA: 0x003A88DE File Offset: 0x003A6ADE
		// (set) Token: 0x0601919C RID: 102812 RVA: 0x003A88E6 File Offset: 0x003A6AE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LayerCount
		{
			get
			{
				return this.layerCount_;
			}
			set
			{
				this.layerCount_ = value;
			}
		}

		// Token: 0x170054D4 RID: 21716
		// (get) Token: 0x0601919D RID: 102813 RVA: 0x003A88EF File Offset: 0x003A6AEF
		// (set) Token: 0x0601919E RID: 102814 RVA: 0x003A88F7 File Offset: 0x003A6AF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BuffId
		{
			get
			{
				return this.buffId_;
			}
			set
			{
				this.buffId_ = value;
			}
		}

		// Token: 0x0601919F RID: 102815 RVA: 0x003A8900 File Offset: 0x003A6B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SimpleCombatEntityBuffLayerCountNotify);
		}

		// Token: 0x060191A0 RID: 102816 RVA: 0x003A8910 File Offset: 0x003A6B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SimpleCombatEntityBuffLayerCountNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.LayerCount == other.LayerCount && this.BuffId == other.BuffId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060191A1 RID: 102817 RVA: 0x003A896C File Offset: 0x003A6B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.LayerCount != 0)
			{
				num ^= this.LayerCount.GetHashCode();
			}
			if (this.BuffId != 0)
			{
				num ^= this.BuffId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060191A2 RID: 102818 RVA: 0x003A89DD File Offset: 0x003A6BDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060191A3 RID: 102819 RVA: 0x003A89EA File Offset: 0x003A6BEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060191A4 RID: 102820 RVA: 0x003A89F4 File Offset: 0x003A6BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LayerCount != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LayerCount);
			}
			if (this.BuffId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.BuffId);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060191A5 RID: 102821 RVA: 0x003A8A68 File Offset: 0x003A6C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.LayerCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LayerCount);
			}
			if (this.BuffId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BuffId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060191A6 RID: 102822 RVA: 0x003A8AD8 File Offset: 0x003A6CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SimpleCombatEntityBuffLayerCountNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.LayerCount != 0)
			{
				this.LayerCount = other.LayerCount;
			}
			if (other.BuffId != 0)
			{
				this.BuffId = other.BuffId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060191A7 RID: 102823 RVA: 0x003A8B3C File Offset: 0x003A6D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060191A8 RID: 102824 RVA: 0x003A8B48 File Offset: 0x003A6D48
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
					if (num != 40U)
					{
						if (num != 64U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.EntityId = input.ReadInt64();
						}
					}
					else
					{
						this.BuffId = input.ReadInt32();
					}
				}
				else
				{
					this.LayerCount = input.ReadInt32();
				}
			}
		}

		// Token: 0x040094AC RID: 38060
		private UnknownFieldSet _unknownFields;

		// Token: 0x040094AD RID: 38061
		public const int EntityIdFieldNumber = 8;

		// Token: 0x040094AE RID: 38062
		private long entityId_;

		// Token: 0x040094AF RID: 38063
		public const int LayerCountFieldNumber = 1;

		// Token: 0x040094B0 RID: 38064
		private int layerCount_;

		// Token: 0x040094B1 RID: 38065
		public const int BuffIdFieldNumber = 5;

		// Token: 0x040094B2 RID: 38066
		private int buffId_;
	}
}
