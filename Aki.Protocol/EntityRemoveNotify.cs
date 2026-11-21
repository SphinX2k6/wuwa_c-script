using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004A4 RID: 1188
	[NetMessage(EMessageId.EntityRemoveNotify)]
	public sealed class EntityRemoveNotify : IMessage<EntityRemoveNotify>, IMessage, IEquatable<EntityRemoveNotify>, IDeepCloneable<EntityRemoveNotify>, IBufferMessage
	{
		// Token: 0x060071B6 RID: 29110 RVA: 0x00117917 File Offset: 0x00115B17
		[NullableContext(1)]
		public static EntityRemoveNotify Create()
		{
			return new EntityRemoveNotify();
		}

		// Token: 0x170015F7 RID: 5623
		// (get) Token: 0x060071B7 RID: 29111 RVA: 0x0011791E File Offset: 0x00115B1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015F8 RID: 5624
		// (get) Token: 0x060071B8 RID: 29112 RVA: 0x00117921 File Offset: 0x00115B21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityRemoveNotify.Descriptor;
			}
		}

		// Token: 0x060071B9 RID: 29113 RVA: 0x00117928 File Offset: 0x00115B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRemoveNotify()
		{
		}

		// Token: 0x060071BA RID: 29114 RVA: 0x0011793B File Offset: 0x00115B3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRemoveNotify(EntityRemoveNotify other) : this()
		{
			this.removeInfos_ = other.removeInfos_.Clone();
			this.isRemove_ = other.isRemove_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060071BB RID: 29115 RVA: 0x00117971 File Offset: 0x00115B71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityRemoveNotify Clone()
		{
			return new EntityRemoveNotify(this);
		}

		// Token: 0x170015F9 RID: 5625
		// (get) Token: 0x060071BC RID: 29116 RVA: 0x00117979 File Offset: 0x00115B79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EntityRemoveInfo> RemoveInfos
		{
			get
			{
				return this.removeInfos_;
			}
		}

		// Token: 0x170015FA RID: 5626
		// (get) Token: 0x060071BD RID: 29117 RVA: 0x00117981 File Offset: 0x00115B81
		// (set) Token: 0x060071BE RID: 29118 RVA: 0x00117989 File Offset: 0x00115B89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsRemove
		{
			get
			{
				return this.isRemove_;
			}
			set
			{
				this.isRemove_ = value;
			}
		}

		// Token: 0x060071BF RID: 29119 RVA: 0x00117992 File Offset: 0x00115B92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityRemoveNotify);
		}

		// Token: 0x060071C0 RID: 29120 RVA: 0x001179A0 File Offset: 0x00115BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityRemoveNotify other)
		{
			return other != null && (other == this || (this.removeInfos_.Equals(other.removeInfos_) && this.IsRemove == other.IsRemove && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060071C1 RID: 29121 RVA: 0x001179F0 File Offset: 0x00115BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.removeInfos_.GetHashCode();
			if (this.IsRemove)
			{
				num ^= this.IsRemove.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060071C2 RID: 29122 RVA: 0x00117A3D File Offset: 0x00115C3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060071C3 RID: 29123 RVA: 0x00117A4A File Offset: 0x00115C4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060071C4 RID: 29124 RVA: 0x00117A54 File Offset: 0x00115C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsRemove)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.IsRemove);
			}
			this.removeInfos_.WriteTo(ref output, EntityRemoveNotify._repeated_removeInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060071C5 RID: 29125 RVA: 0x00117AA4 File Offset: 0x00115CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.removeInfos_.CalculateSize(EntityRemoveNotify._repeated_removeInfos_codec);
			if (this.IsRemove)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060071C6 RID: 29126 RVA: 0x00117AEC File Offset: 0x00115CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityRemoveNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.removeInfos_.Add(other.removeInfos_);
			if (other.IsRemove)
			{
				this.IsRemove = other.IsRemove;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060071C7 RID: 29127 RVA: 0x00117B39 File Offset: 0x00115D39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060071C8 RID: 29128 RVA: 0x00117B44 File Offset: 0x00115D44
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
				if (num != 80U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.removeInfos_.AddEntriesFrom(ref input, EntityRemoveNotify._repeated_removeInfos_codec);
					}
				}
				else
				{
					this.IsRemove = input.ReadBool();
				}
			}
		}

		// Token: 0x04003D05 RID: 15621
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D06 RID: 15622
		public const int RemoveInfosFieldNumber = 14;

		// Token: 0x04003D07 RID: 15623
		private static readonly FieldCodec<EntityRemoveInfo> _repeated_removeInfos_codec = FieldCodec.ForMessage<EntityRemoveInfo>(114U, EntityRemoveInfo.Parser);

		// Token: 0x04003D08 RID: 15624
		private readonly RepeatedField<EntityRemoveInfo> removeInfos_ = new RepeatedField<EntityRemoveInfo>();

		// Token: 0x04003D09 RID: 15625
		public const int IsRemoveFieldNumber = 10;

		// Token: 0x04003D0A RID: 15626
		private bool isRemove_;
	}
}
