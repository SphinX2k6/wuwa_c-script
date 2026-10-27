using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001423 RID: 5155
	[NetMessage(EMessageId.TrapDefenseEntityDataChangeNotify)]
	public sealed class TrapDefenseEntityDataChangeNotify : IMessage<TrapDefenseEntityDataChangeNotify>, IMessage, IEquatable<TrapDefenseEntityDataChangeNotify>, IDeepCloneable<TrapDefenseEntityDataChangeNotify>, IBufferMessage
	{
		// Token: 0x0601B51F RID: 111903 RVA: 0x003F5529 File Offset: 0x003F3729
		[NullableContext(1)]
		public static TrapDefenseEntityDataChangeNotify Create()
		{
			return new TrapDefenseEntityDataChangeNotify();
		}

		// Token: 0x17005C26 RID: 23590
		// (get) Token: 0x0601B520 RID: 111904 RVA: 0x003F5530 File Offset: 0x003F3730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C27 RID: 23591
		// (get) Token: 0x0601B521 RID: 111905 RVA: 0x003F5533 File Offset: 0x003F3733
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseEntityDataChangeNotify.Descriptor;
			}
		}

		// Token: 0x0601B522 RID: 111906 RVA: 0x003F553A File Offset: 0x003F373A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseEntityDataChangeNotify()
		{
		}

		// Token: 0x0601B523 RID: 111907 RVA: 0x003F5544 File Offset: 0x003F3744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseEntityDataChangeNotify(TrapDefenseEntityDataChangeNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.newComponentData_ = ((other.newComponentData_ != null) ? other.newComponentData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B524 RID: 111908 RVA: 0x003F5590 File Offset: 0x003F3790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseEntityDataChangeNotify Clone()
		{
			return new TrapDefenseEntityDataChangeNotify(this);
		}

		// Token: 0x17005C28 RID: 23592
		// (get) Token: 0x0601B525 RID: 111909 RVA: 0x003F5598 File Offset: 0x003F3798
		// (set) Token: 0x0601B526 RID: 111910 RVA: 0x003F55A0 File Offset: 0x003F37A0
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

		// Token: 0x17005C29 RID: 23593
		// (get) Token: 0x0601B527 RID: 111911 RVA: 0x003F55A9 File Offset: 0x003F37A9
		// (set) Token: 0x0601B528 RID: 111912 RVA: 0x003F55B1 File Offset: 0x003F37B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseComponentPb NewComponentData
		{
			get
			{
				return this.newComponentData_;
			}
			set
			{
				this.newComponentData_ = value;
			}
		}

		// Token: 0x0601B529 RID: 111913 RVA: 0x003F55BA File Offset: 0x003F37BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseEntityDataChangeNotify);
		}

		// Token: 0x0601B52A RID: 111914 RVA: 0x003F55C8 File Offset: 0x003F37C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseEntityDataChangeNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.NewComponentData, other.NewComponentData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B52B RID: 111915 RVA: 0x003F5618 File Offset: 0x003F3818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.newComponentData_ != null)
			{
				num ^= this.NewComponentData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B52C RID: 111916 RVA: 0x003F566D File Offset: 0x003F386D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B52D RID: 111917 RVA: 0x003F567A File Offset: 0x003F387A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B52E RID: 111918 RVA: 0x003F5684 File Offset: 0x003F3884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.newComponentData_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.NewComponentData);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B52F RID: 111919 RVA: 0x003F56E0 File Offset: 0x003F38E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.newComponentData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NewComponentData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B530 RID: 111920 RVA: 0x003F5738 File Offset: 0x003F3938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseEntityDataChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.newComponentData_ != null)
			{
				if (this.newComponentData_ == null)
				{
					this.NewComponentData = new TrapDefenseComponentPb();
				}
				this.NewComponentData.MergeFrom(other.NewComponentData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B531 RID: 111921 RVA: 0x003F57A0 File Offset: 0x003F39A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B532 RID: 111922 RVA: 0x003F57AC File Offset: 0x003F39AC
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
				if (num != 34U)
				{
					if (num != 72U)
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
					if (this.newComponentData_ == null)
					{
						this.NewComponentData = new TrapDefenseComponentPb();
					}
					input.ReadMessage(this.NewComponentData);
				}
			}
		}

		// Token: 0x04009DE0 RID: 40416
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009DE1 RID: 40417
		public const int EntityIdFieldNumber = 9;

		// Token: 0x04009DE2 RID: 40418
		private long entityId_;

		// Token: 0x04009DE3 RID: 40419
		public const int NewComponentDataFieldNumber = 4;

		// Token: 0x04009DE4 RID: 40420
		private TrapDefenseComponentPb newComponentData_;
	}
}
